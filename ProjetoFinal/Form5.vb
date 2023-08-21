Public Class Form5


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Cursos' table. You can move, or remove it, as needed.
        Me.CursosTableAdapter.Fill(Me.EscolaDataSet.Cursos)
        'TODO: This line of code loads data into the 'EscolaDataSet.Turmas' table. You can move, or remove it, as needed.
        Me.TurmasTableAdapter.Fill(Me.EscolaDataSet.Turmas)
        ' TurmasTableAdapter.ordenar(Me.EscolaDataSet.Turmas)
        TurmasTableAdapter.ano(Me.EscolaDataSet.Turmas)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Close()

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o ID? ")
            TurmasBindingSource.Filter = "ID_Turma ='" & nome_pesq & "'"

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
        End If
    End Sub


    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual a Sigla? ")
            TurmasBindingSource.Filter = "Sigla like'" & nome_pesq & "'"

        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o Curso (Indique o número)? ")
            TurmasBindingSource.Filter = "Curso ='" & nome_pesq & "'"

        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o Diretor de Turma? ")
            TurmasBindingSource.Filter = "[Diretor-Turma] like '*" & nome_pesq & "*'"

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' TurmasTableAdapter.ordenarid(Me.EscolaDataSet.Turmas)
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
        RadioButton1.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
        RadioButton4.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TurmasBindingSource.RemoveFilter()
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TurmasBindingSource.RemoveFilter()
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
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
    End Sub

    Private Sub RadioButton5_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        TurmasBindingSource.Filter = "Ano ='" & 10 & "'"
    End Sub

    Private Sub RadioButton6_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        TurmasBindingSource.Filter = "Ano ='" & 11 & "'"
    End Sub

    Private Sub RadioButton7_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        TurmasBindingSource.Filter = "Ano ='" & 12 & "'"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TurmasTableAdapter.ordenarid(Me.EscolaDataSet.Turmas)
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        TurmasTableAdapter.ano(Me.EscolaDataSet.Turmas)
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        TurmasTableAdapter.sigla(Me.EscolaDataSet.Turmas)
    End Sub


End Class