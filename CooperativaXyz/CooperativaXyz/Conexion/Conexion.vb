﻿Imports System.Data
Imports System.Data.SqlClient

Module Conexion
    Public Cn As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=CooperativaDB;Integrated Security=True")
End Module