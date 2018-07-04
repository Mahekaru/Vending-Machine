Public Class frmDebug
    Public Debug As Integer
    Public Clicked As Integer
    Private Sub tmrTEST_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDebug.Tick

        txtCreditCardX.Text = frmVendingMachine.CreditCardX
        txtCreditCardY.Text = frmVendingMachine.CreditCardY
        txtTest3.Text = frmVendingMachine.DoorY
        txtInfoTime.Text = frmVendingMachine.InfoTime
        txtAnimationTime.Text = frmVendingMachine.AnimationTime
        txtInfoDelay.Text = frmVendingMachine.info_Delay
        txtDelay.Text = frmVendingMachine.Delay
        txtAnimation.Text = frmVendingMachine.animation
        txtCredit.Text = frmVendingMachine.Credit
        txtCokeMachine.Text = frmVendingMachine.CokeMachine
        txtCokeMachineX.Text = frmVendingMachine.CokeMachineX
        txtCokeMachineY.Text = frmVendingMachine.CokeMachineY
        txtDecline.Text = frmVendingMachine.Decline
        txtTime.Text = frmVendingMachine.Time
        txtPepsiMachine.Text = frmVendingMachine.PepsiMachine
        txtPepsiMachineX.text = frmVendingMachine.PepsiMachineX
        txtPepsiMachineY.text = frmVendingMachine.PepsiMachineY
        txtAnimeForklist.Text = frmVendingMachine.AnimeForklift
        txtCandrinkMachineX.Text = frmVendingMachine.CanDrinkMachineX
        txtCanDrinkMachineY.Text = frmVendingMachine.CanDrinkMachineY
        txtCanDrinkMachine.Text = frmVendingMachine.CanDrinkMachine
        txtIceCreamMachineX.Text = frmVendingMachine.IceCreamMachineX
        txtIceCreamMachineY.Text = frmVendingMachine.IceCreamMachineY
        txtIceCreamMachine.Text = frmVendingMachine.IceCreamMachine
        txtLiveBaitMachineX.Text = frmVendingMachine.LiveBaitMachineX
        txtLiveMachineY.Text = frmVendingMachine.LiveBaitMachineY
        txtLiveMachine.Text = frmVendingMachine.livebaitMachine
        txtMiscSnacksMachineX.Text = frmVendingMachine.MiscSnackMachineX
        txtMiscSnacksMachineY.Text = frmVendingMachine.MiscSnackMachineY
        MiscSnacksMachine.Text = frmVendingMachine.MiscSnackMachine
        MountainDewMachineX.Text = frmVendingMachine.MountainDewMachineX
        txtMountainDewMachineY.Text = frmVendingMachine.mountainDewMachineY
        txtMountainDewMachine.Text = frmVendingMachine.MountainDewMachine
        txtPastaMachineX.Text = frmVendingMachine.PastaMachineX
        txtPastaMachineY.Text = frmVendingMachine.PastaMachineY
        txtPastaMachine.text = frmVendingMachine.PastaMachine
        txtPizzaMachineX.Text = frmVendingMachine.PizzaMachineX
        txtPizzaMachineY.Text = frmVendingMachine.PizzaMachineY
        txtPizzaMachine.Text = frmVendingMachine.PizzaMachine
        txtSnackDrinkMachineX.Text = frmVendingMachine.SnackDrinkMachineX
        txtSnackDrinkMachineY.Text = frmVendingMachine.SnackDrinkMachineY
        txtTest44.Text = frmVendingMachine.SnackDrinkMachine
        txtSnackMachineX.Text = frmVendingMachine.SnackMachineX
        txtSnackMachineY.Text = frmVendingMachine.SnackMachineY
        txtSnackMachine.Text = frmVendingMachine.SnackMachine
        txtUmbrellaMachineX.Text = frmVendingMachine.UmbrellaMachineX
        txtUmbrellaMachineY.Text = frmVendingMachine.UmbrellaMachineY
        txtUmbrellaMachine.Text = frmVendingMachine.UmbrellaMachine
        txtGenericSodaMachineX.Text = frmVendingMachine.GenericSodaMachineX
        txtGenericSodaMachineY.Text = frmVendingMachine.GenericSodaMachineY
        txtGenericSodaMachine.Text = frmVendingMachine.GenericSodaMachine
        txtAnimeForklist.Text = frmVendingMachine.AnimeForklift




    End Sub

   





    Private Sub btnDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebug.Click
        If Clicked = 0 Then
            Clicked += 1
            Debug += 1
            btnDebug.Text = "DEBUG ON"
            frmVendingMachine.lblInfo.Text = ""
            frmVendingMachine.Focus()
        Else
            Debug -= 1
            btnDebug.Text = "DEBUG OFF"
            Clicked -= 1
            frmVendingMachine.Focus()
        End If
    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click

        If Not IsNumeric(txtCreditConfig.Text) Then
            txtCreditConfig.Text = ""
        ElseIf txtCreditConfig.Text.Length > 9 Then
            txtCreditConfig.Text = ""
        Else
            frmVendingMachine.Credit = txtCreditConfig.Text
            frmVendingMachine.Focus()
        End If
    End Sub

    Private Sub cbSound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSound.CheckedChanged
        If cbSound.Checked = True Then
            cbSound.Text = "Sound ON"
            frmVendingMachine.Sound = 0
        Else
            cbSound.Text = "Sound OFF"
            frmVendingMachine.Sound = 1
        End If
    End Sub

    Private Sub frmDebug_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 112 Then 'F1 is pressed
            Me.Visible = False
        End If
    End Sub
End Class