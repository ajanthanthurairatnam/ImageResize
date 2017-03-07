<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.lblFileSize = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResize = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCompressedFileSize = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtCompressedFile = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCurrentWidth = New System.Windows.Forms.Label()
        Me.lblCurrentHeight = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblConvertedHeight = New System.Windows.Forms.Label()
        Me.lblConvertedWidth = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Image Files (*.png *.jpg *.bmp) |*.png; *.jpg; *.bmp|All Files(*.*) |*.*"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(578, 47)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(170, 32)
        Me.btnUpload.TabIndex = 0
        Me.btnUpload.Text = "Upload and Compress"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Enabled = False
        Me.txtFilePath.Location = New System.Drawing.Point(15, 50)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(557, 22)
        Me.txtFilePath.TabIndex = 1
        '
        'lblFileSize
        '
        Me.lblFileSize.AutoSize = True
        Me.lblFileSize.Location = New System.Drawing.Point(255, 67)
        Me.lblFileSize.Name = "lblFileSize"
        Me.lblFileSize.Size = New System.Drawing.Size(16, 17)
        Me.lblFileSize.TabIndex = 2
        Me.lblFileSize.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(191, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "File Size"
        '
        'txtResize
        '
        Me.txtResize.Location = New System.Drawing.Point(292, 199)
        Me.txtResize.Mask = "00000000"
        Me.txtResize.Name = "txtResize"
        Me.txtResize.Size = New System.Drawing.Size(100, 22)
        Me.txtResize.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(231, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Resize"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Set resize image dimension"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Location = New System.Drawing.Point(9, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Compressed File Size"
        '
        'lblCompressedFileSize
        '
        Me.lblCompressedFileSize.AutoSize = True
        Me.lblCompressedFileSize.Location = New System.Drawing.Point(156, 277)
        Me.lblCompressedFileSize.Name = "lblCompressedFileSize"
        Me.lblCompressedFileSize.Size = New System.Drawing.Size(16, 17)
        Me.lblCompressedFileSize.TabIndex = 10
        Me.lblCompressedFileSize.Text = "0"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(587, 364)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(170, 32)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtCompressedFile
        '
        Me.txtCompressedFile.Enabled = False
        Me.txtCompressedFile.Location = New System.Drawing.Point(12, 310)
        Me.txtCompressedFile.Name = "txtCompressedFile"
        Me.txtCompressedFile.Size = New System.Drawing.Size(745, 22)
        Me.txtCompressedFile.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblCurrentWidth)
        Me.Panel1.Controls.Add(Me.lblCurrentHeight)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtResize)
        Me.Panel1.Controls.Add(Me.lblFileSize)
        Me.Panel1.Location = New System.Drawing.Point(7, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 230)
        Me.Panel1.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(172, 17)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Current image dimensions"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Location = New System.Drawing.Point(13, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Width"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label7.Location = New System.Drawing.Point(11, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Height"
        '
        'lblCurrentWidth
        '
        Me.lblCurrentWidth.AutoSize = True
        Me.lblCurrentWidth.Location = New System.Drawing.Point(76, 158)
        Me.lblCurrentWidth.Name = "lblCurrentWidth"
        Me.lblCurrentWidth.Size = New System.Drawing.Size(0, 17)
        Me.lblCurrentWidth.TabIndex = 20
        Me.lblCurrentWidth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCurrentHeight
        '
        Me.lblCurrentHeight.AutoSize = True
        Me.lblCurrentHeight.Location = New System.Drawing.Point(76, 113)
        Me.lblCurrentHeight.Name = "lblCurrentHeight"
        Me.lblCurrentHeight.Size = New System.Drawing.Size(0, 17)
        Me.lblCurrentHeight.TabIndex = 19
        Me.lblCurrentHeight.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(398, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Pixels"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label8.Location = New System.Drawing.Point(14, 395)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Width"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label9.Location = New System.Drawing.Point(12, 350)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Height"
        '
        'lblConvertedHeight
        '
        Me.lblConvertedHeight.AutoSize = True
        Me.lblConvertedHeight.Location = New System.Drawing.Point(96, 350)
        Me.lblConvertedHeight.Name = "lblConvertedHeight"
        Me.lblConvertedHeight.Size = New System.Drawing.Size(0, 17)
        Me.lblConvertedHeight.TabIndex = 17
        Me.lblConvertedHeight.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConvertedWidth
        '
        Me.lblConvertedWidth.AutoSize = True
        Me.lblConvertedWidth.Location = New System.Drawing.Point(96, 395)
        Me.lblConvertedWidth.Name = "lblConvertedWidth"
        Me.lblConvertedWidth.Size = New System.Drawing.Size(0, 17)
        Me.lblConvertedWidth.TabIndex = 18
        Me.lblConvertedWidth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 425)
        Me.Controls.Add(Me.lblConvertedWidth)
        Me.Controls.Add(Me.lblConvertedHeight)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCompressedFile)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCompressedFileSize)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Image Resize App "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnUpload As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents lblFileSize As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtResize As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCompressedFileSize As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents txtCompressedFile As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblConvertedHeight As Label
    Friend WithEvents lblConvertedWidth As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCurrentWidth As Label
    Friend WithEvents lblCurrentHeight As Label
End Class
