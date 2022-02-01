<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKasutajaAken
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
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst1 = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst2 = New System.Windows.Forms.TextBox()
        Me.lblSisendTekst = New System.Windows.Forms.Label()
        Me.lblValjundTekst1 = New System.Windows.Forms.Label()
        Me.lblValjundTekst2 = New System.Windows.Forms.Label()
        Me.btnPoora1 = New System.Windows.Forms.Button()
        Me.btnPoora2 = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStopp = New System.Windows.Forms.Button()
        Me.timerUuenda = New System.Windows.Forms.Timer(Me.components)
        Me.txtPikkus = New System.Windows.Forms.Label()
        Me.txtTaisHaalik = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValjundTekst12 = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst22 = New System.Windows.Forms.TextBox()
        Me.btnPoora12 = New System.Windows.Forms.Button()
        Me.btnPoora22 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(258, 93)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(250, 26)
        Me.txtSisendTekst.TabIndex = 0
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.Location = New System.Drawing.Point(258, 163)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.Size = New System.Drawing.Size(250, 26)
        Me.txtValjundTekst1.TabIndex = 1
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Location = New System.Drawing.Point(258, 267)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.Size = New System.Drawing.Size(250, 26)
        Me.txtValjundTekst2.TabIndex = 2
        '
        'lblSisendTekst
        '
        Me.lblSisendTekst.AutoSize = True
        Me.lblSisendTekst.Location = New System.Drawing.Point(87, 99)
        Me.lblSisendTekst.Name = "lblSisendTekst"
        Me.lblSisendTekst.Size = New System.Drawing.Size(97, 20)
        Me.lblSisendTekst.TabIndex = 3
        Me.lblSisendTekst.Text = "Sisendtekst:"
        '
        'lblValjundTekst1
        '
        Me.lblValjundTekst1.AutoSize = True
        Me.lblValjundTekst1.Location = New System.Drawing.Point(64, 169)
        Me.lblValjundTekst1.Name = "lblValjundTekst1"
        Me.lblValjundTekst1.Size = New System.Drawing.Size(188, 20)
        Me.lblValjundTekst1.TabIndex = 4
        Me.lblValjundTekst1.Text = "Pööramine funktsiooniga:"
        '
        'lblValjundTekst2
        '
        Me.lblValjundTekst2.AutoSize = True
        Me.lblValjundTekst2.Location = New System.Drawing.Point(64, 273)
        Me.lblValjundTekst2.Name = "lblValjundTekst2"
        Me.lblValjundTekst2.Size = New System.Drawing.Size(191, 20)
        Me.lblValjundTekst2.TabIndex = 5
        Me.lblValjundTekst2.Text = "Pööramine protseduuriga:"
        '
        'btnPoora1
        '
        Me.btnPoora1.Location = New System.Drawing.Point(258, 209)
        Me.btnPoora1.Name = "btnPoora1"
        Me.btnPoora1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnPoora1.Size = New System.Drawing.Size(216, 31)
        Me.btnPoora1.TabIndex = 6
        Me.btnPoora1.Text = "Pööra funktsiooniga"
        Me.btnPoora1.UseVisualStyleBackColor = True
        '
        'btnPoora2
        '
        Me.btnPoora2.Location = New System.Drawing.Point(258, 319)
        Me.btnPoora2.Name = "btnPoora2"
        Me.btnPoora2.Size = New System.Drawing.Size(216, 33)
        Me.btnPoora2.TabIndex = 7
        Me.btnPoora2.Text = "Pööra protseduuriga"
        Me.btnPoora2.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(224, 388)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(91, 30)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStopp
        '
        Me.btnStopp.Location = New System.Drawing.Point(376, 388)
        Me.btnStopp.Name = "btnStopp"
        Me.btnStopp.Size = New System.Drawing.Size(87, 30)
        Me.btnStopp.TabIndex = 9
        Me.btnStopp.Text = "Stop"
        Me.btnStopp.UseVisualStyleBackColor = True
        '
        'timerUuenda
        '
        Me.timerUuenda.Interval = 5000
        '
        'txtPikkus
        '
        Me.txtPikkus.AutoSize = True
        Me.txtPikkus.Location = New System.Drawing.Point(544, 99)
        Me.txtPikkus.Name = "txtPikkus"
        Me.txtPikkus.Size = New System.Drawing.Size(0, 20)
        Me.txtPikkus.TabIndex = 11
        '
        'txtTaisHaalik
        '
        Me.txtTaisHaalik.AutoSize = True
        Me.txtTaisHaalik.Location = New System.Drawing.Point(567, 99)
        Me.txtTaisHaalik.Name = "txtTaisHaalik"
        Me.txtTaisHaalik.Size = New System.Drawing.Size(0, 20)
        Me.txtTaisHaalik.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CTekstiPööraja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(587, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "CAlgoritmilinePööraja"
        '
        'txtValjundTekst12
        '
        Me.txtValjundTekst12.Location = New System.Drawing.Point(571, 163)
        Me.txtValjundTekst12.Name = "txtValjundTekst12"
        Me.txtValjundTekst12.Size = New System.Drawing.Size(200, 26)
        Me.txtValjundTekst12.TabIndex = 16
        '
        'txtValjundTekst22
        '
        Me.txtValjundTekst22.Location = New System.Drawing.Point(571, 267)
        Me.txtValjundTekst22.Name = "txtValjundTekst22"
        Me.txtValjundTekst22.Size = New System.Drawing.Size(200, 26)
        Me.txtValjundTekst22.TabIndex = 17
        '
        'btnPoora12
        '
        Me.btnPoora12.Location = New System.Drawing.Point(571, 209)
        Me.btnPoora12.Name = "btnPoora12"
        Me.btnPoora12.Size = New System.Drawing.Size(170, 32)
        Me.btnPoora12.TabIndex = 18
        Me.btnPoora12.Text = "Pööra funktsiooniga"
        Me.btnPoora12.UseVisualStyleBackColor = True
        '
        'btnPoora22
        '
        Me.btnPoora22.Location = New System.Drawing.Point(571, 320)
        Me.btnPoora22.Name = "btnPoora22"
        Me.btnPoora22.Size = New System.Drawing.Size(170, 32)
        Me.btnPoora22.TabIndex = 19
        Me.btnPoora22.Text = "Pööra protseduuriga"
        Me.btnPoora22.UseVisualStyleBackColor = True
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPoora22)
        Me.Controls.Add(Me.btnPoora12)
        Me.Controls.Add(Me.txtValjundTekst22)
        Me.Controls.Add(Me.txtValjundTekst12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTaisHaalik)
        Me.Controls.Add(Me.txtPikkus)
        Me.Controls.Add(Me.btnStopp)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnPoora2)
        Me.Controls.Add(Me.btnPoora1)
        Me.Controls.Add(Me.lblValjundTekst2)
        Me.Controls.Add(Me.lblValjundTekst1)
        Me.Controls.Add(Me.lblSisendTekst)
        Me.Controls.Add(Me.txtValjundTekst2)
        Me.Controls.Add(Me.txtValjundTekst1)
        Me.Controls.Add(Me.txtSisendTekst)
        Me.Name = "formKasutajaAken"
        Me.Text = "Tekstiöötlus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSisendTekst As TextBox
    Friend WithEvents txtValjundTekst1 As TextBox
    Friend WithEvents txtValjundTekst2 As TextBox
    Friend WithEvents lblSisendTekst As Label
    Friend WithEvents lblValjundTekst1 As Label
    Friend WithEvents lblValjundTekst2 As Label
    Friend WithEvents btnPoora1 As Button
    Friend WithEvents btnPoora2 As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStopp As Button
    Friend WithEvents timerUuenda As Timer
    Friend WithEvents txtPikkus As Label
    Friend WithEvents txtTaisHaalik As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValjundTekst12 As TextBox
    Friend WithEvents txtValjundTekst22 As TextBox
    Friend WithEvents btnPoora12 As Button
    Friend WithEvents btnPoora22 As Button
End Class
