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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMenuTitle = New System.Windows.Forms.Label()
        Me.rdoWaakye = New System.Windows.Forms.RadioButton()
        Me.rdoBanku = New System.Windows.Forms.RadioButton()
        Me.rdoSpaghetti = New System.Windows.Forms.RadioButton()
        Me.lblExtraTitle = New System.Windows.Forms.Label()
        Me.chkFanta = New System.Windows.Forms.CheckBox()
        Me.chkMalt = New System.Windows.Forms.CheckBox()
        Me.chkChicken = New System.Windows.Forms.CheckBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblFeedBack = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Famous catering"
        '
        'lblMenuTitle
        '
        Me.lblMenuTitle.AutoSize = True
        Me.lblMenuTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuTitle.Location = New System.Drawing.Point(70, 122)
        Me.lblMenuTitle.Name = "lblMenuTitle"
        Me.lblMenuTitle.Size = New System.Drawing.Size(130, 24)
        Me.lblMenuTitle.TabIndex = 1
        Me.lblMenuTitle.Text = "Today's Menu"
        '
        'rdoWaakye
        '
        Me.rdoWaakye.AutoSize = True
        Me.rdoWaakye.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoWaakye.Location = New System.Drawing.Point(80, 176)
        Me.rdoWaakye.Name = "rdoWaakye"
        Me.rdoWaakye.Size = New System.Drawing.Size(171, 28)
        Me.rdoWaakye.TabIndex = 2
        Me.rdoWaakye.TabStop = True
        Me.rdoWaakye.Text = "Waakye - Ghc 75"
        Me.rdoWaakye.UseVisualStyleBackColor = True
        '
        'rdoBanku
        '
        Me.rdoBanku.AutoSize = True
        Me.rdoBanku.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoBanku.Location = New System.Drawing.Point(80, 221)
        Me.rdoBanku.Name = "rdoBanku"
        Me.rdoBanku.Size = New System.Drawing.Size(167, 28)
        Me.rdoBanku.TabIndex = 3
        Me.rdoBanku.TabStop = True
        Me.rdoBanku.Text = "Banku - Ghc 120"
        Me.rdoBanku.UseVisualStyleBackColor = True
        '
        'rdoSpaghetti
        '
        Me.rdoSpaghetti.AutoSize = True
        Me.rdoSpaghetti.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSpaghetti.Location = New System.Drawing.Point(80, 266)
        Me.rdoSpaghetti.Name = "rdoSpaghetti"
        Me.rdoSpaghetti.Size = New System.Drawing.Size(182, 28)
        Me.rdoSpaghetti.TabIndex = 4
        Me.rdoSpaghetti.TabStop = True
        Me.rdoSpaghetti.Text = "Spaghetti - Ghc 55"
        Me.rdoSpaghetti.UseVisualStyleBackColor = True
        '
        'lblExtraTitle
        '
        Me.lblExtraTitle.AutoSize = True
        Me.lblExtraTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtraTitle.Location = New System.Drawing.Point(452, 122)
        Me.lblExtraTitle.Name = "lblExtraTitle"
        Me.lblExtraTitle.Size = New System.Drawing.Size(62, 24)
        Me.lblExtraTitle.TabIndex = 5
        Me.lblExtraTitle.Text = "Extras"
        '
        'chkFanta
        '
        Me.chkFanta.AutoSize = True
        Me.chkFanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFanta.Location = New System.Drawing.Point(456, 176)
        Me.chkFanta.Name = "chkFanta"
        Me.chkFanta.Size = New System.Drawing.Size(152, 28)
        Me.chkFanta.TabIndex = 6
        Me.chkFanta.Text = "Fanta - Ghc 15"
        Me.chkFanta.UseVisualStyleBackColor = True
        '
        'chkMalt
        '
        Me.chkMalt.AutoSize = True
        Me.chkMalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMalt.Location = New System.Drawing.Point(456, 222)
        Me.chkMalt.Name = "chkMalt"
        Me.chkMalt.Size = New System.Drawing.Size(164, 28)
        Me.chkMalt.TabIndex = 7
        Me.chkMalt.Text = "Malt - Ghc 20.25"
        Me.chkMalt.UseVisualStyleBackColor = True
        '
        'chkChicken
        '
        Me.chkChicken.AutoSize = True
        Me.chkChicken.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChicken.Location = New System.Drawing.Point(456, 267)
        Me.chkChicken.Name = "chkChicken"
        Me.chkChicken.Size = New System.Drawing.Size(238, 28)
        Me.chkChicken.TabIndex = 8
        Me.chkChicken.Text = "Extra chicken  Ghc 35.88"
        Me.chkChicken.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(265, 334)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(75, 33)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "0.00"
        '
        'lblFeedBack
        '
        Me.lblFeedBack.AutoSize = True
        Me.lblFeedBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedBack.Location = New System.Drawing.Point(78, 416)
        Me.lblFeedBack.Name = "lblFeedBack"
        Me.lblFeedBack.Size = New System.Drawing.Size(95, 24)
        Me.lblFeedBack.TabIndex = 10
        Me.lblFeedBack.Text = "Feedback"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(456, 491)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 49)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(286, 491)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(148, 49)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate Bill"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 33)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Total (Ghc):"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 571)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblFeedBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.chkChicken)
        Me.Controls.Add(Me.chkMalt)
        Me.Controls.Add(Me.chkFanta)
        Me.Controls.Add(Me.lblExtraTitle)
        Me.Controls.Add(Me.rdoSpaghetti)
        Me.Controls.Add(Me.rdoBanku)
        Me.Controls.Add(Me.rdoWaakye)
        Me.Controls.Add(Me.lblMenuTitle)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Famous Catering"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblMenuTitle As Label
    Friend WithEvents rdoWaakye As RadioButton
    Friend WithEvents rdoBanku As RadioButton
    Friend WithEvents rdoSpaghetti As RadioButton
    Friend WithEvents lblExtraTitle As Label
    Friend WithEvents chkFanta As CheckBox
    Friend WithEvents chkMalt As CheckBox
    Friend WithEvents chkChicken As CheckBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblFeedBack As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label2 As Label
End Class
