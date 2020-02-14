Imports System.Configuration
Public Class frmPrincipal
    Private Sub BtnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        'Leemos todas las cadenas de conexión en el administrador de configuraciones y carga en un control
        'También lee la cadena de conexión especificada en el control con el nombre de la cadena de conexión a buscar
        Try
            txtNombresCadCon.Text = String.Empty
            For i As Integer = 0 To ConfigurationManager.ConnectionStrings.Count - 1
                txtNombresCadCon.Text += ConfigurationManager.ConnectionStrings(i).Name & IIf(i = ConfigurationManager.ConnectionStrings.Count - 1, String.Empty, vbCrLf)
            Next

            If ConfigurationManager.ConnectionStrings("AppConfigFile.My.MySettings." & txtNombreCadCon.Text) IsNot Nothing Then
                txtCadenaConexion.Text = ConfigurationManager.ConnectionStrings("AppConfigFile.My.MySettings." & Me.txtNombreCadCon.Text).ConnectionString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            AgregarCadenaConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Clear connection strings collection.
    Shared Sub LimpiarCadenaConexion()

        ' Get the application configuration file.
        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        ' Clear the connection strings collection.
        Dim csSection As ConnectionStringsSection = config.ConnectionStrings
        csSection.ConnectionStrings.Clear()

        ' Save the configuration file.
        config.Save(ConfigurationSaveMode.Modified)

        Application.Restart()
    End Sub

    Private Sub AgregarCadenaConexion()
        'Si no hay nombre de cadena de conexión
        If txtNombreCadCon.Text.Trim = "" Then
            Exit Sub
        End If

        ' Get the configuration file.
        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim csSection As ConnectionStringsSection = config.ConnectionStrings

        'Si no existe cadena con ese nombre
        If ConfigurationManager.ConnectionStrings("AppCopnfigFile.My.MySettings." & Me.txtNombreCadCon.Text) Is Nothing Then
            ' Add the connection string.
            csSection.ConnectionStrings.Add(New ConnectionStringSettings("AppCopnfigFile.My.MySettings." & Me.txtNombreCadCon.Text, txtCadenaConexion.Text, "System.Data.SqlClient"))

            ' Save the configuration file.
            config.Save(ConfigurationSaveMode.Modified)
            Application.Restart()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            LimpiarCadenaConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
