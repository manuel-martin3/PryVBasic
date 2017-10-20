<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleCRUD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.cmb_data = New System.Windows.Forms.ComboBox()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_ape = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btn_search)
        Me.groupBox1.Controls.Add(Me.btn_delete)
        Me.groupBox1.Controls.Add(Me.btn_insert)
        Me.groupBox1.Controls.Add(Me.btn_update)
        Me.groupBox1.Location = New System.Drawing.Point(406, 159)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(88, 158)
        Me.groupBox1.TabIndex = 19
        Me.groupBox1.TabStop = False
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(6, 18)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 0
        Me.btn_search.Text = "Buscar"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(6, 47)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 0
        Me.btn_delete.Text = "Eliminar"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(6, 76)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert.TabIndex = 0
        Me.btn_insert.Text = "Ingresar"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(6, 105)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 0
        Me.btn_update.Text = "Actualizar"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(69, 15)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(340, 44)
        Me.label5.TabIndex = 18
        Me.label5.Text = "Ficha de Alumnos"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(247, 114)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(26, 13)
        Me.label2.TabIndex = 14
        Me.label2.Text = "DNI"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(22, 114)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(49, 13)
        Me.label4.TabIndex = 15
        Me.label4.Text = "Nombres"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(53, 88)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(18, 13)
        Me.label3.TabIndex = 16
        Me.label3.Text = "ID"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(224, 88)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 13)
        Me.label1.TabIndex = 17
        Me.label1.Text = "Apellidos"
        '
        'dgv_detalle
        '
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Location = New System.Drawing.Point(21, 166)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.Size = New System.Drawing.Size(379, 150)
        Me.dgv_detalle.TabIndex = 13
        '
        'cmb_data
        '
        Me.cmb_data.FormattingEnabled = True
        Me.cmb_data.Location = New System.Drawing.Point(77, 139)
        Me.cmb_data.Name = "cmb_data"
        Me.cmb_data.Size = New System.Drawing.Size(121, 21)
        Me.cmb_data.TabIndex = 12
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(279, 111)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(121, 20)
        Me.txt_dni.TabIndex = 8
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(77, 111)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(121, 20)
        Me.txt_nom.TabIndex = 9
        '
        'txt_ape
        '
        Me.txt_ape.Location = New System.Drawing.Point(279, 85)
        Me.txt_ape.Name = "txt_ape"
        Me.txt_ape.Size = New System.Drawing.Size(121, 20)
        Me.txt_ape.TabIndex = 10
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(77, 85)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(121, 20)
        Me.txt_id.TabIndex = 11
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.btn_exit)
        Me.groupBox2.Controls.Add(Me.btn_cancel)
        Me.groupBox2.Controls.Add(Me.btn_new)
        Me.groupBox2.Location = New System.Drawing.Point(21, 315)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(473, 43)
        Me.groupBox2.TabIndex = 20
        Me.groupBox2.TabStop = False
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(168, 14)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 0
        Me.btn_exit.Text = "Salir"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(6, 14)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 0
        Me.btn_cancel.Text = "Cancelar"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(87, 14)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 23)
        Me.btn_new.TabIndex = 0
        Me.btn_new.Text = "Nuevo"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'SimpleCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 372)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dgv_detalle)
        Me.Controls.Add(Me.cmb_data)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.txt_ape)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.groupBox2)
        Me.Name = "SimpleCRUD"
        Me.Text = "Simple_CRUD"
        Me.groupBox1.ResumeLayout(False)
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btn_search As System.Windows.Forms.Button
    Private WithEvents btn_delete As System.Windows.Forms.Button
    Private WithEvents btn_insert As System.Windows.Forms.Button
    Private WithEvents btn_update As System.Windows.Forms.Button
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Private WithEvents cmb_data As System.Windows.Forms.ComboBox
    Private WithEvents txt_dni As System.Windows.Forms.TextBox
    Private WithEvents txt_nom As System.Windows.Forms.TextBox
    Private WithEvents txt_ape As System.Windows.Forms.TextBox
    Private WithEvents txt_id As System.Windows.Forms.TextBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents btn_exit As System.Windows.Forms.Button
    Private WithEvents btn_cancel As System.Windows.Forms.Button
    Private WithEvents btn_new As System.Windows.Forms.Button

End Class
