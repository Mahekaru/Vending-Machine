<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendingMachine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendingMachine))
        Me.tmrAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlA = New System.Windows.Forms.Panel()
        Me.pnlOne = New System.Windows.Forms.Panel()
        Me.pnlTwo = New System.Windows.Forms.Panel()
        Me.pbStickmonPos = New System.Windows.Forms.PictureBox()
        Me.pbStickmonStand5 = New System.Windows.Forms.PictureBox()
        Me.pbStickmonStand4 = New System.Windows.Forms.PictureBox()
        Me.pbStickmonWalk5 = New System.Windows.Forms.PictureBox()
        Me.pbStickmonWalk3 = New System.Windows.Forms.PictureBox()
        Me.pbStickmonWalk4 = New System.Windows.Forms.PictureBox()
        Me.pbStickmonWalk2 = New System.Windows.Forms.PictureBox()
        Me.pbStickmonStand3 = New System.Windows.Forms.PictureBox()
        Me.pbStickmonStand2 = New System.Windows.Forms.PictureBox()
        Me.pbStickmonWalk1 = New System.Windows.Forms.PictureBox()
        Me.pbStickmonStand1 = New System.Windows.Forms.PictureBox()
        Me.pnlThree = New System.Windows.Forms.Panel()
        Me.pnlB = New System.Windows.Forms.Panel()
        Me.pnlFour = New System.Windows.Forms.Panel()
        Me.pnlFive = New System.Windows.Forms.Panel()
        Me.pnlSix = New System.Windows.Forms.Panel()
        Me.pnlC = New System.Windows.Forms.Panel()
        Me.pnlSeven = New System.Windows.Forms.Panel()
        Me.pnlEight = New System.Windows.Forms.Panel()
        Me.pnlNine = New System.Windows.Forms.Panel()
        Me.pnlD = New System.Windows.Forms.Panel()
        Me.PnlZero = New System.Windows.Forms.Panel()
        Me.pnlEnter = New System.Windows.Forms.Panel()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.tmrKeypad = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStickmonPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStickmonStand5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStickmonStand4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStickmonWalk5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStickmonWalk3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStickmonWalk4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStickmonWalk2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStickmonStand3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStickmonStand2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStickmonWalk1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStickmonStand1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrAnimate
        '
        Me.tmrAnimate.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(79, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 76)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'pnlA
        '
        Me.pnlA.BackColor = System.Drawing.Color.Transparent
        Me.pnlA.Location = New System.Drawing.Point(206, 519)
        Me.pnlA.Name = "pnlA"
        Me.pnlA.Size = New System.Drawing.Size(41, 47)
        Me.pnlA.TabIndex = 19
        Me.pnlA.Visible = False
        '
        'pnlOne
        '
        Me.pnlOne.BackColor = System.Drawing.Color.Transparent
        Me.pnlOne.Location = New System.Drawing.Point(253, 519)
        Me.pnlOne.Name = "pnlOne"
        Me.pnlOne.Size = New System.Drawing.Size(44, 47)
        Me.pnlOne.TabIndex = 20
        Me.pnlOne.Visible = False
        '
        'pnlTwo
        '
        Me.pnlTwo.BackColor = System.Drawing.Color.Transparent
        Me.pnlTwo.Location = New System.Drawing.Point(303, 519)
        Me.pnlTwo.Name = "pnlTwo"
        Me.pnlTwo.Size = New System.Drawing.Size(39, 47)
        Me.pnlTwo.TabIndex = 21
        Me.pnlTwo.Visible = False
        '
        'pbStickmonPos
        '
        Me.pbStickmonPos.ErrorImage = Nothing
        Me.pbStickmonPos.Image = Global.Vending_Machine.My.Resources.Resources.stickmon_stand
        Me.pbStickmonPos.InitialImage = Nothing
        Me.pbStickmonPos.Location = New System.Drawing.Point(352, 681)
        Me.pbStickmonPos.Name = "pbStickmonPos"
        Me.pbStickmonPos.Size = New System.Drawing.Size(26, 53)
        Me.pbStickmonPos.TabIndex = 43
        Me.pbStickmonPos.TabStop = False
        Me.pbStickmonPos.Visible = False
        '
        'pbStickmonStand5
        '
        Me.pbStickmonStand5.ErrorImage = Nothing
        Me.pbStickmonStand5.Image = Global.Vending_Machine.My.Resources.Resources.Stickmon
        Me.pbStickmonStand5.InitialImage = Nothing
        Me.pbStickmonStand5.Location = New System.Drawing.Point(285, 682)
        Me.pbStickmonStand5.Name = "pbStickmonStand5"
        Me.pbStickmonStand5.Size = New System.Drawing.Size(26, 51)
        Me.pbStickmonStand5.TabIndex = 42
        Me.pbStickmonStand5.TabStop = False
        Me.pbStickmonStand5.Visible = False
        '
        'pbStickmonStand4
        '
        Me.pbStickmonStand4.ErrorImage = Nothing
        Me.pbStickmonStand4.Image = Global.Vending_Machine.My.Resources.Resources.Stickmon
        Me.pbStickmonStand4.InitialImage = Nothing
        Me.pbStickmonStand4.Location = New System.Drawing.Point(215, 681)
        Me.pbStickmonStand4.Name = "pbStickmonStand4"
        Me.pbStickmonStand4.Size = New System.Drawing.Size(26, 53)
        Me.pbStickmonStand4.TabIndex = 41
        Me.pbStickmonStand4.TabStop = False
        Me.pbStickmonStand4.Visible = False
        '
        'pbStickmonWalk5
        '
        Me.pbStickmonWalk5.ErrorImage = Nothing
        Me.pbStickmonWalk5.Image = Global.Vending_Machine.My.Resources.Resources.Stickmon_run
        Me.pbStickmonWalk5.Location = New System.Drawing.Point(320, 683)
        Me.pbStickmonWalk5.Name = "pbStickmonWalk5"
        Me.pbStickmonWalk5.Size = New System.Drawing.Size(26, 52)
        Me.pbStickmonWalk5.TabIndex = 40
        Me.pbStickmonWalk5.TabStop = False
        Me.pbStickmonWalk5.Visible = False
        '
        'pbStickmonWalk3
        '
        Me.pbStickmonWalk3.ErrorImage = Nothing
        Me.pbStickmonWalk3.Image = Global.Vending_Machine.My.Resources.Resources.Stickmon_run
        Me.pbStickmonWalk3.Location = New System.Drawing.Point(180, 681)
        Me.pbStickmonWalk3.Name = "pbStickmonWalk3"
        Me.pbStickmonWalk3.Size = New System.Drawing.Size(26, 52)
        Me.pbStickmonWalk3.TabIndex = 39
        Me.pbStickmonWalk3.TabStop = False
        Me.pbStickmonWalk3.Visible = False
        '
        'pbStickmonWalk4
        '
        Me.pbStickmonWalk4.ErrorImage = Nothing
        Me.pbStickmonWalk4.Image = Global.Vending_Machine.My.Resources.Resources.Stickmon_run
        Me.pbStickmonWalk4.Location = New System.Drawing.Point(250, 681)
        Me.pbStickmonWalk4.Name = "pbStickmonWalk4"
        Me.pbStickmonWalk4.Size = New System.Drawing.Size(26, 52)
        Me.pbStickmonWalk4.TabIndex = 38
        Me.pbStickmonWalk4.TabStop = False
        Me.pbStickmonWalk4.Visible = False
        '
        'pbStickmonWalk2
        '
        Me.pbStickmonWalk2.ErrorImage = Nothing
        Me.pbStickmonWalk2.Image = Global.Vending_Machine.My.Resources.Resources.Stickmon_run
        Me.pbStickmonWalk2.Location = New System.Drawing.Point(113, 681)
        Me.pbStickmonWalk2.Name = "pbStickmonWalk2"
        Me.pbStickmonWalk2.Size = New System.Drawing.Size(26, 52)
        Me.pbStickmonWalk2.TabIndex = 37
        Me.pbStickmonWalk2.TabStop = False
        Me.pbStickmonWalk2.Visible = False
        '
        'pbStickmonStand3
        '
        Me.pbStickmonStand3.ErrorImage = Nothing
        Me.pbStickmonStand3.Image = Global.Vending_Machine.My.Resources.Resources.Stickmon
        Me.pbStickmonStand3.InitialImage = Nothing
        Me.pbStickmonStand3.Location = New System.Drawing.Point(145, 681)
        Me.pbStickmonStand3.Name = "pbStickmonStand3"
        Me.pbStickmonStand3.Size = New System.Drawing.Size(26, 52)
        Me.pbStickmonStand3.TabIndex = 36
        Me.pbStickmonStand3.TabStop = False
        Me.pbStickmonStand3.Visible = False
        '
        'pbStickmonStand2
        '
        Me.pbStickmonStand2.ErrorImage = Nothing
        Me.pbStickmonStand2.Image = Global.Vending_Machine.My.Resources.Resources.Stickmon
        Me.pbStickmonStand2.InitialImage = Nothing
        Me.pbStickmonStand2.Location = New System.Drawing.Point(81, 681)
        Me.pbStickmonStand2.Name = "pbStickmonStand2"
        Me.pbStickmonStand2.Size = New System.Drawing.Size(26, 52)
        Me.pbStickmonStand2.TabIndex = 35
        Me.pbStickmonStand2.TabStop = False
        Me.pbStickmonStand2.Visible = False
        '
        'pbStickmonWalk1
        '
        Me.pbStickmonWalk1.ErrorImage = Nothing
        Me.pbStickmonWalk1.Image = Global.Vending_Machine.My.Resources.Resources.Stickmon_run
        Me.pbStickmonWalk1.Location = New System.Drawing.Point(49, 681)
        Me.pbStickmonWalk1.Name = "pbStickmonWalk1"
        Me.pbStickmonWalk1.Size = New System.Drawing.Size(26, 52)
        Me.pbStickmonWalk1.TabIndex = 34
        Me.pbStickmonWalk1.TabStop = False
        Me.pbStickmonWalk1.Visible = False
        '
        'pbStickmonStand1
        '
        Me.pbStickmonStand1.ErrorImage = Nothing
        Me.pbStickmonStand1.Image = Global.Vending_Machine.My.Resources.Resources.Stickmon
        Me.pbStickmonStand1.InitialImage = Nothing
        Me.pbStickmonStand1.Location = New System.Drawing.Point(17, 681)
        Me.pbStickmonStand1.Name = "pbStickmonStand1"
        Me.pbStickmonStand1.Size = New System.Drawing.Size(26, 53)
        Me.pbStickmonStand1.TabIndex = 33
        Me.pbStickmonStand1.TabStop = False
        '
        'pnlThree
        '
        Me.pnlThree.BackColor = System.Drawing.Color.Transparent
        Me.pnlThree.Location = New System.Drawing.Point(348, 519)
        Me.pnlThree.Name = "pnlThree"
        Me.pnlThree.Size = New System.Drawing.Size(39, 47)
        Me.pnlThree.TabIndex = 44
        Me.pnlThree.Visible = False
        '
        'pnlB
        '
        Me.pnlB.BackColor = System.Drawing.Color.Transparent
        Me.pnlB.Location = New System.Drawing.Point(206, 572)
        Me.pnlB.Name = "pnlB"
        Me.pnlB.Size = New System.Drawing.Size(41, 54)
        Me.pnlB.TabIndex = 45
        Me.pnlB.Visible = False
        '
        'pnlFour
        '
        Me.pnlFour.BackColor = System.Drawing.Color.Transparent
        Me.pnlFour.Location = New System.Drawing.Point(256, 572)
        Me.pnlFour.Name = "pnlFour"
        Me.pnlFour.Size = New System.Drawing.Size(41, 54)
        Me.pnlFour.TabIndex = 46
        Me.pnlFour.Visible = False
        '
        'pnlFive
        '
        Me.pnlFive.BackColor = System.Drawing.Color.Transparent
        Me.pnlFive.Location = New System.Drawing.Point(303, 572)
        Me.pnlFive.Name = "pnlFive"
        Me.pnlFive.Size = New System.Drawing.Size(39, 54)
        Me.pnlFive.TabIndex = 47
        Me.pnlFive.Visible = False
        '
        'pnlSix
        '
        Me.pnlSix.BackColor = System.Drawing.Color.Transparent
        Me.pnlSix.Location = New System.Drawing.Point(346, 572)
        Me.pnlSix.Name = "pnlSix"
        Me.pnlSix.Size = New System.Drawing.Size(41, 54)
        Me.pnlSix.TabIndex = 48
        Me.pnlSix.Visible = False
        '
        'pnlC
        '
        Me.pnlC.BackColor = System.Drawing.Color.Transparent
        Me.pnlC.Location = New System.Drawing.Point(206, 632)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.Size = New System.Drawing.Size(41, 48)
        Me.pnlC.TabIndex = 49
        Me.pnlC.Visible = False
        '
        'pnlSeven
        '
        Me.pnlSeven.BackColor = System.Drawing.Color.Transparent
        Me.pnlSeven.Location = New System.Drawing.Point(256, 632)
        Me.pnlSeven.Name = "pnlSeven"
        Me.pnlSeven.Size = New System.Drawing.Size(41, 48)
        Me.pnlSeven.TabIndex = 50
        Me.pnlSeven.Visible = False
        '
        'pnlEight
        '
        Me.pnlEight.BackColor = System.Drawing.Color.Transparent
        Me.pnlEight.Location = New System.Drawing.Point(301, 632)
        Me.pnlEight.Name = "pnlEight"
        Me.pnlEight.Size = New System.Drawing.Size(41, 48)
        Me.pnlEight.TabIndex = 51
        Me.pnlEight.Visible = False
        '
        'pnlNine
        '
        Me.pnlNine.BackColor = System.Drawing.Color.Transparent
        Me.pnlNine.Location = New System.Drawing.Point(348, 632)
        Me.pnlNine.Name = "pnlNine"
        Me.pnlNine.Size = New System.Drawing.Size(39, 48)
        Me.pnlNine.TabIndex = 52
        Me.pnlNine.Visible = False
        '
        'pnlD
        '
        Me.pnlD.BackColor = System.Drawing.Color.Transparent
        Me.pnlD.Location = New System.Drawing.Point(206, 686)
        Me.pnlD.Name = "pnlD"
        Me.pnlD.Size = New System.Drawing.Size(41, 48)
        Me.pnlD.TabIndex = 53
        Me.pnlD.Visible = False
        '
        'PnlZero
        '
        Me.PnlZero.BackColor = System.Drawing.Color.Transparent
        Me.PnlZero.Location = New System.Drawing.Point(301, 686)
        Me.PnlZero.Name = "PnlZero"
        Me.PnlZero.Size = New System.Drawing.Size(41, 48)
        Me.PnlZero.TabIndex = 54
        Me.PnlZero.Visible = False
        '
        'pnlEnter
        '
        Me.pnlEnter.BackColor = System.Drawing.Color.Transparent
        Me.pnlEnter.Location = New System.Drawing.Point(346, 686)
        Me.pnlEnter.Name = "pnlEnter"
        Me.pnlEnter.Size = New System.Drawing.Size(81, 48)
        Me.pnlEnter.TabIndex = 55
        Me.pnlEnter.Visible = False
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(208, 458)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(0, 13)
        Me.lblItem.TabIndex = 56
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(208, 471)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(47, 13)
        Me.lblInfo.TabIndex = 57
        Me.lblInfo.Text = "sdfgsdfg"
        '
        'tmrKeypad
        '
        '
        'frmVendingMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vending_Machine.My.Resources.Resources.vending_machines_798148
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(429, 737)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.pbStickmonStand5)
        Me.Controls.Add(Me.pnlEnter)
        Me.Controls.Add(Me.pbStickmonStand1)
        Me.Controls.Add(Me.PnlZero)
        Me.Controls.Add(Me.pbStickmonWalk1)
        Me.Controls.Add(Me.pnlD)
        Me.Controls.Add(Me.pbStickmonStand2)
        Me.Controls.Add(Me.pnlNine)
        Me.Controls.Add(Me.pbStickmonStand3)
        Me.Controls.Add(Me.pbStickmonWalk2)
        Me.Controls.Add(Me.pnlEight)
        Me.Controls.Add(Me.pbStickmonWalk4)
        Me.Controls.Add(Me.pnlSeven)
        Me.Controls.Add(Me.pbStickmonWalk3)
        Me.Controls.Add(Me.pnlC)
        Me.Controls.Add(Me.pbStickmonWalk5)
        Me.Controls.Add(Me.pnlSix)
        Me.Controls.Add(Me.pbStickmonStand4)
        Me.Controls.Add(Me.pnlFive)
        Me.Controls.Add(Me.pbStickmonPos)
        Me.Controls.Add(Me.pnlFour)
        Me.Controls.Add(Me.pnlB)
        Me.Controls.Add(Me.pnlThree)
        Me.Controls.Add(Me.pnlOne)
        Me.Controls.Add(Me.pnlTwo)
        Me.Controls.Add(Me.pnlA)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmVendingMachine"
        Me.Text = "Vending Machine"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStickmonPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStickmonStand5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStickmonStand4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStickmonWalk5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStickmonWalk3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStickmonWalk4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStickmonWalk2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStickmonStand3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStickmonStand2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStickmonWalk1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStickmonStand1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrAnimate As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlA As System.Windows.Forms.Panel
    Friend WithEvents pnlOne As System.Windows.Forms.Panel
    Friend WithEvents pnlTwo As System.Windows.Forms.Panel
    Friend WithEvents pbStickmonPos As System.Windows.Forms.PictureBox
    Friend WithEvents pbStickmonStand5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStickmonStand4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStickmonWalk5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStickmonWalk3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStickmonWalk4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStickmonWalk2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStickmonStand3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStickmonStand2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStickmonWalk1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStickmonStand1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlThree As System.Windows.Forms.Panel
    Friend WithEvents pnlB As System.Windows.Forms.Panel
    Friend WithEvents pnlFour As System.Windows.Forms.Panel
    Friend WithEvents pnlFive As System.Windows.Forms.Panel
    Friend WithEvents pnlSix As System.Windows.Forms.Panel
    Friend WithEvents pnlC As System.Windows.Forms.Panel
    Friend WithEvents pnlSeven As System.Windows.Forms.Panel
    Friend WithEvents pnlEight As System.Windows.Forms.Panel
    Friend WithEvents pnlNine As System.Windows.Forms.Panel
    Friend WithEvents pnlD As System.Windows.Forms.Panel
    Friend WithEvents PnlZero As System.Windows.Forms.Panel
    Friend WithEvents pnlEnter As System.Windows.Forms.Panel
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents tmrKeypad As System.Windows.Forms.Timer

End Class
