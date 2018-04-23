Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace E3803
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			gridControl2.DataSource = CreateTable(10)
			Dim helper As New HotTrackHelper(gridView2)
		End Sub

		Private Shared Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(Date))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, Date.Now.AddDays(i) })
			Next i
			Return tbl

		End Function


		Private Sub myGridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView2.CustomDrawCell
			'if (hotRow != e.RowHandle && e.RowHandle != gridView2.FocusedRowHandle) return;
			'GridCellInfo CellInfo = e.Cell as GridCellInfo;

			'SimpleButton button = new SimpleButton();
			'this.Controls.Add(button);
			'button.Bounds = CellInfo.RowInfo.Bounds;

			'Bitmap bm = new Bitmap(button.Width, button.Height);
			'button.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
			'Rectangle rec = Rectangle.Intersect(CellInfo.RowInfo.Bounds, CellInfo.CellValueRect);
			'rec.Offset(-CellInfo.RowInfo.Bounds.X, -CellInfo.RowInfo.Bounds.Y);
			'e.Graphics.DrawImage(bm, CellInfo.CellValueRect, rec, GraphicsUnit.Pixel);

		End Sub

		Private hotRow As Integer = GridControl.InvalidRowHandle
		Private Sub myGridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView2.MouseMove
			'GridHitInfo hi = gridView2.CalcHitInfo(e.Location);
			'{
			'    if (hotRow != hi.RowHandle)
			'    {
			'        gridView2.RefreshRow(hotRow);
			'        hotRow = hi.RowHandle;
			'        gridView2.RefreshRow(hotRow);
			'    }
			'}
		End Sub

	End Class
End Namespace
