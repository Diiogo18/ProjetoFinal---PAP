<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form16
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
        Dim DisciplinaLabel As System.Windows.Forms.Label
        Dim AnoLabel As System.Windows.Forms.Label
        Dim SiglaLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim TurmaLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EscolaDataSet = New ProjetoFinal.EscolaDataSet()
        Me.Turma_DisciplinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Turma_DisciplinaTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.Turma_DisciplinaTableAdapter()
        Me.TableAdapterManager = New ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager()
        Me.TurmasTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.TurmasTableAdapter()
        Me.TurmasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DisciplinaComboBox = New System.Windows.Forms.ComboBox()
        Me.DisciplinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnoTextBox = New System.Windows.Forms.TextBox()
        Me.SiglaTextBox = New System.Windows.Forms.TextBox()
        Me.DisciplinasTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.DisciplinasTableAdapter()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TurmaComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        DisciplinaLabel = New System.Windows.Forms.Label()
        AnoLabel = New System.Windows.Forms.Label()
        SiglaLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        TurmaLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turma_DisciplinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisciplinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DisciplinaLabel
        '
        DisciplinaLabel.AutoSize = True
        DisciplinaLabel.Location = New System.Drawing.Point(147, 166)
        DisciplinaLabel.Name = "DisciplinaLabel"
        DisciplinaLabel.Size = New System.Drawing.Size(55, 13)
        DisciplinaLabel.TabIndex = 16
        DisciplinaLabel.Text = "Disciplina:"
        '
        'AnoLabel
        '
        AnoLabel.AutoSize = True
        AnoLabel.Location = New System.Drawing.Point(188, 108)
        AnoLabel.Name = "AnoLabel"
        AnoLabel.Size = New System.Drawing.Size(29, 13)
        AnoLabel.TabIndex = 17
        AnoLabel.Text = "Ano:"
        '
        'SiglaLabel
        '
        SiglaLabel.AutoSize = True
        SiglaLabel.Location = New System.Drawing.Point(184, 134)
        SiglaLabel.Name = "SiglaLabel"
        SiglaLabel.Size = New System.Drawing.Size(33, 13)
        SiglaLabel.TabIndex = 18
        SiglaLabel.Text = "Sigla:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(179, 204)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 19
        NomeLabel.Text = "Nome:"
        '
        'TurmaLabel
        '
        TurmaLabel.AutoSize = True
        TurmaLabel.Location = New System.Drawing.Point(162, 81)
        TurmaLabel.Name = "TurmaLabel"
        TurmaLabel.Size = New System.Drawing.Size(40, 13)
        TurmaLabel.TabIndex = 14
        TurmaLabel.Text = "Turma:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjetoFinal.My.Resources.Resources.undo
        Me.PictureBox1.Location = New System.Drawing.Point(443, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'EscolaDataSet
        '
        Me.EscolaDataSet.DataSetName = "EscolaDataSet"
        Me.EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Turma_DisciplinaBindingSource
        '
        Me.Turma_DisciplinaBindingSource.DataMember = "Turma/Disciplina"
        Me.Turma_DisciplinaBindingSource.DataSource = Me.EscolaDataSet
        '
        'Turma_DisciplinaTableAdapter
        '
        Me.Turma_DisciplinaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.Aluno_AvaliaçãoTableAdapter = Nothing
        Me.TableAdapterManager.AlunosTableAdapter = Nothing
        Me.TableAdapterManager.AvaliaçõesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.DisciplinasTableAdapter = Nothing
        Me.TableAdapterManager.Modulo_DisciplinaTableAdapter = Nothing
        Me.TableAdapterManager.ModuloTableAdapter = Nothing
        Me.TableAdapterManager.PresençasTableAdapter = Nothing
        Me.TableAdapterManager.ProfessoresTableAdapter = Nothing
        Me.TableAdapterManager.Turma_DisciplinaTableAdapter = Me.Turma_DisciplinaTableAdapter
        Me.TableAdapterManager.TurmasTableAdapter = Me.TurmasTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TurmasTableAdapter
        '
        Me.TurmasTableAdapter.ClearBeforeFill = True
        '
        'TurmasBindingSource
        '
        Me.TurmasBindingSource.DataMember = "Turmas"
        Me.TurmasBindingSource.DataSource = Me.EscolaDataSet
        '
        'DisciplinaComboBox
        '
        Me.DisciplinaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Turma_DisciplinaBindingSource, "Disciplina", True))
        Me.DisciplinaComboBox.DataSource = Me.DisciplinasBindingSource
        Me.DisciplinaComboBox.DisplayMember = "ID_disciplina"
        Me.DisciplinaComboBox.FormattingEnabled = True
        Me.DisciplinaComboBox.Location = New System.Drawing.Point(223, 163)
        Me.DisciplinaComboBox.Name = "DisciplinaComboBox"
        Me.DisciplinaComboBox.Size = New System.Drawing.Size(51, 21)
        Me.DisciplinaComboBox.TabIndex = 17
        Me.DisciplinaComboBox.ValueMember = "ID_disciplina"
        '
        'DisciplinasBindingSource
        '
        Me.DisciplinasBindingSource.DataMember = "Disciplinas"
        Me.DisciplinasBindingSource.DataSource = Me.EscolaDataSet
        '
        'AnoTextBox
        '
        Me.AnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Ano", True))
        Me.AnoTextBox.Enabled = False
        Me.AnoTextBox.Location = New System.Drawing.Point(223, 105)
        Me.AnoTextBox.Name = "AnoTextBox"
        Me.AnoTextBox.Size = New System.Drawing.Size(51, 20)
        Me.AnoTextBox.TabIndex = 18
        '
        'SiglaTextBox
        '
        Me.SiglaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Sigla", True))
        Me.SiglaTextBox.Enabled = False
        Me.SiglaTextBox.Location = New System.Drawing.Point(223, 131)
        Me.SiglaTextBox.Name = "SiglaTextBox"
        Me.SiglaTextBox.Size = New System.Drawing.Size(51, 20)
        Me.SiglaTextBox.TabIndex = 19
        '
        'DisciplinasTableAdapter
        '
        Me.DisciplinasTableAdapter.ClearBeforeFill = True
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DisciplinasBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(223, 201)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(132, 20)
        Me.NomeTextBox.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 34)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Turmas/Disciplinas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.ProjetoFinal.My.Resources.Resources.save
        Me.PictureBox8.Location = New System.Drawing.Point(402, 237)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 67
        Me.PictureBox8.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(401, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Guardar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Novo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProjetoFinal.My.Resources.Resources.plus
        Me.PictureBox4.Location = New System.Drawing.Point(38, 237)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(61, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 68
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'TurmaComboBox
        '
        Me.TurmaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Turma_DisciplinaBindingSource, "Turma", True))
        Me.TurmaComboBox.DataSource = Me.TurmasBindingSource
        Me.TurmaComboBox.DisplayMember = "ID_Turma"
        Me.TurmaComboBox.Enabled = False
        Me.TurmaComboBox.FormattingEnabled = True
        Me.TurmaComboBox.Location = New System.Drawing.Point(223, 78)
        Me.TurmaComboBox.Name = "TurmaComboBox"
        Me.TurmaComboBox.Size = New System.Drawing.Size(41, 21)
        Me.TurmaComboBox.TabIndex = 15
        Me.TurmaComboBox.ValueMember = "ID_Turma"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(291, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 20)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 332)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(SiglaLabel)
        Me.Controls.Add(Me.SiglaTextBox)
        Me.Controls.Add(AnoLabel)
        Me.Controls.Add(Me.AnoTextBox)
        Me.Controls.Add(TurmaLabel)
        Me.Controls.Add(Me.TurmaComboBox)
        Me.Controls.Add(DisciplinaLabel)
        Me.Controls.Add(Me.DisciplinaComboBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form16"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form16"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turma_DisciplinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisciplinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EscolaDataSet As EscolaDataSet
    Friend WithEvents Turma_DisciplinaBindingSource As BindingSource
    Friend WithEvents Turma_DisciplinaTableAdapter As EscolaDataSetTableAdapters.Turma_DisciplinaTableAdapter
    Friend WithEvents TableAdapterManager As EscolaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TurmasTableAdapter As EscolaDataSetTableAdapters.TurmasTableAdapter
    Friend WithEvents DisciplinaComboBox As ComboBox
    Friend WithEvents TurmasBindingSource As BindingSource
    Friend WithEvents AnoTextBox As TextBox
    Friend WithEvents SiglaTextBox As TextBox
    Friend WithEvents DisciplinasBindingSource As BindingSource
    Friend WithEvents DisciplinasTableAdapter As EscolaDataSetTableAdapters.DisciplinasTableAdapter
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TurmaComboBox As ComboBox
    Friend WithEvents Button1 As Button
End Class
