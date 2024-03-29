﻿using Microsoft.Extensions.Options;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DGLI.Bank.Forms;

public partial class LoginForm : Form
{
    private readonly IServiceProvider _serviceProvider;
    private readonly Settings _options;

    public LoginForm(IServiceProvider serviceProvider, IOptions<Settings> options)
    {
        _serviceProvider = serviceProvider;
        _options = options.Value;
        InitializeComponent();
    }
    private void login_Resize(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }
    protected override void WndProc(ref Message m)
    {
        // Prevent form from resizing if user attempts to left click
        // on title bar of form and drag it
        int WM_NCLBUTTONDOWN = 0xA1;
        int WM_SYSCOMMAND = 0x112;
        int HTCAPTION = 0x02;
        int SC_MOVE = 0xF010;

        if (m.Msg == WM_SYSCOMMAND && m.WParam.ToInt32() == SC_MOVE)
            return;

        if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HTCAPTION)
            return;

        base.WndProc(ref m);
    }
    private void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtPassword.Text.Equals(_options.Password, StringComparison.OrdinalIgnoreCase))
        {
            Hide();
            var transactionForm = Application.OpenForms.Cast<Form>().SingleOrDefault(form => form.Name == "TransactionsForm");
            if (transactionForm == null)
            {
                transactionForm = (TransactionsForm)_serviceProvider.GetService(typeof(TransactionsForm));
                transactionForm.Closed += (s, args) => this.Close();
            }
            transactionForm.Show();
        }
        else
        {
            var incorrectPasswordForm = Application.OpenForms.Cast<Form>().SingleOrDefault(form => form.Name == "IncorrectPasswordForm");
            if (incorrectPasswordForm == null) incorrectPasswordForm = (IncorrectPasswordForm)_serviceProvider.GetService(typeof(IncorrectPasswordForm));
            incorrectPasswordForm.ShowDialog();
        }
        txtPassword.Text = string.Empty;
    }

    private void OnClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}
