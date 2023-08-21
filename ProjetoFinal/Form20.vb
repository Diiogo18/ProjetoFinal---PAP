Imports System.Data.OleDb

Imports System.Data
Public Class Form20
    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label16.Text = nomedisp
        Label11.Text = Now.Date
        Label1.Text = professornome + " " + professorsobrenome
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If MessageBox.Show("Deseja mesmo Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form22.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form21.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Form25.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form24.Show()
    End Sub
End Class