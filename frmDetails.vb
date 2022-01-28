' Version 1.1
' Authors: Ryan Beckett(100642971) and Shreeji Patel(100635549)
' Date: March 26th 2017
' Revised: April 13, 2017 --RB
' Description: This is the form for the details of the enemy.
' Filename: frmDetails.vb

Option Strict On
Public Class frmDetails

    Public _newStatus As Boolean

    ''' <summary>
    ''' Method: frmDetails_Load
    ''' Description: Handles the form's load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If PopulateTextBoxes() = 0 Then
            _newStatus = True
        End If

    End Sub 'frmDetails_Load

    ''' <summary>
    ''' Function: PopulateTextBoxes
    ''' Description: A function to populate textboxes on a form
    ''' The values come from the currently selected enemy The value returned is an indicator
    ''' of how many textboxes have been updated
    ''' </summary>
    ''' <returns>Integer</returns>
    Private Function PopulateTextBoxes() As Integer

        Dim iFound As Integer = 0
        If _curEnemy.EnemyID <> 0 Then
            Me.txtEnemyID.Text = _curEnemy.EnemyID.ToString()
            iFound += 1
        End If
        If _curEnemy.FirstName <> "" Then
            Me.txtFirstName.Text = _curEnemy.FirstName
            iFound += 1
        End If
        If _curEnemy.LastName <> "" Then
            Me.txtLastName.Text = _curEnemy.LastName
            iFound += 1
        End If
        If _curEnemy.ThreatLevel <> 0 Then
            Me.txtThreatLevel.Text = _curEnemy.ThreatLevel.ToString()
            iFound += 1
        End If
        If _curEnemy.AllianceID <> 0 Then
            Me.txtAllianceID.Text = _curEnemy.AllianceID.ToString()
            iFound += 1
        End If
        Return iFound

    End Function 'PopulateTextBoxes

    ''' <summary>
    ''' Method: btnOK_Click
    ''' Description: Handles the btnOK.CLick event
    ''' Post-Conditions: If changes have been made to the db, they will also be 
    ''' persisted back to the main form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim iReturnValue As Integer = 0
        iReturnValue = AddOrUpdateDetails()
        If iReturnValue > 0 Then
            ' shadow member assignment
            frmMain._curEnemy = Me._curEnemy
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            ' most likely there will already be a messagebox from the SQLCommand
            ' so no need to notify the user twice
        End If

    End Sub 'btnOK_Click

    ''' <summary>
    ''' Function: AddOrUPdateDetails
    ''' Description: A function to update the database, given an updated list of values
    ''' Post-Conditions: the data is validated before inserting/updating the database
    ''' </summary>
    ''' <returns></returns>
    Private Function AddOrUpdateDetails() As Integer

        Dim iReturnValue As Integer = 0
        If ValidateFileds(Me.txtEnemyID.Text.Trim, Me.txtFirstName.Text.Trim, Me.txtLastName.Text.Trim, Me.txtThreatLevel.Text, Me.txtAllianceID.Text) Then
            Dim iTemp As Integer = 0
            Dim datEnemyRow As DBL.Tables.datEnemy = New DBL.Tables.datEnemy()

            datEnemyRow.FirstName = _curEnemy.FirstName
            datEnemyRow.LastName = _curEnemy.LastName
            datEnemyRow.ThreatLevelID = _curEnemy.ThreatLevel
            datEnemyRow.AllianceID = _curEnemy.AllianceID

            If _newStatus Then
                iReturnValue = DBL.Tables.datEnemy.insertNewRow(datEnemyRow)
            Else
                datEnemyRow.enemyID = _curEnemy.EnemyID
                iReturnValue = CInt(DBL.Tables.datEnemy.updateExistingRow(datEnemyRow))
            End If

        End If
cancel:
        Return iReturnValue

    End Function 'AddOrUpdateDetails

    ''' <summary>
    ''' Method: btnReset_Click
    ''' Description: Resets the value in the form's textboxes, suitable for adding another record
    ''' or else erasing confidential information
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Me.txtEnemyID.Text = ""
        Me.txtFirstName.Text = ""
        Me.txtLastName.Text = ""
        Me.txtThreatLevel.Text = ""
        Me.txtAllianceID.Text = ""

    End Sub ' btnReset_Click

    ''' <summary>
    ''' Method: btnCancel_Click
    ''' Description: a method to handle the btnCancel.Click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub ' btnCancel_Click

    ''' <summary>
    ''' FUnction: ValidateFIelds
    ''' Description: A function to validate the fields that are passed to it via parameter
    ''' Post-Conditions: Any errors in validation are alerted to the user via a message box
    ''' </summary>
    ''' <param name="enemyID">String</param>
    ''' <param name="firstName">String</param>
    ''' <param name="lastName">String</param>
    ''' <param name="threatLevel">String</param>
    ''' <param name="allianceID">String</param>
    ''' <returns></returns>
    Private Function ValidateFileds(enemyID As String, firstName As String, lastName As String, threatLevel As String, allianceID As String) As Boolean

        If Not Int32.TryParse(enemyID, _curEnemy.EnemyID) Then
            MsgBox("Invalid number entered: EnemyID")
            Return False
        End If
        If firstName.Length > 25 Then
            MsgBox("First Name is too long")
            Return False
        Else
            _curEnemy.FirstName = firstName
        End If
        If lastName.Length > 25 Then
            MsgBox("Last Name is too long")
            Return False
        Else
            _curEnemy.LastName = lastName
        End If
        If Not Int32.TryParse(threatLevel, _curEnemy.ThreatLevel) Then
            MsgBox("Invalid number entered: ThreatLevelID")
            Return False
        End If
        If Not Int32.TryParse(allianceID, _curEnemy.AllianceID) Then
            MsgBox("Invalid number entered: AllianceID")
            Return False
        End If
        Return True

    End Function 'ValidateFileds

    ''' <summary>
    ''' Method: btnSave_Click
    ''' Description: Handles the btnSave.CLick event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        AddOrUpdateDetails()

    End Sub
End Class 'frmDetails