<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class scoresReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scoresReport))
        Dim CustomSqlQuery2 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim DynamicListLookUpSettings2 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim DynamicListLookUpSettings3 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.SAssFormattingRule2 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.FTestFormattingRule3 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.STestFormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.ExamFormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.TotalFormattingRule4 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.FAssFormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.yt_label = New DevExpress.XtraReports.UI.XRLabel()
        Me.tw_label = New DevExpress.XtraReports.UI.XRLabel()
        Me.fb_label = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.vendorContactsTable = New DevExpress.XtraReports.UI.XRTable()
        Me.vendorContactsRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrsch_website = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrSch_email = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrSch_phone = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrSchAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrNameOfSchool = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrAss1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrAss2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTest1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTest2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrExam = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTotal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine7 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine9 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine10 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.totalTable = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.totalRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.totalCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.total = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrGroundTotal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.baseControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.LineTotalCalcField = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GrandTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.percentageDiscount = New DevExpress.XtraReports.UI.CalculatedField()
        Me.percentageAmount = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GradeFormattingRule5 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.sessionIDParams = New DevExpress.XtraReports.Parameters.Parameter()
        Me.classIDParams = New DevExpress.XtraReports.Parameters.Parameter()
        Me.studentIDParams = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorContactsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.totalTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "dbConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "Query"
        QueryParameter1.Name = "sessionIDParams"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.sessionIDParams]", GetType(String))
        QueryParameter2.Name = "classIDParams"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.classIDParams]", GetType(String))
        QueryParameter3.Name = "studentID"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.studentIDParams]", GetType(String))
        CustomSqlQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter1, QueryParameter2, QueryParameter3})
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        CustomSqlQuery2.Name = "ScoreReportQuery"
        CustomSqlQuery2.Sql = resources.GetString("CustomSqlQuery2.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1, CustomSqlQuery2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.HeightF = 21.12494!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("subjectName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.StyleName = "baseControlStyle"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(1.413409!, 1.124935!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(731.2517!, 20.0!)
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell69, Me.XrTableCell70, Me.XrTableCell71, Me.XrTableCell72, Me.XrTableCell68, Me.XrTableCell12, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.StylePriority.UseFont = False
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[subjectName]")})
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell4.Weight = 2.48816471716985R
        '
        'XrTableCell69
        '
        Me.XrTableCell69.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[firstAss]")})
        Me.XrTableCell69.Name = "XrTableCell69"
        Me.XrTableCell69.StylePriority.UseTextAlignment = False
        Me.XrTableCell69.Text = "XrTableCell69"
        Me.XrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell69.Weight = 0.500535249985899R
        '
        'XrTableCell70
        '
        Me.XrTableCell70.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[secondass]")})
        Me.XrTableCell70.Name = "XrTableCell70"
        Me.XrTableCell70.StylePriority.UseTextAlignment = False
        Me.XrTableCell70.Text = "XrTableCell70"
        Me.XrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell70.Weight = 0.500535244858109R
        '
        'XrTableCell71
        '
        Me.XrTableCell71.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[firstca]")})
        Me.XrTableCell71.Name = "XrTableCell71"
        Me.XrTableCell71.StylePriority.UseTextAlignment = False
        Me.XrTableCell71.Text = "XrTableCell71"
        Me.XrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell71.Weight = 0.500535238407205R
        '
        'XrTableCell72
        '
        Me.XrTableCell72.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[secondca]")})
        Me.XrTableCell72.Name = "XrTableCell72"
        Me.XrTableCell72.StylePriority.UseTextAlignment = False
        Me.XrTableCell72.Text = "XrTableCell72"
        Me.XrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell72.Weight = 0.50053524708652R
        '
        'XrTableCell68
        '
        Me.XrTableCell68.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[exam]")})
        Me.XrTableCell68.Name = "XrTableCell68"
        Me.XrTableCell68.StylePriority.UseTextAlignment = False
        Me.XrTableCell68.Text = "XrTableCell68"
        Me.XrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell68.Weight = 0.500535258006065R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[totalScore]")})
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "100"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell12.Weight = 0.500535247393114R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[subjectPosition]")})
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "XrTableCell5"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell5.Weight = 0.500535240988435R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[gradeRemarks]")})
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "XrTableCell6"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell6.Weight = 1.52861077650337R
        '
        'SAssFormattingRule2
        '
        Me.SAssFormattingRule2.DataMember = "student_marks"
        Me.SAssFormattingRule2.Formatting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SAssFormattingRule2.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.SAssFormattingRule2.Name = "SAssFormattingRule2"
        '
        'FTestFormattingRule3
        '
        Me.FTestFormattingRule3.DataMember = "student_marks"
        Me.FTestFormattingRule3.Formatting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FTestFormattingRule3.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.FTestFormattingRule3.Name = "FTestFormattingRule3"
        '
        'STestFormattingRule1
        '
        Me.STestFormattingRule1.DataMember = "student_marks"
        Me.STestFormattingRule1.Formatting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.STestFormattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.STestFormattingRule1.Name = "STestFormattingRule1"
        '
        'ExamFormattingRule1
        '
        Me.ExamFormattingRule1.DataMember = "student_marks"
        Me.ExamFormattingRule1.Formatting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExamFormattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.ExamFormattingRule1.Name = "ExamFormattingRule1"
        '
        'TotalFormattingRule4
        '
        Me.TotalFormattingRule4.DataMember = "student_marks"
        Me.TotalFormattingRule4.Formatting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TotalFormattingRule4.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.TotalFormattingRule4.Name = "TotalFormattingRule4"
        '
        'FAssFormattingRule1
        '
        Me.FAssFormattingRule1.DataMember = "Query"
        Me.FAssFormattingRule1.DataSource = Me.SqlDataSource1
        Me.FAssFormattingRule1.Formatting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FAssFormattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.FAssFormattingRule1.Name = "FAssFormattingRule1"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 11.29166!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBackColor = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel16, Me.XrLine8, Me.xrLine1, Me.yt_label, Me.tw_label, Me.fb_label, Me.XrPictureBox4, Me.XrPictureBox3, Me.XrPictureBox2, Me.vendorContactsTable})
        Me.BottomMargin.HeightF = 106.448!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLabel16.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 7.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(502.5487!, 83.94801!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(234.0177!, 12.5!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Generated by - SRSC (08066838217)"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine8
        '
        Me.XrLine8.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLine8.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrLine8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.XrLine8.LineWidth = 2.0!
        Me.XrLine8.LocationFloat = New DevExpress.Utils.PointFloat(5.979919!, 0.07292429!)
        Me.XrLine8.Name = "XrLine8"
        Me.XrLine8.SizeF = New System.Drawing.SizeF(729.7052!, 3.770761!)
        Me.XrLine8.StylePriority.UseForeColor = False
        '
        'xrLine1
        '
        Me.xrLine1.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.xrLine1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.xrLine1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.xrLine1.LineWidth = 2.0!
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 77.56252!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(741.6851!, 2.0!)
        Me.xrLine1.StylePriority.UseForeColor = False
        '
        'yt_label
        '
        Me.yt_label.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yt_label.LocationFloat = New DevExpress.Utils.PointFloat(526.0082!, 49.48966!)
        Me.yt_label.Name = "yt_label"
        Me.yt_label.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.yt_label.SizeF = New System.Drawing.SizeF(168.9684!, 23.0!)
        Me.yt_label.StylePriority.UseFont = False
        Me.yt_label.StylePriority.UseTextAlignment = False
        Me.yt_label.Text = "fb_label"
        Me.yt_label.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'tw_label
        '
        Me.tw_label.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tw_label.LocationFloat = New DevExpress.Utils.PointFloat(272.044!, 54.56252!)
        Me.tw_label.Name = "tw_label"
        Me.tw_label.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.tw_label.SizeF = New System.Drawing.SizeF(199.7578!, 23.0!)
        Me.tw_label.StylePriority.UseFont = False
        Me.tw_label.StylePriority.UseTextAlignment = False
        Me.tw_label.Text = "fb_label"
        Me.tw_label.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'fb_label
        '
        Me.fb_label.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fb_label.LocationFloat = New DevExpress.Utils.PointFloat(54.20669!, 54.56252!)
        Me.fb_label.Name = "fb_label"
        Me.fb_label.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.fb_label.SizeF = New System.Drawing.SizeF(168.75!, 23.0!)
        Me.fb_label.StylePriority.UseFont = False
        Me.fb_label.StylePriority.UseTextAlignment = False
        Me.fb_label.Text = "fb_label"
        Me.fb_label.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox4.ImageSource"))
        Me.XrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(479.144!, 54.56252!)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.SizeF = New System.Drawing.SizeF(35.89783!, 23.0!)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox3.ImageSource"))
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(241.4681!, 54.56252!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(19.58412!, 23.0!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox2.ImageSource"))
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(30.0096!, 54.56252!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(19.58412!, 23.0!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'vendorContactsTable
        '
        Me.vendorContactsTable.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.vendorContactsTable.BorderColor = System.Drawing.Color.Gray
        Me.vendorContactsTable.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.vendorContactsTable.LocationFloat = New DevExpress.Utils.PointFloat(5.979919!, 10.9999!)
        Me.vendorContactsTable.Name = "vendorContactsTable"
        Me.vendorContactsTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vendorContactsTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.vendorContactsRow})
        Me.vendorContactsTable.SizeF = New System.Drawing.SizeF(716.6851!, 25.0!)
        Me.vendorContactsTable.StylePriority.UseBorderColor = False
        Me.vendorContactsTable.StylePriority.UseFont = False
        Me.vendorContactsTable.StylePriority.UsePadding = False
        '
        'vendorContactsRow
        '
        Me.vendorContactsRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrsch_website, Me.xrSch_email, Me.xrSch_phone})
        Me.vendorContactsRow.Name = "vendorContactsRow"
        Me.vendorContactsRow.Weight = 1.0R
        '
        'xrsch_website
        '
        Me.xrsch_website.CanShrink = True
        Me.xrsch_website.Name = "xrsch_website"
        Me.xrsch_website.StylePriority.UseTextAlignment = False
        Me.xrsch_website.Text = "VendorWebsite"
        Me.xrsch_website.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrsch_website.Weight = 1.07796490230565R
        '
        'xrSch_email
        '
        Me.xrSch_email.CanShrink = True
        Me.xrSch_email.Name = "xrSch_email"
        Me.xrSch_email.StylePriority.UseBorders = False
        Me.xrSch_email.StylePriority.UseTextAlignment = False
        Me.xrSch_email.Text = "VendorEmail"
        Me.xrSch_email.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrSch_email.Weight = 1.04412289162163R
        '
        'xrSch_phone
        '
        Me.xrSch_phone.CanShrink = True
        Me.xrSch_phone.Name = "xrSch_phone"
        Me.xrSch_phone.StylePriority.UseBorders = False
        Me.xrSch_phone.StylePriority.UseTextAlignment = False
        Me.xrSch_phone.Text = "VendorPhone"
        Me.xrSch_phone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrSch_phone.Weight = 0.940667796112451R
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel19, Me.XrLabel20, Me.XrLabel17, Me.XrLabel18, Me.XrSchAddress, Me.XrLabel2, Me.XrLabel11, Me.XrLabel1, Me.XrNameOfSchool, Me.XrLine2, Me.XrPictureBox1, Me.XrLabel3, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6, Me.XrLabel7, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("surname", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("otherNames", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader1.HeightF = 195.0834!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.StyleName = "baseControlStyle"
        Me.GroupHeader1.StylePriority.UseBackColor = False
        Me.GroupHeader1.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel19.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(408.4675!, 157.9167!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(196.5212!, 23.0!)
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "3"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel20
        '
        Me.XrLabel20.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(292.0172!, 157.9167!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(116.4503!, 23.0!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "Next Term Begin:"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(604.9886!, 157.9167!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(99.34375!, 23.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "Class Position:"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[classPosition]")})
        Me.XrLabel18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(704.3325!, 157.9167!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(37.35266!, 23.0!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "3"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrSchAddress
        '
        Me.XrSchAddress.Font = New System.Drawing.Font("Calibri", 15.5!)
        Me.XrSchAddress.LocationFloat = New DevExpress.Utils.PointFloat(121.3474!, 50.08332!)
        Me.XrSchAddress.Name = "XrSchAddress"
        Me.XrSchAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrSchAddress.SizeF = New System.Drawing.SizeF(586.2394!, 28.91668!)
        Me.XrSchAddress.StylePriority.UseFont = False
        Me.XrSchAddress.StylePriority.UseTextAlignment = False
        Me.XrSchAddress.Text = "XrNameOfSchool"
        Me.XrSchAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(638.707!, 124.2085!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(21.43335!, 22.99998!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "99"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(470.2398!, 124.2085!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(161.2835!, 23.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "No. of Students in class:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Calibri", 19.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(292.0172!, 79.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(220.1926!, 25.99999!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "TERMLY REPORT"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrNameOfSchool
        '
        Me.XrNameOfSchool.Font = New System.Drawing.Font("Calibri", 28.0!, System.Drawing.FontStyle.Bold)
        Me.XrNameOfSchool.LocationFloat = New DevExpress.Utils.PointFloat(121.3474!, 3.54166!)
        Me.XrNameOfSchool.Name = "XrNameOfSchool"
        Me.XrNameOfSchool.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrNameOfSchool.SizeF = New System.Drawing.SizeF(586.2394!, 46.54166!)
        Me.XrNameOfSchool.StylePriority.UseFont = False
        Me.XrNameOfSchool.StylePriority.UseTextAlignment = False
        Me.XrNameOfSchool.Text = "XrNameOfSchool"
        Me.XrNameOfSchool.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 6.0!
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(1.413409!, 105.1667!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(734.2717!, 6.25!)
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource(Global.SRCSv3._1.My.Resources.Resources.logoGlory, True)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 3.54166!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(110.6731!, 101.625!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(6.381607!, 124.2085!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(51.6!, 22.99998!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Name:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString('{0} {1}',[surname],[otherNames])")})
        Me.XrLabel4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(57.98161!, 124.2085!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(247.8012!, 22.99998!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(306.7592!, 124.2085!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(43.75!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Class:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[stdClass]")})
        Me.XrLabel6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(350.5092!, 124.2085!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(114.1033!, 23.0!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "XrLabel4"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(6.939951!, 157.9167!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(39.58333!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Year:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[schYear]")})
        Me.XrLabel8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(46.52328!, 157.9167!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(92.20062!, 23.0!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "XrLabel4"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(138.7239!, 157.9167!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(44.79166!, 23.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Term:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[schTerm]")})
        Me.XrLabel10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(183.5155!, 157.9167!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(108.5016!, 23.0!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "XrLabel4"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.SubBand1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic)
        Me.SubBand1.HeightF = 30.0!
        Me.SubBand1.KeepTogether = True
        Me.SubBand1.Name = "SubBand1"
        Me.SubBand1.StylePriority.UseFont = False
        '
        'XrTable2
        '
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(1.413441!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(731.2516!, 30.0!)
        '
        'XrTableRow3
        '
        Me.XrTableRow3.BackColor = System.Drawing.Color.Black
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.xrAss1, Me.xrAss2, Me.xrTest1, Me.xrTest2, Me.xrExam, Me.xrTotal, Me.XrTableCell10, Me.XrTableCell11})
        Me.XrTableRow3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableRow3.ForeColor = System.Drawing.Color.White
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.StylePriority.UseBackColor = False
        Me.XrTableRow3.StylePriority.UseFont = False
        Me.XrTableRow3.StylePriority.UseForeColor = False
        Me.XrTableRow3.StylePriority.UseTextAlignment = False
        Me.XrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Subjects"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell9.Weight = 1.61499205072748R
        '
        'xrAss1
        '
        Me.xrAss1.Name = "xrAss1"
        Me.xrAss1.StylePriority.UseTextAlignment = False
        Me.xrAss1.Text = "Ass"
        Me.xrAss1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrAss1.Weight = 0.345482417779868R
        '
        'xrAss2
        '
        Me.xrAss2.Name = "xrAss2"
        Me.xrAss2.StylePriority.UseTextAlignment = False
        Me.xrAss2.Text = "Ass"
        Me.xrAss2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrAss2.Weight = 0.328332091693686R
        '
        'xrTest1
        '
        Me.xrTest1.Name = "xrTest1"
        Me.xrTest1.StylePriority.UseTextAlignment = False
        Me.xrTest1.Text = "Test"
        Me.xrTest1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTest1.Weight = 0.328332491423979R
        '
        'xrTest2
        '
        Me.xrTest2.Name = "xrTest2"
        Me.xrTest2.StylePriority.UseTextAlignment = False
        Me.xrTest2.Text = "Test"
        Me.xrTest2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTest2.Weight = 0.328332704613453R
        '
        'xrExam
        '
        Me.xrExam.Name = "xrExam"
        Me.xrExam.StylePriority.UseTextAlignment = False
        Me.xrExam.Text = "Exam"
        Me.xrExam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrExam.Weight = 0.32833227823449R
        '
        'xrTotal
        '
        Me.xrTotal.Name = "xrTotal"
        Me.xrTotal.StylePriority.UseTextAlignment = False
        Me.xrTotal.Text = "Total"
        Me.xrTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTotal.Weight = 0.329177573316009R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "Pos"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell10.Weight = 0.327486321376887R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "Grade"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell11.Weight = 1.00271139181988R
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1, Me.XrLabel14, Me.XrLabel15, Me.XrLine9, Me.XrLine10, Me.XrPanel2, Me.XrTable3})
        Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter1.HeightF = 405.9062!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry
        Me.GroupFooter1.StyleName = "baseControlStyle"
        '
        'XrPanel1
        '
        Me.XrPanel1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrPanel1.CanGrow = False
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.XrLine4, Me.XrLine5, Me.XrLine7, Me.XrLine6, Me.XrLabel13})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(5.979919!, 188.8229!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(729.7052!, 144.1461!)
        '
        'XrLabel12
        '
        Me.XrLabel12.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLabel12.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrLabel12.CanGrow = False
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 16.7813!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(146.5837!, 26.04167!)
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Teacher's Remarks:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine4
        '
        Me.XrLine4.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLine4.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(162.559!, 40.82298!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(563.4611!, 2.0!)
        '
        'XrLine5
        '
        Me.XrLine5.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLine5.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(22.54895!, 69.90622!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(704.2169!, 2.0!)
        '
        'XrLine7
        '
        Me.XrLine7.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLine7.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrLine7.LocationFloat = New DevExpress.Utils.PointFloat(22.54895!, 127.0521!)
        Me.XrLine7.Name = "XrLine7"
        Me.XrLine7.SizeF = New System.Drawing.SizeF(696.0201!, 2.0!)
        '
        'XrLine6
        '
        Me.XrLine6.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLine6.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrLine6.LocationFloat = New DevExpress.Utils.PointFloat(180.4287!, 104.1564!)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.SizeF = New System.Drawing.SizeF(546.3371!, 2.0!)
        '
        'XrLabel13
        '
        Me.XrLabel13.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLabel13.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrLabel13.CanGrow = False
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(0.960032!, 83.32306!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(164.0974!, 22.83331!)
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Principal's Remarks:"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLabel14.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrLabel14.CanGrow = False
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(20.25605!, 375.5939!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(214.5034!, 19.18765!)
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Form Teacher's Signature:"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLabel15.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrLabel15.CanGrow = False
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(489.8289!, 379.8645!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(214.5034!, 16.04169!)
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Principal's Signature:"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine9
        '
        Me.XrLine9.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLine9.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrLine9.LocationFloat = New DevExpress.Utils.PointFloat(16.49194!, 362.1356!)
        Me.XrLine9.Name = "XrLine9"
        Me.XrLine9.SizeF = New System.Drawing.SizeF(218.2675!, 13.45831!)
        '
        'XrLine10
        '
        Me.XrLine10.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLine10.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrLine10.LocationFloat = New DevExpress.Utils.PointFloat(486.0648!, 362.1356!)
        Me.XrLine10.Name = "XrLine10"
        Me.XrLine10.SizeF = New System.Drawing.SizeF(218.2675!, 13.45831!)
        '
        'XrPanel2
        '
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.totalTable, Me.XrTable4, Me.XrTable5})
        Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(16.49194!, 25.0!)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrPanel2.SizeF = New System.Drawing.SizeF(706.1731!, 163.8229!)
        Me.XrPanel2.StylePriority.UsePadding = False
        '
        'totalTable
        '
        Me.totalTable.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
        Me.totalTable.BorderColor = System.Drawing.Color.Black
        Me.totalTable.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.totalTable.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalTable.ForeColor = System.Drawing.Color.Black
        Me.totalTable.LocationFloat = New DevExpress.Utils.PointFloat(9.607403!, 13.82291!)
        Me.totalTable.Name = "totalTable"
        Me.totalTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.totalTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6, Me.XrTableRow1, Me.totalRow, Me.XrTableRow2})
        Me.totalTable.SizeF = New System.Drawing.SizeF(211.4585!, 140.0!)
        Me.totalTable.StylePriority.UseBorderColor = False
        Me.totalTable.StylePriority.UseBorders = False
        Me.totalTable.StylePriority.UseFont = False
        Me.totalTable.StylePriority.UseForeColor = False
        Me.totalTable.StylePriority.UsePadding = False
        Me.totalTable.StylePriority.UseTextAlignment = False
        Me.totalTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow6
        '
        Me.XrTableRow6.BackColor = System.Drawing.Color.Black
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell15, Me.XrTableCell16})
        Me.XrTableRow6.ForeColor = System.Drawing.Color.White
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.StylePriority.UseBackColor = False
        Me.XrTableRow6.StylePriority.UseForeColor = False
        Me.XrTableRow6.Weight = 1.52173913043478R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell15.BorderWidth = 0.5!
        Me.XrTableCell15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseBorders = False
        Me.XrTableCell15.StylePriority.UseBorderWidth = False
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.Text = "Summary"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell15.Weight = 4.60660096596033R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell16.BorderWidth = 0.5!
        Me.XrTableCell16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseBorders = False
        Me.XrTableCell16.StylePriority.UseBorderWidth = False
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell16.Weight = 4.25422262325027R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell67})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.52173913043478R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.BorderWidth = 0.5!
        Me.XrTableCell1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBorderColor = False
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UseBorderWidth = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "Total Score"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell1.Weight = 4.60660178684206R
        '
        'XrTableCell67
        '
        Me.XrTableCell67.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell67.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell67.BorderWidth = 0.5!
        Me.XrTableCell67.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([totalScore])")})
        Me.XrTableCell67.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell67.Name = "XrTableCell67"
        Me.XrTableCell67.StylePriority.UseBorderColor = False
        Me.XrTableCell67.StylePriority.UseBorders = False
        Me.XrTableCell67.StylePriority.UseBorderWidth = False
        Me.XrTableCell67.StylePriority.UseFont = False
        Me.XrTableCell67.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell67.Summary = XrSummary1
        Me.XrTableCell67.Text = "XrTableCell67"
        Me.XrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell67.Weight = 4.25422180236855R
        '
        'totalRow
        '
        Me.totalRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.totalRow.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.totalRow.BorderWidth = 3.0!
        Me.totalRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.totalCaption, Me.total})
        Me.totalRow.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.totalRow.Name = "totalRow"
        Me.totalRow.StylePriority.UseBorderColor = False
        Me.totalRow.StylePriority.UseBorders = False
        Me.totalRow.StylePriority.UseBorderWidth = False
        Me.totalRow.StylePriority.UseFont = False
        Me.totalRow.Weight = 1.52173913043478R
        '
        'totalCaption
        '
        Me.totalCaption.BorderColor = System.Drawing.Color.Black
        Me.totalCaption.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.totalCaption.BorderWidth = 0.5!
        Me.totalCaption.CanGrow = False
        Me.totalCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCaption.Name = "totalCaption"
        Me.totalCaption.StylePriority.UseBorderColor = False
        Me.totalCaption.StylePriority.UseBorders = False
        Me.totalCaption.StylePriority.UseBorderWidth = False
        Me.totalCaption.StylePriority.UseFont = False
        Me.totalCaption.StylePriority.UseTextAlignment = False
        Me.totalCaption.Text = "Average Score"
        Me.totalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.totalCaption.Weight = 4.60660178684206R
        '
        'total
        '
        Me.total.BorderColor = System.Drawing.Color.Black
        Me.total.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.total.BorderWidth = 0.5!
        Me.total.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([totalscore])")})
        Me.total.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Name = "total"
        Me.total.StylePriority.UseBorderColor = False
        Me.total.StylePriority.UseBorders = False
        Me.total.StylePriority.UseBorderWidth = False
        Me.total.StylePriority.UseFont = False
        Me.total.StylePriority.UseTextAlignment = False
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.total.Summary = XrSummary2
        Me.total.Text = "1000"
        Me.total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.total.TextFormatString = "{0:#,#}"
        Me.total.Weight = 4.25422180236855R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.XrGroundTotal})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.52173913043478R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.BorderWidth = 0.5!
        Me.XrTableCell3.CanGrow = False
        Me.XrTableCell3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell3.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBorderColor = False
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.StylePriority.UseBorderWidth = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseForeColor = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Overall Grade"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell3.Weight = 4.60660073466426R
        '
        'XrGroundTotal
        '
        Me.XrGroundTotal.BorderColor = System.Drawing.Color.Black
        Me.XrGroundTotal.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrGroundTotal.BorderWidth = 0.5!
        Me.XrGroundTotal.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", resources.GetString("XrGroundTotal.ExpressionBindings"))})
        Me.XrGroundTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrGroundTotal.ForeColor = System.Drawing.Color.Maroon
        Me.XrGroundTotal.Name = "XrGroundTotal"
        Me.XrGroundTotal.StylePriority.UseBorderColor = False
        Me.XrGroundTotal.StylePriority.UseBorders = False
        Me.XrGroundTotal.StylePriority.UseBorderWidth = False
        Me.XrGroundTotal.StylePriority.UseFont = False
        Me.XrGroundTotal.StylePriority.UseForeColor = False
        Me.XrGroundTotal.StylePriority.UseTextAlignment = False
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrGroundTotal.Summary = XrSummary3
        Me.XrGroundTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrGroundTotal.TextFormatString = "{0:c0}"
        Me.XrGroundTotal.Weight = 4.25422285454635R
        '
        'XrTable4
        '
        Me.XrTable4.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
        Me.XrTable4.BorderColor = System.Drawing.Color.Black
        Me.XrTable4.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTable4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTable4.ForeColor = System.Drawing.Color.Black
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(237.1654!, 13.82291!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7, Me.XrTableRow8, Me.XrTableRow9, Me.XrTableRow10})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(212.3896!, 140.0!)
        Me.XrTable4.StylePriority.UseBorderColor = False
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        Me.XrTable4.StylePriority.UseForeColor = False
        Me.XrTable4.StylePriority.UsePadding = False
        Me.XrTable4.StylePriority.UseTextAlignment = False
        Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow7
        '
        Me.XrTableRow7.BackColor = System.Drawing.Color.Black
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell17, Me.XrTableCell18})
        Me.XrTableRow7.ForeColor = System.Drawing.Color.White
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.StylePriority.UseBackColor = False
        Me.XrTableRow7.StylePriority.UseForeColor = False
        Me.XrTableRow7.Weight = 1.52173913043478R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell17.BorderWidth = 0.5!
        Me.XrTableCell17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseBorders = False
        Me.XrTableCell17.StylePriority.UseBorderWidth = False
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        Me.XrTableCell17.Text = "Attendance"
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell17.Weight = 4.60659905592459R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell18.BorderWidth = 0.5!
        Me.XrTableCell18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseBorders = False
        Me.XrTableCell18.StylePriority.UseBorderWidth = False
        Me.XrTableCell18.StylePriority.UseFont = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell18.Weight = 4.25422453328601R
        '
        'XrTableRow8
        '
        Me.XrTableRow8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.XrTableRow8.BorderWidth = 3.0!
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell19, Me.XrTableCell20})
        Me.XrTableRow8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.StylePriority.UseBorderColor = False
        Me.XrTableRow8.StylePriority.UseBorderWidth = False
        Me.XrTableRow8.StylePriority.UseFont = False
        Me.XrTableRow8.Weight = 1.52173913043478R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell19.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell19.BorderWidth = 0.5!
        Me.XrTableCell19.CanGrow = False
        Me.XrTableCell19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StylePriority.UseBorderColor = False
        Me.XrTableCell19.StylePriority.UseBorders = False
        Me.XrTableCell19.StylePriority.UseBorderWidth = False
        Me.XrTableCell19.StylePriority.UseFont = False
        Me.XrTableCell19.StylePriority.UseTextAlignment = False
        Me.XrTableCell19.Text = "Total Days"
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell19.Weight = 4.60660178684206R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell20.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell20.BorderWidth = 0.5!
        Me.XrTableCell20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseBorderColor = False
        Me.XrTableCell20.StylePriority.UseBorders = False
        Me.XrTableCell20.StylePriority.UseBorderWidth = False
        Me.XrTableCell20.StylePriority.UseFont = False
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        Me.XrTableCell20.Text = "130"
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell20.TextFormatString = "{0:₦0.00}"
        Me.XrTableCell20.Weight = 4.25422180236855R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell21, Me.XrTableCell22})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1.52173913043478R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell21.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell21.BorderWidth = 0.5!
        Me.XrTableCell21.CanGrow = False
        Me.XrTableCell21.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseBorderColor = False
        Me.XrTableCell21.StylePriority.UseBorders = False
        Me.XrTableCell21.StylePriority.UseBorderWidth = False
        Me.XrTableCell21.StylePriority.UseFont = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        Me.XrTableCell21.Text = "Attended"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell21.Weight = 4.60660073466426R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell22.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell22.BorderWidth = 0.5!
        Me.XrTableCell22.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseBorderColor = False
        Me.XrTableCell22.StylePriority.UseBorders = False
        Me.XrTableCell22.StylePriority.UseBorderWidth = False
        Me.XrTableCell22.StylePriority.UseFont = False
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        Me.XrTableCell22.Text = " "
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell22.Weight = 4.25422285454635R
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell23, Me.XrTableCell24})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 1.52173913043478R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell23.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell23.BorderWidth = 0.5!
        Me.XrTableCell23.CanGrow = False
        Me.XrTableCell23.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell23.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.StylePriority.UseBorderColor = False
        Me.XrTableCell23.StylePriority.UseBorders = False
        Me.XrTableCell23.StylePriority.UseBorderWidth = False
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.StylePriority.UseForeColor = False
        Me.XrTableCell23.StylePriority.UseTextAlignment = False
        Me.XrTableCell23.Text = "Absent"
        Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell23.Weight = 4.60660073466426R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell24.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell24.BorderWidth = 0.5!
        Me.XrTableCell24.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell24.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseBorderColor = False
        Me.XrTableCell24.StylePriority.UseBorders = False
        Me.XrTableCell24.StylePriority.UseBorderWidth = False
        Me.XrTableCell24.StylePriority.UseFont = False
        Me.XrTableCell24.StylePriority.UseForeColor = False
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        Me.XrTableCell24.Text = " "
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell24.TextFormatString = "{0:c0}"
        Me.XrTableCell24.Weight = 4.25422285454635R
        '
        'XrTable5
        '
        Me.XrTable5.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right
        Me.XrTable5.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrTable5.BorderColor = System.Drawing.Color.Black
        Me.XrTable5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTable5.ForeColor = System.Drawing.Color.Black
        Me.XrTable5.KeepTogether = True
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(469.6582!, 13.82291!)
        Me.XrTable5.LockedInUserDesigner = True
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow11, Me.XrTableRow12, Me.XrTableRow13, Me.XrTableRow14, Me.XrTableRow15, Me.XrTableRow16, Me.XrTableRow17})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(228.7353!, 140.0!)
        Me.XrTable5.StylePriority.UseBorderColor = False
        Me.XrTable5.StylePriority.UseBorders = False
        Me.XrTable5.StylePriority.UseFont = False
        Me.XrTable5.StylePriority.UseForeColor = False
        Me.XrTable5.StylePriority.UsePadding = False
        Me.XrTable5.StylePriority.UseTextAlignment = False
        Me.XrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow11
        '
        Me.XrTableRow11.BackColor = System.Drawing.Color.Black
        Me.XrTableRow11.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow11.BorderWidth = 0.5!
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell25, Me.XrTableCell26, Me.XrTableCell33, Me.XrTableCell37, Me.XrTableCell41, Me.XrTableCell45})
        Me.XrTableRow11.ForeColor = System.Drawing.Color.White
        Me.XrTableRow11.LockedInUserDesigner = True
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.StylePriority.UseBackColor = False
        Me.XrTableRow11.StylePriority.UseBorders = False
        Me.XrTableRow11.StylePriority.UseBorderWidth = False
        Me.XrTableRow11.StylePriority.UseForeColor = False
        Me.XrTableRow11.StylePriority.UseTextAlignment = False
        Me.XrTableRow11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableRow11.Weight = 1.52173913043478R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.CanGrow = False
        Me.XrTableCell25.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell25.LockedInUserDesigner = True
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseFont = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        Me.XrTableCell25.Text = "Behaviour & Activities"
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell25.Weight = 4.6066020374158R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell26.BorderWidth = 0.5!
        Me.XrTableCell26.CanGrow = False
        Me.XrTableCell26.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell26.LockedInUserDesigner = True
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.StylePriority.UseBorders = False
        Me.XrTableCell26.StylePriority.UseBorderWidth = False
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.StylePriority.UseTextAlignment = False
        Me.XrTableCell26.Text = "A"
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell26.Weight = 0.709892116110565R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell33.BorderWidth = 0.5!
        Me.XrTableCell33.CanGrow = False
        Me.XrTableCell33.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell33.LockedInUserDesigner = True
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.StylePriority.UseBorders = False
        Me.XrTableCell33.StylePriority.UseBorderWidth = False
        Me.XrTableCell33.StylePriority.UseFont = False
        Me.XrTableCell33.StylePriority.UseTextAlignment = False
        Me.XrTableCell33.Text = "B"
        Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell33.Weight = 0.709892116110565R
        '
        'XrTableCell37
        '
        Me.XrTableCell37.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell37.BorderWidth = 0.5!
        Me.XrTableCell37.CanGrow = False
        Me.XrTableCell37.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell37.LockedInUserDesigner = True
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.StylePriority.UseBorders = False
        Me.XrTableCell37.StylePriority.UseBorderWidth = False
        Me.XrTableCell37.StylePriority.UseFont = False
        Me.XrTableCell37.StylePriority.UseTextAlignment = False
        Me.XrTableCell37.Text = "C"
        Me.XrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell37.Weight = 0.709892116110565R
        '
        'XrTableCell41
        '
        Me.XrTableCell41.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell41.BorderWidth = 0.5!
        Me.XrTableCell41.CanGrow = False
        Me.XrTableCell41.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell41.LockedInUserDesigner = True
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.StylePriority.UseBorders = False
        Me.XrTableCell41.StylePriority.UseBorderWidth = False
        Me.XrTableCell41.StylePriority.UseFont = False
        Me.XrTableCell41.StylePriority.UseTextAlignment = False
        Me.XrTableCell41.Text = "D"
        Me.XrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell41.Weight = 0.709892116110565R
        '
        'XrTableCell45
        '
        Me.XrTableCell45.CanGrow = False
        Me.XrTableCell45.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell45.LockedInUserDesigner = True
        Me.XrTableCell45.Name = "XrTableCell45"
        Me.XrTableCell45.StylePriority.UseFont = False
        Me.XrTableCell45.StylePriority.UseTextAlignment = False
        Me.XrTableCell45.Text = "E"
        Me.XrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell45.Weight = 0.709892116110565R
        '
        'XrTableRow12
        '
        Me.XrTableRow12.BorderColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.XrTableRow12.BorderWidth = 3.0!
        Me.XrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell34, Me.XrTableCell38, Me.XrTableCell42, Me.XrTableCell46})
        Me.XrTableRow12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow12.LockedInUserDesigner = True
        Me.XrTableRow12.Name = "XrTableRow12"
        Me.XrTableRow12.StylePriority.UseBorderColor = False
        Me.XrTableRow12.StylePriority.UseBorderWidth = False
        Me.XrTableRow12.StylePriority.UseFont = False
        Me.XrTableRow12.Weight = 1.52173913043478R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell27.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell27.BorderWidth = 0.5!
        Me.XrTableCell27.CanGrow = False
        Me.XrTableCell27.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.XrTableCell27.LockedInUserDesigner = True
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.StylePriority.UseBorderColor = False
        Me.XrTableCell27.StylePriority.UseBorders = False
        Me.XrTableCell27.StylePriority.UseBorderWidth = False
        Me.XrTableCell27.StylePriority.UseFont = False
        Me.XrTableCell27.StylePriority.UseForeColor = False
        Me.XrTableCell27.StylePriority.UseTextAlignment = False
        Me.XrTableCell27.Text = "Punctuality"
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell27.Weight = 4.60660178684206R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell28.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell28.BorderWidth = 0.5!
        Me.XrTableCell28.CanGrow = False
        Me.XrTableCell28.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell28.LockedInUserDesigner = True
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseBorderColor = False
        Me.XrTableCell28.StylePriority.UseBorders = False
        Me.XrTableCell28.StylePriority.UseBorderWidth = False
        Me.XrTableCell28.StylePriority.UseFont = False
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        Me.XrTableCell28.Text = " "
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell28.TextFormatString = "{0}"
        Me.XrTableCell28.Weight = 0.709892366684303R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell34.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell34.BorderWidth = 0.5!
        Me.XrTableCell34.CanGrow = False
        Me.XrTableCell34.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell34.LockedInUserDesigner = True
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.StylePriority.UseBorderColor = False
        Me.XrTableCell34.StylePriority.UseBorders = False
        Me.XrTableCell34.StylePriority.UseBorderWidth = False
        Me.XrTableCell34.StylePriority.UseFont = False
        Me.XrTableCell34.StylePriority.UseTextAlignment = False
        Me.XrTableCell34.Text = " "
        Me.XrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell34.Weight = 0.709892366684303R
        '
        'XrTableCell38
        '
        Me.XrTableCell38.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell38.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell38.BorderWidth = 0.5!
        Me.XrTableCell38.CanGrow = False
        Me.XrTableCell38.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell38.LockedInUserDesigner = True
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.StylePriority.UseBorderColor = False
        Me.XrTableCell38.StylePriority.UseBorders = False
        Me.XrTableCell38.StylePriority.UseBorderWidth = False
        Me.XrTableCell38.StylePriority.UseFont = False
        Me.XrTableCell38.StylePriority.UseTextAlignment = False
        Me.XrTableCell38.Text = " "
        Me.XrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell38.Weight = 0.709892366684303R
        '
        'XrTableCell42
        '
        Me.XrTableCell42.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell42.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell42.BorderWidth = 0.5!
        Me.XrTableCell42.CanGrow = False
        Me.XrTableCell42.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell42.LockedInUserDesigner = True
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.StylePriority.UseBorderColor = False
        Me.XrTableCell42.StylePriority.UseBorders = False
        Me.XrTableCell42.StylePriority.UseBorderWidth = False
        Me.XrTableCell42.StylePriority.UseFont = False
        Me.XrTableCell42.StylePriority.UseTextAlignment = False
        Me.XrTableCell42.Text = " "
        Me.XrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell42.Weight = 0.709892366684303R
        '
        'XrTableCell46
        '
        Me.XrTableCell46.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell46.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell46.BorderWidth = 0.5!
        Me.XrTableCell46.CanGrow = False
        Me.XrTableCell46.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell46.LockedInUserDesigner = True
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.StylePriority.UseBorderColor = False
        Me.XrTableCell46.StylePriority.UseBorders = False
        Me.XrTableCell46.StylePriority.UseBorderWidth = False
        Me.XrTableCell46.StylePriority.UseFont = False
        Me.XrTableCell46.StylePriority.UseTextAlignment = False
        Me.XrTableCell46.Text = " "
        Me.XrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell46.Weight = 0.709892366684303R
        '
        'XrTableRow13
        '
        Me.XrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell29, Me.XrTableCell30, Me.XrTableCell35, Me.XrTableCell39, Me.XrTableCell43, Me.XrTableCell47})
        Me.XrTableRow13.LockedInUserDesigner = True
        Me.XrTableRow13.Name = "XrTableRow13"
        Me.XrTableRow13.Weight = 1.52173913043478R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell29.BorderWidth = 0.5!
        Me.XrTableCell29.CanGrow = False
        Me.XrTableCell29.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.XrTableCell29.LockedInUserDesigner = True
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.StylePriority.UseBorderColor = False
        Me.XrTableCell29.StylePriority.UseBorderWidth = False
        Me.XrTableCell29.StylePriority.UseFont = False
        Me.XrTableCell29.StylePriority.UseForeColor = False
        Me.XrTableCell29.StylePriority.UseTextAlignment = False
        Me.XrTableCell29.Text = "Attentiveness in class"
        Me.XrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell29.Weight = 4.60660073466426R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell30.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell30.BorderWidth = 0.5!
        Me.XrTableCell30.CanGrow = False
        Me.XrTableCell30.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell30.LockedInUserDesigner = True
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.StylePriority.UseBorderColor = False
        Me.XrTableCell30.StylePriority.UseBorders = False
        Me.XrTableCell30.StylePriority.UseBorderWidth = False
        Me.XrTableCell30.StylePriority.UseFont = False
        Me.XrTableCell30.StylePriority.UseTextAlignment = False
        Me.XrTableCell30.Text = " "
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell30.Weight = 0.709893418862106R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell35.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell35.BorderWidth = 0.5!
        Me.XrTableCell35.CanGrow = False
        Me.XrTableCell35.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell35.LockedInUserDesigner = True
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.StylePriority.UseBorderColor = False
        Me.XrTableCell35.StylePriority.UseBorders = False
        Me.XrTableCell35.StylePriority.UseBorderWidth = False
        Me.XrTableCell35.StylePriority.UseFont = False
        Me.XrTableCell35.StylePriority.UseTextAlignment = False
        Me.XrTableCell35.Text = " "
        Me.XrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell35.Weight = 0.709893418862106R
        '
        'XrTableCell39
        '
        Me.XrTableCell39.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell39.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell39.BorderWidth = 0.5!
        Me.XrTableCell39.CanGrow = False
        Me.XrTableCell39.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell39.LockedInUserDesigner = True
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.StylePriority.UseBorderColor = False
        Me.XrTableCell39.StylePriority.UseBorders = False
        Me.XrTableCell39.StylePriority.UseBorderWidth = False
        Me.XrTableCell39.StylePriority.UseFont = False
        Me.XrTableCell39.StylePriority.UseTextAlignment = False
        Me.XrTableCell39.Text = " "
        Me.XrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell39.Weight = 0.709893418862106R
        '
        'XrTableCell43
        '
        Me.XrTableCell43.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell43.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell43.BorderWidth = 0.5!
        Me.XrTableCell43.CanGrow = False
        Me.XrTableCell43.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell43.LockedInUserDesigner = True
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.StylePriority.UseBorderColor = False
        Me.XrTableCell43.StylePriority.UseBorders = False
        Me.XrTableCell43.StylePriority.UseBorderWidth = False
        Me.XrTableCell43.StylePriority.UseFont = False
        Me.XrTableCell43.StylePriority.UseTextAlignment = False
        Me.XrTableCell43.Text = " "
        Me.XrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell43.Weight = 0.709893418862106R
        '
        'XrTableCell47
        '
        Me.XrTableCell47.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell47.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell47.BorderWidth = 0.5!
        Me.XrTableCell47.CanGrow = False
        Me.XrTableCell47.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell47.LockedInUserDesigner = True
        Me.XrTableCell47.Name = "XrTableCell47"
        Me.XrTableCell47.StylePriority.UseBorderColor = False
        Me.XrTableCell47.StylePriority.UseBorders = False
        Me.XrTableCell47.StylePriority.UseBorderWidth = False
        Me.XrTableCell47.StylePriority.UseFont = False
        Me.XrTableCell47.StylePriority.UseTextAlignment = False
        Me.XrTableCell47.Text = " "
        Me.XrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell47.Weight = 0.709893418862106R
        '
        'XrTableRow14
        '
        Me.XrTableRow14.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow14.BorderWidth = 0.5!
        Me.XrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell31, Me.XrTableCell32, Me.XrTableCell36, Me.XrTableCell40, Me.XrTableCell44, Me.XrTableCell48})
        Me.XrTableRow14.LockedInUserDesigner = True
        Me.XrTableRow14.Name = "XrTableRow14"
        Me.XrTableRow14.StylePriority.UseBorders = False
        Me.XrTableRow14.StylePriority.UseBorderWidth = False
        Me.XrTableRow14.Weight = 1.52173913043478R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell31.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell31.CanGrow = False
        Me.XrTableCell31.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.XrTableCell31.LockedInUserDesigner = True
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.StylePriority.UseBorderColor = False
        Me.XrTableCell31.StylePriority.UseBorders = False
        Me.XrTableCell31.StylePriority.UseFont = False
        Me.XrTableCell31.StylePriority.UseForeColor = False
        Me.XrTableCell31.StylePriority.UseTextAlignment = False
        Me.XrTableCell31.Text = "Carrying out assignments"
        Me.XrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell31.Weight = 4.60660073466426R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell32.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell32.BorderWidth = 0.5!
        Me.XrTableCell32.CanGrow = False
        Me.XrTableCell32.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell32.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell32.LockedInUserDesigner = True
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.StylePriority.UseBorderColor = False
        Me.XrTableCell32.StylePriority.UseBorders = False
        Me.XrTableCell32.StylePriority.UseBorderWidth = False
        Me.XrTableCell32.StylePriority.UseFont = False
        Me.XrTableCell32.StylePriority.UseForeColor = False
        Me.XrTableCell32.StylePriority.UseTextAlignment = False
        Me.XrTableCell32.Text = " "
        Me.XrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell32.TextFormatString = "{0:c0}"
        Me.XrTableCell32.Weight = 0.709893418862106R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell36.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell36.BorderWidth = 0.5!
        Me.XrTableCell36.CanGrow = False
        Me.XrTableCell36.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell36.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell36.LockedInUserDesigner = True
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.StylePriority.UseBorderColor = False
        Me.XrTableCell36.StylePriority.UseBorders = False
        Me.XrTableCell36.StylePriority.UseBorderWidth = False
        Me.XrTableCell36.StylePriority.UseFont = False
        Me.XrTableCell36.StylePriority.UseForeColor = False
        Me.XrTableCell36.StylePriority.UseTextAlignment = False
        Me.XrTableCell36.Text = " "
        Me.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell36.Weight = 0.709893418862106R
        '
        'XrTableCell40
        '
        Me.XrTableCell40.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell40.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell40.BorderWidth = 0.5!
        Me.XrTableCell40.CanGrow = False
        Me.XrTableCell40.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell40.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell40.LockedInUserDesigner = True
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.StylePriority.UseBorderColor = False
        Me.XrTableCell40.StylePriority.UseBorders = False
        Me.XrTableCell40.StylePriority.UseBorderWidth = False
        Me.XrTableCell40.StylePriority.UseFont = False
        Me.XrTableCell40.StylePriority.UseForeColor = False
        Me.XrTableCell40.StylePriority.UseTextAlignment = False
        Me.XrTableCell40.Text = " "
        Me.XrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell40.Weight = 0.709893418862106R
        '
        'XrTableCell44
        '
        Me.XrTableCell44.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell44.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell44.BorderWidth = 0.5!
        Me.XrTableCell44.CanGrow = False
        Me.XrTableCell44.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell44.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell44.LockedInUserDesigner = True
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.StylePriority.UseBorderColor = False
        Me.XrTableCell44.StylePriority.UseBorders = False
        Me.XrTableCell44.StylePriority.UseBorderWidth = False
        Me.XrTableCell44.StylePriority.UseFont = False
        Me.XrTableCell44.StylePriority.UseForeColor = False
        Me.XrTableCell44.StylePriority.UseTextAlignment = False
        Me.XrTableCell44.Text = " "
        Me.XrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell44.Weight = 0.709893418862106R
        '
        'XrTableCell48
        '
        Me.XrTableCell48.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell48.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell48.CanGrow = False
        Me.XrTableCell48.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell48.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell48.LockedInUserDesigner = True
        Me.XrTableCell48.Name = "XrTableCell48"
        Me.XrTableCell48.StylePriority.UseBorderColor = False
        Me.XrTableCell48.StylePriority.UseBorders = False
        Me.XrTableCell48.StylePriority.UseFont = False
        Me.XrTableCell48.StylePriority.UseForeColor = False
        Me.XrTableCell48.StylePriority.UseTextAlignment = False
        Me.XrTableCell48.Text = " "
        Me.XrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell48.Weight = 0.709893418862106R
        '
        'XrTableRow15
        '
        Me.XrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell49, Me.XrTableCell50, Me.XrTableCell51, Me.XrTableCell52, Me.XrTableCell53, Me.XrTableCell54})
        Me.XrTableRow15.LockedInUserDesigner = True
        Me.XrTableRow15.Name = "XrTableRow15"
        Me.XrTableRow15.StylePriority.UseTextAlignment = False
        Me.XrTableRow15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableRow15.Weight = 1.52173913043478R
        '
        'XrTableCell49
        '
        Me.XrTableCell49.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell49.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell49.BorderWidth = 0.5!
        Me.XrTableCell49.CanGrow = False
        Me.XrTableCell49.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell49.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.XrTableCell49.LockedInUserDesigner = True
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.StylePriority.UseBorderColor = False
        Me.XrTableCell49.StylePriority.UseBorders = False
        Me.XrTableCell49.StylePriority.UseBorderWidth = False
        Me.XrTableCell49.StylePriority.UseFont = False
        Me.XrTableCell49.StylePriority.UseForeColor = False
        Me.XrTableCell49.StylePriority.UseTextAlignment = False
        Me.XrTableCell49.Text = "Neatness"
        Me.XrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell49.Weight = 4.60660073466426R
        '
        'XrTableCell50
        '
        Me.XrTableCell50.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell50.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell50.BorderWidth = 0.5!
        Me.XrTableCell50.CanGrow = False
        Me.XrTableCell50.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell50.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell50.LockedInUserDesigner = True
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.StylePriority.UseBorderColor = False
        Me.XrTableCell50.StylePriority.UseBorders = False
        Me.XrTableCell50.StylePriority.UseBorderWidth = False
        Me.XrTableCell50.StylePriority.UseFont = False
        Me.XrTableCell50.StylePriority.UseForeColor = False
        Me.XrTableCell50.StylePriority.UseTextAlignment = False
        Me.XrTableCell50.Text = " "
        Me.XrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell50.Weight = 0.709893418862106R
        '
        'XrTableCell51
        '
        Me.XrTableCell51.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell51.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell51.BorderWidth = 0.5!
        Me.XrTableCell51.CanGrow = False
        Me.XrTableCell51.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell51.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell51.LockedInUserDesigner = True
        Me.XrTableCell51.Name = "XrTableCell51"
        Me.XrTableCell51.StylePriority.UseBorderColor = False
        Me.XrTableCell51.StylePriority.UseBorders = False
        Me.XrTableCell51.StylePriority.UseBorderWidth = False
        Me.XrTableCell51.StylePriority.UseFont = False
        Me.XrTableCell51.StylePriority.UseForeColor = False
        Me.XrTableCell51.StylePriority.UseTextAlignment = False
        Me.XrTableCell51.Text = " "
        Me.XrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell51.Weight = 0.709893418862106R
        '
        'XrTableCell52
        '
        Me.XrTableCell52.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell52.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell52.BorderWidth = 0.5!
        Me.XrTableCell52.CanGrow = False
        Me.XrTableCell52.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell52.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell52.LockedInUserDesigner = True
        Me.XrTableCell52.Name = "XrTableCell52"
        Me.XrTableCell52.StylePriority.UseBorderColor = False
        Me.XrTableCell52.StylePriority.UseBorders = False
        Me.XrTableCell52.StylePriority.UseBorderWidth = False
        Me.XrTableCell52.StylePriority.UseFont = False
        Me.XrTableCell52.StylePriority.UseForeColor = False
        Me.XrTableCell52.StylePriority.UseTextAlignment = False
        Me.XrTableCell52.Text = " "
        Me.XrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell52.Weight = 0.709893418862106R
        '
        'XrTableCell53
        '
        Me.XrTableCell53.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell53.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell53.BorderWidth = 0.5!
        Me.XrTableCell53.CanGrow = False
        Me.XrTableCell53.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell53.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell53.LockedInUserDesigner = True
        Me.XrTableCell53.Name = "XrTableCell53"
        Me.XrTableCell53.StylePriority.UseBorderColor = False
        Me.XrTableCell53.StylePriority.UseBorders = False
        Me.XrTableCell53.StylePriority.UseBorderWidth = False
        Me.XrTableCell53.StylePriority.UseFont = False
        Me.XrTableCell53.StylePriority.UseForeColor = False
        Me.XrTableCell53.StylePriority.UseTextAlignment = False
        Me.XrTableCell53.Text = " "
        Me.XrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell53.Weight = 0.709893418862106R
        '
        'XrTableCell54
        '
        Me.XrTableCell54.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell54.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell54.BorderWidth = 0.5!
        Me.XrTableCell54.CanGrow = False
        Me.XrTableCell54.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell54.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell54.LockedInUserDesigner = True
        Me.XrTableCell54.Name = "XrTableCell54"
        Me.XrTableCell54.StylePriority.UseBorderColor = False
        Me.XrTableCell54.StylePriority.UseBorders = False
        Me.XrTableCell54.StylePriority.UseBorderWidth = False
        Me.XrTableCell54.StylePriority.UseFont = False
        Me.XrTableCell54.StylePriority.UseForeColor = False
        Me.XrTableCell54.StylePriority.UseTextAlignment = False
        Me.XrTableCell54.Text = " "
        Me.XrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        Me.XrTableCell54.Weight = 0.709893418862106R
        '
        'XrTableRow16
        '
        Me.XrTableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell55, Me.XrTableCell56, Me.XrTableCell57, Me.XrTableCell58, Me.XrTableCell59, Me.XrTableCell60})
        Me.XrTableRow16.LockedInUserDesigner = True
        Me.XrTableRow16.Name = "XrTableRow16"
        Me.XrTableRow16.Weight = 1.52173913043478R
        '
        'XrTableCell55
        '
        Me.XrTableCell55.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell55.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell55.BorderWidth = 0.5!
        Me.XrTableCell55.CanGrow = False
        Me.XrTableCell55.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell55.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.XrTableCell55.LockedInUserDesigner = True
        Me.XrTableCell55.Name = "XrTableCell55"
        Me.XrTableCell55.StylePriority.UseBorderColor = False
        Me.XrTableCell55.StylePriority.UseBorders = False
        Me.XrTableCell55.StylePriority.UseBorderWidth = False
        Me.XrTableCell55.StylePriority.UseFont = False
        Me.XrTableCell55.StylePriority.UseForeColor = False
        Me.XrTableCell55.StylePriority.UseTextAlignment = False
        Me.XrTableCell55.Text = "Honesty"
        Me.XrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell55.Weight = 4.60660073466426R
        '
        'XrTableCell56
        '
        Me.XrTableCell56.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell56.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell56.BorderWidth = 0.5!
        Me.XrTableCell56.CanGrow = False
        Me.XrTableCell56.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell56.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell56.LockedInUserDesigner = True
        Me.XrTableCell56.Name = "XrTableCell56"
        Me.XrTableCell56.StylePriority.UseBorderColor = False
        Me.XrTableCell56.StylePriority.UseBorders = False
        Me.XrTableCell56.StylePriority.UseBorderWidth = False
        Me.XrTableCell56.StylePriority.UseFont = False
        Me.XrTableCell56.StylePriority.UseForeColor = False
        Me.XrTableCell56.StylePriority.UseTextAlignment = False
        Me.XrTableCell56.Text = " "
        Me.XrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell56.Weight = 0.709893418862106R
        '
        'XrTableCell57
        '
        Me.XrTableCell57.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell57.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell57.BorderWidth = 0.5!
        Me.XrTableCell57.CanGrow = False
        Me.XrTableCell57.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell57.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell57.LockedInUserDesigner = True
        Me.XrTableCell57.Name = "XrTableCell57"
        Me.XrTableCell57.StylePriority.UseBorderColor = False
        Me.XrTableCell57.StylePriority.UseBorders = False
        Me.XrTableCell57.StylePriority.UseBorderWidth = False
        Me.XrTableCell57.StylePriority.UseFont = False
        Me.XrTableCell57.StylePriority.UseForeColor = False
        Me.XrTableCell57.StylePriority.UseTextAlignment = False
        Me.XrTableCell57.Text = " "
        Me.XrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell57.Weight = 0.709893418862106R
        '
        'XrTableCell58
        '
        Me.XrTableCell58.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell58.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell58.BorderWidth = 0.5!
        Me.XrTableCell58.CanGrow = False
        Me.XrTableCell58.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell58.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell58.LockedInUserDesigner = True
        Me.XrTableCell58.Name = "XrTableCell58"
        Me.XrTableCell58.StylePriority.UseBorderColor = False
        Me.XrTableCell58.StylePriority.UseBorders = False
        Me.XrTableCell58.StylePriority.UseBorderWidth = False
        Me.XrTableCell58.StylePriority.UseFont = False
        Me.XrTableCell58.StylePriority.UseForeColor = False
        Me.XrTableCell58.StylePriority.UseTextAlignment = False
        Me.XrTableCell58.Text = " "
        Me.XrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell58.Weight = 0.709893418862106R
        '
        'XrTableCell59
        '
        Me.XrTableCell59.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell59.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell59.BorderWidth = 0.5!
        Me.XrTableCell59.CanGrow = False
        Me.XrTableCell59.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell59.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell59.LockedInUserDesigner = True
        Me.XrTableCell59.Name = "XrTableCell59"
        Me.XrTableCell59.StylePriority.UseBorderColor = False
        Me.XrTableCell59.StylePriority.UseBorders = False
        Me.XrTableCell59.StylePriority.UseBorderWidth = False
        Me.XrTableCell59.StylePriority.UseFont = False
        Me.XrTableCell59.StylePriority.UseForeColor = False
        Me.XrTableCell59.StylePriority.UseTextAlignment = False
        Me.XrTableCell59.Text = " "
        Me.XrTableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell59.Weight = 0.709893418862106R
        '
        'XrTableCell60
        '
        Me.XrTableCell60.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell60.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell60.BorderWidth = 0.5!
        Me.XrTableCell60.CanGrow = False
        Me.XrTableCell60.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell60.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell60.LockedInUserDesigner = True
        Me.XrTableCell60.Name = "XrTableCell60"
        Me.XrTableCell60.StylePriority.UseBorderColor = False
        Me.XrTableCell60.StylePriority.UseBorders = False
        Me.XrTableCell60.StylePriority.UseBorderWidth = False
        Me.XrTableCell60.StylePriority.UseFont = False
        Me.XrTableCell60.StylePriority.UseForeColor = False
        Me.XrTableCell60.StylePriority.UseTextAlignment = False
        Me.XrTableCell60.Text = " "
        Me.XrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell60.Weight = 0.709893418862106R
        '
        'XrTableRow17
        '
        Me.XrTableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell61, Me.XrTableCell62, Me.XrTableCell63, Me.XrTableCell64, Me.XrTableCell65, Me.XrTableCell66})
        Me.XrTableRow17.LockedInUserDesigner = True
        Me.XrTableRow17.Name = "XrTableRow17"
        Me.XrTableRow17.Weight = 1.52173913043478R
        '
        'XrTableCell61
        '
        Me.XrTableCell61.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell61.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell61.BorderWidth = 0.5!
        Me.XrTableCell61.CanGrow = False
        Me.XrTableCell61.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell61.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.XrTableCell61.LockedInUserDesigner = True
        Me.XrTableCell61.Name = "XrTableCell61"
        Me.XrTableCell61.StylePriority.UseBorderColor = False
        Me.XrTableCell61.StylePriority.UseBorders = False
        Me.XrTableCell61.StylePriority.UseBorderWidth = False
        Me.XrTableCell61.StylePriority.UseFont = False
        Me.XrTableCell61.StylePriority.UseForeColor = False
        Me.XrTableCell61.StylePriority.UseTextAlignment = False
        Me.XrTableCell61.Text = "Self Control"
        Me.XrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell61.Weight = 4.60660073466426R
        '
        'XrTableCell62
        '
        Me.XrTableCell62.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell62.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell62.BorderWidth = 0.5!
        Me.XrTableCell62.CanGrow = False
        Me.XrTableCell62.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell62.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell62.LockedInUserDesigner = True
        Me.XrTableCell62.Name = "XrTableCell62"
        Me.XrTableCell62.StylePriority.UseBorderColor = False
        Me.XrTableCell62.StylePriority.UseBorders = False
        Me.XrTableCell62.StylePriority.UseBorderWidth = False
        Me.XrTableCell62.StylePriority.UseFont = False
        Me.XrTableCell62.StylePriority.UseForeColor = False
        Me.XrTableCell62.StylePriority.UseTextAlignment = False
        Me.XrTableCell62.Text = " "
        Me.XrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell62.Weight = 0.709893418862106R
        '
        'XrTableCell63
        '
        Me.XrTableCell63.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell63.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell63.BorderWidth = 0.5!
        Me.XrTableCell63.CanGrow = False
        Me.XrTableCell63.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell63.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell63.LockedInUserDesigner = True
        Me.XrTableCell63.Name = "XrTableCell63"
        Me.XrTableCell63.StylePriority.UseBorderColor = False
        Me.XrTableCell63.StylePriority.UseBorders = False
        Me.XrTableCell63.StylePriority.UseBorderWidth = False
        Me.XrTableCell63.StylePriority.UseFont = False
        Me.XrTableCell63.StylePriority.UseForeColor = False
        Me.XrTableCell63.StylePriority.UseTextAlignment = False
        Me.XrTableCell63.Text = " "
        Me.XrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell63.Weight = 0.709893418862106R
        '
        'XrTableCell64
        '
        Me.XrTableCell64.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell64.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell64.BorderWidth = 0.5!
        Me.XrTableCell64.CanGrow = False
        Me.XrTableCell64.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell64.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell64.LockedInUserDesigner = True
        Me.XrTableCell64.Name = "XrTableCell64"
        Me.XrTableCell64.StylePriority.UseBorderColor = False
        Me.XrTableCell64.StylePriority.UseBorders = False
        Me.XrTableCell64.StylePriority.UseBorderWidth = False
        Me.XrTableCell64.StylePriority.UseFont = False
        Me.XrTableCell64.StylePriority.UseForeColor = False
        Me.XrTableCell64.StylePriority.UseTextAlignment = False
        Me.XrTableCell64.Text = " "
        Me.XrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell64.Weight = 0.709893418862106R
        '
        'XrTableCell65
        '
        Me.XrTableCell65.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell65.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell65.BorderWidth = 0.5!
        Me.XrTableCell65.CanGrow = False
        Me.XrTableCell65.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell65.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell65.LockedInUserDesigner = True
        Me.XrTableCell65.Name = "XrTableCell65"
        Me.XrTableCell65.StylePriority.UseBorderColor = False
        Me.XrTableCell65.StylePriority.UseBorders = False
        Me.XrTableCell65.StylePriority.UseBorderWidth = False
        Me.XrTableCell65.StylePriority.UseFont = False
        Me.XrTableCell65.StylePriority.UseForeColor = False
        Me.XrTableCell65.StylePriority.UseTextAlignment = False
        Me.XrTableCell65.Text = " "
        Me.XrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell65.Weight = 0.709893418862106R
        '
        'XrTableCell66
        '
        Me.XrTableCell66.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell66.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell66.BorderWidth = 0.5!
        Me.XrTableCell66.CanGrow = False
        Me.XrTableCell66.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell66.ForeColor = System.Drawing.Color.Maroon
        Me.XrTableCell66.LockedInUserDesigner = True
        Me.XrTableCell66.Name = "XrTableCell66"
        Me.XrTableCell66.StylePriority.UseBorderColor = False
        Me.XrTableCell66.StylePriority.UseBorders = False
        Me.XrTableCell66.StylePriority.UseBorderWidth = False
        Me.XrTableCell66.StylePriority.UseFont = False
        Me.XrTableCell66.StylePriority.UseForeColor = False
        Me.XrTableCell66.StylePriority.UseTextAlignment = False
        Me.XrTableCell66.Text = " "
        Me.XrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell66.Weight = 0.709893418862106R
        '
        'XrTable3
        '
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(1.413425!, 0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(731.2516!, 25.0!)
        '
        'XrTableRow5
        '
        Me.XrTableRow5.BackColor = System.Drawing.Color.Silver
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell7, Me.XrTableCell14, Me.XrTableCell13})
        Me.XrTableRow5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableRow5.ForeColor = System.Drawing.Color.Black
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.StylePriority.UseBackColor = False
        Me.XrTableRow5.StylePriority.UseFont = False
        Me.XrTableRow5.StylePriority.UseForeColor = False
        Me.XrTableRow5.StylePriority.UseTextAlignment = False
        Me.XrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", " sumCount([subjectID])")})
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell2.Summary = XrSummary4
        Me.XrTableCell2.Text = "Total"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell2.TextFormatString = "No. of Subjects: {0}"
        Me.XrTableCell2.Weight = 1.17098403167711R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([ReportItems].[XrTableCell12].[Value])")})
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell7.Summary = XrSummary5
        Me.XrTableCell7.Text = "Total Marks Obtained"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell7.Weight = 1.20275651134688R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([LineTotalCalcField])")})
        Me.XrTableCell14.Name = "XrTableCell14"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell14.Summary = XrSummary6
        Me.XrTableCell14.Text = "XrTableCell14"
        Me.XrTableCell14.Weight = 0.23867742396149R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Text = " "
        Me.XrTableCell13.Weight = 0.977211532429586R
        '
        'baseControlStyle
        '
        Me.baseControlStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.baseControlStyle.Name = "baseControlStyle"
        Me.baseControlStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'LineTotalCalcField
        '
        Me.LineTotalCalcField.DataMember = "student_marks"
        Me.LineTotalCalcField.DisplayName = "LineTotal"
        Me.LineTotalCalcField.Expression = "[totalscore]"
        Me.LineTotalCalcField.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.LineTotalCalcField.Name = "LineTotalCalcField"
        '
        'GrandTotal
        '
        Me.GrandTotal.DataMember = "student_bill"
        Me.GrandTotal.Expression = "[amtdueMinusDiscount] - [percentageAmount]"
        Me.GrandTotal.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
        Me.GrandTotal.Name = "GrandTotal"
        '
        'percentageDiscount
        '
        Me.percentageDiscount.DataMember = "Query"
        Me.percentageDiscount.Expression = "ToFloat([totalDiscount] / 100)"
        Me.percentageDiscount.FieldType = DevExpress.XtraReports.UI.FieldType.Float
        Me.percentageDiscount.Name = "percentageDiscount"
        '
        'percentageAmount
        '
        Me.percentageAmount.DataMember = "student_bill"
        Me.percentageAmount.Expression = "[amtdueMinusDiscount] * [percentageDiscount]"
        Me.percentageAmount.FieldType = DevExpress.XtraReports.UI.FieldType.Float
        Me.percentageAmount.Name = "percentageAmount"
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Name = "XrControlStyle1"
        '
        'GradeFormattingRule5
        '
        Me.GradeFormattingRule5.DataMember = "student_marks"
        Me.GradeFormattingRule5.Formatting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GradeFormattingRule5.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.GradeFormattingRule5.Name = "GradeFormattingRule5"
        '
        'sessionIDParams
        '
        Me.sessionIDParams.Name = "sessionIDParams"
        DynamicListLookUpSettings1.DataMember = "ScoreReportQuery"
        DynamicListLookUpSettings1.DataSource = Me.SqlDataSource1
        DynamicListLookUpSettings1.DisplayMember = "sessionID"
        DynamicListLookUpSettings1.ValueMember = "sessionID"
        Me.sessionIDParams.ValueSourceSettings = DynamicListLookUpSettings1
        '
        'classIDParams
        '
        Me.classIDParams.Name = "classIDParams"
        DynamicListLookUpSettings2.DataMember = "ScoreReportQuery"
        DynamicListLookUpSettings2.DataSource = Me.SqlDataSource1
        DynamicListLookUpSettings2.DisplayMember = "classID"
        DynamicListLookUpSettings2.ValueMember = "classID"
        Me.classIDParams.ValueSourceSettings = DynamicListLookUpSettings2
        '
        'studentIDParams
        '
        Me.studentIDParams.Name = "studentIDParams"
        DynamicListLookUpSettings3.DataMember = "Query"
        DynamicListLookUpSettings3.DataSource = Me.SqlDataSource1
        DynamicListLookUpSettings3.DisplayMember = "stdID"
        DynamicListLookUpSettings3.ValueMember = "stdID"
        Me.studentIDParams.ValueSourceSettings = DynamicListLookUpSettings3
        '
        'scoresReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupFooter1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.LineTotalCalcField, Me.GrandTotal, Me.percentageDiscount, Me.percentageAmount})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "ScoreReportQuery"
        Me.DataSource = Me.SqlDataSource1
        Me.DrawWatermark = True
        Me.FilterString = "[sessionID] = ?sessionIDParams And [classID] = ?classIDParams"
        Me.Margins = New System.Drawing.Printing.Margins(42, 43, 11, 106)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.sessionIDParams, Me.classIDParams, Me.studentIDParams})
        Me.RequestParameters = False
        Me.ScriptsSource = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "private void CalculatedField1_GetValue(object sender, DevExpress.XtraReports.UI" &
    ".GetValueEventArgs e) {" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.baseControlStyle, Me.XrControlStyle1})
        Me.Version = "21.2"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorContactsTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.totalTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents vendorContactsTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents vendorContactsRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrsch_website As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrSch_email As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrSch_phone As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents baseControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents LineTotalCalcField As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents GrandTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents percentageDiscount As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents percentageAmount As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrNameOfSchool As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents yt_label As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tw_label As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fb_label As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrSchAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents totalTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents totalRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents totalCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents total As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrGroundTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow12 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow13 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow14 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow15 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell53 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell54 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow16 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell55 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell56 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell57 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell58 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell59 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell60 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLine8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTableRow17 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell61 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell62 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell63 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell64 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell65 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell66 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell67 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell69 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell70 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell71 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell72 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell68 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrAss1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrAss2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTest1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTest2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrExam As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine9 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine10 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FAssFormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents SAssFormattingRule2 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents FTestFormattingRule3 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents STestFormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents ExamFormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents TotalFormattingRule4 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents GradeFormattingRule5 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents sessionIDParams As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents classIDParams As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents studentIDParams As DevExpress.XtraReports.Parameters.Parameter
End Class
