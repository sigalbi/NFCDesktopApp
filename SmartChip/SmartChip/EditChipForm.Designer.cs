namespace SmartChip
{
    partial class EditChipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditChipForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewActionComboBox = new System.Windows.Forms.ComboBox();
            this.NewNameTextBox = new System.Windows.Forms.TextBox();
            this.ChipDetailsLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChangeActionLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChangeNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ActionDetailes1Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ActionDetailes2Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ActionDetailes1TextBox = new System.Windows.Forms.TextBox();
            this.MessegeBodyTextBox = new System.Windows.Forms.RichTextBox();
            this.ActionDetailsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GlobalChipLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.ExitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DoneChipButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NewActionComboBox
            // 
            this.NewActionComboBox.FormattingEnabled = true;
            this.NewActionComboBox.Items.AddRange(new object[] {
            "Send Messege",
            "Open Web Page",
            "Call Someone",
            "Set Alarm Clock",
            "Vibrate Mode"});
            this.NewActionComboBox.Location = new System.Drawing.Point(89, 213);
            this.NewActionComboBox.Name = "NewActionComboBox";
            this.NewActionComboBox.Size = new System.Drawing.Size(157, 24);
            this.NewActionComboBox.TabIndex = 3;
            this.NewActionComboBox.SelectedIndexChanged += new System.EventHandler(this.NewActionComboBox_SelectedIndexChanged);
            // 
            // NewNameTextBox
            // 
            this.NewNameTextBox.Location = new System.Drawing.Point(374, 215);
            this.NewNameTextBox.Name = "NewNameTextBox";
            this.NewNameTextBox.Size = new System.Drawing.Size(196, 22);
            this.NewNameTextBox.TabIndex = 4;
            // 
            // ChipDetailsLabel
            // 
            this.ChipDetailsLabel.AutoSize = true;
            this.ChipDetailsLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChipDetailsLabel.Location = new System.Drawing.Point(57, 48);
            this.ChipDetailsLabel.Name = "ChipDetailsLabel";
            this.ChipDetailsLabel.Size = new System.Drawing.Size(215, 27);
            this.ChipDetailsLabel.TabIndex = 5;
            this.ChipDetailsLabel.Text = "bunifuCustomLabel1";
            // 
            // ChangeActionLabel
            // 
            this.ChangeActionLabel.AutoSize = true;
            this.ChangeActionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChangeActionLabel.Location = new System.Drawing.Point(89, 165);
            this.ChangeActionLabel.Name = "ChangeActionLabel";
            this.ChangeActionLabel.Size = new System.Drawing.Size(121, 22);
            this.ChangeActionLabel.TabIndex = 6;
            this.ChangeActionLabel.Text = "ChangeAction";
            // 
            // ChangeNameLabel
            // 
            this.ChangeNameLabel.AutoSize = true;
            this.ChangeNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChangeNameLabel.Location = new System.Drawing.Point(371, 165);
            this.ChangeNameLabel.Name = "ChangeNameLabel";
            this.ChangeNameLabel.Size = new System.Drawing.Size(114, 22);
            this.ChangeNameLabel.TabIndex = 7;
            this.ChangeNameLabel.Text = "Change name";
            // 
            // ActionDetailes1Label
            // 
            this.ActionDetailes1Label.AutoSize = true;
            this.ActionDetailes1Label.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ActionDetailes1Label.Location = new System.Drawing.Point(12, 302);
            this.ActionDetailes1Label.Name = "ActionDetailes1Label";
            this.ActionDetailes1Label.Size = new System.Drawing.Size(125, 16);
            this.ActionDetailes1Label.TabIndex = 14;
            this.ActionDetailes1Label.Text = "bunifuCustomLabel1";
            this.ActionDetailes1Label.Visible = false;
            // 
            // ActionDetailes2Label
            // 
            this.ActionDetailes2Label.AutoSize = true;
            this.ActionDetailes2Label.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ActionDetailes2Label.Location = new System.Drawing.Point(12, 340);
            this.ActionDetailes2Label.Name = "ActionDetailes2Label";
            this.ActionDetailes2Label.Size = new System.Drawing.Size(125, 16);
            this.ActionDetailes2Label.TabIndex = 15;
            this.ActionDetailes2Label.Text = "bunifuCustomLabel1";
            this.ActionDetailes2Label.Visible = false;
            // 
            // ActionDetailes1TextBox
            // 
            this.ActionDetailes1TextBox.Location = new System.Drawing.Point(163, 302);
            this.ActionDetailes1TextBox.Name = "ActionDetailes1TextBox";
            this.ActionDetailes1TextBox.Size = new System.Drawing.Size(315, 22);
            this.ActionDetailes1TextBox.TabIndex = 16;
            this.ActionDetailes1TextBox.Visible = false;
            // 
            // MessegeBodyTextBox
            // 
            this.MessegeBodyTextBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MessegeBodyTextBox.Location = new System.Drawing.Point(163, 340);
            this.MessegeBodyTextBox.Name = "MessegeBodyTextBox";
            this.MessegeBodyTextBox.Size = new System.Drawing.Size(315, 100);
            this.MessegeBodyTextBox.TabIndex = 17;
            this.MessegeBodyTextBox.Text = "";
            this.MessegeBodyTextBox.Visible = false;
            // 
            // ActionDetailsDateTimePicker
            // 
            this.ActionDetailsDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ActionDetailsDateTimePicker.Location = new System.Drawing.Point(163, 302);
            this.ActionDetailsDateTimePicker.Name = "ActionDetailsDateTimePicker";
            this.ActionDetailsDateTimePicker.ShowUpDown = true;
            this.ActionDetailsDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ActionDetailsDateTimePicker.TabIndex = 18;
            this.ActionDetailsDateTimePicker.Visible = false;
            // 
            // GlobalChipLabel
            // 
            this.GlobalChipLabel.AutoSize = true;
            this.GlobalChipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GlobalChipLabel.ForeColor = System.Drawing.Color.Red;
            this.GlobalChipLabel.Location = new System.Drawing.Point(372, 69);
            this.GlobalChipLabel.Name = "GlobalChipLabel";
            this.GlobalChipLabel.Size = new System.Drawing.Size(47, 25);
            this.GlobalChipLabel.TabIndex = 19;
            this.GlobalChipLabel.Text = "text";
            this.GlobalChipLabel.Visible = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuImageButton1.Image = global::SmartChip.Properties.Resources.X;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(609, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 31);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 12;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
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
            this.ExitButton.Location = new System.Drawing.Point(492, 474);
            this.ExitButton.Name = "ExitButton";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Red;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.ExitButton.onHoverState = stateProperties1;
            this.ExitButton.Size = new System.Drawing.Size(100, 41);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            this.DoneChipButton.Location = new System.Drawing.Point(60, 474);
            this.DoneChipButton.Name = "DoneChipButton";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.Lime;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.DoneChipButton.onHoverState = stateProperties2;
            this.DoneChipButton.Size = new System.Drawing.Size(108, 41);
            this.DoneChipButton.TabIndex = 9;
            this.DoneChipButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DoneChipButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // EditChipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 554);
            this.Controls.Add(this.GlobalChipLabel);
            this.Controls.Add(this.ActionDetailsDateTimePicker);
            this.Controls.Add(this.MessegeBodyTextBox);
            this.Controls.Add(this.ActionDetailes1TextBox);
            this.Controls.Add(this.ActionDetailes2Label);
            this.Controls.Add(this.ActionDetailes1Label);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DoneChipButton);
            this.Controls.Add(this.ChangeNameLabel);
            this.Controls.Add(this.ChangeActionLabel);
            this.Controls.Add(this.ChipDetailsLabel);
            this.Controls.Add(this.NewNameTextBox);
            this.Controls.Add(this.NewActionComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditChipForm";
            this.Text = "EditChipForm";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel ChipDetailsLabel;
        private System.Windows.Forms.TextBox NewNameTextBox;
        private System.Windows.Forms.ComboBox NewActionComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuCustomLabel ChangeNameLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel ChangeActionLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DoneChipButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ExitButton;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel ActionDetailes1Label;
        private Bunifu.Framework.UI.BunifuCustomLabel ActionDetailes2Label;
        private System.Windows.Forms.DateTimePicker ActionDetailsDateTimePicker;
        private System.Windows.Forms.RichTextBox MessegeBodyTextBox;
        private System.Windows.Forms.TextBox ActionDetailes1TextBox;
        private Bunifu.Framework.UI.BunifuCustomLabel GlobalChipLabel;
    }
}