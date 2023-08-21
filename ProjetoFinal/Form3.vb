Public Class Form3
    Dim var As New EscolaDataSetTableAdapters.AlunosTableAdapter
    Dim nom, sob, ende, sex, data, foto As String
    Dim nif, turma, numero, cont As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Cursos' table. You can move, or remove it, as needed.
        Me.CursosTableAdapter.Fill(Me.EscolaDataSet.Cursos)
        'TODO: This line of code loads data into the 'EscolaDataSet.Turmas' table. You can move, or remove it, as needed.
        Me.TurmasTableAdapter.Fill(Me.EscolaDataSet.Turmas)
        'TODO: This line of code loads data into the 'EscolaDataSet.Alunos' table. You can move, or remove it, as needed.
        Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.Alunos)
        PictureBox9.ImageLocation = Application.StartupPath & "\imagens\" & FotoTextBox.Text

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Close()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If MsgBox("Deseja inserir um novo aluno? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Escola") = MsgBoxResult.Yes Then
            PictureBox14.Visible = True
            Label12.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox13.Visible = False
            Label2.Visible = False
            Label7.Visible = False
            Label1.Visible = False
            PictureBox4.Visible = False
            PictureBox10.Visible = False
            Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.Alunos)
            NomeTextBox.Enabled = False
            NomeTextBox.Clear()

            SobrenomeTextBox.Clear()
            NIFTextBox.Enabled = True
            NIFTextBox.Clear()

            Data_NascDateTimePicker.Value = "31/12/2005"

            SexoComboBox.SelectedItem = Nothing
            TurmaComboBox.SelectedItem = Nothing
            FotoTextBox.Clear()
            PictureBox9.ImageLocation = Nothing
            EndereçoTextBox.Clear()
            NomeTextBox.Focus()

        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        If NomeTextBox.Text = "" Or SobrenomeTextBox.Text = "" Or SexoComboBox.SelectedItem = "" Or Data_NascDateTimePicker.Text = "" Or NIFTextBox.Text = "" Or TurmaComboBox.Text = "" Or EndereçoTextBox.Text = "" Then
            MsgBox("Introduza Todos os Dados", MsgBoxStyle.Critical, "Aviso!")
            NomeTextBox.Enabled = True
            SobrenomeTextBox.Enabled = True
            NIFTextBox.Enabled = True
            Data_NascDateTimePicker.Enabled = True
            SexoComboBox.Enabled = True
            TurmaComboBox.Enabled = True
            EndereçoTextBox.Enabled = True
            Button1.Visible = True
            Button1.Visible = True
        Else
            Try
                        var.Insert(NomeTextBox.Text, SobrenomeTextBox.Text, Data_NascDateTimePicker.Text, SexoComboBox.Text, NIFTextBox.Text, EndereçoTextBox.Text, TurmaComboBox.Text, FotoTextBox.Text)
                        MsgBox("Registo Inserido com Sucesso", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        NomeTextBox.SelectAll()
                    End Try
            Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.Alunos)
            NomeTextBox.Enabled = False
                    SobrenomeTextBox.Enabled = False
                    NIFTextBox.Enabled = False
                    Data_NascDateTimePicker.Enabled = False
                    SexoComboBox.Enabled = False
                    TurmaComboBox.Enabled = False
                    EndereçoTextBox.Enabled = False
                    PictureBox5.Visible = False
                    Label8.Visible = False
                    PictureBox3.Visible = False
                    Label5.Visible = False
            PictureBox4.Visible = True
            PictureBox10.Visible = True
                    Label1.Visible = True
                    Label7.Visible = True
                    PictureBox13.Visible = True
                    Label2.Visible = True
                    PictureBox1.Visible = True
                    PictureBox2.Visible = True
                    PictureBox7.Visible = True
                    PictureBox8.Visible = True
            PictureBox9.ImageLocation = Application.StartupPath & "\imagens\" & FotoTextBox.Text
            Button1.Visible = False
        End If



    End Sub
    Private Sub TurmaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TurmaComboBox.SelectedIndexChanged
        If TurmaComboBox.Text <> "" Then
            AnoTextBox.Visible = True
            SiglaTextBox.Visible = True
            Nome_CursoTextBox.Visible = True
            Diretor_TurmaTextBox.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label10.Visible = True
            Label9.Visible = True
            CursoComboBox.Visible = True

        Else
            AnoTextBox.Visible = False
            SiglaTextBox.Visible = False
            Nome_CursoTextBox.Visible = False
            Diretor_TurmaTextBox.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label10.Visible = False
            Label9.Visible = False
            CursoComboBox.Visible = False

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        AlunosBindingSource.MoveFirst()
        PictureBox9.ImageLocation = Application.StartupPath & "\imagens\" & FotoTextBox.Text
        MsgBox("Situa-se no primeiro Aluno!", MsgBoxStyle.Information, "Informação")
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

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If System.Text.RegularExpressions.Regex.IsMatch(EndereçoTextBox.Text, par) Then
            PictureBox5.Visible = True
            Label8.Visible = True
            PictureBox6.Visible = False
            Label13.Visible = False
            NomeTextBox.Enabled = False
            SobrenomeTextBox.Enabled = False
            NIFTextBox.Enabled = False
            Data_NascDateTimePicker.Enabled = False
            SexoComboBox.Enabled = False
            TurmaComboBox.Enabled = False
            EndereçoTextBox.Enabled = False
            Button1.Visible = False
        Else
            MsgBox("Introduza um Email correto. Ex:Diogo@gmail.com", MsgBoxStyle.Critical, "Email")
            EndereçoTextBox.Clear()
            EndereçoTextBox.Focus()

        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Dim contar As Integer
        Dim nif1 As String
        Dim nif2 As String
        contar = Len(NIFTextBox.Text)
        nif2 = NIFTextBox.Text
        If contar < 9 Then
            MsgBox("Insira um NIF correto. Ex:123456789", MsgBoxStyle.Critical, "Aviso")
        Else
            If nif = nif2 Then
                Label13.Visible = True
                PictureBox14.Visible = False
                PictureBox6.Visible = True
                Label12.Visible = False
                NIFTextBox.Enabled = False

            Else
                nif1 = NIFTextBox.Text
                AlunosBindingSource.Filter = "NIF = " & NIFTextBox.Text & " "
                If AlunosBindingSource.Count = 0 Then
                    AlunosBindingSource.RemoveFilter()
                    NIFTextBox.Text = nif1
                    NomeTextBox.Clear()
                    NomeTextBox.Enabled = True
                    NIFTextBox.Enabled = False
                    PictureBox6.Visible = True
                    Label13.Visible = True
                    PictureBox14.Visible = False
                    Label12.Visible = False
                    TurmaComboBox.Enabled = True
                    PictureBox3.Visible = True
                    Label5.Visible = True
                    EndereçoTextBox.Enabled = True
                    EndereçoTextBox.Clear()
                    TurmaComboBox.SelectedItem = Nothing
                    Data_NascDateTimePicker.Enabled = True
                    Data_NascDateTimePicker.Value = "31/12/2005"
                    SexoComboBox.Enabled = True
                    SexoComboBox.SelectedItem = Nothing
                    TurmaComboBox.SelectedItem = Nothing
                    Button1.Visible = True



                    SobrenomeTextBox.Enabled = True
                    SobrenomeTextBox.Clear()

                Else
                    MsgBox("O NIF Introduzido já se encontra registado!", MsgBoxStyle.Critical, "Erro!")
                    AlunosBindingSource.RemoveFilter()
                    Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.Alunos)
                    NomeTextBox.Enabled = False
                    SobrenomeTextBox.Enabled = False
                    NIFTextBox.Enabled = False
                    Data_NascDateTimePicker.Enabled = False
                    SexoComboBox.Enabled = False
                    TurmaComboBox.Enabled = False
                    EndereçoTextBox.Enabled = False
                    PictureBox5.Visible = False
                    Label8.Visible = False
                    PictureBox3.Visible = False
                    Label5.Visible = False
                    PictureBox4.Visible = True

                    PictureBox10.Visible = True
                    Label1.Visible = True
                    Label7.Visible = True
                    PictureBox13.Visible = True
                    Label2.Visible = True
                    PictureBox1.Visible = True
                    PictureBox2.Visible = True
                    PictureBox7.Visible = True
                    PictureBox8.Visible = True
                    PictureBox14.Visible = False
                    Label12.Visible = False
                    PictureBox9.ImageLocation = Application.StartupPath & "\imagens\" & FotoTextBox.Text
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
    End Sub

    Private Sub NomeTextBox_TextChanged(sender As Object, e As EventArgs) Handles NomeTextBox.TextChanged

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click

        Form4.Show()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        AlunosBindingSource.MovePrevious()
        PictureBox9.ImageLocation = Application.StartupPath & "\imagens\" & FotoTextBox.Text
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

        Try
            var.Update(NomeTextBox.Text, SobrenomeTextBox.Text, Data_NascDateTimePicker.Text, SexoComboBox.Text, NIFTextBox.Text, EndereçoTextBox.Text, TurmaComboBox.Text, FotoTextBox.Text, numero, nom, sob, data, sex, nif, ende, turma, foto)
            MsgBox("Registo alterado com Sucesso", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.Alunos)
        NomeTextBox.Enabled = False
        SobrenomeTextBox.Enabled = False
        NIFTextBox.Enabled = False
        Data_NascDateTimePicker.Enabled = False
        SexoComboBox.Enabled = False
        TurmaComboBox.Enabled = False
        EndereçoTextBox.Enabled = False
        PictureBox5.Visible = False
        Label8.Visible = False
        PictureBox3.Visible = False
        Label5.Visible = False
        PictureBox4.Visible = True
        PictureBox5.Visible = False
        PictureBox10.Visible = True
        Label1.Visible = True
        Label7.Visible = True
        ID_AlunoTextBox.Visible = False
        PictureBox12.Visible = False
        PictureBox9.ImageLocation = Application.StartupPath & "\imagens\" & FotoTextBox.Text
        PictureBox13.Visible = True
        Label2.Visible = True
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox7.Visible = True
        PictureBox8.Visible = True
        Button1.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AlunosBindingSource.MoveNext()
        PictureBox9.ImageLocation = Application.StartupPath & "\imagens\" & FotoTextBox.Text
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        AlunosBindingSource.MoveLast()
        PictureBox9.ImageLocation = Application.StartupPath & "\imagens\" & FotoTextBox.Text
        MsgBox("Situa-se no último Aluno!", MsgBoxStyle.Information, "Informação")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        OpenFileDialog1.ShowDialog()
        FotoTextBox.Text = OpenFileDialog1.SafeFileName
        My.Computer.FileSystem.CopyFile(
         OpenFileDialog1.FileName,
         Application.StartupPath & "\imagens\" & OpenFileDialog1.SafeFileName, overwrite:=True)
        PictureBox9.Visible = True
        PictureBox9.ImageLocation = Application.StartupPath & "\imagens\" & FotoTextBox.Text
        PictureBox3.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click


    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If MsgBox("Deseja alterar o aluno? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Escola") = MsgBoxResult.Yes Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox6.Visible = False
            PictureBox14.Visible = True
            PictureBox5.Visible = False
            PictureBox10.Visible = False
            ID_AlunoTextBox.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label7.Visible = False
            Label1.Visible = False
            PictureBox4.Visible = False
            PictureBox3.Visible = False
            Label12.Visible = True
            PictureBox13.Visible = False



            numero = ID_AlunoTextBox.Text
            nom = NomeTextBox.Text
            sob = SobrenomeTextBox.Text
            ende = EndereçoTextBox.Text
            sex = SexoComboBox.Text
            data = Data_NascDateTimePicker.Text
            nif = NIFTextBox.Text
            turma = TurmaComboBox.Text
            foto = FotoTextBox.Text
            NomeTextBox.Enabled = True
            SobrenomeTextBox.Enabled = True
            NIFTextBox.Enabled = True
            Data_NascDateTimePicker.Enabled = True
            SexoComboBox.Enabled = True
            TurmaComboBox.Enabled = True
            EndereçoTextBox.Enabled = True
            Button1.Visible = True
        End If
    End Sub
End Class