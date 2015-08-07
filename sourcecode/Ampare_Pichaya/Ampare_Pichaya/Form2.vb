Option Explicit On
Option Strict On
Imports System.IO
Imports System.Drawing
Imports System.Transactions
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Data.Linq
Public Class Form2
    Dim AllRecord As Integer = 0
    Dim CurrentRecord As Integer = 0
    Dim IStudent As IQueryable(Of Student)
    Dim db As New juthawonga

    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        db.Connection.Close()
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearStudent()
        tsedit.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        search.Focus()
    End Sub

    Private Sub ClearStudent()
        idtxt.Text = ""
        fullname1.Text = ""
        idcard.Text = ""
        RichTextBox1.Text = ""
    End Sub
    Private Sub ShowCurrentStudent(ByVal Current As Integer)
        Dim hs = (From Student In IStudent Order By Student.FullName).Skip(Current).Take(1)
        idtxt.Text = hs.FirstOrDefault().SID
        ampareid.Text = hs.FirstOrDefault().IntialID
        fullname1.Text = hs.FirstOrDefault().FullName
        idcard.Text = hs.FirstOrDefault().IDCard
        If hs.FirstOrDefault().Sex = "M" Then
            male.Checked = True
        Else
            female.Checked = True
        End If
        DateTimePicker1.Value = Convert.ToDateTime(hs.FirstOrDefault().BirthDate)
        RichTextBox1.Text = hs.FirstOrDefault().Note
    End Sub

    Private Sub tsedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsedit.Click
        tsedit.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
        bn.Enabled = False
        fullname1.Focus()
        fullname1.SelectAll()
    End Sub
    Private Sub ShowStudentData()
        idtxt.Text = IStudent.FirstOrDefault().SID
        ampareid.Text = IStudent.FirstOrDefault().IntialID
        fullname1.Text = IStudent.FirstOrDefault().FullName
        idcard.Text = IStudent.FirstOrDefault().IDCard
        DateTimePicker1.Value = Convert.ToDateTime(IStudent.FirstOrDefault().Birthdate)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ClearStudent()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (fullname1.Text.Trim() = "") OrElse (idcard.Text.Trim() = "") Then
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบทุกช่อง !!!", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            fullname1.Focus()
            Exit Sub
        End If

        If MessageBox.Show("คุณต้องการแก้ไขข้อมูลนักเรียน ใช่หรือไม่?", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Using ts = New TransactionScope()
                    Dim hs = db.Students.FirstOrDefault(Function(id) id.SID = idtxt.Text.Trim())
                    hs.IntialID = ampareid.Text.ToString()
                    hs.FullName = fullname1.Text.Trim()
                    hs.IDCard = idcard.Text.Trim()

                    If male.Checked = True Then
                        hs.Sex = "M"
                    Else
                        hs.Sex = "F"
                    End If

                    hs.Birthdate = DateTimePicker1.Text
                    db.SubmitChanges()
                    ts.Complete()
                End Using
                MessageBox.Show("แก้ไขข้อมูลนักเรียน เรียบร้อย !!!", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("เกิดข้อผิดพลาด เนื่องจาก " & ex.Message, "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub movefirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles movefirst.Click
        CurrentRecord = 0
        ShowCurrentStudent(CurrentRecord)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim lgb As New LinearGradientBrush(ClientRectangle, Color.Purple, Color.Lavender, LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(lgb, ClientRectangle)
        lgb.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        IStudent = From h In db.Students
        Where ((h.SID.Contains(search.Text.Trim()) OrElse h.FullName.Contains(search.Text.Trim())))
                    Order By h.FullName Select h

        Select Case AllRecord
            Case 0
                tsedit.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                ClearStudent()
                MessageBox.Show("เงื่อนไขที่คุณป้อน ไม่พบข้อมูลนักเรียนที่มีอยู่", "ผลการค้นหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
                search.Focus()
                search.SelectAll()
            Case 1
                ShowStudentData()
                record.Text = "1"
                count.Text = "1"
                movefirst.Enabled = False
                previousmove.Enabled = False
                nextmove.Enabled = False
                lastmove.Enabled = False
            Case Is > 1
                ShowStudentData()
                CurrentRecord = 0
                ShowCurrentStudent(CurrentRecord)
                movefirst.Enabled = True
                previousmove.Enabled = True
                nextmove.Enabled = True
                lastmove.Enabled = True
                tsedit.Enabled = True
                Button2.Enabled = False
                Button3.Enabled = False
        End Select
    End Sub

    Private Sub bn_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bn.RefreshItems

    End Sub
End Class