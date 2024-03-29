﻿
using System.Windows.Forms;

namespace DGLI.Bank.Forms;

partial class LoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.btnLogin = new System.Windows.Forms.Button();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.panel1 = new System.Windows.Forms.Panel();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.label1.Location = new System.Drawing.Point(420, 326);
        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(126, 29);
        this.label1.TabIndex = 0;
        this.label1.Text = "Password:";
        // 
        // txtPassword
        // 
        this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtPassword.Location = new System.Drawing.Point(572, 323);
        this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.Size = new System.Drawing.Size(161, 35);
        this.txtPassword.TabIndex = 1;
        this.txtPassword.UseSystemPasswordChar = true;
        // 
        // btnLogin
        // 
        this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.btnLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
        this.btnLogin.FlatAppearance.BorderSize = 0;
        this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLogin.Location = new System.Drawing.Point(673, 376);
        this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(60, 25);
        this.btnLogin.TabIndex = 2;
        this.btnLogin.Text = "Login >";
        this.btnLogin.UseVisualStyleBackColor = true;
        this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        // 
        // pictureBox1
        // 
        this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.pictureBox1.Image = global::DGLI.Bank.Properties.Resources.pictureBox1_Image;
        this.pictureBox1.Location = new System.Drawing.Point(868, 4);
        this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(298, 101);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pictureBox1.TabIndex = 3;
        this.pictureBox1.TabStop = false;
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.pictureBox1);
        this.panel1.Controls.Add(this.btnLogin);
        this.panel1.Controls.Add(this.txtPassword);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Margin = new System.Windows.Forms.Padding(4);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(1171, 739);
        this.panel1.TabIndex = 4;
        // 
        // LoginForm
        // 
        this.AcceptButton = this.btnLogin;
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(1171, 739);
        this.ControlBox = false;
        this.Controls.Add(this.panel1);
        this.Margin = new System.Windows.Forms.Padding(4);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "LoginForm";
        this.Text = "DGLI Bank";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
        this.Resize += new System.EventHandler(this.login_Resize);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panel1;
}
