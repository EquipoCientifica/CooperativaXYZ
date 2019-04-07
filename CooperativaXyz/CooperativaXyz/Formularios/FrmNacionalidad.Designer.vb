<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNacionalidad
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
        Me.components = New System.ComponentModel.Container()
        Me.TbNacionalidades = New System.Windows.Forms.TabControl()
        Me.TbDatosNacionalidad = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtNacionalidad = New System.Windows.Forms.TextBox()
        Me.TxtCodNacionalidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbListadoNacionalidad = New System.Windows.Forms.TabPage()
        Me.TxtBuscarNacionalidades = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LsvNacionalidades = New System.Windows.Forms.ListView()
        Me.CHCodNacionalidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHNacionalidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EpMensajeNacionalidad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CmsOpcionesNacionalidad = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbNacionalidades.SuspendLayout()
        Me.TbDatosNacionalidad.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TbListadoNacionalidad.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.EpMensajeNacionalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsOpcionesNacionalidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbNacionalidades
        '
        Me.TbNacionalidades.Controls.Add(Me.TbDatosNacionalidad)
        Me.TbNacionalidades.Controls.Add(Me.TbListadoNacionalidad)
        Me.TbNacionalidades.Location = New System.Drawing.Point(-1, 133)
        Me.TbNacionalidades.Margin = New System.Windows.Forms.Padding(4)
        Me.TbNacionalidades.Name = "TbNacionalidades"
        Me.TbNacionalidades.SelectedIndex = 0
        Me.TbNacionalidades.Size = New System.Drawing.Size(1071, 420)
        Me.TbNacionalidades.TabIndex = 11
        '
        'TbDatosNacionalidad
        '
        Me.TbDatosNacionalidad.Controls.Add(Me.GroupBox1)
        Me.TbDatosNacionalidad.Controls.Add(Me.Panel2)
        Me.TbDatosNacionalidad.Location = New System.Drawing.Point(4, 25)
        Me.TbDatosNacionalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDatosNacionalidad.Name = "TbDatosNacionalidad"
        Me.TbDatosNacionalidad.Padding = New System.Windows.Forms.Padding(4)
        Me.TbDatosNacionalidad.Size = New System.Drawing.Size(1063, 391)
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 202)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1047, 135)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnSalir.Location = New System.Drawing.Point(861, 34)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(100, 62)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnCancelar.Location = New System.Drawing.Point(660, 34)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 62)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnModificar.Location = New System.Drawing.Point(461, 34)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(100, 62)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnGuardar.Location = New System.Drawing.Point(239, 34)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 62)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnNuevo.Location = New System.Drawing.Point(35, 34)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(100, 62)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.TxtNacionalidad)
        Me.Panel2.Controls.Add(Me.TxtCodNacionalidad)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(4, 32)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1052, 150)
        Me.Panel2.TabIndex = 10
        '
        'TxtNacionalidad
        '
        Me.TxtNacionalidad.Location = New System.Drawing.Point(496, 85)
        Me.TxtNacionalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNacionalidad.Multiline = True
        Me.TxtNacionalidad.Name = "TxtNacionalidad"
        Me.TxtNacionalidad.Size = New System.Drawing.Size(251, 40)
        Me.TxtNacionalidad.TabIndex = 6
        '
        'TxtCodNacionalidad
        '
        Me.TxtCodNacionalidad.Location = New System.Drawing.Point(496, 27)
        Me.TxtCodNacionalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodNacionalidad.Multiline = True
        Me.TxtCodNacionalidad.Name = "TxtCodNacionalidad"
        Me.TxtCodNacionalidad.Size = New System.Drawing.Size(251, 40)
        Me.TxtCodNacionalidad.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(273, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nacionalidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(171, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código Nacionalidad"
        '
        'TbListadoNacionalidad
        '
        Me.TbListadoNacionalidad.Controls.Add(Me.TxtBuscarNacionalidades)
        Me.TbListadoNacionalidad.Controls.Add(Me.Label4)
        Me.TbListadoNacionalidad.Controls.Add(Me.LsvNacionalidades)
        Me.TbListadoNacionalidad.Location = New System.Drawing.Point(4, 25)
        Me.TbListadoNacionalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TbListadoNacionalidad.Name = "TbListadoNacionalidad"
        Me.TbListadoNacionalidad.Padding = New System.Windows.Forms.Padding(4)
        Me.TbListadoNacionalidad.Size = New System.Drawing.Size(1063, 391)
        Me.TbListadoNacionalidad.TabIndex = 1
        Me.TbListadoNacionalidad.Text = "Listado"
        Me.TbListadoNacionalidad.UseVisualStyleBackColor = True
        '
        'TxtBuscarNacionalidades
        '
        Me.TxtBuscarNacionalidades.Location = New System.Drawing.Point(385, 57)
        Me.TxtBuscarNacionalidades.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBuscarNacionalidades.Name = "TxtBuscarNacionalidades"
        Me.TxtBuscarNacionalidades.Size = New System.Drawing.Size(361, 22)
        Me.TxtBuscarNacionalidades.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(247, 63)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Buscar"
        '
        'LsvNacionalidades
        '
        Me.LsvNacionalidades.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHCodNacionalidad, Me.CHNacionalidad})
        Me.LsvNacionalidades.ContextMenuStrip = Me.CmsOpcionesNacionalidad
        Me.LsvNacionalidades.FullRowSelect = True
        Me.LsvNacionalidades.GridLines = True
        Me.LsvNacionalidades.Location = New System.Drawing.Point(235, 128)
        Me.LsvNacionalidades.Margin = New System.Windows.Forms.Padding(4)
        Me.LsvNacionalidades.Name = "LsvNacionalidades"
        Me.LsvNacionalidades.Size = New System.Drawing.Size(617, 230)
        Me.LsvNacionalidades.TabIndex = 0
        Me.LsvNacionalidades.UseCompatibleStateImageBehavior = False
        Me.LsvNacionalidades.View = System.Windows.Forms.View.Details
        '
        'CHCodNacionalidad
        '
        Me.CHCodNacionalidad.Text = "Código Nacionalidad"
        Me.CHCodNacionalidad.Width = 150
        '
        'CHNacionalidad
        '
        Me.CHNacionalidad.Text = "Nacionalidad"
        Me.CHNacionalidad.Width = 150
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-1, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1071, 123)
        Me.Panel1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(362, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(317, 51)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nacionalidad"
        '
        'EpMensajeNacionalidad
        '
        Me.EpMensajeNacionalidad.ContainerControl = Me
        '
        'CmsOpcionesNacionalidad
        '
        Me.CmsOpcionesNacionalidad.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsOpcionesNacionalidad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsOpcionesNacionalidad.Name = "CmsOpcionesNacionalidad"
        Me.CmsOpcionesNacionalidad.Size = New System.Drawing.Size(133, 52)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'FrmNacionalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.TbNacionalidades)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmNacionalidad"
        Me.Text = "FrmNacionalidad"
        Me.TbNacionalidades.ResumeLayout(False)
        Me.TbDatosNacionalidad.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TbListadoNacionalidad.ResumeLayout(False)
        Me.TbListadoNacionalidad.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EpMensajeNacionalidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsOpcionesNacionalidad.ResumeLayout(False)
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
    Friend WithEvents TxtNacionalidad As TextBox
    Friend WithEvents TxtCodNacionalidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbListadoNacionalidad As TabPage
    Friend WithEvents TxtBuscarNacionalidades As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LsvNacionalidades As ListView
    Friend WithEvents CHCodNacionalidad As ColumnHeader
    Friend WithEvents CHNacionalidad As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents EpMensajeNacionalidad As ErrorProvider
    Friend WithEvents CmsOpcionesNacionalidad As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
