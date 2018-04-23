Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors
Imports System.Drawing

Namespace E3803
	Friend Class HotTrackHelper
		Private _view As GridView
		Private hotRow As Integer = GridControl.InvalidRowHandle

		Public Sub New(ByVal view As GridView)
			Attach(view)
		End Sub
		Private Sub Attach(ByVal view As GridView)
			_view = view
			AddHandler _view.CustomDrawCell, AddressOf _view_CustomDrawCell
			AddHandler _view.MouseMove, AddressOf _view_MouseMove
		End Sub

		Private Sub _view_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim hi As GridHitInfo = _view.CalcHitInfo(e.Location)
				If hotRow <> hi.RowHandle Then
					_view.RefreshRow(hotRow)
					hotRow = hi.RowHandle
					_view.RefreshRow(hotRow)
				End If

		End Sub

		Private Sub _view_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
			If hotRow <> e.RowHandle AndAlso e.RowHandle <> _view.FocusedRowHandle Then
				Return
			End If
			Dim CellInfo As GridCellInfo = TryCast(e.Cell, GridCellInfo)

			Dim button As New SimpleButton()
			_view.GridControl.FindForm().Controls.Add(button)
			button.Bounds = CellInfo.RowInfo.Bounds

			Dim bm As New Bitmap(button.Width, button.Height)
			button.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
			Dim rec As Rectangle = Rectangle.Intersect(CellInfo.RowInfo.Bounds, CellInfo.CellValueRect)
			rec.Offset(-CellInfo.RowInfo.Bounds.X, -CellInfo.RowInfo.Bounds.Y)
			e.Graphics.DrawImage(bm, CellInfo.Bounds, rec, GraphicsUnit.Pixel)
			_view.GridControl.FindForm().Controls.Remove(button)
		End Sub
		Private Sub Detach(ByVal view As GridView)
			_view = Nothing
		End Sub
	End Class
End Namespace
