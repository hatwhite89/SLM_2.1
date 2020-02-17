
Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic

Module ModulosVarios

    ':::::::::::::::::::::::: Importar Excel ::::::::::::::::::::::::
    Sub importarExcel(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With

        If myFileDialog.FileName.ToString <> "" Then

            Dim ExcelFile As String = myFileDialog.FileName.ToString

            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection

            xSheet = InputBox("Ingrese el nombre de la hoja a importar", "Complete")
            conn = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & ExcelFile & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            Try
                da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                tabla.DataSource = ds
                tabla.DataMember = "MyData"

            Catch ex As Exception
                MsgBox("Inserte un nombre válido de la Hoja que desea importar.", MsgBoxStyle.Information, "Información")
            Finally
                conn.Close()
            End Try


            MsgBox("Se ha cargado la importación correctamente. ", MsgBoxStyle.Information, "Importado con exito")

        Else
            MsgBox("No se logro la importación.")
        End If

    End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::



End Module
