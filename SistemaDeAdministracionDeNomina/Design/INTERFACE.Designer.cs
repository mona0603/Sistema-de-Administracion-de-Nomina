namespace SistemaDeAdministracionDeNomina.Design
{
    partial class INTERFACE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INTERFACE));
            this.if_welcome = new System.Windows.Forms.Label();
            this.if_username = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.if_lastlogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.if_help = new System.Windows.Forms.Button();
            this.if_manage = new System.Windows.Forms.Button();
            this.if_logout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uC_Cards6 = new SistemaDeAdministracionDeNomina.UC_Cards();
            this.uC_Cards5 = new SistemaDeAdministracionDeNomina.UC_Cards();
            this.uC_Cards4 = new SistemaDeAdministracionDeNomina.UC_Cards();
            this.uC_Cards3 = new SistemaDeAdministracionDeNomina.UC_Cards();
            this.uC_Cards2 = new SistemaDeAdministracionDeNomina.UC_Cards();
            this.uC_Cards1 = new SistemaDeAdministracionDeNomina.UC_Cards();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // if_welcome
            // 
            this.if_welcome.AutoSize = true;
            this.if_welcome.BackColor = System.Drawing.Color.Transparent;
            this.if_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.if_welcome.Location = new System.Drawing.Point(60, 10);
            this.if_welcome.Name = "if_welcome";
            this.if_welcome.Size = new System.Drawing.Size(87, 20);
            this.if_welcome.TabIndex = 0;
            this.if_welcome.Text = "Welcome,";
            // 
            // if_username
            // 
            this.if_username.AutoSize = true;
            this.if_username.BackColor = System.Drawing.Color.Transparent;
            this.if_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.if_username.ForeColor = System.Drawing.Color.White;
            this.if_username.Location = new System.Drawing.Point(150, 10);
            this.if_username.Name = "if_username";
            this.if_username.Size = new System.Drawing.Size(91, 20);
            this.if_username.TabIndex = 1;
            this.if_username.Text = "Username";
            this.if_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.if_username.Click += new System.EventHandler(this.if_username_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(60, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last login:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // if_lastlogin
            // 
            this.if_lastlogin.AutoSize = true;
            this.if_lastlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.if_lastlogin.ForeColor = System.Drawing.Color.Gray;
            this.if_lastlogin.Location = new System.Drawing.Point(110, 30);
            this.if_lastlogin.Name = "if_lastlogin";
            this.if_lastlogin.Size = new System.Drawing.Size(89, 13);
            this.if_lastlogin.TabIndex = 13;
            this.if_lastlogin.Text = "7/31/2026 00:00";
            this.if_lastlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(30, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 5);
            this.panel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(30, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 5);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.if_lastlogin);
            this.panel2.Controls.Add(this.if_help);
            this.panel2.Controls.Add(this.if_manage);
            this.panel2.Controls.Add(this.if_username);
            this.panel2.Controls.Add(this.if_welcome);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.if_logout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 50);
            this.panel2.TabIndex = 21;
            // 
            // if_help
            // 
            this.if_help.BackColor = System.Drawing.Color.Transparent;
            this.if_help.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.help_web_button;
            this.if_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.if_help.Cursor = System.Windows.Forms.Cursors.Help;
            this.if_help.FlatAppearance.BorderSize = 0;
            this.if_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.if_help.Location = new System.Drawing.Point(900, 10);
            this.if_help.Name = "if_help";
            this.if_help.Size = new System.Drawing.Size(30, 30);
            this.if_help.TabIndex = 20;
            this.if_help.UseVisualStyleBackColor = false;
            // 
            // if_manage
            // 
            this.if_manage.BackColor = System.Drawing.Color.Transparent;
            this.if_manage.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.avatar;
            this.if_manage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.if_manage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.if_manage.FlatAppearance.BorderSize = 0;
            this.if_manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.if_manage.Location = new System.Drawing.Point(0, 0);
            this.if_manage.Name = "if_manage";
            this.if_manage.Size = new System.Drawing.Size(50, 50);
            this.if_manage.TabIndex = 10;
            this.if_manage.UseVisualStyleBackColor = false;
            this.if_manage.Click += new System.EventHandler(this.if_manage_Click);
            // 
            // if_logout
            // 
            this.if_logout.BackColor = System.Drawing.Color.Transparent;
            this.if_logout.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.salir;
            this.if_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.if_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.if_logout.FlatAppearance.BorderSize = 0;
            this.if_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.if_logout.Location = new System.Drawing.Point(950, 10);
            this.if_logout.Name = "if_logout";
            this.if_logout.Size = new System.Drawing.Size(30, 30);
            this.if_logout.TabIndex = 11;
            this.if_logout.UseVisualStyleBackColor = false;
            this.if_logout.Click += new System.EventHandler(this.if_logout_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 644);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(992, 50);
            this.panel4.TabIndex = 22;
            // 
            // uC_Cards6
            // 
            this.uC_Cards6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_Cards6.CardDescription = "System administration";
            this.uC_Cards6.CardImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.administration;
            this.uC_Cards6.CardImageSecond = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow1;
            this.uC_Cards6.CardTitle = "Administrators";
            this.uC_Cards6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_Cards6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uC_Cards6.Location = new System.Drawing.Point(510, 480);
            this.uC_Cards6.Name = "uC_Cards6";
            this.uC_Cards6.Size = new System.Drawing.Size(451, 135);
            this.uC_Cards6.TabIndex = 15;
            // 
            // uC_Cards5
            // 
            this.uC_Cards5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_Cards5.CardDescription = "Configurate charges";
            this.uC_Cards5.CardImage = ((System.Drawing.Image)(resources.GetObject("uC_Cards5.CardImage")));
            this.uC_Cards5.CardImageSecond = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow1;
            this.uC_Cards5.CardTitle = "Fiscal Configuration";
            this.uC_Cards5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_Cards5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uC_Cards5.Location = new System.Drawing.Point(30, 480);
            this.uC_Cards5.Name = "uC_Cards5";
            this.uC_Cards5.Size = new System.Drawing.Size(451, 135);
            this.uC_Cards5.TabIndex = 14;
            // 
            // uC_Cards4
            // 
            this.uC_Cards4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_Cards4.CardDescription = "Generate employees payroll";
            this.uC_Cards4.CardImage = global::SistemaDeAdministracionDeNomina.Properties.Resources._006_accounting;
            this.uC_Cards4.CardImageSecond = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow1;
            this.uC_Cards4.CardTitle = "Payroll Capture";
            this.uC_Cards4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_Cards4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uC_Cards4.Location = new System.Drawing.Point(510, 270);
            this.uC_Cards4.Name = "uC_Cards4";
            this.uC_Cards4.Size = new System.Drawing.Size(451, 135);
            this.uC_Cards4.TabIndex = 6;
            // 
            // uC_Cards3
            // 
            this.uC_Cards3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_Cards3.CardDescription = "Capture departments, positions, banks and more";
            this.uC_Cards3.CardImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.businessman;
            this.uC_Cards3.CardImageSecond = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow1;
            this.uC_Cards3.CardTitle = "Concepts";
            this.uC_Cards3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_Cards3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uC_Cards3.Location = new System.Drawing.Point(30, 270);
            this.uC_Cards3.Name = "uC_Cards3";
            this.uC_Cards3.Size = new System.Drawing.Size(451, 135);
            this.uC_Cards3.TabIndex = 5;
            // 
            // uC_Cards2
            // 
            this.uC_Cards2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_Cards2.CardDescription = "Catalogue of reports and analytics";
            this.uC_Cards2.CardImage = global::SistemaDeAdministracionDeNomina.Properties.Resources._003_book;
            this.uC_Cards2.CardImageSecond = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow1;
            this.uC_Cards2.CardTitle = "Catalogue";
            this.uC_Cards2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_Cards2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uC_Cards2.Location = new System.Drawing.Point(510, 110);
            this.uC_Cards2.Name = "uC_Cards2";
            this.uC_Cards2.Size = new System.Drawing.Size(451, 135);
            this.uC_Cards2.TabIndex = 4;
            // 
            // uC_Cards1
            // 
            this.uC_Cards1.BackColor = System.Drawing.Color.Transparent;
            this.uC_Cards1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_Cards1.CardDescription = "Capture employees data and aditional information";
            this.uC_Cards1.CardImage = global::SistemaDeAdministracionDeNomina.Properties.Resources._007_gig_economy;
            this.uC_Cards1.CardImageSecond = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow1;
            this.uC_Cards1.CardTitle = "Employees";
            this.uC_Cards1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_Cards1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uC_Cards1.Location = new System.Drawing.Point(30, 110);
            this.uC_Cards1.Name = "uC_Cards1";
            this.uC_Cards1.Size = new System.Drawing.Size(451, 135);
            this.uC_Cards1.TabIndex = 3;
            this.uC_Cards1.Load += new System.EventHandler(this.uC_Cards1_Load);
            // 
            // INTERFACE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(992, 694);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uC_Cards6);
            this.Controls.Add(this.uC_Cards5);
            this.Controls.Add(this.uC_Cards4);
            this.Controls.Add(this.uC_Cards3);
            this.Controls.Add(this.uC_Cards2);
            this.Controls.Add(this.uC_Cards1);
            this.Name = "INTERFACE";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.INTERFACE_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label if_welcome;
        private System.Windows.Forms.Label if_username;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UC_Cards uC_Cards1;
        private UC_Cards uC_Cards2;
        private UC_Cards uC_Cards3;
        private UC_Cards uC_Cards4;
        private System.Windows.Forms.Button if_manage;
        private System.Windows.Forms.Button if_logout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label if_lastlogin;
        private UC_Cards uC_Cards5;
        private UC_Cards uC_Cards6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button if_help;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}