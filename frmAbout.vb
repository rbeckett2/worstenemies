' Authors: Ryan Beckett(100642971) and Shreeji Patel(100635549)
' Date: March 28th 2017
' Revised: April 13, 2017 --RB
' Description: This is the form for the authors description and version.
' Version 1.1
' Filename: frmAbout.vb

Option Strict On
Public Class frmAbout
    ''' <summary>
    ''' Method: btnExit_Click
    ''' Description: Handles the btnExit.Click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class 'frmAbout