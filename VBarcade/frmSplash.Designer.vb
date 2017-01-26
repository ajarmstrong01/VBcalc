<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbtn1 = New System.Windows.Forms.Button()
        Me.gBtn3 = New System.Windows.Forms.Button()
        Me.gBtn4 = New System.Windows.Forms.Button()
        Me.gBtn2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Font = New System.Drawing.Font("Arial Black", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.Location = New System.Drawing.Point(142, 82)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(216, 60)
        Me.titleLbl.TabIndex = 0
        Me.titleLbl.Text = "SPLASH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 64)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ARCADE"
        '
        'gbtn1
        '
        Me.gbtn1.Location = New System.Drawing.Point(92, 284)
        Me.gbtn1.Name = "gbtn1"
        Me.gbtn1.Size = New System.Drawing.Size(75, 23)
        Me.gbtn1.TabIndex = 2
        Me.gbtn1.Text = "Pong"
        Me.gbtn1.UseVisualStyleBackColor = True
        '
        'gBtn3
        '
        Me.gBtn3.Location = New System.Drawing.Point(92, 395)
        Me.gBtn3.Name = "gBtn3"
        Me.gBtn3.Size = New System.Drawing.Size(75, 23)
        Me.gBtn3.TabIndex = 3
        Me.gBtn3.Text = "Hangman"
        Me.gBtn3.UseVisualStyleBackColor = True
        '
        'gBtn4
        '
        Me.gBtn4.Location = New System.Drawing.Point(319, 395)
        Me.gBtn4.Name = "gBtn4"
        Me.gBtn4.Size = New System.Drawing.Size(75, 23)
        Me.gBtn4.TabIndex = 4
        Me.gBtn4.Text = "Amanda"
        Me.gBtn4.UseVisualStyleBackColor = True
        '
        'gBtn2
        '
        Me.gBtn2.Location = New System.Drawing.Point(319, 284)
        Me.gBtn2.Name = "gBtn2"
        Me.gBtn2.Size = New System.Drawing.Size(75, 23)
        Me.gBtn2.TabIndex = 5
        Me.gBtn2.Text = "Frogger"
        Me.gBtn2.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.gBtn2)
        Me.Controls.Add(Me.gBtn4)
        Me.Controls.Add(Me.gBtn3)
        Me.Controls.Add(Me.gbtn1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.titleLbl)
        Me.Name = "Home"
        Me.Text = "Splash Arcade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbtn1 As Button
    Friend WithEvents gBtn3 As Button
    Friend WithEvents gBtn4 As Button
    Friend WithEvents gBtn2 As Button
End Class
