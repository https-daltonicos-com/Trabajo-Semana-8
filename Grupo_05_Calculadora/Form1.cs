using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_05_Calculadora
{
    public partial class Form1 : Form
    {
        private List<string> historial = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ejecutar_Operación_Click(object sender, EventArgs e)
        {
            double primerNumero, segundoNumero, resultado = 0;

            if (!double.TryParse(txt_Primer_Numero.Text, out primerNumero) || !double.TryParse(txt_Segundo_Numero.Text, out segundoNumero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
                return;
            }

            string operacion = "";

            if (rb_Suma.Checked)
            {
                MessageBox.Show("Ejecucion no validad, por falta de codigo.");
                resultado = primerNumero + segundoNumero;
                operacion = " + ";
            }
            else if (rb_Resta.Checked)
            {
                MessageBox.Show("Ejecucion no validad, por falta de codigo.");
                /*resultado = primerNumero - segundoNumero;
                operacion = " - ";*/
            }
            else if (rb_Multiplicacion.Checked)
            {
                MessageBox.Show("Ejecucion no validad, por falta de codigo.");
                /*resultado = primerNumero * segundoNumero;
                operacion = " x ";*/
            }
            else if (rb_Divicion.Checked)
            {
                MessageBox.Show("Ejecucion no validad, por falta de codigo.");
                /*if (segundoNumero != 0)
                {
                    resultado = primerNumero / segundoNumero;
                    operacion = " / ";
                }
                else
                {
                    MessageBox.Show("No se puede dividir entre cero.");
                    return;
                }*/
            }
            else if (rb_Potencia.Checked)
            {
                MessageBox.Show("Ejecucion no validad, por falta de codigo.");
                /*resultado = Math.Pow(primerNumero, segundoNumero);
                operacion = " ^ ";*/
            }
            else if (rb_Porcentaje.Checked)
            {
                MessageBox.Show("Ejecucion no validad, por falta de codigo.");
                /*resultado = (primerNumero * segundoNumero) / 100;
                operacion = " % ";*/
            }

            lb_Resultado.Text = resultado.ToString();

            //string operacionHistorial = $"Operación: {primerNumero} {operacion} {segundoNumero}  =  {resultado}";
            string operacionHistorial = "No signal: ";
            historial.Add(operacionHistorial);

            lst_Historial.Items.Add(operacionHistorial);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //hola
        }
    }
}
