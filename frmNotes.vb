' Authors: Ryan Beckett(100642971) and Shreeji Patel(100635549)
' Date: March 28th 2017
' Revised: April 13, 2017 --RB
' Description: This is the form for enemies notes. Changes may be saved to the database or ignored.
' Filename: frmNotes.vb
' Version: 1.1

Option Strict On
Public Class frmNotes

    Public enemyId As Integer
    ' used to track whether or not the note has been edited
    Public _noteChanged As Boolean
    ' used to track whether the user has already confirmed they want to discard changes
    Dim _alreadyConfirmed As Boolean

    ''' <summary>
    ''' Method: frmNotes_Load
    ''' Description: Handles the form's load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If enemyId <> 0 Then

            nudEnemyID.Value = enemyId
            Dim dNote As DBL.Tables.datNotes = New DBL.Tables.datNotes()
            dNote = DBL.Tables.datNotes.getOneRow(enemyId)
            rtxtMain.Text = dNote.note

        End If

    End Sub 'frmNotes_Load

    ''' <summary>
    ''' Method: btnOK_Click
    ''' Description: Handles the btnOK.Click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        AddOrUpdateNote(CInt(nudEnemyID.Value))
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub 'btnOK_Click

    ''' <summary>
    ''' Subroutine: AddOrUpdateNote
    ''' Description: Persists changes made to the database. The data is assumed valid.
    ''' </summary>
    ''' <param name="enemyID"></param>
    Private Sub AddOrUpdateNote(enemyID As Integer)

        Dim iResult As Integer = 0
        Dim dNote As DBL.Tables.datNotes = New DBL.Tables.datNotes()
        Dim qNote As DBL.Tables.datNotes = New DBL.Tables.datNotes()
        dNote.enemyID = CInt(nudEnemyID.Value)
        dNote.note = rtxtMain.Text
        Dim i As Integer = 0
        qNote = DBL.Tables.datNotes.getOneRowByEnemyID(CInt(nudEnemyID.Value))
        i = qNote.noteID
        If i <> 0 Then
            dNote.noteID = i
            iResult = CInt(DBL.Tables.datNotes.updateExistingRow(dNote))
        Else
            iResult = DBL.Tables.datNotes.insertNewRow(dNote)
        End If
        If iResult > 0 Then
            MsgBox("Success!")
        Else
            ' most likely there will already be a messagebox from the SQLCommand
            ' so no need to notify the user twice
        End If

    End Sub 'AddOrUpdateNote

    ''' <summary>
    ''' Method: btnCancel_Click
    ''' DEscription: Handles the btnCancel.Click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Call ConfirmClosedNote()

    End Sub 'btnCancel_Click

    ''' <summary>
    ''' Subroutine: btnSave_Click
    ''' Description: Calls AddOrUpdateNote to update the DB
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AddOrUpdateNote(CInt(nudEnemyID.Value))
        _noteChanged = False
        lblStatus.Text = "Saved"
    End Sub 'btnSave_Click

    ''' <summary>
    ''' Subroutine: ConfirmClosedNote
    ''' Description: in the case of user hasn't made any changes, closes the dialogbox with success
    ''' in the case user has made changes, but hasn't saved them, asks for confirmation before closing
    ''' if OK, close the dialogbox losing changes, if cancel, leave the dialog box open
    ''' </summary>
    Private Sub ConfirmClosedNote()

        If _noteChanged Then
            _alreadyConfirmed = True
            Dim mbResult As MsgBoxResult
            mbResult = MsgBox("You have not saved your work. Continue closing?", MsgBoxStyle.OkCancel)
            If MsgBoxResult.Ok = mbResult Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                Me.DialogResult = Nothing
                _alreadyConfirmed = False
            End If
        Else
            Me.DialogResult = DialogResult.OK
            _alreadyConfirmed = True
            Me.Close()
        End If

    End Sub 'ConfirmClosedNote

    ''' <summary>
    ''' SUbroutine: rtxtMain_ModifiedChanged
    ''' Description: Sets a flag when text in the textbox has actually been changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub rtxtMain_ModifiedChanged(sender As Object, e As EventArgs) Handles rtxtMain.ModifiedChanged
        _noteChanged = True
        lblStatus.Text = "Edited"
    End Sub

End Class 'frmNotes