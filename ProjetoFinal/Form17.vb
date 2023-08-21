Public Class Form17


    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Modulo' table. You can move, or remove it, as needed.
        Me.ModuloTableAdapter.Fill(Me.EscolaDataSet.Modulo)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.Close()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o ID? ")
            ModuloBindingSource.Filter = "ID_modulo='" & nome_pesq & "'"

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Dim nome_pesq As String
            nome_pesq = InputBox("Qual o Nome? ")
            ModuloBindingSource.Filter = "Nome ='" & nome_pesq & "'"

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
        ModuloBindingSource.RemoveFilter()
        RadioButton2.Checked = False
        RadioButton3.Checked = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ModuloBindingSource.RemoveFilter()
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
        ModuloTableAdapter.id(Me.EscolaDataSet.Modulo)
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        ModuloTableAdapter.Nome(Me.EscolaDataSet.Modulo)
    End Sub
End Class