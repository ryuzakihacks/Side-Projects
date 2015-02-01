Imports MetroFramework
Imports MySql.Data.MySqlClient
Imports System.Text


Public Class main
    Inherits MetroFramework.Forms.MetroForm

    'Dim serverstring As String = "Server=localhost;User Id=root;Password=123456789qwer;Database=geopulse_loader"
    Dim serverstring As String = "Server=sql5.freemysqlhosting.net;User Id=sql562300;Password=jL4*tT4%;Database=sql562300"
    Dim sqlconnection As MySqlConnection = New MySqlConnection
    Dim rng As Random = New Random

    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load
        sqlconnection.ConnectionString = serverstring
        Try
            If sqlconnection.State = ConnectionState.Closed Then
                Cursor = Cursors.WaitCursor
                sqlconnection.Open()
                retrievedata()
                retrieveinfo()
                Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.ToString())
            MsgBox("Failed to connect in the server")
            Me.Close()
        End Try
    End Sub

#Region "FUNCTION"

    Public Sub retrievedata()
        Dim query As String = "SELECT * FROM users"
        Dim adapter As New MySqlDataAdapter
        Dim cmd As New MySqlCommand
        Dim TABLE As New DataTable


        With cmd
            .CommandText = query
            .Connection = sqlconnection
        End With

        With adapter
            .SelectCommand = cmd
            .Fill(TABLE)
        End With

        For i As Integer = 0 To TABLE.Rows.Count - 1
            With lvusers
                .Items.Add(TABLE.Rows(i)("ID"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("NAME"))
                    .Add(TABLE.Rows(i)("CODE"))
                    .Add(TABLE.Rows(i)("HWID"))
                    .Add(TABLE.Rows(i)("IP"))
                    .Add(TABLE.Rows(i)("DATE"))
                End With
            End With
        Next
    End Sub

    Public Sub retrieveinfo()
        Dim query As String = "SELECT * FROM info"
        Dim adapter As New MySqlDataAdapter
        Dim cmd As New MySqlCommand
        Dim TABLE As New DataTable


        With cmd
            .CommandText = query
            .Connection = sqlconnection
        End With

        With adapter
            .SelectCommand = cmd
            .Fill(TABLE)
        End With

        For i As Integer = 0 To TABLE.Rows.Count - 1
            With lvLOADERINFO
                .Items.Add(TABLE.Rows(i)("LOADER_VERSION"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("STATUS"))
                End With
            End With
        Next
    End Sub
   
    Public Function generatekeys()
       
        Dim sb As New StringBuilder
        Dim sb2 As New StringBuilder
        Dim sb3 As New StringBuilder
        Dim holder As String
        ' Selection of pure numbers sequence or mixed one
        Dim pureNumbers = rng.Next(1, 11)
            ' Generate a sequence of digits and letters 
            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        For i As Integer = 1 To 3
            Dim idx As Integer = rng.Next(0, 36)
            sb.Append(s.Substring(idx, 1))
        Next
        holder = sb.ToString()
        holder += "-"
        For i As Integer = 1 To 3
            Dim idx As Integer = rng.Next(0, 36)
            sb2.Append(s.Substring(idx, 1))
        Next
        holder += sb2.ToString()
        holder += "-"
        For i As Integer = 1 To 3
            Dim idx As Integer = rng.Next(0, 36)
            sb3.Append(s.Substring(idx, 1))
        Next
        holder += sb3.ToString()
        Return holder
    End Function
    Public Sub insert(ByRef sqlstatement As String)
        Dim cmd As MySqlCommand = New MySqlCommand
        With cmd
            .CommandText = sqlstatement
            .CommandType = CommandType.Text
            .Connection = sqlconnection
            .ExecuteNonQuery()
        End With
    End Sub
#End Region

#Region "CODE MANAGER"
    Private Sub btnGENERATE_Click(sender As Object, e As EventArgs) Handles btnGENERATE.Click
        txtboxRESULT.Text = ""
        For i As Integer = 1 To Val(txtboxNUMKEYS.Text)
            txtboxRESULT.Text += generatekeys() + Environment.NewLine
        Next
    End Sub
    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        Cursor = Cursors.WaitCursor
        Dim arraytxt() As String = Split(txtboxRESULT.Text, Environment.NewLine)
        For i As Integer = 0 To arraytxt.Length - 2
            Dim sqlcommand As String = "INSERT INTO users(CODE) VALUES('" & arraytxt(i) & "')"
            insert(sqlcommand)
        Next
        My.Computer.Clipboard.SetText(txtboxRESULT.Text)
        txtboxRESULT.Text = ""
        lvusers.Items.Clear()
        retrievedata()
        Cursor = Cursors.Default
    End Sub
#End Region

#Region "CODE USERS"
    Private Sub btnRESET_Click(sender As Object, e As EventArgs) Handles btnRESET.Click
        'Dim sqlcmd As String = "DELETE FROM users WHERE ID='" & 29 & "'"
        'insert(sqlcmd)
        Cursor = Cursors.WaitCursor
        For i As Integer = 0 To lvusers.Items.Count - 1
            Dim sqlcmd As String = "DELETE FROM users WHERE ID='" & lvusers.Items(i).Text & "'"
            Dim sqlcmd2 As String = "ALTER TABLE users auto_increment = 1"
            insert(sqlcmd)
            insert(sqlcmd2)
        Next
        Cursor = Cursors.Default
        lvusers.Items.Clear()
        retrievedata()
    End Sub
#End Region

#Region "LOADER INFO"
    Private Sub btnADDINFO_Click(sender As Object, e As EventArgs) Handles btnADDINFO.Click
        Cursor = Cursors.WaitCursor
        Dim sqlcommand As String = "INSERT INTO info(LOADER_VERSION,STATUS) VALUES('" & txtboxVERSION.Text & "', '" & cmbboxLOADERSTATUS.Text & "')"
        Dim cleardatafromlatestversion = "TRUNCATE TABLE latest"
        Dim sqlcommand2 As String = "INSERT INTO latest(latestversion) VALUES('" & txtboxVERSION.Text & "')"
        insert(sqlcommand)
        insert(cleardatafromlatestversion)
        insert(sqlcommand2)
        lvLOADERINFO.Items.Clear()
        retrieveinfo()
        Cursor = Cursors.Default
    End Sub


    Private Sub tsUD_Click(sender As Object, e As EventArgs) Handles tsUD.Click
        Cursor = Cursors.WaitCursor
        Dim sqlcommand As String = "UPDATE info SET STATUS='UNDETECTED' WHERE LOADER_VERSION='" & lvLOADERINFO.SelectedItems(0).Text & "'"
        insert(sqlcommand)
        lvLOADERINFO.Items.Clear()
        retrieveinfo()
        Cursor = Cursors.Default
    End Sub

    Private Sub tsD_Click(sender As Object, e As EventArgs) Handles tsD.Click
        Cursor = Cursors.WaitCursor
        Dim sqlcommand As String = "UPDATE info SET STATUS='DETECTED' WHERE LOADER_VERSION='" & lvLOADERINFO.SelectedItems(0).Text & "'"
        insert(sqlcommand)
        lvLOADERINFO.Items.Clear()
        retrieveinfo()
        Cursor = Cursors.Default
    End Sub

    Private Sub tsP_Click(sender As Object, e As EventArgs) Handles tsP.Click
        Cursor = Cursors.WaitCursor
        Dim sqlcommand As String = "UPDATE info SET STATUS='PATCHED' WHERE LOADER_VERSION='" & lvLOADERINFO.SelectedItems(0).Text & "'"
        insert(sqlcommand)
        lvLOADERINFO.Items.Clear()
        retrieveinfo()
        Cursor = Cursors.Default
    End Sub

    Private Sub tsDELETE_Click(sender As Object, e As EventArgs) Handles tsDELETE.Click
        Cursor = Cursors.WaitCursor
        Dim sqlcommand As String = "DELETE FROM info WHERE LOADER_VERSION='" & lvLOADERINFO.SelectedItems(0).Text & "'"
        insert(sqlcommand)
        lvLOADERINFO.Items.Clear()
        retrieveinfo()
        Cursor = Cursors.Default
    End Sub
#End Region


End Class