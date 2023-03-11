<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Cookie_Value = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Passivecookietimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_cost_click = New System.Windows.Forms.Label()
        Me.lbl_cost_wide = New System.Windows.Forms.Label()
        Me.Round_button1 = New Firstproject.Round_button()
        Me.SuspendLayout()
        '
        'Cookie_Value
        '
        Me.Cookie_Value.Location = New System.Drawing.Point(0, 0)
        Me.Cookie_Value.Name = "Cookie_Value"
        Me.Cookie_Value.Size = New System.Drawing.Size(100, 23)
        Me.Cookie_Value.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(100, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 0
        '
        'lbl_cost_click
        '
        Me.lbl_cost_click.Location = New System.Drawing.Point(0, 0)
        Me.lbl_cost_click.Name = "lbl_cost_click"
        Me.lbl_cost_click.Size = New System.Drawing.Size(100, 23)
        Me.lbl_cost_click.TabIndex = 0
        '
        'lbl_cost_wide
        '
        Me.lbl_cost_wide.Location = New System.Drawing.Point(0, 0)
        Me.lbl_cost_wide.Name = "lbl_cost_wide"
        Me.lbl_cost_wide.Size = New System.Drawing.Size(100, 23)
        Me.lbl_cost_wide.TabIndex = 0
        '
        'Round_button1
        '
        Me.Round_button1.Location = New System.Drawing.Point(274, 140)
        Me.Round_button1.Name = "Round_button1"
        Me.Round_button1.Size = New System.Drawing.Size(137, 138)
        Me.Round_button1.TabIndex = 0
        Me.Round_button1.Text = "Round_button1"
        Me.Round_button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(699, 449)
        Me.Controls.Add(Me.Round_button1)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cookie_Value As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Passivecookietimer As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_cost_click As Label
    Friend WithEvents lbl_cost_wide As Label
    Friend WithEvents grandma As Button
    Friend WithEvents grandma_cost As Label
    Friend WithEvents Round_button1 As Round_button
End Class
