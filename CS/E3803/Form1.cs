using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace E3803
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gridControl2.DataSource = CreateTable(10);
            HotTrackHelper helper = new HotTrackHelper(gridView2);
        }

        private static DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
            
        }


        private void myGridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if (hotRow != e.RowHandle && e.RowHandle != gridView2.FocusedRowHandle) return;
            //GridCellInfo CellInfo = e.Cell as GridCellInfo;

            //SimpleButton button = new SimpleButton();
            //this.Controls.Add(button);
            //button.Bounds = CellInfo.RowInfo.Bounds;

            //Bitmap bm = new Bitmap(button.Width, button.Height);
            //button.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
            //Rectangle rec = Rectangle.Intersect(CellInfo.RowInfo.Bounds, CellInfo.CellValueRect);
            //rec.Offset(-CellInfo.RowInfo.Bounds.X, -CellInfo.RowInfo.Bounds.Y);
            //e.Graphics.DrawImage(bm, CellInfo.CellValueRect, rec, GraphicsUnit.Pixel);

        }

        int hotRow = GridControl.InvalidRowHandle;
        private void myGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            //GridHitInfo hi = gridView2.CalcHitInfo(e.Location);
            //{
            //    if (hotRow != hi.RowHandle)
            //    {
            //        gridView2.RefreshRow(hotRow);
            //        hotRow = hi.RowHandle;
            //        gridView2.RefreshRow(hotRow);
            //    }
            //}
        }

    }
}
