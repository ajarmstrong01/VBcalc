'Programmer: Amanda Armstrong
'Date: 2/20/2017
'Class: CIS310
'Purpose: Demonstrate skills learned in class


Public Class frmTTT
    'Declaration of variables
    Dim Turn As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Shows the value of Turn variable
        Turn = 1
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'Determines which text (X or O) is allowed in each button depending
        'on the value of the Turn variable
        If Turn = 1 Then
            btn1.Text = "O"
            lblTurn.Text = "X"
        Else
            btn1.Text = "X"
            lblTurn.Text = "O"
        End If
        Turn += 1
        If Turn > 2 Then
            Turn = 1
        End If
        'Win procedure is called to end the game
        Call Win()
        'Buttons are disabled once they have been clicked
        btn1.Enabled = False
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If Turn = 1 Then
            btn2.Text = "O"
            lblTurn.Text = "X"
        Else
            btn2.Text = "X"
            lblTurn.Text = "O"
        End If
        Turn += 1
        If Turn > 2 Then
            Turn = 1
        End If
        Call Win()
        btn2.Enabled = False
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If Turn = 1 Then
            btn3.Text = "O"
            lblTurn.Text = "X"
        Else
            btn3.Text = "X"
            lblTurn.Text = "O"
        End If
        Turn += 1
        If Turn > 2 Then
            Turn = 1
        End If
        Call Win()
        btn3.Enabled = False
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If Turn = 1 Then
            btn4.Text = "O"
            lblTurn.Text = "X"
        Else
            btn4.Text = "X"
            lblTurn.Text = "O"
        End If
        Turn += 1
        If Turn > 2 Then
            Turn = 1
        End If
        Call Win()
        btn4.Enabled = False
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If Turn = 1 Then
            btn5.Text = "O"
            lblTurn.Text = "X"
        Else
            btn5.Text = "X"
            lblTurn.Text = "O"
        End If
        Turn += 1
        If Turn > 2 Then
            Turn = 1
        End If
        Call Win()
        btn5.Enabled = False
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If Turn = 1 Then
            btn6.Text = "O"
            lblTurn.Text = "X"
        Else
            btn6.Text = "X"
            lblTurn.Text = "O"
        End If
        Turn += 1
        If Turn > 2 Then
            Turn = 1
        End If
        Call Win()
        btn6.Enabled = False
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If Turn = 1 Then
            btn7.Text = "O"
            lblTurn.Text = "X"
        Else
            btn7.Text = "X"
            lblTurn.Text = "O"
        End If
        Turn += 1
        If Turn > 2 Then
            Turn = 1
        End If
        Call Win()
        btn7.Enabled = False
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If Turn = 1 Then
            btn8.Text = "O"
            lblTurn.Text = "X"
        Else
            btn8.Text = "X"
            lblTurn.Text = "O"
        End If
        Turn += 1
        If Turn > 2 Then
            Turn = 1
        End If
        Call Win()
        btn8.Enabled = False
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If Turn = 1 Then
            btn9.Text = "O"
            lblTurn.Text = "X"
        Else
            btn9.Text = "X"
            lblTurn.Text = "O"
        End If
        Turn += 1
        If Turn > 2 Then
            Turn = 1
        End If
        Call Win()
        btn9.Enabled = False
    End Sub

    Private Sub DisableButtons()
        'Disables the game buttons for after the games have gone through the Win scenario
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
    End Sub

    Private Sub Win()
        'Win procedure for the game which is called after Turns have taken place.

        'All possible Win scenarios for Player X

        'Location of "X" within the buttons
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            'Message box appears
            MsgBox("Player X Wins!")
            'Score tally is updated
            lblXScore.Text += 1
            'Buttons are disabled so they can no longer be selected
            Call DisableButtons()
        ElseIf btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            MsgBox("Player X Wins!")
            lblXScore.Text += 1
            Call DisableButtons()
        ElseIf btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            MsgBox("Player X Wins!")
            lblXScore.Text += 1
            Call DisableButtons()
        ElseIf btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            MsgBox("Player X Wins!")
            lblXScore.Text += 1
            Call DisableButtons()
        ElseIf btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            MsgBox("Player X Wins!")
            lblXScore.Text += 1
            Call DisableButtons()
        ElseIf btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            MsgBox("Player X Wins!")
            lblXScore.Text += 1
            Call DisableButtons()
        ElseIf btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            MsgBox("Player X Wins!")
            lblXScore.Text += 1
            Call DisableButtons()
        ElseIf btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            MsgBox("Player X Wins!")
            lblXScore.Text += 1
            Call DisableButtons()

            'All possible Win scenarios for Player O

        ElseIf btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            MsgBox("Player O Wins!")
            lblOScore.Text += 1
            Call DisableButtons()
        ElseIf btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            MsgBox("Player O Wins!")
            lblOScore.Text += 1
            Call DisableButtons()
        ElseIf btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            MsgBox("Player O Wins!")
            lblOScore.Text += 1
            Call DisableButtons()
        ElseIf btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            MsgBox("Player O Wins!")
            lblOScore.Text += 1
            Call DisableButtons()
        ElseIf btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            MsgBox("Player O Wins!")
            lblOScore.Text += 1
            Call DisableButtons()
        ElseIf btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            MsgBox("Player O Wins!")
            lblOScore.Text += 1
            Call DisableButtons()
        ElseIf btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            MsgBox("Player O Wins!")
            lblOScore.Text += 1
            Call DisableButtons()
        ElseIf btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            MsgBox("Player O Wins!")
            lblOScore.Text += 1
            Call DisableButtons()
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Resets the game, but does not reset the Score
        btn1.Text = ""
        btn1.Enabled = True
        btn2.Text = ""
        btn2.Enabled = True
        btn3.Text = ""
        btn3.Enabled = True
        btn4.Text = ""
        btn4.Enabled = True
        btn5.Text = ""
        btn5.Enabled = True
        btn6.Text = ""
        btn6.Enabled = True
        btn7.Text = ""
        btn7.Enabled = True
        btn8.Text = ""
        btn8.Enabled = True
        btn9.Text = ""
        btn9.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the X Score and O Score labels
        lblXScore.Text = "0"
        lblOScore.Text = "0"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the form
        Me.Close()
    End Sub


End Class
