Public Class Form14
    Dim y As Integer
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.AlunosNotas' table. You can move, or remove it, as needed.
        Me.AlunosNotasTableAdapter.Fill(Me.EscolaDataSet.AlunosNotas)
        RadioButton10.Checked = True

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.AlunosNotasDataGridView.Width, Me.AlunosNotasDataGridView.Height)
        AlunosNotasDataGridView.DrawToBitmap(bm, New Rectangle(30, 30, Me.AlunosNotasDataGridView.Width, Me.AlunosNotasDataGridView.Height))
        e.Graphics.DrawLine(Pens.Black, 20, 50, 800, 50)
        e.Graphics.DrawString("Agrumento de Escolas de Estarreja", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 300, 75)
        e.Graphics.DrawLine(Pens.Black, 20, 150, 800, 150)
        e.Graphics.DrawString("Curso: " & Nome_CursoTextBox.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 30, 200)
        e.Graphics.DrawString("Ano: " & AnoTextBox.Text + " " + "Turma: " + SiglaTextBox.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 30, 225)




        e.Graphics.DrawLine(New Pen(Color.Black), New Point(40, 425), New Point(780, 425))
        e.Graphics.DrawLine(New Pen(Color.Black), New Point(40, 430), New Point(780, 430))



        e.Graphics.DrawLine(New Pen(Color.Black), New Point(40, 650), New Point(780, 650))
        ' e.Graphics.DrawString("Total a Pagar (com iva):", SystemFonts.DefaultFont, Brushes.Black, 60, 700)
        'e.Graphics.DrawString(Format(total, "0.00 €"), SystemFonts.DefaultFont, Brushes.Black, 669, 700)
        e.Graphics.DrawImage(bm, -75, 355)


    End Sub



    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        AlunosNotasBindingSource.RemoveFilter()
        GroupBox3.Visible = True
        RadioButton14.Checked = False
        AlunosNotasDataGridView.Visible = False
        GroupBox1.Visible = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        RadioButton14.Visible = False
        Label1.Visible = False
        Label2.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked = True Then
            GroupBox6.Enabled = True
        Else
            GroupBox6.Enabled = False
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked = True Then
            GroupBox5.Enabled = True
        Else
            GroupBox5.Enabled = False
        End If

    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked = True Then
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked = True Then
            GroupBox7.Enabled = True
        Else
            GroupBox7.Enabled = False
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            Dim idade As String
            idade = InputBox("Qual o Curso? ")
            AlunosNotasBindingSource.Filter = "Nome_Curso like'*" & idade & "*'"
            RadioButton15.Checked = False
            AlunosNotasDataGridView.Visible = True
            GroupBox1.Visible = True
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            GroupBox3.Visible = False
            RadioButton14.Visible = True
            RadioButton13.Checked = False
            Label1.Visible = True
            Label2.Visible = True
            RadioButton8.Checked = False

            AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
        End If


    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
        AlunosNotasDataGridView.Visible = True
        GroupBox1.Visible = True

        GroupBox3.Visible = False
        RadioButton14.Visible = True
        RadioButton13.Checked = False


    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            Dim idade As String
            idade = InputBox("Qual a Sigla? ")
            AlunosNotasBindingSource.Filter = "Sigla Like '" & idade & "'"
            RadioButton16.Checked = False
            AlunosNotasDataGridView.Visible = True
            GroupBox1.Visible = True
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            GroupBox3.Visible = False
            RadioButton14.Visible = True
            RadioButton13.Checked = False
            Label1.Visible = True
            Label2.Visible = True

            AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            GroupBox4.Visible = True
        Else
            GroupBox4.Visible = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        AlunosNotasBindingSource.Filter = "Ano ='" & 10 & "'"
        RadioButton16.Checked = False
        AlunosNotasDataGridView.Visible = True
        GroupBox1.Visible = True
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        GroupBox3.Visible = False
        RadioButton14.Visible = True
        RadioButton13.Checked = False
        Label1.Visible = True
        Label2.Visible = True
        RadioButton4.Checked = False

        'AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        AlunosNotasBindingSource.Filter = "Ano ='" & 11 & "'"
        RadioButton16.Checked = False
        AlunosNotasDataGridView.Visible = True
        GroupBox1.Visible = True
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        GroupBox3.Visible = False
        RadioButton14.Visible = True
        RadioButton13.Checked = False
        Label1.Visible = True
        Label2.Visible = True
        RadioButton4.Checked = False

        AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        AlunosNotasBindingSource.Filter = "Ano ='" & 12 & "'"
        RadioButton16.Checked = False
        AlunosNotasDataGridView.Visible = True
        GroupBox1.Visible = True
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        GroupBox3.Visible = False
        RadioButton14.Visible = True
        RadioButton13.Checked = False
        Label1.Visible = True
        Label2.Visible = True
        RadioButton4.Checked = False

        AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o nome? ")
            AlunosNotasBindingSource.Filter = "Alunos_Nome like'*" & nome_pesq & "*'"
            AlunosNotasDataGridView.Visible = True
            GroupBox1.Visible = True
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            GroupBox3.Visible = False
            RadioButton14.Visible = True
            RadioButton13.Checked = False
            Label1.Visible = True
            Label2.Visible = True
            RadioButton3.Checked = False
            RadioButton17.Checked = False

            AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o ID? ")
            AlunosNotasBindingSource.Filter = "ID_Aluno ='" & nome_pesq & "'"
            AlunosNotasDataGridView.Visible = True
            GroupBox1.Visible = True
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            GroupBox3.Visible = False
            RadioButton14.Visible = True
            RadioButton13.Checked = False
            Label1.Visible = True
            Label2.Visible = True
            RadioButton11.Checked = False
            RadioButton17.Checked = False

            AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o Sobrenome? ")
            AlunosNotasBindingSource.Filter = "Sobrenome like'*" & nome_pesq & "*'"
            AlunosNotasDataGridView.Visible = True
            GroupBox1.Visible = True
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            GroupBox3.Visible = False
            RadioButton14.Visible = True
            RadioButton13.Checked = False
            Label1.Visible = True
            Label2.Visible = True
            RadioButton2.Checked = False
            RadioButton17.Checked = False

            AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual a Disciplina? ")
            AlunosNotasBindingSource.Filter = "Disciplinas_Nome like'*" & nome_pesq & "*'"
            AlunosNotasDataGridView.Visible = True
            GroupBox1.Visible = True
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            GroupBox3.Visible = False
            RadioButton14.Visible = True
            RadioButton13.Checked = False
            Label1.Visible = True
            Label2.Visible = True
            RadioButton1.Checked = False
            RadioButton18.Checked = False

            AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o Módulo? ")
            AlunosNotasBindingSource.Filter = "Modulo_Nome like'*" & nome_pesq & "*'"
            AlunosNotasDataGridView.Visible = True
            GroupBox1.Visible = True
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            GroupBox3.Visible = False
            RadioButton14.Visible = True
            RadioButton13.Checked = False
            Label1.Visible = True
            Label2.Visible = True
            RadioButton9.Checked = False
            RadioButton18.Checked = False

            AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
        End If
    End Sub


    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged

    End Sub
End Class