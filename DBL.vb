''Authors: Ryan Beckett(100642971) and Shreeji Patel(100635549)
'' Date: March 26th 2017
''Description: This is the form for the enemies base.

Option Strict On
Imports System.Data, System.Data.SqlClient

' Database Code Generated on 2017-03-20 8:59:16 AM by Ryan Beckett
Namespace DBL

Public Class Conn
Public Shared Function getConnectionString() as String
Return My.Settings.dbConn
End Function
End Class

Public Class Tables

Partial Public Class datEnemy

#Region " -- Constants -- "
Public Class Fields
Public Const enemyID As String = "enemyID"
Public Const FirstName As String = "FirstName"
Public Const LastName As String = "LastName"
                Public Const ThreatLevelID As String = "ThreatLevelID"
                Public Const AllianceID As String = "AllianceID"
            End Class

#End Region

#Region " -- SQLStatements -- "
            Public Class SQLStatements
                Public Const SELECT_ALL As String = "SELECT * FROM [datEnemy]"
                Public Const SELECT_COUNT As String = "SELECT COUNT(enemyID) FROM [datEnemy]"
                Public Const SELECT_1_BY_ID As String = "SELECT TOP 1 * FROM [datEnemy] WHERE [enemyID] = @Key"
                Public Const INSERT_NEW As String = "INSERT INTO datEnemy VALUES(@FirstName, @LastName, @ThreatLevelID, @AllianceID)"
                Public Const UPDATE_EXISING As String = "UPDATE datEnemy Set FirstName  = @FirstName, LastName  = @LastName, ThreatLevelID  = @ThreatLevelID, AllianceID  = @AllianceID WHERE enemyID = @PK"
                Public Const DELETE_EXISTING As String = "DELETE FROM [datEnemy] WHERE [enemyID] = @Key"
            End Class

#End Region

#Region "-- Properties --"
            Private _enemyID As Integer
            Public Property enemyID() As Integer
                Get
                    Return _enemyID
                End Get
                Set(ByVal value As Integer)
                    _enemyID = value
                End Set
            End Property

            Private _FirstName As String
            Public Property FirstName() As String
                Get
                    Return _FirstName
                End Get
                Set(ByVal value As String)
                    _FirstName = value
                End Set
            End Property

            Private _LastName As String
            Public Property LastName() As String
                Get
                    Return _LastName
                End Get
                Set(ByVal value As String)
                    _LastName = value
                End Set
            End Property

            Private _ThreatLevelID As Integer
            Public Property ThreatLevelID() As Integer
                Get
                    Return _ThreatLevelID
                End Get
                Set(ByVal value As Integer)
                    _ThreatLevelID = value
                End Set
            End Property

            Private _AllianceID As Integer
            Public Property AllianceID() As Integer
                Get
                    Return _AllianceID
                End Get
                Set(ByVal value As Integer)
                    _AllianceID = value
                End Set
            End Property

#End Region

#Region " -- Constructors -- "
            Public Sub New(enemyID_ As Integer, FirstName_ As String, LastName_ As String, ThreatLevelID_ As Integer, AllianceID_ As Integer)
                Dim Row As New datEnemy(0)
                enemyID = 0
                FirstName = FirstName_
                LastName = LastName_
                ThreatLevelID = ThreatLevelID_
                AllianceID = AllianceID_
            End Sub

            Public Sub New(ID As Integer)
                If ID > 0 Then
                    Dim Row As New datEnemy(0)
                    Row = getOneRow(ID)
                    enemyID = Row.enemyID
                    FirstName = Row.FirstName
                    LastName = Row.LastName
                    ThreatLevelID = Row.ThreatLevelID
                    AllianceID = Row.AllianceID
                End If
            End Sub
            Public Sub New()
                enemyID = 0
                FirstName = String.Empty
                LastName = String.Empty
                ThreatLevelID = 1
                AllianceID = 1
            End Sub

#End Region

#Region "-- Generic Methods --"
            Public Shared Function getCountRows() As Integer
                Dim myInt As Integer = 0
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString
                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_COUNT
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    If dR.Read() Then
                        myInt = CInt(dR.Item(0))
                    End If
                Catch ex As Exception
                    MsgBox(Err.Description)
                End Try
                Return myInt
            End Function
            Public Shared Function getOneRow(PK As Integer) As datEnemy
                Dim returnRow As New datEnemy(0)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_1_BY_ID
                command.Parameters.AddWithValue("@Key", PK)
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    If dR.Read() Then
                        returnRow.enemyID = PK
                        If Not IsDBNull(dR(Fields.FirstName)) Then returnRow.FirstName = CStr(dR(Fields.FirstName))
                        If Not IsDBNull(dR(Fields.LastName)) Then returnRow.LastName = CStr(dR(Fields.LastName))
                        If Not IsDBNull(dR(Fields.ThreatLevelID)) Then returnRow.ThreatLevelID = CInt(dR(Fields.ThreatLevelID))
                        If Not IsDBNull(dR(Fields.AllianceID)) Then returnRow.AllianceID = CInt(dR(Fields.AllianceID))
                    End If
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRow
            End Function
            Public Shared Function getAllRows() As Generic.List(Of datEnemy)
                Dim returnRows As New Generic.List(Of datEnemy)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_ALL
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    Do While dR.Read()
                        Dim Row As New datEnemy(0)
                        If Not IsDBNull(dR(Fields.enemyID)) Then Row.enemyID = CInt(dR(Fields.enemyID))
                        If Not IsDBNull(dR(Fields.FirstName)) Then Row.FirstName = CStr(dR(Fields.FirstName))
                        If Not IsDBNull(dR(Fields.LastName)) Then Row.LastName = CStr(dR(Fields.LastName))
                        If Not IsDBNull(dR(Fields.ThreatLevelID)) Then Row.ThreatLevelID = CInt(dR(Fields.ThreatLevelID))
                        If Not IsDBNull(dR(Fields.AllianceID)) Then Row.AllianceID = CInt(dR(Fields.AllianceID))
                        returnRows.Add(Row)
                    Loop
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRows
            End Function
            Public Shared Function insertNewRow(Row As datEnemy) As Integer
                Dim ReturnValue As Integer = 0
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.INSERT_NEW
                command.Parameters.AddWithValue("@FirstName", Row.FirstName)
                command.Parameters.AddWithValue("@LastName", Row.LastName)
                command.Parameters.AddWithValue("@ThreatLevelID", Row.ThreatLevelID)
                command.Parameters.AddWithValue("@AllianceID", Row.AllianceID)
                Try
                    connDB.Open()
                    ReturnValue = command.ExecuteNonQuery
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return ReturnValue
            End Function
            Public Shared Function updateExistingRow(Row As datEnemy) As Integer
                Dim ReturnValue As Integer
                If Row.enemyID > 0 Then
                    Dim connDB As New SqlConnection
                    connDB.ConnectionString = Conn.getConnectionString

                    Dim command As New SqlCommand
                    command.Connection = connDB
                    command.CommandType = CommandType.Text
                    command.CommandText = SQLStatements.UPDATE_EXISING
                    command.Parameters.AddWithValue("@PK", Row.enemyID)
                    command.Parameters.AddWithValue("@FirstName", Row.FirstName)
                    command.Parameters.AddWithValue("@LastName", Row.LastName)
                    command.Parameters.AddWithValue("@ThreatLevelID", Row.ThreatLevelID)
                    command.Parameters.AddWithValue("@AllianceID", Row.AllianceID)
                    Try
                        connDB.Open()
                        ReturnValue = command.ExecuteNonQuery
                    Catch ex As Exception
                        Console.WriteLine(Err.Description)
                    End Try
                Else
                    ReturnValue = insertNewRow(Row)
                End If
                Return ReturnValue
            End Function
            Public Shared Function deleteRow(PK As Integer) As Boolean
 Dim returnValue As Boolean = False
Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
command.CommandType = CommandType.Text
Command.commandtext = sqlstatements.DELETE_EXISTING
       command.Parameters.AddWithValue("@Key", PK)
Try
        connDB.Open()
       returnValue = command.ExecuteNonQuery() > 0
Catch ex As Exception
Console.Writeline(err.description)
End Try
 Return returnValue
  End Function
#End Region
End Class

Partial Public Class datNotes

#Region " -- Constants -- "
Public Class Fields
Public Const noteID As String = "noteID"
Public Const enemyID As String = "enemyID"
Public Const note As String = "note"
End Class

#End Region

#Region " -- SQLStatements -- "
Public Class SQLStatements
 Public Const SELECT_ALL As String = "SELECT * FROM [datNotes]"
                Public Const SELECT_1_BY_ID As String = "SELECT TOP 1 * FROM [datNotes] WHERE [noteID] = @Key"
                Public Const SELECT_1_BY_ENEMY_ID As String = "SELECT TOP 1 * FROM [datNotes] WHERE [enemyID] = @EnemyID"
                Public Const INSERT_NEW As String = "INSERT INTO datNotes VALUES(@enemyID, @note)"
Public Const UPDATE_EXISING as string = "UPDATE datNotes Set enemyID  = @enemyID, note  = @note WHERE noteID = @PK"
 Public Const DELETE_EXISTING as string = "DELETE FROM [datNotes] WHERE [noteID] = @Key"
End Class

#End Region

#region "-- Properties --"
   Private _noteID As Integer
Public Property noteID() As Integer
Get
Return _noteID
End Get
Set(ByVal value As Integer)
_noteID = value
End Set
End Property

   Private _enemyID As Integer
Public Property enemyID() As Integer
Get
Return _enemyID
End Get
Set(ByVal value As Integer)
_enemyID = value
End Set
End Property

   Private _note As String
Public Property note() As String
Get
Return _note
End Get
Set(ByVal value As String)
_note = value
End Set
End Property

#End Region

#Region " -- Constructors -- "
Public Sub New(noteID_ As Integer, enemyID_ As Integer, note_ As String)
Dim Row As New datNotes(0)
noteID = 0
enemyID = enemyID_
note = note_
End Sub

Public Sub New(ID As Integer)
If ID > 0 Then
Dim Row As New datNotes(0)
Row = getOneRow(ID)
noteID = Row.noteID
enemyID = Row.enemyID
note = Row.note
End If
End Sub
Public Sub New()
noteID = 0
enemyID = 0
note = "1"
End Sub

#End Region

#Region "-- Generic Methods --"
            Public Shared Function getOneRowByEnemyID(PK As Integer) As datNotes
                Dim returnRow As New datNotes(0)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_1_BY_ENEMY_ID
                command.Parameters.AddWithValue("@EnemyID", PK)
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    If dR.Read() Then
                        returnRow.noteID = PK
                        'If Not IsDBNull(dR(Fields.enemyID)) Then returnRow.enemyID = dR(Fields.enemyID)
                        If Not IsDBNull(dR(Fields.note)) Then returnRow.note = CStr(dR(Fields.note))
                    End If
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRow
            End Function
            Public Shared Function getOneRow(PK As Integer) As datNotes
Dim returnRow As New datNotes(0)
Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
    command.CommandType = CommandType.Text
command.CommandText = sqlstatements.SELECT_1_BY_ID
    command.Parameters.AddWithValue("@Key", PK)
Try
        connDB.Open()
    Dim dR As IDataReader = command.ExecuteReader
    If dR.Read() Then
      returnRow.noteID = PK
                        If Not IsDBNull(dR(Fields.enemyID)) Then returnRow.enemyID = CInt(dR(Fields.enemyID))
                        If Not IsDBNull(dR(Fields.note)) Then returnRow.note = CStr(dR(Fields.note))
                    End If
Catch ex As Exception
Console.Writeline(err.description)
End Try
 Return returnRow
End Function
Public Shared Function getAllRows() As Generic.List(Of datNotes)
Dim returnRows As New Generic.List(Of datNotes)
Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
command.CommandType = CommandType.Text
command.CommandText = sqlstatements.SELECT_ALL
Try
        connDB.Open()
Dim dR As IDataReader = command.ExecuteReader
Do While dR.Read()
    Dim Row As New datNotes(0)
                        If Not IsDBNull(dR(Fields.noteID)) Then Row.noteID = CInt(dR(Fields.noteID))
                        If Not IsDBNull(dR(Fields.enemyID)) Then Row.enemyID = CInt(dR(Fields.enemyID))
                        If Not IsDBNull(dR(Fields.note)) Then Row.note = CStr(dR(Fields.note))
                        returnRows.Add(Row)
Loop
Catch ex As Exception
Console.Writeline(err.description)
End Try
Return returnRows
End Function
Public Shared Function insertNewRow(Row As datNotes) As Integer
                Dim ReturnValue As Integer = 0
                Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
command.CommandType = CommandType.Text
command.CommandText = sqlstatements.INSERT_NEW
command.Parameters.AddWithValue("@enemyID", Row.enemyID)
command.Parameters.AddWithValue("@note", Row.note)
Try
        connDB.Open()
                    ReturnValue = command.ExecuteNonQuery
                Catch ex As Exception
Console.Writeline(err.description)
End Try
Return ReturnValue
 End Function
Public Shared Function updateExistingRow(Row As datNotes) As Boolean
Dim ReturnValue As Boolean = False
If Row.noteID > 0 Then
Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
command.CommandType = CommandType.Text
Command.commandtext = sqlstatements.UPDATE_EXISING
            command.Parameters.AddWithValue("@PK", Row.noteID)
            command.Parameters.AddWithValue("@enemyID", Row.enemyID)
            command.Parameters.AddWithValue("@note", Row.note)
Try
        connDB.Open()
            If command.ExecuteNonQuery > 0 Then ReturnValue = True
Catch ex As Exception
Console.Writeline(err.description)
End Try
 Else
     If insertNewRow(Row) > 0 Then ReturnValue = True
 End If
  Return ReturnValue
End Function
Public Shared Function deleteRow(PK As Integer) As Boolean
 Dim returnValue As Boolean = False
Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
command.CommandType = CommandType.Text
Command.commandtext = sqlstatements.DELETE_EXISTING
       command.Parameters.AddWithValue("@Key", PK)
Try
        connDB.Open()
       returnValue = command.ExecuteNonQuery() > 0
Catch ex As Exception
Console.Writeline(err.description)
End Try
 Return returnValue
  End Function
#End Region
End Class

Partial Public Class lstThreatLevel

#Region " -- Constants -- "
Public Class Fields
Public Const levelID As String = "levelID"
Public Const ThreatLevel As String = "ThreatLevel"
Public Const Priority As String = "Priority"
Public Const isActive As String = "isActive"
End Class

#End Region

#Region " -- SQLStatements -- "
            Public Class SQLStatements
                Public Const SELECT_ALL As String = "SELECT * FROM [lstThreatLevel]"
                Public Const SELECT_1_BY_ID As String = "SELECT TOP 1 * FROM [lstThreatLevel] WHERE [levelID] = @Key"
                Public Const SELECT_1_BY_THREAT_LEVEL As String = "SELECT TOP 1 levelID FROM [lstThreatLevel] WHERE [ThreatLevel] = @ThreatIn"
                Public Const INSERT_NEW As String = "INSERT INTO lstThreatLevel VALUES(@ThreatLevel, @Priority, @isActive)"
                Public Const UPDATE_EXISING As String = "UPDATE lstThreatLevel Set ThreatLevel  = @ThreatLevel, Priority  = @Priority, isActive  = @isActive WHERE levelID = @PK"
                Public Const DELETE_EXISTING As String = "DELETE FROM [lstThreatLevel] WHERE [levelID] = @Key"
            End Class

#End Region

#region "-- Properties --"
   Private _levelID As Integer
Public Property levelID() As Integer
Get
Return _levelID
End Get
Set(ByVal value As Integer)
_levelID = value
End Set
End Property

   Private _ThreatLevel As String
Public Property ThreatLevel() As String
Get
Return _ThreatLevel
End Get
Set(ByVal value As String)
_ThreatLevel = value
End Set
End Property

   Private _Priority As Integer
Public Property Priority() As Integer
Get
Return _Priority
End Get
Set(ByVal value As Integer)
_Priority = value
End Set
End Property

   Private _isActive As Boolean
Public Property isActive() As Boolean
Get
Return _isActive
End Get
Set(ByVal value As Boolean)
_isActive = value
End Set
End Property

#End Region

#Region " -- Constructors -- "
Public Sub New(levelID_ As Integer, ThreatLevel_ As String, Priority_ As Integer, isActive_ As Boolean)
Dim Row As New lstThreatLevel(0)
levelID = 0
ThreatLevel = ThreatLevel_
Priority = Priority_
isActive = isActive_
End Sub

Public Sub New(ID As Integer)
If ID > 0 Then
Dim Row As New lstThreatLevel(0)
Row = getOneRow(ID)
levelID = Row.levelID
ThreatLevel = Row.ThreatLevel
Priority = Row.Priority
isActive = Row.isActive
End If
End Sub
Public Sub New()
levelID = 0
ThreatLevel = String.empty
Priority = 10
isActive = True
End Sub

#End Region

#Region "-- Generic Methods --"
            Public Shared Function getThreatLevelID(str As String) As Integer

                Dim i As Integer = 0
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_1_BY_THREAT_LEVEL
                command.Parameters.AddWithValue("@ThreatIn", str)
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    If dR.Read() Then
                        If Not IsDBNull(dR(Fields.levelID)) Then i = CInt(dR(Fields.levelID))
                    End If
                Catch ex As Exception
                End Try
                Return i

            End Function
            Public Shared Function getOneRow(PK As Integer) As lstThreatLevel
Dim returnRow As New lstThreatLevel(0)
Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
    command.CommandType = CommandType.Text
command.CommandText = sqlstatements.SELECT_1_BY_ID
    command.Parameters.AddWithValue("@Key", PK)
Try
        connDB.Open()
    Dim dR As IDataReader = command.ExecuteReader
    If dR.Read() Then
      returnRow.levelID = PK
                        If Not IsDBNull(dR(Fields.ThreatLevel)) Then returnRow.ThreatLevel = CStr(dR(Fields.ThreatLevel))
                        If Not IsDBNull(dR(Fields.Priority)) Then returnRow.Priority = CInt(dR(Fields.Priority))
                        If Not IsDBNull(dR(Fields.isActive)) Then returnRow.isActive = CBool(dR(Fields.isActive))
                    End If
Catch ex As Exception
Console.Writeline(err.description)
End Try
 Return returnRow
End Function
Public Shared Function getAllRows() As Generic.List(Of lstThreatLevel)
Dim returnRows As New Generic.List(Of lstThreatLevel)
Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
command.CommandType = CommandType.Text
command.CommandText = sqlstatements.SELECT_ALL
Try
        connDB.Open()
Dim dR As IDataReader = command.ExecuteReader
Do While dR.Read()
    Dim Row As New lstThreatLevel(0)
                        If Not IsDBNull(dR(Fields.levelID)) Then Row.levelID = CInt(dR(Fields.levelID))
                        If Not IsDBNull(dR(Fields.ThreatLevel)) Then Row.ThreatLevel = CStr(dR(Fields.ThreatLevel))
                        If Not IsDBNull(dR(Fields.Priority)) Then Row.Priority = CInt(dR(Fields.Priority))
                        If Not IsDBNull(dR(Fields.isActive)) Then Row.isActive = CBool(dR(Fields.isActive))
                        returnRows.Add(Row)
Loop
Catch ex As Exception
Console.Writeline(err.description)
End Try
Return returnRows
End Function
Public Shared Function insertNewRow(Row As lstThreatLevel) As Integer
                Dim ReturnValue As Integer = 0
                Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
command.CommandType = CommandType.Text
command.CommandText = sqlstatements.INSERT_NEW
command.Parameters.AddWithValue("@ThreatLevel", Row.ThreatLevel)
command.Parameters.AddWithValue("@Priority", Row.Priority)
command.Parameters.AddWithValue("@isActive", Row.isActive)
Try
        connDB.Open()
                    ReturnValue = command.ExecuteNonQuery
                Catch ex As Exception
Console.Writeline(err.description)
End Try
Return ReturnValue
 End Function
Public Shared Function updateExistingRow(Row As lstThreatLevel) As Boolean
Dim ReturnValue As Boolean = False
If Row.levelID > 0 Then
Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
command.CommandType = CommandType.Text
Command.commandtext = sqlstatements.UPDATE_EXISING
            command.Parameters.AddWithValue("@PK", Row.levelID)
            command.Parameters.AddWithValue("@ThreatLevel", Row.ThreatLevel)
            command.Parameters.AddWithValue("@Priority", Row.Priority)
            command.Parameters.AddWithValue("@isActive", Row.isActive)
Try
        connDB.Open()
            If command.ExecuteNonQuery > 0 Then ReturnValue = True
Catch ex As Exception
Console.Writeline(err.description)
End Try
 Else
     If insertNewRow(Row) > 0 Then ReturnValue = True
 End If
  Return ReturnValue
End Function
Public Shared Function deleteRow(PK As Integer) As Boolean
 Dim returnValue As Boolean = False
Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
command.CommandType = CommandType.Text
Command.commandtext = sqlstatements.DELETE_EXISTING
       command.Parameters.AddWithValue("@Key", PK)
Try
        connDB.Open()
       returnValue = command.ExecuteNonQuery() > 0
Catch ex As Exception
Console.Writeline(err.description)
End Try
 Return returnValue
  End Function
#End Region
End Class

Partial Public Class lstAlliances

#Region " -- Constants -- "
Public Class Fields
Public Const allianceID As String = "allianceID"
Public Const allianceName As String = "allianceName"
Public Const isActive As String = "isActive"
End Class

#End Region

#Region " -- SQLStatements -- "
Public Class SQLStatements
 Public Const SELECT_ALL As String = "SELECT * FROM [lstAlliances]"
                Public Const SELECT_1_BY_ID As String = "SELECT TOP 1 * FROM [lstAlliances] WHERE [allianceID] = @Key"
                Public Const SELECT_1_BY_ALLIANCE_ID As String = "SELECT TOP 1 allianceID FROM [lstAlliances] WHERE [allianceName] = @AllianceIn"
                Public Const INSERT_NEW As String = "INSERT INTO lstAlliances VALUES(@allianceName, @isActive)"
Public Const UPDATE_EXISING as string = "UPDATE lstAlliances Set allianceName  = @allianceName, isActive  = @isActive WHERE allianceID = @PK"
 Public Const DELETE_EXISTING as string = "DELETE FROM [lstAlliances] WHERE [allianceID] = @Key"
End Class

#End Region

#region "-- Properties --"
   Private _allianceID As Integer
Public Property allianceID() As Integer
Get
Return _allianceID
End Get
Set(ByVal value As Integer)
_allianceID = value
End Set
End Property

   Private _allianceName As String
Public Property allianceName() As String
Get
Return _allianceName
End Get
Set(ByVal value As String)
_allianceName = value
End Set
End Property

   Private _isActive As Boolean
Public Property isActive() As Boolean
Get
Return _isActive
End Get
Set(ByVal value As Boolean)
_isActive = value
End Set
End Property

#End Region

#Region " -- Constructors -- "
Public Sub New(allianceID_ As Integer, allianceName_ As String, isActive_ As Boolean)
Dim Row As New lstAlliances(0)
allianceID = 0
allianceName = allianceName_
isActive = isActive_
End Sub

Public Sub New(ID As Integer)
If ID > 0 Then
Dim Row As New lstAlliances(0)
Row = getOneRow(ID)
allianceID = Row.allianceID
allianceName = Row.allianceName
isActive = Row.isActive
End If
End Sub
Public Sub New()
allianceID = 0
allianceName = String.empty
isActive = True
End Sub

#End Region

#Region "-- Generic Methods --"
            Public Shared Function getAllianceID(str As String) As Integer

                Dim i As Integer = 0
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_1_BY_ALLIANCE_ID
                command.Parameters.AddWithValue("@AllianceIn", str)
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    If dR.Read() Then
                        If Not IsDBNull(dR(Fields.allianceID)) Then i = CInt(dR(Fields.allianceID))
                    End If
                Catch ex As Exception
                End Try
                Return i

            End Function
            Public Shared Function getOneRow(PK As Integer) As lstAlliances
Dim returnRow As New lstAlliances(0)
Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
    command.CommandType = CommandType.Text
command.CommandText = sqlstatements.SELECT_1_BY_ID
    command.Parameters.AddWithValue("@Key", PK)
Try
        connDB.Open()
    Dim dR As IDataReader = command.ExecuteReader
    If dR.Read() Then
      returnRow.allianceID = PK
                        If Not IsDBNull(dR(Fields.allianceName)) Then returnRow.allianceName = CStr(dR(Fields.allianceName))
                        If Not IsDBNull(dR(Fields.isActive)) Then returnRow.isActive = CBool(dR(Fields.isActive))
                    End If
Catch ex As Exception
Console.Writeline(err.description)
End Try
 Return returnRow
End Function
Public Shared Function getAllRows() As Generic.List(Of lstAlliances)
Dim returnRows As New Generic.List(Of lstAlliances)
Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
command.CommandType = CommandType.Text
command.CommandText = sqlstatements.SELECT_ALL
Try
        connDB.Open()
Dim dR As IDataReader = command.ExecuteReader
Do While dR.Read()
    Dim Row As New lstAlliances(0)
                        If Not IsDBNull(dR(Fields.allianceID)) Then Row.allianceID = CInt(dR(Fields.allianceID))
                        If Not IsDBNull(dR(Fields.allianceName)) Then Row.allianceName = CStr(dR(Fields.allianceName))
                        If Not IsDBNull(dR(Fields.isActive)) Then Row.isActive = CBool(dR(Fields.isActive))
                        returnRows.Add(Row)
Loop
Catch ex As Exception
Console.Writeline(err.description)
End Try
Return returnRows
End Function
Public Shared Function insertNewRow(Row As lstAlliances) As Integer
                Dim ReturnValue As Integer = 0
                Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
command.CommandType = CommandType.Text
command.CommandText = sqlstatements.INSERT_NEW
command.Parameters.AddWithValue("@allianceName", Row.allianceName)
command.Parameters.AddWithValue("@isActive", Row.isActive)
Try
        connDB.Open()
                    ReturnValue = command.ExecuteNonQuery
                Catch ex As Exception
Console.Writeline(err.description)
End Try
Return ReturnValue
 End Function
Public Shared Function updateExistingRow(Row As lstAlliances) As Boolean
Dim ReturnValue As Boolean = False
If Row.allianceID > 0 Then
Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
command.CommandType = CommandType.Text
Command.commandtext = sqlstatements.UPDATE_EXISING
            command.Parameters.AddWithValue("@PK", Row.allianceID)
            command.Parameters.AddWithValue("@allianceName", Row.allianceName)
            command.Parameters.AddWithValue("@isActive", Row.isActive)
Try
        connDB.Open()
            If command.ExecuteNonQuery > 0 Then ReturnValue = True
Catch ex As Exception
Console.Writeline(err.description)
End Try
 Else
     If insertNewRow(Row) > 0 Then ReturnValue = True
 End If
  Return ReturnValue
End Function
Public Shared Function deleteRow(PK As Integer) As Boolean
 Dim returnValue As Boolean = False
Dim connDB As New SqlConnection
conndb.connectionstring = conn.getConnectionString

Dim command As New SqlCommand
command.connection = connDB
command.CommandType = CommandType.Text
Command.commandtext = sqlstatements.DELETE_EXISTING
       command.Parameters.AddWithValue("@Key", PK)
Try
        connDB.Open()
       returnValue = command.ExecuteNonQuery() > 0
Catch ex As Exception
Console.Writeline(err.description)
End Try
 Return returnValue
  End Function
#End Region
End Class

End Class
End Namespace

