namespace pry_Luna_Ejercitacion1
{
    partial class frmEncuesta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSatisfecho = new System.Windows.Forms.Button();
            this.btnNoSatisfecho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSatisfecho
            // 
            this.btnSatisfecho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSatisfecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSatisfecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatisfecho.Location = new System.Drawing.Point(42, 48);
            this.btnSatisfecho.Name = "btnSatisfecho";
            this.btnSatisfecho.Size = new System.Drawing.Size(222, 169);
            this.btnSatisfecho.TabIndex = 0;
            this.btnSatisfecho.Text = "Satisfecho";
            this.btnSatisfecho.UseVisualStyleBackColor = false;
            this.btnSatisfecho.Click += new System.EventHandler(this.btnSatisfecho_Click);
            // 
            // btnNoSatisfecho
            // 
            this.btnNoSatisfecho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNoSatisfecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNoSatisfecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoSatisfecho.Location = new System.Drawing.Point(270, 48);
            this.btnNoSatisfecho.Name = "btnNoSatisfecho";
            this.btnNoSatisfecho.Size = new System.Drawing.Size(222, 169);
            this.btnNoSatisfecho.TabIndex = 1;
            this.btnNoSatisfecho.Text = "No Satisfecho";
            this.btnNoSatisfecho.UseVisualStyleBackColor = false;
            this.btnNoSatisfecho.Click += new System.EventHandler(this.btnNoSatisfecho_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 265);
            this.Controls.Add(this.btnNoSatisfecho);
            this.Controls.Add(this.btnSatisfecho);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Queremos saber tu opinion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSatisfecho;
        private System.Windows.Forms.Button btnNoSatisfecho;
    }
}

