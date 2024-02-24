<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecipeSelector
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_recipeID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgrecipe = New System.Windows.Forms.DataGridView()
        CType(Me.dgrecipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Search"
        '
        'txt_recipeID
        '
        Me.txt_recipeID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_recipeID.DefaultText = ""
        Me.txt_recipeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_recipeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_recipeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_recipeID.DisabledState.Parent = Me.txt_recipeID
        Me.txt_recipeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_recipeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_recipeID.FocusedState.Parent = Me.txt_recipeID
        Me.txt_recipeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_recipeID.HoverState.Parent = Me.txt_recipeID
        Me.txt_recipeID.Location = New System.Drawing.Point(118, 18)
        Me.txt_recipeID.Name = "txt_recipeID"
        Me.txt_recipeID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_recipeID.PlaceholderText = ""
        Me.txt_recipeID.SelectedText = ""
        Me.txt_recipeID.ShadowDecoration.Parent = Me.txt_recipeID
        Me.txt_recipeID.Size = New System.Drawing.Size(381, 29)
        Me.txt_recipeID.TabIndex = 9
        '
        'dgrecipe
        '
        Me.dgrecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrecipe.Location = New System.Drawing.Point(31, 71)
        Me.dgrecipe.Name = "dgrecipe"
        Me.dgrecipe.Size = New System.Drawing.Size(468, 495)
        Me.dgrecipe.TabIndex = 11
        '
        'FormRecipeSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 590)
        Me.Controls.Add(Me.dgrecipe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_recipeID)
        Me.Name = "FormRecipeSelector"
        Me.Text = "FormRecipeSelector"
        CType(Me.dgrecipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_recipeID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgrecipe As DataGridView
End Class
