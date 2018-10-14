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
    public partial class ChipTableForm : Form
    {

        AppLogicAPI logic;
        User user;

        public ChipTableForm(string UserToken)
        {
            user = new User();
            logic = new AppLogicAPI();
            InitializeComponent();
            
            try
            {
                GetUserInfo(UserToken);

            }
            catch (Exception exp)
            {
                MessageBox.Show("Somthing went wrong ... \nTry again");
                this.Close();
            }
            setUserMainForm();
        }
      
        private void GetUserInfo(string UserToken)
        {
            user = logic.GetUserInfoByToken(UserToken);
            user.MyChips = logic.GetUserChips(UserToken);
        }
        public void SetHelloLabel(string name)
        {
            HelloUserLabel.Text = "Welcome back " +name;
        }
        public void setUserMainForm()
        {
            int i, j;
            SetHelloLabel(user.name);
            bunifuCustomDataGrid1.RowTemplate.Height = 50;
            //upload user photo here
            bunifuCustomDataGrid1.CellContentClick += new DataGridViewCellEventHandler(deleteCellClick);

            for (i = 0; i < user.MyChips.Count; i++)
            {
                j = bunifuCustomDataGrid1.Rows.Add();
                bunifuCustomDataGrid1.Rows[j].Cells[1].Value = user.MyChips[i].name;
                bunifuCustomDataGrid1.Rows[j].Cells[2].Value = user.MyChips[i]._id;
                bunifuCustomDataGrid1.Rows[j].Cells[3].Value = user.MyChips[i].action;
                bunifuCustomDataGrid1.Rows[j].Cells[4].Value = "Edit";
                bunifuCustomDataGrid1.Rows[j].Cells[5].Value = "Delete";
            }
            SetRowsColor();
            ChipNumLabel.Text = "You have a total of " + (bunifuCustomDataGrid1.Rows.Count).ToString() + " Smart Chips";
        }
        public void SetRowsColor()
        {
            int i;
            for (i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    bunifuCustomDataGrid1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                else
                    bunifuCustomDataGrid1.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;

            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
        private bool UserIsSure()
        {
            var confirmResult = MessageBox.Show("Are sure you want to Delete Chip?", "WE Are SmartChip", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        private void deleteCellClick(object sender, DataGridViewCellEventArgs e)
        {
            Chip chip = new Chip();
            string id;
            if (e.RowIndex < 0)
                return;

            if (bunifuCustomDataGrid1.Columns[e.ColumnIndex] == bunifuCustomDataGrid1.Columns[5])////delete!!!
            {
                if (UserIsSure())
                {
                    id = (string)bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value;

                    try
                    {
                        chip = logic.GetChip(id, user.token);
                        logic.DeleteChipInDataB(chip, user.token);
                        bunifuCustomDataGrid1.Rows.Remove(bunifuCustomDataGrid1.Rows[e.RowIndex]);
                        SetRowsColor();
                        MessageBox.Show("Chip Deleted :)");
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
            }
            else if (bunifuCustomDataGrid1.Columns[e.ColumnIndex] == bunifuCustomDataGrid1.Columns[4])/////edit!!!
            {

                string chipName = (string)bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value;
                string action = (string)bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value;
                id = (string)bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value;

                EditChipForm Edf = new EditChipForm(chipName, action, id, user.token);
                Edf.ShowDialog();
                chip = logic.GetChip(id, user.token);
                bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value = chip.name;
                bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value = chip.action;
            }
        }
        private void EditUserButton_Click(object sender, EventArgs e)
        {
            UpdateUserForm Uuf = new UpdateUserForm(user,this);
            Uuf.ShowDialog();
        }
    }
}
