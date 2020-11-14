using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using prjDAL;

namespace prjDonateSchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new ZamaniEntities();
            gridControl1.DataSource = db.tblStudents.ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var ea = e as DXMouseEventArgs;
            var view = sender as GridView;
            var info = view?.CalcHitInfo(ea.Location);
            if (info == null || (!info.InRow && !info.InRowCell)) return;
            var handles = gridView1.GetSelectedRows();
            if (handles.Length <= 0) return;
            var codeMeli = gridView1.GetRowCellValue(handles[0], "CodeMeli").ToString();
            var frmPayments = new FrmPayments();
            frmPayments.ShowDialog();
        }
    }
}
