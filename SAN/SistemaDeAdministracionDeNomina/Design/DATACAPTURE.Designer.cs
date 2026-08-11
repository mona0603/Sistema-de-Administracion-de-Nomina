namespace SistemaDeAdministracionDeNomina.Design
{
    partial class DATACAPTURE
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
            this.d_paneltop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.d_panelcontent = new System.Windows.Forms.Panel();
            this.d_division = new System.Windows.Forms.Panel();
            this.d_menustrip = new System.Windows.Forms.MenuStrip();
            this.d_sidebar = new System.Windows.Forms.Panel();
            this.d_help = new System.Windows.Forms.Button();
            this.d_exit = new System.Windows.Forms.Button();
            this.d_back = new System.Windows.Forms.Button();
            this.d_uC_Modules4 = new SistemaDeAdministracionDeNomina.UserControls.UC_Modules();
            this.d_uC_Modules3 = new SistemaDeAdministracionDeNomina.UserControls.UC_Modules();
            this.d_uC_Modules2 = new SistemaDeAdministracionDeNomina.UserControls.UC_Modules();
            this.d_uC_Modules1 = new SistemaDeAdministracionDeNomina.UserControls.UC_Modules();
            this.d_paneltop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.d_sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // d_paneltop
            // 
            this.d_paneltop.BackColor = System.Drawing.Color.White;
            this.d_paneltop.Controls.Add(this.d_help);
            this.d_paneltop.Controls.Add(this.d_exit);
            this.d_paneltop.Controls.Add(this.label1);
            this.d_paneltop.Controls.Add(this.d_back);
            this.d_paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.d_paneltop.Location = new System.Drawing.Point(0, 0);
            this.d_paneltop.Name = "d_paneltop";
            this.d_paneltop.Size = new System.Drawing.Size(975, 45);
            this.d_paneltop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(66, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Back";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.d_panelcontent);
            this.panel2.Controls.Add(this.d_sidebar);
            this.panel2.Controls.Add(this.d_division);
            this.panel2.Controls.Add(this.d_menustrip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 896);
            this.panel2.TabIndex = 1;
            // 
            // d_panelcontent
            // 
            this.d_panelcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d_panelcontent.Location = new System.Drawing.Point(168, 34);
            this.d_panelcontent.Name = "d_panelcontent";
            this.d_panelcontent.Size = new System.Drawing.Size(807, 862);
            this.d_panelcontent.TabIndex = 3;
            // 
            // d_division
            // 
            this.d_division.Dock = System.Windows.Forms.DockStyle.Top;
            this.d_division.Location = new System.Drawing.Point(0, 29);
            this.d_division.Name = "d_division";
            this.d_division.Size = new System.Drawing.Size(975, 5);
            this.d_division.TabIndex = 1;
            // 
            // d_menustrip
            // 
            this.d_menustrip.BackColor = System.Drawing.Color.Gold;
            this.d_menustrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.d_menustrip.Location = new System.Drawing.Point(0, 0);
            this.d_menustrip.Name = "d_menustrip";
            this.d_menustrip.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.d_menustrip.Size = new System.Drawing.Size(975, 29);
            this.d_menustrip.TabIndex = 0;
            this.d_menustrip.Text = "menuStrip1";
            // 
            // d_sidebar
            // 
            this.d_sidebar.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.bg;
            this.d_sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d_sidebar.Controls.Add(this.d_uC_Modules4);
            this.d_sidebar.Controls.Add(this.d_uC_Modules3);
            this.d_sidebar.Controls.Add(this.d_uC_Modules2);
            this.d_sidebar.Controls.Add(this.d_uC_Modules1);
            this.d_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.d_sidebar.Location = new System.Drawing.Point(0, 34);
            this.d_sidebar.Name = "d_sidebar";
            this.d_sidebar.Size = new System.Drawing.Size(168, 862);
            this.d_sidebar.TabIndex = 2;
            // 
            // d_help
            // 
            this.d_help.BackColor = System.Drawing.Color.Transparent;
            this.d_help.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.help_web_button;
            this.d_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d_help.FlatAppearance.BorderSize = 0;
            this.d_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_help.Location = new System.Drawing.Point(888, 6);
            this.d_help.Name = "d_help";
            this.d_help.Size = new System.Drawing.Size(30, 30);
            this.d_help.TabIndex = 21;
            this.d_help.UseVisualStyleBackColor = false;
            // 
            // d_exit
            // 
            this.d_exit.BackColor = System.Drawing.Color.Transparent;
            this.d_exit.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.salir;
            this.d_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.d_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.d_exit.FlatAppearance.BorderSize = 0;
            this.d_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_exit.Location = new System.Drawing.Point(936, 6);
            this.d_exit.Name = "d_exit";
            this.d_exit.Padding = new System.Windows.Forms.Padding(5);
            this.d_exit.Size = new System.Drawing.Size(30, 30);
            this.d_exit.TabIndex = 2;
            this.d_exit.UseVisualStyleBackColor = false;
            // 
            // d_back
            // 
            this.d_back.BackColor = System.Drawing.Color.Transparent;
            this.d_back.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.left_arrow1;
            this.d_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.d_back.FlatAppearance.BorderSize = 0;
            this.d_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_back.Location = new System.Drawing.Point(12, 6);
            this.d_back.Name = "d_back";
            this.d_back.Size = new System.Drawing.Size(35, 35);
            this.d_back.TabIndex = 0;
            this.d_back.UseVisualStyleBackColor = false;
            this.d_back.Click += new System.EventHandler(this.d_back_Click_1);
            // 
            // d_uC_Modules4
            // 
            this.d_uC_Modules4.BackColor = System.Drawing.Color.Transparent;
            this.d_uC_Modules4.CardImage = global::SistemaDeAdministracionDeNomina.Properties.Resources._006_accounting;
            this.d_uC_Modules4.CardTitle = "Payroll C";
            this.d_uC_Modules4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d_uC_Modules4.GoIconNormal = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow;
            this.d_uC_Modules4.GoIconSeleccionado = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow1;
            this.d_uC_Modules4.IsSelected = false;
            this.d_uC_Modules4.Location = new System.Drawing.Point(0, 180);
            this.d_uC_Modules4.Name = "d_uC_Modules4";
            this.d_uC_Modules4.Size = new System.Drawing.Size(168, 46);
            this.d_uC_Modules4.TabIndex = 3;
            // 
            // d_uC_Modules3
            // 
            this.d_uC_Modules3.BackColor = System.Drawing.Color.Transparent;
            this.d_uC_Modules3.CardImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.businessman;
            this.d_uC_Modules3.CardTitle = "Concepts";
            this.d_uC_Modules3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d_uC_Modules3.GoIconNormal = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow;
            this.d_uC_Modules3.GoIconSeleccionado = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow1;
            this.d_uC_Modules3.IsSelected = false;
            this.d_uC_Modules3.Location = new System.Drawing.Point(0, 120);
            this.d_uC_Modules3.Name = "d_uC_Modules3";
            this.d_uC_Modules3.Size = new System.Drawing.Size(168, 46);
            this.d_uC_Modules3.TabIndex = 2;
            // 
            // d_uC_Modules2
            // 
            this.d_uC_Modules2.BackColor = System.Drawing.Color.Transparent;
            this.d_uC_Modules2.CardImage = global::SistemaDeAdministracionDeNomina.Properties.Resources._003_book;
            this.d_uC_Modules2.CardTitle = "Catalogue";
            this.d_uC_Modules2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d_uC_Modules2.GoIconNormal = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow;
            this.d_uC_Modules2.GoIconSeleccionado = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow1;
            this.d_uC_Modules2.IsSelected = false;
            this.d_uC_Modules2.Location = new System.Drawing.Point(0, 60);
            this.d_uC_Modules2.Name = "d_uC_Modules2";
            this.d_uC_Modules2.Size = new System.Drawing.Size(168, 46);
            this.d_uC_Modules2.TabIndex = 1;
            // 
            // d_uC_Modules1
            // 
            this.d_uC_Modules1.BackColor = System.Drawing.Color.Transparent;
            this.d_uC_Modules1.CardImage = global::SistemaDeAdministracionDeNomina.Properties.Resources._007_gig_economy;
            this.d_uC_Modules1.CardTitle = "Employees";
            this.d_uC_Modules1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d_uC_Modules1.GoIconNormal = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow;
            this.d_uC_Modules1.GoIconSeleccionado = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow1;
            this.d_uC_Modules1.IsSelected = false;
            this.d_uC_Modules1.Location = new System.Drawing.Point(0, 0);
            this.d_uC_Modules1.Name = "d_uC_Modules1";
            this.d_uC_Modules1.Size = new System.Drawing.Size(168, 46);
            this.d_uC_Modules1.TabIndex = 0;
            this.d_uC_Modules1.Load += new System.EventHandler(this.d_uC_Modules1_Load);
            // 
            // DATACAPTURE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 941);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.d_paneltop);
            this.Name = "DATACAPTURE";
            this.Load += new System.EventHandler(this.DATACAPTURE_Load);
            this.d_paneltop.ResumeLayout(false);
            this.d_paneltop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.d_sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel d_paneltop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button d_back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip d_menustrip;
        private System.Windows.Forms.Button d_exit;
        private System.Windows.Forms.Panel d_sidebar;
        private System.Windows.Forms.Panel d_division;
        private System.Windows.Forms.Panel d_panelcontent;
        private UserControls.UC_Modules d_uC_Modules2;
        private UserControls.UC_Modules d_uC_Modules1;
        private UserControls.UC_Modules d_uC_Modules4;
        private UserControls.UC_Modules d_uC_Modules3;
        private System.Windows.Forms.Button d_help;
    }
}