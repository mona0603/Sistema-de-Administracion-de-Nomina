namespace SistemaDeAdministracionDeNomina.UserControls
{
    partial class UC_Buttons
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
            this.ucb_title = new System.Windows.Forms.Label();
            this.ucb_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ucb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // ucb_title
            // 
            this.ucb_title.AutoSize = true;
            this.ucb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucb_title.Location = new System.Drawing.Point(42, 6);
            this.ucb_title.Name = "ucb_title";
            this.ucb_title.Size = new System.Drawing.Size(35, 17);
            this.ucb_title.TabIndex = 1;
            this.ucb_title.Text = "Title";
            // 
            // ucb_icon
            // 
            this.ucb_icon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucb_icon.Image = global::SistemaDeAdministracionDeNomina.Properties.Resources._lock;
            this.ucb_icon.Location = new System.Drawing.Point(0, 0);
            this.ucb_icon.Name = "ucb_icon";
            this.ucb_icon.Padding = new System.Windows.Forms.Padding(4);
            this.ucb_icon.Size = new System.Drawing.Size(30, 30);
            this.ucb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucb_icon.TabIndex = 0;
            this.ucb_icon.TabStop = false;
            // 
            // UC_Buttons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.ucb_title);
            this.Controls.Add(this.ucb_icon);
            this.Name = "UC_Buttons";
            this.Size = new System.Drawing.Size(152, 32);
            this.Load += new System.EventHandler(this.UC_Buttons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucb_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ucb_icon;
        private System.Windows.Forms.Label ucb_title;
    }
}
