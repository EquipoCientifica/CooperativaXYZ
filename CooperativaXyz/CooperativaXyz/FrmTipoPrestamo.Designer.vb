<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoPrestamo
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
        Me.TbDatosTipoPrestamo = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtTipoPrestamo = New System.Windows.Forms.TextBox()
        Me.TxtCodTipoPrestamo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbListadoTipoPrestamo = New System.Windows.Forms.TabPage()
        Me.TxtBuscarTipoPrestamo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LsvTipoPrestamo = New System.Windows.Forms.ListView()
        Me.CHCodTipoPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHTipoPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNacionalidades.SuspendLayout()
        Me.TbDatosTipoPrestamo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TbListadoTipoPrestamo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbNacionalidades
        '
        Me.TbNacionalidades.Controls.Add(Me.TbDatosTipoPrestamo)
        Me.TbNacionalidades.Controls.Add(Me.TbListadoTipoPrestamo)
        Me.TbNacionalidades.Location = New System.Drawing.Point(27, 108)
        Me.TbNacionalidades.Name = "TbNacionalidades"
        Me.TbNacionalidades.SelectedIndex = 0
        Me.TbNacionalidades.Size = New System.Drawing.Size(803, 341)
        Me.TbNacionalidades.TabIndex = 13
        '
        'TbDatosTipoPrestamo
        '
        Me.TbDatosTipoPrestamo.Controls.Add(Me.GroupBox1)
        Me.TbDatosTipoPrestamo.Controls.Add(Me.Panel2)
        Me.TbDatosTipoPrestamo.Location = New System.Drawing.Point(4, 22)
        Me.TbDatosTipoPrestamo.Name = "TbDatosTipoPrestamo"
        Me.TbDatosTipoPrestamo.Padding = New System.Windows.Forms.Padding(3)
        Me.TbDatosTipoPrestamo.Size = New System.Drawing.Size(795, 315)
        Me.TbDatosTipoPrestamo.TabIndex = 0
        Me.TbDatosTipoPrestamo.Text = "Datos Tipo Prestamo"
        Me.TbDatosTipoPrestamo.UseVisualStyleBackColor = True
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
        Me.Panel2.Controls.Add(Me.TxtTipoPrestamo)
        Me.Panel2.Controls.Add(Me.TxtCodTipoPrestamo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 122)
        Me.Panel2.TabIndex = 10
        '
        'TxtTipoPrestamo
        '
        Me.TxtTipoPrestamo.Location = New System.Drawing.Point(372, 69)
        Me.TxtTipoPrestamo.Multiline = True
        Me.TxtTipoPrestamo.Name = "TxtTipoPrestamo"
        Me.TxtTipoPrestamo.Size = New System.Drawing.Size(189, 33)
        Me.TxtTipoPrestamo.TabIndex = 6
        '
        'TxtCodTipoPrestamo
        '
        Me.TxtCodTipoPrestamo.Location = New System.Drawing.Point(372, 22)
        Me.TxtCodTipoPrestamo.Multiline = True
        Me.TxtCodTipoPrestamo.Name = "TxtCodTipoPrestamo"
        Me.TxtCodTipoPrestamo.Size = New System.Drawing.Size(189, 33)
        Me.TxtCodTipoPrestamo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(205, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tipo Prestamo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(128, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código Tipo Prestamo"
        '
        'TbListadoTipoPrestamo
        '
        Me.TbListadoTipoPrestamo.Controls.Add(Me.TxtBuscarTipoPrestamo)
        Me.TbListadoTipoPrestamo.Controls.Add(Me.Label4)
        Me.TbListadoTipoPrestamo.Controls.Add(Me.LsvTipoPrestamo)
        Me.TbListadoTipoPrestamo.Location = New System.Drawing.Point(4, 22)
        Me.TbListadoTipoPrestamo.Name = "TbListadoTipoPrestamo"
        Me.TbListadoTipoPrestamo.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListadoTipoPrestamo.Size = New System.Drawing.Size(795, 315)
        Me.TbListadoTipoPrestamo.TabIndex = 1
        Me.TbListadoTipoPrestamo.Text = "Listado"
        Me.TbListadoTipoPrestamo.UseVisualStyleBackColor = True
        '
        'TxtBuscarTipoPrestamo
        '
        Me.TxtBuscarTipoPrestamo.Location = New System.Drawing.Point(289, 46)
        Me.TxtBuscarTipoPrestamo.Name = "TxtBuscarTipoPrestamo"
        Me.TxtBuscarTipoPrestamo.Size = New System.Drawing.Size(272, 20)
        Me.TxtBuscarTipoPrestamo.TabIndex = 2
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
        'LsvTipoPrestamo
        '
        Me.LsvTipoPrestamo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHCodTipoPrestamo, Me.CHTipoPrestamo})
        Me.LsvTipoPrestamo.GridLines = True
        Me.LsvTipoPrestamo.Location = New System.Drawing.Point(176, 104)
        Me.LsvTipoPrestamo.Name = "LsvTipoPrestamo"
        Me.LsvTipoPrestamo.Size = New System.Drawing.Size(464, 188)
        Me.LsvTipoPrestamo.TabIndex = 0
        Me.LsvTipoPrestamo.UseCompatibleStateImageBehavior = False
        Me.LsvTipoPrestamo.View = System.Windows.Forms.View.Details
        '
        'CHCodTipoPrestamo
        '
        Me.CHCodTipoPrestamo.Text = "Código Tipo Prestamo"
        Me.CHCodTipoPrestamo.Width = 150
        '
        'CHTipoPrestamo
        '
        Me.CHTipoPrestamo.Text = "Tipo Prestamo"
        Me.CHTipoPrestamo.Width = 150
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(27, 2)
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
        Me.Label3.Size = New System.Drawing.Size(263, 40)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "TipoPrestamo"
        '
        'FrmTipoPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 450)
        Me.Controls.Add(Me.TbNacionalidades)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmTipoPrestamo"
        Me.Text = "FrmTipoPrestamo"
        Me.TbNacionalidades.ResumeLayout(False)
        Me.TbDatosTipoPrestamo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TbListadoTipoPrestamo.ResumeLayout(False)
        Me.TbListadoTipoPrestamo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TbNacionalidades As TabControl
    Friend WithEvents TbDatosTipoPrestamo As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtTipoPrestamo As TextBox
    Friend WithEvents TxtCodTipoPrestamo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbListadoTipoPrestamo As TabPage
    Friend WithEvents TxtBuscarTipoPrestamo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LsvTipoPrestamo As ListView
    Friend WithEvents CHCodTipoPrestamo As ColumnHeader
    Friend WithEvents CHTipoPrestamo As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
