Public Class Form23
    Private Sub Form23_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        e.Graphics.DrawLine(Pens.Black, 20, 50, 800, 50)
        e.Graphics.DrawString("Agrumento de Escolas de Estarreja", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 300, 75)
        e.Graphics.DrawLine(Pens.Black, 20, 150, 800, 150)
        e.Graphics.DrawString("Curso: " & cursoee, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 30, 200)
        e.Graphics.DrawString("Ano: " & anoee & " " + "Turma: " & siglaee, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 30, 225)
        e.Graphics.DrawString("Aluno: " & nomee + " " + sobree + " " + "Nº:" & idalunoee, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 30, 250)
        e.Graphics.DrawString("Disciplina: " & discmee, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 30, 300)


        e.Graphics.DrawLine(New Pen(Color.Black), New Point(40, 425), New Point(780, 425))
        e.Graphics.DrawLine(New Pen(Color.Black), New Point(40, 430), New Point(780, 430))

        e.Graphics.DrawString("Módulo :", SystemFonts.DefaultFont, Brushes.Black, 60, 450)
        e.Graphics.DrawString(moduee, SystemFonts.DefaultFont, Brushes.Black, 669, 450)
        e.Graphics.DrawString("Autoavaliação :", SystemFonts.DefaultFont, Brushes.Black, 60, 500)
        e.Graphics.DrawString(autoee, SystemFonts.DefaultFont, Brushes.Black, 669, 500)
        e.Graphics.DrawString("Nota Final :", SystemFonts.DefaultFont, Brushes.Black, 60, 550)
        e.Graphics.DrawString(finalee, SystemFonts.DefaultFont, Brushes.Black, 669, 550)
        ' e.Graphics.DrawString("Desconto :", SystemFonts.DefaultFont, Brushes.Black, 60, 600)
        'e.Graphics.DrawString(DescontoTextBox.Text, SystemFonts.DefaultFont, Brushes.Black, 669, 600)


        e.Graphics.DrawLine(New Pen(Color.Black), New Point(40, 650), New Point(780, 650))
        ' e.Graphics.DrawString("Total a Pagar (com iva):", SystemFonts.DefaultFont, Brushes.Black, 60, 700)
        'e.Graphics.DrawString(Format(total, "0.00 €"), SystemFonts.DefaultFont, Brushes.Black, 669, 700)



    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub
End Class