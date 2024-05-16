<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEdit))
        Me.txtGameName = New System.Windows.Forms.TextBox()
        Me.txtGameYear = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.comboGamePlatform = New System.Windows.Forms.ComboBox()
        Me.comboGameMediaType = New System.Windows.Forms.ComboBox()
        Me.labelGameName = New System.Windows.Forms.Label()
        Me.labelGameYear = New System.Windows.Forms.Label()
        Me.labelGamePlatform = New System.Windows.Forms.Label()
        Me.labelGameMediaType = New System.Windows.Forms.Label()
        Me.labelGame = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtGameName
        '
        Me.txtGameName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGameName.Location = New System.Drawing.Point(309, 82)
        Me.txtGameName.Name = "txtGameName"
        Me.txtGameName.Size = New System.Drawing.Size(245, 23)
        Me.txtGameName.TabIndex = 0
        '
        'txtGameYear
        '
        Me.txtGameYear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGameYear.Location = New System.Drawing.Point(309, 130)
        Me.txtGameYear.Name = "txtGameYear"
        Me.txtGameYear.Size = New System.Drawing.Size(245, 23)
        Me.txtGameYear.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnSave.Location = New System.Drawing.Point(210, 300)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 24)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnCancel.Location = New System.Drawing.Point(434, 300)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 24)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'comboGamePlatform
        '
        Me.comboGamePlatform.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboGamePlatform.FormattingEnabled = True
        Me.comboGamePlatform.Items.AddRange(New Object() {"PC", "Xbox", "Xbox 360", "Xbox One", "Xbox Series X/S", "Playstation", "Playstation 2", "Playstation 3", "Playstation 4", "Playstation 5", "NES", "SNES", "N64", "Gamecube", "Wii", "Wii U", "Switch", "Gameboy", "Gameboy Color", "Gameboy Advance", "DS", "3DS", "Mobile"})
        Me.comboGamePlatform.Location = New System.Drawing.Point(309, 181)
        Me.comboGamePlatform.MaxDropDownItems = 20
        Me.comboGamePlatform.Name = "comboGamePlatform"
        Me.comboGamePlatform.Size = New System.Drawing.Size(245, 23)
        Me.comboGamePlatform.TabIndex = 6
        '
        'comboGameMediaType
        '
        Me.comboGameMediaType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboGameMediaType.FormattingEnabled = True
        Me.comboGameMediaType.Items.AddRange(New Object() {"Disk", "Cartridge", "Digital"})
        Me.comboGameMediaType.Location = New System.Drawing.Point(309, 230)
        Me.comboGameMediaType.Name = "comboGameMediaType"
        Me.comboGameMediaType.Size = New System.Drawing.Size(245, 23)
        Me.comboGameMediaType.TabIndex = 7
        '
        'labelGameName
        '
        Me.labelGameName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelGameName.AutoSize = True
        Me.labelGameName.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.labelGameName.Location = New System.Drawing.Point(210, 85)
        Me.labelGameName.Name = "labelGameName"
        Me.labelGameName.Size = New System.Drawing.Size(73, 15)
        Me.labelGameName.TabIndex = 8
        Me.labelGameName.Text = "Game Name"
        '
        'labelGameYear
        '
        Me.labelGameYear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelGameYear.AutoSize = True
        Me.labelGameYear.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.labelGameYear.Location = New System.Drawing.Point(220, 133)
        Me.labelGameYear.Name = "labelGameYear"
        Me.labelGameYear.Size = New System.Drawing.Size(63, 15)
        Me.labelGameYear.TabIndex = 9
        Me.labelGameYear.Text = "Game Year"
        '
        'labelGamePlatform
        '
        Me.labelGamePlatform.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelGamePlatform.AutoSize = True
        Me.labelGamePlatform.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.labelGamePlatform.Location = New System.Drawing.Point(202, 184)
        Me.labelGamePlatform.Name = "labelGamePlatform"
        Me.labelGamePlatform.Size = New System.Drawing.Size(87, 15)
        Me.labelGamePlatform.TabIndex = 10
        Me.labelGamePlatform.Text = "Game Platform"
        '
        'labelGameMediaType
        '
        Me.labelGameMediaType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelGameMediaType.AutoSize = True
        Me.labelGameMediaType.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.labelGameMediaType.Location = New System.Drawing.Point(188, 233)
        Me.labelGameMediaType.Name = "labelGameMediaType"
        Me.labelGameMediaType.Size = New System.Drawing.Size(101, 15)
        Me.labelGameMediaType.TabIndex = 11
        Me.labelGameMediaType.Text = "Game Media Type"
        '
        'labelGame
        '
        Me.labelGame.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelGame.AutoSize = True
        Me.labelGame.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelGame.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.labelGame.Location = New System.Drawing.Point(49, 9)
        Me.labelGame.Name = "labelGame"
        Me.labelGame.Size = New System.Drawing.Size(628, 60)
        Me.labelGame.TabIndex = 12
        Me.labelGame.Text = "********************* Game"
        Me.labelGame.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(727, 377)
        Me.Controls.Add(Me.labelGame)
        Me.Controls.Add(Me.labelGameMediaType)
        Me.Controls.Add(Me.labelGamePlatform)
        Me.Controls.Add(Me.labelGameYear)
        Me.Controls.Add(Me.labelGameName)
        Me.Controls.Add(Me.comboGameMediaType)
        Me.Controls.Add(Me.comboGamePlatform)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtGameYear)
        Me.Controls.Add(Me.txtGameName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddEdit"
        Me.Text = "frmAddEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGameName As TextBox
    Friend WithEvents txtGameYear As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents comboGamePlatform As ComboBox
    Friend WithEvents comboGameMediaType As ComboBox
    Friend WithEvents labelGameName As Label
    Friend WithEvents labelGameYear As Label
    Friend WithEvents labelGamePlatform As Label
    Friend WithEvents labelGameMediaType As Label
    Friend WithEvents labelGame As Label
End Class
