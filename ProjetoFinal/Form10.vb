Public Class Form10
    Dim var As New EscolaDataSetTableAdapters.ProfessoresTableAdapter
    Dim nif, id As Integer
    Dim nome, sobre, data, sexo, email, pass As String
    Dim disciplina As Integer
    Dim flag As Integer = 0
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Disciplinas' table. You can move, or remove it, as needed.
        Me.DisciplinasTableAdapter.Fill(Me.EscolaDataSet.Disciplinas)
        'TODO: This line of code loads data into the 'EscolaDataSet.Professores' table. You can move, or remove it, as needed.
        Me.ProfessoresTableAdapter.Fill(Me.EscolaDataSet.Professores)

    End Sub



    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If MsgBox("Deseja apagar este professor? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Escola") = MsgBoxResult.Yes Then
            Try
                var.Delete(ID_profTextBox.Text, NomeTextBox.Text, SobrenomeTextBox.Text, Data_NascDateTimePicker.Text, SexoComboBox.Text, EmailTextBox.Text, NIFTextBox.Text, DisciplinaComboBox.Text)
                MsgBox("Registo apagado com Sucesso", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.ProfessoresTableAdapter.Fill(Me.EscolaDataSet.Professores)
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Close()
    End Sub

    Private Sub DisciplinaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisciplinaComboBox.SelectedIndexChanged
        If DisciplinaComboBox.Text <> "" Then
            NomeTextBox1.Visible = True
        Else
            NomeTextBox1.Visible = False
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ProfessoresBindingSource.MoveLast()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ProfessoresBindingSource.MoveNext()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ProfessoresBindingSource.MovePrevious()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ProfessoresBindingSource.MoveFirst()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If MsgBox("Deseja inserir um professor? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Escola") = MsgBoxResult.Yes Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox6.Visible = False
            PictureBox9.Visible = False
            PictureBox5.Visible = False

            Label2.Visible = False
            Label3.Visible = False
            Label7.Visible = False
            Label1.Visible = False
            PictureBox4.Visible = False
            PictureBox3.Visible = False

            Label12.Visible = True
            PictureBox12.Visible = True

            Me.ProfessoresTableAdapter.Fill(Me.EscolaDataSet.Professores)
            ID_profTextBox.Text = "Novo"
            NomeTextBox.Clear()
            SobrenomeTextBox.Clear()
            Data_NascDateTimePicker.Value = "31/12/1995"
            SexoComboBox.SelectedItem = Nothing
            EmailTextBox.Clear()
            NIFTextBox.Clear()
            DisciplinaComboBox.SelectedItem = Nothing
            NIFTextBox.Enabled = True

        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

        If NomeTextBox.Text = "" Or SobrenomeTextBox.Text = "" Or SexoComboBox.SelectedItem = "" Or Data_NascDateTimePicker.Text = "" Or NIFTextBox.Text = "" Or DisciplinaComboBox.Text = "" Or EmailTextBox.Text = "" Then
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
                var.Insert(NomeTextBox.Text, SobrenomeTextBox.Text, Data_NascDateTimePicker.Text, SexoComboBox.Text, EmailTextBox.Text, NIFTextBox.Text, DisciplinaComboBox.Text, PasswordTextBox.Text)
                MsgBox("Registo inserido com Sucesso", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.ProfessoresTableAdapter.Fill(Me.EscolaDataSet.Professores)
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox7.Visible = True
            PictureBox8.Visible = True
            PictureBox6.Visible = True
            PictureBox9.Visible = True
            PictureBox5.Visible = True

            Label2.Visible = True
            Label3.Visible = True
            Label7.Visible = True
            Label1.Visible = True
            PictureBox4.Visible = True
            PictureBox3.Visible = True

            Label8.Visible = False
            PictureBox8.Visible = False
            Button1.Visible = False
            PasswordTextBox.Visible = False
            Label4.Visible = False
        End If

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Dim par As String

        If flag = 1 Then
            par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
            If System.Text.RegularExpressions.Regex.IsMatch(EmailTextBox.Text, par) Then
                MsgBox("Válidado com Sucesso", MsgBoxStyle.Information, "Email")
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
                PictureBox14.Visible = False
                Button1.Visible = False
                Label3.Visible = False
            Else
                MsgBox("Introduza um Email correto. Ex:Diogo@gmail.com", MsgBoxStyle.Critical, "Email")
                EmailTextBox.Clear()
                EmailTextBox.Focus()

            End If
        Else

            par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
            If System.Text.RegularExpressions.Regex.IsMatch(EmailTextBox.Text, par) Then
                MsgBox("Válidado com Sucesso", MsgBoxStyle.Information, "Email")
                ID_profTextBox.Text = "Novo"
                NomeTextBox.Enabled = False
                SobrenomeTextBox.Enabled = False
                Data_NascDateTimePicker.Enabled = False
                SexoComboBox.Enabled = False
                EmailTextBox.Enabled = False
                NIFTextBox.Enabled = False
                DisciplinaComboBox.Enabled = False
                Label8.Visible = True
                PictureBox8.Visible = True
                Label13.Visible = False
                PictureBox14.Visible = False
                PasswordTextBox.Enabled = False


            Else
                MsgBox("Introduza um Email correto. Ex:Diogo@gmail.com", MsgBoxStyle.Critical, "Email")
                EmailTextBox.Clear()
                EmailTextBox.Focus()

            End If

        End If
        Label13.Visible = False

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Dim contar As Integer
        Dim nif2 As String
        flag = 1
        nif2 = NIFTextBox.Text
        contar = Len(NIFTextBox.Text)
        If contar < 9 Then
            MsgBox("Insira um NIF correto. Ex:123456789", MsgBoxStyle.Critical, "Aviso")
        Else
            If nif = nif2 Then
                Label13.Visible = True
                PictureBox14.Visible = True
                PictureBox13.Visible = False
                Label12.Visible = False
                NIFTextBox.Enabled = False
            Else
                ProfessoresBindingSource.Filter = "NIF = " & NIFTextBox.Text
                If ProfessoresBindingSource.Count = 0 Then
                    ProfessoresBindingSource.RemoveFilter()
                    NIFTextBox.Enabled = False
                    Label13.Visible = True
                PictureBox14.Visible = True
                    Label13.Visible = False
                    PictureBox13.Visible = False
                Else
                MsgBox("O NIF Introduzido já se encontra registado!", MsgBoxStyle.Critical, "Erro!")
                Me.DisciplinasTableAdapter.Fill(Me.EscolaDataSet.Disciplinas)
                ProfessoresBindingSource.RemoveFilter()
                PictureBox1.Visible = True
                PictureBox2.Visible = True
                PictureBox7.Visible = True
                PictureBox8.Visible = True
                PictureBox6.Visible = True
                PictureBox9.Visible = True
                PictureBox5.Visible = True

                Label2.Visible = True
                Label3.Visible = True
                Label7.Visible = True
                Label1.Visible = True
                PictureBox4.Visible = True
                PictureBox3.Visible = True

                NomeTextBox.Enabled = False
                SobrenomeTextBox.Enabled = False
                Data_NascDateTimePicker.Enabled = False
                SexoComboBox.Enabled = False
                EmailTextBox.Enabled = False
                NIFTextBox.Enabled = False
                    DisciplinaComboBox.Enabled = False
                    Button1.Visible = False
                    PasswordTextBox.Enabled = False

                End If
        End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form9.Show()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim contar As Integer
        Dim nif3 As String
        nif3 = NIFTextBox.Text
        contar = Len(NIFTextBox.Text)
        If contar < 9 Then
            MsgBox("Insira um NIF correto. Ex:123456789", MsgBoxStyle.Critical, "Aviso")
        Else

            ProfessoresBindingSource.Filter = "NIF = " & NIFTextBox.Text
            If ProfessoresBindingSource.Count = 0 Then
                ProfessoresBindingSource.RemoveFilter()
                ID_profTextBox.Text = "Novo"
                NomeTextBox.Focus()
                NomeTextBox.Clear()
                SobrenomeTextBox.Clear()
                Data_NascDateTimePicker.Value = "31/12/1995"
                SexoComboBox.SelectedItem = Nothing
                EmailTextBox.Clear()
                DisciplinaComboBox.SelectedItem = Nothing
                NIFTextBox.Text = nif3
                NomeTextBox.Focus()
                NomeTextBox.Enabled = True
                SobrenomeTextBox.Enabled = True
                Data_NascDateTimePicker.Enabled = True
                SexoComboBox.Enabled = True
                EmailTextBox.Enabled = True
                NIFTextBox.Enabled = False
                DisciplinaComboBox.Enabled = True
                Label13.Visible = True
                PictureBox14.Visible = True
                Label12.Visible = False
                PictureBox12.Visible = False
                Button1.Visible = True
                PasswordTextBox.Enabled = True
                PasswordTextBox.Visible = True
                Label4.Visible = True
                PasswordTextBox.Clear()
            Else
                MsgBox("O NIF Introduzido já se encontra registado!", MsgBoxStyle.Critical, "Erro!")
                Me.DisciplinasTableAdapter.Fill(Me.EscolaDataSet.Disciplinas)
                ProfessoresBindingSource.RemoveFilter()
                PictureBox1.Visible = True
                PictureBox2.Visible = True
                PictureBox7.Visible = True
                PictureBox8.Visible = True
                PictureBox6.Visible = True
                PictureBox9.Visible = True
                PictureBox5.Visible = True

                Label2.Visible = True
                Label3.Visible = True
                Label7.Visible = True
                Label1.Visible = True
                PictureBox4.Visible = True
                PictureBox3.Visible = True

                NomeTextBox.Enabled = False
                SobrenomeTextBox.Enabled = False
                Data_NascDateTimePicker.Enabled = False
                SexoComboBox.Enabled = False
                EmailTextBox.Enabled = False
                NIFTextBox.Enabled = False
                DisciplinaComboBox.Enabled = False
                Button1.Visible = False
                PasswordTextBox.Enabled = False

            End If
        End If


    End Sub

    Private Sub NIFTextBox_TextChanged(sender As Object, e As EventArgs) Handles NIFTextBox.TextChanged
        Dim contar As Integer
        contar = Len(NIFTextBox.Text)
        If contar > 9 Then
            MsgBox("Insira um NIF correto. Ex:123456789", MsgBoxStyle.Critical, "Aviso")
            NIFTextBox.Clear()
            NIFTextBox.Focus()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        Form11.Show()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If MsgBox("Deseja alterar este professor? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Escola") = MsgBoxResult.Yes Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox6.Visible = False
            PictureBox9.Visible = False
            PictureBox5.Visible = False
            ID_profTextBox.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label7.Visible = False
            Label1.Visible = False
            PictureBox4.Visible = False
            PictureBox3.Visible = False
            Label12.Visible = True
            PictureBox13.Visible = True

            NomeTextBox.Enabled = True
            SobrenomeTextBox.Enabled = True
            Data_NascDateTimePicker.Enabled = True
            SexoComboBox.Enabled = True
            EmailTextBox.Enabled = True
            NIFTextBox.Enabled = True
            DisciplinaComboBox.Enabled = True
            Button1.Visible = True
            id = ID_profTextBox.Text
            nome = NomeTextBox.Text
            sobre = SobrenomeTextBox.Text
            data = Data_NascDateTimePicker.Text
            nif = NIFTextBox.Text
            sexo = SexoComboBox.Text
            email = EmailTextBox.Text
            disciplina = DisciplinaComboBox.Text
            pass = PasswordTextBox.Text
            PictureBox10.Visible = True

        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

        If NomeTextBox.Text = "" Or SobrenomeTextBox.Text = "" Or SexoComboBox.SelectedItem = "" Or Data_NascDateTimePicker.Text = "" Or NIFTextBox.Text = "" Or DisciplinaComboBox.Text = "" Or EmailTextBox.Text = "" Then
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
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox7.Visible = True
            PictureBox8.Visible = True
            PictureBox6.Visible = True
            PictureBox9.Visible = True
            PictureBox5.Visible = True

            Label2.Visible = True
            Label3.Visible = True
            Label7.Visible = True
            Label1.Visible = True
            PictureBox4.Visible = True
            PictureBox3.Visible = True

            Label8.Visible = False
            PictureBox8.Visible = False
            Button1.Visible = False
            PictureBox11.Visible = False
        End If
    End Sub
End Class