namespace RedLine_C
{
    partial class Consultorio_Mooca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultorio_Mooca));
            this.TxtNumCart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNumCart
            // 
            this.TxtNumCart.Location = new System.Drawing.Point(303, 95);
            this.TxtNumCart.Name = "TxtNumCart";
            this.TxtNumCart.Size = new System.Drawing.Size(189, 20);
            this.TxtNumCart.TabIndex = 0;
            this.TxtNumCart.TextChanged += new System.EventHandler(this.TxtNumCart_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número da Carteirinha:";
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.BackColor = System.Drawing.Color.Red;
            this.BtnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnVerificar.Location = new System.Drawing.Point(245, 143);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(141, 56);
            this.BtnVerificar.TabIndex = 14;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = false;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(587, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Insira o número da carteirinha abaixo para verificar situação do paciente";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Consultorio_Mooca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(609, 257);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNumCart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultorio_Mooca";
            this.Text = "Consultorio_Mooca";
            this.Load += new System.EventHandler(this.Consultorio_Mooca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.Label label10;
    }
}