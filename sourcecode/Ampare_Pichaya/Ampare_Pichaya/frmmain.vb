Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class frmmain
    Protected db As New juthawonga
    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim lgb As New LinearGradientBrush(ClientRectangle, Color.Violet, Color.Azure, LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(lgb, ClientRectangle)
        lgb.Dispose()
    End Sub
End Class