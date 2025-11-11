namespace Cafe_Management_System
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            imageList1 = new ImageList(components);
            LoginPanel = new Panel();
            pictureBox1 = new PictureBox();
            lblUsernm = new Label();
            txtPsswd = new TextBox();
            btnReset = new Button();
            chkShowpsswd = new CheckBox();
            btnLogin = new Button();
            label1 = new Label();
            txtUsrnm = new TextBox();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "enter_1828466.png");
            imageList1.Images.SetKeyName(1, "login_7856126.png");
            imageList1.Images.SetKeyName(2, "png-transparent-reboot-computer-icons-random-buttons-miscellaneous-reset-button-reset-thumbnail.png");
            imageList1.Images.SetKeyName(3, "png-transparent-file-system-permissions-computer-icons-reset-computer-software-reset-s-reset-button-computer-icons-user-thumbnail.png");
            imageList1.Images.SetKeyName(4, "multi-purpose-restaurant-app-management-platform.jpg");
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(pictureBox1);
            LoginPanel.Controls.Add(lblUsernm);
            LoginPanel.Controls.Add(txtPsswd);
            LoginPanel.Controls.Add(btnReset);
            LoginPanel.Controls.Add(chkShowpsswd);
            LoginPanel.Controls.Add(btnLogin);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(txtUsrnm);
            LoginPanel.ImeMode = ImeMode.Off;
            LoginPanel.Location = new Point(399, 82);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(502, 549);
            LoginPanel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Login_avatar;
            pictureBox1.Location = new Point(145, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // lblUsernm
            // 
            lblUsernm.AutoSize = true;
            lblUsernm.BackColor = Color.Transparent;
            lblUsernm.Font = new Font("Calibri", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsernm.ForeColor = SystemColors.ActiveCaptionText;
            lblUsernm.Location = new Point(75, 282);
            lblUsernm.Name = "lblUsernm";
            lblUsernm.Size = new Size(127, 31);
            lblUsernm.TabIndex = 0;
            lblUsernm.Text = "User Name";
            lblUsernm.Click += lblUsernm_Click;
            // 
            // txtPsswd
            // 
            txtPsswd.BackColor = SystemColors.ButtonFace;
            txtPsswd.Font = new Font("Californian FB", 14.2641506F);
            txtPsswd.Location = new Point(218, 342);
            txtPsswd.Multiline = true;
            txtPsswd.Name = "txtPsswd";
            txtPsswd.PasswordChar = '*';
            txtPsswd.PlaceholderText = " enter password";
            txtPsswd.Size = new Size(198, 27);
            txtPsswd.TabIndex = 2;
            txtPsswd.TextChanged += textBox1_TextChanged;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ButtonFace;
            btnReset.ImageAlign = ContentAlignment.TopLeft;
            btnReset.ImageIndex = 2;
            btnReset.ImageList = imageList1;
            btnReset.Location = new Point(291, 469);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(145, 57);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // chkShowpsswd
            // 
            chkShowpsswd.AutoSize = true;
            chkShowpsswd.BackColor = Color.Transparent;
            chkShowpsswd.Font = new Font("Calibri", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowpsswd.ForeColor = SystemColors.ActiveCaptionText;
            chkShowpsswd.Location = new Point(252, 411);
            chkShowpsswd.Name = "chkShowpsswd";
            chkShowpsswd.Size = new Size(164, 30);
            chkShowpsswd.TabIndex = 4;
            chkShowpsswd.Text = "Show Password";
            chkShowpsswd.UseVisualStyleBackColor = false;
            chkShowpsswd.CheckedChanged += chkShowpsswd_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonFace;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.ImageAlign = ContentAlignment.TopLeft;
            btnLogin.ImageIndex = 3;
            btnLogin.ImageList = imageList1;
            btnLogin.Location = new Point(109, 469);
            btnLogin.Margin = new Padding(30);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(148, 57);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "   Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(75, 342);
            label1.Name = "label1";
            label1.Size = new Size(111, 31);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // txtUsrnm
            // 
            txtUsrnm.BackColor = SystemColors.ButtonFace;
            txtUsrnm.Font = new Font("Californian FB", 14.2641506F);
            txtUsrnm.Location = new Point(215, 286);
            txtUsrnm.Multiline = true;
            txtUsrnm.Name = "txtUsrnm";
            txtUsrnm.PlaceholderText = "enter user name";
            txtUsrnm.Size = new Size(201, 27);
            txtUsrnm.TabIndex = 1;
            txtUsrnm.TextChanged += txtUsrnm_TextChanged;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1584, 762);
            Controls.Add(LoginPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.On;
            Name = "LoginPage";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafe Management System";
            TransparencyKey = Color.DimGray;
            Load += LoginPage_Load;
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        public Panel LoginPanel;
        private Label lblUsernm;
        private TextBox txtPsswd;
        private Button btnReset;
        private CheckBox chkShowpsswd;
        private Button btnLogin;
        private Label label1;
        private TextBox txtUsrnm;
        private PictureBox pictureBox1;
    }
}
