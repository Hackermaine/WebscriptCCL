namespace WebscriptCCL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_manager = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_manager = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_apps = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rad_COS = new System.Windows.Forms.RadioButton();
            this.rad_GNB = new System.Windows.Forms.RadioButton();
            this.rad_SAN = new System.Windows.Forms.RadioButton();
            this.dropDept = new System.Windows.Forms.ComboBox();
            this.chk_apps = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(203, 84);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(204, 23);
            this.txt_username.TabIndex = 0;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged_1);
            // 
            // txt_manager
            // 
            this.txt_manager.Location = new System.Drawing.Point(203, 113);
            this.txt_manager.Name = "txt_manager";
            this.txt_manager.Size = new System.Drawing.Size(204, 23);
            this.txt_manager.TabIndex = 1;
            this.txt_manager.TextChanged += new System.EventHandler(this.txt_manager_TextChanged);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.Location = new System.Drawing.Point(12, 85);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(92, 22);
            this.lbl_username.TabIndex = 7;
            this.lbl_username.Text = "Username";
            // 
            // lbl_manager
            // 
            this.lbl_manager.AutoSize = true;
            this.lbl_manager.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_manager.Location = new System.Drawing.Point(12, 114);
            this.lbl_manager.Name = "lbl_manager";
            this.lbl_manager.Size = new System.Drawing.Size(185, 22);
            this.lbl_manager.TabIndex = 12;
            this.lbl_manager.Text = "Manager\'s Username";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_location.Location = new System.Drawing.Point(12, 143);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(82, 22);
            this.lbl_location.TabIndex = 13;
            this.lbl_location.Text = "Location";
            this.lbl_location.UseWaitCursor = true;
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_department.Location = new System.Drawing.Point(12, 172);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(107, 22);
            this.lbl_department.TabIndex = 14;
            this.lbl_department.Text = "Department";
            // 
            // lbl_apps
            // 
            this.lbl_apps.AutoSize = true;
            this.lbl_apps.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_apps.Location = new System.Drawing.Point(12, 201);
            this.lbl_apps.Name = "lbl_apps";
            this.lbl_apps.Size = new System.Drawing.Size(111, 22);
            this.lbl_apps.TabIndex = 15;
            this.lbl_apps.Text = "Applications";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(13, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(459, 54);
            this.label10.TabIndex = 16;
            this.label10.Text = "Lazy SysAdmin Script";
            // 
            // rad_COS
            // 
            this.rad_COS.AutoSize = true;
            this.rad_COS.Location = new System.Drawing.Point(203, 146);
            this.rad_COS.Name = "rad_COS";
            this.rad_COS.Size = new System.Drawing.Size(48, 19);
            this.rad_COS.TabIndex = 18;
            this.rad_COS.TabStop = true;
            this.rad_COS.Text = "COS";
            this.rad_COS.UseVisualStyleBackColor = true;
            this.rad_COS.CheckedChanged += new System.EventHandler(this.rad_COS_CheckedChanged);
            // 
            // rad_GNB
            // 
            this.rad_GNB.AutoSize = true;
            this.rad_GNB.Location = new System.Drawing.Point(311, 146);
            this.rad_GNB.Name = "rad_GNB";
            this.rad_GNB.Size = new System.Drawing.Size(49, 19);
            this.rad_GNB.TabIndex = 19;
            this.rad_GNB.TabStop = true;
            this.rad_GNB.Text = "GNB";
            this.rad_GNB.UseVisualStyleBackColor = true;
            this.rad_GNB.CheckedChanged += new System.EventHandler(this.rad_GNB_CheckedChanged);
            // 
            // rad_SAN
            // 
            this.rad_SAN.AutoSize = true;
            this.rad_SAN.Location = new System.Drawing.Point(257, 146);
            this.rad_SAN.Name = "rad_SAN";
            this.rad_SAN.Size = new System.Drawing.Size(48, 19);
            this.rad_SAN.TabIndex = 20;
            this.rad_SAN.TabStop = true;
            this.rad_SAN.Text = "SAN";
            this.rad_SAN.UseVisualStyleBackColor = true;
            this.rad_SAN.CheckedChanged += new System.EventHandler(this.rad_SAN_CheckedChanged);
            // 
            // dropDept
            // 
            this.dropDept.FormattingEnabled = true;
            this.dropDept.Items.AddRange(new object[] {
            "Information Technology",
            "Facilities Management",
            "Janitorial",
            "Sales",
            "Accounting",
            "Fitness",
            "Coaching"});
            this.dropDept.Location = new System.Drawing.Point(203, 171);
            this.dropDept.Name = "dropDept";
            this.dropDept.Size = new System.Drawing.Size(204, 23);
            this.dropDept.TabIndex = 21;
            this.dropDept.SelectedIndexChanged += new System.EventHandler(this.dropDept_SelectedIndexChanged);
            // 
            // chk_apps
            // 
            this.chk_apps.FormattingEnabled = true;
            this.chk_apps.Items.AddRange(new object[] {
            "D365",
            "Adobe CC",
            "Firefox",
            "Chrome",
            "DameWare"});
            this.chk_apps.Location = new System.Drawing.Point(203, 208);
            this.chk_apps.Name = "chk_apps";
            this.chk_apps.Size = new System.Drawing.Size(204, 202);
            this.chk_apps.TabIndex = 22;
            this.chk_apps.SelectedIndexChanged += new System.EventHandler(this.chk_apps_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WebscriptCCL.Properties.Resources.ccl;
            this.pictureBox1.Location = new System.Drawing.Point(436, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(497, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 68);
            this.button1.TabIndex = 24;
            this.button1.Text = "Generate Ticket Windows";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 79);
            this.panel1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chk_apps);
            this.Controls.Add(this.dropDept);
            this.Controls.Add(this.rad_SAN);
            this.Controls.Add(this.rad_GNB);
            this.Controls.Add(this.rad_COS);
            this.Controls.Add(this.lbl_apps);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.lbl_manager);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_manager);
            this.Controls.Add(this.txt_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCL New User Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_username;
        private TextBox txt_manager;
        private Label lbl_username;
        private Label lbl_manager;
        private Label lbl_location;
        private Label lbl_department;
        private Label lbl_apps;
        private Label label10;
        private RadioButton rad_COS;
        private RadioButton rad_GNB;
        private RadioButton rad_SAN;
        private ComboBox dropDept;
        private CheckedListBox chk_apps;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel1;
    }
}