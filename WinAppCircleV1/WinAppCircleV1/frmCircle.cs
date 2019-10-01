using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCircleV1
{
    public partial class frmCircle : Form
       
    {
        //Datos mimebro de la caja 
        //variables globales del formulario 
        private double perimeter, area, radiuos;
        public frmCircle()
        {
            InitializeComponent();
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {
            //Caja de mensaje despliega el mensaje: Hola Mundo 
            //MessageBox.Show("Hola Mundo");
            //Inicializar las variables radiuos, perimeter, area con cero 
            radiuos = 0; perimeter = 0; area = 0;

            //Inicializar las cajas de texto con comillas dobles ("")
            txtRadiuos.Text = "";// las comillas dobles es equivalente a (BLANK)
            txtPerimetro.Text = "";
            txtArea.Text = "";

            //la funcion focus activa el cursor en la caja de texto txtRadiuos
            txtRadiuos.Focus();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //leer el valor del radio, se asigna el valor que se ingresa en la 
            // caja de texto txtRadious a la variable radiuos, para lo cual se hace 
            //una conversion implicita de un tipo de dato String a double 
            radiuos = double.Parse (txtRadiuos.Text);

            //se calcula el valor del perimetro del circulo
            perimeter = 2 * Math.PI * radiuos;
            
            //se calcula el valor del area del circulo 
            area = Math.PI * Math.Pow(radiuos, 2);

            //Se despliega el valor del perimetro y el area en los controles 
            // TextBoxes, para lo cual se hace una conversion implicita de un 
            // tipo de dato double a String 
            txtPerimetro.Text = perimeter.ToString();
            txtArea.Text = area.ToString();

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            //Inicializar las variables radiuos, perimeter, area con cero 
            radiuos = 0; perimeter = 0; area = 0;

            //Inicializar las cajas de texto con comillas dobles ("")
            txtRadiuos.Text = "";// las comillas dobles es equivalente a (BLANK)
            txtPerimetro.Text = "";
            txtArea.Text = "";

            //la funcion focus activa el cursor en la caja de texto txtRadiuos
            txtRadiuos.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //funcion close permiete cerrar un formulario 
            Close();
        }
    }
}
