<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form12
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
        Dim ID_avaliaçãoLabel As System.Windows.Forms.Label
        Dim TurmaLabel As System.Windows.Forms.Label
        Dim ModuloLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim AnoLabel As System.Windows.Forms.Label
        Dim SiglaLabel As System.Windows.Forms.Label
        Dim ID_AlunoLabel As System.Windows.Forms.Label
        Dim NomeLabel1 As System.Windows.Forms.Label
        Dim SobrenomeLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim NotaFinalLabel As System.Windows.Forms.Label
        Dim AutoavaliaçãoLabel As System.Windows.Forms.Label
        Me.EscolaDataSet = New ProjetoFinal.EscolaDataSet()
        Me.AvaliaçõesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvaliaçõesTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.AvaliaçõesTableAdapter()
        Me.TableAdapterManager = New ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager()
        Me.CursosTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.CursosTableAdapter()
        Me.DisciplinasTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.DisciplinasTableAdapter()
        Me.Modulo_DisciplinaTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.Modulo_DisciplinaTableAdapter()
        Me.ModuloTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.ModuloTableAdapter()
        Me.TurmasTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.TurmasTableAdapter()
        Me.ID_avaliaçãoTextBox = New System.Windows.Forms.TextBox()
        Me.TurmaComboBox = New System.Windows.Forms.ComboBox()
        Me.TurmasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModuloComboBox = New System.Windows.Forms.ComboBox()
        Me.ModuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.DisciplinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Modulo_DisciplinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.AlunosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlunosTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.AlunosTableAdapter()
        Me.Aluno_AvaliaçãoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Aluno_AvaliaçãoTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.Aluno_AvaliaçãoTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SiglaTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AnoTextBox = New System.Windows.Forms.TextBox()
        Me.AlunosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.AlunosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_AlunoTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox1 = New System.Windows.Forms.TextBox()
        Me.SobrenomeTextBox = New System.Windows.Forms.TextBox()
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AutoavaliaçãoTextBox = New System.Windows.Forms.TextBox()
        Me.NotaFinalTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        ID_avaliaçãoLabel = New System.Windows.Forms.Label()
        TurmaLabel = New System.Windows.Forms.Label()
        ModuloLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        AnoLabel = New System.Windows.Forms.Label()
        SiglaLabel = New System.Windows.Forms.Label()
        ID_AlunoLabel = New System.Windows.Forms.Label()
        NomeLabel1 = New System.Windows.Forms.Label()
        SobrenomeLabel = New System.Windows.Forms.Label()
        EndereçoLabel = New System.Windows.Forms.Label()
        NotaFinalLabel = New System.Windows.Forms.Label()
        AutoavaliaçãoLabel = New System.Windows.Forms.Label()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvaliaçõesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisciplinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modulo_DisciplinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aluno_AvaliaçãoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AlunosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_avaliaçãoLabel
        '
        ID_avaliaçãoLabel.AutoSize = True
        ID_avaliaçãoLabel.Location = New System.Drawing.Point(22, 38)
        ID_avaliaçãoLabel.Name = "ID_avaliaçãoLabel"
        ID_avaliaçãoLabel.Size = New System.Drawing.Size(70, 13)
        ID_avaliaçãoLabel.TabIndex = 1
        ID_avaliaçãoLabel.Text = "ID avaliação:"
        '
        'TurmaLabel
        '
        TurmaLabel.AutoSize = True
        TurmaLabel.Location = New System.Drawing.Point(54, 66)
        TurmaLabel.Name = "TurmaLabel"
        TurmaLabel.Size = New System.Drawing.Size(40, 13)
        TurmaLabel.TabIndex = 3
        TurmaLabel.Text = "Turma:"
        '
        'ModuloLabel
        '
        ModuloLabel.AutoSize = True
        ModuloLabel.Location = New System.Drawing.Point(49, 52)
        ModuloLabel.Name = "ModuloLabel"
        ModuloLabel.Size = New System.Drawing.Size(45, 13)
        ModuloLabel.TabIndex = 5
        ModuloLabel.Text = "Modulo:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(56, 78)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 6
        NomeLabel.Text = "Nome:"
        '
        'AnoLabel
        '
        AnoLabel.AutoSize = True
        AnoLabel.Location = New System.Drawing.Point(63, 100)
        AnoLabel.Name = "AnoLabel"
        AnoLabel.Size = New System.Drawing.Size(29, 13)
        AnoLabel.TabIndex = 10
        AnoLabel.Text = "Ano:"
        '
        'SiglaLabel
        '
        SiglaLabel.AutoSize = True
        SiglaLabel.Location = New System.Drawing.Point(59, 127)
        SiglaLabel.Name = "SiglaLabel"
        SiglaLabel.Size = New System.Drawing.Size(33, 13)
        SiglaLabel.TabIndex = 12
        SiglaLabel.Text = "Sigla:"
        '
        'ID_AlunoLabel
        '
        ID_AlunoLabel.AutoSize = True
        ID_AlunoLabel.Location = New System.Drawing.Point(41, 63)
        ID_AlunoLabel.Name = "ID_AlunoLabel"
        ID_AlunoLabel.Size = New System.Drawing.Size(51, 13)
        ID_AlunoLabel.TabIndex = 64
        ID_AlunoLabel.Text = "ID Aluno:"
        '
        'NomeLabel1
        '
        NomeLabel1.AutoSize = True
        NomeLabel1.Location = New System.Drawing.Point(41, 89)
        NomeLabel1.Name = "NomeLabel1"
        NomeLabel1.Size = New System.Drawing.Size(38, 13)
        NomeLabel1.TabIndex = 66
        NomeLabel1.Text = "Nome:"
        '
        'SobrenomeLabel
        '
        SobrenomeLabel.AutoSize = True
        SobrenomeLabel.Location = New System.Drawing.Point(41, 115)
        SobrenomeLabel.Name = "SobrenomeLabel"
        SobrenomeLabel.Size = New System.Drawing.Size(64, 13)
        SobrenomeLabel.TabIndex = 68
        SobrenomeLabel.Text = "Sobrenome:"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Location = New System.Drawing.Point(41, 141)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(56, 13)
        EndereçoLabel.TabIndex = 76
        EndereçoLabel.Text = "Endereço:"
        '
        'NotaFinalLabel
        '
        NotaFinalLabel.AutoSize = True
        NotaFinalLabel.Location = New System.Drawing.Point(38, 153)
        NotaFinalLabel.Name = "NotaFinalLabel"
        NotaFinalLabel.Size = New System.Drawing.Size(58, 13)
        NotaFinalLabel.TabIndex = 7
        NotaFinalLabel.Text = "Nota Final:"
        '
        'AutoavaliaçãoLabel
        '
        AutoavaliaçãoLabel.AutoSize = True
        AutoavaliaçãoLabel.Location = New System.Drawing.Point(16, 117)
        AutoavaliaçãoLabel.Name = "AutoavaliaçãoLabel"
        AutoavaliaçãoLabel.Size = New System.Drawing.Size(78, 13)
        AutoavaliaçãoLabel.TabIndex = 8
        AutoavaliaçãoLabel.Text = "Autoavaliação:"
        '
        'EscolaDataSet
        '
        Me.EscolaDataSet.DataSetName = "EscolaDataSet"
        Me.EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AvaliaçõesBindingSource
        '
        Me.AvaliaçõesBindingSource.DataMember = "Avaliações"
        Me.AvaliaçõesBindingSource.DataSource = Me.EscolaDataSet
        '
        'AvaliaçõesTableAdapter
        '
        Me.AvaliaçõesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.Aluno_AvaliaçãoTableAdapter = Nothing
        Me.TableAdapterManager.AlunosTableAdapter = Nothing
        Me.TableAdapterManager.AvaliaçõesTableAdapter = Me.AvaliaçõesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CursosTableAdapter = Me.CursosTableAdapter
        Me.TableAdapterManager.DisciplinasTableAdapter = Me.DisciplinasTableAdapter
        Me.TableAdapterManager.Modulo_DisciplinaTableAdapter = Me.Modulo_DisciplinaTableAdapter
        Me.TableAdapterManager.ModuloTableAdapter = Me.ModuloTableAdapter
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
        'DisciplinasTableAdapter
        '
        Me.DisciplinasTableAdapter.ClearBeforeFill = True
        '
        'Modulo_DisciplinaTableAdapter
        '
        Me.Modulo_DisciplinaTableAdapter.ClearBeforeFill = True
        '
        'ModuloTableAdapter
        '
        Me.ModuloTableAdapter.ClearBeforeFill = True
        '
        'TurmasTableAdapter
        '
        Me.TurmasTableAdapter.ClearBeforeFill = True
        '
        'ID_avaliaçãoTextBox
        '
        Me.ID_avaliaçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvaliaçõesBindingSource, "ID_avaliação", True))
        Me.ID_avaliaçãoTextBox.Enabled = False
        Me.ID_avaliaçãoTextBox.Location = New System.Drawing.Point(98, 35)
        Me.ID_avaliaçãoTextBox.Name = "ID_avaliaçãoTextBox"
        Me.ID_avaliaçãoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ID_avaliaçãoTextBox.TabIndex = 2
        '
        'TurmaComboBox
        '
        Me.TurmaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvaliaçõesBindingSource, "Turma", True))
        Me.TurmaComboBox.DataSource = Me.TurmasBindingSource
        Me.TurmaComboBox.DisplayMember = "ID_Turma"
        Me.TurmaComboBox.Enabled = False
        Me.TurmaComboBox.FormattingEnabled = True
        Me.TurmaComboBox.Location = New System.Drawing.Point(100, 63)
        Me.TurmaComboBox.Name = "TurmaComboBox"
        Me.TurmaComboBox.Size = New System.Drawing.Size(43, 21)
        Me.TurmaComboBox.TabIndex = 4
        Me.TurmaComboBox.ValueMember = "ID_Turma"
        '
        'TurmasBindingSource
        '
        Me.TurmasBindingSource.DataMember = "Turmas"
        Me.TurmasBindingSource.DataSource = Me.EscolaDataSet
        '
        'ModuloComboBox
        '
        Me.ModuloComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvaliaçõesBindingSource, "Modulo", True))
        Me.ModuloComboBox.DataSource = Me.ModuloBindingSource
        Me.ModuloComboBox.DisplayMember = "ID_modulo"
        Me.ModuloComboBox.FormattingEnabled = True
        Me.ModuloComboBox.Location = New System.Drawing.Point(102, 49)
        Me.ModuloComboBox.Name = "ModuloComboBox"
        Me.ModuloComboBox.Size = New System.Drawing.Size(45, 21)
        Me.ModuloComboBox.TabIndex = 6
        Me.ModuloComboBox.ValueMember = "ID_modulo"
        '
        'ModuloBindingSource
        '
        Me.ModuloBindingSource.DataMember = "Modulo"
        Me.ModuloBindingSource.DataSource = Me.EscolaDataSet
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModuloBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(102, 75)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(140, 20)
        Me.NomeTextBox.TabIndex = 7
        '
        'DisciplinasBindingSource
        '
        Me.DisciplinasBindingSource.DataMember = "Disciplinas"
        Me.DisciplinasBindingSource.DataSource = Me.EscolaDataSet
        '
        'Modulo_DisciplinaBindingSource
        '
        Me.Modulo_DisciplinaBindingSource.DataMember = "Modulo/Disciplina"
        Me.Modulo_DisciplinaBindingSource.DataSource = Me.EscolaDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(347, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 34)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Inserir Avaliações"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CursosBindingSource
        '
        Me.CursosBindingSource.DataMember = "Cursos"
        Me.CursosBindingSource.DataSource = Me.EscolaDataSet
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.ProjetoFinal.My.Resources.Resources.undo
        Me.PictureBox10.Location = New System.Drawing.Point(869, 12)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(51, 34)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 59
        Me.PictureBox10.TabStop = False
        '
        'AlunosBindingSource
        '
        Me.AlunosBindingSource.DataMember = "Alunos"
        Me.AlunosBindingSource.DataSource = Me.EscolaDataSet
        '
        'AlunosTableAdapter
        '
        Me.AlunosTableAdapter.ClearBeforeFill = True
        '
        'Aluno_AvaliaçãoBindingSource
        '
        Me.Aluno_AvaliaçãoBindingSource.DataMember = "Aluno/Avaliação"
        Me.Aluno_AvaliaçãoBindingSource.DataSource = Me.EscolaDataSet
        '
        'Aluno_AvaliaçãoTableAdapter
        '
        Me.Aluno_AvaliaçãoTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SiglaTextBox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.AnoTextBox)
        Me.GroupBox1.Controls.Add(Me.ID_avaliaçãoTextBox)
        Me.GroupBox1.Controls.Add(Me.TurmaComboBox)
        Me.GroupBox1.Controls.Add(TurmaLabel)
        Me.GroupBox1.Controls.Add(ID_avaliaçãoLabel)
        Me.GroupBox1.Controls.Add(SiglaLabel)
        Me.GroupBox1.Controls.Add(AnoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 184)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Avaliação/Turma"
        '
        'SiglaTextBox
        '
        Me.SiglaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Sigla", True))
        Me.SiglaTextBox.Enabled = False
        Me.SiglaTextBox.Location = New System.Drawing.Point(98, 123)
        Me.SiglaTextBox.Name = "SiglaTextBox"
        Me.SiglaTextBox.Size = New System.Drawing.Size(121, 20)
        Me.SiglaTextBox.TabIndex = 87
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 23)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AnoTextBox
        '
        Me.AnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Ano", True))
        Me.AnoTextBox.Enabled = False
        Me.AnoTextBox.Location = New System.Drawing.Point(98, 97)
        Me.AnoTextBox.Name = "AnoTextBox"
        Me.AnoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AnoTextBox.TabIndex = 86
        '
        'AlunosDataGridView
        '
        Me.AlunosDataGridView.AutoGenerateColumns = False
        Me.AlunosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlunosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.AlunosDataGridView.DataSource = Me.AlunosBindingSource
        Me.AlunosDataGridView.Location = New System.Drawing.Point(336, 129)
        Me.AlunosDataGridView.Name = "AlunosDataGridView"
        Me.AlunosDataGridView.Size = New System.Drawing.Size(547, 154)
        Me.AlunosDataGridView.TabIndex = 63
        Me.AlunosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Aluno"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Aluno"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Sobrenome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sobrenome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NIF"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NIF"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Endereço"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Endereço"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(336, 89)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(95, 17)
        Me.RadioButton1.TabIndex = 64
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Mostrar Alunos"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'AlunosBindingSource1
        '
        Me.AlunosBindingSource1.DataMember = "Alunos"
        Me.AlunosBindingSource1.DataSource = Me.EscolaDataSet
        '
        'ID_AlunoTextBox
        '
        Me.ID_AlunoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "ID_Aluno", True))
        Me.ID_AlunoTextBox.Enabled = False
        Me.ID_AlunoTextBox.Location = New System.Drawing.Point(111, 60)
        Me.ID_AlunoTextBox.Name = "ID_AlunoTextBox"
        Me.ID_AlunoTextBox.Size = New System.Drawing.Size(54, 20)
        Me.ID_AlunoTextBox.TabIndex = 65
        '
        'NomeTextBox1
        '
        Me.NomeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "Nome", True))
        Me.NomeTextBox1.Enabled = False
        Me.NomeTextBox1.Location = New System.Drawing.Point(111, 86)
        Me.NomeTextBox1.Name = "NomeTextBox1"
        Me.NomeTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.NomeTextBox1.TabIndex = 67
        '
        'SobrenomeTextBox
        '
        Me.SobrenomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "Sobrenome", True))
        Me.SobrenomeTextBox.Enabled = False
        Me.SobrenomeTextBox.Location = New System.Drawing.Point(111, 112)
        Me.SobrenomeTextBox.Name = "SobrenomeTextBox"
        Me.SobrenomeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SobrenomeTextBox.TabIndex = 69
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Enabled = False
        Me.EndereçoTextBox.Location = New System.Drawing.Point(111, 138)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EndereçoTextBox.TabIndex = 77
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(AutoavaliaçãoLabel)
        Me.GroupBox2.Controls.Add(Me.AutoavaliaçãoTextBox)
        Me.GroupBox2.Controls.Add(NotaFinalLabel)
        Me.GroupBox2.Controls.Add(Me.NotaFinalTextBox)
        Me.GroupBox2.Controls.Add(ModuloLabel)
        Me.GroupBox2.Controls.Add(Me.ModuloComboBox)
        Me.GroupBox2.Controls.Add(Me.NomeTextBox)
        Me.GroupBox2.Controls.Add(NomeLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 273)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 213)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Módulo"
        Me.GroupBox2.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(153, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 23)
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "Ver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AutoavaliaçãoTextBox
        '
        Me.AutoavaliaçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aluno_AvaliaçãoBindingSource, "Autoavaliação", True))
        Me.AutoavaliaçãoTextBox.Location = New System.Drawing.Point(102, 114)
        Me.AutoavaliaçãoTextBox.Name = "AutoavaliaçãoTextBox"
        Me.AutoavaliaçãoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AutoavaliaçãoTextBox.TabIndex = 9
        '
        'NotaFinalTextBox
        '
        Me.NotaFinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aluno_AvaliaçãoBindingSource, "NotaFinal", True))
        Me.NotaFinalTextBox.Location = New System.Drawing.Point(102, 150)
        Me.NotaFinalTextBox.Name = "NotaFinalTextBox"
        Me.NotaFinalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NotaFinalTextBox.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ID_AlunoTextBox)
        Me.GroupBox3.Controls.Add(Me.EndereçoTextBox)
        Me.GroupBox3.Controls.Add(ID_AlunoLabel)
        Me.GroupBox3.Controls.Add(EndereçoLabel)
        Me.GroupBox3.Controls.Add(Me.SobrenomeTextBox)
        Me.GroupBox3.Controls.Add(NomeLabel1)
        Me.GroupBox3.Controls.Add(SobrenomeLabel)
        Me.GroupBox3.Controls.Add(Me.NomeTextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(437, 307)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 179)
        Me.GroupBox3.TabIndex = 79
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informações do Aluno"
        Me.GroupBox3.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(462, 89)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton2.TabIndex = 80
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Remover"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.ProjetoFinal.My.Resources.Resources.save
        Me.PictureBox12.Location = New System.Drawing.Point(815, 513)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(68, 47)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 82
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(817, 569)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Guardar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label8.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(548, 91)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton3.TabIndex = 83
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.UseVisualStyleBackColor = True
        Me.RadioButton3.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 569)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Inserir"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProjetoFinal.My.Resources.Resources.plus
        Me.PictureBox4.Location = New System.Drawing.Point(39, 513)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(61, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 84
        Me.PictureBox4.TabStop = False
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 635)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.AlunosDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form12"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form12"
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvaliaçõesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisciplinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modulo_DisciplinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aluno_AvaliaçãoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AlunosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EscolaDataSet As EscolaDataSet
    Friend WithEvents AvaliaçõesBindingSource As BindingSource
    Friend WithEvents AvaliaçõesTableAdapter As EscolaDataSetTableAdapters.AvaliaçõesTableAdapter
    Friend WithEvents TableAdapterManager As EscolaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_avaliaçãoTextBox As TextBox
    Friend WithEvents TurmaComboBox As ComboBox
    Friend WithEvents ModuloComboBox As ComboBox
    Friend WithEvents ModuloTableAdapter As EscolaDataSetTableAdapters.ModuloTableAdapter
    Friend WithEvents ModuloBindingSource As BindingSource
    Friend WithEvents DisciplinasTableAdapter As EscolaDataSetTableAdapters.DisciplinasTableAdapter
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents DisciplinasBindingSource As BindingSource
    Friend WithEvents TurmasTableAdapter As EscolaDataSetTableAdapters.TurmasTableAdapter
    Friend WithEvents TurmasBindingSource As BindingSource
    Friend WithEvents Modulo_DisciplinaTableAdapter As EscolaDataSetTableAdapters.Modulo_DisciplinaTableAdapter
    Friend WithEvents Modulo_DisciplinaBindingSource As BindingSource
    Friend WithEvents CursosTableAdapter As EscolaDataSetTableAdapters.CursosTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents AlunosBindingSource As BindingSource
    Friend WithEvents AlunosTableAdapter As EscolaDataSetTableAdapters.AlunosTableAdapter
    Friend WithEvents Aluno_AvaliaçãoBindingSource As BindingSource
    Friend WithEvents Aluno_AvaliaçãoTableAdapter As EscolaDataSetTableAdapters.Aluno_AvaliaçãoTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AlunosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents AlunosBindingSource1 As BindingSource
    Friend WithEvents ID_AlunoTextBox As TextBox
    Friend WithEvents NomeTextBox1 As TextBox
    Friend WithEvents SobrenomeTextBox As TextBox
    Friend WithEvents EndereçoTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AutoavaliaçãoTextBox As TextBox
    Friend WithEvents NotaFinalTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents SiglaTextBox As TextBox
    Friend WithEvents AnoTextBox As TextBox
    Friend WithEvents Button2 As Button
End Class
