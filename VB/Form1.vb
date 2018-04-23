Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace SwapRows
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Left
			' 
			' gridControl1.EmbeddedNavigator
			' 
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(267, 235)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "ID"
			Me.dataColumn1.DataType = GetType(Integer)
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Keyword"
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Order"
			Me.dataColumn3.DataType = GetType(Integer)
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(280, 28)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(62, 20)
			Me.button1.TabIndex = 1
			Me.button1.Text = "&Up"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(280, 62)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(62, 20)
			Me.button2.TabIndex = 2
			Me.button2.Text = "&Down"
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(353, 235)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub FillDataSet()
			dataTable1.Rows.Add(New Object() {1, "abstract", 1})
			dataTable1.Rows.Add(New Object() {2, "event", 2})
			dataTable1.Rows.Add(New Object() {3, "new", 3})
			dataTable1.Rows.Add(New Object() {4, "struct", 4})
			dataTable1.Rows.Add(New Object() {5, "as", 5})
			dataTable1.Rows.Add(New Object() {6, "explicit", 6})
			dataTable1.Rows.Add(New Object() {7, "null", 7})
			dataTable1.Rows.Add(New Object() {8, "switch", 8})
			dataTable1.Rows.Add(New Object() {9, "base", 9})
			dataTable1.Rows.Add(New Object() {10, "extern", 10})
			dataTable1.Rows.Add(New Object() {11, "object", 11})
			dataTable1.Rows.Add(New Object() {12, "this", 12})
			dataTable1.Rows.Add(New Object() {13, "bool", 13})
			dataTable1.Rows.Add(New Object() {14, "false", 14})
			dataTable1.Rows.Add(New Object() {15, "operator", 15})
			dataTable1.Rows.Add(New Object() {16, "throw", 16})
			dataTable1.Rows.Add(New Object() {17, "break", 17})
			dataTable1.AcceptChanges()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			FillDataSet()
			gridControl1.DataSource = dataTable1
			gridView1.PopulateColumns()
			gridView1.Columns(OrderFieldName).SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
			gridView1.OptionsCustomization.AllowSort = False
			gridView1.OptionsView.ShowGroupPanel = False
		End Sub

		Private Const OrderFieldName As String = "Order"

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gridView1
			view.GridControl.Focus()
			Dim index As Integer = view.FocusedRowHandle
			If index <= 0 Then
				Return
			End If

			Dim row1 As DataRow = view.GetDataRow(index)
			Dim row2 As DataRow = view.GetDataRow(index - 1)
			Dim val1 As Object = row1(OrderFieldName)
			Dim val2 As Object = row2(OrderFieldName)
			row1(OrderFieldName) = val2
			row2(OrderFieldName) = val1

			view.FocusedRowHandle = index - 1
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gridView1
			view.GridControl.Focus()
			Dim index As Integer = view.FocusedRowHandle
			If index >= view.DataRowCount - 1 Then
				Return
			End If

			Dim row1 As DataRow = view.GetDataRow(index)
			Dim row2 As DataRow = view.GetDataRow(index + 1)
			Dim val1 As Object = row1(OrderFieldName)
			Dim val2 As Object = row2(OrderFieldName)
			row1(OrderFieldName) = val2
			row2(OrderFieldName) = val1

			view.FocusedRowHandle = index + 1
		End Sub
	End Class
End Namespace
