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
    public partial class EditChipForm : Form
    {
        Chip c;
        string UserToken;
        AppLogicAPI logic;

        public EditChipForm(string ChipName , string Action,string id ,string _UserToken )
        {
            logic = new AppLogicAPI();
            InitializeComponent();
            SetChip(id,_UserToken);
            UserToken = _UserToken;
            ChipDetailsLabel.Text = "Edit Chip : " + c.name + "\nId : " + c._id + "\nAction : " + c.action;
            NewNameTextBox.Text = c.name;
            CheckIfChipIsGlobal();
        }
        public void CheckIfChipIsGlobal()
        {
            if(c.isGlobal==true)
            {
                GlobalChipLabel.Text = "This is a global chip\nCould not edit chip";
                GlobalChipLabel.Visible = true;
                DoneChipButton.Enabled = false;
            }
        }
        public void SetChip(string id,string UserToken)
        {
            c = logic.GetChip(id,UserToken);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Changes wont be saved !!!\nExit?","Are you sure ?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void UpdateOptionsArr(Chip c)
        {
            c.options = new List<string>();

            if (NewActionComboBox.SelectedIndex == 0 || NewActionComboBox.SelectedIndex ==1 || NewActionComboBox.SelectedIndex == 2) //send messege
            {
                c.options.Add(ActionDetailes1TextBox.Text);
                if (NewActionComboBox.SelectedIndex == 0)
                    c.options.Add(MessegeBodyTextBox.Text);
            }
            else if(NewActionComboBox.SelectedIndex == 4)
            {
                c.options.Add(ActionDetailsDateTimePicker.Value.ToString("hh"));
                c.options.Add(ActionDetailsDateTimePicker.Value.ToString("mm"));
            }
        }
        private void DoneButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Change Chip?", "Are you sure ?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                UpdateOptionsArr(c);
                try
                {
                    logic.EditChipInDataB(NewNameTextBox.Text,NewActionComboBox.Text,c._id, UserToken,c.options,c.isGlobal);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            this.Close();
        }
        public void MakeSendMessegeTools()
        {
            ActionDetailes1Label.Text = "Send To :";
            ActionDetailes1Label.Visible = true;

            ActionDetailes2Label.Text = "Messege Body :";
            ActionDetailes2Label.Visible = true;

            ActionDetailes1TextBox.Visible = true;
            MessegeBodyTextBox.Visible = true;

            ActionDetailsDateTimePicker.Visible = false;
        }
        public void MakeOpenWebPageTools()
        {
            ActionDetailes1Label.Text = "URL :";
            ActionDetailes1Label.Visible = true;

            ActionDetailes2Label.Visible = false;

            MessegeBodyTextBox.Visible = false;
            ActionDetailes1TextBox.Visible = true;

            ActionDetailsDateTimePicker.Visible = false;

        }
        public void MakeCallSomeoneTools()
        {
            ActionDetailes1Label.Text = "Call To :";
            ActionDetailes1Label.Visible = true;

            ActionDetailes2Label.Visible = false;

            MessegeBodyTextBox.Visible = false;
            ActionDetailes1TextBox.Visible = true;

            ActionDetailsDateTimePicker.Visible = false;
        }
        public void MakeSetAlarmClockTools()
        {
            ActionDetailes1Label.Text = "Alarm Time :";
            ActionDetailes1Label.Visible = true;

            ActionDetailes2Label.Visible = false;

            MessegeBodyTextBox.Visible = false;
            ActionDetailes1TextBox.Visible = false;

            ActionDetailsDateTimePicker.Visible = true;
        }
        public void MakeVibrateTools()
        {
            ActionDetailes1Label.Visible = false;
            ActionDetailes2Label.Visible = false;
            MessegeBodyTextBox.Visible = false;
            ActionDetailes1TextBox.Visible = false;
        }
        private void NewActionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NewActionComboBox.SelectedIndex == 0) //send messege
                MakeSendMessegeTools();
            else if (NewActionComboBox.SelectedIndex == 1)//open web page
                MakeOpenWebPageTools();
            else if (NewActionComboBox.SelectedIndex == 2)//call someone
                MakeCallSomeoneTools();
            else if (NewActionComboBox.SelectedIndex == 3)//set alarm clock
                MakeSetAlarmClockTools();
            else if (NewActionComboBox.SelectedIndex == 4)//set timer
                MakeVibrateTools();
        }
    }
}
