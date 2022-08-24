<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.detailTable = New DevExpress.XtraReports.UI.XRTable()
        Me.detailTableRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.productName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.quantity = New DevExpress.XtraReports.UI.XRTableCell()
        Me.unitPrice = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lineTotal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.vendorContactsTable = New DevExpress.XtraReports.UI.XRTable()
        Me.vendorContactsRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorWebsite = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorEmail = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorPhone = New DevExpress.XtraReports.UI.XRTableCell()
        Me.thankYouLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.heartLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.invoiceInfoTable = New DevExpress.XtraReports.UI.XRTable()
        Me.invoiceDateRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.invoiceDateCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceNumberRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.invoiceNumberCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceNumber = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerTable = New DevExpress.XtraReports.UI.XRTable()
        Me.customerNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorTable = New DevExpress.XtraReports.UI.XRTable()
        Me.vendorNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorAddressRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorAddress = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorCityRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorCity = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorCountryRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorCountry = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.invoiceLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.summariesTable = New DevExpress.XtraReports.UI.XRTable()
        Me.totalCaptionRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.invoiceDueDateCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.totalCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.totalRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.invoiceDueDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.total = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.subtotalTable = New DevExpress.XtraReports.UI.XRTable()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.headerTable = New DevExpress.XtraReports.UI.XRTable()
        Me.headerTableRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.productNameCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.quantityCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.unitPriceCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lineTotalCaptionCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.baseControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        CType(Me.detailTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorContactsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.invoiceInfoTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.summariesTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subtotalTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.detailTable})
        Me.Detail.HeightF = 35.0!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "baseControlStyle"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'detailTable
        '
        Me.detailTable.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.detailTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.detailTable.Name = "detailTable"
        Me.detailTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.detailTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.detailTableRow})
        Me.detailTable.SizeF = New System.Drawing.SizeF(650.0!, 35.0!)
        Me.detailTable.StylePriority.UseFont = False
        Me.detailTable.StylePriority.UsePadding = False
        '
        'detailTableRow
        '
        Me.detailTableRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.productName, Me.quantity, Me.unitPrice, Me.lineTotal})
        Me.detailTableRow.Name = "detailTableRow"
        Me.detailTableRow.Weight = 12.343333333333334R
        '
        'productName
        '
        Me.productName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[surname]")})
        Me.productName.Name = "productName"
        Me.productName.StylePriority.UsePadding = False
        Me.productName.Weight = 1.2791103986779131R
        '
        'quantity
        '
        Me.quantity.Name = "quantity"
        Me.quantity.StylePriority.UsePadding = False
        Me.quantity.StylePriority.UseTextAlignment = False
        Me.quantity.Text = "1"
        Me.quantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.quantity.Weight = 0.20794141038459232R
        '
        'unitPrice
        '
        Me.unitPrice.Name = "unitPrice"
        Me.unitPrice.StylePriority.UsePadding = False
        Me.unitPrice.StylePriority.UseTextAlignment = False
        Me.unitPrice.Text = "₦0.00"
        Me.unitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.unitPrice.TextFormatString = "{0:$0.00}"
        Me.unitPrice.Weight = 0.43550145953603214R
        '
        'lineTotal
        '
        Me.lineTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lineTotal.Name = "lineTotal"
        Me.lineTotal.StylePriority.UseFont = False
        Me.lineTotal.StylePriority.UseForeColor = False
        Me.lineTotal.StylePriority.UsePadding = False
        Me.lineTotal.StylePriority.UseTextAlignment = False
        Me.lineTotal.Text = "₦0.00"
        Me.lineTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.lineTotal.TextFormatString = "{0:$0.00}"
        Me.lineTotal.Weight = 0.54191906534549128R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 100.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBackColor = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.vendorContactsTable, Me.thankYouLabel, Me.heartLabel})
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'vendorContactsTable
        '
        Me.vendorContactsTable.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.vendorContactsTable.Font = New System.Drawing.Font("Segoe UI", 7.75!)
        Me.vendorContactsTable.LocationFloat = New DevExpress.Utils.PointFloat(271.0!, 25.0!)
        Me.vendorContactsTable.Name = "vendorContactsTable"
        Me.vendorContactsTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.vendorContactsRow})
        Me.vendorContactsTable.SizeF = New System.Drawing.SizeF(378.9991!, 15.0!)
        Me.vendorContactsTable.StylePriority.UseBorderColor = False
        Me.vendorContactsTable.StylePriority.UseFont = False
        '
        'vendorContactsRow
        '
        Me.vendorContactsRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorWebsite, Me.vendorEmail, Me.vendorPhone})
        Me.vendorContactsRow.Name = "vendorContactsRow"
        Me.vendorContactsRow.Weight = 1.0R
        '
        'vendorWebsite
        '
        Me.vendorWebsite.CanGrow = False
        Me.vendorWebsite.CanShrink = True
        Me.vendorWebsite.Name = "vendorWebsite"
        Me.vendorWebsite.StylePriority.UseTextAlignment = False
        Me.vendorWebsite.Text = "VendorWebsite"
        Me.vendorWebsite.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.vendorWebsite.Weight = 1.0R
        '
        'vendorEmail
        '
        Me.vendorEmail.CanGrow = False
        Me.vendorEmail.CanShrink = True
        Me.vendorEmail.Name = "vendorEmail"
        Me.vendorEmail.StylePriority.UseBorders = False
        Me.vendorEmail.StylePriority.UseTextAlignment = False
        Me.vendorEmail.Text = "VendorEmail"
        Me.vendorEmail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.vendorEmail.Weight = 1.0R
        '
        'vendorPhone
        '
        Me.vendorPhone.CanGrow = False
        Me.vendorPhone.CanShrink = True
        Me.vendorPhone.Name = "vendorPhone"
        Me.vendorPhone.StylePriority.UseBorders = False
        Me.vendorPhone.StylePriority.UseTextAlignment = False
        Me.vendorPhone.Text = "VendorPhone"
        Me.vendorPhone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.vendorPhone.Weight = 1.0R
        '
        'thankYouLabel
        '
        Me.thankYouLabel.CanGrow = False
        Me.thankYouLabel.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.thankYouLabel.LocationFloat = New DevExpress.Utils.PointFloat(39.5429!, 9.999974!)
        Me.thankYouLabel.Name = "thankYouLabel"
        Me.thankYouLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.thankYouLabel.SizeF = New System.Drawing.SizeF(110.4167!, 40.0!)
        Me.thankYouLabel.StylePriority.UseFont = False
        Me.thankYouLabel.StylePriority.UseTextAlignment = False
        Me.thankYouLabel.Text = "Thank you!"
        Me.thankYouLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'heartLabel
        '
        Me.heartLabel.CanGrow = False
        Me.heartLabel.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.heartLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.heartLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 9.999974!)
        Me.heartLabel.Name = "heartLabel"
        Me.heartLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.heartLabel.SizeF = New System.Drawing.SizeF(39.54286!, 40.0!)
        Me.heartLabel.StylePriority.UseFont = False
        Me.heartLabel.StylePriority.UseForeColor = False
        Me.heartLabel.StylePriority.UseTextAlignment = False
        Me.heartLabel.Text = "♥"
        Me.heartLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.invoiceInfoTable, Me.customerTable, Me.vendorTable, Me.vendorLogo, Me.invoiceLabel})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader2.HeightF = 230.0!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.StyleName = "baseControlStyle"
        Me.GroupHeader2.StylePriority.UseBackColor = False
        '
        'invoiceInfoTable
        '
        Me.invoiceInfoTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 129.1666!)
        Me.invoiceInfoTable.Name = "invoiceInfoTable"
        Me.invoiceInfoTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.invoiceDateRow, Me.invoiceNumberRow})
        Me.invoiceInfoTable.SizeF = New System.Drawing.SizeF(315.0421!, 50.0!)
        '
        'invoiceDateRow
        '
        Me.invoiceDateRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.invoiceDateCaption, Me.invoiceDate})
        Me.invoiceDateRow.Name = "invoiceDateRow"
        Me.invoiceDateRow.Weight = 1.0R
        '
        'invoiceDateCaption
        '
        Me.invoiceDateCaption.CanShrink = True
        Me.invoiceDateCaption.Name = "invoiceDateCaption"
        Me.invoiceDateCaption.StylePriority.UseFont = False
        Me.invoiceDateCaption.StylePriority.UsePadding = False
        Me.invoiceDateCaption.StylePriority.UseTextAlignment = False
        Me.invoiceDateCaption.Text = "Date Issued:"
        Me.invoiceDateCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.invoiceDateCaption.Weight = 0.49655929171275132R
        '
        'invoiceDate
        '
        Me.invoiceDate.CanShrink = True
        Me.invoiceDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.invoiceDate.Name = "invoiceDate"
        Me.invoiceDate.StylePriority.UseFont = False
        Me.invoiceDate.Text = "InvoiceDate"
        Me.invoiceDate.TextFormatString = "{0:d MMMM yyyy}"
        Me.invoiceDate.Weight = 1.3680312174875988R
        '
        'invoiceNumberRow
        '
        Me.invoiceNumberRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.invoiceNumberCaption, Me.invoiceNumber})
        Me.invoiceNumberRow.Name = "invoiceNumberRow"
        Me.invoiceNumberRow.Weight = 1.0R
        '
        'invoiceNumberCaption
        '
        Me.invoiceNumberCaption.CanShrink = True
        Me.invoiceNumberCaption.Name = "invoiceNumberCaption"
        Me.invoiceNumberCaption.StylePriority.UseFont = False
        Me.invoiceNumberCaption.StylePriority.UsePadding = False
        Me.invoiceNumberCaption.StylePriority.UseTextAlignment = False
        Me.invoiceNumberCaption.Text = "Invoice No:"
        Me.invoiceNumberCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.invoiceNumberCaption.Weight = 0.49655929171275132R
        '
        'invoiceNumber
        '
        Me.invoiceNumber.CanShrink = True
        Me.invoiceNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.invoiceNumber.Name = "invoiceNumber"
        Me.invoiceNumber.StylePriority.UseFont = False
        Me.invoiceNumber.Text = "000001"
        Me.invoiceNumber.Weight = 1.3680312174875988R
        '
        'customerTable
        '
        Me.customerTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 89.99999!)
        Me.customerTable.Name = "customerTable"
        Me.customerTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.customerNameRow})
        Me.customerTable.SizeF = New System.Drawing.SizeF(201.0514!, 25.0!)
        '
        'customerNameRow
        '
        Me.customerNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerName})
        Me.customerNameRow.Name = "customerNameRow"
        Me.customerNameRow.Weight = 1.0R
        '
        'customerName
        '
        Me.customerName.CanShrink = True
        Me.customerName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[subjectName]")})
        Me.customerName.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.customerName.Name = "customerName"
        Me.customerName.StylePriority.UseFont = False
        Me.customerName.StylePriority.UsePadding = False
        Me.customerName.Weight = 1.1915477284685581R
        '
        'vendorTable
        '
        Me.vendorTable.LocationFloat = New DevExpress.Utils.PointFloat(350.0!, 89.99999!)
        Me.vendorTable.Name = "vendorTable"
        Me.vendorTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.vendorNameRow, Me.vendorAddressRow, Me.vendorCityRow, Me.vendorCountryRow})
        Me.vendorTable.SizeF = New System.Drawing.SizeF(300.0!, 100.0!)
        Me.vendorTable.StylePriority.UseTextAlignment = False
        Me.vendorTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'vendorNameRow
        '
        Me.vendorNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorName})
        Me.vendorNameRow.Name = "vendorNameRow"
        Me.vendorNameRow.Weight = 1.0R
        '
        'vendorName
        '
        Me.vendorName.CanShrink = True
        Me.vendorName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[classID]")})
        Me.vendorName.Name = "vendorName"
        Me.vendorName.StylePriority.UseFont = False
        Me.vendorName.StylePriority.UsePadding = False
        Me.vendorName.Weight = 1.0R
        '
        'vendorAddressRow
        '
        Me.vendorAddressRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorAddress})
        Me.vendorAddressRow.Name = "vendorAddressRow"
        Me.vendorAddressRow.Weight = 1.0R
        '
        'vendorAddress
        '
        Me.vendorAddress.CanShrink = True
        Me.vendorAddress.Name = "vendorAddress"
        Me.vendorAddress.StylePriority.UseFont = False
        Me.vendorAddress.Text = "VendorAddress"
        Me.vendorAddress.Weight = 1.0R
        '
        'vendorCityRow
        '
        Me.vendorCityRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorCity})
        Me.vendorCityRow.Name = "vendorCityRow"
        Me.vendorCityRow.Weight = 1.0R
        '
        'vendorCity
        '
        Me.vendorCity.CanShrink = True
        Me.vendorCity.Name = "vendorCity"
        Me.vendorCity.StylePriority.UseFont = False
        Me.vendorCity.Text = "VendorCity"
        Me.vendorCity.Weight = 1.0R
        '
        'vendorCountryRow
        '
        Me.vendorCountryRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorCountry})
        Me.vendorCountryRow.Name = "vendorCountryRow"
        Me.vendorCountryRow.Weight = 1.0R
        '
        'vendorCountry
        '
        Me.vendorCountry.CanShrink = True
        Me.vendorCountry.Name = "vendorCountry"
        Me.vendorCountry.StylePriority.UseFont = False
        Me.vendorCountry.Text = "VendorCountry"
        Me.vendorCountry.Weight = 1.0R
        '
        'vendorLogo
        '
        Me.vendorLogo.Image = CType(resources.GetObject("vendorLogo.Image"), System.Drawing.Image)
        Me.vendorLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft
        Me.vendorLogo.LocationFloat = New DevExpress.Utils.PointFloat(499.9991!, 0!)
        Me.vendorLogo.Name = "vendorLogo"
        Me.vendorLogo.SizeF = New System.Drawing.SizeF(150.0!, 71.0!)
        Me.vendorLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.vendorLogo.StylePriority.UseBorders = False
        Me.vendorLogo.StylePriority.UsePadding = False
        '
        'invoiceLabel
        '
        Me.invoiceLabel.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoiceLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0004182782!, 9.999995!)
        Me.invoiceLabel.Name = "invoiceLabel"
        Me.invoiceLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.invoiceLabel.SizeF = New System.Drawing.SizeF(185.0!, 50.0!)
        Me.invoiceLabel.StylePriority.UseFont = False
        Me.invoiceLabel.Text = "INVOICE"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.summariesTable})
        Me.GroupFooter2.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter2.HeightF = 160.0!
        Me.GroupFooter2.KeepTogether = True
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry
        Me.GroupFooter2.PrintAtBottom = True
        Me.GroupFooter2.StyleName = "baseControlStyle"
        '
        'summariesTable
        '
        Me.summariesTable.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.summariesTable.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.summariesTable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.summariesTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 29.99999!)
        Me.summariesTable.Name = "summariesTable"
        Me.summariesTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.totalCaptionRow, Me.totalRow})
        Me.summariesTable.SizeF = New System.Drawing.SizeF(650.0001!, 115.0!)
        Me.summariesTable.StylePriority.UseBorderColor = False
        Me.summariesTable.StylePriority.UseBorders = False
        Me.summariesTable.StylePriority.UseForeColor = False
        '
        'totalCaptionRow
        '
        Me.totalCaptionRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.invoiceDueDateCaption, Me.totalCaption})
        Me.totalCaptionRow.Name = "totalCaptionRow"
        Me.totalCaptionRow.Weight = 1.0R
        '
        'invoiceDueDateCaption
        '
        Me.invoiceDueDateCaption.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.invoiceDueDateCaption.Name = "invoiceDueDateCaption"
        Me.invoiceDueDateCaption.StylePriority.UseFont = False
        Me.invoiceDueDateCaption.StylePriority.UseForeColor = False
        Me.invoiceDueDateCaption.StylePriority.UseTextAlignment = False
        Me.invoiceDueDateCaption.Text = "DUE BY"
        Me.invoiceDueDateCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.invoiceDueDateCaption.Weight = 1.4499949651285395R
        '
        'totalCaption
        '
        Me.totalCaption.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.totalCaption.Name = "totalCaption"
        Me.totalCaption.StylePriority.UseFont = False
        Me.totalCaption.StylePriority.UseForeColor = False
        Me.totalCaption.StylePriority.UseTextAlignment = False
        Me.totalCaption.Text = "TOTAL DUE"
        Me.totalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.totalCaption.TextFormatString = "{0:$0.00}"
        Me.totalCaption.Weight = 0.86395575723338147R
        '
        'totalRow
        '
        Me.totalRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.invoiceDueDate, Me.total})
        Me.totalRow.Name = "totalRow"
        Me.totalRow.Weight = 3.6000000584920282R
        '
        'invoiceDueDate
        '
        Me.invoiceDueDate.Font = New System.Drawing.Font("Segoe UI", 26.0!)
        Me.invoiceDueDate.ForeColor = System.Drawing.Color.Black
        Me.invoiceDueDate.Name = "invoiceDueDate"
        Me.invoiceDueDate.StylePriority.UseFont = False
        Me.invoiceDueDate.StylePriority.UseForeColor = False
        Me.invoiceDueDate.StylePriority.UseTextAlignment = False
        Me.invoiceDueDate.Text = "InvoiceDueDate"
        Me.invoiceDueDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.invoiceDueDate.TextFormatString = "{0:d MMMM, yyyy}"
        Me.invoiceDueDate.Weight = 1.4499949651285395R
        '
        'total
        '
        Me.total.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
        Me.total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.total.Name = "total"
        Me.total.StylePriority.UseFont = False
        Me.total.StylePriority.UseForeColor = False
        Me.total.StylePriority.UseTextAlignment = False
        Me.total.Text = "₦0.00"
        Me.total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.total.TextFormatString = "{0:$0.00}"
        Me.total.Weight = 0.86395575723338147R
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.subtotalTable})
        Me.GroupFooter1.HeightF = 12.00001!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.StyleName = "baseControlStyle"
        '
        'subtotalTable
        '
        Me.subtotalTable.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.subtotalTable.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.subtotalTable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.subtotalTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.subtotalTable.Name = "subtotalTable"
        Me.subtotalTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.subtotalTable.SizeF = New System.Drawing.SizeF(650.0!, 2.0!)
        Me.subtotalTable.StylePriority.UseBorderColor = False
        Me.subtotalTable.StylePriority.UseFont = False
        Me.subtotalTable.StylePriority.UseForeColor = False
        Me.subtotalTable.StylePriority.UsePadding = False
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.headerTable})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("stdID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 50.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        Me.GroupHeader1.StyleName = "baseControlStyle"
        '
        'headerTable
        '
        Me.headerTable.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.headerTable.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.headerTable.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.headerTable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.headerTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.headerTable.Name = "headerTable"
        Me.headerTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.headerTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.headerTableRow})
        Me.headerTable.SizeF = New System.Drawing.SizeF(650.0!, 32.0!)
        Me.headerTable.StylePriority.UseBorderColor = False
        Me.headerTable.StylePriority.UseBorders = False
        Me.headerTable.StylePriority.UseFont = False
        Me.headerTable.StylePriority.UseForeColor = False
        Me.headerTable.StylePriority.UsePadding = False
        '
        'headerTableRow
        '
        Me.headerTableRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.productNameCaption, Me.quantityCaption, Me.unitPriceCaption, Me.lineTotalCaptionCell})
        Me.headerTableRow.Name = "headerTableRow"
        Me.headerTableRow.Weight = 11.5R
        '
        'productNameCaption
        '
        Me.productNameCaption.Name = "productNameCaption"
        Me.productNameCaption.StylePriority.UsePadding = False
        Me.productNameCaption.Text = "DESCRIPTION"
        Me.productNameCaption.Weight = 1.2611252269900464R
        '
        'quantityCaption
        '
        Me.quantityCaption.Name = "quantityCaption"
        Me.quantityCaption.StylePriority.UseTextAlignment = False
        Me.quantityCaption.Text = "QTY"
        Me.quantityCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.quantityCaption.Weight = 0.20495475959705467R
        '
        'unitPriceCaption
        '
        Me.unitPriceCaption.Name = "unitPriceCaption"
        Me.unitPriceCaption.StylePriority.UseTextAlignment = False
        Me.unitPriceCaption.Text = "PRICE"
        Me.unitPriceCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.unitPriceCaption.Weight = 0.429381446953317R
        '
        'lineTotalCaptionCell
        '
        Me.lineTotalCaptionCell.Name = "lineTotalCaptionCell"
        Me.lineTotalCaptionCell.StylePriority.UseTextAlignment = False
        Me.lineTotalCaptionCell.Text = "TOTAL"
        Me.lineTotalCaptionCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.lineTotalCaptionCell.Weight = 0.53455211842257433R
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "dbConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "scoreTable"
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'baseControlStyle
        '
        Me.baseControlStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.baseControlStyle.Name = "baseControlStyle"
        Me.baseControlStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader2, Me.GroupFooter2, Me.GroupFooter1, Me.GroupHeader1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "scoreTable"
        Me.DataSource = Me.SqlDataSource1
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.baseControlStyle})
        Me.Version = "17.2"
        CType(Me.detailTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorContactsTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.invoiceInfoTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.summariesTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subtotalTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headerTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents detailTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailTableRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents productName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents quantity As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents unitPrice As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lineTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents vendorContactsTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents vendorContactsRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorWebsite As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorEmail As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorPhone As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents thankYouLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents heartLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents invoiceInfoTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents invoiceDateRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents invoiceDateCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceNumberRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents invoiceNumberCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceNumber As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents customerNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents vendorNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorAddressRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorAddress As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorCityRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorCity As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorCountryRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorCountry As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents invoiceLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents summariesTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents totalCaptionRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents invoiceDueDateCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents totalCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents totalRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents invoiceDueDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents total As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents subtotalTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents headerTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents headerTableRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents productNameCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents quantityCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents unitPriceCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lineTotalCaptionCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents baseControlStyle As DevExpress.XtraReports.UI.XRControlStyle
End Class
