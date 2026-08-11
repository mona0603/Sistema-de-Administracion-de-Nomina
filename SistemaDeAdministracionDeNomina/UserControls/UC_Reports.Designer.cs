namespace SistemaDeAdministracionDeNomina.UserControls
{
    partial class UC_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Reports));
            this.ucr_data = new System.Windows.Forms.DataGridView();
            this.ucr_sortby = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.ucr_from = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ucr_to = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.uC_generate_pdf = new SistemaDeAdministracionDeNomina.UserControls.UC_Buttons();
            ((System.ComponentModel.ISupportInitialize)(this.ucr_data)).BeginInit();
            this.SuspendLayout();
            // 
            // ucr_data
            // 
            this.ucr_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ucr_data.Location = new System.Drawing.Point(16, 56);
            this.ucr_data.Name = "ucr_data";
            this.ucr_data.Size = new System.Drawing.Size(776, 728);
            this.ucr_data.TabIndex = 0;
            // 
            // ucr_sortby
            // 
            this.ucr_sortby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucr_sortby.FormattingEnabled = true;
            this.ucr_sortby.Location = new System.Drawing.Point(16, 24);
            this.ucr_sortby.Name = "ucr_sortby";
            this.ucr_sortby.Size = new System.Drawing.Size(136, 24);
            this.ucr_sortby.TabIndex = 79;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(16, 8);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 17);
            this.label27.TabIndex = 78;
            this.label27.Text = "Sort by:";
            // 
            // ucr_from
            // 
            this.ucr_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucr_from.Location = new System.Drawing.Point(272, 24);
            this.ucr_from.Name = "ucr_from";
            this.ucr_from.Size = new System.Drawing.Size(240, 23);
            this.ucr_from.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "From:";
            // 
            // ucr_to
            // 
            this.ucr_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucr_to.Location = new System.Drawing.Point(552, 24);
            this.ucr_to.Name = "ucr_to";
            this.ucr_to.Size = new System.Drawing.Size(240, 23);
            this.ucr_to.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "To:";
            // 
            // uC_generate_pdf
            // 
            this.uC_generate_pdf.BackColor = System.Drawing.SystemColors.Menu;
            this.uC_generate_pdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_generate_pdf.CardImage = ((System.Drawing.Image)(resources.GetObject("uC_generate_pdf.CardImage")));
            this.uC_generate_pdf.CardTitle = "Generate PDF";
            this.uC_generate_pdf.IconBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_generate_pdf.Location = new System.Drawing.Point(624, 800);
            this.uC_generate_pdf.Name = "uC_generate_pdf";
            this.uC_generate_pdf.Size = new System.Drawing.Size(166, 32);
            this.uC_generate_pdf.TabIndex = 84;
            // 
            // UC_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uC_generate_pdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucr_from);
            this.Controls.Add(this.ucr_to);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucr_sortby);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.ucr_data);
            this.Name = "UC_Reports";
            this.Size = new System.Drawing.Size(808, 846);
            this.Load += new System.EventHandler(this.UC_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucr_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ucr_data;
        private System.Windows.Forms.ComboBox ucr_sortby;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker ucr_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ucr_to;
        private System.Windows.Forms.Label label2;
        private UC_Buttons uC_generate_pdf;
    }
}
