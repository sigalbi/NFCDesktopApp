using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppLogic;

namespace SmartChip
{
    public partial class UserMainForm : Form
    {
        ChipTableForm chipTableForm;
        AboutUsForm aboutUsForm;
        ShopForm shopForm;
        ContectUsForm contectUsForm;

        public UserMainForm(string UserToken)
        {
            InitializeComponent();
            IntializeTabPanel(UserToken);
        }

        public void IntializeTabPanel(string UserToken)
        {
            aboutUsForm = new AboutUsForm();
            aboutUsForm.TopLevel = false;
            aboutUsForm.AutoScroll = true;

            chipTableForm = new ChipTableForm(UserToken);
            chipTableForm.TopLevel = false;
            chipTableForm.AutoScroll = true;

            shopForm = new ShopForm();
            shopForm.TopLevel = false;
            shopForm.AutoScroll = true;

            contectUsForm = new ContectUsForm(UserToken);
            contectUsForm.TopLevel = false;
            contectUsForm.AutoScroll = true;

            TabPanel.Controls.Add(aboutUsForm);
            TabPanel.Controls.Add(chipTableForm);
            TabPanel.Controls.Add(shopForm);
            TabPanel.Controls.Add(contectUsForm);

            chipTableForm.Show();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AboutUsButton_Click(object sender, EventArgs e)
        {
            chipTableForm.Hide();
            MyChipspanel.Visible = false;

            shopForm.Hide();
            ShopPanel.Visible = false;

            contectUsForm.Hide();
            ContectUsPanel.Visible = false;

            AboutUspanel.Visible = true;
            aboutUsForm.Show();
        }
        private void MyChipsButton_Click(object sender, EventArgs e)
        {
            aboutUsForm.Hide();
            AboutUspanel.Visible = false;

            shopForm.Hide();
            ShopPanel.Visible = false;

            contectUsForm.Hide();
            ContectUsPanel.Visible = false;

            chipTableForm.Show();
            MyChipspanel.Visible = true;
        }
        private void ShopButton_Click(object sender, EventArgs e)
        {
            aboutUsForm.Hide();
            AboutUspanel.Visible = false;

            contectUsForm.Hide();
            ContectUsPanel.Visible = false;

            chipTableForm.Hide();
            MyChipspanel.Visible = false;

            shopForm.Show();
            ShopPanel.Visible = true;
        }
        private void ContectUsButton_Click(object sender, EventArgs e)
        {
            aboutUsForm.Hide();
            AboutUspanel.Visible = false;

            chipTableForm.Hide();
            MyChipspanel.Visible = false;

            shopForm.Hide();
            ShopPanel.Visible = false;

            contectUsForm.Show();
            ContectUsPanel.Visible = true;
        }
    }
}