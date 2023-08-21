Public Class Form21
    Dim var As New EscolaDataSetTableAdapters.PresençasTableAdapter
    Dim n As Integer = -1
    Structure aluno
        Dim sala, sit As String
        Dim data As Date
        Dim prof, aluno As Integer
        Dim hora As String

    End Structure
    Dim pre() As aluno
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
        Form20.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim pass2 As String
        pass2 = InputBox("Password: ")
        If pass2 <> pass Then
            MsgBox("Incorreto!", MsgBoxStyle.Critical, "Registo")
        Else

            If ListBox1.Items.Count = 0 Then
                MsgBox("Insira algum registo!!!", MsgBoxStyle.Critical, "Presenças")
            Else

                For i = 0 To n

                    Try
                        var.Insert(pre(i).sala, pre(i).data, pre(i).hora, pre(i).prof, pre(i).aluno, pre(i).sit)

                    Catch ex As Exception
                        MsgBox(ex.Message)
                        NomeTextBox.SelectAll()
                    End Try
                Next
                PictureBox5.Visible = True
                PictureBox3.Visible = False
                MsgBox("Registado com Sucesso", MsgBoxStyle.Information)
            End If
            GroupBox1.Visible = False
            GroupBox3.Visible = False
            GroupBox2.Enabled = True
            PictureBox4.Visible = True
            SalaTextBox.Clear()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim aluno As Integer
        Dim horapre As String

        Dim verd As Integer = 0


        aluno = InputBox("Número de Aluno: ")


        For i = 0 To n
            If aluno = pre(i).aluno Then
                MsgBox("Aluno já inserido!!!", MsgBoxStyle.Critical, "Presenças")
                verd = 1
            End If
        Next
        If verd = 0 Then
            AlunosBindingSource.Filter = "(ID_Aluno = '" & aluno & "') "
            GroupBox3.Visible = True
            horapre = Label3.Text

            If horapre = "8:30" Or horapre = "8:35" Or horapre = "8:31" Or horapre = "8:32" Or horapre = "8:33" Or horapre = "8:34" Then
                SituaçãoTextBox.Text = "Presente"
            Else
                If horapre = "8:36" Or horapre = "8:37" Or horapre = "8:38" Or horapre = "8:39" Or horapre = "8:40" Or horapre = "8:41" Or horapre = "8:42" Or horapre = "8:43" Or horapre = "8:44" Or horapre = "8:45" Then
                    SituaçãoTextBox.Text = "Falta de Atraso"
                Else

                    SituaçãoTextBox.Text = "Falta"
                    End If

            End If

            Label1.Visible = True
            n = n + 1
            ReDim Preserve pre(n)

            pre(n).sala = SalaTextBox.Text
            pre(n).data = Label2.Text
            pre(n).hora = Label3.Text
            pre(n).prof = codigoprof
            pre(n).aluno = ID_AlunoTextBox.Text
            pre(n).sit = SituaçãoTextBox.Text
            ListBox1.Items.Add(NomeTextBox.Text + " " + SobrenomeTextBox.Text + ":" + " " + SituaçãoTextBox.Text)
            PictureBox1.ImageLocation = Application.StartupPath & "\imagens\" & FotoTextBox.Text
            GroupBox3.Visible = True

        End If
        PictureBox3.Visible = True
    End Sub



    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Cursos' table. You can move, or remove it, as needed.
        Me.CursosTableAdapter.Fill(Me.EscolaDataSet.Cursos)
        'TODO: This line of code loads data into the 'EscolaDataSet.Turmas' table. You can move, or remove it, as needed.
        Me.TurmasTableAdapter.Fill(Me.EscolaDataSet.Turmas)
        'TODO: This line of code loads data into the 'EscolaDataSet.Alunos' table. You can move, or remove it, as needed.
        Me.AlunosTableAdapter.Fill(Me.EscolaDataSet.Alunos)
        'TODO: This line of code loads data into the 'EscolaDataSet.Presenças' table. You can move, or remove it, as needed.
        Me.PresençasTableAdapter.Fill(Me.EscolaDataSet.Presenças)
        Label2.Text = Now.Date
        SalaTextBox.Text = ""

        ID_AlunoTextBox.Clear()
        NomeTextBox.Clear()
        SobrenomeTextBox.Clear()
        SituaçãoTextBox.Clear()
        AnoTextBox.Clear()
        Diretor_TurmaTextBox.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If SalaTextBox.Text = "" Then
            MsgBox("Insira a Sala!!!", MsgBoxStyle.Critical, "Presenças")
        Else
            GroupBox1.Visible = Enabled
            GroupBox2.Enabled = False
            ID_AlunoTextBox.Clear()
            NomeTextBox.Clear()
            SobrenomeTextBox.Clear()
            SituaçãoTextBox.Clear()
            AnoTextBox.Clear()
            Diretor_TurmaTextBox.Clear()
            PictureBox5.Visible = False
            PictureBox4.Visible = False
        End If
    End Sub

    Private Sub TurmaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TurmaComboBox.SelectedIndexChanged

    End Sub
End Class