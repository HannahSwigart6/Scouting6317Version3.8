Imports System.IO

Public Class Form1
    Friend WithEvents UpperAutoPts As System.Windows.Forms.NumericUpDown
    Friend WithEvents LowerAutoPts As System.Windows.Forms.NumericUpDown
    Friend WithEvents LowerTeleopPts As System.Windows.Forms.NumericUpDown
    Friend WithEvents UpperTeleopPts As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BreakB As System.Windows.Forms.CheckBox
    Friend WithEvents Rotor40 As System.Windows.Forms.CheckBox
    Friend WithEvents Rotor As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnResult As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTeamName As System.Windows.Forms.TextBox
    Friend WithEvents txtTeamNum As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Rotor160 As System.Windows.Forms.CheckBox
    Friend WithEvents Rotor120 As System.Windows.Forms.CheckBox
    Friend WithEvents Rotor80 As System.Windows.Forms.CheckBox
    Friend WithEvents Rope As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtSpecial As System.Windows.Forms.TextBox


    Dim a As StreamReader
    Dim b As String
    Dim c As String = "C:\Users\hs131455\Desktop\Github repository\Scouting6317Version3.8\WindowsApplication2\Resources\ScoutingText.txt"


    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        'Autonomous Scoring Code!!!!!!!!!!!
        'Autonomous Scoring Code!!!!!!!!!!!
        'Autonomous Scoring Code!!!!!!!!!!!
        Dim dblUpperAutoPts As Double
        Dim dblLowerAutoPts As Double
        Dim blnInputOk = True
        Dim dblResult As Double

        Const intBreakB As Integer = 5
        Const intRotor As Integer = 60

        'Converting strings to integers(Autonomous)
        dblUpperAutoPts = CDbl(UpperAutoPts.Text)
        dblLowerAutoPts = CDbl(LowerAutoPts.Text)

        dblResult = dblUpperAutoPts + (dblLowerAutoPts / 3)

        lblResult.Text = CStr(dblResult)


        If BreakB.Checked = True Then
            dblResult = dblUpperAutoPts + (dblLowerAutoPts / 3) + intBreakB
            lblResult.Text = CStr(dblResult)
        End If

        If Rotor.Checked = True Then
            dblResult = dblUpperAutoPts + (dblLowerAutoPts / 3) + intRotor
            lblResult.Text = CStr(dblResult)
        End If

        If Rotor.Checked And BreakB.Checked = True Then
            dblResult = dblUpperAutoPts + (dblLowerAutoPts / 3) + intBreakB + intRotor
            lblResult.Text = CStr(dblResult)
        End If

        'Teleop Scoring Code!!!!!!!!!!!
        'Teleop Scoring Code!!!!!!!!!!!
        'Teleop Scoring Code!!!!!!!!!!!
        Dim dblUpperTeleopPts As Double
        Dim dblLowerTeleopPts As Double
        Dim dblTotal As Double

        Const intRope As Integer = 50
        Const intRotor40 As Integer = 40
        Const intRotor80 As Integer = 80
        Const intRotor120 As Integer = 120
        Const intRotor160 As Integer = 160

        'Converting strings to integers(Teleop)
        dblUpperTeleopPts = CDbl(UpperTeleopPts.Text)
        dblLowerTeleopPts = CDbl(LowerTeleopPts.Text)

        dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9)
        lblTotal.Text = CStr(dblTotal)

        'If check boxes are checked.
        If Rope.Checked = True Then
            dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9) + intRope
            lblTotal.Text = CStr(dblTotal)
        End If
        If Rotor40.Checked = True Then
            dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9) + intRotor40
            lblTotal.Text = CStr(dblTotal)
        End If

        If Rotor80.Checked = True Then
            dblTotal = dblUpperTeleopPts + (dblLowerTeleopPts / 3) + intRotor80
            lblTotal.Text = CStr(dblTotal)
        End If

        If Rotor120.Checked = True Then
            dblTotal = dblUpperTeleopPts + (dblLowerTeleopPts / 3) + intRotor120
            lblTotal.Text = CStr(dblTotal)
        End If

        If Rotor160.Checked = True Then
            dblTotal = dblUpperTeleopPts + (dblLowerTeleopPts / 3) + intRotor160
            lblTotal.Text = CStr(dblTotal)
        End If


        'If one of the 4 rotor check boxes is checked plus the rope if completed.
        If Rope.Checked And Rotor40.Checked = True Then
            dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9) + intRope + intRotor40
            lblTotal.Text = CStr(dblTotal)
        End If
        If Rope.Checked And Rotor80.Checked = True Then
            dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9) + intRope + intRotor80
            lblTotal.Text = CStr(dblTotal)
        End If
        If Rope.Checked And Rotor120.Checked = True Then
            dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9) + intRope + intRotor120
            lblTotal.Text = CStr(dblTotal)
        End If
        If Rope.Checked And Rotor160.Checked = True Then
            dblTotal = (dblUpperTeleopPts / 3) + (dblLowerTeleopPts / 9) + intRope + intRotor160
            lblTotal.Text = CStr(dblTotal)
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Unchecking the CheckBoxes!
        BreakB.Checked = False
        Rotor.Checked = False
        Rope.Checked = False
        Rotor40.Checked = False
        Rotor80.Checked = False
        Rotor120.Checked = False
        Rotor160.Checked = False

        'Clearing the Team Name and Number Text Boxes
        txtTeamName.Text = String.Empty
        txtTeamNum.Text = String.Empty
        txtSpecial.Text = String.Empty

        'Clearing the Numeric Up and Down Boxes
        UpperAutoPts.Text = 0
        LowerAutoPts.Text = 0
        UpperTeleopPts.Text = 0
        LowerTeleopPts.Text = 0

        'Clearing The Total Labels
        lblResult.Text = String.Empty
        lblTotal.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        'Exports the data to notepad 
        ' Puts the information into a coulmns "AddInfo.WriteLine"
        If lblResult.Text And lblTotal.Text = Nothing Then
            MsgBox("Enter a password to be saved.")
        Else
            File.AppendAllText(c, lblResult.Text & lblTotal.Text & vbCrLf & txtTeamName.Text & txtTeamNum.Text & lblResult.Text & lblTotal.Text & BreakB.Text & Rotor.Text & txtSpecial.Text)
            lblResult.Text = ""
            lblTotal.Text = ""
            MsgBox("Password saved!", MsgBoxStyle.Information, "Saved")
        End If

        Dim Scouting As New ScoutingData()

    End Sub

    Private Sub InitializeComponent()
        Me.txtSpecial = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Rope = New System.Windows.Forms.CheckBox()
        Me.Rotor80 = New System.Windows.Forms.CheckBox()
        Me.Rotor120 = New System.Windows.Forms.CheckBox()
        Me.Rotor160 = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTeamNum = New System.Windows.Forms.TextBox()
        Me.txtTeamName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Rotor = New System.Windows.Forms.CheckBox()
        Me.Rotor40 = New System.Windows.Forms.CheckBox()
        Me.BreakB = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UpperTeleopPts = New System.Windows.Forms.NumericUpDown()
        Me.LowerTeleopPts = New System.Windows.Forms.NumericUpDown()
        Me.LowerAutoPts = New System.Windows.Forms.NumericUpDown()
        Me.UpperAutoPts = New System.Windows.Forms.NumericUpDown()
        CType(Me.UpperTeleopPts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LowerTeleopPts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LowerAutoPts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpperAutoPts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSpecial
        '
        Me.txtSpecial.Location = New System.Drawing.Point(59, 498)
        Me.txtSpecial.Multiline = True
        Me.txtSpecial.Name = "txtSpecial"
        Me.txtSpecial.Size = New System.Drawing.Size(441, 127)
        Me.txtSpecial.TabIndex = 81
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(578, 569)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 56)
        Me.btnClear.TabIndex = 80
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Rope
        '
        Me.Rope.AutoSize = True
        Me.Rope.Location = New System.Drawing.Point(756, 272)
        Me.Rope.Name = "Rope"
        Me.Rope.Size = New System.Drawing.Size(76, 17)
        Me.Rope.TabIndex = 79
        Me.Rope.Text = "Completed"
        Me.Rope.UseVisualStyleBackColor = True
        '
        'Rotor80
        '
        Me.Rotor80.AutoSize = True
        Me.Rotor80.Location = New System.Drawing.Point(741, 232)
        Me.Rotor80.Name = "Rotor80"
        Me.Rotor80.Size = New System.Drawing.Size(32, 17)
        Me.Rotor80.TabIndex = 78
        Me.Rotor80.Text = "2"
        Me.Rotor80.UseVisualStyleBackColor = True
        '
        'Rotor120
        '
        Me.Rotor120.AutoSize = True
        Me.Rotor120.Location = New System.Drawing.Point(834, 202)
        Me.Rotor120.Name = "Rotor120"
        Me.Rotor120.Size = New System.Drawing.Size(32, 17)
        Me.Rotor120.TabIndex = 77
        Me.Rotor120.Text = "3"
        Me.Rotor120.UseVisualStyleBackColor = True
        '
        'Rotor160
        '
        Me.Rotor160.AutoSize = True
        Me.Rotor160.Location = New System.Drawing.Point(834, 232)
        Me.Rotor160.Name = "Rotor160"
        Me.Rotor160.Size = New System.Drawing.Size(32, 17)
        Me.Rotor160.TabIndex = 76
        Me.Rotor160.Text = "4"
        Me.Rotor160.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label19.Location = New System.Drawing.Point(59, 77)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(193, 24)
        Me.Label19.TabIndex = 75
        Me.Label19.Text = "Autonomous Scoring:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label18.Location = New System.Drawing.Point(513, 87)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(145, 24)
        Me.Label18.TabIndex = 74
        Me.Label18.Text = "Teleop Scoring:"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblTotal.Location = New System.Drawing.Point(660, 323)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(138, 34)
        Me.lblTotal.TabIndex = 73
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(718, 569)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 56)
        Me.btnExit.TabIndex = 72
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(578, 480)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(265, 74)
        Me.btnExcel.TabIndex = 71
        Me.btnExcel.Text = "Export to Excel:"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label15.Location = New System.Drawing.Point(70, 470)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 24)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Special Notes:"
        '
        'txtTeamNum
        '
        Me.txtTeamNum.Location = New System.Drawing.Point(747, 32)
        Me.txtTeamNum.Name = "txtTeamNum"
        Me.txtTeamNum.Size = New System.Drawing.Size(96, 20)
        Me.txtTeamNum.TabIndex = 69
        '
        'txtTeamName
        '
        Me.txtTeamName.Location = New System.Drawing.Point(382, 31)
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(270, 20)
        Me.txtTeamName.TabIndex = 68
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label17.Location = New System.Drawing.Point(282, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 18)
        Me.Label17.TabIndex = 67
        Me.Label17.Text = "Team Name:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label16.Location = New System.Drawing.Point(679, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 18)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Team #:"
        '
        'btnResult
        '
        Me.btnResult.Location = New System.Drawing.Point(382, 369)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(175, 78)
        Me.btnResult.TabIndex = 64
        Me.btnResult.Text = "Total Out"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblResult.Location = New System.Drawing.Point(268, 323)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(138, 34)
        Me.lblResult.TabIndex = 63
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label12.Location = New System.Drawing.Point(56, 323)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(169, 24)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Autonomous Total:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label11.Location = New System.Drawing.Point(513, 323)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 24)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Teleop Total:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Firebrick
        Me.Label10.Location = New System.Drawing.Point(60, 460)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(802, 1)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Label10"
        '
        'Rotor
        '
        Me.Rotor.AutoSize = True
        Me.Rotor.Location = New System.Drawing.Point(249, 264)
        Me.Rotor.Name = "Rotor"
        Me.Rotor.Size = New System.Drawing.Size(76, 17)
        Me.Rotor.TabIndex = 59
        Me.Rotor.Text = "Completed"
        Me.Rotor.UseVisualStyleBackColor = True
        '
        'Rotor40
        '
        Me.Rotor40.AutoSize = True
        Me.Rotor40.Location = New System.Drawing.Point(741, 200)
        Me.Rotor40.Name = "Rotor40"
        Me.Rotor40.Size = New System.Drawing.Size(32, 17)
        Me.Rotor40.TabIndex = 58
        Me.Rotor40.Text = "1"
        Me.Rotor40.UseVisualStyleBackColor = True
        '
        'BreakB
        '
        Me.BreakB.AutoSize = True
        Me.BreakB.Location = New System.Drawing.Point(249, 215)
        Me.BreakB.Name = "BreakB"
        Me.BreakB.Size = New System.Drawing.Size(76, 17)
        Me.BreakB.TabIndex = 57
        Me.BreakB.Text = "Completed"
        Me.BreakB.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(507, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Climb the Rope"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(504, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(215, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Each Rotor Turning (4 Rotors) (40 pts Each)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(71, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Upper Goal (1 Fuel = 1 pt)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Lower Goal (3 Fuel = 1 pt)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Break Baseline"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "1st Rotor Turning (60 pts)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(504, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Upper Goal (3 Fuel = 1 pt)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(504, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Lower Goal (9 Fuel = 1 pt)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(59, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 24)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Scouting Program:"
        '
        'UpperTeleopPts
        '
        Me.UpperTeleopPts.Location = New System.Drawing.Point(756, 119)
        Me.UpperTeleopPts.Name = "UpperTeleopPts"
        Me.UpperTeleopPts.Size = New System.Drawing.Size(116, 20)
        Me.UpperTeleopPts.TabIndex = 47
        '
        'LowerTeleopPts
        '
        Me.LowerTeleopPts.Location = New System.Drawing.Point(756, 162)
        Me.LowerTeleopPts.Name = "LowerTeleopPts"
        Me.LowerTeleopPts.Size = New System.Drawing.Size(116, 20)
        Me.LowerTeleopPts.TabIndex = 46
        '
        'LowerAutoPts
        '
        Me.LowerAutoPts.Location = New System.Drawing.Point(249, 167)
        Me.LowerAutoPts.Name = "LowerAutoPts"
        Me.LowerAutoPts.Size = New System.Drawing.Size(116, 20)
        Me.LowerAutoPts.TabIndex = 45
        '
        'UpperAutoPts
        '
        Me.UpperAutoPts.Location = New System.Drawing.Point(249, 119)
        Me.UpperAutoPts.Name = "UpperAutoPts"
        Me.UpperAutoPts.Size = New System.Drawing.Size(116, 20)
        Me.UpperAutoPts.TabIndex = 44
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(933, 650)
        Me.Controls.Add(Me.txtSpecial)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Rope)
        Me.Controls.Add(Me.Rotor80)
        Me.Controls.Add(Me.Rotor120)
        Me.Controls.Add(Me.Rotor160)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTeamNum)
        Me.Controls.Add(Me.txtTeamName)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Rotor)
        Me.Controls.Add(Me.Rotor40)
        Me.Controls.Add(Me.BreakB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UpperTeleopPts)
        Me.Controls.Add(Me.LowerTeleopPts)
        Me.Controls.Add(Me.LowerAutoPts)
        Me.Controls.Add(Me.UpperAutoPts)
        Me.Name = "Form1"
        CType(Me.UpperTeleopPts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LowerTeleopPts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LowerAutoPts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpperAutoPts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub lblResult_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(c) Then
            Dim d As FileStream
            d = File.Create(c)
            d.Close()
        End If
    End Sub
End Class


