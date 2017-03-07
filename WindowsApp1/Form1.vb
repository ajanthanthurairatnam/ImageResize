Imports System.Drawing.Drawing2D
Imports System.IO

''' <summary>
''' Image Dimension Converter 
''' Ajanthan
''' </summary>
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnUpload.Enabled = False
    End Sub

    Public Function resizeImage(imgToResize As Drawing.Image, sizeWidth As Int32, sizeheight As Int32) As Drawing.Image

        Dim sourceWidth As Integer = imgToResize.Width
        Dim sourceHeight As Integer = imgToResize.Height

        Dim nPercent As Single = 0
        Dim nPercentW As Single = 0
        Dim nPercentH As Single = 0

        nPercentW = (CSng(sizeWidth) / CSng(sourceWidth))
        nPercentH = (CSng(sizeheight) / CSng(sourceHeight))

        If nPercentH < nPercentW Then
            nPercent = nPercentH
        Else
            nPercent = nPercentW
        End If

        Dim destWidth As Integer = CInt(sourceWidth * nPercent)
        Dim destHeight As Integer = CInt(sourceHeight * nPercent)

        Dim b As New Bitmap(destWidth, destHeight)
        Dim g As Graphics = Graphics.FromImage(DirectCast(b, Drawing.Image))
        g.InterpolationMode = InterpolationMode.HighQualityBicubic

        g.DrawImage(imgToResize, 0, 0, destWidth, destHeight)
        g.Dispose()

        Return DirectCast(b, Drawing.Image)
    End Function

    Public Function byteArrayToImage(byteArrayIn As Byte()) As Drawing.Image
        Dim returnImage As Drawing.Image = Nothing
        Try
            Dim ms As New MemoryStream(byteArrayIn, 0, byteArrayIn.Length)
            ms.Write(byteArrayIn, 0, byteArrayIn.Length)
            'Exception occurs here
            returnImage = Drawing.Image.FromStream(ms, True)
        Catch
        End Try
        Return returnImage
    End Function

    Public Function imageToByteArray(imageIn As System.Drawing.Image) As Byte()
        Dim ms As New MemoryStream()
        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif)
        Return ms.ToArray()
    End Function

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            txtFilePath.Text = OpenFileDialog1.FileName
            lblFileSize.Text = New FileInfo(OpenFileDialog1.FileName).Length.ToString("0.00") + "  Bytes  |||  " + (New FileInfo(OpenFileDialog1.FileName).Length / 1024).ToString("0.00") + "  KB  |||  " + (New FileInfo(OpenFileDialog1.FileName).Length / (1024 * 1024)).ToString("0.00") + "  MB"
            Dim buffer As Byte() = File.ReadAllBytes(OpenFileDialog1.FileName)
            Dim imgImageForConversion As Drawing.Image = byteArrayToImage(buffer)
            Dim imgConvertedImage As Drawing.Image = resizeImage(imgImageForConversion, txtResize.Text, txtResize.Text)
            imgConvertedImage.Save(OpenFileDialog1.FileName.Substring(0, OpenFileDialog1.FileName.LastIndexOf(".")) + "Compressed" + OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf(".")))
            Dim fileInfo = New FileInfo(OpenFileDialog1.FileName.Substring(0, OpenFileDialog1.FileName.LastIndexOf(".")) + "Compressed" + OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf(".")))
            lblCompressedFileSize.Text = fileInfo.Length.ToString("0.00") + "  Bytes  |||  " + (fileInfo.Length / 1024).ToString("0.00") + "  KB  |||  " + (fileInfo.Length / (1024 * 1024)).ToString("0.00") + "  MB"
            txtCompressedFile.Text = OpenFileDialog1.FileName.Substring(0, OpenFileDialog1.FileName.LastIndexOf(".")) + "Compressed" + OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("."))
            lblConvertedHeight.Text = imgConvertedImage.Height.ToString + "Pixels"
            lblConvertedWidth.Text = imgConvertedImage.Width.ToString + "Pixels"
            lblCurrentHeight.Text = imgImageForConversion.Height.ToString + "Pixels"
            lblCurrentWidth.Text = imgImageForConversion.Width.ToString + "Pixels"
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnUpload.Enabled = False
        txtFilePath.Text = ""
        lblFileSize.Text = "0"
        lblCompressedFileSize.Text = "0"
        txtResize.Text = ""
        lblConvertedHeight.Text = ""
        lblConvertedWidth.Text = ""
        lblCurrentHeight.Text = ""
        lblCurrentWidth.Text = ""
        txtCompressedFile.Text = ""
    End Sub

    Private Sub txtResize_KeyDown(sender As Object, e As KeyEventArgs) Handles txtResize.KeyDown
        If txtResize.Text = "" OrElse Integer.Parse(txtResize.Text) = 0 Then
            btnUpload.Enabled = False
        Else
            btnUpload.Enabled = True
        End If
    End Sub

    Private Sub txtResize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtResize.KeyPress
        If txtResize.Text = "" OrElse Integer.Parse(txtResize.Text) = 0 Then
            btnUpload.Enabled = False
        Else
            btnUpload.Enabled = True
        End If
    End Sub
End Class
