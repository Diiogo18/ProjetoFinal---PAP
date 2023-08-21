<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.components = New System.ComponentModel.Container()
        Dim AnoLabel As System.Windows.Forms.Label
        Dim SiglaLabel As System.Windows.Forms.Label
        Dim CursoLabel As System.Windows.Forms.Label
        Dim Diretor_TurmaLabel As System.Windows.Forms.Label
        Me.EscolaDataSet = New ProjetoFinal.EscolaDataSet()
        Me.TurmasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurmasTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.TurmasTableAdapter()
        Me.TableAdapterManager = New ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager()
        Me.CursosTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.CursosTableAdapter()
        Me.ID_TurmaTextBox = New System.Windows.Forms.TextBox()
        Me.AnoTextBox = New System.Windows.Forms.TextBox()
        Me.SiglaTextBox = New System.Windows.Forms.TextBox()
        Me.Diretor_TurmaTextBox = New System.Windows.Forms.TextBox()
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nome_CursoTextBox = New System.Windows.Forms.TextBox()
        Me.CursoComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        AnoLabel = New System.Windows.Forms.Label()
        SiglaLabel = New System.Windows.Forms.Label()
        CursoLabel = New System.Windows.Forms.Label()
        Diretor_TurmaLabel = New System.Windows.Forms.Label()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnoLabel
        '
        AnoLabel.AutoSize = True
        AnoLabel.Location = New System.Drawing.Point(139, 104)
        AnoLabel.Name = "AnoLabel"
        AnoLabel.Size = New System.Drawing.Size(29, 13)
        AnoLabel.TabIndex = 3
        AnoLabel.Text = "Ano:"
        '
        'SiglaLabel
        '
        SiglaLabel.AutoSize = True
        SiglaLabel.Location = New System.Drawing.Point(139, 130)
        SiglaLabel.Name = "SiglaLabel"
        SiglaLabel.Size = New System.Drawing.Size(33, 13)
        SiglaLabel.TabIndex = 5
        SiglaLabel.Text = "Sigla:"
        '
        'CursoLabel
        '
        CursoLabel.AutoSize = True
        CursoLabel.Location = New System.Drawing.Point(139, 156)
        CursoLabel.Name = "CursoLabel"
        CursoLabel.Size = New System.Drawing.Size(37, 13)
        CursoLabel.TabIndex = 7
        CursoLabel.Text = "Curso:"
        '
        'Diretor_TurmaLabel
        '
        Diretor_TurmaLabel.AutoSize = True
        Diretor_TurmaLabel.Location = New System.Drawing.Point(139, 182)
        Diretor_TurmaLabel.Name = "Diretor_TurmaLabel"
        Diretor_TurmaLabel.Size = New System.Drawing.Size(74, 13)
        Diretor_TurmaLabel.TabIndex = 9
        Diretor_TurmaLabel.Text = "Diretor-Turma:"
        '
        'EscolaDataSet
        '
        Me.EscolaDataSet.DataSetName = "EscolaDataSet"
        Me.EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TurmasBindingSource
        '
        Me.TurmasBindingSource.DataMember = "Turmas"
        Me.TurmasBindingSource.DataSource = Me.EscolaDataSet
        '
        'TurmasTableAdapter
        '
        Me.TurmasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.Aluno_AvaliaçãoTableAdapter = Nothing
        Me.TableAdapterManager.AlunosTableAdapter = Nothing
        Me.TableAdapterManager.AvaliaçõesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CursosTableAdapter = Me.CursosTableAdapter
        Me.TableAdapterManager.DisciplinasTableAdapter = Nothing
        Me.TableAdapterManager.Modulo_DisciplinaTableAdapter = Nothing
        Me.TableAdapterManager.ModuloTableAdapter = Nothing
        Me.TableAdapterManager.PresençasTableAdapter = Nothing
        Me.TableAdapterManager.ProfessoresTableAdapter = Nothing
        Me.TableAdapterManager.Turma_DisciplinaTableAdapter = Nothing
        Me.TableAdapterManager.TurmasTableAdapter = Me.TurmasTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CursosTableAdapter
        '
        Me.CursosTableAdapter.ClearBeforeFill = True
        '
        'ID_TurmaTextBox
        '
        Me.ID_TurmaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "ID_Turma", True))
        Me.ID_TurmaTextBox.Enabled = False
        Me.ID_TurmaTextBox.Location = New System.Drawing.Point(252, 75)
        Me.ID_TurmaTextBox.Name = "ID_TurmaTextBox"
        Me.ID_TurmaTextBox.Size = New System.Drawing.Size(28, 20)
        Me.ID_TurmaTextBox.TabIndex = 2
        Me.ID_TurmaTextBox.Visible = False
        '
        'AnoTextBox
        '
        Me.AnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Ano", True))
        Me.AnoTextBox.Enabled = False
        Me.AnoTextBox.Location = New System.Drawing.Point(219, 101)
        Me.AnoTextBox.Name = "AnoTextBox"
        Me.AnoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnoTextBox.TabIndex = 4
        '
        'SiglaTextBox
        '
        Me.SiglaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Sigla", True))
        Me.SiglaTextBox.Enabled = False
        Me.SiglaTextBox.Location = New System.Drawing.Point(219, 127)
        Me.SiglaTextBox.Name = "SiglaTextBox"
        Me.SiglaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SiglaTextBox.TabIndex = 6
        '
        'Diretor_TurmaTextBox
        '
        Me.Diretor_TurmaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Diretor-Turma", True))
        Me.Diretor_TurmaTextBox.Enabled = False
        Me.Diretor_TurmaTextBox.Location = New System.Drawing.Point(219, 179)
        Me.Diretor_TurmaTextBox.Name = "Diretor_TurmaTextBox"
        Me.Diretor_TurmaTextBox.Size = New System.Drawing.Size(170, 20)
        Me.Diretor_TurmaTextBox.TabIndex = 10
        '
        'CursosBindingSource
        '
        Me.CursosBindingSource.DataMember = "Cursos"
        Me.CursosBindingSource.DataSource = Me.EscolaDataSet
        '
        'Nome_CursoTextBox
        '
        Me.Nome_CursoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursosBindingSource, "Nome_Curso", True))
        Me.Nome_CursoTextBox.Enabled = False
        Me.Nome_CursoTextBox.Location = New System.Drawing.Point(270, 153)
        Me.Nome_CursoTextBox.Name = "Nome_CursoTextBox"
        Me.Nome_CursoTextBox.Size = New System.Drawing.Size(119, 20)
        Me.Nome_CursoTextBox.TabIndex = 11
        Me.Nome_CursoTextBox.Visible = False
        '
        'CursoComboBox
        '
        Me.CursoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Curso", True))
        Me.CursoComboBox.DataSource = Me.CursosBindingSource
        Me.CursoComboBox.DisplayMember = "ID_Curso"
        Me.CursoComboBox.Enabled = False
        Me.CursoComboBox.FormattingEnabled = True
        Me.CursoComboBox.Location = New System.Drawing.Point(219, 152)
        Me.CursoComboBox.Name = "CursoComboBox"
        Me.CursoComboBox.Size = New System.Drawing.Size(45, 21)
        Me.CursoComboBox.TabIndex = 12
        Me.CursoComboBox.ValueMember = "ID_Curso"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjetoFinal.My.Resources.Resources.undo
        Me.PictureBox1.Location = New System.Drawing.Point(522, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProjetoFinal.My.Resources.Resources._1
        Me.PictureBox2.Location = New System.Drawing.Point(128, 227)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProjetoFinal.My.Resources.Resources.back
        Me.PictureBox3.Location = New System.Drawing.Point(222, 227)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(57, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProjetoFinal.My.Resources.Resources._2
        Me.PictureBox4.Location = New System.Drawing.Point(303, 227)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(57, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ProjetoFinal.My.Resources.Resources.fast_forward
        Me.PictureBox5.Location = New System.Drawing.Point(389, 227)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(57, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 17
        Me.PictureBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(340, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Listagem"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Editar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(456, 354)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Guardar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(66, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Novo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.ProjetoFinal.My.Resources.Resources.check
        Me.PictureBox11.Location = New System.Drawing.Point(457, 304)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 60
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Visible = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.ProjetoFinal.My.Resources.Resources.list
        Me.PictureBox9.Location = New System.Drawing.Point(343, 304)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 59
        Me.PictureBox9.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.ProjetoFinal.My.Resources.Resources.lapis
        Me.PictureBox7.Location = New System.Drawing.Point(157, 304)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 58
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.ProjetoFinal.My.Resources.Resources.plus
        Me.PictureBox6.Location = New System.Drawing.Point(56, 304)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 57
        Me.PictureBox6.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.ProjetoFinal.My.Resources.Resources.save
        Me.PictureBox8.Location = New System.Drawing.Point(457, 304)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 65
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(216, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 34)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Turmas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(580, 399)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CursoComboBox)
        Me.Controls.Add(Me.Nome_CursoTextBox)
        Me.Controls.Add(Me.ID_TurmaTextBox)
        Me.Controls.Add(AnoLabel)
        Me.Controls.Add(Me.AnoTextBox)
        Me.Controls.Add(SiglaLabel)
        Me.Controls.Add(Me.SiglaTextBox)
        Me.Controls.Add(CursoLabel)
        Me.Controls.Add(Diretor_TurmaLabel)
        Me.Controls.Add(Me.Diretor_TurmaTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EscolaDataSet As EscolaDataSet
    Friend WithEvents TurmasBindingSource As BindingSource
    Friend WithEvents TurmasTableAdapter As EscolaDataSetTableAdapters.TurmasTableAdapter
    Friend WithEvents TableAdapterManager As EscolaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CursosTableAdapter As EscolaDataSetTableAdapters.CursosTableAdapter
    Friend WithEvents ID_TurmaTextBox As TextBox
    Friend WithEvents AnoTextBox As TextBox
    Friend WithEvents SiglaTextBox As TextBox
    Friend WithEvents Diretor_TurmaTextBox As TextBox
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents Nome_CursoTextBox As TextBox
    Friend WithEvents CursoComboBox As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label6 As Label
End Class
