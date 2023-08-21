<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EscolaDataSet = New ProjetoFinal.EscolaDataSet()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.AdminTableAdapter()
        Me.TableAdapterManager = New ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(139, 204)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(197, 20)
        Me.TextBox2.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(139, 132)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 20)
        Me.TextBox1.TabIndex = 13
        '
        'EscolaDataSet
        '
        Me.EscolaDataSet.DataSetName = "EscolaDataSet"
        Me.EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "Admin"
        Me.AdminBindingSource.DataSource = Me.EscolaDataSet
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Me.AdminTableAdapter
        Me.TableAdapterManager.Aluno_AvaliaçãoTableAdapter = Nothing
        Me.TableAdapterManager.AlunosTableAdapter = Nothing
        Me.TableAdapterManager.AvaliaçõesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.DisciplinasTableAdapter = Nothing
        Me.TableAdapterManager.Modulo_DisciplinaTableAdapter = Nothing
        Me.TableAdapterManager.ModuloTableAdapter = Nothing
        Me.TableAdapterManager.ProfessoresTableAdapter = Nothing
        Me.TableAdapterManager.Turma_DisciplinaTableAdapter = Nothing
        Me.TableAdapterManager.TurmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(-1, -1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(458, 58)
        Me.Label6.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(154, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 33)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Login Admin"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.ProjetoFinal.My.Resources.Resources._152533
        Me.PictureBox6.Location = New System.Drawing.Point(388, 279)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(56, 49)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 26
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ProjetoFinal.My.Resources.Resources.lock_password_protect_safety_security_icon_1320086045132546966
        Me.PictureBox5.Location = New System.Drawing.Point(50, 184)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(62, 49)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Image = Global.ProjetoFinal.My.Resources.Resources.transferir1
        Me.PictureBox1.Location = New System.Drawing.Point(50, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProjetoFinal.My.Resources.Resources.eye_slash_visible_hide_hidden_show_icon_145987
        Me.PictureBox3.Location = New System.Drawing.Point(315, 207)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 13)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProjetoFinal.My.Resources.Resources._1490793853_user_interface15_82360
        Me.PictureBox2.Location = New System.Drawing.Point(314, 207)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 13)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox4.Image = Global.ProjetoFinal.My.Resources.Resources.emblemunreadable_93487
        Me.PictureBox4.Location = New System.Drawing.Point(403, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(41, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(457, 340)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents EscolaDataSet As EscolaDataSet
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents AdminTableAdapter As EscolaDataSetTableAdapters.AdminTableAdapter
    Friend WithEvents TableAdapterManager As EscolaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox6 As PictureBox
End Class
