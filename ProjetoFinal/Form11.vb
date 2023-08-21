Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet._Professores_Disci' table. You can move, or remove it, as needed.
        Me.Professores_DisciTableAdapter.Fill(Me.EscolaDataSet._Professores_Disci)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.Close()
        Form10.Show()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o ID? ")
            Professores_DisciBindingSource.Filter = "ID_prof ='" & nome_pesq & "'"

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o Nome? ")
            Professores_DisciBindingSource.Filter = "Professores_Nome like '*" & nome_pesq & "*'"

        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o Sobrenome? ")
            Professores_DisciBindingSource.Filter = "Sobrenome like '*" & nome_pesq & "*'"

        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o Email? ")
            Professores_DisciBindingSource.Filter = "email like '" & nome_pesq & "*'"

        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual a Disciplina? ")
            Professores_DisciBindingSource.Filter = "Disciplinas_Nome like '" & nome_pesq & "'"

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Professores_DisciBindingSource.RemoveFilter()
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        GroupBox4.Visible = False
        GroupBox3.Visible = True

        PictureBox3.Visible = True
        Label2.Visible = True

        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        PictureBox1.Visible = True

        RadioButton1.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
        Label3.Visible = True
        PictureBox2.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        GroupBox4.Visible = True
        GroupBox3.Visible = False

        PictureBox3.Visible = False
        Label2.Visible = False

        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False


        RadioButton1.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
        PictureBox2.Visible = True
        Label1.Visible = True
        PictureBox1.Visible = False
        Label3.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Professores_DisciTableAdapter.ordenaid(Me.EscolaDataSet._Professores_Disci)
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        Professores_DisciTableAdapter.nome(Me.EscolaDataSet._Professores_Disci)
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        Professores_DisciTableAdapter.disc(Me.EscolaDataSet._Professores_Disci)
    End Sub


End Class