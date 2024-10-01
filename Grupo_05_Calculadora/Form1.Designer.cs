namespace Grupo_05_Calculadora
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
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_Historial = new System.Windows.Forms.ListBox();
            this.txt_Segundo_Numero = new System.Windows.Forms.TextBox();
            this.txt_Primer_Numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ejecutar_Operación = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Porcentaje = new System.Windows.Forms.RadioButton();
            this.rb_Potencia = new System.Windows.Forms.RadioButton();
            this.rb_Suma = new System.Windows.Forms.RadioButton();
            this.rb_Divicion = new System.Windows.Forms.RadioButton();
            this.rb_Resta = new System.Windows.Forms.RadioButton();
            this.rb_Multiplicacion = new System.Windows.Forms.RadioButton();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.AutoSize = true;
            this.lb_Resultado.Location = new System.Drawing.Point(221, 227);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(43, 16);
            this.lb_Resultado.TabIndex = 20;
            this.lb_Resultado.Text = "---------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Resultado:";
            // 
            // lst_Historial
            // 
            this.lst_Historial.FormattingEnabled = true;
            this.lst_Historial.ItemHeight = 16;
            this.lst_Historial.Location = new System.Drawing.Point(564, 89);
            this.lst_Historial.Name = "lst_Historial";
            this.lst_Historial.Size = new System.Drawing.Size(212, 196);
            this.lst_Historial.TabIndex = 18;
            // 
            // txt_Segundo_Numero
            // 
            this.txt_Segundo_Numero.Location = new System.Drawing.Point(193, 167);
            this.txt_Segundo_Numero.Name = "txt_Segundo_Numero";
            this.txt_Segundo_Numero.Size = new System.Drawing.Size(100, 22);
            this.txt_Segundo_Numero.TabIndex = 17;
            // 
            // txt_Primer_Numero
            // 
            this.txt_Primer_Numero.Location = new System.Drawing.Point(193, 120);
            this.txt_Primer_Numero.Name = "txt_Primer_Numero";
            this.txt_Primer_Numero.Size = new System.Drawing.Size(100, 22);
            this.txt_Primer_Numero.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Segundo Número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Primer Número:";
            // 
            // btn_Ejecutar_Operación
            // 
            this.btn_Ejecutar_Operación.Location = new System.Drawing.Point(101, 288);
            this.btn_Ejecutar_Operación.Name = "btn_Ejecutar_Operación";
            this.btn_Ejecutar_Operación.Size = new System.Drawing.Size(163, 49);
            this.btn_Ejecutar_Operación.TabIndex = 13;
            this.btn_Ejecutar_Operación.Text = "Ejecutar Operación";
            this.btn_Ejecutar_Operación.UseVisualStyleBackColor = true;
            this.btn_Ejecutar_Operación.Click += new System.EventHandler(this.btn_Ejecutar_Operación_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Porcentaje);
            this.groupBox1.Controls.Add(this.rb_Potencia);
            this.groupBox1.Controls.Add(this.rb_Suma);
            this.groupBox1.Controls.Add(this.rb_Divicion);
            this.groupBox1.Controls.Add(this.rb_Resta);
            this.groupBox1.Controls.Add(this.rb_Multiplicacion);
            this.groupBox1.Location = new System.Drawing.Point(370, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 201);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones:";
            // 
            // rb_Porcentaje
            // 
            this.rb_Porcentaje.AutoSize = true;
            this.rb_Porcentaje.Location = new System.Drawing.Point(20, 163);
            this.rb_Porcentaje.Name = "rb_Porcentaje";
            this.rb_Porcentaje.Size = new System.Drawing.Size(93, 20);
            this.rb_Porcentaje.TabIndex = 7;
            this.rb_Porcentaje.Text = "Porcentaje";
            this.rb_Porcentaje.UseVisualStyleBackColor = true;
            // 
            // rb_Potencia
            // 
            this.rb_Potencia.AutoSize = true;
            this.rb_Potencia.Location = new System.Drawing.Point(20, 137);
            this.rb_Potencia.Name = "rb_Potencia";
            this.rb_Potencia.Size = new System.Drawing.Size(81, 20);
            this.rb_Potencia.TabIndex = 6;
            this.rb_Potencia.Text = "Potencia";
            this.rb_Potencia.UseVisualStyleBackColor = true;
            // 
            // rb_Suma
            // 
            this.rb_Suma.AutoSize = true;
            this.rb_Suma.Checked = true;
            this.rb_Suma.Location = new System.Drawing.Point(20, 33);
            this.rb_Suma.Name = "rb_Suma";
            this.rb_Suma.Size = new System.Drawing.Size(63, 20);
            this.rb_Suma.TabIndex = 2;
            this.rb_Suma.TabStop = true;
            this.rb_Suma.Text = "Suma";
            this.rb_Suma.UseVisualStyleBackColor = true;
            // 
            // rb_Divicion
            // 
            this.rb_Divicion.AutoSize = true;
            this.rb_Divicion.Location = new System.Drawing.Point(20, 111);
            this.rb_Divicion.Name = "rb_Divicion";
            this.rb_Divicion.Size = new System.Drawing.Size(76, 20);
            this.rb_Divicion.TabIndex = 5;
            this.rb_Divicion.Text = "Divición";
            this.rb_Divicion.UseVisualStyleBackColor = true;
            // 
            // rb_Resta
            // 
            this.rb_Resta.AutoSize = true;
            this.rb_Resta.Location = new System.Drawing.Point(20, 59);
            this.rb_Resta.Name = "rb_Resta";
            this.rb_Resta.Size = new System.Drawing.Size(64, 20);
            this.rb_Resta.TabIndex = 3;
            this.rb_Resta.Text = "Resta";
            this.rb_Resta.UseVisualStyleBackColor = true;
            // 
            // rb_Multiplicacion
            // 
            this.rb_Multiplicacion.AutoSize = true;
            this.rb_Multiplicacion.Location = new System.Drawing.Point(20, 85);
            this.rb_Multiplicacion.Name = "rb_Multiplicacion";
            this.rb_Multiplicacion.Size = new System.Drawing.Size(109, 20);
            this.rb_Multiplicacion.TabIndex = 4;
            this.rb_Multiplicacion.Text = "Multiplicación";
            this.rb_Multiplicacion.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(655, 327);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(121, 39);
            this.btn_Salir.TabIndex = 11;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_Historial);
            this.Controls.Add(this.txt_Segundo_Numero);
            this.Controls.Add(this.txt_Primer_Numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ejecutar_Operación);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Salir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_Historial;
        private System.Windows.Forms.TextBox txt_Segundo_Numero;
        private System.Windows.Forms.TextBox txt_Primer_Numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ejecutar_Operación;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Porcentaje;
        private System.Windows.Forms.RadioButton rb_Potencia;
        private System.Windows.Forms.RadioButton rb_Suma;
        private System.Windows.Forms.RadioButton rb_Divicion;
        private System.Windows.Forms.RadioButton rb_Resta;
        private System.Windows.Forms.RadioButton rb_Multiplicacion;
        private System.Windows.Forms.Button btn_Salir;
    }
}

