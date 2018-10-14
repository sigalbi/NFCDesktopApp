using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppLogic;
using Bunifu.Core;

namespace SmartChip
{
    public partial class LoginForm : Form
    {
        AppLogicAPI logic;
        public LoginForm()
        {
            logic = new AppLogicAPI();
            InitializeComponent();
            PasswordtextBox.PasswordChar = '*';
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            string UserToken;
            try
            {
                UserToken = logic.LoginCheck(EmailtextBox.Text, PasswordtextBox.Text);
                UserMainForm Umf = new UserMainForm(UserToken);
                this.Hide();
                Umf.ShowDialog();
                this.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm RegForm = new RegisterForm(this);
            this.Hide();
            RegForm.ShowDialog();
        }

        private void ForgottPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm Fpf = new ForgotPasswordForm();
            Fpf.ShowDialog();
        }
    }
}
