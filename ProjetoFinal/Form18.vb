Public Class Form18
    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Bem Vindo/a a Escola de Estarreja", MsgBoxStyle.Information, "Olá")
        Form13.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If MessageBox.Show("Deseja mesmo Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form19.Show()
        Me.Hide()
    End Sub
End Class