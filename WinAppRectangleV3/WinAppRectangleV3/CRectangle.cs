using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinAppRectangleV3
{
    class CRectangle
    {
        private double mperimeter, marea, mlargo, mancho;

        public CRectangle()
        {
            InitializeData();
        }

        public CRectangle (double l, double a)
        {
            mlargo= l;
            mancho = a;
        }

        public void InitializeData()
        {
            mlargo = 0; mancho = 0; mperimeter = 0; marea = 0;
        }

        public void InitializeData(TextBox txtLargo, TextBox txtAncho,
                                   TextBox txtPerimetro,
                                   TextBox txtArea)
        {

            //Inicializar las variables radiuos, perimeter, area con cero 
            mlargo = 0; mancho = 0; mperimeter = 0; marea = 0;

            //Inicializar las cajas de texto con comillas dobles ("")
            txtLargo.Text = "";// las comillas dobles es equivalente a (BLANK)
            txtAncho.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            //la funcion focus activa el cursor en la caja de texto txtRadiuos
            txtLargo.Focus();
            txtAncho.Focus();
        }
        public void ReadData(TextBox txtLargo, TextBox txtAncho)
        {
            //leer el valor del radio, se asigna el valor que se ingresa en la 
            // caja de texto txtRadious a la variable radiuos, para lo cual se hace 
            //una conversion implicita de un tipo de dato String a double 
            mlargo = double.Parse(txtLargo.Text);
            mancho = double.Parse(txtAncho.Text);

        }

        public void CalculatePerimeter()
        {
            mperimeter = 2 * (mlargo + mancho);
        }

        public void CalculateArea()
        {
            marea = mlargo * mancho;
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            //Se despliega el valor del perimetro y el area en los controles 
            // TextBoxes, para lo cual se hace una conversion implicita de un 
            // tipo de dato double a String 
            txtPerimetro.Text = mperimeter.ToString();
            txtArea.Text = marea.ToString();
        }
    }

}
