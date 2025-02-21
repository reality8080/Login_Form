namespace Login_Form
{
    partial class forgotPass
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
            panelLayout = new Panel();
            resultLb = new Label();
            submitBtn = new Button();
            forgotLb = new Label();
            infoGB = new GroupBox();
            serialTxt = new TextBox();
            serialNumberlb = new Label();
            emailTxt = new TextBox();
            emailLb = new Label();
            panelLayout.SuspendLayout();
            infoGB.SuspendLayout();
            SuspendLayout();
            // 
            // panelLayout
            // 
            panelLayout.Controls.Add(resultLb);
            panelLayout.Controls.Add(submitBtn);
            panelLayout.Controls.Add(forgotLb);
            panelLayout.Controls.Add(infoGB);
            panelLayout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelLayout.Location = new Point(12, 12);
            panelLayout.Name = "panelLayout";
            panelLayout.Size = new Size(513, 426);
            panelLayout.TabIndex = 0;
            // 
            // resultLb
            // 
            resultLb.AutoSize = true;
            resultLb.Location = new Point(85, 270);
            resultLb.Name = "resultLb";
            resultLb.Size = new Size(71, 22);
            resultLb.TabIndex = 3;
            resultLb.Text = "Result: ";
            resultLb.Visible = false;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(350, 337);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(104, 43);
            submitBtn.TabIndex = 2;
            submitBtn.Text = "Nhập";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // forgotLb
            // 
            forgotLb.AutoSize = true;
            forgotLb.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotLb.Location = new Point(157, 34);
            forgotLb.Name = "forgotLb";
            forgotLb.Size = new Size(223, 39);
            forgotLb.TabIndex = 1;
            forgotLb.Text = "Quên mật khẩu";
            // 
            // infoGB
            // 
            infoGB.Controls.Add(serialTxt);
            infoGB.Controls.Add(serialNumberlb);
            infoGB.Controls.Add(emailTxt);
            infoGB.Controls.Add(emailLb);
            infoGB.Location = new Point(3, 110);
            infoGB.Name = "infoGB";
            infoGB.Size = new Size(507, 134);
            infoGB.TabIndex = 0;
            infoGB.TabStop = false;
            infoGB.Text = "Thông tin";
            // 
            // serialTxt
            // 
            serialTxt.Location = new Point(236, 53);
            serialTxt.Name = "serialTxt";
            serialTxt.Size = new Size(215, 30);
            serialTxt.TabIndex = 3;
            serialTxt.Visible = false;
            // 
            // serialNumberlb
            // 
            serialNumberlb.AutoSize = true;
            serialNumberlb.Location = new Point(82, 53);
            serialNumberlb.Name = "serialNumberlb";
            serialNumberlb.Size = new Size(126, 22);
            serialNumberlb.TabIndex = 2;
            serialNumberlb.Text = "Serial Number";
            serialNumberlb.Visible = false;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(236, 53);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(215, 30);
            emailTxt.TabIndex = 1;
            // 
            // emailLb
            // 
            emailLb.AutoSize = true;
            emailLb.Location = new Point(82, 53);
            emailLb.Name = "emailLb";
            emailLb.Size = new Size(57, 22);
            emailLb.TabIndex = 0;
            emailLb.Text = "Email";
            // 
            // forgotPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 450);
            Controls.Add(panelLayout);
            Name = "forgotPass";
            Text = "forgotPass";
            Load += forgotPass_Load;
            panelLayout.ResumeLayout(false);
            panelLayout.PerformLayout();
            infoGB.ResumeLayout(false);
            infoGB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLayout;
        private Label forgotLb;
        private GroupBox infoGB;
        private TextBox emailTxt;
        private Label emailLb;
        private Button submitBtn;
        private Label resultLb;
        private TextBox serialTxt;
        private Label serialNumberlb;
    }
}