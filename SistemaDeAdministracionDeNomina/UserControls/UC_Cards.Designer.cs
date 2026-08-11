namespace SistemaDeAdministracionDeNomina
{
    partial class UC_Cards
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
            this.ucc_title = new System.Windows.Forms.Label();
            this.ucc_description = new System.Windows.Forms.Label();
            this.ucc_icon = new System.Windows.Forms.PictureBox();
            this.ucc_go = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ucc_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucc_go)).BeginInit();
            this.SuspendLayout();
            // 
            // ucc_title
            // 
            this.ucc_title.AutoSize = true;
            this.ucc_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_title.Location = new System.Drawing.Point(135, 45);
            this.ucc_title.Name = "ucc_title";
            this.ucc_title.Size = new System.Drawing.Size(57, 26);
            this.ucc_title.TabIndex = 0;
            this.ucc_title.Text = "Title";
            // 
            // ucc_description
            // 
            this.ucc_description.AutoEllipsis = true;
            this.ucc_description.AutoSize = true;
            this.ucc_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucc_description.ForeColor = System.Drawing.Color.Gray;
            this.ucc_description.Location = new System.Drawing.Point(135, 75);
            this.ucc_description.Name = "ucc_description";
            this.ucc_description.Size = new System.Drawing.Size(27, 13);
            this.ucc_description.TabIndex = 1;
            this.ucc_description.Text = "Title";
            // 
            // ucc_icon
            // 
            this.ucc_icon.Image = global::SistemaDeAdministracionDeNomina.Properties.Resources.circulo_naranja2;
            this.ucc_icon.Location = new System.Drawing.Point(15, 15);
            this.ucc_icon.Name = "ucc_icon";
            this.ucc_icon.Size = new System.Drawing.Size(105, 105);
            this.ucc_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucc_icon.TabIndex = 2;
            this.ucc_icon.TabStop = false;
            // 
            // ucc_go
            // 
            this.ucc_go.Image = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrownaranja;
            this.ucc_go.Location = new System.Drawing.Point(390, 45);
            this.ucc_go.Name = "ucc_go";
            this.ucc_go.Size = new System.Drawing.Size(45, 45);
            this.ucc_go.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucc_go.TabIndex = 3;
            this.ucc_go.TabStop = false;
            // 
            // UC_Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucc_go);
            this.Controls.Add(this.ucc_icon);
            this.Controls.Add(this.ucc_description);
            this.Controls.Add(this.ucc_title);
            this.Name = "UC_Cards";
            this.Size = new System.Drawing.Size(451, 135);
            this.Load += new System.EventHandler(this.UC_Cards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucc_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucc_go)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ucc_title;
        private System.Windows.Forms.Label ucc_description;
        private System.Windows.Forms.PictureBox ucc_icon;
        private System.Windows.Forms.PictureBox ucc_go;
    }
}
