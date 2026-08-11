namespace SistemaDeAdministracionDeNomina.UserControls
{
    partial class UC_Modules
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
            this.ucm_title = new System.Windows.Forms.Label();
            this.ucm_go = new System.Windows.Forms.PictureBox();
            this.ucm_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ucm_go)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucm_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // ucm_title
            // 
            this.ucm_title.AutoSize = true;
            this.ucm_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucm_title.ForeColor = System.Drawing.SystemColors.Window;
            this.ucm_title.Location = new System.Drawing.Point(47, 14);
            this.ucm_title.Name = "ucm_title";
            this.ucm_title.Size = new System.Drawing.Size(40, 17);
            this.ucm_title.TabIndex = 1;
            this.ucm_title.Text = "Title";
            // 
            // ucm_go
            // 
            this.ucm_go.BackColor = System.Drawing.Color.Transparent;
            this.ucm_go.BackgroundImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.right_arrow;
            this.ucm_go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucm_go.Location = new System.Drawing.Point(141, 14);
            this.ucm_go.Name = "ucm_go";
            this.ucm_go.Size = new System.Drawing.Size(20, 20);
            this.ucm_go.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ucm_go.TabIndex = 2;
            this.ucm_go.TabStop = false;
            // 
            // ucm_icon
            // 
            this.ucm_icon.Image = global::SistemaDeAdministracionDeNomina.Properties.Resources.agregar_usuario;
            this.ucm_icon.Location = new System.Drawing.Point(6, 5);
            this.ucm_icon.Name = "ucm_icon";
            this.ucm_icon.Size = new System.Drawing.Size(35, 35);
            this.ucm_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucm_icon.TabIndex = 0;
            this.ucm_icon.TabStop = false;
            // 
            // UC_Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.ucm_go);
            this.Controls.Add(this.ucm_title);
            this.Controls.Add(this.ucm_icon);
            this.Name = "UC_Modules";
            this.Size = new System.Drawing.Size(168, 46);
            this.Load += new System.EventHandler(this.UC_Modules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucm_go)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucm_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ucm_icon;
        private System.Windows.Forms.Label ucm_title;
        private System.Windows.Forms.PictureBox ucm_go;
    }
}
