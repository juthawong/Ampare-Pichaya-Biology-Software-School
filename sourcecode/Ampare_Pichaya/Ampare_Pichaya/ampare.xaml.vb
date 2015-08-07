Option Explicit On
Option Strict On
Class MainWindow
    Public Sub New()
        Windows.Forms.Application.EnableVisualStyles()
        InitializeComponent()
        AddHandler Me.Loaded, AddressOf ampare_Loaded

        'แท็บค่าแรงและเงินเดือน
        AddHandler Button1.Click, AddressOf Button1_Click
        AddHandler Button2.Click, AddressOf Button2_Click
        AddHandler Button3.Click, AddressOf Button3_Click
        AddHandler Button4.Click, AddressOf Button4_Click
        AddHandler cmdExit.Click, AddressOf cmdExit_Click
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button2.Click
        Dim f As New Form2()
        f.ShowDialog()
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        If (MessageBox.Show("คุณต้องการออกจากโปรแกรม ใช่หรือไม่?", "คำยืนยัน", MessageBoxButton.YesNo, MessageBoxImage.Question) = MessageBoxResult.Yes) Then
            End
        End If
    End Sub

    Private Sub RibbonWindow_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Dim f As New Form1()
        f.ShowDialog()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button3.Click

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button4.Click

    End Sub
    Private Sub ampare_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        
    End Sub
End Class
