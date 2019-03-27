namespace WindowsFormsApplication2
{
    partial class frmOperaciones
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValA = new System.Windows.Forms.TextBox();
            this.txtValB = new System.Windows.Forms.TextBox();
            this.gbrGrupoA = new System.Windows.Forms.GroupBox();
            this.lblValA = new System.Windows.Forms.Label();
            this.lblValB = new System.Windows.Forms.Label();
            this.lblResul = new System.Windows.Forms.Label();
            this.gbrGrupoA.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(58, 133);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtValA
            // 
            this.txtValA.Location = new System.Drawing.Point(75, 32);
            this.txtValA.Name = "txtValA";
            this.txtValA.Size = new System.Drawing.Size(100, 20);
            this.txtValA.TabIndex = 1;
            // 
            // txtValB
            // 
            this.txtValB.Location = new System.Drawing.Point(75, 58);
            this.txtValB.Name = "txtValB";
            this.txtValB.Size = new System.Drawing.Size(100, 20);
            this.txtValB.TabIndex = 2;
            // 
            // gbrGrupoA
            // 
            this.gbrGrupoA.Controls.Add(this.lblResul);
            this.gbrGrupoA.Controls.Add(this.lblValB);
            this.gbrGrupoA.Controls.Add(this.lblValA);
            this.gbrGrupoA.Controls.Add(this.txtValA);
            this.gbrGrupoA.Controls.Add(this.btnCalcular);
            this.gbrGrupoA.Controls.Add(this.txtValB);
            this.gbrGrupoA.Location = new System.Drawing.Point(38, 12);
            this.gbrGrupoA.Name = "gbrGrupoA";
            this.gbrGrupoA.Size = new System.Drawing.Size(220, 178);
            this.gbrGrupoA.TabIndex = 3;
            this.gbrGrupoA.TabStop = false;
            // 
            // lblValA
            // 
            this.lblValA.AutoSize = true;
            this.lblValA.Location = new System.Drawing.Point(23, 35);
            this.lblValA.Name = "lblValA";
            this.lblValA.Size = new System.Drawing.Size(41, 13);
            this.lblValA.TabIndex = 3;
            this.lblValA.Text = "Valor A";
            // 
            // lblValB
            // 
            this.lblValB.AutoSize = true;
            this.lblValB.Location = new System.Drawing.Point(23, 61);
            this.lblValB.Name = "lblValB";
            this.lblValB.Size = new System.Drawing.Size(41, 13);
            this.lblValB.TabIndex = 4;
            this.lblValB.Text = "Valor B";
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.Location = new System.Drawing.Point(60, 117);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(82, 13);
            this.lblResul.TabIndex = 5;
            this.lblResul.Text = "RESULTADO";
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 229);
            this.Controls.Add(this.gbrGrupoA);
            this.Name = "frmOperaciones";
            this.Text = "Operaciones con clases";
            this.Load += new System.EventHandler(this.frmOperaciones_Load);
            this.gbrGrupoA.ResumeLayout(false);
            this.gbrGrupoA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValA;
        private System.Windows.Forms.TextBox txtValB;
        private System.Windows.Forms.GroupBox gbrGrupoA;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.Label lblValB;
        private System.Windows.Forms.Label lblValA;
    }
}

