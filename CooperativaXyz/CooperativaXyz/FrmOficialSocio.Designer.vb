﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOficialSocio
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
        Me.TbDatosOficial = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnTipoCuenta = New System.Windows.Forms.TextBox()
        Me.TxtCodigoOficialCredito = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbListadoOficiales = New System.Windows.Forms.TabPage()
        Me.TxtBuscarOficiales = New System.Windows.Forms.TextBox()
        Me.LsvOficiales = New System.Windows.Forms.ListView()
        Me.CHCodOficial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHApellidos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbDatosOficial.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TbListadoOficiales.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbDatosOficial
        '
        Me.TbDatosOficial.Controls.Add(Me.TabPage1)
        Me.TbDatosOficial.Controls.Add(Me.TbListadoOficiales)
        Me.TbDatosOficial.Location = New System.Drawing.Point(11, 109)
        Me.TbDatosOficial.Name = "TbDatosOficial"
        Me.TbDatosOficial.SelectedIndex = 0
        Me.TbDatosOficial.Size = New System.Drawing.Size(830, 320)
        Me.TbDatosOficial.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(822, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos del Oficial"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Size = New System.Drawing.Size(803, 110)
        Me.GroupBox1.TabIndex = 14
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
        Me.Panel2.Controls.Add(Me.TxtApellido)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.BtnTipoCuenta)
        Me.Panel2.Controls.Add(Me.TxtCodigoOficialCredito)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(6, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 122)
        Me.Panel2.TabIndex = 11
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(396, 89)
        Me.TxtApellido.Multiline = True
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(189, 23)
        Me.TxtApellido.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(264, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Apellido"
        '
        'BtnTipoCuenta
        '
        Me.BtnTipoCuenta.Location = New System.Drawing.Point(396, 52)
        Me.BtnTipoCuenta.Multiline = True
        Me.BtnTipoCuenta.Name = "BtnTipoCuenta"
        Me.BtnTipoCuenta.Size = New System.Drawing.Size(189, 23)
        Me.BtnTipoCuenta.TabIndex = 6
        '
        'TxtCodigoOficialCredito
        '
        Me.TxtCodigoOficialCredito.Location = New System.Drawing.Point(396, 14)
        Me.TxtCodigoOficialCredito.Multiline = True
        Me.TxtCodigoOficialCredito.Name = "TxtCodigoOficialCredito"
        Me.TxtCodigoOficialCredito.Size = New System.Drawing.Size(189, 23)
        Me.TxtCodigoOficialCredito.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(264, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(125, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código Oficial Crédito"
        '
        'TbListadoOficiales
        '
        Me.TbListadoOficiales.Controls.Add(Me.TxtBuscarOficiales)
        Me.TbListadoOficiales.Controls.Add(Me.LsvOficiales)
        Me.TbListadoOficiales.Controls.Add(Me.Label5)
        Me.TbListadoOficiales.Location = New System.Drawing.Point(4, 22)
        Me.TbListadoOficiales.Name = "TbListadoOficiales"
        Me.TbListadoOficiales.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListadoOficiales.Size = New System.Drawing.Size(822, 294)
        Me.TbListadoOficiales.TabIndex = 1
        Me.TbListadoOficiales.Text = "Listado"
        Me.TbListadoOficiales.UseVisualStyleBackColor = True
        '
        'TxtBuscarOficiales
        '
        Me.TxtBuscarOficiales.Location = New System.Drawing.Point(279, 30)
        Me.TxtBuscarOficiales.Name = "TxtBuscarOficiales"
        Me.TxtBuscarOficiales.Size = New System.Drawing.Size(272, 20)
        Me.TxtBuscarOficiales.TabIndex = 12
        '
        'LsvOficiales
        '
        Me.LsvOficiales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHCodOficial, Me.CHNombre, Me.CHApellidos})
        Me.LsvOficiales.GridLines = True
        Me.LsvOficiales.Location = New System.Drawing.Point(166, 88)
        Me.LsvOficiales.Name = "LsvOficiales"
        Me.LsvOficiales.Size = New System.Drawing.Size(464, 188)
        Me.LsvOficiales.TabIndex = 10
        Me.LsvOficiales.UseCompatibleStateImageBehavior = False
        Me.LsvOficiales.View = System.Windows.Forms.View.Details
        '
        'CHCodOficial
        '
        Me.CHCodOficial.Text = "Código Oficiales"
        Me.CHCodOficial.Width = 150
        '
        'CHNombre
        '
        Me.CHNombre.Text = "Nombre"
        Me.CHNombre.Width = 150
        '
        'CHApellidos
        '
        Me.CHApellidos.Text = "Apellidos"
        Me.CHApellidos.Width = 150
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(175, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Buscar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 100)
        Me.Panel1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(235, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 40)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Oficial Credito"
        '
        'FrmOficialSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 450)
        Me.Controls.Add(Me.TbDatosOficial)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmOficialSocio"
        Me.Text = "FrmOficialSocio"
        Me.TbDatosOficial.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TbListadoOficiales.ResumeLayout(False)
        Me.TbListadoOficiales.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TbDatosOficial As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnTipoCuenta As TextBox
    Friend WithEvents TxtCodigoOficialCredito As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbListadoOficiales As TabPage
    Friend WithEvents TxtBuscarOficiales As TextBox
    Friend WithEvents LsvOficiales As ListView
    Friend WithEvents CHCodOficial As ColumnHeader
    Friend WithEvents CHNombre As ColumnHeader
    Friend WithEvents CHApellidos As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
