Public Class Form1

    Dim total As Decimal

    Private Sub Penny_Click(sender As Object, e As EventArgs) Handles Penny.Click
        Dim pennyquant As Integer
        pennyquant = PennyCount.Text()
        PennyCount.Text() = pennyquant + 1

        total = TotalValue.Text()
        TotalValue.Text() = total + 0.01
    End Sub

    Private Sub Nickel_Click(sender As Object, e As EventArgs) Handles Nickel.Click
        Dim nickelquant As Integer
        nickelquant = NickelCount.Text()
        NickelCount.Text() = nickelquant + 1

        total = TotalValue.Text()
        TotalValue.Text() = total + 0.05
    End Sub

    Private Sub Dime_Click(sender As Object, e As EventArgs) Handles Dime.Click
        Dim dimequant As Integer
        dimequant = DimeCount.Text()
        DimeCount.Text() = dimequant + 1

        total = TotalValue.Text()
        TotalValue.Text() = total + 0.1
    End Sub

    Private Sub Quarter_Click(sender As Object, e As EventArgs) Handles Quarter.Click
        Dim quarterquant As Integer
        quarterquant = QuarterCount.Text()
        QuarterCount.Text() = quarterquant + 1

        total = TotalValue.Text()
        TotalValue.Text() = total + 0.25
    End Sub

    Private Sub HalfDollar_Click(sender As Object, e As EventArgs) Handles HalfDollar.Click
        Dim halfdollarquant As Integer
        halfdollarquant = HalfDollarCount.Text()
        HalfDollarCount.Text() = halfdollarquant + 1

        total = TotalValue.Text()
        TotalValue.Text() = total + 0.5
    End Sub

    Private Sub Dollar_Click(sender As Object, e As EventArgs) Handles Dollar.Click
        Dim dollarquant As Integer
        dollarquant = DollarCount.Text()
        DollarCount.Text() = dollarquant + 1

        total = TotalValue.Text()
        TotalValue.Text() = total + 1
    End Sub
End Class
