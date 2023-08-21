<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form22
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
        Dim ID_profLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim SobrenomeLabel As System.Windows.Forms.Label
        Dim Data_NascLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim DisciplinaLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.EscolaDataSet = New ProjetoFinal.EscolaDataSet()
        Me.ProfessoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfessoresTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.ProfessoresTableAdapter()
        Me.TableAdapterManager = New ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager()
        Me.DisciplinasTableAdapter = New ProjetoFinal.EscolaDataSetTableAdapters.DisciplinasTableAdapter()
        Me.ID_profTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.SobrenomeTextBox = New System.Windows.Forms.TextBox()
        Me.Data_NascDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SexoComboBox = New System.Windows.Forms.ComboBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.NIFTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.DisciplinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomeTextBox1 = New System.Windows.Forms.TextBox()
        Me.DisciplinaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        ID_profLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        SobrenomeLabel = New System.Windows.Forms.Label()
        Data_NascLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        DisciplinaLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfessoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisciplinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_profLabel
        '
        ID_profLabel.AutoSize = True
        ID_profLabel.Location = New System.Drawing.Point(165, 123)
        ID_profLabel.Name = "ID_profLabel"
        ID_profLabel.Size = New System.Drawing.Size(42, 13)
        ID_profLabel.TabIndex = 10
        ID_profLabel.Text = "ID prof:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(165, 149)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 12
        NomeLabel.Text = "Nome:"
        '
        'SobrenomeLabel
        '
        SobrenomeLabel.AutoSize = True
        SobrenomeLabel.Location = New System.Drawing.Point(165, 175)
        SobrenomeLabel.Name = "SobrenomeLabel"
        SobrenomeLabel.Size = New System.Drawing.Size(64, 13)
        SobrenomeLabel.TabIndex = 14
        SobrenomeLabel.Text = "Sobrenome:"
        '
        'Data_NascLabel
        '
        Data_NascLabel.AutoSize = True
        Data_NascLabel.Location = New System.Drawing.Point(165, 202)
        Data_NascLabel.Name = "Data_NascLabel"
        Data_NascLabel.Size = New System.Drawing.Size(61, 13)
        Data_NascLabel.TabIndex = 16
        Data_NascLabel.Text = "Data Nasc:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(165, 227)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(34, 13)
        SexoLabel.TabIndex = 18
        SexoLabel.Text = "Sexo:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(165, 254)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 20
        EmailLabel.Text = "email:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Location = New System.Drawing.Point(165, 280)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(27, 13)
        NIFLabel.TabIndex = 22
        NIFLabel.Text = "NIF:"
        '
        'DisciplinaLabel
        '
        DisciplinaLabel.AutoSize = True
        DisciplinaLabel.Location = New System.Drawing.Point(165, 306)
        DisciplinaLabel.Name = "DisciplinaLabel"
        DisciplinaLabel.Size = New System.Drawing.Size(55, 13)
        DisciplinaLabel.TabIndex = 24
        DisciplinaLabel.Text = "Disciplina:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(165, 332)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 26
        PasswordLabel.Text = "Password:"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox4.Image = Global.ProjetoFinal.My.Resources.Resources.emblemunreadable_934871
        Me.PictureBox4.Location = New System.Drawing.Point(557, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(41, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
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
        Me.TableAdapterManager.DisciplinasTableAdapter = Me.DisciplinasTableAdapter
        Me.TableAdapterManager.Modulo_DisciplinaTableAdapter = Nothing
        Me.TableAdapterManager.ModuloTableAdapter = Nothing
        Me.TableAdapterManager.PresençasTableAdapter = Nothing
        Me.TableAdapterManager.ProfessoresTableAdapter = Me.ProfessoresTableAdapter
        Me.TableAdapterManager.Turma_DisciplinaTableAdapter = Nothing
        Me.TableAdapterManager.TurmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjetoFinal.EscolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DisciplinasTableAdapter
        '
        Me.DisciplinasTableAdapter.ClearBeforeFill = True
        '
        'ID_profTextBox
        '
        Me.ID_profTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "ID_prof", True))
        Me.ID_profTextBox.Enabled = False
        Me.ID_profTextBox.Location = New System.Drawing.Point(235, 120)
        Me.ID_profTextBox.Name = "ID_profTextBox"
        Me.ID_profTextBox.Size = New System.Drawing.Size(53, 20)
        Me.ID_profTextBox.TabIndex = 11
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(235, 146)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomeTextBox.TabIndex = 13
        '
        'SobrenomeTextBox
        '
        Me.SobrenomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "Sobrenome", True))
        Me.SobrenomeTextBox.Enabled = False
        Me.SobrenomeTextBox.Location = New System.Drawing.Point(235, 172)
        Me.SobrenomeTextBox.Name = "SobrenomeTextBox"
        Me.SobrenomeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SobrenomeTextBox.TabIndex = 15
        '
        'Data_NascDateTimePicker
        '
        Me.Data_NascDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProfessoresBindingSource, "Data_Nasc", True))
        Me.Data_NascDateTimePicker.Enabled = False
        Me.Data_NascDateTimePicker.Location = New System.Drawing.Point(235, 198)
        Me.Data_NascDateTimePicker.MaxDate = New Date(1999, 12, 31, 0, 0, 0, 0)
        Me.Data_NascDateTimePicker.MinDate = New Date(1955, 12, 31, 0, 0, 0, 0)
        Me.Data_NascDateTimePicker.Name = "Data_NascDateTimePicker"
        Me.Data_NascDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Data_NascDateTimePicker.TabIndex = 17
        Me.Data_NascDateTimePicker.Value = New Date(1999, 12, 31, 0, 0, 0, 0)
        '
        'SexoComboBox
        '
        Me.SexoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "Sexo", True))
        Me.SexoComboBox.Enabled = False
        Me.SexoComboBox.FormattingEnabled = True
        Me.SexoComboBox.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.SexoComboBox.Location = New System.Drawing.Point(235, 224)
        Me.SexoComboBox.Name = "SexoComboBox"
        Me.SexoComboBox.Size = New System.Drawing.Size(200, 21)
        Me.SexoComboBox.TabIndex = 19
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(235, 251)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 21
        '
        'NIFTextBox
        '
        Me.NIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "NIF", True))
        Me.NIFTextBox.Enabled = False
        Me.NIFTextBox.Location = New System.Drawing.Point(235, 277)
        Me.NIFTextBox.Name = "NIFTextBox"
        Me.NIFTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NIFTextBox.TabIndex = 23
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "Password", True))
        Me.PasswordTextBox.Enabled = False
        Me.PasswordTextBox.Location = New System.Drawing.Point(235, 329)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PasswordTextBox.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Editar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.ProjetoFinal.My.Resources.Resources.lapis
        Me.PictureBox7.Location = New System.Drawing.Point(70, 382)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 68
        Me.PictureBox7.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(474, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Guardar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label8.Visible = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.ProjetoFinal.My.Resources.Resources.check
        Me.PictureBox11.Location = New System.Drawing.Point(475, 382)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(61, 37)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 86
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Visible = False
        '
        'DisciplinasBindingSource
        '
        Me.DisciplinasBindingSource.DataMember = "Disciplinas"
        Me.DisciplinasBindingSource.DataSource = Me.EscolaDataSet
        '
        'NomeTextBox1
        '
        Me.NomeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DisciplinasBindingSource, "Nome", True))
        Me.NomeTextBox1.Enabled = False
        Me.NomeTextBox1.Location = New System.Drawing.Point(281, 303)
        Me.NomeTextBox1.Name = "NomeTextBox1"
        Me.NomeTextBox1.Size = New System.Drawing.Size(154, 20)
        Me.NomeTextBox1.TabIndex = 88
        '
        'DisciplinaComboBox
        '
        Me.DisciplinaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "Disciplina", True))
        Me.DisciplinaComboBox.DataSource = Me.DisciplinasBindingSource
        Me.DisciplinaComboBox.DisplayMember = "ID_disciplina"
        Me.DisciplinaComboBox.Enabled = False
        Me.DisciplinaComboBox.FormattingEnabled = True
        Me.DisciplinaComboBox.Location = New System.Drawing.Point(234, 302)
        Me.DisciplinaComboBox.Name = "DisciplinaComboBox"
        Me.DisciplinaComboBox.Size = New System.Drawing.Size(41, 21)
        Me.DisciplinaComboBox.TabIndex = 89
        Me.DisciplinaComboBox.ValueMember = "ID_disciplina"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(-1, -3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(616, 83)
        Me.Label6.TabIndex = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(229, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 34)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Definições"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form22
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 464)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DisciplinaComboBox)
        Me.Controls.Add(Me.NomeTextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(ID_profLabel)
        Me.Controls.Add(Me.ID_profTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(SobrenomeLabel)
        Me.Controls.Add(Me.SobrenomeTextBox)
        Me.Controls.Add(Data_NascLabel)
        Me.Controls.Add(Me.Data_NascDateTimePicker)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(Me.SexoComboBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(NIFLabel)
        Me.Controls.Add(Me.NIFTextBox)
        Me.Controls.Add(DisciplinaLabel)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form22"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form22"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EscolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfessoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisciplinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents EscolaDataSet As EscolaDataSet
    Friend WithEvents ProfessoresBindingSource As BindingSource
    Friend WithEvents ProfessoresTableAdapter As EscolaDataSetTableAdapters.ProfessoresTableAdapter
    Friend WithEvents TableAdapterManager As EscolaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_profTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents SobrenomeTextBox As TextBox
    Friend WithEvents Data_NascDateTimePicker As DateTimePicker
    Friend WithEvents SexoComboBox As ComboBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents NIFTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents DisciplinasTableAdapter As EscolaDataSetTableAdapters.DisciplinasTableAdapter
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents DisciplinasBindingSource As BindingSource
    Friend WithEvents NomeTextBox1 As TextBox
    Friend WithEvents DisciplinaComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
End Class
