using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCircleV2
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

        private void InitializeData ()
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

        private void ReadData()
        {
            //leer el valor del radio, se asigna el valor que se ingresa en la 
            // caja de texto txtRadious a la variable radiuos, para lo cual se hace 
            //una conversion implicita de un tipo de dato String a double 
            radiuos = double.Parse(txtRadiuos.Text);

        }

        private void CalculatePerimeter()
        {
            perimeter = 2 * Math.PI * radiuos;
        }

        private void CalculateArea()
        {
            area = Math.PI * Math.Pow(radiuos, 2);
        }

        private void PrintData()
        {
            //Se despliega el valor del perimetro y el area en los controles 
            // TextBoxes, para lo cual se hace una conversion implicita de un 
            // tipo de dato double a String 
            txtPerimetro.Text = perimeter.ToString();
            txtArea.Text = area.ToString();
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {
            InitializeData();
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            ReadData();
            CalculatePerimeter();
            CalculateArea();
            PrintData();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
