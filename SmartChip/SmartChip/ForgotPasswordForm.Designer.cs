namespace SmartChip
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EnterYourEmailLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.SendPasswordButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
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
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(94, 328);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(227, 22);
            this.EmailTextBox.TabIndex = 0;
            // 
            // EnterYourEmailLabel
            // 
            this.EnterYourEmailLabel.AutoSize = true;
            this.EnterYourEmailLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EnterYourEmailLabel.Location = new System.Drawing.Point(121, 270);
            this.EnterYourEmailLabel.Name = "EnterYourEmailLabel";
            this.EnterYourEmailLabel.Size = new System.Drawing.Size(153, 17);
            this.EnterYourEmailLabel.TabIndex = 1;
            this.EnterYourEmailLabel.Text = "Enter your Email adress ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartChip.Properties.Resources.forgotPass1;
            this.pictureBox1.Location = new System.Drawing.Point(71, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 312);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Image = global::SmartChip.Properties.Resources.X;
            this.ExitButton.ImageActive = null;
            this.ExitButton.Location = new System.Drawing.Point(388, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(28, 31);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 12;
            this.ExitButton.TabStop = false;
            this.ExitButton.Zoom = 10;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SendPasswordButton
            // 
            this.SendPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.SendPasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendPasswordButton.BackgroundImage")));
            this.SendPasswordButton.ButtonText = "Send Password";
            this.SendPasswordButton.ButtonTextMarginLeft = 0;
            this.SendPasswordButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.SendPasswordButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.SendPasswordButton.DisabledForecolor = System.Drawing.Color.White;
            this.SendPasswordButton.ForeColor = System.Drawing.Color.White;
            this.SendPasswordButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SendPasswordButton.IconPadding = 10;
            this.SendPasswordButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SendPasswordButton.IdleBorderColor = System.Drawing.Color.Lime;
            this.SendPasswordButton.IdleBorderRadius = 1;
            this.SendPasswordButton.IdleBorderThickness = 0;
            this.SendPasswordButton.IdleFillColor = System.Drawing.Color.Silver;
            this.SendPasswordButton.IdleIconLeftImage = null;
            this.SendPasswordButton.IdleIconRightImage = null;
            this.SendPasswordButton.Location = new System.Drawing.Point(130, 403);
            this.SendPasswordButton.Name = "SendPasswordButton";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.Lime;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.SendPasswordButton.onHoverState = stateProperties3;
            this.SendPasswordButton.Size = new System.Drawing.Size(144, 31);
            this.SendPasswordButton.TabIndex = 9;
            this.SendPasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendPasswordButton.Click += new System.EventHandler(this.SendPasswordButton_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 511);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SendPasswordButton);
            this.Controls.Add(this.EnterYourEmailLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel EnterYourEmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SendPasswordButton;
        private Bunifu.Framework.UI.BunifuImageButton ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}