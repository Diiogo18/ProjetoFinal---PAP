<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim SobrenomeLabel As System.Windows.Forms.Label
        Dim Data_NascLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim TurmaLabel As System.Windows.Forms.Label
        Me.AlunosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EscolaDataSet = New ProjetoFinal.EscolaDataSet()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.SobrenomeTextBox = New System.Windows.Forms.TextBox()
        Me.Data_NascDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NIFTextBox = New System.Windows.Forms.TextBox()
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox()
        Me.FotoTextBox = New System.Windows.Forms.TextBox()
        Me.AlunosTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.AlunosTableAdapter()
        Me.TableAdapterManager = New ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.TurmasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurmasTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.TurmasTableAdapter()
        Me.AnoTextBox = New System.Windows.Forms.TextBox()
        Me.SiglaTextBox = New System.Windows.Forms.TextBox()
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CursosTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.CursosTableAdapter()
        Me.Diretor_TurmaTextBox = New System.Windows.Forms.TextBox()
        Me.SexoComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.TurmaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ID_AlunoTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Nome_CursoTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TurmasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CursoComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        NomeLabel = New System.Windows.Forms.Label()
        SobrenomeLabel = New System.Windows.Forms.Label()
        Data_NascLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        EndereçoLabel = New System.Windows.Forms.Label()
        TurmaLabel = New System.Windows.Forms.Label()
        CType(Me.AlunosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurmasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(43, 90)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'SobrenomeLabel
        '
        SobrenomeLabel.AutoSize = True
        SobrenomeLabel.Location = New System.Drawing.Point(43, 116)
        SobrenomeLabel.Name = "SobrenomeLabel"
        SobrenomeLabel.Size = New System.Drawing.Size(64, 13)
        SobrenomeLabel.TabIndex = 5
        SobrenomeLabel.Text = "Sobrenome:"
        '
        'Data_NascLabel
        '
        Data_NascLabel.AutoSize = True
        Data_NascLabel.Location = New System.Drawing.Point(43, 143)
        Data_NascLabel.Name = "Data_NascLabel"
        Data_NascLabel.Size = New System.Drawing.Size(61, 13)
        Data_NascLabel.TabIndex = 7
        Data_NascLabel.Text = "Data Nasc:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(43, 168)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(34, 13)
        SexoLabel.TabIndex = 9
        SexoLabel.Text = "Sexo:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Location = New System.Drawing.Point(43, 194)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(27, 13)
        NIFLabel.TabIndex = 11
        NIFLabel.Text = "NIF:"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Location = New System.Drawing.Point(43, 220)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(35, 13)
        EndereçoLabel.TabIndex = 13
        EndereçoLabel.Text = "Email:"
        '
        'TurmaLabel
        '
        TurmaLabel.AutoSize = True
        TurmaLabel.Location = New System.Drawing.Point(43, 246)
        TurmaLabel.Name = "TurmaLabel"
        TurmaLabel.Size = New System.Drawing.Size(40, 13)
        TurmaLabel.TabIndex = 15
        TurmaLabel.Text = "Turma:"
        '
        'AlunosBindingSource
        '
        Me.AlunosBindingSource.DataMember = "Alunos"
        Me.AlunosBindingSource.DataSource = Me.EscolaDataSet
        '
        'EscolaDataSet
        '
        Me.EscolaDataSet.DataSetName = "EscolaDataSet"
        Me.EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(113, 87)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'SobrenomeTextBox
        '
        Me.SobrenomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "Sobrenome", True))
        Me.SobrenomeTextBox.Enabled = False
        Me.SobrenomeTextBox.Location = New System.Drawing.Point(113, 113)
        Me.SobrenomeTextBox.Name = "SobrenomeTextBox"
        Me.SobrenomeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SobrenomeTextBox.TabIndex = 6
        '
        'Data_NascDateTimePicker
        '
        Me.Data_NascDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AlunosBindingSource, "Data_Nasc", True))
        Me.Data_NascDateTimePicker.Enabled = False
        Me.Data_NascDateTimePicker.Location = New System.Drawing.Point(113, 139)
        Me.Data_NascDateTimePicker.MaxDate = New Date(2005, 12, 31, 0, 0, 0, 0)
        Me.Data_NascDateTimePicker.MinDate = New Date(1999, 1, 1, 0, 0, 0, 0)
        Me.Data_NascDateTimePicker.Name = "Data_NascDateTimePicker"
        Me.Data_NascDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Data_NascDateTimePicker.TabIndex = 8
        Me.Data_NascDateTimePicker.Value = New Date(2005, 12, 31, 0, 0, 0, 0)
        '
        'NIFTextBox
        '
        Me.NIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "NIF", True))
        Me.NIFTextBox.Enabled = False
        Me.NIFTextBox.Location = New System.Drawing.Point(113, 191)
        Me.NIFTextBox.Name = "NIFTextBox"
        Me.NIFTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NIFTextBox.TabIndex = 12
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Enabled = False
        Me.EndereçoTextBox.Location = New System.Drawing.Point(113, 217)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EndereçoTextBox.TabIndex = 14
        '
        'FotoTextBox
        '
        Me.FotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "Foto", True))
        Me.FotoTextBox.Location = New System.Drawing.Point(467, 161)
        Me.FotoTextBox.Name = "FotoTextBox"
        Me.FotoTextBox.Size = New System.Drawing.Size(212, 20)
        Me.FotoTextBox.TabIndex = 18
        '
        'AlunosTableAdapter
        '
        Me.AlunosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PresençasTableAdapter = Nothing
        Me.TableAdapterManager.ProfessoresTableAdapter = Nothing
        Me.TableAdapterManager.Turma_DisciplinaTableAdapter = Nothing
        Me.TableAdapterManager.TurmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(518, 375)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Carregar Imagem"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(662, 492)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Guardar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(432, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Novo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(673, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Editar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.ProjetoFinal.My.Resources.Resources.lapis
        Me.PictureBox10.Location = New System.Drawing.Point(667, 317)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(61, 47)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 28
        Me.PictureBox10.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjetoFinal.My.Resources.Resources._2
        Me.PictureBox1.Location = New System.Drawing.Point(206, 446)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProjetoFinal.My.Resources.Resources._1
        Me.PictureBox2.Location = New System.Drawing.Point(25, 446)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.ProjetoFinal.My.Resources.Resources.back
        Me.PictureBox7.Location = New System.Drawing.Point(117, 446)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(56, 43)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 24
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.ProjetoFinal.My.Resources.Resources.fast_forward
        Me.PictureBox8.Location = New System.Drawing.Point(300, 446)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(56, 43)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 23
        Me.PictureBox8.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ProjetoFinal.My.Resources.Resources.save
        Me.PictureBox5.Location = New System.Drawing.Point(656, 427)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(74, 59)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 21
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProjetoFinal.My.Resources.Resources.plus
        Me.PictureBox4.Location = New System.Drawing.Point(425, 317)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(61, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProjetoFinal.My.Resources.Resources.picture
        Me.PictureBox3.Location = New System.Drawing.Point(541, 312)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(73, 52)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(425, 87)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(303, 201)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 34
        Me.PictureBox9.TabStop = False
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
        'AnoTextBox
        '
        Me.AnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Ano", True))
        Me.AnoTextBox.Enabled = False
        Me.AnoTextBox.Location = New System.Drawing.Point(113, 282)
        Me.AnoTextBox.Name = "AnoTextBox"
        Me.AnoTextBox.Size = New System.Drawing.Size(41, 20)
        Me.AnoTextBox.TabIndex = 37
        Me.AnoTextBox.Visible = False
        '
        'SiglaTextBox
        '
        Me.SiglaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Sigla", True))
        Me.SiglaTextBox.Enabled = False
        Me.SiglaTextBox.Location = New System.Drawing.Point(113, 314)
        Me.SiglaTextBox.Name = "SiglaTextBox"
        Me.SiglaTextBox.Size = New System.Drawing.Size(41, 20)
        Me.SiglaTextBox.TabIndex = 38
        Me.SiglaTextBox.Visible = False
        '
        'CursosBindingSource
        '
        Me.CursosBindingSource.DataMember = "Cursos"
        Me.CursosBindingSource.DataSource = Me.EscolaDataSet
        '
        'CursosTableAdapter
        '
        Me.CursosTableAdapter.ClearBeforeFill = True
        '
        'Diretor_TurmaTextBox
        '
        Me.Diretor_TurmaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Diretor-Turma", True))
        Me.Diretor_TurmaTextBox.Enabled = False
        Me.Diretor_TurmaTextBox.Location = New System.Drawing.Point(113, 348)
        Me.Diretor_TurmaTextBox.Name = "Diretor_TurmaTextBox"
        Me.Diretor_TurmaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Diretor_TurmaTextBox.TabIndex = 40
        Me.Diretor_TurmaTextBox.Visible = False
        '
        'SexoComboBox
        '
        Me.SexoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "Sexo", True))
        Me.SexoComboBox.Enabled = False
        Me.SexoComboBox.FormattingEnabled = True
        Me.SexoComboBox.Items.AddRange(New Object() {"Masculino", "Feminino ", "Indefenido "})
        Me.SexoComboBox.Location = New System.Drawing.Point(113, 165)
        Me.SexoComboBox.Name = "SexoComboBox"
        Me.SexoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SexoComboBox.TabIndex = 41
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.ProjetoFinal.My.Resources.Resources.undo
        Me.PictureBox11.Location = New System.Drawing.Point(705, 12)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(59, 52)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 42
        Me.PictureBox11.TabStop = False
        '
        'TurmaComboBox
        '
        Me.TurmaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "Turma", True))
        Me.TurmaComboBox.DataSource = Me.TurmasBindingSource
        Me.TurmaComboBox.DisplayMember = "ID_Turma"
        Me.TurmaComboBox.Enabled = False
        Me.TurmaComboBox.FormattingEnabled = True
        Me.TurmaComboBox.Location = New System.Drawing.Point(113, 246)
        Me.TurmaComboBox.Name = "TurmaComboBox"
        Me.TurmaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TurmaComboBox.TabIndex = 43
        Me.TurmaComboBox.ValueMember = "ID_Turma"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Ano:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Sigla:"
        Me.Label4.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 351)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Diretor-Turma:"
        Me.Label9.Visible = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.ProjetoFinal.My.Resources.Resources.save
        Me.PictureBox12.Location = New System.Drawing.Point(656, 427)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(74, 59)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 48
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ID_AlunoTextBox
        '
        Me.ID_AlunoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "ID_Aluno", True))
        Me.ID_AlunoTextBox.Enabled = False
        Me.ID_AlunoTextBox.Location = New System.Drawing.Point(162, 61)
        Me.ID_AlunoTextBox.Name = "ID_AlunoTextBox"
        Me.ID_AlunoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_AlunoTextBox.TabIndex = 49
        Me.ID_AlunoTextBox.Visible = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.ProjetoFinal.My.Resources.Resources.list
        Me.PictureBox13.Location = New System.Drawing.Point(425, 429)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(73, 52)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 50
        Me.PictureBox13.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(427, 488)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Listagem"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(336, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 34)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Alunos"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Nome_CursoTextBox
        '
        Me.Nome_CursoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursosBindingSource, "Nome_Curso", True))
        Me.Nome_CursoTextBox.Enabled = False
        Me.Nome_CursoTextBox.Location = New System.Drawing.Point(113, 391)
        Me.Nome_CursoTextBox.Name = "Nome_CursoTextBox"
        Me.Nome_CursoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nome_CursoTextBox.TabIndex = 61
        Me.Nome_CursoTextBox.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 394)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Nome Curso:"
        Me.Label10.Visible = False
        '
        'TurmasBindingSource1
        '
        Me.TurmasBindingSource1.DataMember = "CursosTurmas"
        Me.TurmasBindingSource1.DataSource = Me.CursosBindingSource
        '
        'CursoComboBox
        '
        Me.CursoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "Curso", True))
        Me.CursoComboBox.DataSource = Me.CursosBindingSource
        Me.CursoComboBox.DisplayMember = "ID_Curso"
        Me.CursoComboBox.Enabled = False
        Me.CursoComboBox.FormattingEnabled = True
        Me.CursoComboBox.Location = New System.Drawing.Point(317, 391)
        Me.CursoComboBox.Name = "CursoComboBox"
        Me.CursoComboBox.Size = New System.Drawing.Size(39, 21)
        Me.CursoComboBox.TabIndex = 63
        Me.CursoComboBox.ValueMember = "ID_Curso"
        Me.CursoComboBox.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.ProjetoFinal.My.Resources.Resources.check
        Me.PictureBox6.Location = New System.Drawing.Point(543, 427)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(71, 54)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 64
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(538, 488)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 17)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Validar NIF"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(484, 489)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(172, 17)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Validar Email e Guardar"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label13.Visible = False
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = Global.ProjetoFinal.My.Resources.Resources.check
        Me.PictureBox14.Location = New System.Drawing.Point(543, 427)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(71, 54)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 67
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 23)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(776, 538)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.CursoComboBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Nome_CursoTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.ID_AlunoTextBox)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TurmaComboBox)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.SexoComboBox)
        Me.Controls.Add(Me.Diretor_TurmaTextBox)
        Me.Controls.Add(Me.SiglaTextBox)
        Me.Controls.Add(Me.AnoTextBox)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(SobrenomeLabel)
        Me.Controls.Add(Me.SobrenomeTextBox)
        Me.Controls.Add(Data_NascLabel)
        Me.Controls.Add(Me.Data_NascDateTimePicker)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(NIFLabel)
        Me.Controls.Add(Me.NIFTextBox)
        Me.Controls.Add(EndereçoLabel)
        Me.Controls.Add(Me.EndereçoTextBox)
        Me.Controls.Add(TurmaLabel)
        Me.Controls.Add(Me.FotoTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.AlunosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurmasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EscolaDataSet As EscolaDataSet
    Friend WithEvents AlunosBindingSource As BindingSource
    Friend WithEvents AlunosTableAdapter As EscolaDataSetTableAdapters.AlunosTableAdapter
    Friend WithEvents TableAdapterManager As EscolaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents SobrenomeTextBox As TextBox
    Friend WithEvents Data_NascDateTimePicker As DateTimePicker
    Friend WithEvents NIFTextBox As TextBox
    Friend WithEvents EndereçoTextBox As TextBox
    Friend WithEvents FotoTextBox As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents TurmasBindingSource As BindingSource
    Friend WithEvents TurmasTableAdapter As EscolaDataSetTableAdapters.TurmasTableAdapter
    Friend WithEvents AnoTextBox As TextBox
    Friend WithEvents SiglaTextBox As TextBox
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents CursosTableAdapter As EscolaDataSetTableAdapters.CursosTableAdapter
    Friend WithEvents Diretor_TurmaTextBox As TextBox
    Friend WithEvents SexoComboBox As ComboBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents TurmaComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ID_AlunoTextBox As TextBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Nome_CursoTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TurmasBindingSource1 As BindingSource
    Friend WithEvents CursoComboBox As ComboBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Button1 As Button
End Class
