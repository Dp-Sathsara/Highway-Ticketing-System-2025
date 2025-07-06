namespace Highway_Ticketing_System
{
    partial class Form6
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
            button1 = new Button();
            txtVehicleNo = new TextBox();
            txtVehicleType = new TextBox();
            label4 = new Label();
            cmbHighwayExit = new ComboBox();
            buttonBack = new Button();
            label5 = new Label();
            textBoxEntranceTime = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 177);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "Vehicle No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(195, 282);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 1;
            label2.Text = "Vehicle Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(195, 374);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 2;
            label3.Text = "Highway Exit:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(600, 606);
            button1.Name = "button1";
            button1.Size = new Size(106, 42);
            button1.TabIndex = 3;
            button1.Text = "Bill";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtVehicleNo
            // 
            txtVehicleNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleNo.Location = new Point(383, 169);
            txtVehicleNo.Name = "txtVehicleNo";
            txtVehicleNo.Size = new Size(323, 33);
            txtVehicleNo.TabIndex = 4;
            // 
            // txtVehicleType
            // 
            txtVehicleType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleType.Location = new Point(383, 274);
            txtVehicleType.Name = "txtVehicleType";
            txtVehicleType.Size = new Size(323, 33);
            txtVehicleType.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(383, 21);
            label4.Name = "label4";
            label4.Size = new Size(205, 40);
            label4.TabIndex = 6;
            label4.Text = "Exit Details";
            // 
            // cmbHighwayExit
            // 
            cmbHighwayExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbHighwayExit.FormattingEnabled = true;
            cmbHighwayExit.Location = new Point(383, 366);
            cmbHighwayExit.Name = "cmbHighwayExit";
            cmbHighwayExit.Size = new Size(323, 33);
            cmbHighwayExit.TabIndex = 7;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.DarkGreen;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(383, 606);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(111, 42);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(195, 466);
            label5.Name = "label5";
            label5.Size = new Size(139, 25);
            label5.TabIndex = 9;
            label5.Text = "Entrance Time:";
            // 
            // textBoxEntranceTime
            // 
            textBoxEntranceTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEntranceTime.Location = new Point(383, 458);
            textBoxEntranceTime.Name = "textBoxEntranceTime";
            textBoxEntranceTime.Size = new Size(323, 33);
            textBoxEntranceTime.TabIndex = 10;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(984, 761);
            Controls.Add(textBoxEntranceTime);
            Controls.Add(label5);
            Controls.Add(buttonBack);
            Controls.Add(cmbHighwayExit);
            Controls.Add(label4);
            Controls.Add(txtVehicleType);
            Controls.Add(txtVehicleNo);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtVehicleNo;
        private TextBox txtVehicleType;
        private Label label4;
        private ComboBox cmbHighwayExit;
        private Button buttonBack;
        private Label label5;
        private TextBox textBoxEntranceTime;
    }
}