Option Explicit On
Option Strict On
Imports GAF
Imports System.IO
Imports System.Drawing
Imports System.Transactions
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Data.Linq
Public Class Form1
    Dim CurrentSID As String
    Dim Today As DateTime
    Dim picFileName As String = ""
    Dim CBMP As Bitmap
    Dim db As New juthawonga

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        db.Connection.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            With OpenFileDialog1
                .Title = "เลือกไฟล์รูปภาพ"
                .Filter = "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp"
                .FileName = ""
                .Multiselect = False
                .FilterIndex = 0
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    picFileName = .FileName
                    CBMP = New Bitmap(picFileName)
                    If CBMP IsNot Nothing Then
                        If CBMP.Height < 185 OrElse CBMP.Width < 135 Then
                            PictureBox1.Image = Nothing
                            MessageBox.Show("ไฟล์รูปภาพที่ใช้ ต้องมีขนาดความกว้างมากกว่า 135 พิกเซล และความยาวมากกว่า 185 พิกเซล !!!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End If
                    PictureBox1.BackgroundImage = Image.FromFile(picFileName)
                Else
                    picFileName = ""
                    PictureBox1.Image = Nothing
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("ไฟล์รูปภาพที่คุณเลือก ไม่สามารถใช้งานได้ เนื่องจาก " & ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        picFileName = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ClearHuman()
    End Sub
    Private Sub ClearHuman()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        picFileName = ""
        PictureBox1.Image = Nothing
        TextBox1.Focus()
        TextBox4.Text = ""
        TextBox3.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Using ts As New TransactionScope()
            Try
                Dim h As New Student()
                h.SID = TextBox3.Text
                h.FullName = TextBox1.Text
                h.Birthdate = DateTimePicker1.Text
                h.IDCard = TextBox2.Text
                If RadioButton1.Checked Then
                    h.Sex = "M"
                Else
                    h.Sex = "F"
                End If
                h.IsLeave = "0"
                h.Room = TextBox5.Text
                h.Note = RichTextBox1.Text
                h.IntialID = TextBox3.Text
                MsgBox("Save Completed", MsgBoxStyle.Information, "Result")
            Catch ex As Exception
                MsgBox("Error")
            End Try
            db.SubmitChanges()
            ts.Complete()
        End Using
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class