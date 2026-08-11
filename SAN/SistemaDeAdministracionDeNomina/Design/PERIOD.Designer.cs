namespace SistemaDeAdministracionDeNomina.Design
{
    partial class PERIOD
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
            this.prd_dtp1 = new System.Windows.Forms.DateTimePicker();
            this.prd_dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prd_department = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.prd_type = new System.Windows.Forms.ComboBox();
            this.uC_Generate = new SistemaDeAdministracionDeNomina.UserControls.UC_Buttons();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // prd_dtp1
            // 
            this.prd_dtp1.Location = new System.Drawing.Point(8, 40);
            this.prd_dtp1.Name = "prd_dtp1";
            this.prd_dtp1.Size = new System.Drawing.Size(232, 23);
            this.prd_dtp1.TabIndex = 1;
            // 
            // prd_dtp2
            // 
            this.prd_dtp2.Location = new System.Drawing.Point(280, 40);
            this.prd_dtp2.Name = "prd_dtp2";
            this.prd_dtp2.Size = new System.Drawing.Size(232, 23);
            this.prd_dtp2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prd_dtp1);
            this.groupBox1.Controls.Add(this.prd_dtp2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Period";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prd_department);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 88);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department";
            // 
            // prd_department
            // 
            this.prd_department.FormattingEnabled = true;
            this.prd_department.Location = new System.Drawing.Point(8, 40);
            this.prd_department.Name = "prd_department";
            this.prd_department.Size = new System.Drawing.Size(176, 24);
            this.prd_department.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prd_type);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(344, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 84);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type";
            // 
            // prd_type
            // 
            this.prd_type.FormattingEnabled = true;
            this.prd_type.Location = new System.Drawing.Point(8, 40);
            this.prd_type.Name = "prd_type";
            this.prd_type.Size = new System.Drawing.Size(176, 24);
            this.prd_type.TabIndex = 0;
            // 
            // uC_Generate
            // 
            this.uC_Generate.BackColor = System.Drawing.SystemColors.Menu;
            this.uC_Generate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_Generate.CardImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.check;
            this.uC_Generate.CardTitle = "Generate";
            this.uC_Generate.IconBackColor = System.Drawing.Color.Green;
            this.uC_Generate.Location = new System.Drawing.Point(200, 224);
            this.uC_Generate.Name = "uC_Generate";
            this.uC_Generate.Size = new System.Drawing.Size(150, 32);
            this.uC_Generate.TabIndex = 8;
            // 
            // PERIOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 270);
            this.Controls.Add(this.uC_Generate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PERIOD";
            this.Text = "GENERATE PAYROLL PERIOD";
            this.Load += new System.EventHandler(this.PERIOD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker prd_dtp1;
        private System.Windows.Forms.DateTimePicker prd_dtp2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox prd_department;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox prd_type;
        private UserControls.UC_Buttons uC_Generate;
    }
}