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
    public partial class ChangePasswordForm : Form
    {
        AppLogicAPI logic;
        string userToken;

        public ChangePasswordForm(string UserToken)
        {
            InitializeComponent();
            logic = new AppLogicAPI();
            OldPasswordTextBox.PasswordChar = '*';
            NewPasswordTextBox.PasswordChar = '*';
            userToken = UserToken;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DoneChipButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Change Password?", "Are you sure ?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    logic.ChangePasswredInDataB(OldPasswordTextBox.Text,NewPasswordTextBox.Text, userToken);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            this.Hide();
            this.Close();
        }
    }
}
