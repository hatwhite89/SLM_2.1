﻿Imports System.Xml

Public Class A_PlantillasDeResultado
    Dim plantilla As New ClsPlantillaResultado
    Private Sub A_PlantillasDeResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        alternarColoFilasDatagridview(dtPlantillas)
        ListarPlantillas()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            If txtSimbolo.Text <> "" And txtDescripcion.Text <> "" Then

                With plantilla
                    .simbolo_ = txtSimbolo.Text
                    .descripcion_ = txtDescripcion.Text
                    If .registrarNuevaPlantilla() = 1 Then
                        ListarPlantillas()
                        LimpiarCampos()
                    End If
                End With

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try

            If txtSimbolo.Text <> "" And txtDescripcion.Text <> "" And txtCodigo.Text <> "" Then

                With plantilla
                    .Cod = Convert.ToInt32(txtCodigo.Text)
                    .simbolo_ = txtSimbolo.Text
                    .descripcion_ = txtDescripcion.Text
                    If .modificarPlantilla() = 1 Then
                        ListarPlantillas()
                        LimpiarCampos()
                        btnNuevo.Enabled = False
                        btnModificar.Enabled = False
                        btnGuardar.Enabled = True
                    End If
                End With

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtPlantillas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPlantillas.CellDoubleClick

        Try
            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnGuardar.Enabled = False
            Dim dt As New DataTable
            Dim row As DataRow

            dt = dtPlantillas.DataSource
            row = dt.Rows(e.RowIndex)

            txtCodigo.Text = row("cod_Plantilla")
            txtSimbolo.Text = row("simbolo")
            txtDescripcion.Text = row("descripcion")

        Catch ex As Exception

        End Try

    End Sub

    Sub ListarPlantillas()

        dtPlantillas.DataSource = plantilla.listarPlantillas

        If dtPlantillas.Columns.Contains("cod_Plantilla") = True Then

            dtPlantillas.Columns("cod_Plantilla").Visible = False

        End If

    End Sub

    Sub LimpiarCampos()

        txtCodigo.Clear()
        txtSimbolo.Clear()
        txtDescripcion.Clear()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class