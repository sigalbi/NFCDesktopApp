using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartChip
{
    public partial class ShopForm : Form
    {
        WebBrowser browser;

        public ShopForm()
        {
            InitializeComponent();
            AddBrowser();  
        }

        public void AddBrowser()
        {
            browser = new WebBrowser();
            browser.Size = this.Size;
            browser.Location = this.Location;
            this.Controls.Add(browser);
            browser.Navigate("https://www.ebay.com/sch/i.html?_from=R40&_trksid=m570.l1313&_nkw=NFC&_sacat=0");
        }
    }
}