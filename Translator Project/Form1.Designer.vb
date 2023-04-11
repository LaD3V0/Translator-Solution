<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cboLang = New System.Windows.Forms.ComboBox()
        Me.gbEnglish = New System.Windows.Forms.GroupBox()
        Me.RadMother = New System.Windows.Forms.RadioButton()
        Me.radBrother = New System.Windows.Forms.RadioButton()
        Me.radFather = New System.Windows.Forms.RadioButton()
        Me.radSister = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.lblTranslated = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbEnglish.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboLang
        '
        Me.cboLang.FormattingEnabled = True
        Me.cboLang.Items.AddRange(New Object() {"French", "Spanish", "Italian"})
        Me.cboLang.Location = New System.Drawing.Point(304, 124)
        Me.cboLang.Name = "cboLang"
        Me.cboLang.Size = New System.Drawing.Size(121, 24)
        Me.cboLang.TabIndex = 0
        '
        'gbEnglish
        '
        Me.gbEnglish.Controls.Add(Me.RadMother)
        Me.gbEnglish.Controls.Add(Me.radBrother)
        Me.gbEnglish.Controls.Add(Me.radFather)
        Me.gbEnglish.Controls.Add(Me.radSister)
        Me.gbEnglish.Location = New System.Drawing.Point(61, 103)
        Me.gbEnglish.Name = "gbEnglish"
        Me.gbEnglish.Size = New System.Drawing.Size(200, 129)
        Me.gbEnglish.TabIndex = 1
        Me.gbEnglish.TabStop = False
        Me.gbEnglish.Text = "English"
        '
        'RadMother
        '
        Me.RadMother.AutoSize = True
        Me.RadMother.Location = New System.Drawing.Point(6, 21)
        Me.RadMother.Name = "RadMother"
        Me.RadMother.Size = New System.Drawing.Size(69, 20)
        Me.RadMother.TabIndex = 2
        Me.RadMother.TabStop = True
        Me.RadMother.Text = "&Mother"
        Me.RadMother.UseVisualStyleBackColor = True
        '
        'radBrother
        '
        Me.radBrother.AutoSize = True
        Me.radBrother.Location = New System.Drawing.Point(6, 99)
        Me.radBrother.Name = "radBrother"
        Me.radBrother.Size = New System.Drawing.Size(71, 20)
        Me.radBrother.TabIndex = 5
        Me.radBrother.TabStop = True
        Me.radBrother.Text = "&Brother"
        Me.radBrother.UseVisualStyleBackColor = True
        '
        'radFather
        '
        Me.radFather.AutoSize = True
        Me.radFather.Location = New System.Drawing.Point(6, 47)
        Me.radFather.Name = "radFather"
        Me.radFather.Size = New System.Drawing.Size(66, 20)
        Me.radFather.TabIndex = 3
        Me.radFather.TabStop = True
        Me.radFather.Text = "&Father"
        Me.radFather.UseVisualStyleBackColor = True
        '
        'radSister
        '
        Me.radSister.AutoSize = True
        Me.radSister.Location = New System.Drawing.Point(6, 73)
        Me.radSister.Name = "radSister"
        Me.radSister.Size = New System.Drawing.Size(62, 20)
        Me.radSister.TabIndex = 4
        Me.radSister.TabStop = True
        Me.radSister.Text = "&Sister"
        Me.radSister.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(301, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "T&ranslate To:"
        '
        'btnTranslate
        '
        Me.btnTranslate.Location = New System.Drawing.Point(477, 96)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(82, 23)
        Me.btnTranslate.TabIndex = 3
        Me.btnTranslate.Text = "Translate"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'lblTranslated
        '
        Me.lblTranslated.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblTranslated.Location = New System.Drawing.Point(304, 155)
        Me.lblTranslated.Name = "lblTranslated"
        Me.lblTranslated.Size = New System.Drawing.Size(121, 77)
        Me.lblTranslated.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(477, 125)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTranslated)
        Me.Controls.Add(Me.btnTranslate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbEnglish)
        Me.Controls.Add(Me.cboLang)
        Me.Name = "frmMain"
        Me.Text = "Main Form"
        Me.gbEnglish.ResumeLayout(False)
        Me.gbEnglish.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboLang As ComboBox
    Friend WithEvents gbEnglish As GroupBox
    Friend WithEvents RadMother As RadioButton
    Friend WithEvents radBrother As RadioButton
    Friend WithEvents radFather As RadioButton
    Friend WithEvents radSister As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTranslate As Button
    Friend WithEvents lblTranslated As Label
    Friend WithEvents btnExit As Button
End Class
