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
    public partial class ContectUsForm : Form
    {
        AppLogicAPI logic;
        string UserToken;
        public ContectUsForm(string _UserToken)
        {
            InitializeComponent();
            logic = new AppLogicAPI();
            UserToken = _UserToken;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(SubjectTextBox.Text))
            {
                MessageBox.Show("Please add a subject to the messege");
            }
            else
            {
                try
                {
                    logic.SendContectUsMessege(SubjectTextBox.Text, MessegeBodyRichTextBox.Text, UserToken);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Somthing went wrong\nDid not sent messege");
                }
                MessageBox.Show("Messege Sent");
            }
        }
    }
}
