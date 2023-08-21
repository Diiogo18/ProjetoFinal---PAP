Public Class Form22
    Dim var As New EscolaDataSetTableAdapters.ProfessoresTableAdapter
    Dim nif, id As Integer
    Dim nome, sobre, data, sexo, email, pass As String
    Dim problema As Integer = 0

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim contar As Integer
        Dim nif2 As String

        nif2 = nif
        contar = Len(NIFTextBox.Text)
        If contar < 9 Then
            MsgBox("Insira um NIF correto. Ex:123456789", MsgBoxStyle.Critical, "Aviso")
            problema = 1
        Else
            If nif = nif2 Then
                NIFTextBox.Enabled = False
            Else
                ProfessoresBindingSource.Filter = "NIF = " & NIFTextBox.Text
                If ProfessoresBindingSource.Count = 0 Then
                    ProfessoresBindingSource.RemoveFilter()
                    NIFTextBox.Enabled = False

                Else
                    MsgBox("O NIF Introduzido já se encontra registado!", MsgBoxStyle.Critical, "Erro!")
                    Me.DisciplinasTableAdapter.Fill(Me.EscolaDataSet.Disciplinas)
                    ProfessoresBindingSource.RemoveFilter()


                    PictureBox4.Visible = True

                    problema = 1
                    NomeTextBox.Enabled = False
                    SobrenomeTextBox.Enabled = False
                    Data_NascDateTimePicker.Enabled = False
                    SexoComboBox.Enabled = False
                    EmailTextBox.Enabled = False
                    NIFTextBox.Enabled = False
                    DisciplinaComboBox.Enabled = False
                    PasswordTextBox.Enabled = False

                End If
            End If
        End If
        If problema <> 1 Then

            Dim par As String

            If flag = 1 Then
                par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
                If System.Text.RegularExpressions.Regex.IsMatch(EmailTextBox.Text, par) Then
                    MsgBox("Email válido com sucesso", MsgBoxStyle.Information, "Email")
                    ID_profTextBox.Text = "Novo"
                    NomeTextBox.Enabled = False
                    SobrenomeTextBox.Enabled = False
                    Data_NascDateTimePicker.Enabled = False
                    SexoComboBox.Enabled = False
                    EmailTextBox.Enabled = False
                    NIFTextBox.Enabled = False
                    DisciplinaComboBox.Enabled = False
                    Label8.Visible = True
                    PictureBox11.Visible = True
                    Label8.Visible = True
                    PasswordTextBox.Enabled = False

                Else
                    MsgBox("Introduza um Email correto. Ex:Diogo@gmail.com", MsgBoxStyle.Critical, "Email")
                    EmailTextBox.Clear()
                    EmailTextBox.Focus()
                    problema = 2
                End If

            End If
            If problema <> 2 And problema <> 1 Then
                If NomeTextBox.Text = "" Or SobrenomeTextBox.Text = "" Or SexoComboBox.SelectedItem = "" Or Data_NascDateTimePicker.Text = "" Or NIFTextBox.Text = "" Or DisciplinaComboBox.Text = "" Or EmailTextBox.Text = "" Or PasswordTextBox.Text = "" Then
                    MsgBox("Introduza Todos os Dados", MsgBoxStyle.Critical, "Aviso!")
                    ID_profTextBox.Text = "Novo"
                    NomeTextBox.Focus()
                    NomeTextBox.Enabled = True
                    SobrenomeTextBox.Enabled = True
                    Data_NascDateTimePicker.Enabled = True
                    SexoComboBox.Enabled = True
                    DisciplinaComboBox.Enabled = True
                Else
                    Try
                        var.Update(NomeTextBox.Text, SobrenomeTextBox.Text, Data_NascDateTimePicker.Text, SexoComboBox.Text, EmailTextBox.Text, NIFTextBox.Text, DisciplinaComboBox.Text, PasswordTextBox.Text, id, nome, sobre, data, sexo, email, nif, disciplina)
                        MsgBox("Registo alterado com Sucesso", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Me.ProfessoresTableAdapter.Fill(Me.EscolaDataSet.Professores)

                    PictureBox7.Visible = True
                    Label1.Visible = True
                    NomeTextBox.Enabled = False
                    SobrenomeTextBox.Enabled = False
                    Data_NascDateTimePicker.Enabled = False
                    SexoComboBox.Enabled = False
                    EmailTextBox.Enabled = False
                    NIFTextBox.Enabled = False
                    PasswordTextBox.Enabled = False

                    Label8.Visible = False
                    PictureBox11.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs)

    End Sub

    Dim flag As Integer

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs)

    End Sub

    Dim disciplina As Integer
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
        Form20.Show()
    End Sub


    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Disciplinas' table. You can move, or remove it, as needed.
        Me.DisciplinasTableAdapter.Fill(Me.EscolaDataSet.Disciplinas)
        'TODO: This line of code loads data into the 'EscolaDataSet.Professores' table. You can move, or remove it, as needed.
        Me.ProfessoresTableAdapter.Fill(Me.EscolaDataSet.Professores)
        ProfessoresBindingSource.Filter = "(ID_prof = '" & codigoprof & "') "
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If MsgBox("Deseja alterar? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Escola") = MsgBoxResult.Yes Then
            PictureBox7.Visible = False
            Label1.Visible = False
            ID_profTextBox.Visible = True
            Label8.Visible = True
            PictureBox11.Visible = True

            NomeTextBox.Enabled = True
            SobrenomeTextBox.Enabled = True
            Data_NascDateTimePicker.Enabled = True
            SexoComboBox.Enabled = True
            EmailTextBox.Enabled = True
            NIFTextBox.Enabled = True
            PasswordTextBox.Enabled = True
            id = ID_profTextBox.Text
            nome = NomeTextBox.Text
            sobre = SobrenomeTextBox.Text
            data = Data_NascDateTimePicker.Text
            nif = NIFTextBox.Text
            sexo = SexoComboBox.Text
            email = EmailTextBox.Text
            disciplina = DisciplinaComboBox.Text
            pass = PasswordTextBox.Text


        End If
    End Sub
End Class