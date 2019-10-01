using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppRectangleV3
{
    public partial class frmRectangle : Form
    {
        private CRectangle ObjCRectangle = new CRectangle();
        public frmRectangle()
        {
            InitializeComponent();
        }

        private void FrmRectangle_Load(object sender, EventArgs e)
        {
            ObjCRectangle.InitializeData(txtArea, txtPerimetro, txtLargo, txtAncho);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            ObjCRectangle.ReadData(txtLargo,txtAncho);
            ObjCRectangle.CalculatePerimeter();
            ObjCRectangle.CalculateArea();
            ObjCRectangle.PrintData(txtPerimetro, txtArea);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ObjCRectangle.InitializeData(txtArea, txtPerimetro, txtLargo, txtAncho);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
