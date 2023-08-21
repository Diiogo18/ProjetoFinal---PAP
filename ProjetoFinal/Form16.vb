Public Class Form16
    Dim var As New EscolaDataSetTableAdapters.Turma_DisciplinaTableAdapter
    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Disciplinas' table. You can move, or remove it, as needed.
        Me.DisciplinasTableAdapter.Fill(Me.EscolaDataSet.Disciplinas)
        'TODO: This line of code loads data into the 'EscolaDataSet.Turmas' table. You can move, or remove it, as needed.
        Me.TurmasTableAdapter.Fill(Me.EscolaDataSet.Turmas)
        'TODO: This line of code loads data into the 'EscolaDataSet._Turma_Disciplina' table. You can move, or remove it, as needed.
        Me.Turma_DisciplinaTableAdapter.Fill(Me.EscolaDataSet._Turma_Disciplina)
        TurmaComboBox.SelectedValue = turma
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form8.Show()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Try
            var.Insert(TurmaComboBox.Text, DisciplinaComboBox.Text)
            MsgBox("Registo Inserido com Sucesso", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
            AnoTextBox.SelectAll()
        End Try
        PictureBox8.Visible = False
        Label8.Visible = False
        PictureBox4.Visible = True
        Label7.Visible = True
        DisciplinaComboBox.Enabled = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        DisciplinaComboBox.SelectedItem = Nothing
        PictureBox8.Visible = True
        Label8.Visible = True
        PictureBox4.Visible = False
        Label7.Visible = False
        DisciplinaComboBox.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form9.Show()
    End Sub
End Class