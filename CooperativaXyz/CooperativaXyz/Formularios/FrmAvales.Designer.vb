<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAvales
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbMenu = New System.Windows.Forms.TabControl()
        Me.TbDatosAvales = New System.Windows.Forms.TabPage()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumSolicitus = New System.Windows.Forms.TextBox()
        Me.TxtMostrarPrestamo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtAval = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnBuscarSocioAval = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBuscarNumSolicitud = New System.Windows.Forms.TextBox()
        Me.LsvAvales = New System.Windows.Forms.ListView()
        Me.CHNumSolicitud = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHCodSocioAval = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.TbMenu.SuspendLayout()
        Me.TbDatosAvales.SuspendLayout()
        Me.TbListado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(961, 68)
        Me.Panel1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(320, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(346, 51)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Gestión Avales"
        '
        'TbMenu
        '
        Me.TbMenu.Controls.Add(Me.TbDatosAvales)
        Me.TbMenu.Controls.Add(Me.TbListado)
        Me.TbMenu.Location = New System.Drawing.Point(12, 76)
        Me.TbMenu.Name = "TbMenu"
        Me.TbMenu.SelectedIndex = 0
        Me.TbMenu.Size = New System.Drawing.Size(951, 333)
        Me.TbMenu.TabIndex = 15
        '
        'TbDatosAvales
        '
        Me.TbDatosAvales.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TbDatosAvales.Controls.Add(Me.GroupBox3)
        Me.TbDatosAvales.Controls.Add(Me.GroupBox2)
        Me.TbDatosAvales.Location = New System.Drawing.Point(4, 25)
        Me.TbDatosAvales.Name = "TbDatosAvales"
        Me.TbDatosAvales.Padding = New System.Windows.Forms.Padding(3)
        Me.TbDatosAvales.Size = New System.Drawing.Size(943, 304)
        Me.TbDatosAvales.TabIndex = 0
        Me.TbDatosAvales.Text = "Datos"
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.LsvAvales)
        Me.TbListado.Controls.Add(Me.TxtBuscarNumSolicitud)
        Me.TbListado.Controls.Add(Me.Label4)
        Me.TbListado.Location = New System.Drawing.Point(4, 25)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(943, 304)
        Me.TbListado.TabIndex = 1
        Me.TbListado.Text = "Listado"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnRegresar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 415)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 82)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnRegresar.Location = New System.Drawing.Point(812, 13)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(100, 62)
        Me.BtnRegresar.TabIndex = 9
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnCancelar.Location = New System.Drawing.Point(637, 13)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 62)
        Me.BtnCancelar.TabIndex = 8
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnModificar.Location = New System.Drawing.Point(438, 13)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(100, 62)
        Me.BtnModificar.TabIndex = 7
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnGuardar.Location = New System.Drawing.Point(216, 13)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 62)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 13)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(100, 62)
        Me.BtnNuevo.TabIndex = 5
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.TxtMostrarPrestamo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtNumSolicitus)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Bright", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 186)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Prestamo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de Solicitud"
        '
        'TxtNumSolicitus
        '
        Me.TxtNumSolicitus.Location = New System.Drawing.Point(172, 49)
        Me.TxtNumSolicitus.Name = "TxtNumSolicitus"
        Me.TxtNumSolicitus.Size = New System.Drawing.Size(144, 23)
        Me.TxtNumSolicitus.TabIndex = 2
        '
        'TxtMostrarPrestamo
        '
        Me.TxtMostrarPrestamo.Location = New System.Drawing.Point(172, 108)
        Me.TxtMostrarPrestamo.Name = "TxtMostrarPrestamo"
        Me.TxtMostrarPrestamo.Size = New System.Drawing.Size(144, 23)
        Me.TxtMostrarPrestamo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo Prestamo"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.BtnBuscarSocioAval)
        Me.GroupBox3.Controls.Add(Me.TxtAval)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Lucida Bright", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(536, 44)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 186)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Aval"
        '
        'TxtAval
        '
        Me.TxtAval.Location = New System.Drawing.Point(135, 87)
        Me.TxtAval.Name = "TxtAval"
        Me.TxtAval.Size = New System.Drawing.Size(144, 23)
        Me.TxtAval.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Código Aval"
        '
        'BtnBuscarSocioAval
        '
        Me.BtnBuscarSocioAval.Location = New System.Drawing.Point(285, 88)
        Me.BtnBuscarSocioAval.Name = "BtnBuscarSocioAval"
        Me.BtnBuscarSocioAval.Size = New System.Drawing.Size(54, 22)
        Me.BtnBuscarSocioAval.TabIndex = 3
        Me.BtnBuscarSocioAval.Text = "..."
        Me.BtnBuscarSocioAval.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(321, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Buscar"
        '
        'TxtBuscarNumSolicitud
        '
        Me.TxtBuscarNumSolicitud.Location = New System.Drawing.Point(391, 25)
        Me.TxtBuscarNumSolicitud.Name = "TxtBuscarNumSolicitud"
        Me.TxtBuscarNumSolicitud.Size = New System.Drawing.Size(250, 22)
        Me.TxtBuscarNumSolicitud.TabIndex = 1
        '
        'LsvAvales
        '
        Me.LsvAvales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHNumSolicitud, Me.CHCodSocioAval})
        Me.LsvAvales.FullRowSelect = True
        Me.LsvAvales.GridLines = True
        Me.LsvAvales.Location = New System.Drawing.Point(284, 93)
        Me.LsvAvales.Name = "LsvAvales"
        Me.LsvAvales.Size = New System.Drawing.Size(404, 165)
        Me.LsvAvales.TabIndex = 2
        Me.LsvAvales.UseCompatibleStateImageBehavior = False
        Me.LsvAvales.View = System.Windows.Forms.View.Details
        '
        'CHNumSolicitud
        '
        Me.CHNumSolicitud.Text = "Número de Solicitud"
        Me.CHNumSolicitud.Width = 150
        '
        'CHCodSocioAval
        '
        Me.CHCodSocioAval.Text = "Socio-Aval"
        Me.CHCodSocioAval.Width = 150
        '
        'FrmAvales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 508)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TbMenu)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmAvales"
        Me.Text = "FrmAvales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TbMenu.ResumeLayout(False)
        Me.TbDatosAvales.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.TbListado.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TbMenu As TabControl
    Friend WithEvents TbDatosAvales As TabPage
    Friend WithEvents TbListado As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtAval As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtMostrarPrestamo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNumSolicitus As TextBox
    Friend WithEvents BtnBuscarSocioAval As Button
    Friend WithEvents LsvAvales As ListView
    Friend WithEvents CHNumSolicitud As ColumnHeader
    Friend WithEvents CHCodSocioAval As ColumnHeader
    Friend WithEvents TxtBuscarNumSolicitud As TextBox
    Friend WithEvents Label4 As Label
End Class
