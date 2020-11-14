using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjDonateSchool
{
    public partial class FrmPayments : Form
    {
        public FrmPayments()
        {
            InitializeComponent();
        }

        private void FrmPayments_Load(object sender, EventArgs e)
        {
            Width = Screen.PrimaryScreen.Bounds.Width/2;
            Height = Screen.PrimaryScreen.Bounds.Height/2;
            Left = Width / 2;
            Top = Height / 2;
        }
    }
}
