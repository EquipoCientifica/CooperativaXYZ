<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLugarTrabajo
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
        Me.TcLugarTrabajo = New System.Windows.Forms.TabControl()
        Me.TpLugarTrabajo = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtLugar = New System.Windows.Forms.TextBox()
        Me.TxtCodigoLugar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TpLista = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.LsvLugarTrabajo = New System.Windows.Forms.ListView()
        Me.ChCodigoLugarTrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChLugarTrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TcLugarTrabajo.SuspendLayout()
        Me.TpLugarTrabajo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TpLista.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.CmOpciones.SuspendLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TcLugarTrabajo
        '
        Me.TcLugarTrabajo.Controls.Add(Me.TpLugarTrabajo)
        Me.TcLugarTrabajo.Controls.Add(Me.TpLista)
        Me.TcLugarTrabajo.Location = New System.Drawing.Point(6, 117)
        Me.TcLugarTrabajo.Name = "TcLugarTrabajo"
        Me.TcLugarTrabajo.SelectedIndex = 0
        Me.TcLugarTrabajo.Size = New System.Drawing.Size(821, 322)
        Me.TcLugarTrabajo.TabIndex = 11
        '
        'TpLugarTrabajo
        '
        Me.TpLugarTrabajo.Controls.Add(Me.GroupBox1)
        Me.TpLugarTrabajo.Controls.Add(Me.Panel2)
        Me.TpLugarTrabajo.Location = New System.Drawing.Point(4, 22)
        Me.TpLugarTrabajo.Name = "TpLugarTrabajo"
        Me.TpLugarTrabajo.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLugarTrabajo.Size = New System.Drawing.Size(813, 296)
        Me.TpLugarTrabajo.TabIndex = 0
        Me.TpLugarTrabajo.Text = "Lugar de trabajo"
        Me.TpLugarTrabajo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(785, 110)
        Me.GroupBox1.TabIndex = 12
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
        Me.Panel2.Controls.Add(Me.TxtLugar)
        Me.Panel2.Controls.Add(Me.TxtCodigoLugar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 122)
        Me.Panel2.TabIndex = 11
        '
        'TxtLugar
        '
        Me.TxtLugar.Location = New System.Drawing.Point(396, 71)
        Me.TxtLugar.Multiline = True
        Me.TxtLugar.Name = "TxtLugar"
        Me.TxtLugar.Size = New System.Drawing.Size(189, 33)
        Me.TxtLugar.TabIndex = 6
        '
        'TxtCodigoLugar
        '
        Me.TxtCodigoLugar.Location = New System.Drawing.Point(396, 28)
        Me.TxtCodigoLugar.Multiline = True
        Me.TxtCodigoLugar.Name = "TxtCodigoLugar"
        Me.TxtCodigoLugar.Size = New System.Drawing.Size(189, 33)
        Me.TxtCodigoLugar.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(184, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lugar de Trabajo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(107, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código Lugar de Trabajo"
        '
        'TpLista
        '
        Me.TpLista.Controls.Add(Me.Label12)
        Me.TpLista.Controls.Add(Me.TxtBuscar)
        Me.TpLista.Controls.Add(Me.LsvLugarTrabajo)
        Me.TpLista.Location = New System.Drawing.Point(4, 22)
        Me.TpLista.Name = "TpLista"
        Me.TpLista.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLista.Size = New System.Drawing.Size(813, 296)
        Me.TpLista.TabIndex = 1
        Me.TpLista.Text = "Listado"
        Me.TpLista.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(227, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Buscar:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(318, 23)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(216, 20)
        Me.TxtBuscar.TabIndex = 4
        '
        'LsvLugarTrabajo
        '
        Me.LsvLugarTrabajo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodigoLugarTrabajo, Me.ChLugarTrabajo})
        Me.LsvLugarTrabajo.FullRowSelect = True
        Me.LsvLugarTrabajo.GridLines = True
        Me.LsvLugarTrabajo.Location = New System.Drawing.Point(209, 68)
        Me.LsvLugarTrabajo.Name = "LsvLugarTrabajo"
        Me.LsvLugarTrabajo.Size = New System.Drawing.Size(380, 199)
        Me.LsvLugarTrabajo.TabIndex = 0
        Me.LsvLugarTrabajo.UseCompatibleStateImageBehavior = False
        Me.LsvLugarTrabajo.View = System.Windows.Forms.View.Details
        '
        'ChCodigoLugarTrabajo
        '
        Me.ChCodigoLugarTrabajo.Text = "Código Lugar Trabajo"
        Me.ChCodigoLugarTrabajo.Width = 120
        '
        'ChLugarTrabajo
        '
        Me.ChLugarTrabajo.Text = "Lugar Trabajo"
        Me.ChLugarTrabajo.Width = 200
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(6, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 100)
        Me.Panel1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(158, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(479, 40)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Gestión Lugar De Trabajo"
        '
        'CmOpciones
        '
        Me.CmOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmOpciones.Name = "CmOpciones"
        Me.CmOpciones.Size = New System.Drawing.Size(118, 48)
        '
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'FrmLugarTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 450)
        Me.ContextMenuStrip = Me.CmOpciones
        Me.Controls.Add(Me.TcLugarTrabajo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmLugarTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLugarTrabajo"
        Me.TcLugarTrabajo.ResumeLayout(False)
        Me.TpLugarTrabajo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TpLista.ResumeLayout(False)
        Me.TpLista.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CmOpciones.ResumeLayout(False)
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TcLugarTrabajo As TabControl
    Friend WithEvents TpLugarTrabajo As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtLugar As TextBox
    Friend WithEvents TxtCodigoLugar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TpLista As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents LsvLugarTrabajo As ListView
    Friend WithEvents ChCodigoLugarTrabajo As ColumnHeader
    Friend WithEvents ChLugarTrabajo As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CmOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EpMensaje As ErrorProvider
End Class
