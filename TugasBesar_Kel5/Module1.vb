Imports MySql.Data.MySqlClient
Module Module1
        Public conn As New MySqlConnection
        Public da As New MySqlDataAdapter
        Public ds As New DataSet

        Public Sub koneksi()
        conn = New MySqlConnection("server=localhost" + ";user id = root" + "; password=" + "" + ";database=db_cafe2")
    End Sub
    End Module
