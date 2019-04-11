Imports System.Data
Imports System.Data.SqlClient

Module Conexion

    Public Cn As New SqlConnection("Data Source=ROGER-PC\SQLEXPRESS;Initial Catalog=CooperativaDB;Integrated Security=True")
    ' Public Cn As New SqlConnection("Data Source=.;Initial Catalog=CooperativaDB;Integrated Security=True")
End Module