<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtCadenaConexion = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnLeer = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblNombreCadCon = New System.Windows.Forms.Label()
        Me.txtNombreCadCon = New System.Windows.Forms.TextBox()
        Me.lblCadenaConexion = New System.Windows.Forms.Label()
        Me.txtNombresCadCon = New System.Windows.Forms.RichTextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCadenaConexion
        '
        Me.txtCadenaConexion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCadenaConexion.Location = New System.Drawing.Point(62, 32)
        Me.txtCadenaConexion.Name = "txtCadenaConexion"
        Me.txtCadenaConexion.Size = New System.Drawing.Size(540, 20)
        Me.txtCadenaConexion.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnLeer
        '
        Me.btnLeer.Location = New System.Drawing.Point(12, 58)
        Me.btnLeer.Name = "btnLeer"
        Me.btnLeer.Size = New System.Drawing.Size(75, 23)
        Me.btnLeer.TabIndex = 2
        Me.btnLeer.Text = "Leer"
        Me.btnLeer.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(93, 58)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblNombreCadCon
        '
        Me.lblNombreCadCon.AutoSize = True
        Me.lblNombreCadCon.Location = New System.Drawing.Point(9, 9)
        Me.lblNombreCadCon.Name = "lblNombreCadCon"
        Me.lblNombreCadCon.Size = New System.Drawing.Size(322, 13)
        Me.lblNombreCadCon.TabIndex = 4
        Me.lblNombreCadCon.Text = "Nombre de la cadena de conexión: AppCopnfigFile.My.MySettings."
        '
        'txtNombreCadCon
        '
        Me.txtNombreCadCon.Location = New System.Drawing.Point(329, 6)
        Me.txtNombreCadCon.Name = "txtNombreCadCon"
        Me.txtNombreCadCon.Size = New System.Drawing.Size(272, 20)
        Me.txtNombreCadCon.TabIndex = 5
        Me.txtNombreCadCon.Text = "cadena_conexion"
        '
        'lblCadenaConexion
        '
        Me.lblCadenaConexion.AutoSize = True
        Me.lblCadenaConexion.Location = New System.Drawing.Point(9, 35)
        Me.lblCadenaConexion.Name = "lblCadenaConexion"
        Me.lblCadenaConexion.Size = New System.Drawing.Size(47, 13)
        Me.lblCadenaConexion.TabIndex = 6
        Me.lblCadenaConexion.Text = "Cadena:"
        '
        'txtNombresCadCon
        '
        Me.txtNombresCadCon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombresCadCon.Location = New System.Drawing.Point(174, 58)
        Me.txtNombresCadCon.Name = "txtNombresCadCon"
        Me.txtNombresCadCon.Size = New System.Drawing.Size(428, 115)
        Me.txtNombresCadCon.TabIndex = 7
        Me.txtNombresCadCon.Text = ""
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(93, 87)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 185)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtNombresCadCon)
        Me.Controls.Add(Me.lblCadenaConexion)
        Me.Controls.Add(Me.txtNombreCadCon)
        Me.Controls.Add(Me.lblNombreCadCon)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnLeer)
        Me.Controls.Add(Me.txtCadenaConexion)
        Me.Name = "frmPrincipal"
        Me.Text = "Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCadenaConexion As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnLeer As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblNombreCadCon As Label
    Friend WithEvents txtNombreCadCon As TextBox
    Friend WithEvents lblCadenaConexion As Label
    Friend WithEvents txtNombresCadCon As RichTextBox
    Friend WithEvents btnGuardar As Button
End Class
