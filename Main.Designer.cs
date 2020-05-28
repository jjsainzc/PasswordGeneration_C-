namespace PasswordGeneration
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.limpiar = new System.Windows.Forms.Button();
            this.generar = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.especiales = new System.Windows.Forms.CheckBox();
            this.minusculas = new System.Windows.Forms.CheckBox();
            this.numeros = new System.Windows.Forms.CheckBox();
            this.mayusculas = new System.Windows.Forms.CheckBox();
            this.longitud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.longitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // limpiar
            // 
            this.limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.limpiar.Location = new System.Drawing.Point(449, 364);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 0;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // generar
            // 
            this.generar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generar.Location = new System.Drawing.Point(12, 364);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(75, 23);
            this.generar.TabIndex = 1;
            this.generar.Text = "Generar";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // resultado
            // 
            this.resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultado.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultado.Location = new System.Drawing.Point(12, 134);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultado.Size = new System.Drawing.Size(512, 224);
            this.resultado.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.especiales);
            this.groupBox1.Controls.Add(this.minusculas);
            this.groupBox1.Controls.Add(this.numeros);
            this.groupBox1.Controls.Add(this.mayusculas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de inclusión";
            // 
            // especiales
            // 
            this.especiales.AutoSize = true;
            this.especiales.Location = new System.Drawing.Point(123, 47);
            this.especiales.Name = "especiales";
            this.especiales.Size = new System.Drawing.Size(79, 19);
            this.especiales.TabIndex = 3;
            this.especiales.Text = "Especiales";
            this.especiales.UseVisualStyleBackColor = true;
            // 
            // minusculas
            // 
            this.minusculas.AutoSize = true;
            this.minusculas.Checked = true;
            this.minusculas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minusculas.Location = new System.Drawing.Point(16, 47);
            this.minusculas.Name = "minusculas";
            this.minusculas.Size = new System.Drawing.Size(86, 19);
            this.minusculas.TabIndex = 2;
            this.minusculas.Text = "Minúsculas";
            this.minusculas.UseVisualStyleBackColor = true;
            // 
            // numeros
            // 
            this.numeros.AutoSize = true;
            this.numeros.Checked = true;
            this.numeros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numeros.Location = new System.Drawing.Point(123, 22);
            this.numeros.Name = "numeros";
            this.numeros.Size = new System.Drawing.Size(75, 19);
            this.numeros.TabIndex = 1;
            this.numeros.Text = "Números";
            this.numeros.UseVisualStyleBackColor = true;
            // 
            // mayusculas
            // 
            this.mayusculas.AutoSize = true;
            this.mayusculas.Checked = true;
            this.mayusculas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mayusculas.Location = new System.Drawing.Point(16, 22);
            this.mayusculas.Name = "mayusculas";
            this.mayusculas.Size = new System.Drawing.Size(88, 19);
            this.mayusculas.TabIndex = 0;
            this.mayusculas.Text = "Mayúsculas";
            this.mayusculas.UseVisualStyleBackColor = true;
            // 
            // longitud
            // 
            this.longitud.Location = new System.Drawing.Point(130, 105);
            this.longitud.Name = "longitud";
            this.longitud.Size = new System.Drawing.Size(57, 23);
            this.longitud.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tamaño Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(470, 105);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(54, 23);
            this.cantidad.TabIndex = 7;
            this.cantidad.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 412);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.longitud);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.generar);
            this.Controls.Add(this.limpiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Generación de contraseñas";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.longitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox especiales;
        private System.Windows.Forms.CheckBox minusculas;
        private System.Windows.Forms.CheckBox numeros;
        private System.Windows.Forms.CheckBox mayusculas;
        private System.Windows.Forms.NumericUpDown longitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cantidad;
    }
}

