Public Class A_MuestraPantallaCliente
    Dim ARCHIVOS As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
    Dim CONTADOR As Integer
    Dim DURACION As Integer
    Private Sub A_MuestraPantallaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            WMP.stretchToFit = True 'ADAPTA LA IMAGEN EL ARCHIVO AL TAMAÑO DE LA PANTALLA
            WMP.uiMode = "NONE" 'PARA QUE NO SE PUEDAN HACER CAMBIOS EN LA BARRA DE TIEMPO

            alternarColoFilasDatagridview(dtPacientesEspera)

            Timer1.Enabled = True

            ARCHIVOS = My.Computer.FileSystem.GetFiles("C:\Program Files (x86)\Laboratorios Medicos\Sistema De Laboratorios Medicos\PROMOCIONALES")

            Dim NOMBRE As String = Nothing
            For I = 0 To ARCHIVOS.Count - 1
                NOMBRE = ARCHIVOS(I).Remove(0, ARCHIVOS(I).LastIndexOf("\") + 1)
                cbxVideos.Items.Add(NOMBRE)
            Next
            REPRODUCIR()
        Catch ex As Exception
            MsgBox("No existen vídeos en la carpeta PROMOCIONALES en la raíz del programa. No se mostrarán vídeos.")
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        lblFecha.Text = DateTime.Now.ToLongDateString()

    End Sub

    Private Sub cbxVideos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxVideos.SelectedIndexChanged
        Try
            WMP.URL = ARCHIVOS(cbxVideos.SelectedIndex) 'AL SELECCIONAR UN ITEM EN EL COMBOBOX EMPIEZA A REPRODUCIRSE
            CONTADOR = cbxVideos.SelectedIndex 'INICIALIZA EL CONTADOR DE ARCHIVOS CON EL INDICE SELECCIONADO 
            Timer2.Interval = 3000 'PARA DAR TIEMPO A CARGAR EL ARCHIVO EN EL REPRODUCTOR Y PODER DETERMINAR SU DURACION
            Timer2.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            DURACION = WMP.currentMedia.duration - 2 'DETERMINA LA DURACION DEL ARCHIVO
            Timer2.Stop()
            Timer3.Interval = 1000 'EMPIEZA LA CUENTA ATRAS PARA SABER CUANDO ACABA DE REPRODUCIRSE EL ARCHIVO
            Timer3.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            DURACION -= 1 ' CUENTA ATRAS PARA SABER CUANDO ACABA DE REPRODUCIRSE EL ARCHIVO
            If DURACION <= 0 Then 'HA TERMINADO DE REPRODUCIRSE EN AUTOMATICO
                CONTADOR += 1 ' PASA AL SIGUIENTE ARCHIVO
                If CONTADOR > ARCHIVOS.Count - 1 Then ' SI HA LLEGADO AL FIN DEL ULTIMO ARCHIVO VUELVE A EMPEZAR 
                    CONTADOR = 0
                End If
                Timer3.Stop() 'DETIENE LA CUENTA ATRAS
                REPRODUCIR() 'REPRODUCE EL SIGUIENTE ARCHIVO

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub REPRODUCIR()
        Try
            cbxVideos.SelectedIndex = CONTADOR 'ACTUALIZA LA SELECCION EN EL COMBOBOX
            WMP.URL = ARCHIVOS(cbxVideos.SelectedIndex) 'REPRODUCE EL ARCHIVO SELECCIONADO
            Timer2.Interval = 3000 'PARA DAR TIEMPO A CARGAR EL ARCHIVO EN EL REPRODUCTOR Y PODER DETERMINAR SU DURACION
            Timer2.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class