Public Class Form25

    Dim var1 As New EscolaDataSetTableAdapters.AvaliaçõesTableAdapter
        Dim alun As New EscolaDataSetTableAdapters.Aluno_AvaliaçãoTableAdapter
        Dim contar As Integer


        Private Sub TurmaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TurmaComboBox.SelectedIndexChanged
            If TurmaComboBox.Text <> "" Then
                AnoTextBox.Visible = True
                SiglaTextBox.Visible = True
                RadioButton1.Visible = True
            RadioButton2.Visible = True
            CursoComboBox.Visible = True
            Nome_CursoTextBox.Visible = True

        Else
                AnoTextBox.Visible = False
                SiglaTextBox.Visible = False
                RadioButton1.Visible = False
            RadioButton2.Visible = False
            CursoComboBox.Visible = False
            Nome_CursoTextBox.Visible = False
        End If
        End Sub



    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
            Me.Close()
        End Sub


        Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
            If RadioButton1.Checked = True Then
                AlunosBindingSource.Filter = "Turma ='" & TurmaComboBox.Text & "'"
            AlunosTableAdapter.ordenar(Me.EscolaDataSet.Alunos)
            AlunosDataGridView.Visible = True
                GroupBox2.Visible = True
                GroupBox3.Visible = True
                PictureBox12.Visible = True
                Label8.Visible = True
            ModuloTextBox.Clear()
            NotaFinalTextBox.Clear()
                AutoavaliaçãoTextBox.Clear()
                GroupBox1.Enabled = False
                RadioButton2.Visible = True
            Else
            AlunosTableAdapter.ordenar(Me.EscolaDataSet.Alunos)
            AlunosDataGridView.Visible = False
                GroupBox2.Visible = False
                GroupBox3.Visible = False
                PictureBox12.Visible = False
                Label8.Visible = False
            ModuloTextBox.Clear()
            NotaFinalTextBox.Clear()
                AutoavaliaçãoTextBox.Clear()
                RadioButton2.Visible = False

            End If
        End Sub

        Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
            AvaliaçõesBindingSource.MoveLast()

        End Sub

        Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
            AvaliaçõesBindingSource.MoveNext()
        End Sub

        Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
            AvaliaçõesBindingSource.MovePrevious()
        End Sub

        Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
            AvaliaçõesBindingSource.MoveFirst()
        End Sub

        Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
            AlunosBindingSource.RemoveFilter()
            AlunosDataGridView.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            PictureBox12.Visible = False
            Label8.Visible = False
            GroupBox1.Enabled = True
        End Sub

        Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If NotaFinalTextBox.Text > "20" Or NotaFinalTextBox.Text < "0" Then
            MsgBox("Insira uma Nota Final de 0 a 20!", MsgBoxStyle.Information, "Notas")
            NotaFinalTextBox.Clear()
            NotaFinalTextBox.Focus()
        Else
            If AutoavaliaçãoTextBox.Text > "20" Or AutoavaliaçãoTextBox.Text < "0" Then
                MsgBox("Insira uma Autoavaliação de 0 a 20!", MsgBoxStyle.Information, "Notas")
                AutoavaliaçãoTextBox.Clear()
                AutoavaliaçãoTextBox.Focus()
            Else
                If MsgBox("Deseja inserir a nota? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Escola") = MsgBoxResult.Yes Then
                Try
                        var1.Insert(TurmaComboBox.Text, ModuloTextBox.Text)
                    Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

                Try
                    alun.Insert(ID_AlunoTextBox.Text, ID_avaliaçãoTextBox.Text, NotaFinalTextBox.Text, AutoavaliaçãoTextBox.Text)
                    MsgBox("Registo Inserido com Sucesso", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
            End If
            Me.Aluno_AvaliaçãoTableAdapter.Fill(Me.EscolaDataSet._Aluno_Avaliação)
            Me.AvaliaçõesTableAdapter.Fill(Me.EscolaDataSet.Avaliações)
            PictureBox4.Visible = True
            Label7.Visible = True
            ModuloTextBox.Enabled = False
            AutoavaliaçãoTextBox.Enabled = False
            NotaFinalTextBox.Enabled = False
            PictureBox12.Visible = False
            Label8.Visible = False
            RadioButton1.Checked = False
        End If
        End If
    End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)
            Form5.Show()
        End Sub

        Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
            Form5.Show()
        End Sub

        Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
            PictureBox4.Visible = False
            Label7.Visible = False
            AlunosBindingSource.RemoveFilter()
            AlunosDataGridView.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            PictureBox12.Visible = False
            Label8.Visible = False
            contar = AvaliaçõesBindingSource.Count
        ID_avaliaçãoTextBox.Text = contar + 20
        TurmaComboBox.SelectedItem = Nothing
            TurmaComboBox.Enabled = True
            RadioButton3.Checked = True
            GroupBox1.Enabled = True
            AnoTextBox.Clear()
            SiglaTextBox.Clear()
        End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form17.Show()
    End Sub



    Private Sub Form25_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Cons_modulo' table. You can move, or remove it, as needed.
        Me.Cons_moduloTableAdapter.Fill(Me.EscolaDataSet.Cons_modulo)
        'TODO: This line of code loads data into the 'EscolaDataSet.Avaliações' table. You can move, or remove it, as needed.
        Me.AvaliaçõesTableAdapter.Fill(Me.EscolaDataSet.Avaliações)
        'TODO: This line of code loads data into the 'EscolaDataSet.Turmas' table. You can move, or remove it, as needed.
        Me.TurmasTableAdapter.Fill(Me.EscolaDataSet.Turmas)
        'TODO: This line of code loads data into the 'EscolaDataSet._Modulo_Disciplina' table. You can move, or remove it, as needed.
        Me.Modulo_DisciplinaTableAdapter.Fill(Me.EscolaDataSet._Modulo_Disciplina)
        'TODO: This line of code loads data into the 'EscolaDataSet.Disciplinas' table. You can move, or remove it, as needed.
        Me.DisciplinasTableAdapter.Fill(Me.EscolaDataSet.Disciplinas)
        'TODO: This line of code loads data into the 'EscolaDataSet.Cursos' table. You can move, or remove it, as needed.
        Me.CursosTableAdapter.Fill(Me.EscolaDataSet.Cursos)
        'TODO: This line of code loads data into the 'EscolaDataSet.Modulo' table. You can move, or remove it, as needed.
        Me.ModuloTableAdapter.Fill(Me.EscolaDataSet.Modulo)
        'TODO: This line of code loads data into the 'EscolaDataSet.Alunos' table. You can move, or remove it, as needed.
        Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.Alunos)
        'TODO: This line of code loads data into the 'EscolaDataSet._Aluno_Avaliação' table. You can move, or remove it, as needed.
        Me.Aluno_AvaliaçãoTableAdapter.Fill(Me.EscolaDataSet._Aluno_Avaliação)

        Cons_moduloBindingSource.Filter = "Disciplina='" & cod & "'"

        Me.AvaliaçõesTableAdapter.Fill(Me.EscolaDataSet.Avaliações)

        contar = AvaliaçõesBindingSource.Count
        ID_avaliaçãoTextBox.Text = contar + 20
        TurmaComboBox.SelectedItem = Nothing
        RadioButton3.Checked = True
        AnoTextBox.Clear()
        SiglaTextBox.Clear()
        CursoComboBox.SelectedItem = Nothing
        Nome_CursoTextBox.Clear()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Form26.Show()
    End Sub


End Class