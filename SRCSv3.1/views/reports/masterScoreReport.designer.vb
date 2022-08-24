<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class masterScoreReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(masterScoreReport))
        Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Dim PivotGridGroup2 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim DynamicListLookUpSettings2 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Me.fieldfirstAss = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldsecondAss = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldfirstCA = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldsecondCA = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldexam = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldtotalScore = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldsubjectName = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
        Me.pivotGridField1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldsurname = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldstdClass = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldschYear = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldschTerm = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.fieldgradeRemarks1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.yt_label = New DevExpress.XtraReports.UI.XRLabel()
        Me.tw_label = New DevExpress.XtraReports.UI.XRLabel()
        Me.fb_label = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrSchAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrNameOfSchool = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.baseControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.LineTotalCalcField = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GrandTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.percentageDiscount = New DevExpress.XtraReports.UI.CalculatedField()
        Me.percentageAmount = New DevExpress.XtraReports.UI.CalculatedField()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FormattingRule2 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.SessionIDParams = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ClassIDParams = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ScoreTableTableAdapter1 = New SRCSv3._1.dbDataSetTableAdapters.scoreTableTableAdapter()
        Me.DbDataSet1 = New SRCSv3._1.dbDataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'fieldfirstAss
        '
        Me.fieldfirstAss.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.fieldfirstAss.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldfirstAss.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldfirstAss.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldfirstAss.AreaIndex = 0
        Me.fieldfirstAss.Caption = "A1"
        Me.fieldfirstAss.FieldName = "firstAss"
        Me.fieldfirstAss.Name = "fieldfirstAss"
        Me.fieldfirstAss.Options.ShowGrandTotal = False
        Me.fieldfirstAss.Width = 20
        '
        'fieldsecondAss
        '
        Me.fieldsecondAss.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.fieldsecondAss.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldsecondAss.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldsecondAss.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldsecondAss.AreaIndex = 1
        Me.fieldsecondAss.Caption = "A2"
        Me.fieldsecondAss.FieldName = "secondAss"
        Me.fieldsecondAss.Name = "fieldsecondAss"
        Me.fieldsecondAss.Options.ShowGrandTotal = False
        Me.fieldsecondAss.Width = 20
        '
        'fieldfirstCA
        '
        Me.fieldfirstCA.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.fieldfirstCA.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldfirstCA.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldfirstCA.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldfirstCA.AreaIndex = 2
        Me.fieldfirstCA.Caption = "T1"
        Me.fieldfirstCA.FieldName = "firstCA"
        Me.fieldfirstCA.Name = "fieldfirstCA"
        Me.fieldfirstCA.Options.ShowGrandTotal = False
        Me.fieldfirstCA.Width = 22
        '
        'fieldsecondCA
        '
        Me.fieldsecondCA.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.fieldsecondCA.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldsecondCA.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldsecondCA.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldsecondCA.AreaIndex = 3
        Me.fieldsecondCA.Caption = "T2"
        Me.fieldsecondCA.FieldName = "secondCA"
        Me.fieldsecondCA.Name = "fieldsecondCA"
        Me.fieldsecondCA.Options.ShowGrandTotal = False
        Me.fieldsecondCA.Width = 20
        '
        'fieldexam
        '
        Me.fieldexam.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.fieldexam.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldexam.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldexam.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldexam.AreaIndex = 4
        Me.fieldexam.Caption = "Exm"
        Me.fieldexam.FieldName = "exam"
        Me.fieldexam.Name = "fieldexam"
        Me.fieldexam.Options.ShowGrandTotal = False
        Me.fieldexam.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldexam.Width = 24
        '
        'fieldtotalScore
        '
        Me.fieldtotalScore.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.fieldtotalScore.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldtotalScore.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldtotalScore.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldtotalScore.AreaIndex = 5
        Me.fieldtotalScore.Caption = "Tot"
        Me.fieldtotalScore.FieldName = "totalScore"
        Me.fieldtotalScore.Name = "fieldtotalScore"
        Me.fieldtotalScore.RunningTotal = True
        Me.fieldtotalScore.Width = 34
        '
        'fieldsubjectName
        '
        Me.fieldsubjectName.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldsubjectName.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldsubjectName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldsubjectName.AreaIndex = 0
        Me.fieldsubjectName.FieldName = "subjectName"
        Me.fieldsubjectName.Name = "fieldsubjectName"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "dbConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "ScoreQuery"
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPivotGrid1})
        Me.Detail.HeightF = 142.7083!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("surname", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.StyleName = "baseControlStyle"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPivotGrid1
        '
        Me.XrPivotGrid1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.XrPivotGrid1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.XrPivotGrid1.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGrid1.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.FieldHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrPivotGrid1.Appearance.FieldValue.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrPivotGrid1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.GrandTotalCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrPivotGrid1.Appearance.Lines.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.Appearance.TotalCell.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPivotGrid1.DataAdapter = Me.ScoreTableTableAdapter1
        Me.XrPivotGrid1.DataMember = "scoreTable"
        Me.XrPivotGrid1.DataSource = Me.DbDataSet1
        Me.XrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() {Me.pivotGridField1, Me.fieldsurname, Me.fieldstdClass, Me.fieldsubjectName, Me.fieldfirstCA, Me.fieldsecondCA, Me.fieldsecondAss, Me.fieldfirstAss, Me.fieldschYear, Me.fieldschTerm, Me.fieldexam, Me.fieldtotalScore, Me.fieldgradeRemarks1})
        PivotGridGroup1.Fields.Add(Me.fieldfirstAss)
        PivotGridGroup1.Fields.Add(Me.fieldsecondAss)
        PivotGridGroup1.Fields.Add(Me.fieldfirstCA)
        PivotGridGroup1.Fields.Add(Me.fieldsecondCA)
        PivotGridGroup1.Fields.Add(Me.fieldexam)
        PivotGridGroup1.Fields.Add(Me.fieldtotalScore)
        PivotGridGroup2.Fields.Add(Me.fieldsubjectName)
        Me.XrPivotGrid1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1, PivotGridGroup2})
        Me.XrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(1.413425!, 0!)
        Me.XrPivotGrid1.Name = "XrPivotGrid1"
        Me.XrPivotGrid1.OLAPConnectionString = ""
        Me.XrPivotGrid1.OLAPDataProvider = DevExpress.XtraPivotGrid.OLAPDataProvider.OleDb
        Me.XrPivotGrid1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrPivotGrid1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrPivotGrid1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.XrPivotGrid1.SizeF = New System.Drawing.SizeF(1201.587!, 142.7083!)
        '
        'pivotGridField1
        '
        Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pivotGridField1.AreaIndex = 1
        Me.pivotGridField1.Caption = "Other names"
        Me.pivotGridField1.FieldName = "otherNames"
        Me.pivotGridField1.Name = "pivotGridField1"
        '
        'fieldsurname
        '
        Me.fieldsurname.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.fieldsurname.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.fieldsurname.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldsurname.Appearance.Cell.WordWrap = True
        Me.fieldsurname.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsurname.AreaIndex = 0
        Me.fieldsurname.Caption = "Surname"
        Me.fieldsurname.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldsurname.FieldName = "surname"
        Me.fieldsurname.Name = "fieldsurname"
        Me.fieldsurname.Width = 135
        '
        'fieldstdClass
        '
        Me.fieldstdClass.AreaIndex = 2
        Me.fieldstdClass.FieldName = "stdClass"
        Me.fieldstdClass.Name = "fieldstdClass"
        '
        'fieldschYear
        '
        Me.fieldschYear.AreaIndex = 0
        Me.fieldschYear.FieldName = "schYear"
        Me.fieldschYear.Name = "fieldschYear"
        '
        'fieldschTerm
        '
        Me.fieldschTerm.AreaIndex = 1
        Me.fieldschTerm.FieldName = "schTerm"
        Me.fieldschTerm.Name = "fieldschTerm"
        Me.fieldschTerm.Options.ShowGrandTotal = False
        '
        'fieldgradeRemarks1
        '
        Me.fieldgradeRemarks1.AreaIndex = 3
        Me.fieldgradeRemarks1.FieldName = "gradeRemarks"
        Me.fieldgradeRemarks1.Name = "fieldgradeRemarks1"
        Me.fieldgradeRemarks1.Visible = False
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 10.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBackColor = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel16, Me.yt_label, Me.tw_label, Me.fb_label, Me.XrPictureBox4, Me.XrPictureBox3, Me.XrPictureBox2})
        Me.BottomMargin.HeightF = 139.7606!
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
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(900.8652!, 127.2606!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(312.1348!, 12.5!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = " Designed by Hadron softwares (08184054588)"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'yt_label
        '
        Me.yt_label.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yt_label.LocationFloat = New DevExpress.Utils.PointFloat(900.8652!, 10.00001!)
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
        Me.tw_label.LocationFloat = New DevExpress.Utils.PointFloat(351.9677!, 10.00001!)
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
        Me.fb_label.LocationFloat = New DevExpress.Utils.PointFloat(50.70636!, 10.00001!)
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
        Me.XrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(831.772!, 10.00001!)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.SizeF = New System.Drawing.SizeF(35.89783!, 23.0!)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox3.ImageSource"))
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(321.3916!, 10.00001!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(19.58412!, 23.0!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox2.ImageSource"))
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(22.2209!, 10.00001!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(19.58412!, 23.0!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSchAddress, Me.XrLabel2, Me.XrLabel11, Me.XrLabel1, Me.XrNameOfSchool, Me.XrLine2, Me.XrPictureBox1, Me.XrLabel5, Me.XrLabel6, Me.XrLabel7, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("classID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("sessionID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("subjectName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 130.2918!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.StyleName = "baseControlStyle"
        Me.GroupHeader1.StylePriority.UseBackColor = False
        '
        'XrSchAddress
        '
        Me.XrSchAddress.Font = New System.Drawing.Font("Calibri", 10.5!)
        Me.XrSchAddress.LocationFloat = New DevExpress.Utils.PointFloat(353.365!, 30.91666!)
        Me.XrSchAddress.Name = "XrSchAddress"
        Me.XrSchAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrSchAddress.SizeF = New System.Drawing.SizeF(407.2917!, 19.49997!)
        Me.XrSchAddress.StylePriority.UseFont = False
        Me.XrSchAddress.StylePriority.UseTextAlignment = False
        Me.XrSchAddress.Text = "XrNameOfSchool"
        Me.XrSchAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(862.177!, 103.1251!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(85.41672!, 23.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "3"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(677.8022!, 103.1251!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(176.1458!, 23.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "No. of Students in class:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(489.7531!, 50.41663!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(108.1249!, 23.91666!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Master List"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrNameOfSchool
        '
        Me.XrNameOfSchool.Font = New System.Drawing.Font("Calibri", 19.25!)
        Me.XrNameOfSchool.LocationFloat = New DevExpress.Utils.PointFloat(312.2574!, 6.875006!)
        Me.XrNameOfSchool.Name = "XrNameOfSchool"
        Me.XrNameOfSchool.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrNameOfSchool.SizeF = New System.Drawing.SizeF(490.625!, 24.04165!)
        Me.XrNameOfSchool.StylePriority.UseFont = False
        Me.XrNameOfSchool.StylePriority.UseTextAlignment = False
        Me.XrNameOfSchool.Text = "XrNameOfSchool"
        Me.XrNameOfSchool.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 6.0!
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 87.12495!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1203.0!, 6.25!)
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource(Global.SRCSv3._1.My.Resources.Resources.logoGlory, True)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(22.2209!, 5.83334!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(65.54565!, 68.49994!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(403.365!, 103.1251!)
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
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(470.7948!, 103.1251!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(162.5!, 23.0!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "XrLabel4"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(53.56903!, 103.1251!)
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
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(93.15237!, 103.1251!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(95.6558!, 23.0!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "XrLabel4"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(206.6942!, 103.1251!)
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
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(251.4858!, 103.1251!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(131.25!, 23.0!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "XrLabel4"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupFooter1
        '
        Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter1.HeightF = 3.822803!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry
        Me.GroupFooter1.StyleName = "baseControlStyle"
        '
        'baseControlStyle
        '
        Me.baseControlStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.baseControlStyle.Name = "baseControlStyle"
        Me.baseControlStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'LineTotalCalcField
        '
        Me.LineTotalCalcField.DataMember = "secondary_student_marks"
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
        Me.percentageDiscount.DataMember = "student_bill"
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
        'FormattingRule1
        '
        Me.FormattingRule1.DataMember = "student_marks"
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Name = "XrControlStyle1"
        '
        'FormattingRule2
        '
        Me.FormattingRule2.DataMember = "student_marks"
        Me.FormattingRule2.Name = "FormattingRule2"
        '
        'SessionIDParams
        '
        Me.SessionIDParams.Name = "SessionIDParams"
        DynamicListLookUpSettings1.DataMember = "ScoreQuery"
        DynamicListLookUpSettings1.DataSource = Me.SqlDataSource1
        DynamicListLookUpSettings1.DisplayMember = "sessionID"
        DynamicListLookUpSettings1.ValueMember = "sessionID"
        Me.SessionIDParams.ValueSourceSettings = DynamicListLookUpSettings1
        '
        'ClassIDParams
        '
        Me.ClassIDParams.Name = "ClassIDParams"
        DynamicListLookUpSettings2.DataMember = "ScoreQuery"
        DynamicListLookUpSettings2.DataSource = Me.SqlDataSource1
        DynamicListLookUpSettings2.DisplayMember = "classID"
        DynamicListLookUpSettings2.ValueMember = "classID"
        Me.ClassIDParams.ValueSourceSettings = DynamicListLookUpSettings2
        '
        'ScoreTableTableAdapter1
        '
        Me.ScoreTableTableAdapter1.ClearBeforeFill = True
        '
        'DbDataSet1
        '
        Me.DbDataSet1.DataSetName = "dbDataSet"
        Me.DbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "scoreTable"
        Me.BindingSource1.DataSource = Me.DbDataSet1
        '
        'masterScoreReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupFooter1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.LineTotalCalcField, Me.GrandTotal, Me.percentageDiscount, Me.percentageAmount})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1, Me.DbDataSet1, Me.BindingSource1})
        Me.DataMember = "ScoreQuery"
        Me.DataSource = Me.SqlDataSource1
        Me.DrawWatermark = True
        Me.FilterString = "[classID] = ?ClassIDParams And [sessionID] = ?SessionIDParams"
        Me.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(48, 38, 10, 140)
        Me.PageHeight = 827
        Me.PageWidth = 1299
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4Plus
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.SessionIDParams, Me.ClassIDParams})
        Me.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Inherit
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.baseControlStyle, Me.XrControlStyle1})
        Me.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Version = "21.2"
        CType(Me.DbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents baseControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents LineTotalCalcField As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents GrandTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents percentageDiscount As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents percentageAmount As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrNameOfSchool As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents yt_label As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tw_label As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fb_label As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrSchAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FormattingRule2 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
    Friend WithEvents fieldgradeRemarks1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    '   Friend WithEvents Result_db1DataSet1 As result_db1DataSet
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents pivotGridField1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldsurname As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldstdClass As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldsubjectName As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldfirstCA As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldsecondCA As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldsecondAss As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldfirstAss As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldschYear As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldschTerm As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldexam As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldtotalScore As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents SessionIDParams As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ClassIDParams As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ScoreTableTableAdapter1 As dbDataSetTableAdapters.scoreTableTableAdapter
    Friend WithEvents DbDataSet1 As dbDataSet
    Friend WithEvents BindingSource1 As BindingSource
    'Friend WithEvents Log_regiTableAdapter As result_db1DataSetTableAdapters.log_regiTableAdapter
    'Friend WithEvents Student_marksTableAdapter2 As result_db1DataSetTableAdapters.student_marksTableAdapter
End Class
