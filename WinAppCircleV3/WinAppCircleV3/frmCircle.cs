using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCircleV3
{
    public partial class frmCircle : Form
    {
        private CCircle ObjCCircle = new CCircle ();
        public frmCircle()
        {
            InitializeComponent();
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {
            ObjCCircle.InitializeData(txtArea, txtPerimetro, txtRadiuos);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            ObjCCircle.ReadData(txtRadiuos);
            ObjCCircle.CalculatePerimeter();
            ObjCCircle.CalculateArea();
            ObjCCircle.PrintData(txtPerimetro,txtArea);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ObjCCircle.InitializeData(txtArea, txtPerimetro, txtRadiuos);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
