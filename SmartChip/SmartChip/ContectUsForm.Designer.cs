namespace SmartChip
{
    partial class ContectUsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContectUsForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.SubjectLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MessegeBodyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TextLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SendButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(158, 77);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(293, 22);
            this.SubjectTextBox.TabIndex = 0;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SubjectLabel.Location = new System.Drawing.Point(67, 80);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(69, 19);
            this.SubjectLabel.TabIndex = 1;
            this.SubjectLabel.Text = "Subject :";
            // 
            // MessegeBodyRichTextBox
            // 
            this.MessegeBodyRichTextBox.Location = new System.Drawing.Point(158, 135);
            this.MessegeBodyRichTextBox.Name = "MessegeBodyRichTextBox";
            this.MessegeBodyRichTextBox.Size = new System.Drawing.Size(293, 310);
            this.MessegeBodyRichTextBox.TabIndex = 2;
            this.MessegeBodyRichTextBox.Text = "";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextLabel.Location = new System.Drawing.Point(67, 147);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(47, 19);
            this.TextLabel.TabIndex = 3;
            this.TextLabel.Text = "Text :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(210, 28);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(135, 19);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Send us a messege";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartChip.Properties.Resources.up;
            this.pictureBox1.Location = new System.Drawing.Point(470, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 435);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.Transparent;
            this.SendButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendButton.BackgroundImage")));
            this.SendButton.ButtonText = "Send";
            this.SendButton.ButtonTextMarginLeft = 0;
            this.SendButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.SendButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.SendButton.DisabledForecolor = System.Drawing.Color.White;
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SendButton.IconPadding = 10;
            this.SendButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SendButton.IdleBorderColor = System.Drawing.Color.Lime;
            this.SendButton.IdleBorderRadius = 1;
            this.SendButton.IdleBorderThickness = 0;
            this.SendButton.IdleFillColor = System.Drawing.Color.Silver;
            this.SendButton.IdleIconLeftImage = null;
            this.SendButton.IdleIconRightImage = null;
            this.SendButton.Location = new System.Drawing.Point(245, 497);
            this.SendButton.Name = "SendButton";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Lime;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.SendButton.onHoverState = stateProperties1;
            this.SendButton.Size = new System.Drawing.Size(100, 41);
            this.SendButton.TabIndex = 9;
            this.SendButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ContectUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 589);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.MessegeBodyRichTextBox);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.SubjectTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContectUsForm";
            this.Text = "ContextUsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel TextLabel;
        private System.Windows.Forms.RichTextBox MessegeBodyRichTextBox;
        private Bunifu.Framework.UI.BunifuCustomLabel SubjectLabel;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SendButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}