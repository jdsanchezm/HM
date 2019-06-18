namespace FormularioWiliam
{
    partial class Form1
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
            this.ingresar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txcontrasena = new System.Windows.Forms.TextBox();
            this.txusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(52, 325);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(667, 36);
            this.ingresar.TabIndex = 0;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(239, 125);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(43, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Usuario";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // txcontrasena
            // 
            this.txcontrasena.Location = new System.Drawing.Point(320, 158);
            this.txcontrasena.Name = "txcontrasena";
            this.txcontrasena.Size = new System.Drawing.Size(218, 20);
            this.txcontrasena.TabIndex = 4;
            this.txcontrasena.TextChanged += new System.EventHandler(this.contraseña_TextChanged);
            // 
            // txusuario
            // 
            this.txusuario.Location = new System.Drawing.Point(320, 122);
            this.txusuario.Name = "txusuario";
            this.txusuario.Size = new System.Drawing.Size(218, 20);
            this.txusuario.TabIndex = 5;
            this.txusuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txusuario);
            this.Controls.Add(this.txcontrasena);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ingresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txcontrasena;
        private System.Windows.Forms.TextBox txusuario;
        private System.Windows.Forms.Label label1;
    }
}

