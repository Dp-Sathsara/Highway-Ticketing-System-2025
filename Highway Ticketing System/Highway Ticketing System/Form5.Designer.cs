namespace Highway_Ticketing_System
{
    partial class Form5
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSave = new Button();
            label9 = new Label();
            txtVehicleNo = new TextBox();
            txtSearchVehicleNo = new TextBox();
            cmbVehicleType = new ComboBox();
            cmbEntrance = new ComboBox();
            btnSearch = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip3 = new ContextMenuStrip(components);
            contextMenuStrip4 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem1 = new ToolStripMenuItem();
            employeersDetailsToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            todayStatistToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Copperplate Gothic Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 80);
            label1.Name = "label1";
            label1.Size = new Size(214, 41);
            label1.TabIndex = 1;
            label1.Text = "High Way";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Copperplate Gothic Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(439, 80);
            label2.Name = "label2";
            label2.Size = new Size(216, 41);
            label2.TabIndex = 2;
            label2.Text = "Ticketing\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Copperplate Gothic Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(672, 80);
            label3.Name = "label3";
            label3.Size = new Size(165, 41);
            label3.TabIndex = 3;
            label3.Text = "System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 194);
            label4.Name = "label4";
            label4.Size = new Size(257, 36);
            label4.TabIndex = 4;
            label4.Text = "Entrance Details:\r\n";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(688, 194);
            label5.Name = "label5";
            label5.Size = new Size(182, 36);
            label5.TabIndex = 5;
            label5.Text = "Exit Details:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(86, 273);
            label6.Name = "label6";
            label6.Size = new Size(119, 30);
            label6.TabIndex = 6;
            label6.Text = "Vehicle No:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(86, 376);
            label7.Name = "label7";
            label7.Size = new Size(136, 30);
            label7.TabIndex = 7;
            label7.Text = "Vehicle Type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(86, 484);
            label8.Name = "label8";
            label8.Size = new Size(101, 30);
            label8.TabIndex = 8;
            label8.Text = "Entrance:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(163, 637);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 36);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(688, 273);
            label9.Name = "label9";
            label9.Size = new Size(188, 30);
            label9.TabIndex = 10;
            label9.Text = "Search Vehicle No:";
            // 
            // txtVehicleNo
            // 
            txtVehicleNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleNo.Location = new Point(86, 319);
            txtVehicleNo.Name = "txtVehicleNo";
            txtVehicleNo.Size = new Size(260, 33);
            txtVehicleNo.TabIndex = 11;
            // 
            // txtSearchVehicleNo
            // 
            txtSearchVehicleNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchVehicleNo.Location = new Point(688, 319);
            txtSearchVehicleNo.Name = "txtSearchVehicleNo";
            txtSearchVehicleNo.Size = new Size(188, 33);
            txtSearchVehicleNo.TabIndex = 12;
            txtSearchVehicleNo.TextChanged += txtSearchVehicleNo_TextChanged;
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Location = new Point(86, 434);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(260, 33);
            cmbVehicleType.TabIndex = 13;
            // 
            // cmbEntrance
            // 
            cmbEntrance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEntrance.FormattingEnabled = true;
            cmbEntrance.Location = new Point(86, 543);
            cmbEntrance.Name = "cmbEntrance";
            cmbEntrance.Size = new Size(260, 33);
            cmbEntrance.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(730, 376);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(117, 41);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(106, 26);
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(105, 22);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.Name = "contextMenuStrip4";
            contextMenuStrip4.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem1, helpToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(264, 36);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem1
            // 
            menuToolStripMenuItem1.BackColor = Color.DarkGray;
            menuToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { employeersDetailsToolStripMenuItem, registerToolStripMenuItem, todayStatistToolStripMenuItem, logoutToolStripMenuItem });
            menuToolStripMenuItem1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuToolStripMenuItem1.ForeColor = Color.Black;
            menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            menuToolStripMenuItem1.Size = new Size(86, 32);
            menuToolStripMenuItem1.Text = "Menu";
            // 
            // employeersDetailsToolStripMenuItem
            // 
            employeersDetailsToolStripMenuItem.BackColor = Color.Tan;
            employeersDetailsToolStripMenuItem.Name = "employeersDetailsToolStripMenuItem";
            employeersDetailsToolStripMenuItem.Size = new Size(309, 32);
            employeersDetailsToolStripMenuItem.Text = "Employeers Details";
            employeersDetailsToolStripMenuItem.Click += employeersDetailsToolStripMenuItem_Click;
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.BackColor = Color.NavajoWhite;
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(309, 32);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // todayStatistToolStripMenuItem
            // 
            todayStatistToolStripMenuItem.BackColor = Color.BlanchedAlmond;
            todayStatistToolStripMenuItem.Name = "todayStatistToolStripMenuItem";
            todayStatistToolStripMenuItem.Size = new Size(309, 32);
            todayStatistToolStripMenuItem.Text = "Today Statistics";
            todayStatistToolStripMenuItem.Click += todayStatistToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.BackColor = Color.AntiqueWhite;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(309, 32);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.BackColor = Color.LightGray;
            helpToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(78, 32);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.BackColor = Color.LightGray;
            aboutToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(92, 32);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 761);
            Controls.Add(menuStrip1);
            Controls.Add(btnSearch);
            Controls.Add(cmbEntrance);
            Controls.Add(cmbVehicleType);
            Controls.Add(txtSearchVehicleNo);
            Controls.Add(txtVehicleNo);
            Controls.Add(label9);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSave;
        private Label label9;
        private TextBox txtVehicleNo;
        private TextBox txtSearchVehicleNo;
        private ComboBox cmbVehicleType;
        private ComboBox cmbEntrance;
        private Button btnSearch;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ContextMenuStrip contextMenuStrip4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem1;
        private ToolStripMenuItem employeersDetailsToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem todayStatistToolStripMenuItem;
    }
}