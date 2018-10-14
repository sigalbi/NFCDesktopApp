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
    public partial class UpdateUserForm : Form
    {
        string UserToken;
        ChipTableForm ctf;
        AppLogicAPI logic;

        public UpdateUserForm(User user,ChipTableForm _ctf)
        {
            InitializeComponent();
            SetTextBoxs(user);
            ctf = _ctf;
            logic = new AppLogicAPI();
        }

        public void SetTextBoxs(User user)
        {
            NewNameTextBox.Text = user.name;
            NewEmailTextBox.Text = user.email;
            NewPhoneTextBox.Text = user.phone;
            //PhotUploadPictureBox.Image = תמונה של היוזר
            UserToken = user.token;
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
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DoneChipButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Change User Details?", "Are you sure ?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    logic.EditUserInDataB(NewNameTextBox.Text,NewEmailTextBox.Text,NewPhoneTextBox.Text, UserToken);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            ctf.SetHelloLabel(NewNameTextBox.Text);
            this.Close();
        }
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm Cpf = new ChangePasswordForm(UserToken);
            Cpf.ShowDialog();
        }
    }
}
