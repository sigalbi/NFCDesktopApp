namespace SmartChip
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.RegisterButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LoginButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ExitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ForgottPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(176, 299);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(205, 22);
            this.EmailtextBox.TabIndex = 5;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(176, 357);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(205, 22);
            this.PasswordtextBox.TabIndex = 6;
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.BackColor = System.Drawing.Color.White;
            this.Passwordlabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Passwordlabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Passwordlabel.Location = new System.Drawing.Point(72, 357);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(83, 19);
            this.Passwordlabel.TabIndex = 4;
            this.Passwordlabel.Text = "Password :";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.BackColor = System.Drawing.Color.White;
            this.Emaillabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Emaillabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Emaillabel.Location = new System.Drawing.Point(72, 299);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(74, 19);
            this.Emaillabel.TabIndex = 3;
            this.Emaillabel.Text = "E - Mail :";
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterButton.BackgroundImage")));
            this.RegisterButton.ButtonText = "Register";
            this.RegisterButton.ButtonTextMarginLeft = 0;
            this.RegisterButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.RegisterButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.RegisterButton.DisabledForecolor = System.Drawing.Color.White;
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.RegisterButton.IconPadding = 10;
            this.RegisterButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.RegisterButton.IdleBorderColor = System.Drawing.Color.Lime;
            this.RegisterButton.IdleBorderRadius = 1;
            this.RegisterButton.IdleBorderThickness = 0;
            this.RegisterButton.IdleFillColor = System.Drawing.Color.Silver;
            this.RegisterButton.IdleIconLeftImage = null;
            this.RegisterButton.IdleIconRightImage = null;
            this.RegisterButton.Location = new System.Drawing.Point(61, 438);
            this.RegisterButton.Name = "RegisterButton";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Lime;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.RegisterButton.onHoverState = stateProperties1;
            this.RegisterButton.Size = new System.Drawing.Size(84, 31);
            this.RegisterButton.TabIndex = 7;
            this.RegisterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.ButtonText = "Login";
            this.LoginButton.ButtonTextMarginLeft = 0;
            this.LoginButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.LoginButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.LoginButton.DisabledForecolor = System.Drawing.Color.White;
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LoginButton.IconPadding = 10;
            this.LoginButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LoginButton.IdleBorderColor = System.Drawing.Color.Lime;
            this.LoginButton.IdleBorderRadius = 1;
            this.LoginButton.IdleBorderThickness = 0;
            this.LoginButton.IdleFillColor = System.Drawing.Color.Silver;
            this.LoginButton.IdleIconLeftImage = null;
            this.LoginButton.IdleIconRightImage = null;
            this.LoginButton.Location = new System.Drawing.Point(215, 438);
            this.LoginButton.Name = "LoginButton";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.Lime;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.LoginButton.onHoverState = stateProperties2;
            this.LoginButton.Size = new System.Drawing.Size(84, 31);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
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
            this.ExitButton.Location = new System.Drawing.Point(370, 438);
            this.ExitButton.Name = "ExitButton";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.Red;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.ExitButton.onHoverState = stateProperties3;
            this.ExitButton.Size = new System.Drawing.Size(84, 31);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            // ForgottPasswordLinkLabel
            // 
            this.ForgottPasswordLinkLabel.AutoSize = true;
            this.ForgottPasswordLinkLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForgottPasswordLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.ForgottPasswordLinkLabel.Location = new System.Drawing.Point(387, 361);
            this.ForgottPasswordLinkLabel.Name = "ForgottPasswordLinkLabel";
            this.ForgottPasswordLinkLabel.Size = new System.Drawing.Size(116, 16);
            this.ForgottPasswordLinkLabel.TabIndex = 10;
            this.ForgottPasswordLinkLabel.TabStop = true;
            this.ForgottPasswordLinkLabel.Text = "Forgot Password ?";
            this.ForgottPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgottPasswordLinkLabel_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SmartChip.Properties.Resources.up1;
            this.ClientSize = new System.Drawing.Size(534, 540);
            this.Controls.Add(this.ForgottPasswordLinkLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Emaillabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label Emaillabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton RegisterButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LoginButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ExitButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.LinkLabel ForgottPasswordLinkLabel;
    }
}

