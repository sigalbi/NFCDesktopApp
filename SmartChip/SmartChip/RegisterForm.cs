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
    public partial class RegisterForm : Form
    {
        AppLogicAPI logic;
        LoginForm loginForm;

        public RegisterForm(LoginForm _loginForm)
        {
            loginForm = _loginForm;
            logic = new AppLogicAPI();
            InitializeComponent();
            PasswordTextbox.PasswordChar ='*';
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UploadPhtoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images only. |*.jpg; *.jpeg; *.png; *gif;";
            DialogResult result = ofd.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                PhotUploadPictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }
        private void DoneButton_Click(object sender, EventArgs e)
        {
            string token;

            if (!(string.IsNullOrWhiteSpace(UserNameTextbox.Text)) && !(string.IsNullOrWhiteSpace(PasswordTextbox.Text)) && !(string.IsNullOrWhiteSpace(PhoneNumberTextbox.Text)) && !(string.IsNullOrWhiteSpace(EmailTextbox.Text)))
            {
                try
                {
                    token = logic.RegisterCheck(UserNameTextbox.Text, EmailTextbox.Text, PhoneNumberTextbox.Text, PasswordTextbox.Text);
                    UserMainForm umf = new UserMainForm(token);
                    this.Hide();
                    umf.ShowDialog();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
            this.Close();
        }
    }
}
