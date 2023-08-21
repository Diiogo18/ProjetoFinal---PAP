<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form14
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
        Dim ID_AlunoLabel As System.Windows.Forms.Label
        Dim Alunos_NomeLabel As System.Windows.Forms.Label
        Dim SobrenomeLabel As System.Windows.Forms.Label
        Dim Nome_CursoLabel As System.Windows.Forms.Label
        Dim AnoLabel As System.Windows.Forms.Label
        Dim SiglaLabel As System.Windows.Forms.Label
        Dim Disciplinas_NomeLabel As System.Windows.Forms.Label
        Dim Modulo_NomeLabel As System.Windows.Forms.Label
        Dim AutoavaliaçãoLabel As System.Windows.Forms.Label
        Dim NotaFinalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Me.EscolaDataSet = New ProjetoFinal.EscolaDataSet()
        Me.AlunosNotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlunosNotasTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.AlunosNotasTableAdapter()
        Me.TableAdapterManager = New ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager()
        Me.AlunosNotasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ID_AlunoTextBox = New System.Windows.Forms.TextBox()
        Me.Alunos_NomeTextBox = New System.Windows.Forms.TextBox()
        Me.SobrenomeTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_CursoTextBox = New System.Windows.Forms.TextBox()
        Me.AnoTextBox = New System.Windows.Forms.TextBox()
        Me.SiglaTextBox = New System.Windows.Forms.TextBox()
        Me.Disciplinas_NomeTextBox = New System.Windows.Forms.TextBox()
        Me.Modulo_NomeTextBox = New System.Windows.Forms.TextBox()
        Me.AutoavaliaçãoTextBox = New System.Windows.Forms.TextBox()
        Me.NotaFinalTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintDialog2 = New System.Windows.Forms.PrintDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        ID_AlunoLabel = New System.Windows.Forms.Label()
        Alunos_NomeLabel = New System.Windows.Forms.Label()
        SobrenomeLabel = New System.Windows.Forms.Label()
        Nome_CursoLabel = New System.Windows.Forms.Label()
        AnoLabel = New System.Windows.Forms.Label()
        SiglaLabel = New System.Windows.Forms.Label()
        Disciplinas_NomeLabel = New System.Windows.Forms.Label()
        Modulo_NomeLabel = New System.Windows.Forms.Label()
        AutoavaliaçãoLabel = New System.Windows.Forms.Label()
        NotaFinalLabel = New System.Windows.Forms.Label()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosNotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosNotasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_AlunoLabel
        '
        ID_AlunoLabel.AutoSize = True
        ID_AlunoLabel.Location = New System.Drawing.Point(13, 22)
        ID_AlunoLabel.Name = "ID_AlunoLabel"
        ID_AlunoLabel.Size = New System.Drawing.Size(51, 13)
        ID_AlunoLabel.TabIndex = 80
        ID_AlunoLabel.Text = "ID Aluno:"
        '
        'Alunos_NomeLabel
        '
        Alunos_NomeLabel.AutoSize = True
        Alunos_NomeLabel.Location = New System.Drawing.Point(13, 48)
        Alunos_NomeLabel.Name = "Alunos_NomeLabel"
        Alunos_NomeLabel.Size = New System.Drawing.Size(73, 13)
        Alunos_NomeLabel.TabIndex = 82
        Alunos_NomeLabel.Text = "Alunos Nome:"
        '
        'SobrenomeLabel
        '
        SobrenomeLabel.AutoSize = True
        SobrenomeLabel.Location = New System.Drawing.Point(12, 74)
        SobrenomeLabel.Name = "SobrenomeLabel"
        SobrenomeLabel.Size = New System.Drawing.Size(64, 13)
        SobrenomeLabel.TabIndex = 84
        SobrenomeLabel.Text = "Sobrenome:"
        '
        'Nome_CursoLabel
        '
        Nome_CursoLabel.AutoSize = True
        Nome_CursoLabel.Location = New System.Drawing.Point(290, 22)
        Nome_CursoLabel.Name = "Nome_CursoLabel"
        Nome_CursoLabel.Size = New System.Drawing.Size(68, 13)
        Nome_CursoLabel.TabIndex = 86
        Nome_CursoLabel.Text = "Nome Curso:"
        '
        'AnoLabel
        '
        AnoLabel.AutoSize = True
        AnoLabel.Location = New System.Drawing.Point(290, 48)
        AnoLabel.Name = "AnoLabel"
        AnoLabel.Size = New System.Drawing.Size(29, 13)
        AnoLabel.TabIndex = 88
        AnoLabel.Text = "Ano:"
        '
        'SiglaLabel
        '
        SiglaLabel.AutoSize = True
        SiglaLabel.Location = New System.Drawing.Point(290, 74)
        SiglaLabel.Name = "SiglaLabel"
        SiglaLabel.Size = New System.Drawing.Size(33, 13)
        SiglaLabel.TabIndex = 90
        SiglaLabel.Text = "Sigla:"
        '
        'Disciplinas_NomeLabel
        '
        Disciplinas_NomeLabel.AutoSize = True
        Disciplinas_NomeLabel.Location = New System.Drawing.Point(13, 131)
        Disciplinas_NomeLabel.Name = "Disciplinas_NomeLabel"
        Disciplinas_NomeLabel.Size = New System.Drawing.Size(91, 13)
        Disciplinas_NomeLabel.TabIndex = 92
        Disciplinas_NomeLabel.Text = "Disciplinas Nome:"
        '
        'Modulo_NomeLabel
        '
        Modulo_NomeLabel.AutoSize = True
        Modulo_NomeLabel.Location = New System.Drawing.Point(13, 157)
        Modulo_NomeLabel.Name = "Modulo_NomeLabel"
        Modulo_NomeLabel.Size = New System.Drawing.Size(76, 13)
        Modulo_NomeLabel.TabIndex = 94
        Modulo_NomeLabel.Text = "Modulo Nome:"
        '
        'AutoavaliaçãoLabel
        '
        AutoavaliaçãoLabel.AutoSize = True
        AutoavaliaçãoLabel.Location = New System.Drawing.Point(290, 127)
        AutoavaliaçãoLabel.Name = "AutoavaliaçãoLabel"
        AutoavaliaçãoLabel.Size = New System.Drawing.Size(78, 13)
        AutoavaliaçãoLabel.TabIndex = 96
        AutoavaliaçãoLabel.Text = "Autoavaliação:"
        '
        'NotaFinalLabel
        '
        NotaFinalLabel.AutoSize = True
        NotaFinalLabel.Location = New System.Drawing.Point(290, 153)
        NotaFinalLabel.Name = "NotaFinalLabel"
        NotaFinalLabel.Size = New System.Drawing.Size(58, 13)
        NotaFinalLabel.TabIndex = 98
        NotaFinalLabel.Text = "Nota Final:"
        '
        'EscolaDataSet
        '
        Me.EscolaDataSet.DataSetName = "EscolaDataSet"
        Me.EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlunosNotasBindingSource
        '
        Me.AlunosNotasBindingSource.DataMember = "AlunosNotas"
        Me.AlunosNotasBindingSource.DataSource = Me.EscolaDataSet
        '
        'AlunosNotasTableAdapter
        '
        Me.AlunosNotasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.Aluno_AvaliaçãoTableAdapter = Nothing
        Me.TableAdapterManager.AlunosTableAdapter = Nothing
        Me.TableAdapterManager.AvaliaçõesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.DisciplinasTableAdapter = Nothing
        Me.TableAdapterManager.Modulo_DisciplinaTableAdapter = Nothing
        Me.TableAdapterManager.ModuloTableAdapter = Nothing
        Me.TableAdapterManager.PresençasTableAdapter = Nothing
        Me.TableAdapterManager.ProfessoresTableAdapter = Nothing
        Me.TableAdapterManager.Turma_DisciplinaTableAdapter = Nothing
        Me.TableAdapterManager.TurmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AlunosNotasDataGridView
        '
        Me.AlunosNotasDataGridView.AutoGenerateColumns = False
        Me.AlunosNotasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.AlunosNotasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlunosNotasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.AlunosNotasDataGridView.DataSource = Me.AlunosNotasBindingSource
        Me.AlunosNotasDataGridView.Location = New System.Drawing.Point(151, 352)
        Me.AlunosNotasDataGridView.Name = "AlunosNotasDataGridView"
        Me.AlunosNotasDataGridView.Size = New System.Drawing.Size(918, 253)
        Me.AlunosNotasDataGridView.TabIndex = 1
        Me.AlunosNotasDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Aluno"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 35
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Alunos_Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Sobrenome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sobrenome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nome_Curso"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Curso"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ano"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ano"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Sigla"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Sigla"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Disciplinas_Nome"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Disciplina"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 95
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Modulo_Nome"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Modulo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Autoavaliação"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Autoavaliação"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NotaFinal"
        Me.DataGridViewTextBoxColumn10.HeaderText = "NotaFinal"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 75
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(438, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 34)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Alunos Avaliações"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ID_AlunoTextBox
        '
        Me.ID_AlunoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosNotasBindingSource, "ID_Aluno", True))
        Me.ID_AlunoTextBox.Location = New System.Drawing.Point(92, 22)
        Me.ID_AlunoTextBox.Name = "ID_AlunoTextBox"
        Me.ID_AlunoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_AlunoTextBox.TabIndex = 81
        '
        'Alunos_NomeTextBox
        '
        Me.Alunos_NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosNotasBindingSource, "Alunos_Nome", True))
        Me.Alunos_NomeTextBox.Location = New System.Drawing.Point(92, 45)
        Me.Alunos_NomeTextBox.Name = "Alunos_NomeTextBox"
        Me.Alunos_NomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Alunos_NomeTextBox.TabIndex = 83
        '
        'SobrenomeTextBox
        '
        Me.SobrenomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosNotasBindingSource, "Sobrenome", True))
        Me.SobrenomeTextBox.Location = New System.Drawing.Point(92, 71)
        Me.SobrenomeTextBox.Name = "SobrenomeTextBox"
        Me.SobrenomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SobrenomeTextBox.TabIndex = 85
        '
        'Nome_CursoTextBox
        '
        Me.Nome_CursoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosNotasBindingSource, "Nome_Curso", True))
        Me.Nome_CursoTextBox.Location = New System.Drawing.Point(387, 19)
        Me.Nome_CursoTextBox.Name = "Nome_CursoTextBox"
        Me.Nome_CursoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nome_CursoTextBox.TabIndex = 87
        '
        'AnoTextBox
        '
        Me.AnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosNotasBindingSource, "Ano", True))
        Me.AnoTextBox.Location = New System.Drawing.Point(387, 45)
        Me.AnoTextBox.Name = "AnoTextBox"
        Me.AnoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnoTextBox.TabIndex = 89
        '
        'SiglaTextBox
        '
        Me.SiglaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosNotasBindingSource, "Sigla", True))
        Me.SiglaTextBox.Location = New System.Drawing.Point(387, 71)
        Me.SiglaTextBox.Name = "SiglaTextBox"
        Me.SiglaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SiglaTextBox.TabIndex = 91
        '
        'Disciplinas_NomeTextBox
        '
        Me.Disciplinas_NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosNotasBindingSource, "Disciplinas_Nome", True))
        Me.Disciplinas_NomeTextBox.Location = New System.Drawing.Point(110, 128)
        Me.Disciplinas_NomeTextBox.Name = "Disciplinas_NomeTextBox"
        Me.Disciplinas_NomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Disciplinas_NomeTextBox.TabIndex = 93
        '
        'Modulo_NomeTextBox
        '
        Me.Modulo_NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosNotasBindingSource, "Modulo_Nome", True))
        Me.Modulo_NomeTextBox.Location = New System.Drawing.Point(110, 154)
        Me.Modulo_NomeTextBox.Name = "Modulo_NomeTextBox"
        Me.Modulo_NomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Modulo_NomeTextBox.TabIndex = 95
        '
        'AutoavaliaçãoTextBox
        '
        Me.AutoavaliaçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosNotasBindingSource, "Autoavaliação", True))
        Me.AutoavaliaçãoTextBox.Location = New System.Drawing.Point(387, 124)
        Me.AutoavaliaçãoTextBox.Name = "AutoavaliaçãoTextBox"
        Me.AutoavaliaçãoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AutoavaliaçãoTextBox.TabIndex = 97
        '
        'NotaFinalTextBox
        '
        Me.NotaFinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosNotasBindingSource, "NotaFinal", True))
        Me.NotaFinalTextBox.Location = New System.Drawing.Point(387, 150)
        Me.NotaFinalTextBox.Name = "NotaFinalTextBox"
        Me.NotaFinalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NotaFinalTextBox.TabIndex = 99
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ID_AlunoTextBox)
        Me.GroupBox1.Controls.Add(AutoavaliaçãoLabel)
        Me.GroupBox1.Controls.Add(Disciplinas_NomeLabel)
        Me.GroupBox1.Controls.Add(Nome_CursoLabel)
        Me.GroupBox1.Controls.Add(Me.AutoavaliaçãoTextBox)
        Me.GroupBox1.Controls.Add(Me.Disciplinas_NomeTextBox)
        Me.GroupBox1.Controls.Add(Modulo_NomeLabel)
        Me.GroupBox1.Controls.Add(NotaFinalLabel)
        Me.GroupBox1.Controls.Add(Me.Nome_CursoTextBox)
        Me.GroupBox1.Controls.Add(Me.Modulo_NomeTextBox)
        Me.GroupBox1.Controls.Add(SobrenomeLabel)
        Me.GroupBox1.Controls.Add(Me.NotaFinalTextBox)
        Me.GroupBox1.Controls.Add(AnoLabel)
        Me.GroupBox1.Controls.Add(Alunos_NomeLabel)
        Me.GroupBox1.Controls.Add(Me.AnoTextBox)
        Me.GroupBox1.Controls.Add(Me.SobrenomeTextBox)
        Me.GroupBox1.Controls.Add(SiglaLabel)
        Me.GroupBox1.Controls.Add(ID_AlunoLabel)
        Me.GroupBox1.Controls.Add(Me.SiglaTextBox)
        Me.GroupBox1.Controls.Add(Me.Alunos_NomeTextBox)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(318, 619)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(505, 98)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações"
        Me.GroupBox1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton10)
        Me.GroupBox3.Controls.Add(Me.RadioButton18)
        Me.GroupBox3.Controls.Add(Me.RadioButton17)
        Me.GroupBox3.Controls.Add(Me.RadioButton16)
        Me.GroupBox3.Controls.Add(Me.RadioButton15)
        Me.GroupBox3.Controls.Add(Me.RadioButton13)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 65)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1105, 258)
        Me.GroupBox3.TabIndex = 101
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pesquisar por..."
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(128, 223)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton10.TabIndex = 108
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.UseVisualStyleBackColor = True
        Me.RadioButton10.Visible = False
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.Location = New System.Drawing.Point(930, 189)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton18.TabIndex = 107
        Me.RadioButton18.TabStop = True
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'RadioButton17
        '
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.Location = New System.Drawing.Point(671, 189)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton17.TabIndex = 106
        Me.RadioButton17.TabStop = True
        Me.RadioButton17.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Location = New System.Drawing.Point(376, 185)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton16.TabIndex = 105
        Me.RadioButton16.TabStop = True
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.Location = New System.Drawing.Point(95, 189)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton15.TabIndex = 104
        Me.RadioButton15.TabStop = True
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(18, 221)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(104, 17)
        Me.RadioButton13.TabIndex = 103
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.Text = "Pesquisar Todos"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.RadioButton1)
        Me.GroupBox7.Controls.Add(Me.RadioButton9)
        Me.GroupBox7.Enabled = False
        Me.GroupBox7.Location = New System.Drawing.Point(841, 23)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(187, 160)
        Me.GroupBox7.TabIndex = 61
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Disciplina"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 40)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(53, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Nome"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(16, 76)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton9.TabIndex = 2
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "Módulo"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton8)
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.Location = New System.Drawing.Point(18, 23)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(187, 160)
        Me.GroupBox6.TabIndex = 61
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Curso"
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(19, 40)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(53, 17)
        Me.RadioButton8.TabIndex = 2
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Nome"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton12)
        Me.GroupBox5.Controls.Add(Me.RadioButton4)
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Enabled = False
        Me.GroupBox5.Location = New System.Drawing.Point(245, 23)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(265, 156)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Turma"
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(22, 116)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton12.TabIndex = 5
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "Sigla"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(22, 29)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Ano"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton7)
        Me.GroupBox4.Controls.Add(Me.RadioButton6)
        Me.GroupBox4.Controls.Add(Me.RadioButton5)
        Me.GroupBox4.Location = New System.Drawing.Point(90, 29)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(126, 72)
        Me.GroupBox4.TabIndex = 63
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(41, 43)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(41, 17)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "12º"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(75, 15)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(41, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "11º"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 15)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(41, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "10º"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton11)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(578, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 160)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aluno"
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(16, 40)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(36, 17)
        Me.RadioButton11.TabIndex = 4
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "ID"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(16, 76)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(53, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Nome"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(16, 106)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Sobrenome"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.Location = New System.Drawing.Point(1014, 329)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(114, 17)
        Me.RadioButton14.TabIndex = 104
        Me.RadioButton14.TabStop = True
        Me.RadioButton14.Text = "Remover Pesquisa"
        Me.RadioButton14.UseVisualStyleBackColor = True
        Me.RadioButton14.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(876, 697)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Pauta Geral"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1042, 697)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Imprimir"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'PrintDialog2
        '
        Me.PrintDialog2.UseEXDialog = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProjetoFinal.My.Resources.Resources._535249
        Me.PictureBox2.Location = New System.Drawing.Point(1042, 631)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 105
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjetoFinal.My.Resources.Resources._768818
        Me.PictureBox1.Location = New System.Drawing.Point(896, 631)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.ProjetoFinal.My.Resources.Resources.undo
        Me.PictureBox10.Location = New System.Drawing.Point(1099, 12)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(44, 31)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 60
        Me.PictureBox10.TabStop = False
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1155, 788)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.RadioButton14)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.AlunosNotasDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form14"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form14"
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosNotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosNotasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EscolaDataSet As EscolaDataSet
    Friend WithEvents AlunosNotasBindingSource As BindingSource
    Friend WithEvents AlunosNotasTableAdapter As EscolaDataSetTableAdapters.AlunosNotasTableAdapter
    Friend WithEvents TableAdapterManager As EscolaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AlunosNotasDataGridView As DataGridView
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents ID_AlunoTextBox As TextBox
    Friend WithEvents Alunos_NomeTextBox As TextBox
    Friend WithEvents SobrenomeTextBox As TextBox
    Friend WithEvents Nome_CursoTextBox As TextBox
    Friend WithEvents AnoTextBox As TextBox
    Friend WithEvents SiglaTextBox As TextBox
    Friend WithEvents Disciplinas_NomeTextBox As TextBox
    Friend WithEvents Modulo_NomeTextBox As TextBox
    Friend WithEvents AutoavaliaçãoTextBox As TextBox
    Friend WithEvents NotaFinalTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents RadioButton17 As RadioButton
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents PrintDialog2 As PrintDialog
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
