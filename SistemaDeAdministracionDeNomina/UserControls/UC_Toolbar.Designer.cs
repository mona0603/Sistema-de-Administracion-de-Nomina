namespace SistemaDeAdministracionDeNomina.UserControls
{
    partial class UC_Toolbar
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
            this.uct_flowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // uct_flowpanel
            // 
            this.uct_flowpanel.BackColor = System.Drawing.Color.Transparent;
            this.uct_flowpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uct_flowpanel.Location = new System.Drawing.Point(0, 0);
            this.uct_flowpanel.Name = "uct_flowpanel";
            this.uct_flowpanel.Size = new System.Drawing.Size(575, 40);
            this.uct_flowpanel.TabIndex = 0;
            this.uct_flowpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.uct_flowpanel_Paint);
            // 
            // UC_Toolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uct_flowpanel);
            this.Name = "UC_Toolbar";
            this.Size = new System.Drawing.Size(575, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel uct_flowpanel;
    }
}
