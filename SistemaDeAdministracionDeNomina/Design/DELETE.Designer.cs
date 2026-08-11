namespace SistemaDeAdministracionDeNomina.Design
{
    partial class DELETE
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
            this.label1 = new System.Windows.Forms.Label();
            this.dlt_copytext = new System.Windows.Forms.Label();
            this.dlt_text = new System.Windows.Forms.TextBox();
            this.uC_confirm = new SistemaDeAdministracionDeNomina.UserControls.UC_Buttons();
            this.uC_cancel = new SistemaDeAdministracionDeNomina.UserControls.UC_Buttons();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write the text from down below:";
            // 
            // dlt_copytext
            // 
            this.dlt_copytext.AutoSize = true;
            this.dlt_copytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlt_copytext.Location = new System.Drawing.Point(24, 64);
            this.dlt_copytext.Name = "dlt_copytext";
            this.dlt_copytext.Size = new System.Drawing.Size(342, 17);
            this.dlt_copytext.TabIndex = 1;
            this.dlt_copytext.Text = "\"I decided to delete this information from the system.\"";
            // 
            // dlt_text
            // 
            this.dlt_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dlt_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlt_text.Location = new System.Drawing.Point(72, 96);
            this.dlt_text.Multiline = true;
            this.dlt_text.Name = "dlt_text";
            this.dlt_text.Size = new System.Drawing.Size(240, 48);
            this.dlt_text.TabIndex = 2;
            // 
            // uC_confirm
            // 
            this.uC_confirm.BackColor = System.Drawing.SystemColors.Menu;
            this.uC_confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_confirm.CardImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.check;
            this.uC_confirm.CardTitle = "Confirm";
            this.uC_confirm.IconBackColor = System.Drawing.Color.Green;
            this.uC_confirm.Location = new System.Drawing.Point(16, 168);
            this.uC_confirm.Name = "uC_confirm";
            this.uC_confirm.Size = new System.Drawing.Size(152, 32);
            this.uC_confirm.TabIndex = 3;
            this.uC_confirm.Load += new System.EventHandler(this.uC_confirm_Load);
            // 
            // uC_cancel
            // 
            this.uC_cancel.BackColor = System.Drawing.SystemColors.Menu;
            this.uC_cancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_cancel.CardImage = global::SistemaDeAdministracionDeNomina.Properties.Resources.cross;
            this.uC_cancel.CardTitle = "Cancel";
            this.uC_cancel.IconBackColor = System.Drawing.Color.Red;
            this.uC_cancel.Location = new System.Drawing.Point(224, 168);
            this.uC_cancel.Name = "uC_cancel";
            this.uC_cancel.Size = new System.Drawing.Size(152, 32);
            this.uC_cancel.TabIndex = 4;
            // 
            // DELETE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 221);
            this.Controls.Add(this.uC_cancel);
            this.Controls.Add(this.uC_confirm);
            this.Controls.Add(this.dlt_text);
            this.Controls.Add(this.dlt_copytext);
            this.Controls.Add(this.label1);
            this.Name = "DELETE";
            this.Load += new System.EventHandler(this.DELETE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dlt_copytext;
        private System.Windows.Forms.TextBox dlt_text;
        private UserControls.UC_Buttons uC_confirm;
        private UserControls.UC_Buttons uC_cancel;
    }
}