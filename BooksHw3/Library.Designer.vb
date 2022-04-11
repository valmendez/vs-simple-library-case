<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Library
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
        Me.lblCallNumber = New System.Windows.Forms.Label()
        Me.txtCallNumber = New System.Windows.Forms.TextBox()
        Me.btnFindBook = New System.Windows.Forms.Button()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCallNumber
        '
        Me.lblCallNumber.AutoSize = True
        Me.lblCallNumber.Location = New System.Drawing.Point(82, 38)
        Me.lblCallNumber.Name = "lblCallNumber"
        Me.lblCallNumber.Size = New System.Drawing.Size(65, 13)
        Me.lblCallNumber.TabIndex = 0
        Me.lblCallNumber.Text = "Call number:"
        '
        'txtCallNumber
        '
        Me.txtCallNumber.Location = New System.Drawing.Point(153, 38)
        Me.txtCallNumber.Name = "txtCallNumber"
        Me.txtCallNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtCallNumber.TabIndex = 1
        '
        'btnFindBook
        '
        Me.btnFindBook.Location = New System.Drawing.Point(85, 73)
        Me.btnFindBook.Name = "btnFindBook"
        Me.btnFindBook.Size = New System.Drawing.Size(168, 23)
        Me.btnFindBook.TabIndex = 2
        Me.btnFindBook.Text = "Find Book"
        Me.btnFindBook.UseVisualStyleBackColor = True
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(82, 118)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblLocation.TabIndex = 3
        Me.lblLocation.Text = "Location:"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(153, 118)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 4
        '
        'Library
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 215)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.btnFindBook)
        Me.Controls.Add(Me.txtCallNumber)
        Me.Controls.Add(Me.lblCallNumber)
        Me.Name = "Library"
        Me.Text = "Library"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCallNumber As Label
    Friend WithEvents txtCallNumber As TextBox
    Friend WithEvents btnFindBook As Button
    Friend WithEvents lblLocation As Label
    Friend WithEvents txtResult As TextBox
End Class
