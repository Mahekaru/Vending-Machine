' Author:       Michael Jennings
' Professor:    Steve Carver
' Assignment:   Final Project
' Description:  Vending machine that sells vending machines, works just like the real thing!!!!
' Date created: 12/3/10
Imports System

Public Class frmVendingMachine
    Public Delay As Integer '
    Public info_Delay As Integer '

    Public CokeMachineX As Integer = 94 '
    Public CokeMachineY As Integer = 53 '
    Public CokeMachine As Integer = 2 ' 

    Public PepsiMachineX As Integer = 160 '
    Public PepsiMachineY As Integer = 53 '
    Public PepsiMachine As Integer = 3 '

    Public CanDrinkMachineX As Integer = 220
    Public CanDrinkMachineY As Integer = 53
    Public CanDrinkMachine As Integer = 2 '-----------------------------------------------------HERE

    Public IceCreamMachineX As Integer = 285
    Public IceCreamMachineY As Integer = 53
    Public IceCreamMachine As Integer = 4

    Public LiveBaitMachineX As Integer = 94
    Public LiveBaitMachineY As Integer = 154
    Public livebaitMachine As Integer = 4

    Public MiscSnackMachineX As Integer = 160
    Public MiscSnackMachineY As Integer = 154
    Public MiscSnackMachine As Integer = 5

    Public MountainDewMachineX As Integer = 220
    Public mountainDewMachineY As Integer = 154
    Public MountainDewMachine As Integer = 3

    Public PastaMachineX As Integer = 285
    Public PastaMachineY As Integer = 154
    Public PastaMachine As Integer = 2

    Public PizzaMachineX As Integer = 94
    Public PizzaMachineY As Integer = 255
    Public PizzaMachine As Integer = 1

    Public SnackDrinkMachineX As Integer = 161
    Public SnackDrinkMachineY As Integer = 255
    Public SnackDrinkMachine As Integer = 3

    Public SnackMachineX As Integer = 220
    Public SnackMachineY As Integer = 255
    Public SnackMachine As Integer = 2

    Public UmbrellaMachineX As Integer = 285
    Public UmbrellaMachineY As Integer = 255
    Public UmbrellaMachine As Integer = 3

    Public GenericSodaMachineX As Integer = 174
    Public GenericSodaMachineY As Integer = 352
    Public GenericSodaMachine As Integer = 6

    Public Key As Integer = 0

    Public CreditCardX As Integer = 97 '
    Public CreditCardY As Integer = 497 '

    Public DoorY As Integer = 640 '
    Public Time As Integer = 10 '
    Public InfoTime As Integer = 10 '
    Public AnimationTime As Integer = 10 '
    Public Credit As Integer = 5000 '
    Public animation As Integer = 1 '
    Public Decline As Integer = 0 '
    Public Sound As Integer

    Public AnimeForklift As String '

    Sub VendLoadSndBck()
        pbCreditCard.SendToBack()
        pbHalfCardReader.BringToFront()
        pbWDoor.BringToFront()


        pbCokeMachine1.SendToBack()
        pbCokeMachine2.SendToBack()

        pbPepsiMachine1.SendToBack() '-------------------------------------------------HERE
        pbPepsiMachine2.SendToBack()
        pbPepsiMachine3.SendToBack()

        pbCanDrinkMachine1.SendToBack()
        pbCanDrinkMachine2.SendToBack()

        pbIceCreamMachine1.SendToBack()
        pbIceCreamMachine2.SendToBack()
        pbIceCreamMachine3.SendToBack()
        pbIceCreamMachine4.SendToBack()

        pbLiveBaitMachine1.SendToBack()
        pbLiveBaitMachine2.SendToBack()
        pbLiveBaitMachine3.SendToBack()
        pbLiveBaitMachine4.SendToBack()

        pbMiscSnackMachine1.SendToBack()
        pbMiscSnackMachine2.SendToBack()
        pbMiscSnackMachine3.SendToBack()
        pbMiscSnackMachine4.SendToBack()
        pbMiscSnackMachine5.SendToBack()

        pbMountainDewMachine1.SendToBack()
        pbMountainDewMachine2.SendToBack()
        pbMountainDewMachine3.SendToBack()

        pbPastaMachine1.SendToBack()
        pbPastaMachine2.SendToBack()

        pbPizzaMachine1.SendToBack()

        pbSnackDrinkMachine1.SendToBack()
        pbSnackDrinkMachine2.SendToBack()
        pbSnackDrinkMachine3.SendToBack()

        pbSnackMachine1.SendToBack()
        pbSnackMachine2.SendToBack()

        pbUmbrellaMachine1.SendToBack()
        pbUmbrellaMachine2.SendToBack()
        pbUmbrellaMachine3.SendToBack()

        pbGenericSodaMachine1.SendToBack()
        pbGenericSodaMachine2.SendToBack()
        pbGenericSodaMachine3.SendToBack()
        pbGenericSodaMachine4.SendToBack()
        pbGenericSodaMachine5.SendToBack()
        pbGenericSodaMachine6.SendToBack()

        pbCanDrinkMachine1.SendToBack()
        pbCanDrinkMachine2.SendToBack()

        pbSoldOutLightA1.SendToBack()
        pbSoldOutLightA2.SendToBack()
        pbSoldOutLightA3.SendToBack()
        pbSoldOutLightA4.SendToBack()
        pbSoldOutLightB5.SendToBack()
        pbSoldOutLightB6.SendToBack()
        pbSoldOutLightB7.SendToBack()
        pbSoldOutLightB8.SendToBack()
        pbSoldOutLightC9.SendToBack()
        pbSoldOutLightC0.SendToBack()
        pbSoldOutLightC1.SendToBack()
        pbSoldOutLightC2.SendToBack()
        pbSoldOutLightD0.SendToBack()

        lblA1.SendToBack()
        lblA2.SendToBack()
        lblA3.SendToBack()
        lblA4.SendToBack()
        lblB5.SendToBack()
        lblB6.SendToBack()
        lblB7.SendToBack()
        lblB8.SendToBack()
        lblC0.SendToBack()
        lblC1.SendToBack()
        lblC2.SendToBack()
        lblC9.SendToBack()
        lblD0.SendToBack()

        lblPriceA1.SendToBack()
        lblPriceA2.SendToBack()
        lblPriceA3.SendToBack()
        lblPriceA4.SendToBack()
        lblPriceB5.SendToBack()
        lblPriceB6.SendToBack()
        lblPriceB7.SendToBack()
        lblPriceB8.SendToBack()
        lblPriceC0.SendToBack()
        lblPriceC1.SendToBack()
        lblPriceC2.SendToBack()
        lblPriceC9.SendToBack()
        lblPriceD0.SendToBack()

        lblMoney.Text = ""
    End Sub

    Private Sub frmVendingMachine_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If Key = 0 Then
            If e.KeyCode = 112 Then 'F1 is pressed
                frmDebug.Visible = True
                Key = 1
                Me.Focus()
            End If
        Else
            If e.KeyCode = 112 Then 'F1 is pressed
                frmDebug.Visible = False
                Key = 0
                Me.Focus()
            End If
        End If

    End Sub


    Private Sub frmVendingMachine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblInfo.Visible = False
        pnlOne.Enabled = False
        pnlTwo.Enabled = False
        pnlThree.Enabled = False
        pnlFour.Enabled = False
        pnlFive.Enabled = False
        pnlSix.Enabled = False
        pnlSeven.Enabled = False
        pnlEight.Enabled = False
        pnlNine.Enabled = False
        pbZero.Enabled = False
        frmDebug.Visible = False
        VendLoadSndBck()
    End Sub

    Sub AnimationChange()
        If animation = 1 Then
            pbStickmonWalk1.Image = My.Resources.Stickmon_run
            pbStickmonWalk2.Image = My.Resources.Stickmon_run
            pbStickmonWalk3.Image = My.Resources.Stickmon_run
            pbStickmonWalk4.Image = My.Resources.Stickmon_run
            pbStickmonWalk5.Image = My.Resources.Stickmon_run
            pbStickmonStand1.Image = My.Resources.Stickmon
            pbStickmonStand2.Image = My.Resources.Stickmon
            pbStickmonStand3.Image = My.Resources.Stickmon
            pbStickmonStand4.Image = My.Resources.Stickmon
            pbStickmonStand5.Image = My.Resources.Stickmon
            pbStickmonPos.Image = My.Resources.stickmon_stand
        ElseIf animation = -1 Then
            pbStickmonWalk1.Image = My.Resources.Neg_Stickmon_run
            pbStickmonWalk2.Image = My.Resources.Neg_Stickmon_run
            pbStickmonWalk3.Image = My.Resources.Neg_Stickmon_run
            pbStickmonWalk4.Image = My.Resources.Neg_Stickmon_run
            pbStickmonWalk5.Image = My.Resources.Neg_Stickmon_run
            pbStickmonStand1.Image = My.Resources.Neg_Stickmon
            pbStickmonStand2.Image = My.Resources.Neg_Stickmon
            pbStickmonStand3.Image = My.Resources.Neg_Stickmon
            pbStickmonStand4.Image = My.Resources.Neg_Stickmon
            pbStickmonStand5.Image = My.Resources.Neg_Stickmon
        End If

    End Sub

    Sub Forklift()

        If AnimeForklift = "Coke" Then
            pbStickmonForklift4.Image = My.Resources.Stickmon_Forklift_Coke
            pbStickmonForklift5.Image = My.Resources.Stickmon_Forklift_Coke
            pbStickmonForklift6.Image = My.Resources.Stickmon_Forklift_Coke
        ElseIf AnimeForklift = "Pepsi" Then
            pbStickmonForklift4.Image = My.Resources.Stickmon_Forklift_Pepsi '----------------------------------------------HERE
            pbStickmonForklift5.Image = My.Resources.Stickmon_Forklift_Pepsi
            pbStickmonForklift6.Image = My.Resources.Stickmon_Forklift_Pepsi
        ElseIf AnimeForklift = "CanDrinks" Then
            pbStickmonForklift4.Image = My.Resources.Stickmon_Forklift_Can_Drinks
            pbStickmonForklift5.Image = My.Resources.Stickmon_Forklift_Can_Drinks
            pbStickmonForklift6.Image = My.Resources.Stickmon_Forklift_Can_Drinks
        ElseIf AnimeForklift = "IceCream" Then
            pbStickmonForklift4.Image = My.Resources.Stickmon_Forklift_Ice_Cream
            pbStickmonForklift5.Image = My.Resources.Stickmon_Forklift_Ice_Cream
            pbStickmonForklift6.Image = My.Resources.Stickmon_Forklift_Ice_Cream
        ElseIf AnimeForklift = "LiveBait" Then
            pbStickmonForklift4.Image = My.Resources.Stickmon_Forklift_Live_Bait
            pbStickmonForklift5.Image = My.Resources.Stickmon_Forklift_Live_Bait
            pbStickmonForklift6.Image = My.Resources.Stickmon_Forklift_Live_Bait
        ElseIf AnimeForklift = "MiscSnacks" Then
            pbStickmonForklift4.Image = My.Resources.Stickmon_Forklift_Mics_Snacks
            pbStickmonForklift5.Image = My.Resources.Stickmon_Forklift_Mics_Snacks
            pbStickmonForklift6.Image = My.Resources.Stickmon_Forklift_Mics_Snacks
        ElseIf AnimeForklift = "MountainDew" Then
            pbStickmonForklift4.Image = My.Resources.Stickmon_Forklift_Mountain_Dew
            pbStickmonForklift5.Image = My.Resources.Stickmon_Forklift_Mountain_Dew
            pbStickmonForklift6.Image = My.Resources.Stickmon_Forklift_Mountain_Dew
        ElseIf AnimeForklift = "Pasta" Then
            pbStickmonForklift4.Image = My.Resources.Stickmon_Forklift_Pasta
            pbStickmonForklift5.Image = My.Resources.Stickmon_Forklift_Pasta
            pbStickmonForklift6.Image = My.Resources.Stickmon_Forklift_Pasta
        ElseIf AnimeForklift = "Pizza" Then
            pbStickmonForklift4.Image = My.Resources.Stickmon_Forklift_Pizza
            pbStickmonForklift5.Image = My.Resources.Stickmon_Forklift_Pizza
            pbStickmonForklift6.Image = My.Resources.Stickmon_Forklift_Pizza
        ElseIf AnimeForklift = "SnackDrink" Then
            pbStickmonForklift4.Image = My.Resources.Stickmon_Forklift_Snacks_Drinks
            pbStickmonForklift5.Image = My.Resources.Stickmon_Forklift_Snacks_Drinks
            pbStickmonForklift6.Image = My.Resources.Stickmon_Forklift_Snacks_Drinks
        ElseIf AnimeForklift = "Snacks" Then
            pbStickmonForklift4.Image = My.Resources.Stickmon_Forklift_Snacks
            pbStickmonForklift5.Image = My.Resources.Stickmon_Forklift_Snacks
            pbStickmonForklift6.Image = My.Resources.Stickmon_Forklift_Snacks
        ElseIf AnimeForklift = "Umbrella" Then
            pbStickmonForklift4.Image = My.Resources.Stickmon_Forklift_Umbrella
            pbStickmonForklift5.Image = My.Resources.Stickmon_Forklift_Umbrella
            pbStickmonForklift6.Image = My.Resources.Stickmon_Forklift_Umbrella
        ElseIf AnimeForklift = "Generic" Then
            pbStickmonForklift4.Image = My.Resources.Stickmon_Forklift_Generic_Soda
            pbStickmonForklift5.Image = My.Resources.Stickmon_Forklift_Generic_Soda
            pbStickmonForklift6.Image = My.Resources.Stickmon_Forklift_Generic_Soda
        End If
    End Sub
    Private Sub tmrAnimate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAnimate.Tick
        If frmDebug.Debug = 1 Then
            If AnimationTime = 10 Then '------------------------------AnimationTime 10    DEBUG

                pbStickmonStand1.Visible = False
                pbStickmonStand2.Visible = False
                pbStickmonStand3.Visible = False
                pbStickmonStand4.Visible = False
                pbStickmonStand5.Visible = False
                pbStickmonWalk1.Visible = False
                pbStickmonWalk2.Visible = False
                pbStickmonWalk3.Visible = False
                pbStickmonWalk4.Visible = False
                pbStickmonWalk5.Visible = False
                pbStickmonPos.Visible = False
                pbStickmonForklift1.Visible = False
                pbStickmonForklift2.Visible = False
                pbStickmonForklift3.Visible = False
                pbStickmonForklift4.Visible = False
                pbStickmonForklift5.Visible = False
                pbStickmonForklift6.Visible = False
                pbWDoor.Visible = False
                pbMid.Visible = False

                Delay = 65
                If Delay = 65 Then
                    InfoTime = 100
                    'tmrInfo.Enabled = True
                    lblInfo.Visible = True

                    pbStickmonPos.SendToBack()
                    Me.BackgroundImage = My.Resources.vending_machines_Keypad
                    pnlA.Visible = True
                    pnlB.Visible = True
                    pnlC.Visible = True
                    pbD.Visible = True
                    pnlOne.Visible = True
                    pnlTwo.Visible = True
                    pnlThree.Visible = True
                    pnlFour.Visible = True
                    pnlFive.Visible = True
                    pnlSix.Visible = True
                    pnlSeven.Visible = True
                    pnlEight.Visible = True
                    pnlNine.Visible = True
                    pbZero.Visible = True
                    pbEnter.Visible = True
                    pbClr.Visible = True

                    lblInfo.Visible = True
                    lblItem.Visible = True
                    lblCashSign.Visible = True
                    lblMoney.Visible = True

                    AnimationTime = 0
                    Delay = 0
                End If




            ElseIf AnimationTime = 20 Then '------------------------------AnimationTime 20    DEBUG

                Delay = 55
                If Delay = 55 Then
                    pbStickmonStand1.Visible = False
                    AnimationTime = 30
                    Delay = 0
                End If




            ElseIf AnimationTime = 30 Then '------------------------------AnimationTime 30    DEBUG
                Delay = 20
                If Delay = 20 Then
                    AnimationTime = 10
                    animation = 1
                    AnimationChange()
                    Delay = 0
                    tmrCrditCard.Enabled = False
                    Decline += 1
                End If




            ElseIf AnimationTime = 40 Then '------------------------------AnimationTime 40    DEBUG
                Delay += 2

                If Delay = 44 Then
                    If AnimeForklift = "Coke" Then
                        If CokeMachine = 1 Then
                            pbCokeMachine1.Visible = False
                        Else
                            pbCokeMachine2.Visible = False
                        End If
                    ElseIf AnimeForklift = "Pepsi" Then
                        If PepsiMachine = 1 Then
                            pbPepsiMachine1.Visible = False
                        ElseIf PepsiMachine = 2 Then
                            pbPepsiMachine2.Visible = False
                        Else
                            pbPepsiMachine3.Visible = False
                        End If
                    ElseIf AnimeForklift = "CanDrinks" Then
                        If CanDrinkMachine = 1 Then
                            pbCanDrinkMachine1.Visible = False
                        Else
                            pbCanDrinkMachine2.Visible = False
                        End If
                    ElseIf AnimeForklift = "IceCream" Then
                        If IceCreamMachine = 1 Then
                            pbIceCreamMachine1.Visible = False
                        ElseIf IceCreamMachine = 2 Then
                            pbIceCreamMachine2.Visible = False
                        ElseIf IceCreamMachine = 3 Then
                            pbIceCreamMachine3.Visible = False
                        ElseIf IceCreamMachine = 4 Then
                            pbIceCreamMachine4.Visible = False
                        End If
                    ElseIf AnimeForklift = "LiveBait" Then
                        If livebaitMachine = 1 Then
                            pbLiveBaitMachine1.Visible = False
                        ElseIf livebaitMachine = 2 Then
                            pbLiveBaitMachine2.Visible = False
                        ElseIf livebaitMachine = 3 Then
                            pbLiveBaitMachine3.Visible = False
                        ElseIf livebaitMachine = 4 Then
                            pbLiveBaitMachine4.Visible = False
                        End If
                    ElseIf AnimeForklift = "MiscSnacks" Then
                        If MiscSnackMachine = 1 Then
                            pbMiscSnackMachine1.Visible = False
                        ElseIf MiscSnackMachine = 2 Then
                            pbMiscSnackMachine2.Visible = False
                        ElseIf MiscSnackMachine = 3 Then
                            pbMiscSnackMachine3.Visible = False
                        ElseIf MiscSnackMachine = 4 Then
                            pbMiscSnackMachine4.Visible = False
                        ElseIf MiscSnackMachine = 5 Then
                            pbMiscSnackMachine5.Visible = False
                        End If
                    ElseIf AnimeForklift = "MountainDew" Then
                        If MountainDewMachine = 1 Then
                            pbMountainDewMachine1.Visible = False
                        ElseIf MountainDewMachine = 2 Then
                            pbMountainDewMachine2.Visible = False
                        ElseIf MountainDewMachine = 3 Then
                            pbMountainDewMachine3.Visible = False
                        End If
                    ElseIf AnimeForklift = "Pasta" Then
                        If PastaMachine = 1 Then
                            pbPastaMachine1.Visible = False
                        ElseIf PastaMachine = 2 Then
                            pbPastaMachine2.Visible = False
                        End If
                    ElseIf AnimeForklift = "Pizza" Then
                        If PizzaMachine = 1 Then
                            pbPizzaMachine1.Visible = False
                        End If
                    ElseIf AnimeForklift = "SnackDrink" Then
                        If SnackDrinkMachine = 1 Then
                            pbSnackDrinkMachine1.Visible = False
                        ElseIf SnackDrinkMachine = 2 Then
                            pbSnackDrinkMachine2.Visible = False
                        ElseIf SnackDrinkMachine = 3 Then
                            pbSnackDrinkMachine3.Visible = False
                        End If
                    ElseIf AnimeForklift = "Snacks" Then
                        If SnackMachine = 1 Then
                            pbSnackMachine1.Visible = False
                        ElseIf SnackMachine = 2 Then
                            pbSnackMachine2.Visible = False
                        End If
                    ElseIf AnimeForklift = "Umbrella" Then
                        If UmbrellaMachine = 1 Then
                            pbUmbrellaMachine1.Visible = False
                        ElseIf UmbrellaMachine = 2 Then
                            pbUmbrellaMachine2.Visible = False
                        ElseIf UmbrellaMachine = 3 Then
                            pbUmbrellaMachine3.Visible = False
                        End If
                    ElseIf AnimeForklift = "Generic" Then
                        If GenericSodaMachine = 1 Then
                            pbGenericSodaMachine1.Visible = False
                        ElseIf GenericSodaMachine = 2 Then
                            pbGenericSodaMachine2.Visible = False
                        ElseIf GenericSodaMachine = 3 Then
                            pbGenericSodaMachine3.Visible = False
                        ElseIf GenericSodaMachine = 4 Then
                            pbGenericSodaMachine4.Visible = False
                        ElseIf GenericSodaMachine = 5 Then
                            pbGenericSodaMachine5.Visible = False
                        ElseIf GenericSodaMachine = 6 Then
                            pbGenericSodaMachine6.Visible = False
                        End If
                    End If '----------------------------------------------------------------HERE    DEBUG
                End If

                If Delay = 70 Then
                    AnimationTime = 10
                    animation = 1
                    AnimationChange()
                    Delay = 0
                    tmrCrditCard.Enabled = False
                    pbMid.Visible = False
                    pbWDoor.Visible = False
                    pbBottom.Visible = False

                    lblMoney.Text = ""
                    lblItem.Text = ""

                    If AnimeForklift = "Coke" Then
                        CokeMachine -= 1
                        If CokeMachine = 0 Then
                            pbSoldOutLightA1.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightA1.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "Pepsi" Then '---------------------------------------------HERE   
                        PepsiMachine -= 1
                        If PepsiMachine = 0 Then
                            pbSoldOutLightA2.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightA2.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "CanDrinks" Then
                        CanDrinkMachine -= 1
                        If CanDrinkMachine = 0 Then
                            pbSoldOutLightA3.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightA3.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "IceCream" Then
                        IceCreamMachine -= 1
                        If IceCreamMachine = 0 Then
                            pbSoldOutLightA4.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightA4.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "LiveBait" Then
                        livebaitMachine -= 1
                        If livebaitMachine = 0 Then
                            pbSoldOutLightB5.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightB5.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "MiscSnacks" Then
                        MiscSnackMachine -= 1
                        If MiscSnackMachine = 0 Then
                            pbSoldOutLightB6.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightB6.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "MountainDew" Then
                        MountainDewMachine -= 1
                        If MountainDewMachine = 0 Then
                            pbSoldOutLightB7.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightB7.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "Pasta" Then
                        PastaMachine -= 1
                        If PastaMachine = 0 Then
                            pbSoldOutLightB8.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightB8.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "Pizza" Then
                        PizzaMachine -= 1
                        If PizzaMachine = 0 Then
                            pbSoldOutLightC9.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightC9.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "SnackDrink" Then
                        SnackDrinkMachine -= 1
                        If SnackDrinkMachine = 0 Then
                            pbSoldOutLightC0.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightC0.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "Snacks" Then
                        SnackMachine -= 1
                        If SnackMachine = 0 Then
                            pbSoldOutLightC1.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightC1.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "Umbrella" Then
                        UmbrellaMachine -= 1
                        If UmbrellaMachine = 0 Then
                            pbSoldOutLightC2.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightC2.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "Generic" Then
                        GenericSodaMachine -= 1
                        If GenericSodaMachine = 0 Then
                            pbSoldOutLightD0.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightD0.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If

                    CokeMachineX = 94 '----------------------------------------------------------    DEBUG
                    CokeMachineY = 53

                    PepsiMachineX = 155 '----------------------------------------------------------   DEBUG
                    PepsiMachineY = 53

                    CanDrinkMachineX = 220 '----------------------------------------------------------   DEBUG
                    CanDrinkMachineY = 53

                    IceCreamMachineX = 285 '----------------------------------------------------------   DEBUG
                    IceCreamMachineY = 53

                    LiveBaitMachineX = 94 '----------------------------------------------------------    DEBUG
                    LiveBaitMachineY = 154

                    MiscSnackMachineX = 160 '----------------------------------------------------------   DEBUG
                    MiscSnackMachineY = 154

                    MountainDewMachineX = 220 '----------------------------------------------------------    DEBUG
                    mountainDewMachineY = 154

                    PastaMachineX = 94 '----------------------------------------------------------   DEBUG
                    PastaMachineY = 154

                    PizzaMachineX = 94 '----------------------------------------------------------    DEBUG
                    PizzaMachineY = 255

                    SnackDrinkMachineX = 161 '----------------------------------------------------------    DEBUG
                    SnackDrinkMachineY = 255

                    SnackMachineX = 220 '----------------------------------------------------------    DEBUG
                    SnackMachineY = 255

                    UmbrellaMachineX = 285 '----------------------------------------------------------    DEBUG
                    UmbrellaMachineY = 255

                    GenericSodaMachineX = 174 '----------------------------------------------------------   DEBUG
                    GenericSodaMachineY = 352

                    DoorY = 640

                End If
            End If '------------------------------------------------------------------------------------------------DEBUG END
        Else
            If AnimationTime = 10 Then '------------------------------AnimationTime 10
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
                    InfoTime = 100
                    'tmrInfo.Enabled = True
                    lblInfo.Visible = True

                    pbStickmonPos.SendToBack()
                    Me.BackgroundImage = My.Resources.vending_machines_Keypad
                    pnlA.Visible = True
                    pnlB.Visible = True
                    pnlC.Visible = True
                    pbD.Visible = True
                    pnlOne.Visible = True
                    pnlTwo.Visible = True
                    pnlThree.Visible = True
                    pnlFour.Visible = True
                    pnlFive.Visible = True
                    pnlSix.Visible = True
                    pnlSeven.Visible = True
                    pnlEight.Visible = True
                    pnlNine.Visible = True
                    pbZero.Visible = True
                    pbEnter.Visible = True
                    pbClr.Visible = True

                    lblInfo.Visible = True
                    lblItem.Visible = True
                    lblCashSign.Visible = True
                    lblMoney.Visible = True

                    AnimationTime = 0
                    Delay = 0
                End If




            ElseIf AnimationTime = 20 Then '------------------------------AnimationTime 20

                Delay += 1
                If Delay = 5 Then
                    pbStickmonPos.Visible = False
                    pbStickmonWalk5.Visible = True
                End If
                If Delay = 10 Then
                    pbStickmonWalk5.Visible = False
                    pbStickmonStand5.Visible = True
                End If
                If Delay = 15 Then
                    pbStickmonStand5.Visible = False
                    pbStickmonWalk4.Visible = True
                End If
                If Delay = 20 Then
                    pbStickmonWalk4.Visible = False
                    pbStickmonStand4.Visible = True
                End If
                If Delay = 25 Then
                    pbStickmonStand4.Visible = False
                    pbStickmonWalk3.Visible = True
                End If
                If Delay = 30 Then
                    pbStickmonWalk3.Visible = False
                    pbStickmonStand3.Visible = True
                End If
                If Delay = 35 Then
                    pbStickmonStand3.Visible = False
                    pbStickmonWalk2.Visible = True
                End If
                If Delay = 40 Then
                    pbStickmonWalk2.Visible = False
                    pbStickmonStand2.Visible = True
                End If
                If Delay = 45 Then
                    pbStickmonStand2.Visible = False
                    pbStickmonWalk1.Visible = True
                End If
                If Delay = 50 Then
                    pbStickmonWalk1.Visible = False
                    pbStickmonStand1.Visible = True

                End If
                If Delay = 55 Then
                    pbStickmonStand1.Visible = False
                    AnimationTime = 30
                    Delay = 0
                End If




            ElseIf AnimationTime = 30 Then '------------------------------AnimationTime 30
                Delay += 1
                If Delay = 20 Then
                    AnimationTime = 10
                    animation = 1
                    AnimationChange()
                    Delay = 0
                    tmrCrditCard.Enabled = False
                    Decline += 1
                End If




            ElseIf AnimationTime = 40 Then '------------------------------AnimationTime 40
                Delay += 1
                If Delay = 5 Then
                    pbStickmonPos.Image = My.Resources.stickmon_Thumbs_up
                End If
                If Delay = 15 Then
                    pbStickmonPos.Visible = False
                    pbStickmonWalk6.Visible = True
                End If
                If Delay = 20 Then
                    pbStickmonWalk6.Visible = False
                End If
                If Delay = 34 Then
                    pbStickmonForklift1.Visible = True
                End If
                If Delay = 38 Then
                    pbStickmonForklift1.Visible = False
                    pbStickmonForklift2.Visible = True
                End If
                If Delay = 41 Then
                    pbStickmonForklift2.Visible = False
                    pbStickmonForklift3.Visible = True
                End If
                If Delay = 44 Then
                    pbStickmonForklift3.Visible = False
                    pbStickmonForklift4.Visible = True
                    If AnimeForklift = "Coke" Then
                        If CokeMachine = 1 Then
                            pbCokeMachine1.Visible = False
                        Else
                            pbCokeMachine2.Visible = False
                        End If
                    ElseIf AnimeForklift = "Pepsi" Then
                        If PepsiMachine = 1 Then
                            pbPepsiMachine1.Visible = False
                        ElseIf PepsiMachine = 2 Then
                            pbPepsiMachine2.Visible = False
                        Else
                            pbPepsiMachine3.Visible = False
                        End If
                    ElseIf AnimeForklift = "CanDrinks" Then
                        If CanDrinkMachine = 1 Then
                            pbCanDrinkMachine1.Visible = False
                        Else
                            pbCanDrinkMachine2.Visible = False
                        End If
                    ElseIf AnimeForklift = "IceCream" Then
                        If IceCreamMachine = 1 Then
                            pbIceCreamMachine1.Visible = False
                        ElseIf IceCreamMachine = 2 Then
                            pbIceCreamMachine2.Visible = False
                        ElseIf IceCreamMachine = 3 Then
                            pbIceCreamMachine3.Visible = False
                        ElseIf IceCreamMachine = 4 Then
                            pbIceCreamMachine4.Visible = False
                        End If
                    ElseIf AnimeForklift = "LiveBait" Then
                        If livebaitMachine = 1 Then
                            pbLiveBaitMachine1.Visible = False
                        ElseIf livebaitMachine = 2 Then
                            pbLiveBaitMachine2.Visible = False
                        ElseIf livebaitMachine = 3 Then
                            pbLiveBaitMachine3.Visible = False
                        ElseIf livebaitMachine = 4 Then
                            pbLiveBaitMachine4.Visible = False
                        End If
                    ElseIf AnimeForklift = "MiscSnacks" Then
                        If MiscSnackMachine = 1 Then
                            pbMiscSnackMachine1.Visible = False
                        ElseIf MiscSnackMachine = 2 Then
                            pbMiscSnackMachine2.Visible = False
                        ElseIf MiscSnackMachine = 3 Then
                            pbMiscSnackMachine3.Visible = False
                        ElseIf MiscSnackMachine = 4 Then
                            pbMiscSnackMachine4.Visible = False
                        ElseIf MiscSnackMachine = 5 Then
                            pbMiscSnackMachine5.Visible = False
                        End If
                    ElseIf AnimeForklift = "MountainDew" Then
                        If MountainDewMachine = 1 Then
                            pbMountainDewMachine1.Visible = False
                        ElseIf MountainDewMachine = 2 Then
                            pbMountainDewMachine2.Visible = False
                        ElseIf MountainDewMachine = 3 Then
                            pbMountainDewMachine3.Visible = False
                        End If
                    ElseIf AnimeForklift = "Pasta" Then
                        If PastaMachine = 1 Then
                            pbPastaMachine1.Visible = False
                        ElseIf PastaMachine = 2 Then
                            pbPastaMachine2.Visible = False
                        End If
                    ElseIf AnimeForklift = "Pizza" Then
                        If PizzaMachine = 1 Then
                            pbPizzaMachine1.Visible = False
                        End If
                    ElseIf AnimeForklift = "SnackDrink" Then
                        If SnackDrinkMachine = 1 Then
                            pbSnackDrinkMachine1.Visible = False
                        ElseIf SnackDrinkMachine = 2 Then
                            pbSnackDrinkMachine2.Visible = False
                        ElseIf SnackDrinkMachine = 3 Then
                            pbSnackDrinkMachine3.Visible = False
                        End If
                    ElseIf AnimeForklift = "Snacks" Then
                        If SnackMachine = 1 Then
                            pbSnackMachine1.Visible = False
                        ElseIf SnackMachine = 2 Then
                            pbSnackMachine2.Visible = False
                        End If
                    ElseIf AnimeForklift = "Umbrella" Then
                        If UmbrellaMachine = 1 Then
                            pbUmbrellaMachine1.Visible = False
                        ElseIf UmbrellaMachine = 2 Then
                            pbUmbrellaMachine2.Visible = False
                        ElseIf UmbrellaMachine = 3 Then
                            pbUmbrellaMachine3.Visible = False
                        End If
                    ElseIf AnimeForklift = "Generic" Then
                        If GenericSodaMachine = 1 Then
                            pbGenericSodaMachine1.Visible = False
                        ElseIf GenericSodaMachine = 2 Then
                            pbGenericSodaMachine2.Visible = False
                        ElseIf GenericSodaMachine = 3 Then
                            pbGenericSodaMachine3.Visible = False
                        ElseIf GenericSodaMachine = 4 Then
                            pbGenericSodaMachine4.Visible = False
                        ElseIf GenericSodaMachine = 5 Then
                            pbGenericSodaMachine5.Visible = False
                        ElseIf GenericSodaMachine = 6 Then
                            pbGenericSodaMachine6.Visible = False
                        End If
                    End If '----------------------------------------------------------------HERE
                End If
                If Delay = 48 Then
                    pbStickmonForklift4.Visible = False
                    pbStickmonForklift5.Visible = True
                End If
                If Delay = 51 Then
                    pbStickmonForklift5.Visible = False
                    pbStickmonForklift6.Visible = True
                End If
                If Delay = 54 Then
                    pbStickmonForklift6.Visible = False
                End If

                If Delay = 70 Then
                    AnimationTime = 10
                    animation = 1
                    AnimationChange()
                    Delay = 0
                    tmrCrditCard.Enabled = False
                    pbMid.Visible = False
                    pbWDoor.Visible = False
                    pbBottom.Visible = False

                    lblMoney.Text = ""
                    lblItem.Text = ""

                    If AnimeForklift = "Coke" Then
                        CokeMachine -= 1
                        If CokeMachine = 0 Then
                            pbSoldOutLightA1.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightA1.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "Pepsi" Then '---------------------------------------------HERE   
                        PepsiMachine -= 1
                        If PepsiMachine = 0 Then
                            pbSoldOutLightA2.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightA2.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "CanDrinks" Then
                        CanDrinkMachine -= 1
                        If CanDrinkMachine = 0 Then
                            pbSoldOutLightA3.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightA3.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "IceCream" Then
                        IceCreamMachine -= 1
                        If IceCreamMachine = 0 Then
                            pbSoldOutLightA4.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightA4.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "LiveBait" Then
                        livebaitMachine -= 1
                        If livebaitMachine = 0 Then
                            pbSoldOutLightB5.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightB5.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "MiscSnacks" Then
                        MiscSnackMachine -= 1
                        If MiscSnackMachine = 0 Then
                            pbSoldOutLightB6.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightB6.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "MountainDew" Then
                        MountainDewMachine -= 1
                        If MountainDewMachine = 0 Then
                            pbSoldOutLightB7.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightB7.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "Pasta" Then
                        PastaMachine -= 1
                        If PastaMachine = 0 Then
                            pbSoldOutLightB8.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightB8.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "Pizza" Then
                        PizzaMachine -= 1
                        If PizzaMachine = 0 Then
                            pbSoldOutLightC9.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightC9.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "SnackDrink" Then
                        SnackDrinkMachine -= 1
                        If SnackDrinkMachine = 0 Then
                            pbSoldOutLightC0.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightC0.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "Snacks" Then
                        SnackMachine -= 1
                        If SnackMachine = 0 Then
                            pbSoldOutLightC1.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightC1.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "Umbrella" Then
                        UmbrellaMachine -= 1
                        If UmbrellaMachine = 0 Then
                            pbSoldOutLightC2.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightC2.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If
                    If AnimeForklift = "Generic" Then
                        GenericSodaMachine -= 1
                        If GenericSodaMachine = 0 Then
                            pbSoldOutLightD0.Image = My.Resources.Sold_Out_Light_ON
                        Else
                            pbSoldOutLightD0.Image = My.Resources.Sold_Out_Light_OFF
                        End If
                    End If

                    CokeMachineX = 94
                    CokeMachineY = 53

                    PepsiMachineX = 155 '----------------------------------------------------------HERE
                    PepsiMachineY = 53

                    CanDrinkMachineX = 220
                    CanDrinkMachineY = 53

                    IceCreamMachineX = 285
                    IceCreamMachineY = 53

                    LiveBaitMachineX = 94
                    LiveBaitMachineY = 154

                    MiscSnackMachineX = 160
                    MiscSnackMachineY = 154

                    MountainDewMachineX = 220
                    mountainDewMachineY = 154

                    PastaMachineX = 285
                    PastaMachineY = 154

                    PizzaMachineX = 94
                    PizzaMachineY = 255

                    SnackDrinkMachineX = 161
                    SnackDrinkMachineY = 255

                    SnackMachineX = 220
                    SnackMachineY = 255

                    UmbrellaMachineX = 285
                    UmbrellaMachineY = 255

                    GenericSodaMachineX = 174
                    GenericSodaMachineY = 352

                    DoorY = 640
                End If
            End If
        End If
    End Sub

    Private Sub pnlA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlA.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "A"
        Else
            lblItem.Text += "A"
        End If
    End Sub

    Private Sub pnlB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlB.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "B"
        Else
            lblItem.Text += "B"
        End If
    End Sub

    Private Sub pnlC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlC.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "C"
        Else
            lblItem.Text += "C"
        End If
    End Sub
    Private Sub pbD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbD.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "D"
        Else
            lblItem.Text += "D"
        End If
    End Sub

    Private Sub pbZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbZero.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "0"
        Else
            lblItem.Text += "0"
        End If
    End Sub

    Private Sub pnlOne_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlOne.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "1"
        Else
            lblItem.Text += "1"
        End If
    End Sub

    Private Sub pnlTwo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlTwo.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "2"
        Else
            lblItem.Text += "2"
        End If
    End Sub

    Private Sub pnlThree_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlThree.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "3"
        Else
            lblItem.Text += "3"
        End If
    End Sub

    Private Sub pnlFour_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlFour.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "4"
        Else
            lblItem.Text += "4"
        End If
    End Sub

    Private Sub pnlFive_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlFive.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "5"
        Else
            lblItem.Text += "5"
        End If
    End Sub

    Private Sub pnlSix_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlSix.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "6"
        Else
            lblItem.Text += "6"
        End If
    End Sub

    Private Sub pnlSeven_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlSeven.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "7"
        Else
            lblItem.Text += "7"
        End If
    End Sub

    Private Sub pnlEight_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlEight.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "8"
        Else
            lblItem.Text += "8"
        End If
    End Sub

    Private Sub pnlNine_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlNine.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text += "9"
        Else
            lblItem.Text += "9"
        End If
    End Sub
    Private Sub pbCreditCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCreditCard.Click
        pbCreditCard.Enabled = False
        tmrCrditCard.Enabled = True
        Time = 20
    End Sub
    Private Sub pbClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbClr.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
            lblItem.Text = ""
            lblMoney.Text = ""


            pbEnter.Visible = True
            pbZero.Visible = True
            pbD.Visible = True
            pbCreditCard.Visible = False
            pbHalfCardReader.Visible = False
            Me.BackgroundImage = My.Resources.vending_machines_Keypad
        Else
            lblItem.Text = ""
            lblMoney.Text = ""


            pbEnter.Visible = True
            pbZero.Visible = True
            pbD.Visible = True
            pbCreditCard.Visible = False
            pbHalfCardReader.Visible = False
            Me.BackgroundImage = My.Resources.vending_machines_Keypad
        End If
    End Sub
    Private Sub pbEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEnter.Click
        If Sound = 0 Then
            My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.Background)
        End If

        If lblItem.Text = "A1" Then
            If CokeMachine > 0 Then
                InfoTime = 110
                Me.BackgroundImage = My.Resources.vending_machines_KeypadR

                pbCreditCard.Visible = True
                pbHalfCardReader.Visible = True
                pbD.Visible = False

                pbZero.Visible = False
                pbEnter.Visible = False

                lblMoney.Text = "1200"
            Else
                InfoTime = 140
                info_Delay = 0
            End If
        ElseIf lblItem.Text = "A2" Then
            If PepsiMachine > 0 Then
                InfoTime = 110
                Me.BackgroundImage = My.Resources.vending_machines_KeypadR

                pbCreditCard.Visible = True
                pbHalfCardReader.Visible = True
                pbD.Visible = False

                pbZero.Visible = False
                pbEnter.Visible = False

                lblMoney.Text = "995"
            Else
                InfoTime = 140
                info_Delay = 0
            End If
        ElseIf lblItem.Text = "A3" Then
            If CanDrinkMachine > 0 Then
                InfoTime = 110
                Me.BackgroundImage = My.Resources.vending_machines_KeypadR

                pbCreditCard.Visible = True
                pbHalfCardReader.Visible = True
                pbD.Visible = False

                pbZero.Visible = False
                pbEnter.Visible = False

                lblMoney.Text = "1400"
            Else
                InfoTime = 140
                info_Delay = 0
            End If
        ElseIf lblItem.Text = "A4" Then
            If IceCreamMachine > 0 Then
                InfoTime = 110
                Me.BackgroundImage = My.Resources.vending_machines_KeypadR

                pbCreditCard.Visible = True
                pbHalfCardReader.Visible = True
                pbD.Visible = False

                pbZero.Visible = False
                pbEnter.Visible = False

                lblMoney.Text = "1000"
            Else
                InfoTime = 140
                info_Delay = 0
            End If

        ElseIf lblItem.Text = "B5" Then
            If livebaitMachine > 0 Then
                InfoTime = 110
                Me.BackgroundImage = My.Resources.vending_machines_KeypadR

                pbCreditCard.Visible = True
                pbHalfCardReader.Visible = True
                pbD.Visible = False

                pbZero.Visible = False
                pbEnter.Visible = False

                lblMoney.Text = "550"
            Else
                InfoTime = 140
                info_Delay = 0
            End If
        ElseIf lblItem.Text = "B6" Then
            If MiscSnackMachine > 0 Then
                InfoTime = 110
                Me.BackgroundImage = My.Resources.vending_machines_KeypadR

                pbCreditCard.Visible = True
                pbHalfCardReader.Visible = True
                pbD.Visible = False

                pbZero.Visible = False
                pbEnter.Visible = False

                lblMoney.Text = "435"
            Else
                InfoTime = 140
                info_Delay = 0
            End If
        ElseIf lblItem.Text = "B7" Then
            If MountainDewMachine > 0 Then
                InfoTime = 110
                Me.BackgroundImage = My.Resources.vending_machines_KeypadR

                pbCreditCard.Visible = True
                pbHalfCardReader.Visible = True
                pbD.Visible = False

                pbZero.Visible = False
                pbEnter.Visible = False

                lblMoney.Text = "2300"
            Else
                InfoTime = 140
                info_Delay = 0
            End If
        ElseIf lblItem.Text = "B8" Then
            If PastaMachine > 0 Then
                InfoTime = 110
                Me.BackgroundImage = My.Resources.vending_machines_KeypadR

                pbCreditCard.Visible = True
                pbHalfCardReader.Visible = True
                pbD.Visible = False

                pbZero.Visible = False
                pbEnter.Visible = False

                lblMoney.Text = "3200"
            Else
                InfoTime = 140
                info_Delay = 0
            End If
        ElseIf lblItem.Text = "C9" Then
            If PizzaMachine > 0 Then
                InfoTime = 110
                Me.BackgroundImage = My.Resources.vending_machines_KeypadR

                pbCreditCard.Visible = True
                pbHalfCardReader.Visible = True
                pbD.Visible = False

                pbZero.Visible = False
                pbEnter.Visible = False

                lblMoney.Text = "5000"
            Else
                InfoTime = 140
                info_Delay = 0
            End If
        ElseIf lblItem.Text = "C0" Then
            If SnackDrinkMachine > 0 Then
                InfoTime = 110
                Me.BackgroundImage = My.Resources.vending_machines_KeypadR

                pbCreditCard.Visible = True
                pbHalfCardReader.Visible = True
                pbD.Visible = False

                pbZero.Visible = False
                pbEnter.Visible = False

                lblMoney.Text = "1000"
            Else
                InfoTime = 140
                info_Delay = 0
            End If
        ElseIf lblItem.Text = "C1" Then
            If SnackMachine > 0 Then
                InfoTime = 110
                Me.BackgroundImage = My.Resources.vending_machines_KeypadR

                pbCreditCard.Visible = True
                pbHalfCardReader.Visible = True
                pbD.Visible = False

                pbZero.Visible = False
                pbEnter.Visible = False

                lblMoney.Text = "1000"
            Else
                InfoTime = 140
                info_Delay = 0
            End If
        ElseIf lblItem.Text = "C2" Then
            If UmbrellaMachine > 0 Then
                InfoTime = 110
                Me.BackgroundImage = My.Resources.vending_machines_KeypadR

                pbCreditCard.Visible = True
                pbHalfCardReader.Visible = True
                pbD.Visible = False

                pbZero.Visible = False
                pbEnter.Visible = False

                lblMoney.Text = "800"
            Else
                InfoTime = 140
                info_Delay = 0
            End If
        ElseIf lblItem.Text = "D0" Then
            If GenericSodaMachine > 0 Then
                InfoTime = 110
                Me.BackgroundImage = My.Resources.vending_machines_KeypadR

                pbCreditCard.Visible = True
                pbHalfCardReader.Visible = True
                pbD.Visible = False

                pbZero.Visible = False '----------------------------------------------------------HERE
                pbEnter.Visible = False

                lblMoney.Text = "300"
            Else
                InfoTime = 140
                info_Delay = 0
            End If
        Else
            InfoTime = 150
            info_Delay = 0
        End If
    End Sub

    Private Sub tmrCrditCard_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCrditCard.Tick
        pbCreditCard.Location = New Point(CreditCardX, CreditCardY)
        If frmDebug.Debug = 1 Then '-----------------------------------------------------------    DEBUG START

            If Time = 20 Then '------------------------------Time 20    DEBUG

                CreditCardX = 27
                CreditCardY = 476

                If CreditCardX = 27 And CreditCardY = 476 Then
                    Time = 30
                End If




            ElseIf Time = 30 Then '------------------------------Time 30    DEBUG
                CreditCardX = 520
                If CreditCardY < 520 Then
                    CreditCardY += 1
                Else
                    Time = 40
                End If




            ElseIf Time = 40 Then '------------------------------Time 40    DEBUG
                CreditCardX = 97
                CreditCardY = 497

                If CreditCardY = 497 And CreditCardX = 97 Then
                    If lblItem.Text = "A1" Then
                        If Credit > 1200 Then
                            InfoTime = 120
                            Credit -= 1200
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "A2" Then
                        If Credit > 995 Then
                            InfoTime = 120
                            Credit -= 995
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "A3" Then ' -----------------------------------------------HERE    DEBUG
                        If Credit > 1400 Then
                            InfoTime = 120
                            Credit -= 1400
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "A4" Then '-------------------------------           DEBUG
                        If Credit > 1000 Then
                            InfoTime = 120
                            Credit -= 1000
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "B5" Then '-------------------------------           DEBUG
                        If Credit > 550 Then
                            InfoTime = 120
                            Credit -= 550
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "B6" Then '-------------------------------           DEBUG
                        If Credit > 435 Then
                            InfoTime = 120
                            Credit -= 435
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "B7" Then '-------------------------------           DEBUG
                        If Credit > 2300 Then
                            InfoTime = 120
                            Credit -= 2300
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "B8" Then '-------------------------------           DEBUG
                        If Credit > 3200 Then
                            InfoTime = 120
                            Credit -= 3200
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "C9" Then '-------------------------------           DEBUG
                        If Credit >= 5000 Then
                            InfoTime = 120
                            Credit -= 5000
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "C0" Then '-------------------------------           DEBUG
                        If Credit > 1000 Then
                            InfoTime = 120
                            Credit -= 1000
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "C1" Then '-------------------------------           DEBUG
                        If Credit > 1000 Then
                            InfoTime = 120
                            Credit -= 1000
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "C2" Then '-------------------------------           DEBUG
                        If Credit > 800 Then
                            InfoTime = 120
                            Credit -= 800
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "D0" Then '-------------------------------           DEBUG
                        If Credit > 300 Then
                            InfoTime = 120
                            Credit -= 300
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    End If
                End If




            ElseIf Time = 50 Then '------------------------------Time 50    DEBUG
                pbWDoor.Location = New Point(193, DoorY)

                DoorY = 578
                If DoorY > 578 Then
                    DoorY -= 1
                Else
                    Time = 10
                    pbStickmonPos.Image = My.Resources.stickmon_stand_facing
                    AnimationTime = 40
                End If




            ElseIf Time = 60 Then '------------------------------Time 60    DEBUG

                If lblItem.Text = "A1" Then '-------------------------------           DEBUG
                    AnimeForklift = "Coke"
                    Forklift()
                    If CokeMachine = 1 Then
                        pbCokeMachine1.Location = New Point(CokeMachineX, CokeMachineY)
                    Else
                        pbCokeMachine2.Location = New Point(CokeMachineX, CokeMachineY)
                    End If

                    CokeMachineX = 194
                    CokeMachineY = 650

                    If CokeMachineY < 650 Then
                        CokeMachineY += 1
                        If CokeMachineX < 194 Then
                            CokeMachineX += 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "A2" Then '-------------------------------           DEBUG
                    AnimeForklift = "Pepsi"
                    Forklift()
                    If PepsiMachine = 1 Then
                        pbPepsiMachine1.Location = New Point(PepsiMachineX, PepsiMachineY)
                    ElseIf PepsiMachine = 2 Then
                        pbPepsiMachine2.Location = New Point(PepsiMachineX, PepsiMachineY)
                    ElseIf PepsiMachine = 3 Then
                        pbPepsiMachine3.Location = New Point(PepsiMachineX, PepsiMachineY)
                    End If

                    PepsiMachineX = 194
                    PepsiMachineY = 650

                    If PepsiMachineY < 650 Then
                        PepsiMachineY += 1
                        If PepsiMachineX < 194 Then
                            PepsiMachineX += 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "A3" Then '-------------------------------           DEBUG
                    AnimeForklift = "CanDrinks"
                    Forklift()
                    If CanDrinkMachine = 1 Then
                        pbCanDrinkMachine1.Location = New Point(CanDrinkMachineX, CanDrinkMachineY)
                    Else
                        pbCanDrinkMachine2.Location = New Point(CanDrinkMachineX, CanDrinkMachineY)
                    End If

                    CanDrinkMachineX = 194
                    CanDrinkMachineY = 650

                    If CanDrinkMachineY < 650 Then
                        CanDrinkMachineY += 1
                        If CanDrinkMachineX > 194 Then
                            CanDrinkMachineX -= 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "A4" Then '-------------------------------           DEBUG
                    AnimeForklift = "IceCream"
                    Forklift()
                    If IceCreamMachine = 1 Then
                        pbIceCreamMachine1.Location = New Point(IceCreamMachineX, IceCreamMachineY)
                    ElseIf IceCreamMachine = 2 Then
                        pbIceCreamMachine2.Location = New Point(IceCreamMachineX, IceCreamMachineY)
                    ElseIf IceCreamMachine = 3 Then
                        pbIceCreamMachine3.Location = New Point(IceCreamMachineX, IceCreamMachineY)
                    ElseIf IceCreamMachine = 4 Then
                        pbIceCreamMachine4.Location = New Point(IceCreamMachineX, IceCreamMachineY)
                    End If

                    IceCreamMachineX = 194
                    IceCreamMachineY = 650

                    If IceCreamMachineY < 650 Then
                        IceCreamMachineY += 1
                        If IceCreamMachineX > 194 Then
                            IceCreamMachineX -= 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "B5" Then '-------------------------------           DEBUG
                    AnimeForklift = "LiveBait"
                    Forklift()
                    If livebaitMachine = 1 Then
                        pbLiveBaitMachine1.Location = New Point(LiveBaitMachineX, LiveBaitMachineY)
                    ElseIf livebaitMachine = 2 Then
                        pbLiveBaitMachine2.Location = New Point(LiveBaitMachineX, LiveBaitMachineY)
                    ElseIf livebaitMachine = 3 Then
                        pbLiveBaitMachine3.Location = New Point(LiveBaitMachineX, LiveBaitMachineY)
                    ElseIf livebaitMachine = 4 Then
                        pbLiveBaitMachine4.Location = New Point(LiveBaitMachineX, LiveBaitMachineY)
                    End If

                    LiveBaitMachineX = 194
                    LiveBaitMachineY = 650

                    If LiveBaitMachineY < 650 Then
                        LiveBaitMachineY += 1
                        If LiveBaitMachineX < 194 Then
                            LiveBaitMachineX += 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "B6" Then '-------------------------------           DEBUG
                    AnimeForklift = "MiscSnacks"
                    Forklift()
                    If MiscSnackMachine = 1 Then
                        pbMiscSnackMachine1.Location = New Point(MiscSnackMachineX, MiscSnackMachineY)
                    ElseIf MiscSnackMachine = 2 Then
                        pbMiscSnackMachine2.Location = New Point(MiscSnackMachineX, MiscSnackMachineY)
                    ElseIf MiscSnackMachine = 3 Then
                        pbMiscSnackMachine3.Location = New Point(MiscSnackMachineX, MiscSnackMachineY)
                    ElseIf MiscSnackMachine = 4 Then
                        pbMiscSnackMachine4.Location = New Point(MiscSnackMachineX, MiscSnackMachineY)
                    ElseIf MiscSnackMachine = 5 Then
                        pbMiscSnackMachine4.Location = New Point(MiscSnackMachineX, MiscSnackMachineY)
                    End If

                    MiscSnackMachineX = 194
                    MiscSnackMachineY = 650

                    If MiscSnackMachineY < 650 Then
                        MiscSnackMachineY += 1
                        If MiscSnackMachineX < 194 Then
                            MiscSnackMachineX += 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "B7" Then '-------------------------------           DEBUG
                    AnimeForklift = "MountainDew"
                    Forklift()
                    If MountainDewMachine = 1 Then
                        pbMountainDewMachine1.Location = New Point(MountainDewMachineX, mountainDewMachineY)
                    ElseIf MountainDewMachine = 2 Then
                        pbMountainDewMachine2.Location = New Point(MountainDewMachineX, mountainDewMachineY)
                    ElseIf MountainDewMachine = 3 Then
                        pbMountainDewMachine3.Location = New Point(MountainDewMachineX, mountainDewMachineY)
                    End If

                    MountainDewMachineX = 194
                    mountainDewMachineY = 650

                    If mountainDewMachineY < 650 Then
                        mountainDewMachineY += 1
                        If MountainDewMachineX > 194 Then
                            MountainDewMachineX -= 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "B8" Then '-------------------------------           DEBUG
                    AnimeForklift = "Pasta"
                    Forklift()
                    If PastaMachine = 1 Then
                        pbPastaMachine1.Location = New Point(PastaMachineX, PastaMachineY)
                    Else
                        pbPastaMachine2.Location = New Point(PastaMachineX, PastaMachineY)
                    End If

                    PastaMachineX = 194
                    PastaMachineY = 650

                    If PastaMachineY < 650 Then
                        PastaMachineY += 1
                        If PastaMachineX < 194 Then
                            PastaMachineX += 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "C9" Then '-------------------------------           DEBUG
                    AnimeForklift = "Pizza"
                    Forklift()
                    If PizzaMachine = 1 Then
                        pbPizzaMachine1.Location = New Point(PizzaMachineX, PizzaMachineY)
                    End If

                    PizzaMachineX = 194
                    PizzaMachineY = 650

                    If PizzaMachineY < 650 Then
                        PizzaMachineY += 1
                        If PizzaMachineX < 194 Then
                            PizzaMachineX += 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "C0" Then '-------------------------------           DEBUG
                    AnimeForklift = "SnackDrink"
                    Forklift()
                    If SnackDrinkMachine = 1 Then
                        pbSnackDrinkMachine1.Location = New Point(SnackDrinkMachineX, SnackDrinkMachineY)
                    ElseIf SnackDrinkMachine = 2 Then
                        pbSnackDrinkMachine2.Location = New Point(SnackDrinkMachineX, SnackDrinkMachineY)
                    ElseIf SnackDrinkMachine = 3 Then
                        pbSnackDrinkMachine3.Location = New Point(SnackDrinkMachineX, SnackDrinkMachineY)
                    End If

                    SnackDrinkMachineX = 194
                    SnackDrinkMachineY = 650

                    If SnackDrinkMachineY < 650 Then
                        SnackDrinkMachineY += 1
                        If SnackDrinkMachineX < 194 Then
                            SnackDrinkMachineX -= 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "C1" Then '-------------------------------           DEBUG
                    AnimeForklift = "Snacks"
                    Forklift()
                    If SnackMachine = 1 Then
                        pbSnackMachine1.Location = New Point(SnackMachineX, SnackMachineY)
                    Else
                        pbSnackMachine1.Location = New Point(SnackMachineX, SnackMachineY)
                    End If

                    SnackDrinkMachineX = 194
                    SnackDrinkMachineY = 650

                    If SnackMachineY = 650 Then
                        SnackMachineY += 1
                        If SnackMachineX = 194 Then
                            SnackMachineX -= 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "C2" Then '-------------------------------           DEBUG
                    AnimeForklift = "Umbrella"
                    Forklift()
                    If UmbrellaMachine = 1 Then
                        pbUmbrellaMachine1.Location = New Point(UmbrellaMachineX, UmbrellaMachineY)
                    ElseIf UmbrellaMachine = 2 Then
                        pbUmbrellaMachine1.Location = New Point(UmbrellaMachineX, UmbrellaMachineY)
                    ElseIf UmbrellaMachine = 3 Then
                        pbUmbrellaMachine3.Location = New Point(UmbrellaMachineX, UmbrellaMachineY)
                    End If

                    UmbrellaMachineX = 194
                    UmbrellaMachineY = 650

                    If UmbrellaMachineY < 650 Then
                        UmbrellaMachineY += 1
                        If UmbrellaMachineX > 194 Then
                            UmbrellaMachineX -= 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "D0" Then '-------------------------------           DEBUG
                    AnimeForklift = "Generic"
                    Forklift()
                    If GenericSodaMachine = 1 Then
                        pbGenericSodaMachine1.Location = New Point(GenericSodaMachineX, GenericSodaMachineY)
                    ElseIf GenericSodaMachine = 2 Then
                        pbGenericSodaMachine2.Location = New Point(GenericSodaMachineX, GenericSodaMachineY)
                    ElseIf GenericSodaMachine = 3 Then
                        pbGenericSodaMachine3.Location = New Point(GenericSodaMachineX, GenericSodaMachineY)
                    ElseIf GenericSodaMachine = 4 Then
                        pbGenericSodaMachine4.Location = New Point(GenericSodaMachineX, GenericSodaMachineY)
                    ElseIf GenericSodaMachine = 5 Then
                        pbGenericSodaMachine5.Location = New Point(GenericSodaMachineX, GenericSodaMachineY)
                    ElseIf GenericSodaMachine = 6 Then
                        pbGenericSodaMachine6.Location = New Point(GenericSodaMachineX, GenericSodaMachineY)
                    End If

                    GenericSodaMachineX = 194
                    GenericSodaMachineY = 650

                    If GenericSodaMachineY < 650 Then
                        GenericSodaMachineY += 1
                        If GenericSodaMachineX < 194 Then
                            GenericSodaMachineX += 1
                        End If
                    End If
                Else
                    Time = 150
                    pbWDoor.Visible = True
                    pbBottom.Visible = False
                End If
            End If
            '-----------------------------------------------------------------------------------DEBUG END
        Else

            If Time = 20 Then '------------------------------Time 20
                If CreditCardX > 27 Then
                    CreditCardX -= 1
                End If
                If CreditCardY > 476 Then
                    CreditCardY -= 1
                Else
                End If
                If CreditCardX = 27 And CreditCardY = 476 Then
                    Time = 30
                End If




            ElseIf Time = 30 Then '------------------------------Time 20
                If CreditCardY < 520 Then
                    CreditCardY += 1
                Else
                    Time = 40
                End If




            ElseIf Time = 40 Then '------------------------------Time 40
                If CreditCardY > 497 And CreditCardX <> 97 Then
                    CreditCardX += 1
                    CreditCardY -= 1
                End If
                If CreditCardX <> 97 Then
                    CreditCardX += 1
                End If
                If CreditCardY = 497 And CreditCardX = 97 Then
                    If lblItem.Text = "A1" Then
                        If Credit > 1200 Then
                            InfoTime = 120
                            Credit -= 1200
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "A2" Then
                        If Credit > 995 Then
                            InfoTime = 120
                            Credit -= 995
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "A3" Then ' -----------------------------------------------HERE
                        If Credit > 1400 Then
                            InfoTime = 120
                            Credit -= 1400
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "A4" Then
                        If Credit > 1000 Then
                            InfoTime = 120
                            Credit -= 1000
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "B5" Then
                        If Credit > 550 Then
                            InfoTime = 120
                            Credit -= 550
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "B6" Then
                        If Credit > 435 Then
                            InfoTime = 120
                            Credit -= 435
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "B7" Then
                        If Credit > 2300 Then
                            InfoTime = 120
                            Credit -= 2300
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "B8" Then
                        If Credit > 3200 Then
                            InfoTime = 120
                            Credit -= 3200
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "C9" Then
                        If Credit >= 5000 Then
                            InfoTime = 120
                            Credit -= 5000
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "C0" Then
                        If Credit > 1000 Then
                            InfoTime = 120
                            Credit -= 1000
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "C1" Then
                        If Credit > 1000 Then
                            InfoTime = 120
                            Credit -= 1000
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "C2" Then
                        If Credit > 800 Then
                            InfoTime = 120
                            Credit -= 800
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    ElseIf lblItem.Text = "D0" Then
                        If Credit > 300 Then
                            InfoTime = 120
                            Credit -= 300
                            Time = 10
                        Else
                            InfoTime = 130
                        End If
                    End If
                End If




            ElseIf Time = 50 Then '------------------------------Time 50
                pbWDoor.Location = New Point(193, DoorY)

                If DoorY > 578 Then
                    DoorY -= 1
                Else
                    Time = 10
                    pbStickmonPos.Image = My.Resources.stickmon_stand_facing
                    AnimationTime = 40
                End If




            ElseIf Time = 60 Then '------------------------------Time 60

                If lblItem.Text = "A1" Then
                    AnimeForklift = "Coke"
                    Forklift()
                    If CokeMachine = 1 Then
                        pbCokeMachine1.Location = New Point(CokeMachineX, CokeMachineY)
                    Else
                        pbCokeMachine2.Location = New Point(CokeMachineX, CokeMachineY)
                    End If


                    If CokeMachineY < 650 Then
                        CokeMachineY += 1
                        If CokeMachineX < 194 Then
                            CokeMachineX += 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "A2" Then
                    AnimeForklift = "Pepsi"
                    Forklift()
                    If PepsiMachine = 1 Then
                        pbPepsiMachine1.Location = New Point(PepsiMachineX, PepsiMachineY)
                    ElseIf PepsiMachine = 2 Then
                        pbPepsiMachine2.Location = New Point(PepsiMachineX, PepsiMachineY)
                    ElseIf PepsiMachine = 3 Then
                        pbPepsiMachine3.Location = New Point(PepsiMachineX, PepsiMachineY)
                    End If


                    If PepsiMachineY < 650 Then
                        PepsiMachineY += 1
                        If PepsiMachineX < 194 Then
                            PepsiMachineX += 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "A3" Then
                    AnimeForklift = "CanDrinks"
                    Forklift()
                    If CanDrinkMachine = 1 Then
                        pbCanDrinkMachine1.Location = New Point(CanDrinkMachineX, CanDrinkMachineY)
                    Else
                        pbCanDrinkMachine2.Location = New Point(CanDrinkMachineX, CanDrinkMachineY)
                    End If


                    If CanDrinkMachineY < 650 Then
                        CanDrinkMachineY += 1
                        If CanDrinkMachineX > 194 Then
                            CanDrinkMachineX -= 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "A4" Then
                    AnimeForklift = "IceCream"
                    Forklift()
                    If IceCreamMachine = 1 Then
                        pbIceCreamMachine1.Location = New Point(IceCreamMachineX, IceCreamMachineY)
                    ElseIf IceCreamMachine = 2 Then
                        pbIceCreamMachine2.Location = New Point(IceCreamMachineX, IceCreamMachineY)
                    ElseIf IceCreamMachine = 3 Then
                        pbIceCreamMachine3.Location = New Point(IceCreamMachineX, IceCreamMachineY)
                    Else
                        pbIceCreamMachine4.Location = New Point(IceCreamMachineX, IceCreamMachineY)
                    End If


                    If IceCreamMachineY < 650 Then
                        IceCreamMachineY += 1
                        If IceCreamMachineX > 194 Then
                            IceCreamMachineX -= 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "B5" Then
                    AnimeForklift = "LiveBait"
                    Forklift()
                    If livebaitMachine = 1 Then
                        pbLiveBaitMachine1.Location = New Point(LiveBaitMachineX, LiveBaitMachineY)
                    ElseIf livebaitMachine = 2 Then
                        pbLiveBaitMachine2.Location = New Point(LiveBaitMachineX, LiveBaitMachineY)
                    ElseIf livebaitMachine = 3 Then
                        pbLiveBaitMachine3.Location = New Point(LiveBaitMachineX, LiveBaitMachineY)
                    Else
                        pbLiveBaitMachine4.Location = New Point(LiveBaitMachineX, LiveBaitMachineY)
                    End If


                    If LiveBaitMachineY < 650 Then
                        LiveBaitMachineY += 1
                        If LiveBaitMachineX < 194 Then
                            LiveBaitMachineX += 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "B6" Then
                    AnimeForklift = "MiscSnacks"
                    Forklift()
                    If MiscSnackMachine = 1 Then
                        pbMiscSnackMachine1.Location = New Point(MiscSnackMachineX, MiscSnackMachineY)
                    ElseIf MiscSnackMachine = 2 Then
                        pbMiscSnackMachine2.Location = New Point(MiscSnackMachineX, MiscSnackMachineY)
                    ElseIf MiscSnackMachine = 3 Then
                        pbMiscSnackMachine3.Location = New Point(MiscSnackMachineX, MiscSnackMachineY)
                    ElseIf MiscSnackMachine = 4 Then
                        pbMiscSnackMachine4.Location = New Point(MiscSnackMachineX, MiscSnackMachineY)
                    Else
                        pbMiscSnackMachine5.Location = New Point(MiscSnackMachineX, MiscSnackMachineY)
                    End If


                    If MiscSnackMachineY < 650 Then
                        MiscSnackMachineY += 1
                        If MiscSnackMachineX < 194 Then
                            MiscSnackMachineX += 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "B7" Then
                    AnimeForklift = "MountainDew"
                    Forklift()
                    If MountainDewMachine = 1 Then
                        pbMountainDewMachine1.Location = New Point(MountainDewMachineX, mountainDewMachineY)
                    ElseIf MountainDewMachine = 2 Then
                        pbMountainDewMachine2.Location = New Point(MountainDewMachineX, mountainDewMachineY)
                    Else
                        pbMountainDewMachine3.Location = New Point(MountainDewMachineX, mountainDewMachineY)
                    End If


                    If mountainDewMachineY < 650 Then
                        mountainDewMachineY += 1
                        If MountainDewMachineX > 194 Then
                            MountainDewMachineX -= 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "B8" Then
                    AnimeForklift = "Pasta"
                    Forklift()
                    If PastaMachine = 1 Then
                        pbPastaMachine1.Location = New Point(PastaMachineX, PastaMachineY)
                    Else
                        pbPastaMachine2.Location = New Point(PastaMachineX, PastaMachineY)
                    End If


                    If PastaMachineY < 650 Then
                        PastaMachineY += 1
                        If PastaMachineX > 194 Then
                            PastaMachineX -= 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "C9" Then
                    AnimeForklift = "Pizza"
                    Forklift()
                    If PizzaMachine = 1 Then
                        pbPizzaMachine1.Location = New Point(PizzaMachineX, PizzaMachineY)
                    End If


                    If PizzaMachineY < 650 Then
                        PizzaMachineY += 1
                        If PizzaMachineX < 194 Then
                            PizzaMachineX += 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "C0" Then
                    AnimeForklift = "SnackDrink"
                    Forklift()
                    If SnackDrinkMachine = 1 Then
                        pbSnackDrinkMachine1.Location = New Point(SnackDrinkMachineX, SnackDrinkMachineY)
                    ElseIf SnackDrinkMachine = 2 Then
                        pbSnackDrinkMachine2.Location = New Point(SnackDrinkMachineX, SnackDrinkMachineY)
                    Else
                        pbSnackDrinkMachine3.Location = New Point(SnackDrinkMachineX, SnackDrinkMachineY)
                    End If


                    If SnackDrinkMachineY < 650 Then
                        SnackDrinkMachineY += 1
                        If SnackDrinkMachineX < 194 Then
                            SnackDrinkMachineX += 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "C1" Then
                    AnimeForklift = "Snacks"
                    Forklift()
                    If SnackMachine = 1 Then
                        pbSnackMachine1.Location = New Point(SnackMachineX, SnackMachineY)
                    Else
                        pbSnackMachine2.Location = New Point(SnackMachineX, SnackMachineY)
                    End If


                    If SnackMachineY < 650 Then
                        SnackMachineY += 1
                        If SnackMachineX > 194 Then
                            SnackMachineX -= 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "C2" Then
                    AnimeForklift = "Umbrella"
                    Forklift()
                    If UmbrellaMachine = 1 Then
                        pbUmbrellaMachine1.Location = New Point(UmbrellaMachineX, UmbrellaMachineY)
                    ElseIf UmbrellaMachine = 2 Then
                        pbUmbrellaMachine2.Location = New Point(UmbrellaMachineX, UmbrellaMachineY)
                    ElseIf UmbrellaMachine = 3 Then
                        pbUmbrellaMachine3.Location = New Point(UmbrellaMachineX, UmbrellaMachineY)
                    End If


                    If UmbrellaMachineY < 650 Then
                        UmbrellaMachineY += 1
                        If UmbrellaMachineX > 194 Then
                            UmbrellaMachineX -= 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                ElseIf lblItem.Text = "D0" Then
                    AnimeForklift = "Generic"
                    Forklift()
                    If GenericSodaMachine = 1 Then
                        pbGenericSodaMachine1.Location = New Point(GenericSodaMachineX, GenericSodaMachineY)
                    ElseIf GenericSodaMachine = 2 Then
                        pbGenericSodaMachine2.Location = New Point(GenericSodaMachineX, GenericSodaMachineY)
                    ElseIf GenericSodaMachine = 3 Then
                        pbGenericSodaMachine3.Location = New Point(GenericSodaMachineX, GenericSodaMachineY)
                    ElseIf GenericSodaMachine = 4 Then
                        pbGenericSodaMachine4.Location = New Point(GenericSodaMachineX, GenericSodaMachineY)
                    ElseIf GenericSodaMachine = 5 Then
                        pbGenericSodaMachine5.Location = New Point(GenericSodaMachineX, GenericSodaMachineY)
                    Else
                        pbGenericSodaMachine6.Location = New Point(GenericSodaMachineX, GenericSodaMachineY)
                    End If


                    If GenericSodaMachineY < 650 Then
                        GenericSodaMachineY += 1
                        If GenericSodaMachineX < 194 Then
                            GenericSodaMachineX += 1
                        End If
                    Else
                        Time = 50
                        pbWDoor.Visible = True
                        pbBottom.Visible = False
                    End If
                Else
                    InfoTime = 150
                End If
            End If
        End If
    End Sub

    Private Sub tmrKeypad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrKeypad.Tick
        If lblItem.Text.Length = 2 Then
            pnlA.Enabled = False
            pnlB.Enabled = False
            pnlC.Enabled = False
            pbD.Enabled = False
            pnlOne.Enabled = False
            pnlTwo.Enabled = False
            pnlThree.Enabled = False
            pnlFour.Enabled = False
            pnlFive.Enabled = False
            pnlSix.Enabled = False
            pnlSeven.Enabled = False
            pnlEight.Enabled = False
            pnlNine.Enabled = False
            pbZero.Enabled = False


            pbEnter.Enabled = True
        ElseIf lblItem.Text.Length = 1 Then
            pnlA.Enabled = False
            pnlB.Enabled = False
            pnlC.Enabled = False
            pbD.Enabled = False
            pnlOne.Enabled = True
            pnlTwo.Enabled = True
            pnlThree.Enabled = True
            pnlFour.Enabled = True
            pnlFive.Enabled = True
            pnlSix.Enabled = True
            pnlSeven.Enabled = True
            pnlEight.Enabled = True
            pnlNine.Enabled = True
            pbZero.Enabled = True
        ElseIf lblItem.Text.Length = 0 Then
            pnlA.Enabled = True
            pnlB.Enabled = True
            pnlC.Enabled = True
            pbD.Enabled = True
            pnlOne.Enabled = False
            pnlTwo.Enabled = False
            pnlThree.Enabled = False
            pnlFour.Enabled = False
            pnlFive.Enabled = False
            pnlSix.Enabled = False
            pnlSeven.Enabled = False
            pnlEight.Enabled = False
            pnlNine.Enabled = False
            pbZero.Enabled = False
        End If
    End Sub
    Private Sub tmrInfo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrInfo.Tick
        If frmDebug.Debug = 1 Then
            If InfoTime = 100 Then '------------------------------InfoTime 100        DEBUG

            ElseIf InfoTime = 110 Then '------------------------------InfoTime 110    DEBUG

            ElseIf InfoTime = 120 Then '------------------------------InfoTime 120    DEBUG
                info_Delay = 80

                If info_Delay = 80 Then

                    InfoTime = 10
                    info_Delay = 0
                    lblMoney.Text = ""

                    Me.BackgroundImage = My.Resources.vending_machines_798148

                    pbCreditCard.Visible = False
                    pbCreditCard.Enabled = True
                    pbHalfCardReader.Visible = False
                    pbBottom.Visible = True
                    pbMid.Visible = True
                    pbStickmonPos.BringToFront()

                    lblItem.Visible = False
                    lblInfo.Visible = False
                    lblMoney.Visible = False
                    lblCashSign.Visible = False
                    pbStickmonPos.Image = My.Resources.Neg_Stickmon

                    Time = 60

                End If




            ElseIf InfoTime = 130 Then '------------------------------InfoTime 130    DEBUG
                info_Delay = 80

                If info_Delay = 80 Then
                    InfoTime = 10
                    AnimationTime = 20
                    animation = -1


                    lblMoney.Text = ""
                    lblItem.Text = ""
                    Me.BackgroundImage = My.Resources.vending_machines_798148
                    pbCreditCard.Visible = False
                    pbCreditCard.Enabled = True
                    pbHalfCardReader.Visible = False
                    AnimationChange()


                    lblMoney.Visible = False
                    lblCashSign.Visible = False
                    lblInfo.Visible = False
                    lblItem.Visible = True
                    info_Delay = 0

                    If Decline = 2 Then
                        Credit = 5000
                        Decline = 0
                        MessageBox.Show("Application Restarted")
                    End If
                End If



            ElseIf InfoTime = 140 Then '------------------------------InfoTime 140    DEBUG
                info_Delay += 2
                If info_Delay = 6 Then
                    lblItem.Text = ""
                    lblInfo.Text = "Sold Out"
                End If
                If info_Delay = 30 Then
                    InfoTime = 10
                    info_Delay = 0
                    lblInfo.Text = ""
                End If
            End If
        Else
            If InfoTime = 100 Then '------------------------------InfoTime 100
                info_Delay += 1
                If info_Delay = 2 Then
                    lblInfo.Text = "       p"
                End If
                If info_Delay = 4 Then
                    lblInfo.Text = "     Pl"
                End If
                If info_Delay = 8 Then
                    lblInfo.Text = "    Ple"
                End If
                If info_Delay = 10 Then
                    lblInfo.Text = "   Plea"
                End If
                If info_Delay = 12 Then
                    lblInfo.Text = "  Pleas"
                End If
                If info_Delay = 14 Then
                    lblInfo.Text = " Please"
                End If
                If info_Delay = 16 Then
                    lblInfo.Text = "lease C"
                End If
                If info_Delay = 18 Then
                    lblInfo.Text = "ease Ch"
                End If
                If info_Delay = 20 Then
                    lblInfo.Text = "ase Cho"
                End If
                If info_Delay = 22 Then
                    lblInfo.Text = "se Choo"
                End If
                If info_Delay = 24 Then
                    lblInfo.Text = "e Choos"
                End If
                If info_Delay = 26 Then
                    lblInfo.Text = " Choose"
                End If
                If info_Delay = 28 Then
                    lblInfo.Text = "Choose "
                End If
                If info_Delay = 30 Then
                    lblInfo.Text = "hoose A"
                End If
                If info_Delay = 32 Then
                    lblInfo.Text = "oose An"
                End If
                If info_Delay = 34 Then
                    lblInfo.Text = "ose An "
                End If
                If info_Delay = 36 Then
                    lblInfo.Text = "se An I"
                End If
                If info_Delay = 38 Then
                    lblInfo.Text = "e An It"
                End If
                If info_Delay = 40 Then
                    lblInfo.Text = " An Ite"
                End If
                If info_Delay = 42 Then
                    lblInfo.Text = "An Item"
                End If
                If info_Delay = 44 Then
                    lblInfo.Text = "n Item."
                End If
                If info_Delay = 46 Then
                    lblInfo.Text = " Item. "
                End If
                If info_Delay = 48 Then
                    lblInfo.Text = "Item.  "
                End If
                If info_Delay = 50 Then
                    lblInfo.Text = "tem.   "
                End If
                If info_Delay = 52 Then
                    lblInfo.Text = "em.    "
                End If
                If info_Delay = 54 Then
                    lblInfo.Text = "m.     "
                End If
                If info_Delay = 56 Then
                    lblInfo.Text = ".      "
                End If
                If info_Delay = 58 Then
                    lblInfo.Text = "       "
                End If
                If info_Delay = 60 Then
                    info_Delay = 0
                End If




            ElseIf InfoTime = 110 Then '------------------------------InfoTime 110
                info_Delay += 1
                If info_Delay = 2 Then
                    lblInfo.Text = "       p"
                End If
                If info_Delay = 4 Then
                    lblInfo.Text = "     Pl"
                End If
                If info_Delay = 8 Then
                    lblInfo.Text = "    Ple"
                End If
                If info_Delay = 10 Then
                    lblInfo.Text = "   Plea"
                End If
                If info_Delay = 12 Then
                    lblInfo.Text = "  Pleas"
                End If
                If info_Delay = 14 Then
                    lblInfo.Text = " Please"
                End If
                If info_Delay = 16 Then
                    lblInfo.Text = "lease P"
                End If
                If info_Delay = 18 Then
                    lblInfo.Text = "ease Pa"
                End If
                If info_Delay = 20 Then
                    lblInfo.Text = "ase Pay"
                End If
                If info_Delay = 22 Then
                    lblInfo.Text = "se Pay "
                End If
                If info_Delay = 24 Then
                    lblInfo.Text = "e Pay F"
                End If
                If info_Delay = 26 Then
                    lblInfo.Text = " Pay Fo"
                End If
                If info_Delay = 28 Then
                    lblInfo.Text = "Pay For"
                End If
                If info_Delay = 30 Then
                    lblInfo.Text = "ay For "
                End If
                If info_Delay = 32 Then
                    lblInfo.Text = "y For Y"
                End If
                If info_Delay = 34 Then
                    lblInfo.Text = " For Yo"
                End If
                If info_Delay = 36 Then
                    lblInfo.Text = "For You"
                End If
                If info_Delay = 38 Then
                    lblInfo.Text = "or Your"
                End If
                If info_Delay = 40 Then
                    lblInfo.Text = "r Your "
                End If
                If info_Delay = 42 Then
                    lblInfo.Text = " Your I"
                End If
                If info_Delay = 44 Then
                    lblInfo.Text = "Your It"
                End If
                If info_Delay = 46 Then
                    lblInfo.Text = "our Ite"
                End If
                If info_Delay = 48 Then
                    lblInfo.Text = "ur Item"
                End If
                If info_Delay = 50 Then
                    lblInfo.Text = "r Item."
                End If
                If info_Delay = 52 Then
                    lblInfo.Text = " Item. "
                End If
                If info_Delay = 54 Then
                    lblInfo.Text = "Item.  "
                End If
                If info_Delay = 56 Then
                    lblInfo.Text = "tem.   "
                End If
                If info_Delay = 58 Then
                    lblInfo.Text = "em.    "
                End If
                If info_Delay = 60 Then
                    lblInfo.Text = "m.     "
                End If
                If info_Delay = 62 Then
                    lblInfo.Text = ".      "
                End If
                If info_Delay = 64 Then
                    lblInfo.Text = "       "
                End If
                If info_Delay = 66 Then
                    info_Delay = 0
                End If




            ElseIf InfoTime = 120 Then '------------------------------InfoTime 120
                info_Delay += 1
                If info_Delay = 10 Then
                    lblInfo.Text = "Authorizing"
                End If
                If info_Delay = 20 Then
                    lblInfo.Text = "           "
                End If
                If info_Delay = 30 Then
                    lblInfo.Text = "Authorizing"
                End If
                If info_Delay = 40 Then
                    lblInfo.Text = "           "
                End If
                If info_Delay = 50 Then
                    lblInfo.Text = "Authorizing"
                End If
                If info_Delay = 60 Then
                    lblInfo.Text = "           "
                End If
                If info_Delay = 70 Then
                    lblInfo.Text = "Approved"
                End If
                If info_Delay = 80 Then

                    InfoTime = 10
                    info_Delay = 0
                    lblMoney.Text = ""

                    Me.BackgroundImage = My.Resources.vending_machines_798148

                    pbCreditCard.Visible = False
                    pbCreditCard.Enabled = True
                    pbHalfCardReader.Visible = False
                    pbBottom.Visible = True
                    pbMid.Visible = True
                    pbStickmonPos.BringToFront()
                    pbClr.Visible = False


                    lblItem.Visible = False
                    lblInfo.Visible = False
                    lblMoney.Visible = False
                    lblCashSign.Visible = False
                    pbStickmonPos.Image = My.Resources.Neg_Stickmon

                    Time = 60
                End If




            ElseIf InfoTime = 130 Then '------------------------------InfoTime 130
                info_Delay += 1
                If info_Delay = 10 Then
                    lblInfo.Text = "Authorizing"
                End If
                If info_Delay = 20 Then
                    lblInfo.Text = "           "
                End If
                If info_Delay = 30 Then
                    lblInfo.Text = "Authorizing"
                End If
                If info_Delay = 40 Then
                    lblInfo.Text = "           "
                End If
                If info_Delay = 50 Then
                    lblInfo.Text = "Authorizing"
                End If
                If info_Delay = 60 Then
                    lblInfo.Text = "           "
                End If
                If info_Delay = 70 Then
                    lblInfo.Text = "Declined"
                End If
                If info_Delay = 80 Then
                    InfoTime = 10
                    AnimationTime = 20
                    animation = -1


                    lblMoney.Text = ""
                    lblItem.Text = ""
                    Me.BackgroundImage = My.Resources.vending_machines_798148
                    pbCreditCard.Visible = False
                    pbCreditCard.Enabled = True
                    pbHalfCardReader.Visible = False
                    pbClr.Visible = False
                    pnlA.Visible = False
                    pnlB.Visible = False

                    AnimationChange()


                    lblMoney.Visible = False
                    lblCashSign.Visible = False
                    lblInfo.Visible = False
                    lblItem.Visible = False


                    info_Delay = 0

                    If Decline = 2 Then
                        Credit = 5000
                        Decline = 0
                        MessageBox.Show("Application Restarted")
                    End If
                End If




            ElseIf InfoTime = 140 Then '------------------------------InfoTime 140
                info_Delay += 1
                If info_Delay = 6 Then
                    lblItem.Text = ""
                    lblInfo.Text = "Sold Out"
                End If
                If info_Delay = 30 Then
                    InfoTime = 100
                    info_Delay = 0
                End If

            ElseIf InfoTime = 150 Then '-------------------------------InfoTime 150
                info_Delay += 1
                If info_Delay = 6 Then
                    My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.WaitToComplete)
                    My.Computer.Audio.Play(My.Resources.ButtonBeep, AudioPlayMode.WaitToComplete)

                    lblItem.Text = ""
                    lblInfo.Text = ""

                    lblInfo.Text = "Invalid Selection"
                End If
                If info_Delay = 30 Then
                    InfoTime = 100
                    info_Delay = 0
                End If
            End If
        End If
    End Sub
End Class
