namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.gbrGrupoA = new System.Windows.Forms.GroupBox();
            this.lblResul = new System.Windows.Forms.Label();
            this.lblValB = new System.Windows.Forms.Label();
            this.lblValA = new System.Windows.Forms.Label();
            this.txtValA = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.Button();
            this.txtValB = new System.Windows.Forms.TextBox();
            this.resta = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.gbrGrupoA.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbrGrupoA
            // 
            this.gbrGrupoA.Controls.Add(this.div);
            this.gbrGrupoA.Controls.Add(this.multi);
            this.gbrGrupoA.Controls.Add(this.resta);
            this.gbrGrupoA.Controls.Add(this.lblResul);
            this.gbrGrupoA.Controls.Add(this.lblValB);
            this.gbrGrupoA.Controls.Add(this.lblValA);
            this.gbrGrupoA.Controls.Add(this.txtValA);
            this.gbrGrupoA.Controls.Add(this.suma);
            this.gbrGrupoA.Controls.Add(this.txtValB);
            this.gbrGrupoA.Location = new System.Drawing.Point(32, 41);
            this.gbrGrupoA.Name = "gbrGrupoA";
            this.gbrGrupoA.Size = new System.Drawing.Size(220, 178);
            this.gbrGrupoA.TabIndex = 4;
            this.gbrGrupoA.TabStop = false;
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
            // lblValB
            // 
            this.lblValB.AutoSize = true;
            this.lblValB.Location = new System.Drawing.Point(23, 61);
            this.lblValB.Name = "lblValB";
            this.lblValB.Size = new System.Drawing.Size(41, 13);
            this.lblValB.TabIndex = 4;
            this.lblValB.Text = "Valor B";
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
            // txtValA
            // 
            this.txtValA.Location = new System.Drawing.Point(75, 32);
            this.txtValA.Name = "txtValA";
            this.txtValA.Size = new System.Drawing.Size(100, 20);
            this.txtValA.TabIndex = 1;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(26, 133);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(38, 23);
            this.suma.TabIndex = 0;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValB
            // 
            this.txtValB.Location = new System.Drawing.Point(75, 58);
            this.txtValB.Name = "txtValB";
            this.txtValB.Size = new System.Drawing.Size(100, 20);
            this.txtValB.TabIndex = 2;
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(70, 133);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(35, 23);
            this.resta.TabIndex = 6;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(111, 133);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(35, 23);
            this.multi.TabIndex = 7;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(152, 133);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(35, 23);
            this.div.TabIndex = 8;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gbrGrupoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbrGrupoA.ResumeLayout(false);
            this.gbrGrupoA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbrGrupoA;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.Label lblValB;
        private System.Windows.Forms.Label lblValA;
        private System.Windows.Forms.TextBox txtValA;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.TextBox txtValB;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button resta;
    }
}

