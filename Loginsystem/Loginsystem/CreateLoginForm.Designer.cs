﻿namespace Loginsystem
{
    partial class CreateLoginForm
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
            this.textBoxCreatePassword = new System.Windows.Forms.TextBox();
            this.textBoxCreateUsername = new System.Windows.Forms.TextBox();
            this.textBoxCreateEMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSendToDataBase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCreatePassword
            // 
            this.textBoxCreatePassword.Location = new System.Drawing.Point(134, 39);
            this.textBoxCreatePassword.Name = "textBoxCreatePassword";
            this.textBoxCreatePassword.Size = new System.Drawing.Size(138, 20);
            this.textBoxCreatePassword.TabIndex = 1;
            // 
            // textBoxCreateUsername
            // 
            this.textBoxCreateUsername.Location = new System.Drawing.Point(134, 13);
            this.textBoxCreateUsername.Name = "textBoxCreateUsername";
            this.textBoxCreateUsername.Size = new System.Drawing.Size(138, 20);
            this.textBoxCreateUsername.TabIndex = 0;
            // 
            // textBoxCreateEMail
            // 
            this.textBoxCreateEMail.Location = new System.Drawing.Point(135, 65);
            this.textBoxCreateEMail.Name = "textBoxCreateEMail";
            this.textBoxCreateEMail.Size = new System.Drawing.Size(137, 20);
            this.textBoxCreateEMail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Passwort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-Mail";
            // 
            // buttonSendToDataBase
            // 
            this.buttonSendToDataBase.Location = new System.Drawing.Point(135, 91);
            this.buttonSendToDataBase.Name = "buttonSendToDataBase";
            this.buttonSendToDataBase.Size = new System.Drawing.Size(137, 23);
            this.buttonSendToDataBase.TabIndex = 3;
            this.buttonSendToDataBase.Text = "Konto erstellen!";
            this.buttonSendToDataBase.UseVisualStyleBackColor = true;
            this.buttonSendToDataBase.Click += new System.EventHandler(this.buttonSendToDataBase_Click);
            // 
            // CreateLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.buttonSendToDataBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCreateEMail);
            this.Controls.Add(this.textBoxCreateUsername);
            this.Controls.Add(this.textBoxCreatePassword);
            this.Name = "CreateLoginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCreatePassword;
        private System.Windows.Forms.TextBox textBoxCreateUsername;
        private System.Windows.Forms.TextBox textBoxCreateEMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSendToDataBase;
    }
}