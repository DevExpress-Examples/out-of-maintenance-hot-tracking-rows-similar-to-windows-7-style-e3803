using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors;
using System.Drawing;

namespace E3803
{
    class HotTrackHelper
    {
        GridView _view;
        int hotRow = GridControl.InvalidRowHandle;

        public HotTrackHelper(GridView view)
        {
            Attach(view);
        }
        void Attach(GridView view)
        {
            _view = view;
            _view.CustomDrawCell += new RowCellCustomDrawEventHandler(_view_CustomDrawCell);
            _view.MouseMove += new MouseEventHandler(_view_MouseMove);
        }

        void _view_MouseMove(object sender, MouseEventArgs e)
        {
            GridHitInfo hi = _view.CalcHitInfo(e.Location);
            {
                if (hotRow != hi.RowHandle)
                {
                    _view.RefreshRow(hotRow);
                    hotRow = hi.RowHandle;
                    _view.RefreshRow(hotRow);
                }
            }

        }

        void _view_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (hotRow != e.RowHandle && e.RowHandle != _view.FocusedRowHandle) return;
            GridCellInfo CellInfo = e.Cell as GridCellInfo;

            SimpleButton button = new SimpleButton();
            _view.GridControl.FindForm().Controls.Add(button);
            button.Bounds = CellInfo.RowInfo.Bounds;

            Bitmap bm = new Bitmap(button.Width, button.Height);
            button.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
            Rectangle rec = Rectangle.Intersect(CellInfo.RowInfo.Bounds, CellInfo.CellValueRect);
            rec.Offset(-CellInfo.RowInfo.Bounds.X, -CellInfo.RowInfo.Bounds.Y);
            e.Graphics.DrawImage(bm, CellInfo.Bounds, rec, GraphicsUnit.Pixel);
            _view.GridControl.FindForm().Controls.Remove(button);
        }
        void Detach(GridView view)
        {
            _view = null;
        }
    }
}
