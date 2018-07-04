Public Class frmVendingMachine
    Public Delay As Integer
    Private Sub tmrAnimate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAnimate.Tick
        Delay += 1
        If Delay = 5 Then
            pbStickmonStand1.Visible = False
            pbStickmonWalk1.Visible = True
        End If
        If Delay = 10 Then
            pbStickmonWalk1.Visible = False
            pbStickmonStand2.Visible = True
        End If
        If Delay = 15 Then
            pbStickmonStand2.Visible = False
            pbStickmonWalk2.Visible = True
        End If
        If Delay = 20 Then
            pbStickmonWalk2.Visible = False
            pbStickmonStand3.Visible = True
        End If
        If Delay = 25 Then
            pbStickmonStand3.Visible = False
            pbStickmonWalk3.Visible = True
        End If
        If Delay = 30 Then
            pbStickmonWalk3.Visible = False
            pbStickmonStand4.Visible = True
        End If
        If Delay = 35 Then
            pbStickmonStand4.Visible = False
            pbStickmonWalk4.Visible = True
        End If
        If Delay = 40 Then
            pbStickmonWalk4.Visible = False
            pbStickmonStand5.Visible = True
        End If
        If Delay = 45 Then
            pbStickmonStand5.Visible = False
            pbStickmonWalk5.Visible = True
        End If
        If Delay = 50 Then
            pbStickmonWalk5.Visible = False
            pbStickmonPos.Visible = True
        End If
        If Delay = 65 Then
            Me.BackgroundImage = My.Resources.vending_machines_Keypad
            pnlA.Visible = True
            pnlB.Visible = True
            pnlC.Visible = True
            pnlD.Visible = True
            pnlOne.Visible = True
            pnlTwo.Visible = True
            pnlThree.Visible = True
            pnlFour.Visible = True
            pnlFive.Visible = True
            pnlSix.Visible = True
            pnlSeven.Visible = True
            pnlEight.Visible = True
            pnlNine.Visible = True
            PnlZero.Visible = True

            lblInfo.Visible = True
            lblItem.Visible = True

            tmrAnimate.Enabled = False

        End If
    End Sub

    Private Sub pnlA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlA.Click
        lblItem.Text += "A"
    End Sub

    Private Sub pnlB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlB.Click
        lblItem.Text += "B"
    End Sub

    Private Sub pnlC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlC.Click
        lblItem.Text += "C"
    End Sub

    Private Sub pnlD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlD.Click
        lblItem.Text += "D"
    End Sub

    Private Sub PnlZero_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PnlZero.Click
        lblItem.Text += "0"
    End Sub

    Private Sub pnlOne_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlOne.Click
        lblItem.Text += "1"
    End Sub

    Private Sub pnlTwo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlTwo.Click
        lblItem.Text += "2"
    End Sub

    Private Sub pnlThree_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlThree.Click
        lblItem.Text += "3"
        txtTest.Text += "3"
    End Sub

    Private Sub pnlFour_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlFour.Click
        lblItem.Text += "4"
    End Sub

    Private Sub pnlFive_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlFive.Click
        lblItem.Text += "5"
    End Sub

    Private Sub pnlSix_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlSix.Click
        lblItem.Text += "6"
    End Sub

    Private Sub pnlSeven_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlSeven.Click
        lblItem.Text += "7"
    End Sub

    Private Sub pnlEight_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlEight.Click
        lblItem.Text += "8"
    End Sub

    Private Sub pnlNine_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlNine.Click
        lblItem.Text += "9"
    End Sub

    Private Sub pnlEnter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlEnter.Click

    End Sub

    Private Sub tmrKeypad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrKeypad.Tick
        If lblItem.Text = 2 Then
            pnlA.Visible = False
            pnlB.Visible = False
            pnlC.Visible = False
            pnlD.Visible = False
            pnlOne.Visible = False
            pnlTwo.Visible = False
            pnlThree.Visible = False
            pnlFour.Visible = False
            pnlFive.Visible = False
            pnlSix.Visible = False
            pnlSeven.Visible = False
            pnlEight.Visible = False
            pnlNine.Visible = False
            PnlZero.Visible = False

        End If
    End Sub
End Class
