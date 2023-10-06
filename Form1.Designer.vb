<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtGeneralNumber = New TextBox()
        Label2 = New Label()
        txtFixedNumber = New TextBox()
        Label3 = New Label()
        txtStandardNumber = New TextBox()
        Label4 = New Label()
        txtCurrency = New TextBox()
        Label5 = New Label()
        txtPercentage = New TextBox()
        btnFormat = New Button()
        btnClose = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(173, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 20)
        Label1.TabIndex = 0
        Label1.Text = "General Number"
        ' 
        ' txtGeneralNumber
        ' 
        txtGeneralNumber.Location = New Point(446, 98)
        txtGeneralNumber.Name = "txtGeneralNumber"
        txtGeneralNumber.Size = New Size(125, 27)
        txtGeneralNumber.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(173, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 0
        Label2.Text = "Fixed Number"
        ' 
        ' txtFixedNumber
        ' 
        txtFixedNumber.Location = New Point(446, 146)
        txtFixedNumber.Name = "txtFixedNumber"
        txtFixedNumber.Size = New Size(125, 27)
        txtFixedNumber.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(173, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 20)
        Label3.TabIndex = 0
        Label3.Text = "Standard Number"
        ' 
        ' txtStandardNumber
        ' 
        txtStandardNumber.Location = New Point(446, 198)
        txtStandardNumber.Name = "txtStandardNumber"
        txtStandardNumber.Size = New Size(125, 27)
        txtStandardNumber.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(173, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 0
        Label4.Text = "Currency"
        ' 
        ' txtCurrency
        ' 
        txtCurrency.Location = New Point(446, 251)
        txtCurrency.Name = "txtCurrency"
        txtCurrency.Size = New Size(125, 27)
        txtCurrency.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(173, 308)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 20)
        Label5.TabIndex = 0
        Label5.Text = "Percentage"
        ' 
        ' txtPercentage
        ' 
        txtPercentage.Location = New Point(446, 301)
        txtPercentage.Name = "txtPercentage"
        txtPercentage.Size = New Size(125, 27)
        txtPercentage.TabIndex = 1
        ' 
        ' btnFormat
        ' 
        btnFormat.Location = New Point(260, 389)
        btnFormat.Name = "btnFormat"
        btnFormat.Size = New Size(94, 29)
        btnFormat.TabIndex = 2
        btnFormat.Text = "Format"
        btnFormat.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(410, 389)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Snap ITC", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.HotTrack
        Label6.Location = New Point(50, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(701, 36)
        Label6.TabIndex = 0
        Label6.Text = "Click Format to see the formats of each"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnFormat)
        Controls.Add(txtPercentage)
        Controls.Add(Label5)
        Controls.Add(txtCurrency)
        Controls.Add(Label4)
        Controls.Add(txtStandardNumber)
        Controls.Add(Label3)
        Controls.Add(txtFixedNumber)
        Controls.Add(Label2)
        Controls.Add(txtGeneralNumber)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Number Formats"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtGeneralNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFixedNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStandardNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCurrency As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPercentage As TextBox
    Friend WithEvents btnFormat As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label6 As Label
End Class
