Public Class Form8
    Dim var As New EscolaDataSetTableAdapters.TurmasTableAdapter
    Dim id, ano, curso As Integer
    Dim sigla, diretor As String
    Dim contar As Integer
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Cursos' table. You can move, or remove it, as needed.
        Me.CursosTableAdapter.Fill(Me.EscolaDataSet.Cursos)
        'TODO: This line of code loads data into the 'EscolaDataSet.Turmas' table. You can move, or remove it, as needed.
        Me.TurmasTableAdapter.Fill(Me.EscolaDataSet.Turmas)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        TurmasBindingSource.MoveLast()
        MsgBox("Situa-se no último Aluno!", MsgBoxStyle.Information, "Informação")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TurmasBindingSource.MoveFirst()
        MsgBox("Situa-se no primeiro Aluno!", MsgBoxStyle.Information, "Informação")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TurmasBindingSource.MoveNext()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TurmasBindingSource.MovePrevious()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Form5.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If MsgBox("Deseja inserir uma nova Turma? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Escola") = MsgBoxResult.Yes Then
            PictureBox5.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox9.Visible = False
            PictureBox8.Visible = True
            Label1.Visible = False
            Label7.Visible = False
            Label2.Visible = False
            Label8.Visible = True
            AnoTextBox.Clear()
            SiglaTextBox.Clear()
            CursoComboBox.SelectedItem = Nothing
            Diretor_TurmaTextBox.Clear()
            AnoTextBox.Enabled = True
            SiglaTextBox.Enabled = True
            CursoComboBox.Enabled = True
            Diretor_TurmaTextBox.Enabled = True
            ID_TurmaTextBox.Visible = True
            contar = TurmasBindingSource.Count
            ID_TurmaTextBox.Text = contar + 10

        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Try
            var.Update(AnoTextBox.Text, SiglaTextBox.Text, CursoComboBox.Text, Diretor_TurmaTextBox.Text, id, ano, sigla, curso, diretor)
            MsgBox("Registo alterado com Sucesso", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Me.TurmasTableAdapter.Fill(Me.EscolaDataSet.Turmas)
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        PictureBox8.Visible = False
        PictureBox9.Visible = True
        Label2.Visible = True
        ID_TurmaTextBox.Visible = False
        PictureBox11.Visible = False
        Label7.Visible = True
        Label8.Visible = False
        Label1.Visible = True
        PictureBox4.Visible = True
        AnoTextBox.Enabled = False
        SiglaTextBox.Enabled = False
        CursoComboBox.Enabled = False
        Diretor_TurmaTextBox.Enabled = False
    End Sub

    Private Sub AnoTextBox_TextChanged(sender As Object, e As EventArgs) Handles AnoTextBox.TextChanged

    End Sub

    Private Sub CursoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CursoComboBox.SelectedIndexChanged
        If CursoComboBox.Text <> "" Then
            Nome_CursoTextBox.Visible = True
        Else
            Nome_CursoTextBox.Visible = False
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim ano As Integer
        Dim sigla As String

        ano = AnoTextBox.Text
        sigla = SiglaTextBox.Text

        If AnoTextBox.Text = "" Or SiglaTextBox.Text = "" Or CursoComboBox.Text = "" Or Diretor_TurmaTextBox.Text = "" Then
            MsgBox("Introduza Todos os Dados", MsgBoxStyle.Critical, "Aviso!")
        Else
            If AnoTextBox.Text > 12 Or AnoTextBox.Text < 10 Then
                MsgBox("Introduza um ano válido!!", MsgBoxStyle.Critical, "PAP")
                AnoTextBox.Clear()
            Else
                TurmasBindingSource.Filter = "Ano ='" & AnoTextBox.Text & "' AND Sigla Like '" & SiglaTextBox.Text & "'"
                If TurmasBindingSource.Count = 0 Then
                    TurmasBindingSource.RemoveFilter()
                    AnoTextBox.Text = ano
                    SiglaTextBox.Text = sigla
                    turma = ID_TurmaTextBox.Text
                    Try
                        var.Insert(AnoTextBox.Text, SiglaTextBox.Text, CursoComboBox.Text, Diretor_TurmaTextBox.Text)
                        MsgBox("Registo Inserido com Sucesso", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        AnoTextBox.SelectAll()
                    End Try
                    Me.TurmasTableAdapter.Fill(Me.EscolaDataSet.Turmas)
                    Me.CursosTableAdapter.Fill(Me.EscolaDataSet.Cursos)
                    PictureBox5.Visible = True
                    PictureBox2.Visible = True
                    PictureBox3.Visible = True
                    PictureBox4.Visible = True
                    PictureBox6.Visible = True
                    PictureBox7.Visible = True
                    PictureBox9.Visible = True
                    PictureBox8.Visible = False
                    Label1.Visible = True
                    Label7.Visible = True
                    Label2.Visible = True
                    Label8.Visible = False
                    AnoTextBox.Enabled = False
                    SiglaTextBox.Enabled = False
                    CursoComboBox.Enabled = False
                    Diretor_TurmaTextBox.Enabled = False
                    Me.Close()
                    Form16.Show()
                Else
                    TurmasBindingSource.RemoveFilter()
                    MsgBox("A turma Introduzida já se encontra registada!", MsgBoxStyle.Critical, "Erro!")
                    Me.TurmasTableAdapter.Fill(Me.EscolaDataSet.Turmas)
                    Me.CursosTableAdapter.Fill(Me.EscolaDataSet.Cursos)
                    PictureBox5.Visible = True
                    PictureBox2.Visible = True
                    PictureBox3.Visible = True
                    PictureBox4.Visible = True
                    PictureBox6.Visible = True
                    PictureBox7.Visible = True
                    PictureBox9.Visible = True
                    PictureBox8.Visible = False
                    Label1.Visible = True
                    Label7.Visible = True
                    Label2.Visible = True
                    Label8.Visible = False
                    AnoTextBox.Enabled = False
                    SiglaTextBox.Enabled = False
                    CursoComboBox.Enabled = False
                    Diretor_TurmaTextBox.Enabled = False

                End If
            End If
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If MsgBox("Deseja alterar esta turma? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Escola") = MsgBoxResult.Yes Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            Label2.Visible = False
            ID_TurmaTextBox.Visible = True
            PictureBox11.Visible = True
            Label7.Visible = False
            Label8.Visible = True
            Label1.Visible = False
            PictureBox4.Visible = False
            id = ID_TurmaTextBox.Text
            ano = AnoTextBox.Text
            sigla = SiglaTextBox.Text
            curso = CursoComboBox.Text
            diretor = Diretor_TurmaTextBox.Text
            AnoTextBox.Enabled = True
            SiglaTextBox.Enabled = True
            CursoComboBox.Enabled = True
            Diretor_TurmaTextBox.Enabled = True
        End If
    End Sub
End Class