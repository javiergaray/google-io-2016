Public Class mainform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim precio As Integer = 1500
        Dim imp As Integer = precio * 0.1
        Dim total As Integer = precio + imp

        Label3.Text = precio.ToString("$ 0,000")
        Label7.Text = precio.ToString
        Label8.Text = imp.ToString
        Label9.Text = total.ToString




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim precio As Integer = 2000
        Dim imp As Integer = precio * 0.1
        Dim total As Integer = precio + imp

        Label3.Text = precio.ToString("$ 0,000")
        Label7.Text = precio.ToString
        Label8.Text = imp.ToString
        Label9.Text = total.ToString


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim precio As Integer = 2500
        Dim imp As Integer = precio * 0.1
        Dim total As Integer = precio + imp

        Label3.Text = precio.ToString("$ 0,000")
        Label7.Text = precio.ToString
        Label8.Text = imp.ToString
        Label9.Text = total.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        MsgBox("entradas adquiridas")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label3.Text = "seleccione"
        Label7.Text = "-"
        Label8.Text = "-"
        Label9.Text = "-"








    End Sub
End Class