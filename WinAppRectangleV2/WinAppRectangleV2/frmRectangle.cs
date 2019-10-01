using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppRectangleV2
{
    public partial class frmRectangle : Form
    {
        private double perimeter, area, largo, ancho;
        public frmRectangle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeData();
        }
        private void InitializeData()
        {

            perimeter = 0; area = 0; largo = 0; ancho = 0;
            txtLargo.Text = "";// las comillas dobles es equivalente a (BLANK)
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtAncho.Text = "";
            txtLargo.Focus();
            txtAncho.Focus();
        }

        private void ReadData()
        {
            largo = double.Parse(txtLargo.Text);
            ancho = double.Parse(txtAncho.Text);

        }


        private void CalculatePerimeter()
        {
            perimeter = 2 * (largo + ancho);
        }

        private void CalculateArea()
        {
            area = largo * ancho;
        }

        private void PrintData()
        {
            //Se despliega el valor del perimetro y el area en los controles 
            // TextBoxes, para lo cual se hace una conversion implicita de un 
            // tipo de dato double a String 
            txtPerimetro.Text = perimeter.ToString();
            txtArea.Text = area.ToString();
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
