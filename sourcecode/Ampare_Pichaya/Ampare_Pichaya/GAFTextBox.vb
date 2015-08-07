Option Explicit On
Option Strict On
Imports System.Windows.Forms
Imports System.ComponentModel

Public Enum InputMode
    IntegerMode = 1
    CurrencyMode = 2
End Enum

Public Class GAFTextBox
    Inherits System.Windows.Forms.TextBox

    Private _InputType As InputMode = InputMode.IntegerMode
    Public Property InputType() As InputMode
        Get
            Return _InputType
        End Get
        Set(ByVal value As InputMode)
            _InputType = value
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.ContextMenu = New ContextMenu()
        If Me.Text.Trim() = "" Then Me.Text = "0"
    End Sub

    Protected Overrides Sub OnKeyPress(e As System.Windows.Forms.KeyPressEventArgs)
        MyBase.OnKeyPress(e)
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then
            e.Handled = True
        End If

        If (e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = False
        End If

        If _InputType = InputMode.CurrencyMode Then
            If e.KeyChar = "." Then
                e.Handled = False
            End If

            If CBool(((e.KeyChar = "." AndAlso CBool(InStr(Me.Text, "."))))) Then
                e.Handled = True
            End If
        End If
    End Sub
End Class