Imports System.Data.OleDb

Imports System.Data
Public Class Form19
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
        Form18.Show()

    End Sub

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

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Professores' table. You can move, or remove it, as needed.
        Me.ProfessoresTableAdapter.Fill(Me.EscolaDataSet.Professores)

    End Sub


    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim nome As String
        Dim contar As Integer
        contar = ProfessoresBindingSource.Count

        nome = TextBox1.Text
        pass = TextBox2.Text
        codigoprof = TextBox1.Text
        ProfessoresBindingSource.Filter = "(ID_prof = '" & nome & "'AND Password like '" & pass & "') "
        If ProfessoresBindingSource.Count <> 0 Then
            Dim querry As String = "Select Nome From professores where ID_prof like '" & nome & "'AND Password like '" & pass & "' ;"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=escola.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            professornome = nome
            professornome = cmd.ExecuteScalar().ToString
            conn.Close()
            Dim querrye As String = "Select Sobrenome From professores where ID_prof like '" & nome & "'AND Password like '" & pass & "' ;"
            Dim dbsourcee As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=escola.accdb"
            Dim conne = New OleDbConnection(dbsourcee)
            Dim cmde As New OleDbCommand(querrye, conne)
            conne.Open()
            professorsobrenome = nome
            professorsobrenome = cmde.ExecuteScalar().ToString
            conne.Close()

            Dim querryee As String = "Select Disciplina From professores where ID_prof like '" & nome & "';"
            Dim dbsourceee As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=escola.accdb"
            Dim connee = New OleDbConnection(dbsourceee)
            Dim cmdee As New OleDbCommand(querryee, connee)
            connee.Open()
            cod = nome
            cod = cmdee.ExecuteScalar().ToString
            connee.Close()

            Dim querryeeee As String = "Select Nome From Disciplinas where ID_disciplina =" & cod & ""
            Dim dbsourceeee As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=escola.accdb"
            Dim conneeee = New OleDbConnection(dbsourceeee)
            Dim cmdeeee As New OleDbCommand(querryeeee, conneeee)
            conneeee.Open()
            nomedisp = cod
            nomedisp = cmdeeee.ExecuteScalar().ToString
            conneeee.Close()

            MsgBox("Login feito com Sucesso!", MsgBoxStyle.Information, "Login")
            Form20.Show()
            Me.Hide()

        Else
            MsgBox("Dados Incorretos! Tente Novamente", MsgBoxStyle.Critical, "Aviso")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        End If
    End Sub


End Class