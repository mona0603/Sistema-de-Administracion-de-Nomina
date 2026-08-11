namespace SistemaDeAdministracionDeNomina.UserControls
{
    partial class UC_Concepts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucc_data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.ucc_title = new System.Windows.Forms.TextBox();
            this.ucc_titlelabel = new System.Windows.Forms.Label();
            this.ucc_description = new System.Windows.Forms.TextBox();
            this.ucc_descriptionlabel = new System.Windows.Forms.Label();
            this.ucc_systemtype = new System.Windows.Forms.ComboBox();
            this.ucc_search = new System.Windows.Forms.TextBox();
            this.ucc_reactivate = new System.Windows.Forms.CheckBox();
            this.ucc_canedit = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucc_code = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.ucc_sortby = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucc_canedit_pic = new System.Windows.Forms.PictureBox();
            this.ucc_reactivate_pic = new System.Windows.Forms.PictureBox();
            this.ucc_search_button = new System.Windows.Forms.Button();
            this.ucc_systemtype_pic = new System.Windows.Forms.PictureBox();
            this.ucc_calculateby = new System.Windows.Forms.ComboBox();
            this.ucc_calculateby_pic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uC_Toolbar1 = new SistemaDeAdministracionDeNomina.UserControls.UC_Toolbar();
            ((System.ComponentModel.ISupportInitialize)(this.ucc_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucc_canedit_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucc_reactivate_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucc_systemtype_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucc_calculateby_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // ucc_data
            // 
            this.ucc_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ucc_data.Location = new System.Drawing.Point(15, 56);
            this.ucc_data.Name = "ucc_data";
            this.ucc_data.Size = new System.Drawing.Size(649, 656);
            this.ucc_data.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(704, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "System Type:";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // ucc_title
            // 
            this.ucc_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucc_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucc_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_title.ForeColor = System.Drawing.Color.Black;
            this.ucc_title.Location = new System.Drawing.Point(16, 800);
            this.ucc_title.Name = "ucc_title";
            this.ucc_title.Size = new System.Drawing.Size(240, 23);
            this.ucc_title.TabIndex = 10;
            // 
            // ucc_titlelabel
            // 
            this.ucc_titlelabel.AutoSize = true;
            this.ucc_titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_titlelabel.Location = new System.Drawing.Point(16, 784);
            this.ucc_titlelabel.Name = "ucc_titlelabel";
            this.ucc_titlelabel.Size = new System.Drawing.Size(39, 17);
            this.ucc_titlelabel.TabIndex = 11;
            this.ucc_titlelabel.Text = "Title:";
            // 
            // ucc_description
            // 
            this.ucc_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucc_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucc_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_description.ForeColor = System.Drawing.Color.Black;
            this.ucc_description.Location = new System.Drawing.Point(272, 800);
            this.ucc_description.Name = "ucc_description";
            this.ucc_description.Size = new System.Drawing.Size(392, 23);
            this.ucc_description.TabIndex = 12;
            // 
            // ucc_descriptionlabel
            // 
            this.ucc_descriptionlabel.AutoSize = true;
            this.ucc_descriptionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_descriptionlabel.Location = new System.Drawing.Point(272, 784);
            this.ucc_descriptionlabel.Name = "ucc_descriptionlabel";
            this.ucc_descriptionlabel.Size = new System.Drawing.Size(83, 17);
            this.ucc_descriptionlabel.TabIndex = 13;
            this.ucc_descriptionlabel.Text = "Description:";
            // 
            // ucc_systemtype
            // 
            this.ucc_systemtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_systemtype.FormattingEnabled = true;
            this.ucc_systemtype.Location = new System.Drawing.Point(672, 152);
            this.ucc_systemtype.Name = "ucc_systemtype";
            this.ucc_systemtype.Size = new System.Drawing.Size(120, 24);
            this.ucc_systemtype.TabIndex = 14;
            // 
            // ucc_search
            // 
            this.ucc_search.BackColor = System.Drawing.SystemColors.Window;
            this.ucc_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucc_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_search.ForeColor = System.Drawing.Color.Gray;
            this.ucc_search.Location = new System.Drawing.Point(216, 16);
            this.ucc_search.Name = "ucc_search";
            this.ucc_search.Size = new System.Drawing.Size(416, 23);
            this.ucc_search.TabIndex = 65;
            this.ucc_search.Text = "Search by name...";
            // 
            // ucc_reactivate
            // 
            this.ucc_reactivate.AutoSize = true;
            this.ucc_reactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_reactivate.Location = new System.Drawing.Point(704, 664);
            this.ucc_reactivate.Name = "ucc_reactivate";
            this.ucc_reactivate.Size = new System.Drawing.Size(100, 21);
            this.ucc_reactivate.TabIndex = 67;
            this.ucc_reactivate.Text = "Re-Activate";
            this.ucc_reactivate.UseVisualStyleBackColor = true;
            this.ucc_reactivate.CheckedChanged += new System.EventHandler(this.ucc_reactivate_CheckedChanged);
            // 
            // ucc_canedit
            // 
            this.ucc_canedit.AutoSize = true;
            this.ucc_canedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_canedit.Location = new System.Drawing.Point(704, 280);
            this.ucc_canedit.Name = "ucc_canedit";
            this.ucc_canedit.Size = new System.Drawing.Size(79, 21);
            this.ucc_canedit.TabIndex = 69;
            this.ucc_canedit.Text = "Can edit";
            this.ucc_canedit.UseVisualStyleBackColor = true;
            this.ucc_canedit.CheckedChanged += new System.EventHandler(this.ucc_canedit_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(672, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 5);
            this.panel1.TabIndex = 71;
            // 
            // ucc_code
            // 
            this.ucc_code.BackColor = System.Drawing.SystemColors.Window;
            this.ucc_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucc_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_code.ForeColor = System.Drawing.Color.Gray;
            this.ucc_code.Location = new System.Drawing.Point(80, 16);
            this.ucc_code.MinimumSize = new System.Drawing.Size(2, 23);
            this.ucc_code.Name = "ucc_code";
            this.ucc_code.ReadOnly = true;
            this.ucc_code.Size = new System.Drawing.Size(80, 23);
            this.ucc_code.TabIndex = 73;
            this.ucc_code.Text = "EXM_01";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(16, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 17);
            this.label26.TabIndex = 72;
            this.label26.Text = "Code #:";
            // 
            // ucc_sortby
            // 
            this.ucc_sortby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_sortby.FormattingEnabled = true;
            this.ucc_sortby.Location = new System.Drawing.Point(672, 72);
            this.ucc_sortby.Name = "ucc_sortby";
            this.ucc_sortby.Size = new System.Drawing.Size(120, 24);
            this.ucc_sortby.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(672, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Sort by:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(672, 704);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 5);
            this.panel2.TabIndex = 72;
            // 
            // ucc_canedit_pic
            // 
            this.ucc_canedit_pic.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.check;
            this.ucc_canedit_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucc_canedit_pic.Location = new System.Drawing.Point(672, 280);
            this.ucc_canedit_pic.Name = "ucc_canedit_pic";
            this.ucc_canedit_pic.Size = new System.Drawing.Size(24, 24);
            this.ucc_canedit_pic.TabIndex = 70;
            this.ucc_canedit_pic.TabStop = false;
            // 
            // ucc_reactivate_pic
            // 
            this.ucc_reactivate_pic.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.cross;
            this.ucc_reactivate_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucc_reactivate_pic.Location = new System.Drawing.Point(672, 664);
            this.ucc_reactivate_pic.Name = "ucc_reactivate_pic";
            this.ucc_reactivate_pic.Size = new System.Drawing.Size(24, 24);
            this.ucc_reactivate_pic.TabIndex = 68;
            this.ucc_reactivate_pic.TabStop = false;
            // 
            // ucc_search_button
            // 
            this.ucc_search_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ucc_search_button.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.magnifying_glass;
            this.ucc_search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucc_search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucc_search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_search_button.Location = new System.Drawing.Point(640, 16);
            this.ucc_search_button.Name = "ucc_search_button";
            this.ucc_search_button.Padding = new System.Windows.Forms.Padding(2);
            this.ucc_search_button.Size = new System.Drawing.Size(23, 23);
            this.ucc_search_button.TabIndex = 66;
            this.ucc_search_button.UseVisualStyleBackColor = false;
            // 
            // ucc_systemtype_pic
            // 
            this.ucc_systemtype_pic.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.locked;
            this.ucc_systemtype_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucc_systemtype_pic.Location = new System.Drawing.Point(672, 120);
            this.ucc_systemtype_pic.Name = "ucc_systemtype_pic";
            this.ucc_systemtype_pic.Size = new System.Drawing.Size(24, 24);
            this.ucc_systemtype_pic.TabIndex = 9;
            this.ucc_systemtype_pic.TabStop = false;
            // 
            // ucc_calculateby
            // 
            this.ucc_calculateby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_calculateby.FormattingEnabled = true;
            this.ucc_calculateby.Location = new System.Drawing.Point(672, 232);
            this.ucc_calculateby.Name = "ucc_calculateby";
            this.ucc_calculateby.Size = new System.Drawing.Size(120, 24);
            this.ucc_calculateby.TabIndex = 79;
            // 
            // ucc_calculateby_pic
            // 
            this.ucc_calculateby_pic.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.locked;
            this.ucc_calculateby_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucc_calculateby_pic.Location = new System.Drawing.Point(672, 200);
            this.ucc_calculateby_pic.Name = "ucc_calculateby_pic";
            this.ucc_calculateby_pic.Size = new System.Drawing.Size(24, 24);
            this.ucc_calculateby_pic.TabIndex = 78;
            this.ucc_calculateby_pic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Calculate by:";
            // 
            // uC_Toolbar1
            // 
            this.uC_Toolbar1.Location = new System.Drawing.Point(16, 736);
            this.uC_Toolbar1.Name = "uC_Toolbar1";
            this.uC_Toolbar1.Size = new System.Drawing.Size(648, 38);
            this.uC_Toolbar1.TabIndex = 76;
            this.uC_Toolbar1.Load += new System.EventHandler(this.uC_Toolbar1_Load);
            // 
            // UC_Concepts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucc_calculateby);
            this.Controls.Add(this.ucc_calculateby_pic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uC_Toolbar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucc_sortby);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ucc_code);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucc_canedit_pic);
            this.Controls.Add(this.ucc_canedit);
            this.Controls.Add(this.ucc_reactivate_pic);
            this.Controls.Add(this.ucc_reactivate);
            this.Controls.Add(this.ucc_search_button);
            this.Controls.Add(this.ucc_search);
            this.Controls.Add(this.ucc_systemtype);
            this.Controls.Add(this.ucc_description);
            this.Controls.Add(this.ucc_descriptionlabel);
            this.Controls.Add(this.ucc_title);
            this.Controls.Add(this.ucc_titlelabel);
            this.Controls.Add(this.ucc_systemtype_pic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucc_data);
            this.Name = "UC_Concepts";
            this.Size = new System.Drawing.Size(807, 846);
            this.Load += new System.EventHandler(this.UC_Concepts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucc_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucc_canedit_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucc_reactivate_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucc_systemtype_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucc_calculateby_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ucc_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ucc_systemtype_pic;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox ucc_title;
        private System.Windows.Forms.TextBox ucc_description;
        private System.Windows.Forms.Label ucc_descriptionlabel;
        private System.Windows.Forms.Label ucc_titlelabel;
        private System.Windows.Forms.ComboBox ucc_systemtype;
        private System.Windows.Forms.Button ucc_search_button;
        private System.Windows.Forms.TextBox ucc_search;
        private System.Windows.Forms.PictureBox ucc_canedit_pic;
        private System.Windows.Forms.CheckBox ucc_canedit;
        private System.Windows.Forms.PictureBox ucc_reactivate_pic;
        private System.Windows.Forms.CheckBox ucc_reactivate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ucc_code;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ucc_sortby;
        private System.Windows.Forms.Label label4;
        private UC_Toolbar uC_Toolbar1;
        private System.Windows.Forms.ComboBox ucc_calculateby;
        private System.Windows.Forms.PictureBox ucc_calculateby_pic;
        private System.Windows.Forms.Label label2;
    }
}
