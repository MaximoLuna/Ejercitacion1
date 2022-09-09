namespace pry_Luna_Ejercitacion1
{
    partial class frmRegistroProductos
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
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblTipos = new System.Windows.Forms.Label();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.lstTipos = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(65, 51);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(55, 13);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Productos";
            // 
            // lblTipos
            // 
            this.lblTipos.AutoSize = true;
            this.lblTipos.Location = new System.Drawing.Point(65, 99);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(33, 13);
            this.lblTipos.TabIndex = 1;
            this.lblTipos.Text = "Tipos";
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(185, 51);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(121, 20);
            this.txtProductos.TabIndex = 2;
            this.txtProductos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstTipos
            // 
            this.lstTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipos.FormattingEnabled = true;
            this.lstTipos.Items.AddRange(new object[] {
            "Alimentos",
            "Bebidas",
            "Golosinas"});
            this.lstTipos.Location = new System.Drawing.Point(185, 99);
            this.lstTipos.Name = "lstTipos";
            this.lstTipos.Size = new System.Drawing.Size(121, 21);
            this.lstTipos.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(150, 192);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmRegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 229);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lstTipos);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.lblTipos);
            this.Controls.Add(this.lblProductos);
            this.Name = "frmRegistroProductos";
            this.Text = "Registro de Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblTipos;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.ComboBox lstTipos;
        private System.Windows.Forms.Button btnRegistrar;
    }
}