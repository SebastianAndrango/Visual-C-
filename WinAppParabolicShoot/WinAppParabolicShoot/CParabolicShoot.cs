using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppParabolicShoot
{
    class CParabolicShoot
    {
        private float mVelocity, mTheta, mDistance, mHigh, mTime;
        private const float G = 9.81f; // con const se declara una constante 

        //funciones miembro - metodos de una clase 

        //constructor de la clase sin parametros 

        public CParabolicShoot()
        {
            InitializeData();
        }

        //funcion para inicializar los datos miembro 
        public void InitializeData()
        {
            mVelocity = 0.0f; mTheta = 0.0f; mDistance = 0.0f; mHigh = 0.0f; mTime = 0.0f;
        }

        public void InitializeData(TextBox txtVelocity,
                                   TextBox txtTheta,
                                   TextBox txtDistance,
                                   TextBox txtHigh,
                                   TextBox txtTime)
        {

            //Inicializar las variables radiuos, perimeter, area con cero 
            mVelocity = 0; mTheta = 0; mDistance = 0; mHigh = 0; mTime = 0; 

            //Inicializar las cajas de texto con comillas dobles ("")
            txtSideA.Text = "";// las comillas dobles es equivalente a (BLANK)
            txtSideB.Text = "";
            txtSideC.Text = "";
            txtSemiperimeter.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            //la funcion focus activa el cursor en la caja de texto txtRadiuos
            txtVelocity.Focus();
        }

        //leer loa valores de la velocidad y el angulo de lanzamiento 
        public void ReadData()
        {
            Scanner scan = new Scanner(System.in);
            System.out.printf("Ingrese el valor de la velocidad (m/seg): ");
            mVelocity = scan.nextFloat();
            System.out.printf("Ingrese el valor del angulo theta (grados)");
            mTheta = scan.nextFloat();
        }

        //convertir de grados a radianes al angulo 
        public void ConvertGradesToRadians()
        {
            mTheta = mTheta * (float)Math.PI / 180.0f;
        }

        //calcular la distancia
        public void CalculateDistance()
        {

            mDistance = ((float)Math.pow(mVelocity, 2) * (float)Math.sin(2 * mTheta));
        }

        //calcular tiempo 
        public void CalculateTime()
        {

            mTime = (2 * mVelocity * (float)Math.sin(mTheta)) / G;
        }

        //calcular altura 
        public void CalculateHigh()
        {
            MHigh = ((float)Math.pow(mVelocity, 2) * (float)Math.sin(mTheta)) / G;
        }

        public void PrintData()
        {
            System.out.printf("Distancia (m): %f\n", mDistance);
            System.out.printf("Altura (m): %f\n", MHigh);
            System.out.printf("Tiempo de vuelo (seg): %f", mTime);
        }
    }
}
