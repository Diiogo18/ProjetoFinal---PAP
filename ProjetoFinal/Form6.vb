Public Class Form6
    Dim var As New EscolaDataSetTableAdapters.CursosTableAdapter
    Dim nomee As String
    Dim id As Integer
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Cursos' table. You can move, or remove it, as needed.
        Me.CursosTableAdapter.Fill(Me.EscolaDataSet.Cursos)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        CursosBindingSource.MoveLast()
        MsgBox("Situa-se no último Curso!", MsgBoxStyle.Information, "Informação")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        CursosBindingSource.MoveNext()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        CursosBindingSource.MovePrevious()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CursosBindingSource.MoveFirst()
        MsgBox("Situa-se no primeiro Curso!", MsgBoxStyle.Information, "Informação")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If MsgBox("Deseja inserir um curso? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Escola") = MsgBoxResult.Yes Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            PictureBox7.Visible = False
            Label7.Visible = False
            PictureBox9.Visible = False
            PictureBox8.Visible = True
            Label8.Visible = True
            Nome_CursoTextBox.Clear()
            Nome_CursoTextBox.Enabled = True
            Nome_CursoTextBox.Focus()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim nome As String
        nome = Nome_CursoTextBox.Text
        If Nome_CursoTextBox.Text = "" Then
            MsgBox("Introduza Todos os Dados", MsgBoxStyle.Critical, "Aviso!")
        Else
            CursosBindingSource.Filter = "Nome_Curso ='" & Nome_CursoTextBox.Text & "'"
            If CursosBindingSource.Count = 0 Then
                CursosBindingSource.RemoveFilter()
                Nome_CursoTextBox.Text = nome
                Try
                    var.Insert(Nome_CursoTextBox.Text)
                    MsgBox("Registo Inserido com Sucesso", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Nome_CursoTextBox.SelectAll()
                End Try
                Me.CursosTableAdapter.Fill(Me.EscolaDataSet.Cursos)
                PictureBox1.Visible = True
                PictureBox2.Visible = True
                PictureBox3.Visible = True
                PictureBox4.Visible = True
                PictureBox5.Visible = True
                Label1.Visible = True
                Label2.Visible = True
                PictureBox7.Visible = True
                Label7.Visible = True
                PictureBox9.Visible = True
                PictureBox8.Visible = False
                PictureBox8.Visible = False
                Label8.Visible = False
                Nome_CursoTextBox.Enabled = False
            Else
                CursosBindingSource.RemoveFilter()
                MsgBox("O Curso Introduzido já se encontra registado!", MsgBoxStyle.Critical, "Erro!")
                PictureBox1.Visible = True
                PictureBox2.Visible = True
                PictureBox3.Visible = True
                PictureBox4.Visible = True
                PictureBox5.Visible = True
                Label1.Visible = True
                Label2.Visible = True
                PictureBox7.Visible = True
                Label7.Visible = True
                PictureBox9.Visible = True
                PictureBox11.Visible = False
                Label8.Visible = False
                Nome_CursoTextBox.Enabled = False
                ID_CursoTextBox.Visible = False
                PictureBox8.Visible = False
            End If
        End If
        Me.CursosTableAdapter.Fill(Me.EscolaDataSet.Cursos)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Try
            var.Update(Nome_CursoTextBox.Text, id, nomee)
            MsgBox("Registo Alterado com Sucesso", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
            Nome_CursoTextBox.SelectAll()
        End Try
        Me.CursosTableAdapter.Fill(Me.EscolaDataSet.Cursos)
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        PictureBox7.Visible = True
        Label7.Visible = True
        PictureBox9.Visible = True
        PictureBox11.Visible = False
        Label8.Visible = False
        Nome_CursoTextBox.Enabled = False
        ID_CursoTextBox.Visible = False

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If MsgBox("Deseja alterar este curso? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Escola") = MsgBoxResult.Yes Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            PictureBox7.Visible = False
            Label7.Visible = False
            PictureBox9.Visible = False
            PictureBox11.Visible = True
            Label8.Visible = True
            ID_CursoTextBox.Visible = True
            id = ID_CursoTextBox.Text
            nomee = Nome_CursoTextBox.Text
            Nome_CursoTextBox.Enabled = True
            Nome_CursoTextBox.Focus()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Form7.Show()
    End Sub
End Class