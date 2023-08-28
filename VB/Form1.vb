Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace SwapRows

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits Form

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private dataSet1 As DataSet

        Private dataTable1 As DataTable

        Private dataColumn1 As DataColumn

        Private dataColumn2 As DataColumn

        Private dataColumn3 As DataColumn

        Private button1 As Button

        Private button2 As Button

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
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
            gridControl1 = New DevExpress.XtraGrid.GridControl()
            gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            dataSet1 = New DataSet()
            dataTable1 = New DataTable()
            dataColumn1 = New DataColumn()
            dataColumn2 = New DataColumn()
            dataColumn3 = New DataColumn()
            button1 = New Button()
            button2 = New Button()
            CType(gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            gridControl1.Dock = DockStyle.Left
            ' 
            ' gridControl1.EmbeddedNavigator
            ' 
            gridControl1.EmbeddedNavigator.Name = ""
            gridControl1.Location = New System.Drawing.Point(0, 0)
            gridControl1.MainView = gridView1
            gridControl1.Name = "gridControl1"
            gridControl1.Size = New System.Drawing.Size(267, 235)
            gridControl1.TabIndex = 0
            gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {gridView1})
            ' 
            ' gridView1
            ' 
            gridView1.GridControl = gridControl1
            gridView1.Name = "gridView1"
            ' 
            ' dataSet1
            ' 
            dataSet1.DataSetName = "NewDataSet"
            dataSet1.Locale = New Globalization.CultureInfo("en-US")
            dataSet1.Tables.AddRange(New DataTable() {dataTable1})
            ' 
            ' dataTable1
            ' 
            dataTable1.Columns.AddRange(New DataColumn() {dataColumn1, dataColumn2, dataColumn3})
            dataTable1.TableName = "Table1"
            ' 
            ' dataColumn1
            ' 
            dataColumn1.ColumnName = "ID"
            dataColumn1.DataType = GetType(Integer)
            ' 
            ' dataColumn2
            ' 
            dataColumn2.ColumnName = "Keyword"
            ' 
            ' dataColumn3
            ' 
            dataColumn3.ColumnName = "Order"
            dataColumn3.DataType = GetType(Integer)
            ' 
            ' button1
            ' 
            button1.Location = New System.Drawing.Point(280, 28)
            button1.Name = "button1"
            button1.Size = New System.Drawing.Size(62, 20)
            button1.TabIndex = 1
            button1.Text = "&Up"
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' button2
            ' 
            button2.Location = New System.Drawing.Point(280, 62)
            button2.Name = "button2"
            button2.Size = New System.Drawing.Size(62, 20)
            button2.TabIndex = 2
            button2.Text = "&Down"
            AddHandler button2.Click, New EventHandler(AddressOf button2_Click)
            ' 
            ' Form1
            ' 
            AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            ClientSize = New System.Drawing.Size(353, 235)
            Me.Controls.Add(button2)
            Me.Controls.Add(button1)
            Me.Controls.Add(gridControl1)
            Name = "Form1"
            Text = "Form1"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            CType(gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Call Application.Run(New Form1())
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

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillDataSet()
            gridControl1.DataSource = dataTable1
            gridView1.PopulateColumns()
            gridView1.Columns(OrderFieldName).SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            gridView1.OptionsCustomization.AllowSort = False
            gridView1.OptionsView.ShowGroupPanel = False
        End Sub

        Const OrderFieldName As String = "Order"

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gridView1
            view.GridControl.Focus()
            Dim index As Integer = view.FocusedRowHandle
            If index <= 0 Then Return
            Dim row1 As DataRow = view.GetDataRow(index)
            Dim row2 As DataRow = view.GetDataRow(index - 1)
            Dim val1 As Object = row1(OrderFieldName)
            Dim val2 As Object = row2(OrderFieldName)
            row1(OrderFieldName) = val2
            row2(OrderFieldName) = val1
            view.FocusedRowHandle = index - 1
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gridView1
            view.GridControl.Focus()
            Dim index As Integer = view.FocusedRowHandle
            If index >= view.DataRowCount - 1 Then Return
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
