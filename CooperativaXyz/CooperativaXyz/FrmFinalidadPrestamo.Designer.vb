<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFinalidadPrestamo
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
        Me.TbNacionalidades = New System.Windows.Forms.TabControl()
        Me.TbDatosNacionalidad = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtFinalidad = New System.Windows.Forms.TextBox()
        Me.TxtCodFinalidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbListadoNacionalidad = New System.Windows.Forms.TabPage()
        Me.TxtBuscarFinalidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LsvFinalidades = New System.Windows.Forms.ListView()
        Me.CHCodFinalidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHFinalidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNacionalidades.SuspendLayout()
        Me.TbDatosNacionalidad.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TbListadoNacionalidad.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbNacionalidades
        '
        Me.TbNacionalidades.Controls.Add(Me.TbDatosNacionalidad)
        Me.TbNacionalidades.Controls.Add(Me.TbListadoNacionalidad)
        Me.TbNacionalidades.Location = New System.Drawing.Point(-1, 108)
        Me.TbNacionalidades.Name = "TbNacionalidades"
        Me.TbNacionalidades.SelectedIndex = 0
        Me.TbNacionalidades.Size = New System.Drawing.Size(803, 341)
        Me.TbNacionalidades.TabIndex = 13
        '
        'TbDatosNacionalidad
        '
        Me.TbDatosNacionalidad.Controls.Add(Me.GroupBox1)
        Me.TbDatosNacionalidad.Controls.Add(Me.Panel2)
        Me.TbDatosNacionalidad.Location = New System.Drawing.Point(4, 22)
        Me.TbDatosNacionalidad.Name = "TbDatosNacionalidad"
        Me.TbDatosNacionalidad.Padding = New System.Windows.Forms.Padding(3)
        Me.TbDatosNacionalidad.Size = New System.Drawing.Size(795, 315)
        Me.TbDatosNacionalidad.TabIndex = 0
        Me.TbDatosNacionalidad.Text = "Datos Nacionalidad"
        Me.TbDatosNacionalidad.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(785, 110)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnSalir.Location = New System.Drawing.Point(646, 28)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 50)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnCancelar.Location = New System.Drawing.Point(495, 28)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 50)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnModificar.Location = New System.Drawing.Point(346, 28)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 50)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnGuardar.Location = New System.Drawing.Point(179, 28)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 50)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnNuevo.Location = New System.Drawing.Point(26, 28)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 50)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.TxtFinalidad)
        Me.Panel2.Controls.Add(Me.TxtCodFinalidad)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 122)
        Me.Panel2.TabIndex = 10
        '
        'TxtFinalidad
        '
        Me.TxtFinalidad.Location = New System.Drawing.Point(372, 69)
        Me.TxtFinalidad.Multiline = True
        Me.TxtFinalidad.Name = "TxtFinalidad"
        Me.TxtFinalidad.Size = New System.Drawing.Size(189, 33)
        Me.TxtFinalidad.TabIndex = 6
        '
        'TxtCodFinalidad
        '
        Me.TxtCodFinalidad.Location = New System.Drawing.Point(372, 22)
        Me.TxtCodFinalidad.Multiline = True
        Me.TxtCodFinalidad.Name = "TxtCodFinalidad"
        Me.TxtCodFinalidad.Size = New System.Drawing.Size(189, 33)
        Me.TxtCodFinalidad.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(165, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Finalidad Prestamo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(88, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código Finalidad Prestamo"
        '
        'TbListadoNacionalidad
        '
        Me.TbListadoNacionalidad.Controls.Add(Me.TxtBuscarFinalidad)
        Me.TbListadoNacionalidad.Controls.Add(Me.Label4)
        Me.TbListadoNacionalidad.Controls.Add(Me.LsvFinalidades)
        Me.TbListadoNacionalidad.Location = New System.Drawing.Point(4, 22)
        Me.TbListadoNacionalidad.Name = "TbListadoNacionalidad"
        Me.TbListadoNacionalidad.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListadoNacionalidad.Size = New System.Drawing.Size(795, 315)
        Me.TbListadoNacionalidad.TabIndex = 1
        Me.TbListadoNacionalidad.Text = "Listado"
        Me.TbListadoNacionalidad.UseVisualStyleBackColor = True
        '
        'TxtBuscarFinalidad
        '
        Me.TxtBuscarFinalidad.Location = New System.Drawing.Point(289, 46)
        Me.TxtBuscarFinalidad.Name = "TxtBuscarFinalidad"
        Me.TxtBuscarFinalidad.Size = New System.Drawing.Size(272, 20)
        Me.TxtBuscarFinalidad.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(185, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Buscar"
        '
        'LsvFinalidades
        '
        Me.LsvFinalidades.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHCodFinalidad, Me.CHFinalidad})
        Me.LsvFinalidades.GridLines = True
        Me.LsvFinalidades.Location = New System.Drawing.Point(176, 104)
        Me.LsvFinalidades.Name = "LsvFinalidades"
        Me.LsvFinalidades.Size = New System.Drawing.Size(464, 188)
        Me.LsvFinalidades.TabIndex = 0
        Me.LsvFinalidades.UseCompatibleStateImageBehavior = False
        Me.LsvFinalidades.View = System.Windows.Forms.View.Details
        '
        'CHCodFinalidad
        '
        Me.CHCodFinalidad.Text = "CóDigo Finalidad"
        Me.CHCodFinalidad.Width = 150
        '
        'CHFinalidad
        '
        Me.CHFinalidad.Text = "Finalidad"
        Me.CHFinalidad.Width = 150
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 100)
        Me.Panel1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(214, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(425, 40)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Finalidad del Prestamo"
        '
        'FrmFinalidadPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TbNacionalidades)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmFinalidadPrestamo"
        Me.Text = "FrmFinalidadPrestamo"
        Me.TbNacionalidades.ResumeLayout(False)
        Me.TbDatosNacionalidad.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TbListadoNacionalidad.ResumeLayout(False)
        Me.TbListadoNacionalidad.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TbNacionalidades As TabControl
    Friend WithEvents TbDatosNacionalidad As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtFinalidad As TextBox
    Friend WithEvents TxtCodFinalidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbListadoNacionalidad As TabPage
    Friend WithEvents TxtBuscarFinalidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LsvFinalidades As ListView
    Friend WithEvents CHCodFinalidad As ColumnHeader
    Friend WithEvents CHFinalidad As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
