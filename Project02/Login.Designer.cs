
namespace Project02
{
    partial class LoginUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUserControl));
            this.midicon = new System.Windows.Forms.PictureBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.CloseloginBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.busleft = new System.Windows.Forms.PictureBox();
            this.rightbus = new System.Windows.Forms.PictureBox();
            this.passwordlogo = new System.Windows.Forms.PictureBox();
            this.emaillogo = new System.Windows.Forms.PictureBox();
            this.Registerbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Loginbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PasswordInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EmailInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.midicon)).BeginInit();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightbus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emaillogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // midicon
            // 
            this.midicon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.midicon.Image = ((System.Drawing.Image)(resources.GetObject("midicon.Image")));
            this.midicon.Location = new System.Drawing.Point(474, 26);
            this.midicon.Name = "midicon";
            this.midicon.Size = new System.Drawing.Size(135, 118);
            this.midicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.midicon.TabIndex = 0;
            this.midicon.TabStop = false;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.Controls.Add(this.CloseloginBtn);
            this.LoginPanel.Controls.Add(this.busleft);
            this.LoginPanel.Controls.Add(this.rightbus);
            this.LoginPanel.Controls.Add(this.passwordlogo);
            this.LoginPanel.Controls.Add(this.emaillogo);
            this.LoginPanel.Controls.Add(this.Registerbtn);
            this.LoginPanel.Controls.Add(this.Loginbtn);
            this.LoginPanel.Controls.Add(this.PasswordInput);
            this.LoginPanel.Controls.Add(this.EmailInput);
            this.LoginPanel.Controls.Add(this.NameLabel);
            this.LoginPanel.Controls.Add(this.midicon);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1059, 672);
            this.LoginPanel.TabIndex = 1;
            // 
            // CloseloginBtn
            // 
            this.CloseloginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseloginBtn.AutoSize = true;
            this.CloseloginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseloginBtn.Depth = 0;
            this.CloseloginBtn.Icon = null;
            this.CloseloginBtn.Location = new System.Drawing.Point(941, 17);
            this.CloseloginBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CloseloginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseloginBtn.Name = "CloseloginBtn";
            this.CloseloginBtn.Primary = false;
            this.CloseloginBtn.Size = new System.Drawing.Size(16, 36);
            this.CloseloginBtn.TabIndex = 27;
            this.CloseloginBtn.UseVisualStyleBackColor = true;
            this.CloseloginBtn.Click += new System.EventHandler(this.CloseloginBtn_Click);
            // 
            // busleft
            // 
            this.busleft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.busleft.Image = ((System.Drawing.Image)(resources.GetObject("busleft.Image")));
            this.busleft.Location = new System.Drawing.Point(238, 26);
            this.busleft.Name = "busleft";
            this.busleft.Size = new System.Drawing.Size(168, 118);
            this.busleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.busleft.TabIndex = 9;
            this.busleft.TabStop = false;
            // 
            // rightbus
            // 
            this.rightbus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rightbus.Image = ((System.Drawing.Image)(resources.GetObject("rightbus.Image")));
            this.rightbus.Location = new System.Drawing.Point(670, 26);
            this.rightbus.Name = "rightbus";
            this.rightbus.Size = new System.Drawing.Size(168, 118);
            this.rightbus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightbus.TabIndex = 8;
            this.rightbus.TabStop = false;
            // 
            // passwordlogo
            // 
            this.passwordlogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordlogo.Image = ((System.Drawing.Image)(resources.GetObject("passwordlogo.Image")));
            this.passwordlogo.Location = new System.Drawing.Point(237, 405);
            this.passwordlogo.Name = "passwordlogo";
            this.passwordlogo.Size = new System.Drawing.Size(43, 32);
            this.passwordlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordlogo.TabIndex = 7;
            this.passwordlogo.TabStop = false;
            // 
            // emaillogo
            // 
            this.emaillogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emaillogo.Image = ((System.Drawing.Image)(resources.GetObject("emaillogo.Image")));
            this.emaillogo.Location = new System.Drawing.Point(237, 304);
            this.emaillogo.Name = "emaillogo";
            this.emaillogo.Size = new System.Drawing.Size(43, 32);
            this.emaillogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emaillogo.TabIndex = 6;
            this.emaillogo.TabStop = false;
            // 
            // Registerbtn
            // 
            this.Registerbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Registerbtn.AutoSize = true;
            this.Registerbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Registerbtn.Depth = 0;
            this.Registerbtn.Icon = null;
            this.Registerbtn.Location = new System.Drawing.Point(614, 498);
            this.Registerbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Primary = true;
            this.Registerbtn.Size = new System.Drawing.Size(117, 36);
            this.Registerbtn.TabIndex = 5;
            this.Registerbtn.Text = "Register";
            this.Registerbtn.UseVisualStyleBackColor = true;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Loginbtn.AutoSize = true;
            this.Loginbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Loginbtn.Depth = 0;
            this.Loginbtn.Icon = null;
            this.Loginbtn.Location = new System.Drawing.Point(358, 498);
            this.Loginbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Primary = true;
            this.Loginbtn.Size = new System.Drawing.Size(83, 36);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "LOgin";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordInput.Depth = 0;
            this.PasswordInput.Hint = "Password";
            this.PasswordInput.Location = new System.Drawing.Point(300, 405);
            this.PasswordInput.MaxLength = 32767;
            this.PasswordInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '\0';
            this.PasswordInput.SelectedText = "";
            this.PasswordInput.SelectionLength = 0;
            this.PasswordInput.SelectionStart = 0;
            this.PasswordInput.Size = new System.Drawing.Size(577, 32);
            this.PasswordInput.TabIndex = 3;
            this.PasswordInput.TabStop = false;
            this.PasswordInput.UseSystemPasswordChar = false;
            this.PasswordInput.Click += new System.EventHandler(this.PasswordInput_Click);
            // 
            // EmailInput
            // 
            this.EmailInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailInput.Depth = 0;
            this.EmailInput.Hint = "Email";
            this.EmailInput.Location = new System.Drawing.Point(300, 304);
            this.EmailInput.MaxLength = 32767;
            this.EmailInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.PasswordChar = '\0';
            this.EmailInput.SelectedText = "";
            this.EmailInput.SelectionLength = 0;
            this.EmailInput.SelectionStart = 0;
            this.EmailInput.Size = new System.Drawing.Size(577, 32);
            this.EmailInput.TabIndex = 2;
            this.EmailInput.TabStop = false;
            this.EmailInput.UseSystemPasswordChar = false;
            this.EmailInput.Click += new System.EventHandler(this.EmailInput_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.Depth = 0;
            this.NameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameLabel.Location = new System.Drawing.Point(353, 144);
            this.NameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(378, 55);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Bus Reservation System";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // LoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LoginPanel);
            this.Name = "LoginUserControl";
            this.Size = new System.Drawing.Size(1059, 672);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.midicon)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightbus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emaillogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox midicon;
        private System.Windows.Forms.Panel LoginPanel;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField EmailInput;
        private MaterialSkin.Controls.MaterialLabel NameLabel;
        private MaterialSkin.Controls.MaterialRaisedButton Loginbtn;
        private System.Windows.Forms.PictureBox passwordlogo;
        private System.Windows.Forms.PictureBox emaillogo;
        private System.Windows.Forms.PictureBox rightbus;
        private System.Windows.Forms.PictureBox busleft;
        private MaterialSkin.Controls.MaterialFlatButton CloseloginBtn;
        public MaterialSkin.Controls.MaterialRaisedButton Registerbtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
