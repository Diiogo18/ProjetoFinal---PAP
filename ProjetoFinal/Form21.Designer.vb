<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form21
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
        Dim SalaLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim HoraLabel As System.Windows.Forms.Label
        Dim ID_AlunoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim SobrenomeLabel As System.Windows.Forms.Label
        Dim SituaçãoLabel As System.Windows.Forms.Label
        Dim TurmaLabel As System.Windows.Forms.Label
        Dim AnoLabel As System.Windows.Forms.Label
        Dim CursoLabel As System.Windows.Forms.Label
        Dim Diretor_TurmaLabel As System.Windows.Forms.Label
        Dim Nome_CursoLabel As System.Windows.Forms.Label
        Dim SiglaLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SituaçãoTextBox = New System.Windows.Forms.TextBox()
        Me.PresençasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EscolaDataSet = New ProjetoFinal.EscolaDataSet()
        Me.ID_AlunoTextBox = New System.Windows.Forms.TextBox()
        Me.AlunosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.SobrenomeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FotoTextBox = New System.Windows.Forms.TextBox()
        Me.PresençasTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.PresençasTableAdapter()
        Me.TableAdapterManager = New ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager()
        Me.AlunosTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.AlunosTableAdapter()
        Me.TurmasTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.TurmasTableAdapter()
        Me.SalaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TurmasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SiglaTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_CursoTextBox = New System.Windows.Forms.TextBox()
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Diretor_TurmaTextBox = New System.Windows.Forms.TextBox()
        Me.CursoComboBox = New System.Windows.Forms.ComboBox()
        Me.AnoTextBox = New System.Windows.Forms.TextBox()
        Me.TurmaComboBox = New System.Windows.Forms.ComboBox()
        Me.CursosTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.CursosTableAdapter()
        SalaLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        HoraLabel = New System.Windows.Forms.Label()
        ID_AlunoLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        SobrenomeLabel = New System.Windows.Forms.Label()
        SituaçãoLabel = New System.Windows.Forms.Label()
        TurmaLabel = New System.Windows.Forms.Label()
        AnoLabel = New System.Windows.Forms.Label()
        CursoLabel = New System.Windows.Forms.Label()
        Diretor_TurmaLabel = New System.Windows.Forms.Label()
        Nome_CursoLabel = New System.Windows.Forms.Label()
        SiglaLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PresençasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalaLabel
        '
        SalaLabel.AutoSize = True
        SalaLabel.Location = New System.Drawing.Point(47, 32)
        SalaLabel.Name = "SalaLabel"
        SalaLabel.Size = New System.Drawing.Size(31, 13)
        SalaLabel.TabIndex = 12
        SalaLabel.Text = "Sala:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(47, 59)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 14
        DataLabel.Text = "Data:"
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = True
        HoraLabel.Location = New System.Drawing.Point(47, 85)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(33, 13)
        HoraLabel.TabIndex = 16
        HoraLabel.Text = "Hora:"
        '
        'ID_AlunoLabel
        '
        ID_AlunoLabel.AutoSize = True
        ID_AlunoLabel.Location = New System.Drawing.Point(287, 60)
        ID_AlunoLabel.Name = "ID_AlunoLabel"
        ID_AlunoLabel.Size = New System.Drawing.Size(51, 13)
        ID_AlunoLabel.TabIndex = 13
        ID_AlunoLabel.Text = "ID Aluno:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(287, 86)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 15
        NomeLabel.Text = "Nome:"
        '
        'SobrenomeLabel
        '
        SobrenomeLabel.AutoSize = True
        SobrenomeLabel.Location = New System.Drawing.Point(287, 112)
        SobrenomeLabel.Name = "SobrenomeLabel"
        SobrenomeLabel.Size = New System.Drawing.Size(64, 13)
        SobrenomeLabel.TabIndex = 17
        SobrenomeLabel.Text = "Sobrenome:"
        '
        'SituaçãoLabel
        '
        SituaçãoLabel.AutoSize = True
        SituaçãoLabel.Location = New System.Drawing.Point(287, 139)
        SituaçãoLabel.Name = "SituaçãoLabel"
        SituaçãoLabel.Size = New System.Drawing.Size(52, 13)
        SituaçãoLabel.TabIndex = 30
        SituaçãoLabel.Text = "Situação:"
        '
        'TurmaLabel
        '
        TurmaLabel.AutoSize = True
        TurmaLabel.Location = New System.Drawing.Point(21, 27)
        TurmaLabel.Name = "TurmaLabel"
        TurmaLabel.Size = New System.Drawing.Size(40, 13)
        TurmaLabel.TabIndex = 0
        TurmaLabel.Text = "Turma:"
        '
        'AnoLabel
        '
        AnoLabel.AutoSize = True
        AnoLabel.Location = New System.Drawing.Point(32, 59)
        AnoLabel.Name = "AnoLabel"
        AnoLabel.Size = New System.Drawing.Size(29, 13)
        AnoLabel.TabIndex = 2
        AnoLabel.Text = "Ano:"
        '
        'CursoLabel
        '
        CursoLabel.AutoSize = True
        CursoLabel.Location = New System.Drawing.Point(242, 27)
        CursoLabel.Name = "CursoLabel"
        CursoLabel.Size = New System.Drawing.Size(37, 13)
        CursoLabel.TabIndex = 4
        CursoLabel.Text = "Curso:"
        '
        'Diretor_TurmaLabel
        '
        Diretor_TurmaLabel.AutoSize = True
        Diretor_TurmaLabel.Location = New System.Drawing.Point(11, 137)
        Diretor_TurmaLabel.Name = "Diretor_TurmaLabel"
        Diretor_TurmaLabel.Size = New System.Drawing.Size(74, 13)
        Diretor_TurmaLabel.TabIndex = 6
        Diretor_TurmaLabel.Text = "Diretor-Turma:"
        '
        'Nome_CursoLabel
        '
        Nome_CursoLabel.AutoSize = True
        Nome_CursoLabel.Location = New System.Drawing.Point(211, 59)
        Nome_CursoLabel.Name = "Nome_CursoLabel"
        Nome_CursoLabel.Size = New System.Drawing.Size(68, 13)
        Nome_CursoLabel.TabIndex = 8
        Nome_CursoLabel.Text = "Nome Curso:"
        '
        'SiglaLabel
        '
        SiglaLabel.AutoSize = True
        SiglaLabel.Location = New System.Drawing.Point(28, 88)
        SiglaLabel.Name = "SiglaLabel"
        SiglaLabel.Size = New System.Drawing.Size(33, 13)
        SiglaLabel.TabIndex = 10
        SiglaLabel.Text = "Sigla:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(SituaçãoLabel)
        Me.GroupBox1.Controls.Add(Me.SituaçãoTextBox)
        Me.GroupBox1.Controls.Add(ID_AlunoLabel)
        Me.GroupBox1.Controls.Add(Me.ID_AlunoTextBox)
        Me.GroupBox1.Controls.Add(NomeLabel)
        Me.GroupBox1.Controls.Add(Me.NomeTextBox)
        Me.GroupBox1.Controls.Add(SobrenomeLabel)
        Me.GroupBox1.Controls.Add(Me.SobrenomeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.FotoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 213)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(763, 381)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alunos"
        Me.GroupBox1.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(19, 34)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(225, 329)
        Me.ListBox1.TabIndex = 32
        '
        'SituaçãoTextBox
        '
        Me.SituaçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresençasBindingSource, "Situação", True))
        Me.SituaçãoTextBox.Enabled = False
        Me.SituaçãoTextBox.Location = New System.Drawing.Point(357, 136)
        Me.SituaçãoTextBox.Name = "SituaçãoTextBox"
        Me.SituaçãoTextBox.Size = New System.Drawing.Size(75, 20)
        Me.SituaçãoTextBox.TabIndex = 31
        '
        'PresençasBindingSource
        '
        Me.PresençasBindingSource.DataMember = "Presenças"
        Me.PresençasBindingSource.DataSource = Me.EscolaDataSet
        '
        'EscolaDataSet
        '
        Me.EscolaDataSet.DataSetName = "EscolaDataSet"
        Me.EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ID_AlunoTextBox
        '
        Me.ID_AlunoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "ID_Aluno", True))
        Me.ID_AlunoTextBox.Enabled = False
        Me.ID_AlunoTextBox.Location = New System.Drawing.Point(357, 57)
        Me.ID_AlunoTextBox.Name = "ID_AlunoTextBox"
        Me.ID_AlunoTextBox.Size = New System.Drawing.Size(75, 20)
        Me.ID_AlunoTextBox.TabIndex = 14
        '
        'AlunosBindingSource
        '
        Me.AlunosBindingSource.DataMember = "Alunos"
        Me.AlunosBindingSource.DataSource = Me.EscolaDataSet
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(357, 83)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomeTextBox.TabIndex = 16
        '
        'SobrenomeTextBox
        '
        Me.SobrenomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "Sobrenome", True))
        Me.SobrenomeTextBox.Enabled = False
        Me.SobrenomeTextBox.Location = New System.Drawing.Point(357, 109)
        Me.SobrenomeTextBox.Name = "SobrenomeTextBox"
        Me.SobrenomeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SobrenomeTextBox.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(623, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Aluno"
        Me.Label1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProjetoFinal.My.Resources.Resources.transferir3
        Me.PictureBox2.Location = New System.Drawing.Point(357, 233)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(83, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(556, 173)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'FotoTextBox
        '
        Me.FotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "Foto", True))
        Me.FotoTextBox.Location = New System.Drawing.Point(556, 222)
        Me.FotoTextBox.Name = "FotoTextBox"
        Me.FotoTextBox.Size = New System.Drawing.Size(184, 20)
        Me.FotoTextBox.TabIndex = 30
        '
        'PresençasTableAdapter
        '
        Me.PresençasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.Aluno_AvaliaçãoTableAdapter = Nothing
        Me.TableAdapterManager.AlunosTableAdapter = Me.AlunosTableAdapter
        Me.TableAdapterManager.AvaliaçõesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.DisciplinasTableAdapter = Nothing
        Me.TableAdapterManager.Modulo_DisciplinaTableAdapter = Nothing
        Me.TableAdapterManager.ModuloTableAdapter = Nothing
        Me.TableAdapterManager.PresençasTableAdapter = Me.PresençasTableAdapter
        Me.TableAdapterManager.ProfessoresTableAdapter = Nothing
        Me.TableAdapterManager.Turma_DisciplinaTableAdapter = Nothing
        Me.TableAdapterManager.TurmasTableAdapter = Me.TurmasTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AlunosTableAdapter
        '
        Me.AlunosTableAdapter.ClearBeforeFill = True
        '
        'TurmasTableAdapter
        '
        Me.TurmasTableAdapter.ClearBeforeFill = True
        '
        'SalaTextBox
        '
        Me.SalaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresençasBindingSource, "Sala", True))
        Me.SalaTextBox.Location = New System.Drawing.Point(84, 29)
        Me.SalaTextBox.Name = "SalaTextBox"
        Me.SalaTextBox.Size = New System.Drawing.Size(83, 20)
        Me.SalaTextBox.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(SalaLabel)
        Me.GroupBox2.Controls.Add(Me.SalaTextBox)
        Me.GroupBox2.Controls.Add(HoraLabel)
        Me.GroupBox2.Controls.Add(DataLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 169)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sobre..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Label2"
        '
        'TurmasBindingSource
        '
        Me.TurmasBindingSource.DataMember = "Turmas"
        Me.TurmasBindingSource.DataSource = Me.EscolaDataSet
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ProjetoFinal.My.Resources.Resources.abrir
        Me.PictureBox5.Location = New System.Drawing.Point(50, 610)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(85, 69)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProjetoFinal.My.Resources.Resources.transferir__1_1
        Me.PictureBox3.Location = New System.Drawing.Point(723, 610)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(85, 69)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProjetoFinal.My.Resources.Resources.emblemunreadable_934871
        Me.PictureBox4.Location = New System.Drawing.Point(814, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(41, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(SiglaLabel)
        Me.GroupBox3.Controls.Add(Me.SiglaTextBox)
        Me.GroupBox3.Controls.Add(Nome_CursoLabel)
        Me.GroupBox3.Controls.Add(Me.Nome_CursoTextBox)
        Me.GroupBox3.Controls.Add(Diretor_TurmaLabel)
        Me.GroupBox3.Controls.Add(Me.Diretor_TurmaTextBox)
        Me.GroupBox3.Controls.Add(CursoLabel)
        Me.GroupBox3.Controls.Add(Me.CursoComboBox)
        Me.GroupBox3.Controls.Add(AnoLabel)
        Me.GroupBox3.Controls.Add(Me.AnoTextBox)
        Me.GroupBox3.Controls.Add(TurmaLabel)
        Me.GroupBox3.Controls.Add(Me.TurmaComboBox)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(281, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(513, 169)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Turma"
        Me.GroupBox3.Visible = False
        '
        'SiglaTextBox
        '
        Me.SiglaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Sigla", True))
        Me.SiglaTextBox.Enabled = False
        Me.SiglaTextBox.Location = New System.Drawing.Point(67, 85)
        Me.SiglaTextBox.Name = "SiglaTextBox"
        Me.SiglaTextBox.Size = New System.Drawing.Size(54, 20)
        Me.SiglaTextBox.TabIndex = 11
        '
        'Nome_CursoTextBox
        '
        Me.Nome_CursoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursosBindingSource, "Nome_Curso", True))
        Me.Nome_CursoTextBox.Enabled = False
        Me.Nome_CursoTextBox.Location = New System.Drawing.Point(285, 59)
        Me.Nome_CursoTextBox.Name = "Nome_CursoTextBox"
        Me.Nome_CursoTextBox.Size = New System.Drawing.Size(187, 20)
        Me.Nome_CursoTextBox.TabIndex = 9
        '
        'CursosBindingSource
        '
        Me.CursosBindingSource.DataMember = "Cursos"
        Me.CursosBindingSource.DataSource = Me.EscolaDataSet
        '
        'Diretor_TurmaTextBox
        '
        Me.Diretor_TurmaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Diretor-Turma", True))
        Me.Diretor_TurmaTextBox.Enabled = False
        Me.Diretor_TurmaTextBox.Location = New System.Drawing.Point(91, 134)
        Me.Diretor_TurmaTextBox.Name = "Diretor_TurmaTextBox"
        Me.Diretor_TurmaTextBox.Size = New System.Drawing.Size(188, 20)
        Me.Diretor_TurmaTextBox.TabIndex = 7
        '
        'CursoComboBox
        '
        Me.CursoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Curso", True))
        Me.CursoComboBox.DataSource = Me.CursosBindingSource
        Me.CursoComboBox.DisplayMember = "ID_Curso"
        Me.CursoComboBox.Enabled = False
        Me.CursoComboBox.FormattingEnabled = True
        Me.CursoComboBox.Location = New System.Drawing.Point(285, 24)
        Me.CursoComboBox.Name = "CursoComboBox"
        Me.CursoComboBox.Size = New System.Drawing.Size(54, 21)
        Me.CursoComboBox.TabIndex = 5
        Me.CursoComboBox.ValueMember = "ID_Curso"
        '
        'AnoTextBox
        '
        Me.AnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Ano", True))
        Me.AnoTextBox.Enabled = False
        Me.AnoTextBox.Location = New System.Drawing.Point(67, 56)
        Me.AnoTextBox.Name = "AnoTextBox"
        Me.AnoTextBox.Size = New System.Drawing.Size(54, 20)
        Me.AnoTextBox.TabIndex = 3
        '
        'TurmaComboBox
        '
        Me.TurmaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "Turma", True))
        Me.TurmaComboBox.DataSource = Me.TurmasBindingSource
        Me.TurmaComboBox.DisplayMember = "ID_Turma"
        Me.TurmaComboBox.FormattingEnabled = True
        Me.TurmaComboBox.Location = New System.Drawing.Point(67, 24)
        Me.TurmaComboBox.Name = "TurmaComboBox"
        Me.TurmaComboBox.Size = New System.Drawing.Size(54, 21)
        Me.TurmaComboBox.TabIndex = 1
        Me.TurmaComboBox.ValueMember = "ID_Turma"
        '
        'CursosTableAdapter
        '
        Me.CursosTableAdapter.ClearBeforeFill = True
        '
        'Form21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(867, 700)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form21"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form21"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PresençasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents EscolaDataSet As EscolaDataSet
    Friend WithEvents PresençasBindingSource As BindingSource
    Friend WithEvents PresençasTableAdapter As EscolaDataSetTableAdapters.PresençasTableAdapter
    Friend WithEvents TableAdapterManager As EscolaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalaTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AlunosTableAdapter As EscolaDataSetTableAdapters.AlunosTableAdapter
    Friend WithEvents AlunosBindingSource As BindingSource
    Friend WithEvents ID_AlunoTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents SobrenomeTextBox As TextBox
    Friend WithEvents FotoTextBox As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents TurmasTableAdapter As EscolaDataSetTableAdapters.TurmasTableAdapter
    Friend WithEvents TurmasBindingSource As BindingSource
    Friend WithEvents SituaçãoTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Diretor_TurmaTextBox As TextBox
    Friend WithEvents CursoComboBox As ComboBox
    Friend WithEvents AnoTextBox As TextBox
    Friend WithEvents TurmaComboBox As ComboBox
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents CursosTableAdapter As EscolaDataSetTableAdapters.CursosTableAdapter
    Friend WithEvents Nome_CursoTextBox As TextBox
    Friend WithEvents SiglaTextBox As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
