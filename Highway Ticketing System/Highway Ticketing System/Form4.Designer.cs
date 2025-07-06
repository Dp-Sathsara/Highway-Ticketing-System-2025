namespace Highway_Ticketing_System
{
    partial class Form4
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
            labelSuccess = new Label();
            buttonContinue = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 56);
            label1.Name = "label1";
            label1.Size = new Size(313, 37);
            label1.TabIndex = 0;
            label1.Text = "Registration Successfull ";
            // 
            // labelSuccess
            // 
            labelSuccess.AutoSize = true;
            labelSuccess.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuccess.Location = new Point(120, 156);
            labelSuccess.Name = "labelSuccess";
            labelSuccess.Size = new Size(70, 30);
            labelSuccess.TabIndex = 1;
            labelSuccess.Text = "label2";
            // 
            // buttonContinue
            // 
            buttonContinue.BackColor = Color.DarkBlue;
            buttonContinue.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContinue.ForeColor = Color.White;
            buttonContinue.Location = new Point(158, 242);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(124, 39);
            buttonContinue.TabIndex = 2;
            buttonContinue.Text = "Continue";
            buttonContinue.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(466, 360);
            Controls.Add(buttonContinue);
            Controls.Add(labelSuccess);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelSuccess;
        private Button buttonContinue;
    }
}