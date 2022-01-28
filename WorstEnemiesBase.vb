' Authors: Ryan Beckett(100642971) and Shreeji Patel(100635549)
' Date: March 26th 2017
' Revised: April 13, 2017
' Version 1.1
' Description: This is the form for the enemies base.
' Filename: WorstEnemiesBase.vb

Option Strict On
Public Class WorstEnemiesBase
    Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' Structure: _stEnemy
    ''' Description: Used to represent an enemy within various facets of the WorstEnemies application
    ''' </summary>
    Public Structure _stEnemy
        Public EnemyID As Integer
        Public FirstName As String
        Public LastName As String
        Public ThreatLevel As Integer
        Public AllianceID As Integer
    End Structure

    ''' <summary>
    ''' Structure: _stNote
    ''' Description: Used to represent an enemy note
    ''' </summary>
    Public Structure _stNote
        Public EnemyID As Integer
        Public NoteID As Integer
        Public note As String
    End Structure

    Public _curEnemy As _stEnemy

    ''' <summary>
    ''' Function: getEnemyValueByIndex
    ''' Description: A function to retrieve the given database field value from a recordset
    ''' </summary>
    ''' <param name="column"></param>
    ''' <param name="Row"></param>
    ''' <returns></returns>
    Public Shared Function getEnemyValueByIndex(column As Integer, Row As DBL.Tables.datEnemy) As String

        Select Case column
            Case 0
                Return Row.enemyID.ToString()
            Case 1
                Return Row.FirstName
            Case 2
                Return Row.LastName
            Case 3
                Dim threatLevel As DBL.Tables.lstThreatLevel = DBL.Tables.lstThreatLevel.getOneRow(Row.ThreatLevelID)
                Return threatLevel.ThreatLevel
            Case 4
                Dim allianceId As DBL.Tables.lstAlliances = DBL.Tables.lstAlliances.getOneRow(Row.AllianceID)
                Return allianceId.allianceName
        End Select
        Return "0"

    End Function 'getEnemyValueByIndex

    ''' <summary>
    ''' Function: getEnemyValueByIndex
    ''' Description: An overloaded function to retrieve the given database value from a recordset
    ''' </summary>
    ''' <param name="column"></param>
    ''' <param name="enemy"></param>
    ''' <returns></returns>
    Public Shared Function getEnemyValueByIndex(column As Integer, enemy As _stEnemy) As String

        Select Case column
            Case 0
                Return enemy.EnemyID.ToString()
            Case 1
                Return enemy.FirstName
            Case 2
                Return enemy.LastName
            Case 3
                Dim threatLevel As DBL.Tables.lstThreatLevel = DBL.Tables.lstThreatLevel.getOneRow(enemy.ThreatLevel)
                Return threatLevel.ThreatLevel
            Case 4
                Dim allianceId As DBL.Tables.lstAlliances = DBL.Tables.lstAlliances.getOneRow(enemy.AllianceID)
                Return allianceId.allianceName
        End Select
        Return "0"

    End Function 'getEnemyValueByIndex

    ''' <summary>
    ''' Function: setCurEnemy
    ''' Description: Used to update the application's current enemy selection
    ''' </summary>
    ''' <param name="enemy"></param>
    ''' <returns></returns>
    Public Function setCurEnemy(enemy As _stEnemy) As Boolean
        _curEnemy = enemy
        Return True
    End Function 'setCurEnemy

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
        Me.SuspendLayout()
        '
        'WorstEnemiesBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Name = "WorstEnemiesBase"
        Me.Text = "WorstEnemiesBase"
        Me.ResumeLayout(False)

    End Sub

End Class 'WorstEnemiesBase
