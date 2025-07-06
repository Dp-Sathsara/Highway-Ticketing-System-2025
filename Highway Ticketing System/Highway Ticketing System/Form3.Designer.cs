namespace Highway_Ticketing_System
{
    partial class Form3
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxName = new TextBox();
            textBoxNIC = new TextBox();
            textBoxAddress = new TextBox();
            textBoxAge = new TextBox();
            textBoxPassword = new TextBox();
            textBoxRePassword = new TextBox();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(413, 23);
            label1.Name = "label1";
            label1.Size = new Size(161, 40);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(132, 134);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(133, 220);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 2;
            label3.Text = "NIC:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(132, 301);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 3;
            label4.Text = "Address:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(132, 394);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 4;
            label5.Text = "Age:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(132, 485);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 5;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(132, 568);
            label7.Name = "label7";
            label7.Size = new Size(175, 25);
            label7.TabIndex = 6;
            label7.Text = "Re-enter Password:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(332, 126);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(322, 33);
            textBoxName.TabIndex = 7;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // textBoxNIC
            // 
            textBoxNIC.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNIC.Location = new Point(332, 212);
            textBoxNIC.Name = "textBoxNIC";
            textBoxNIC.Size = new Size(322, 33);
            textBoxNIC.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAddress.Location = new Point(330, 293);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(324, 33);
            textBoxAddress.TabIndex = 9;
            // 
            // textBoxAge
            // 
            textBoxAge.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAge.Location = new Point(330, 386);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(324, 33);
            textBoxAge.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(332, 477);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(322, 33);
            textBoxPassword.TabIndex = 11;
            // 
            // textBoxRePassword
            // 
            textBoxRePassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRePassword.Location = new Point(330, 560);
            textBoxRePassword.Name = "textBoxRePassword";
            textBoxRePassword.Size = new Size(324, 33);
            textBoxRePassword.TabIndex = 12;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.DarkBlue;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(413, 655);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(128, 48);
            buttonRegister.TabIndex = 13;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(984, 761);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxRePassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxNIC);
            Controls.Add(textBoxName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxName;
        private TextBox textBoxNIC;
        private TextBox textBoxAddress;
        private TextBox textBoxAge;
        private TextBox textBoxPassword;
        private TextBox textBoxRePassword;
        private Button buttonRegister;
    }
}