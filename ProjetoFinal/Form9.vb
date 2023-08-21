Public Class Form9


    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Professores' table. You can move, or remove it, as needed.
        Me.ProfessoresTableAdapter.Fill(Me.EscolaDataSet.Professores)
        'TODO: This line of code loads data into the 'EscolaDataSet.Disciplinas' table. You can move, or remove it, as needed.
        Me.DisciplinasTableAdapter.Fill(Me.EscolaDataSet.Disciplinas)
        ' DisciplinasTableAdapter.id(Me.EscolaDataSet.Disciplinas)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o ID? ")
            DisciplinasBindingSource.Filter = "ID_disciplina ='" & nome_pesq & "'"

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o Nome? ")
            DisciplinasBindingSource.Filter = "Nome ='" & nome_pesq & "'"

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        GroupBox3.Visible = True
        GroupBox4.Visible = False
        PictureBox2.Visible = False
        Label1.Visible = False
        PictureBox4.Visible = True
        Label3.Visible = True
        PictureBox3.Visible = True
        Label2.Visible = True
        RadioButton3.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        DisciplinasBindingSource.RemoveFilter()
        RadioButton2.Checked = False
        RadioButton3.Checked = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        DisciplinasBindingSource.RemoveFilter()
        GroupBox3.Visible = False
        GroupBox4.Visible = True
        PictureBox2.Visible = True
        Label1.Visible = True
        PictureBox4.Visible = False
        Label3.Visible = False
        PictureBox3.Visible = False
        Label2.Visible = False
        RadioButton1.Checked = False
        RadioButton9.Checked = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DisciplinasTableAdapter.id(Me.EscolaDataSet.Disciplinas)
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        DisciplinasTableAdapter.nome(Me.EscolaDataSet.Disciplinas)
    End Sub
End Class