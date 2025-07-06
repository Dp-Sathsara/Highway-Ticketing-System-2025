namespace Highway_Ticketing_System
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxUserID = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(174, 46);
            label1.Name = "label1";
            label1.Size = new Size(111, 40);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(191, 194);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 1;
            label2.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(182, 322);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBoxUserID
            // 
            textBoxUserID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserID.Location = new Point(129, 241);
            textBoxUserID.Name = "textBoxUserID";
            textBoxUserID.Size = new Size(212, 33);
            textBoxUserID.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(129, 380);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(212, 33);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.MidnightBlue;
            buttonLogin.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(174, 497);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(111, 41);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(484, 661);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxUserID;
        private TextBox textBoxPassword;
        private Button buttonLogin;
    }
}