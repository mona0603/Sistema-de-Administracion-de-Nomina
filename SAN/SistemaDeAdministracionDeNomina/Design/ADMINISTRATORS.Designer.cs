namespace SistemaDeAdministracionDeNomina.Design
{
    partial class ADMINISTRATORS
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
            this.a_paneltop = new System.Windows.Forms.Panel();
            this.a_help = new System.Windows.Forms.Button();
            this.a_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.a_back = new System.Windows.Forms.Button();
            this.a_panelmenu = new System.Windows.Forms.Panel();
            this.a_menustrip = new System.Windows.Forms.MenuStrip();
            this.a_menu_op1 = new System.Windows.Forms.ToolStripMenuItem();
            this.a_menu_op2 = new System.Windows.Forms.ToolStripMenuItem();
            this.a_division = new System.Windows.Forms.Panel();
            this.a_panelcontent = new System.Windows.Forms.Panel();
            this.a_paneltop.SuspendLayout();
            this.a_panelmenu.SuspendLayout();
            this.a_menustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // a_paneltop
            // 
            this.a_paneltop.BackColor = System.Drawing.Color.White;
            this.a_paneltop.Controls.Add(this.a_help);
            this.a_paneltop.Controls.Add(this.a_exit);
            this.a_paneltop.Controls.Add(this.label1);
            this.a_paneltop.Controls.Add(this.a_back);
            this.a_paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.a_paneltop.Location = new System.Drawing.Point(0, 0);
            this.a_paneltop.Name = "a_paneltop";
            this.a_paneltop.Size = new System.Drawing.Size(805, 45);
            this.a_paneltop.TabIndex = 1;
            // 
            // a_help
            // 
            this.a_help.BackColor = System.Drawing.Color.Transparent;
            this.a_help.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.help_web_button;
            this.a_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a_help.FlatAppearance.BorderSize = 0;
            this.a_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_help.Location = new System.Drawing.Point(712, 8);
            this.a_help.Name = "a_help";
            this.a_help.Size = new System.Drawing.Size(30, 30);
            this.a_help.TabIndex = 21;
            this.a_help.UseVisualStyleBackColor = false;
            // 
            // a_exit
            // 
            this.a_exit.BackColor = System.Drawing.Color.Transparent;
            this.a_exit.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.salir;
            this.a_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.a_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.a_exit.FlatAppearance.BorderSize = 0;
            this.a_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_exit.Location = new System.Drawing.Point(760, 8);
            this.a_exit.Name = "a_exit";
            this.a_exit.Padding = new System.Windows.Forms.Padding(5);
            this.a_exit.Size = new System.Drawing.Size(30, 30);
            this.a_exit.TabIndex = 2;
            this.a_exit.UseVisualStyleBackColor = false;
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
            // a_back
            // 
            this.a_back.BackColor = System.Drawing.Color.Transparent;
            this.a_back.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.left_arrow1;
            this.a_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.a_back.FlatAppearance.BorderSize = 0;
            this.a_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_back.Location = new System.Drawing.Point(12, 6);
            this.a_back.Name = "a_back";
            this.a_back.Size = new System.Drawing.Size(35, 35);
            this.a_back.TabIndex = 0;
            this.a_back.UseVisualStyleBackColor = false;
            this.a_back.Click += new System.EventHandler(this.a_back_Click);
            // 
            // a_panelmenu
            // 
            this.a_panelmenu.Controls.Add(this.a_menustrip);
            this.a_panelmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.a_panelmenu.Location = new System.Drawing.Point(0, 45);
            this.a_panelmenu.Name = "a_panelmenu";
            this.a_panelmenu.Size = new System.Drawing.Size(805, 43);
            this.a_panelmenu.TabIndex = 2;
            // 
            // a_menustrip
            // 
            this.a_menustrip.BackColor = System.Drawing.Color.Gold;
            this.a_menustrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.a_menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.a_menu_op1,
            this.a_menu_op2});
            this.a_menustrip.Location = new System.Drawing.Point(0, 0);
            this.a_menustrip.Name = "a_menustrip";
            this.a_menustrip.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.a_menustrip.Size = new System.Drawing.Size(805, 43);
            this.a_menustrip.TabIndex = 0;
            this.a_menustrip.Text = "menuStrip1";
            this.a_menustrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.a_menustrip_ItemClicked);
            // 
            // a_menu_op1
            // 
            this.a_menu_op1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.a_menu_op1.ForeColor = System.Drawing.Color.White;
            this.a_menu_op1.Name = "a_menu_op1";
            this.a_menu_op1.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.a_menu_op1.Size = new System.Drawing.Size(79, 33);
            this.a_menu_op1.Text = "Users";
            // 
            // a_menu_op2
            // 
            this.a_menu_op2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.a_menu_op2.ForeColor = System.Drawing.Color.White;
            this.a_menu_op2.Name = "a_menu_op2";
            this.a_menu_op2.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.a_menu_op2.Size = new System.Drawing.Size(95, 33);
            this.a_menu_op2.Text = "Reports";
            // 
            // a_division
            // 
            this.a_division.Dock = System.Windows.Forms.DockStyle.Top;
            this.a_division.Location = new System.Drawing.Point(0, 88);
            this.a_division.Name = "a_division";
            this.a_division.Size = new System.Drawing.Size(805, 5);
            this.a_division.TabIndex = 3;
            this.a_division.Paint += new System.Windows.Forms.PaintEventHandler(this.a_division_Paint);
            // 
            // a_panelcontent
            // 
            this.a_panelcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.a_panelcontent.Location = new System.Drawing.Point(0, 93);
            this.a_panelcontent.Name = "a_panelcontent";
            this.a_panelcontent.Size = new System.Drawing.Size(805, 848);
            this.a_panelcontent.TabIndex = 6;
            // 
            // ADMINISTRATORS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 941);
            this.Controls.Add(this.a_panelcontent);
            this.Controls.Add(this.a_division);
            this.Controls.Add(this.a_panelmenu);
            this.Controls.Add(this.a_paneltop);
            this.Name = "ADMINISTRATORS";
            this.Load += new System.EventHandler(this.ADMINISTRATORS_Load);
            this.a_paneltop.ResumeLayout(false);
            this.a_paneltop.PerformLayout();
            this.a_panelmenu.ResumeLayout(false);
            this.a_panelmenu.PerformLayout();
            this.a_menustrip.ResumeLayout(false);
            this.a_menustrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel a_paneltop;
        private System.Windows.Forms.Button a_help;
        private System.Windows.Forms.Button a_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button a_back;
        private System.Windows.Forms.Panel a_panelmenu;
        private System.Windows.Forms.MenuStrip a_menustrip;
        private System.Windows.Forms.ToolStripMenuItem a_menu_op1;
        private System.Windows.Forms.ToolStripMenuItem a_menu_op2;
        private System.Windows.Forms.Panel a_division;
        private System.Windows.Forms.Panel a_panelcontent;
    }
}