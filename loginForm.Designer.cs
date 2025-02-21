namespace Login_Form
{
    partial class loginForm
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
            layoutPanel = new Panel();
            exitBtn = new Button();
            submitBtn = new Button();
            inforGB = new GroupBox();
            signUpLLB = new LinkLabel();
            forgotPassLLB = new LinkLabel();
            passTxt = new TextBox();
            passLb = new Label();
            userTxt = new TextBox();
            userLb = new Label();
            loginLabel = new Label();
            layoutPanel.SuspendLayout();
            inforGB.SuspendLayout();
            SuspendLayout();
            // 
            // layoutPanel
            // 
            layoutPanel.BackColor = SystemColors.Control;
            layoutPanel.BackgroundImageLayout = ImageLayout.Stretch;
            layoutPanel.Controls.Add(exitBtn);
            layoutPanel.Controls.Add(submitBtn);
            layoutPanel.Controls.Add(inforGB);
            layoutPanel.Controls.Add(loginLabel);
            layoutPanel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            layoutPanel.Location = new Point(12, 12);
            layoutPanel.Name = "layoutPanel";
            layoutPanel.Size = new Size(833, 426);
            layoutPanel.TabIndex = 0;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.WhiteSmoke;
            exitBtn.ForeColor = Color.Salmon;
            exitBtn.Location = new Point(530, 367);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(137, 38);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Red;
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(184, 367);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(137, 38);
            submitBtn.TabIndex = 2;
            submitBtn.Text = "Đăng nhập";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // inforGB
            // 
            inforGB.BackColor = SystemColors.Control;
            inforGB.Controls.Add(signUpLLB);
            inforGB.Controls.Add(forgotPassLLB);
            inforGB.Controls.Add(passTxt);
            inforGB.Controls.Add(passLb);
            inforGB.Controls.Add(userTxt);
            inforGB.Controls.Add(userLb);
            inforGB.Location = new Point(140, 113);
            inforGB.Name = "inforGB";
            inforGB.Size = new Size(577, 230);
            inforGB.TabIndex = 0;
            inforGB.TabStop = false;
            inforGB.Text = "Thông tin";
            // 
            // signUpLLB
            // 
            signUpLLB.AutoSize = true;
            signUpLLB.Location = new Point(119, 185);
            signUpLLB.Name = "signUpLLB";
            signUpLLB.Size = new Size(117, 22);
            signUpLLB.TabIndex = 3;
            signUpLLB.TabStop = true;
            signUpLLB.Text = "Tạo tài khoản";
            signUpLLB.LinkClicked += signUpLLB_LinkClicked;
            // 
            // forgotPassLLB
            // 
            forgotPassLLB.AutoSize = true;
            forgotPassLLB.Location = new Point(318, 185);
            forgotPassLLB.Name = "forgotPassLLB";
            forgotPassLLB.Size = new Size(125, 22);
            forgotPassLLB.TabIndex = 4;
            forgotPassLLB.TabStop = true;
            forgotPassLLB.Text = "Quên mật khẩu";
            forgotPassLLB.LinkClicked += forgotPassLLB_LinkClicked;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(223, 124);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(277, 30);
            passTxt.TabIndex = 2;
            passTxt.UseSystemPasswordChar = true;
            // 
            // passLb
            // 
            passLb.AutoSize = true;
            passLb.Location = new Point(79, 132);
            passLb.Name = "passLb";
            passLb.Size = new Size(88, 22);
            passLb.TabIndex = 0;
            passLb.Text = "Password";
            // 
            // userTxt
            // 
            userTxt.Location = new Point(223, 60);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(277, 30);
            userTxt.TabIndex = 1;
            // 
            // userLb
            // 
            userLb.AutoSize = true;
            userLb.Location = new Point(79, 68);
            userLb.Name = "userLb";
            userLb.Size = new Size(68, 22);
            userLb.TabIndex = 0;
            userLb.Text = "User Id";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.Location = new Point(339, 50);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(178, 38);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Đăng nhập";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 450);
            Controls.Add(layoutPanel);
            Name = "loginForm";
            Text = "Đăng nhập";
            FormClosed += loginForm_FormClosed;
            Load += loginForm_Load;
            layoutPanel.ResumeLayout(false);
            layoutPanel.PerformLayout();
            inforGB.ResumeLayout(false);
            inforGB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel layoutPanel;
        private GroupBox inforGB;
        private Label loginLabel;
        private TextBox passTxt;
        private Label passLb;
        private TextBox userTxt;
        private Label userLb;
        private Button submitBtn;
        private LinkLabel signUpLLB;
        private LinkLabel forgotPassLLB;
        private Button exitBtn;
    }
}
