<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim SobrenomeLabel As System.Windows.Forms.Label
        Dim Data_NascLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim DisciplinaLabel As System.Windows.Forms.Label
        Me.EscolaDataSet = New ProjetoFinal.EscolaDataSet()
        Me.ProfessoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfessoresTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.ProfessoresTableAdapter()
        Me.TableAdapterManager = New ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager()
        Me.ID_profTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.SobrenomeTextBox = New System.Windows.Forms.TextBox()
        Me.Data_NascDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.NIFTextBox = New System.Windows.Forms.TextBox()
        Me.DisciplinaComboBox = New System.Windows.Forms.ComboBox()
        Me.DisciplinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DisciplinasTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.DisciplinasTableAdapter()
        Me.NomeTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SexoComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        SobrenomeLabel = New System.Windows.Forms.Label()
        Data_NascLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        DisciplinaLabel = New System.Windows.Forms.Label()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfessoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisciplinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(213, 93)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'SobrenomeLabel
        '
        SobrenomeLabel.AutoSize = True
        SobrenomeLabel.Location = New System.Drawing.Point(213, 119)
        SobrenomeLabel.Name = "SobrenomeLabel"
        SobrenomeLabel.Size = New System.Drawing.Size(64, 13)
        SobrenomeLabel.TabIndex = 5
        SobrenomeLabel.Text = "Sobrenome:"
        '
        'Data_NascLabel
        '
        Data_NascLabel.AutoSize = True
        Data_NascLabel.Location = New System.Drawing.Point(213, 146)
        Data_NascLabel.Name = "Data_NascLabel"
        Data_NascLabel.Size = New System.Drawing.Size(61, 13)
        Data_NascLabel.TabIndex = 7
        Data_NascLabel.Text = "Data Nasc:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(213, 171)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(34, 13)
        SexoLabel.TabIndex = 9
        SexoLabel.Text = "Sexo:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(213, 197)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "Email:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Location = New System.Drawing.Point(213, 223)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(27, 13)
        NIFLabel.TabIndex = 13
        NIFLabel.Text = "NIF:"
        '
        'DisciplinaLabel
        '
        DisciplinaLabel.AutoSize = True
        DisciplinaLabel.Location = New System.Drawing.Point(213, 249)
        DisciplinaLabel.Name = "DisciplinaLabel"
        DisciplinaLabel.Size = New System.Drawing.Size(55, 13)
        DisciplinaLabel.TabIndex = 15
        DisciplinaLabel.Text = "Disciplina:"
        '
        'EscolaDataSet
        '
        Me.EscolaDataSet.DataSetName = "EscolaDataSet"
        Me.EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfessoresBindingSource
        '
        Me.ProfessoresBindingSource.DataMember = "Professores"
        Me.ProfessoresBindingSource.DataSource = Me.EscolaDataSet
        '
        'ProfessoresTableAdapter
        '
        Me.ProfessoresTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ProfessoresTableAdapter = Me.ProfessoresTableAdapter
        Me.TableAdapterManager.Turma_DisciplinaTableAdapter = Nothing
        Me.TableAdapterManager.TurmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ID_profTextBox
        '
        Me.ID_profTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "ID_prof", True))
        Me.ID_profTextBox.Enabled = False
        Me.ID_profTextBox.Location = New System.Drawing.Point(347, 64)
        Me.ID_profTextBox.Name = "ID_profTextBox"
        Me.ID_profTextBox.Size = New System.Drawing.Size(58, 20)
        Me.ID_profTextBox.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(283, 90)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'SobrenomeTextBox
        '
        Me.SobrenomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "Sobrenome", True))
        Me.SobrenomeTextBox.Enabled = False
        Me.SobrenomeTextBox.Location = New System.Drawing.Point(283, 116)
        Me.SobrenomeTextBox.Name = "SobrenomeTextBox"
        Me.SobrenomeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SobrenomeTextBox.TabIndex = 6
        '
        'Data_NascDateTimePicker
        '
        Me.Data_NascDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProfessoresBindingSource, "Data_Nasc", True))
        Me.Data_NascDateTimePicker.Enabled = False
        Me.Data_NascDateTimePicker.Location = New System.Drawing.Point(283, 142)
        Me.Data_NascDateTimePicker.MaxDate = New Date(1995, 12, 31, 0, 0, 0, 0)
        Me.Data_NascDateTimePicker.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.Data_NascDateTimePicker.Name = "Data_NascDateTimePicker"
        Me.Data_NascDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Data_NascDateTimePicker.TabIndex = 8
        Me.Data_NascDateTimePicker.Value = New Date(1995, 12, 31, 0, 0, 0, 0)
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(283, 194)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 12
        '
        'NIFTextBox
        '
        Me.NIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "NIF", True))
        Me.NIFTextBox.Enabled = False
        Me.NIFTextBox.Location = New System.Drawing.Point(283, 220)
        Me.NIFTextBox.Name = "NIFTextBox"
        Me.NIFTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NIFTextBox.TabIndex = 14
        '
        'DisciplinaComboBox
        '
        Me.DisciplinaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "Disciplina", True))
        Me.DisciplinaComboBox.DataSource = Me.DisciplinasBindingSource
        Me.DisciplinaComboBox.DisplayMember = "ID_disciplina"
        Me.DisciplinaComboBox.Enabled = False
        Me.DisciplinaComboBox.FormattingEnabled = True
        Me.DisciplinaComboBox.Location = New System.Drawing.Point(283, 246)
        Me.DisciplinaComboBox.Name = "DisciplinaComboBox"
        Me.DisciplinaComboBox.Size = New System.Drawing.Size(58, 21)
        Me.DisciplinaComboBox.TabIndex = 16
        Me.DisciplinaComboBox.ValueMember = "ID_disciplina"
        '
        'DisciplinasBindingSource
        '
        Me.DisciplinasBindingSource.DataMember = "Disciplinas"
        Me.DisciplinasBindingSource.DataSource = Me.EscolaDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(509, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Listagem"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 433)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Editar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(605, 423)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Guardar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 433)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Novo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.ProjetoFinal.My.Resources.Resources._16326021
        Me.PictureBox6.Location = New System.Drawing.Point(239, 383)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 71
        Me.PictureBox6.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.ProjetoFinal.My.Resources.Resources.save
        Me.PictureBox8.Location = New System.Drawing.Point(606, 383)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 70
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.ProjetoFinal.My.Resources.Resources.undo
        Me.PictureBox10.Location = New System.Drawing.Point(664, 12)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 69
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.ProjetoFinal.My.Resources.Resources.check
        Me.PictureBox11.Location = New System.Drawing.Point(606, 383)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 64
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Visible = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.ProjetoFinal.My.Resources.Resources.list
        Me.PictureBox9.Location = New System.Drawing.Point(512, 383)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 63
        Me.PictureBox9.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.ProjetoFinal.My.Resources.Resources.lapis
        Me.PictureBox7.Location = New System.Drawing.Point(132, 383)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 62
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ProjetoFinal.My.Resources.Resources.plus
        Me.PictureBox5.Location = New System.Drawing.Point(31, 383)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 61
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProjetoFinal.My.Resources.Resources.fast_forward
        Me.PictureBox4.Location = New System.Drawing.Point(489, 317)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(57, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 60
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProjetoFinal.My.Resources.Resources._2
        Me.PictureBox3.Location = New System.Drawing.Point(389, 317)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(57, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 59
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProjetoFinal.My.Resources.Resources.back
        Me.PictureBox2.Location = New System.Drawing.Point(292, 317)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjetoFinal.My.Resources.Resources._1
        Me.PictureBox1.Location = New System.Drawing.Point(198, 317)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(242, 433)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Apagar"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DisciplinasTableAdapter
        '
        Me.DisciplinasTableAdapter.ClearBeforeFill = True
        '
        'NomeTextBox1
        '
        Me.NomeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DisciplinasBindingSource, "Nome", True))
        Me.NomeTextBox1.Enabled = False
        Me.NomeTextBox1.Location = New System.Drawing.Point(347, 246)
        Me.NomeTextBox1.Name = "NomeTextBox1"
        Me.NomeTextBox1.Size = New System.Drawing.Size(136, 20)
        Me.NomeTextBox1.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(301, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 34)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Professores"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SexoComboBox
        '
        Me.SexoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "Sexo", True))
        Me.SexoComboBox.Enabled = False
        Me.SexoComboBox.FormattingEnabled = True
        Me.SexoComboBox.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.SexoComboBox.Location = New System.Drawing.Point(284, 168)
        Me.SexoComboBox.Name = "SexoComboBox"
        Me.SexoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SexoComboBox.TabIndex = 76
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = Global.ProjetoFinal.My.Resources.Resources.check
        Me.PictureBox14.Location = New System.Drawing.Point(406, 383)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 80
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(386, 423)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 17)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Validar Email"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(392, 423)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 17)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Validar NIF"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label12.Visible = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.ProjetoFinal.My.Resources.Resources.check
        Me.PictureBox12.Location = New System.Drawing.Point(406, 383)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 77
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Visible = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.ProjetoFinal.My.Resources.Resources.check
        Me.PictureBox13.Location = New System.Drawing.Point(406, 383)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 81
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(489, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 23)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(283, 273)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PasswordTextBox.TabIndex = 83
        Me.PasswordTextBox.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Password:"
        Me.Label4.Visible = False
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 470)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.SexoComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NomeTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ID_profTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(SobrenomeLabel)
        Me.Controls.Add(Me.SobrenomeTextBox)
        Me.Controls.Add(Data_NascLabel)
        Me.Controls.Add(Me.Data_NascDateTimePicker)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(NIFLabel)
        Me.Controls.Add(Me.NIFTextBox)
        Me.Controls.Add(DisciplinaLabel)
        Me.Controls.Add(Me.DisciplinaComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form10"
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfessoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisciplinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EscolaDataSet As EscolaDataSet
    Friend WithEvents ProfessoresBindingSource As BindingSource
    Friend WithEvents ProfessoresTableAdapter As EscolaDataSetTableAdapters.ProfessoresTableAdapter
    Friend WithEvents TableAdapterManager As EscolaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_profTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents SobrenomeTextBox As TextBox
    Friend WithEvents Data_NascDateTimePicker As DateTimePicker
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents NIFTextBox As TextBox
    Friend WithEvents DisciplinaComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DisciplinasBindingSource As BindingSource
    Friend WithEvents DisciplinasTableAdapter As EscolaDataSetTableAdapters.DisciplinasTableAdapter
    Friend WithEvents NomeTextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SexoComboBox As ComboBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label4 As Label
End Class
