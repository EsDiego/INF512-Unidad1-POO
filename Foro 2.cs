using System;
using System.Windows.Forms;

namespace ConversorMonedas
{
    public partial class Form1 : Form
    {
        // CONSTANTE CON LA TASA DE CAMBIO FIJA
        private const double TASA_CAMBIO = 61.30;

        // CONSTRUCTOR DEL FORMULARIO
        public Form1()
        {
            InitializeComponent();
        }

        // EVENTO CLICK DEL BOTON CONVERTIR
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double monto;

            // VALIDACION PARA VERIFICAR QUE EL USUARIO INGRESE UN NUMERO VALIDO
            if (double.TryParse(txtMonto.Text, out monto))
            {
                // ESTRUCTURA DE CONTROL PARA IDENTIFICAR EL TIPO DE CONVERSION
                if (rdbDopUsd.Checked)
                {
                    // CONVERSION DE PESO DOMINICANO A DOLAR
                    double resultado = monto / TASA_CAMBIO;

                    // MOSTRAR RESULTADO EN PANTALLA
                    lblResultado.Text = $"RESULTADO: {resultado:F2} USD";
                }
                else if (rdbUsdDop.Checked)
                {
                    // CONVERSION DE DOLAR A PESO DOMINICANO
                    double resultado = monto * TASA_CAMBIO;

                    // MOSTRAR RESULTADO EN PANTALLA
                    lblResultado.Text = $"RESULTADO: {resultado:F2} DOP";
                }
                else
                {
                    // MENSAJE EN CASO DE NO SELECCIONAR TIPO DE CONVERSION
                    MessageBox.Show("SELECCIONE UN TIPO DE CONVERSION.");
                }
            }
            else
            {
                // MENSAJE DE ERROR SI EL DATO INGRESADO NO ES NUMERICO
                MessageBox.Show("INGRESE UN VALOR NUMERICO VALIDO.");
            }
        }

        // EVENTO CLICK DEL BOTON LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // LIMPIAR CAMPO DE TEXTO
            txtMonto.Clear();

            // RESTABLECER RESULTADO
            lblResultado.Text = "RESULTADO:";
        }
    }
}
