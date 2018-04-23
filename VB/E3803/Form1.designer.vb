Imports Microsoft.VisualBasic
Imports System
Namespace E3803
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl2
			' 
			Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl2.Location = New System.Drawing.Point(0, 0)
			Me.gridControl2.MainView = Me.gridView2
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.Size = New System.Drawing.Size(665, 250)
			Me.gridControl2.TabIndex = 0
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2})
			' 
			' gridView2
			' 
			Me.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
			Me.gridView2.GridControl = Me.gridControl2
			Me.gridView2.Name = "gridView2"
			Me.gridView2.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.gridView2.OptionsSelection.EnableAppearanceFocusedRow = False
			Me.gridView2.OptionsView.ShowIndicator = False
'			Me.gridView2.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.myGridView1_CustomDrawCell);
'			Me.gridView2.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.myGridView1_MouseMove);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(665, 250)
			Me.Controls.Add(Me.gridControl2)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
	End Class
End Namespace

