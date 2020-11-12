namespace RedLine_C
{
    partial class ViewPaciente
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
            this.txtNomePac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNomePac
            // 
            this.txtNomePac.Enabled = false;
            this.txtNomePac.Location = new System.Drawing.Point(219, 42);
            this.txtNomePac.Name = "txtNomePac";
            this.txtNomePac.ReadOnly = true;
            this.txtNomePac.Size = new System.Drawing.Size(324, 20);
            this.txtNomePac.TabIndex = 0;
            this.txtNomePac.TextChanged += new System.EventHandler(this.txtNomePac_TextChanged);
            // 
            // ViewPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomePac);
            this.Name = "ViewPaciente";
            this.Text = "ViewPaciente";
            this.Load += new System.EventHandler(this.ViewPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomePac;
    }
}