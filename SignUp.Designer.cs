namespace Login_Form
{
    partial class SignUp
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
            layoutPanel = new Panel();
            loginBtn = new Button();
            submitBtn = new Button();
            inforGB = new GroupBox();
            emailTxt = new TextBox();
            emailLb = new Label();
            passTxt = new TextBox();
            passLb = new Label();
            userTxt = new TextBox();
            userLb = new Label();
            signInLabel = new Label();
            layoutPanel.SuspendLayout();
            inforGB.SuspendLayout();
            SuspendLayout();
            // 
            // layoutPanel
            // 
            layoutPanel.BackColor = SystemColors.Control;
            layoutPanel.BackgroundImageLayout = ImageLayout.Stretch;
            layoutPanel.Controls.Add(loginBtn);
            layoutPanel.Controls.Add(submitBtn);
            layoutPanel.Controls.Add(inforGB);
            layoutPanel.Controls.Add(signInLabel);
            layoutPanel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            layoutPanel.Location = new Point(12, 12);
            layoutPanel.Name = "layoutPanel";
            layoutPanel.Size = new Size(776, 426);
            layoutPanel.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.WhiteSmoke;
            loginBtn.ForeColor = Color.Salmon;
            loginBtn.Location = new Point(507, 359);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(137, 38);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Đăng nhập";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Red;
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(161, 359);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(137, 38);
            submitBtn.TabIndex = 2;
            submitBtn.Text = "Đăng kí";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // inforGB
            // 
            inforGB.BackColor = SystemColors.Control;
            inforGB.Controls.Add(emailTxt);
            inforGB.Controls.Add(emailLb);
            inforGB.Controls.Add(passTxt);
            inforGB.Controls.Add(passLb);
            inforGB.Controls.Add(userTxt);
            inforGB.Controls.Add(userLb);
            inforGB.Location = new Point(112, 113);
            inforGB.Name = "inforGB";
            inforGB.Size = new Size(577, 197);
            inforGB.TabIndex = 0;
            inforGB.TabStop = false;
            inforGB.Text = "Thông tin";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(223, 143);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(277, 30);
            emailTxt.TabIndex = 4;
            // 
            // emailLb
            // 
            emailLb.AutoSize = true;
            emailLb.Location = new Point(79, 151);
            emailLb.Name = "emailLb";
            emailLb.Size = new Size(57, 22);
            emailLb.TabIndex = 3;
            emailLb.Text = "Email";
            // 
            // passTxt
            // 
            passTxt.Location = new Point(223, 84);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(277, 30);
            passTxt.TabIndex = 2;
            passTxt.UseSystemPasswordChar = true;
            // 
            // passLb
            // 
            passLb.AutoSize = true;
            passLb.Location = new Point(79, 92);
            passLb.Name = "passLb";
            passLb.Size = new Size(88, 22);
            passLb.TabIndex = 0;
            passLb.Text = "Password";
            // 
            // userTxt
            // 
            userTxt.Location = new Point(223, 30);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(277, 30);
            userTxt.TabIndex = 1;
            // 
            // userLb
            // 
            userLb.AutoSize = true;
            userLb.Location = new Point(79, 38);
            userLb.Name = "userLb";
            userLb.Size = new Size(68, 22);
            userLb.TabIndex = 0;
            userLb.Text = "User Id";
            // 
            // signInLabel
            // 
            signInLabel.AutoSize = true;
            signInLabel.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signInLabel.Location = new Point(311, 50);
            signInLabel.Name = "signInLabel";
            signInLabel.Size = new Size(132, 38);
            signInLabel.TabIndex = 0;
            signInLabel.Text = "Đăng kí";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(layoutPanel);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            layoutPanel.ResumeLayout(false);
            layoutPanel.PerformLayout();
            inforGB.ResumeLayout(false);
            inforGB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel layoutPanel;
        private Button loginBtn;
        private Button submitBtn;
        private GroupBox inforGB;
        private TextBox passTxt;
        private Label passLb;
        private TextBox userTxt;
        private Label userLb;
        private Label signInLabel;
        private TextBox emailTxt;
        private Label emailLb;
    }
}