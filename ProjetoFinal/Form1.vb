Imports System.Data.OleDb

Imports System.Data
Public Class Form1

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TextBox2.PasswordChar = "*"
        PictureBox3.Visible = False
        PictureBox2.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBox2.PasswordChar = ""
        PictureBox3.Visible = True
        PictureBox2.Visible = False
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Alunos' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.EscolaDataSet.Admin)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
        Form18.Show()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim pass, nome As String
        Dim contar As Integer
        contar = AdminBindingSource.Count

        nome = TextBox1.Text
        pass = TextBox2.Text
        AdminBindingSource.Filter = "(Username like '" & nome & "'AND Password like '" & pass & "') "
        If AdminBindingSource.Count <> 0 Then
            Dim querry As String = "Select num_empregado From empregado where nome like '" & nome & "'AND pass like '" & pass & "' ;"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=escola.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            'nome_func = nome
            ' num_func = cmd.ExecuteScalar().ToString
            conn.Close()
            MsgBox("Login feito com Sucesso!", MsgBoxStyle.Information, "Login")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Dados Incorretos! Tente Novamente", MsgBoxStyle.Critical, "Aviso")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
