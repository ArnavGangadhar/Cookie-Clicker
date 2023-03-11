Public Class Form1
    Public totalCookies, ClickValue, ClickLevel As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        totalCookies = 0
        ClickValue = 1
        ClickLevel = 1
        set_Timer(100)
        Passivecookietimer.Start()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub cookie_click()
        totalCookies = totalCookies + ClickValue
        Cookie_Value.Text = "value" + totalCookies.ToString
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        cookie_click()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        totalCookies = totalCookies + 10
        Cookie_Value.Text = "Value: " + totalCookies.ToString
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub set_Timer(interval As Integer)
        Passivecookietimer.Interval = interval
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim upgradeCost As Integer
        upgradeCost = ClickLevel * 2

        If totalCookies >= upgradeCost Then
            totalCookies = totalCookies - upgradeCost

            ClickLevel = ClickLevel + 1
            ClickValue = (ClickLevel - 1) * 5

            upgradeCost = ClickLevel * 2
            lbl_cost_click.Text = "LvL: " + ClickLevel.ToString
            lbl_cost_wide.Text = "Price: " + upgradeCost.ToString
            Button1.Text = "Click to increase cookies by " + ClickValue.ToString
        End If
    End Sub
End Class

