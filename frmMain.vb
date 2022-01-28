' Authors: Ryan Beckett(100642971) and Shreeji Patel(100635549)
' Date: March 24th 2017
' Revised April 13, 2017 --RB
' Description: This is the main form that is loaded when the program runs.
' Filename: frmMain.vb
' Version: 1.1

Option Strict On
Imports System.ComponentModel

Public Class frmMain

    ' class variable declarations
    ' prevents controls from auto-firing events in response to the form initializing
    Dim _initGuard As Boolean = False
    Dim _controlGuard As Boolean = False

    ''' <summary>
    ''' Method: frmMain_Load
    ''' Description: Handles the frmMain.Load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.initTimer.Enabled = True
        _initGuard = True
        Call dgvMain_Populate()
        _initGuard = False

    End Sub 'frmMain_Load

    ''' <summary>
    ''' SubRoutine: dgvMain_Populate
    ''' Description: Helper method to consecutively call other sub-routines for initialization purposes
    ''' </summary>
    Private Sub dgvMain_Populate()

        Call ResetDataGrid()
        Call dgvMain_SetupTopRow()
        Call dgvMain_FillRows()

    End Sub 'dgvMain_Populate

    ''' <summary>
    ''' SubRoutine: dgvMain_Append
    ''' Description: appends new rows to the datagridview
    ''' Pre-conditions: _curEnemy shadow local struct must be valid
    ''' </summary>
    Private Sub dgvMain_Append()

        Dim colourIndicator As Integer = (dgvMain.Rows().Count) Mod 2
        Dim dgvRow As New DataGridViewRow()
        dgvRow.CreateCells(dgvMain)
        For columnIterator As Integer = 0 To 4
            ' do not need to worry about disambiguating shadow member _curEnemy here
            dgvRow.Cells().Item(columnIterator).Value = getEnemyValueByIndex(columnIterator, _curEnemy)
            If colourIndicator > 0 Then
                dgvRow.Cells().Item(columnIterator).Style.BackColor = Color.PaleGoldenrod
            End If
        Next
        dgvMain.Rows().Add(dgvRow)
        dgvMain.Refresh()

    End Sub 'dgvMain_Append

    ''' <summary>
    ''' SubRoutine: dgvMain_SetupTopRow
    ''' Description: Used to initialize the top row of the datagridview
    ''' </summary>
    Private Sub dgvMain_SetupTopRow()

        ' setup top row
        Me.dgvMain.ColumnCount = 5
        Me.dgvMain.RowHeadersVisible = False
        Dim hdrStyle As New DataGridViewCellStyle
        hdrStyle.Font = New Font("Segoe UI", 14)
        hdrStyle.BackColor = SystemColors.Info
        Me.dgvMain.Columns(0).Name = CStr(DBL.Tables.datEnemy.Fields.enemyID)
        Me.dgvMain.Columns(0).HeaderCell.Style = hdrStyle
        Me.dgvMain.Columns(0).Width = 100
        Me.dgvMain.Columns(1).Name = CStr(DBL.Tables.datEnemy.Fields.FirstName)
        Me.dgvMain.Columns(1).HeaderCell.Style = hdrStyle
        Me.dgvMain.Columns(1).Width = 119
        Me.dgvMain.Columns(2).Name = CStr(DBL.Tables.datEnemy.Fields.LastName)
        Me.dgvMain.Columns(2).HeaderCell.Style = hdrStyle
        Me.dgvMain.Columns(2).Width = 102
        Me.dgvMain.Columns(3).Name = CStr(DBL.Tables.datEnemy.Fields.ThreatLevelID)
        Me.dgvMain.Columns(3).HeaderCell.Style = hdrStyle
        Me.dgvMain.Columns(3).Width = 133
        Me.dgvMain.Columns(4).Name = CStr(DBL.Tables.datEnemy.Fields.AllianceID)
        Me.dgvMain.Columns(4).HeaderCell.Style = hdrStyle
        Me.dgvMain.Columns(4).Width = 102

    End Sub 'dgvMain_SetupTopRow

    ''' <summary>
    ''' SubRoutine: dgvMain_FillRows
    ''' Description: used for initialization, populates the datagridview
    ''' </summary>
    Private Sub dgvMain_FillRows()

        For rowIterator As Integer = 1 To DBL.Tables.datEnemy.getCountRows() + 1

            Dim bSkipAddRow As Boolean = False
            Dim colourIndicator As Integer = rowIterator Mod 2
            Dim theEnemy As DBL.Tables.datEnemy = DBL.Tables.datEnemy.getOneRow(rowIterator)
            If theEnemy.enemyID <> 0 Then
                Dim dgvRow As New DataGridViewRow
                dgvRow.CreateCells(dgvMain)
                For columnIterator As Integer = 0 To 4
                    dgvRow.Cells().Item(columnIterator).Value = getEnemyValueByIndex(columnIterator, theEnemy)
                    If colourIndicator > 0 Then
                        dgvRow.Cells().Item(columnIterator).Style.BackColor = Color.PaleGoldenrod
                    End If
                Next
                dgvMain.Rows().Add(dgvRow)
            End If

        Next

    End Sub 'dgvMain_FillRows

    ''' <summary>
    ''' Method: dgvMain_CellEnter
    ''' Description: Handles the dgvMain.CellEnter event
    ''' Pre-conditions: _initGuard must be false
    '''                 initTimer must be disabled
    '''                 chkSticky must be checked
    ''' Post-conditions: calls LaunchDetailsForm for editing the selected item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvMain_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellEnter

        If Not _initGuard AndAlso Me.initTimer.Enabled <> True AndAlso chkSticky.Checked Then
            Call LaunchDetailsForm(e.RowIndex)
        End If

    End Sub

    ''' <summary>
    ''' SubRoutine: LaunchDetailsForm
    ''' Description: A subroutine to open the details form.
    ''' Pre-conditions: User must have selected an item in the datagridview
    ''' Post-conditions: Launches PostProcessDialogProc to evaluate success
    ''' </summary>
    ''' <param name="i"></param>
    Private Sub LaunchDetailsForm(i As Integer)

        Dim frmD As frmDetails
        Try
            frmD = New frmDetails()
        Catch
            MsgBox("ERROR: Out of memory")
            GoTo cancel
        End Try
        Dim myEnemy As _stEnemy
        Dim dgvRow As DataGridViewRow = dgvMain.Rows().Item(i)
        Int32.TryParse(CStr(dgvRow.Cells().Item(0).Value), myEnemy.EnemyID)
        myEnemy.FirstName = CStr(dgvRow.Cells().Item(1).Value)
        myEnemy.LastName = CStr(dgvRow.Cells().Item(2).Value)
        myEnemy.ThreatLevel = DBL.Tables.lstThreatLevel.getThreatLevelID(CStr(dgvRow.Cells().Item(3).Value))
        myEnemy.AllianceID = DBL.Tables.lstAlliances.getAllianceID(CStr(dgvRow.Cells().Item(4).Value))
        ' assign to shadow member, it is out of scope after ShowDialog()
        frmD._curEnemy = myEnemy
        Dim dlgResult As DialogResult
        ' NOTE: this function only returns when the user clicks ok/cancel
        dlgResult = frmD.ShowDialog()
        Call PostProcessDialogProc(dlgResult, frmD._newStatus)

cancel:
    End Sub 'LaunchDetailsForm

    ''' <summary>
    ''' Subroutine: ResetDataGrid
    ''' 
    ''' Description: Used to erase values from the datagridview control
    ''' 
    ''' Preconditions: none
    ''' 
    ''' Postconditions: _initGuard must be false for any meaningful changes to occur
    '''                 if it is, then it sets all the values in the datagridview to empty strings
    ''' </summary>
    Private Sub ResetDataGrid()

        If Not _initGuard Then

            For rowIterator As Integer = 0 To Me.dgvMain.Rows.Count - 1

                For columnIterator As Integer = 0 To Me.dgvMain.Columns.Count - 1
                    Me.dgvMain.Rows().Item(rowIterator).Cells().Item(columnIterator).Value = ""
                Next

            Next

        End If

    End Sub 'ResetDataGrid

    ''' <summary>
    ''' Method: initTimer_Tick
    ''' Description: Handles the initTimer.Tick event
    ''' Pre-conditions: _controlGuard must be True (switched timer context from 
    ''' _initGuard to _controlGuard)
    ''' Post-conditions: Calls update or append as needed to update the gui, the 
    ''' db is already updated at this point.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub initTimer_Tick(sender As Object, e As EventArgs) Handles initTimer.Tick

        Dim newFlag As Boolean = CBool(initTimer.Tag)
        Me.initTimer.Enabled = False

        If _controlGuard Then
            _controlGuard = False
            If Not newFlag Then
                Call dgvMain_Update()
            Else
                Call dgvMain_Append()
            End If
        End If

    End Sub 'initTimer_Tick

    ''' <summary>
    ''' Method: btnAdd_Click
    ''' Description: Handles the btnAdd.Click event
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Call AddDetails()

    End Sub

    ''' <summary>
    ''' Subroutine: AddDetails
    ''' Description: Used to add Details to the DB
    ''' Post-conditions: calls the PostProcessDialogProc subroutine
    ''' </summary>
    Private Sub AddDetails()

        Dim frmD As frmDetails
        Try
            frmD = New frmDetails()
        Catch
            MsgBox("ERROR: Out of memory")
            GoTo cancel
        End Try

        Dim dlgResult As DialogResult
        ' NOTE: this function only returns when the user clicks ok/cancel
        dlgResult = frmD.ShowDialog()
        Call PostProcessDialogProc(dlgResult, frmD._newStatus)
cancel:

    End Sub 'AddDetails

    ''' <summary>
    ''' Method: btnEdit_Click
    ''' Description: Handles the btnEdit.Click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Call LaunchDetailsForm(dgvMain.SelectedCells().Item(0).RowIndex())

    End Sub

    ''' <summary>
    ''' Method: btnNotes_Click
    ''' Description: Handles the btnNotes.Click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNotes_Click(sender As Object, e As EventArgs) Handles btnNotes.Click

        Call LaunchNotesForm()

    End Sub

    ''' <summary>
    ''' SubRoutine: LaunchNotesForm
    ''' Description: A subroutine to launch a new form for editing notes
    ''' </summary>
    Private Sub LaunchNotesForm()

        Dim frmN As frmNotes
        Try
            frmN = New frmNotes()
        Catch
            MsgBox("ERROR: Out of memory")
            GoTo cancel
        End Try

        Dim dgvRow As DataGridViewRow = dgvMain.Rows().Item(dgvMain.SelectedCells().Item(0).RowIndex())
        Int32.TryParse(CStr(dgvRow.Cells().Item(0).Value), frmN.enemyId)
        Dim dlgResult As DialogResult
        ' NOTE: this function only returns when the user clicks ok/cancel
        dlgResult = frmN.ShowDialog()
cancel:

    End Sub 'LaunchNotesForm

    ''' <summary>
    ''' SubRoutine: dgvMain_Update
    ''' Description: A subroutine to process updating the datagridview after changes have been
    ''' committed successfully to the database
    ''' </summary>
    Private Sub dgvMain_Update()

        For rowIterator As Integer = 0 To Me.dgvMain.Rows.Count - 1
            If Not Me._curEnemy.EnemyID <> CInt(dgvMain.Rows().Item(rowIterator).Cells().Item(0).Value) Then
                dgvMain.Rows().Item(rowIterator).Cells().Item(1).Value = CType(_curEnemy.FirstName, Object)
                dgvMain.Rows().Item(rowIterator).Cells().Item(2).Value = CType(_curEnemy.LastName, Object)
                dgvMain.Rows().Item(rowIterator).Cells().Item(3).Value = CType(getEnemyValueByIndex(3, _curEnemy), Object)
                dgvMain.Rows().Item(rowIterator).Cells().Item(4).Value = CType(getEnemyValueByIndex(4, _curEnemy), Object)
            End If
        Next
        dgvMain.Refresh()

    End Sub 'dgvMain_Update

    ''' <summary>
    ''' SubRoutine: PostProcessDialogProc
    ''' Description: A routine to handle the dialogresult and dispatch a timer
    ''' to refresh the datagridview
    ''' </summary>
    ''' <param name="dlgResult">DialogResult</param>
    ''' <param name="newStatus">Boolean</param>
    Private Sub PostProcessDialogProc(dlgResult As DialogResult, newStatus As Boolean)

        If dlgResult = DialogResult.OK Then
            MsgBox("Success!")
            ' set flags and timer to avoid invalid operation exception when calling 
            ' rows.add From a .CellEnter event handler
            initTimer.Interval = 250
            ' set context (new record created vs. update record)
            If newStatus Then
                initTimer.Tag = CType(True, Boolean)
            Else
                initTimer.Tag = CType(False, Boolean)
            End If
            initTimer.Enabled = True
            _controlGuard = True
        End If

    End Sub 'PostProcessDialogProc

    ''' <summary>
    ''' Method: AboutToolStripMenuItem_Click
    ''' Description: Shows the about dialog box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        My.Forms.frmAbout.Show()
    End Sub

    ''' <summary>
    ''' Method: ExitToolStripMenuItem_Click
    ''' Description: Handles the Exit Menu Item's Click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Method: AddNewToolStripMenuItem_Click
    ''' Description: Used to add new item to the DB
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click

        Call AddDetails()

    End Sub

    ''' <summary>
    ''' Method: EditCurrentToolStripMenuItem_Click
    ''' Description: Used to edit the currently selected datagrid item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditCurrentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCurrentToolStripMenuItem.Click

        Call LaunchDetailsForm(dgvMain.SelectedCells().Item(0).RowIndex())

    End Sub

    ''' <summary>
    ''' Method:  NotesToolStripMenuItem_Click
    ''' Description: Used to edit the notes of an enemy
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotesToolStripMenuItem.Click

        Call LaunchNotesForm()

    End Sub
End Class 'frmMain
