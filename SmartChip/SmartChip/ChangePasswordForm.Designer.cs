namespace SmartChip
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.OldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.OldPasswordLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.NewPasswordLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.DoneChipButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ExitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // OldPasswordTextBox
            // 
            this.OldPasswordTextBox.Location = new System.Drawing.Point(169, 249);
            this.OldPasswordTextBox.Name = "OldPasswordTextBox";
            this.OldPasswordTextBox.Size = new System.Drawing.Size(156, 22);
            this.OldPasswordTextBox.TabIndex = 0;
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OldPasswordLabel.Location = new System.Drawing.Point(41, 252);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(95, 16);
            this.OldPasswordLabel.TabIndex = 1;
            this.OldPasswordLabel.Text = "Old Password :";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NewPasswordLabel.Location = new System.Drawing.Point(41, 355);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(102, 16);
            this.NewPasswordLabel.TabIndex = 3;
            this.NewPasswordLabel.Text = "New Password :";
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(169, 352);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(156, 22);
            this.NewPasswordTextBox.TabIndex = 2;
            // 
            // DoneChipButton
            // 
            this.DoneChipButton.BackColor = System.Drawing.Color.Transparent;
            this.DoneChipButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DoneChipButton.BackgroundImage")));
            this.DoneChipButton.ButtonText = "Done";
            this.DoneChipButton.ButtonTextMarginLeft = 0;
            this.DoneChipButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.DoneChipButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.DoneChipButton.DisabledForecolor = System.Drawing.Color.White;
            this.DoneChipButton.ForeColor = System.Drawing.Color.White;
            this.DoneChipButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DoneChipButton.IconPadding = 10;
            this.DoneChipButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DoneChipButton.IdleBorderColor = System.Drawing.Color.Lime;
            this.DoneChipButton.IdleBorderRadius = 1;
            this.DoneChipButton.IdleBorderThickness = 0;
            this.DoneChipButton.IdleFillColor = System.Drawing.Color.Silver;
            this.DoneChipButton.IdleIconLeftImage = null;
            this.DoneChipButton.IdleIconRightImage = null;
            this.DoneChipButton.Location = new System.Drawing.Point(81, 447);
            this.DoneChipButton.Name = "DoneChipButton";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.Lime;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.DoneChipButton.onHoverState = stateProperties3;
            this.DoneChipButton.Size = new System.Drawing.Size(92, 30);
            this.DoneChipButton.TabIndex = 12;
            this.DoneChipButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DoneChipButton.Click += new System.EventHandler(this.DoneChipButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.ButtonText = "Exit";
            this.ExitButton.ButtonTextMarginLeft = 0;
            this.ExitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ExitButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.ExitButton.DisabledForecolor = System.Drawing.Color.White;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.IconPadding = 10;
            this.ExitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.IdleBorderColor = System.Drawing.Color.Red;
            this.ExitButton.IdleBorderRadius = 1;
            this.ExitButton.IdleBorderThickness = 0;
            this.ExitButton.IdleFillColor = System.Drawing.Color.Silver;
            this.ExitButton.IdleIconLeftImage = null;
            this.ExitButton.IdleIconRightImage = null;
            this.ExitButton.Location = new System.Drawing.Point(225, 447);
            this.ExitButton.Name = "ExitButton";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.Red;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.ExitButton.onHoverState = stateProperties4;
            this.ExitButton.Size = new System.Drawing.Size(84, 30);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartChip.Properties.Resources.ChangePass;
            this.pictureBox1.Location = new System.Drawing.Point(29, -35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 360);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 526);
            this.Controls.Add(this.DoneChipButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.OldPasswordLabel);
            this.Controls.Add(this.OldPasswordTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel NewPasswordLabel;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private Bunifu.Framework.UI.BunifuCustomLabel OldPasswordLabel;
        private System.Windows.Forms.TextBox OldPasswordTextBox;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ExitButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DoneChipButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}