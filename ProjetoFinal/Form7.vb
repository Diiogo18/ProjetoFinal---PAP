Public Class Form7
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Close()
    End Sub



    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Cursos' table. You can move, or remove it, as needed.
        Me.CursosTableAdapter.Fill(Me.EscolaDataSet.Cursos)
        ' CursosTableAdapter.ordenarid(Me.EscolaDataSet.Cursos)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CursosBindingSource.RemoveFilter()
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        CursosBindingSource.RemoveFilter()
        RadioButton2.Checked = False
        RadioButton3.Checked = False

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o ID? ")
            CursosBindingSource.Filter = "ID_Curso ='" & nome_pesq & "'"

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o Nome? ")
            CursosBindingSource.Filter = "Nome_Curso ='*" & nome_pesq & "*'"

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        CursosTableAdapter.ordenarid(Me.EscolaDataSet.Cursos)
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        CursosTableAdapter.ordenarnome(Me.EscolaDataSet.Cursos)
    End Sub
End Class