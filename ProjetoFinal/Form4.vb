Public Class Form4
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Close()
        Form3.Show()
    End Sub



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.AlunosConsulta' table. You can move, or remove it, as needed.
        Me.AlunosConsultaTableAdapter.Fill(Me.EscolaDataSet.AlunosConsulta)
        'TODO: This line of code loads data into the 'EscolaDataSet1.Alunos' table. You can move, or remove it, as needed.
        Me.AlunosTableAdapter.Fill(Me.EscolaDataSet1.Alunos)
        'TODO: This line of code loads data into the 'EscolaDataSet.Turmas' table. You can move, or remove it, as needed.
        Me.TurmasTableAdapter.Fill(Me.EscolaDataSet.Turmas)
        'TODO: This line of code loads data into the 'EscolaDataSet._Aluno_Avaliação' table. You can move, or remove it, as needed.
        Me.Aluno_AvaliaçãoTableAdapter.Fill(Me.EscolaDataSet._Aluno_Avaliação)
        'TODO: This line of code loads data into the 'EscolaDataSet.Alunos' table. You can move, or remove it, as needed.
        Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.Alunos)


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        AlunosConsultaTableAdapter.ordenarid(Me.EscolaDataSet.AlunosConsulta)
        GroupBox3.Visible = True
        GroupBox4.Visible = False
        PictureBox2.Visible = False
        Label1.Visible = False
        PictureBox1.Visible = True
        Label3.Visible = True
        PictureBox3.Visible = True
        Label2.Visible = True
        RadioButton3.Checked = False
        RadioButton2.Checked = False
        RadioButton4.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        AlunosConsultaBindingSource.RemoveFilter()
        GroupBox3.Visible = False
        GroupBox4.Visible = True
        PictureBox2.Visible = True
        Label1.Visible = True
        PictureBox1.Visible = False
        Label3.Visible = False
        PictureBox3.Visible = False
        Label2.Visible = False
        RadioButton1.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
        RadioButton8.Checked = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        AlunosConsultaBindingSource.RemoveFilter()
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o nome? ")
            AlunosConsultaBindingSource.Filter = "nome like'*" & nome_pesq & "*'"

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Dim idade As String
            idade = InputBox("Qual a Idade? ")
            AlunosConsultaBindingSource.Filter = "Idade ='" & idade & "'"

        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        AlunosConsultaBindingSource.Filter = "Ano ='" & 10 & "'"
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        AlunosConsultaBindingSource.Filter = "Ano ='" & 11 & "'"
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        AlunosConsultaBindingSource.Filter = "Ano ='" & 12 & "'"
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        AlunosConsultaTableAdapter.ordenarnome(Me.EscolaDataSet.AlunosConsulta)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        AlunosConsultaTableAdapter.ordenarid(Me.EscolaDataSet.AlunosConsulta)
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        AlunosConsultaTableAdapter.ordenaridade(Me.EscolaDataSet.AlunosConsulta)
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        AlunosConsultaTableAdapter.ordenarano(Me.EscolaDataSet.AlunosConsulta)
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            Dim idade As String
            idade = InputBox("Qual o Curso? ")
            AlunosConsultaBindingSource.Filter = "Nome_Curso like'*" & idade & "*'"

        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            Dim idade As String
            idade = InputBox("Qual a Sigla? ")
            AlunosConsultaBindingSource.Filter = "Sigla Like '" & idade & "'"

        End If
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        AlunosConsultaBindingSource.RemoveFilter()
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        AlunosConsultaTableAdapter.ordenarid(Me.EscolaDataSet.AlunosConsulta)
        GroupBox3.Visible = True
        GroupBox4.Visible = False
        PictureBox2.Visible = False
        Label1.Visible = False
        PictureBox1.Visible = True
        Label3.Visible = True
        PictureBox3.Visible = True
        Label2.Visible = True
        RadioButton3.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AlunosConsultaBindingSource.RemoveFilter()
        GroupBox3.Visible = False
        GroupBox4.Visible = True
        PictureBox2.Visible = True
        Label1.Visible = True
        PictureBox1.Visible = False
        Label3.Visible = False
        PictureBox3.Visible = False
        Label2.Visible = False
        RadioButton1.Checked = False
        RadioButton9.Checked = False
    End Sub
End Class