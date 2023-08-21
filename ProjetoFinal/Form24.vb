Public Class Form24
    Dim dia As Date
    Private Sub Form24_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscolaDataSet.Consulta_Pres' table. You can move, or remove it, as needed.
        Me.Consulta_PresTableAdapter.Fill(Me.EscolaDataSet.Consulta_Pres)
        dia = Now.Date
        Consulta_PresBindingSource.Filter = "Professora ='" & codigoprof & "' AND Data ='" & dia & "'"
        RadioButton14.Visible = True
        Consulta_PresDataGridView.Visible = True
        RadioButton3.Checked = True
        RadioButton3.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()

    End Sub



    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Consulta_PresBindingSource.Filter = "Ano ='" & 10 & "'AND Professora ='" & codigoprof & "'"

        Consulta_PresDataGridView.Visible = True


        RadioButton14.Visible = True


        Label2.Visible = True
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton1.Checked = False
        'AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Consulta_PresBindingSource.Filter = "Ano ='" & 11 & "'AND Professora ='" & codigoprof & "'"

        Consulta_PresDataGridView.Visible = True


        RadioButton14.Visible = True


        Label2.Visible = True
        RadioButton4.Checked = False
        RadioButton6.Checked = False
        RadioButton1.Checked = False
        ' AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        Consulta_PresBindingSource.Filter = "Ano ='" & 12 & "' AND Professora ='" & codigoprof & "'"

        Consulta_PresDataGridView.Visible = True

        RadioButton14.Visible = True


        Label2.Visible = True
        RadioButton4.Checked = False
        RadioButton7.Checked = False
        RadioButton1.Checked = False
        ' AlunosNotasTableAdapter.ordenar(Me.EscolaDataSet.AlunosNotas)
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            Dim idade As String
            idade = InputBox("Qual a Sigla? ")
            Consulta_PresBindingSource.Filter = "Sigla Like '" & idade & "'AND Professora ='" & codigoprof & "'"
            Consulta_PresDataGridView.Visible = True
            RadioButton14.Visible = True
            Label2.Visible = True
            RadioButton12.Checked = False
            RadioButton1.Checked = False


        End If

    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs)
        Consulta_PresDataGridView.Visible = True

        RadioButton14.Visible = True


        Label2.Visible = True

    End Sub



    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Consulta_PresBindingSource.Filter = "Data = '" & MonthCalendar1.SelectionStart & "' AND Professora ='" & codigoprof & "'"
        RadioButton14.Visible = True
        Consulta_PresDataGridView.Visible = True
    End Sub




    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            GroupBox5.Enabled = True
        Else
            GroupBox5.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            GroupBox1.Enabled = True
            MonthCalendar1.Enabled = True

        Else
            GroupBox1.Enabled = False
            MonthCalendar1.Enabled = False
        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            GroupBox4.Visible = True

        Else
            GroupBox4.Visible = False

        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged

        Consulta_PresBindingSource.RemoveFilter()

            Consulta_PresDataGridView.Visible = False

        RadioButton14.Visible = False
        RadioButton14.Checked = False
        RadioButton2.Checked = False
        RadioButton1.Checked = False
        RadioButton3.Checked = True


    End Sub

End Class