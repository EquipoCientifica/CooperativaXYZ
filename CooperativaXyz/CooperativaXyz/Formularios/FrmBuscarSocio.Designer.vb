<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarSocio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtBuscar1 = New System.Windows.Forms.TextBox()
        Me.LsvSocios1 = New System.Windows.Forms.ListView()
        Me.ChCodSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellidos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChRTN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNacionalidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstadoCivil = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChLugarTrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefonoCasa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefonoTrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnSeleccionar1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(122, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Buscar:"
        '
        'TxtBuscar1
        '
        Me.TxtBuscar1.Location = New System.Drawing.Point(213, 64)
        Me.TxtBuscar1.Name = "TxtBuscar1"
        Me.TxtBuscar1.Size = New System.Drawing.Size(216, 20)
        Me.TxtBuscar1.TabIndex = 5
        '
        'LsvSocios1
        '
        Me.LsvSocios1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodSocio, Me.ChNombre, Me.ChApellidos, Me.ChRTN, Me.ChDireccion, Me.ChNacionalidad, Me.ChEstadoCivil, Me.ChLugarTrabajo, Me.ChTelefonoCasa, Me.ChTelefonoTrabajo})
        Me.LsvSocios1.FullRowSelect = True
        Me.LsvSocios1.GridLines = True
        Me.LsvSocios1.Location = New System.Drawing.Point(5, 108)
        Me.LsvSocios1.Name = "LsvSocios1"
        Me.LsvSocios1.Size = New System.Drawing.Size(791, 278)
        Me.LsvSocios1.TabIndex = 4
        Me.LsvSocios1.UseCompatibleStateImageBehavior = False
        Me.LsvSocios1.View = System.Windows.Forms.View.Details
        '
        'ChCodSocio
        '
        Me.ChCodSocio.Text = "Código Socio"
        Me.ChCodSocio.Width = 80
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre"
        Me.ChNombre.Width = 100
        '
        'ChApellidos
        '
        Me.ChApellidos.Text = "Apellidos"
        Me.ChApellidos.Width = 100
        '
        'ChRTN
        '
        Me.ChRTN.Text = "RTN"
        Me.ChRTN.Width = 80
        '
        'ChDireccion
        '
        Me.ChDireccion.Text = "Direccion"
        Me.ChDireccion.Width = 120
        '
        'ChNacionalidad
        '
        Me.ChNacionalidad.Text = "Nacionalidad"
        Me.ChNacionalidad.Width = 100
        '
        'ChEstadoCivil
        '
        Me.ChEstadoCivil.Text = "Estado Civil"
        Me.ChEstadoCivil.Width = 80
        '
        'ChLugarTrabajo
        '
        Me.ChLugarTrabajo.Text = "Lugar Trabajo"
        Me.ChLugarTrabajo.Width = 80
        '
        'ChTelefonoCasa
        '
        Me.ChTelefonoCasa.Text = "Teléfono Casa"
        Me.ChTelefonoCasa.Width = 80
        '
        'ChTelefonoTrabajo
        '
        Me.ChTelefonoTrabajo.Text = "Teléfono Trabajo"
        Me.ChTelefonoTrabajo.Width = 80
        '
        'BtnSeleccionar1
        '
        Me.BtnSeleccionar1.Location = New System.Drawing.Point(456, 62)
        Me.BtnSeleccionar1.Name = "BtnSeleccionar1"
        Me.BtnSeleccionar1.Size = New System.Drawing.Size(75, 23)
        Me.BtnSeleccionar1.TabIndex = 7
        Me.BtnSeleccionar1.Text = "Seleccionar"
        Me.BtnSeleccionar1.UseVisualStyleBackColor = True
        '
        'FrmBuscarSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSeleccionar1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtBuscar1)
        Me.Controls.Add(Me.LsvSocios1)
        Me.Name = "FrmBuscarSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBuscarSocio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents TxtBuscar1 As TextBox
    Friend WithEvents LsvSocios1 As ListView
    Friend WithEvents ChCodSocio As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChApellidos As ColumnHeader
    Friend WithEvents ChRTN As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChNacionalidad As ColumnHeader
    Friend WithEvents ChEstadoCivil As ColumnHeader
    Friend WithEvents ChLugarTrabajo As ColumnHeader
    Friend WithEvents ChTelefonoCasa As ColumnHeader
    Friend WithEvents ChTelefonoTrabajo As ColumnHeader
    Friend WithEvents BtnSeleccionar1 As Button
End Class
