using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppLogic;
namespace SmartChip
{
    public partial class ForgotPasswordForm : Form
    {
        AppLogicAPI logic;
        public ForgotPasswordForm()
        {
            InitializeComponent();
            logic = new AppLogicAPI();
        }

        private void SendPasswordButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                try
                {
                    logic.SendForgotPassword(EmailTextBox.Text);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Somthing went wrong\nTry again");
                }
            }
            MessageBox.Show("Password Sent");
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
