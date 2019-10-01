using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esta libreria Sirve para manejar los controles de los formularios   
using System.Windows.Forms; 
namespace WinAppCircleV3
{
    class CCircle
    {
        //datos miembro - atributos de la clase
        private double mperimeter, marea, mradiuos;

        //Funciones miembro - metodos de la clase 

        // constructor sin parametros
        public CCircle()
        {
            InitializeData();
        }

        public  CCircle(double r)
        {
            mradiuos = r;
        }

        public void InitializeData()
        {
            mradiuos = 0; mperimeter = 0; marea = 0;
        }

        public void InitializeData(TextBox txtRadiuos, 
                                   TextBox txtPerimetro, 
                                   TextBox txtArea )
        {

            //Inicializar las variables radiuos, perimeter, area con cero 
            mradiuos = 0; mperimeter = 0; marea = 0;

            //Inicializar las cajas de texto con comillas dobles ("")
            txtRadiuos.Text = "";// las comillas dobles es equivalente a (BLANK)
            txtPerimetro.Text = "";
            txtArea.Text = "";

            //la funcion focus activa el cursor en la caja de texto txtRadiuos
            txtRadiuos.Focus();
        }
        public void ReadData(TextBox txtRadiuos)
        {
            //leer el valor del radio, se asigna el valor que se ingresa en la 
            // caja de texto txtRadious a la variable radiuos, para lo cual se hace 
            //una conversion implicita de un tipo de dato String a double 
            mradiuos = double.Parse(txtRadiuos.Text);

        }

        public void CalculatePerimeter()
        {
            mperimeter = 2 * Math.PI * mradiuos;
        }

        public void CalculateArea()
        {
            marea = Math.PI * Math.Pow(mradiuos, 2);
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
