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
    public partial class AboutUsForm : Form
    {
        public AboutUsForm()
        {
            InitializeComponent();
            AboutUsLabel.Text = "Hello World\n\nWe are Smart Chip :)\nIn a growing world every second counts.Thats why we have\ndeveloped an app that will give you some seconds back.\nNow you can execute tasks on your mobile phone with an easy swipe.\nWe are very proud to be using this cutting edge NFC technology, and looking\nforword to improve the actions that can be executed on your mobile.\n\nHere's to the Future !";
        }
    }
}
