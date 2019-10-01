using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppRectangleV1
{
    public partial class frmRectangle : Form
    {
        private double perimeter, area, largo, ancho;
        public frmRectangle()
        {
            InitializeComponent();
        }

        private void FrmRectangle_Load(object sender, EventArgs e)
        {
            perimeter = 0; area = 0; largo = 0; ancho = 0;
            txtLargo.Text = "";// las comillas dobles es equivalente a (BLANK)
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtAncho.Text = "";
            txtLargo.Focus();
            txtAncho.Focus();

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            largo = double.Parse(txtLargo.Text);
            ancho = double.Parse(txtAncho.Text);
            perimeter = 2 * (largo + ancho);
            area = largo * ancho;
            txtPerimetro.Text = perimeter.ToString();
            txtArea.Text = area.ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            //Inicializar las variables radiuos, perimeter, area con cero 
            largo = 0; ancho = 0; perimeter = 0; area = 0;

            //Inicializar las cajas de texto con comillas dobles ("")
            txtLargo.Text = "";// las comillas dobles es equivalente a (BLANK)
            txtAncho.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            //la funcion focus activa el cursor en la caja de texto txtRadiuos
            txtLargo.Focus();
            txtAncho.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
