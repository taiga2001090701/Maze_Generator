<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LX = New System.Windows.Forms.Label()
        Me.UDX = New System.Windows.Forms.NumericUpDown()
        Me.LY = New System.Windows.Forms.Label()
        Me.UDY = New System.Windows.Forms.NumericUpDown()
        Me.LP1 = New System.Windows.Forms.Label()
        Me.S1 = New System.Windows.Forms.TrackBar()
        Me.LN1 = New System.Windows.Forms.Label()
        Me.LS = New System.Windows.Forms.Label()
        Me.TBS = New System.Windows.Forms.TextBox()
        Me.PB = New System.Windows.Forms.PictureBox()
        Me.BG = New System.Windows.Forms.Button()
        Me.LRP = New System.Windows.Forms.Label()
        Me.LRC = New System.Windows.Forms.Label()
        Me.LP2 = New System.Windows.Forms.Label()
        Me.S2 = New System.Windows.Forms.TrackBar()
        Me.LN2 = New System.Windows.Forms.Label()
        Me.LP3 = New System.Windows.Forms.Label()
        Me.S3 = New System.Windows.Forms.TrackBar()
        Me.LN3 = New System.Windows.Forms.Label()
        CType(Me.UDX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UDY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LX
        '
        Me.LX.AutoSize = True
        Me.LX.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LX.Location = New System.Drawing.Point(12, 14)
        Me.LX.Name = "LX"
        Me.LX.Size = New System.Drawing.Size(76, 22)
        Me.LX.TabIndex = 0
        Me.LX.Text = "横方向"
        '
        'UDX
        '
        Me.UDX.BackColor = System.Drawing.Color.White
        Me.UDX.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.UDX.Location = New System.Drawing.Point(94, 12)
        Me.UDX.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.UDX.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.UDX.Name = "UDX"
        Me.UDX.Size = New System.Drawing.Size(80, 29)
        Me.UDX.TabIndex = 1
        Me.UDX.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'LY
        '
        Me.LY.AutoSize = True
        Me.LY.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LY.Location = New System.Drawing.Point(12, 65)
        Me.LY.Name = "LY"
        Me.LY.Size = New System.Drawing.Size(76, 22)
        Me.LY.TabIndex = 2
        Me.LY.Text = "縦方向"
        '
        'UDY
        '
        Me.UDY.BackColor = System.Drawing.Color.White
        Me.UDY.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.UDY.Location = New System.Drawing.Point(94, 63)
        Me.UDY.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.UDY.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.UDY.Name = "UDY"
        Me.UDY.Size = New System.Drawing.Size(80, 29)
        Me.UDY.TabIndex = 3
        Me.UDY.Value = New Decimal(New Integer() {140, 0, 0, 0})
        '
        'LP1
        '
        Me.LP1.AutoSize = True
        Me.LP1.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LP1.Location = New System.Drawing.Point(12, 116)
        Me.LP1.Name = "LP1"
        Me.LP1.Size = New System.Drawing.Size(76, 22)
        Me.LP1.TabIndex = 4
        Me.LP1.Text = "直進率"
        '
        'S1
        '
        Me.S1.Location = New System.Drawing.Point(94, 114)
        Me.S1.Maximum = 99
        Me.S1.Minimum = 1
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(200, 45)
        Me.S1.TabIndex = 5
        Me.S1.Value = 70
        '
        'LN1
        '
        Me.LN1.AutoSize = True
        Me.LN1.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LN1.Location = New System.Drawing.Point(300, 116)
        Me.LN1.Name = "LN1"
        Me.LN1.Size = New System.Drawing.Size(23, 22)
        Me.LN1.TabIndex = 6
        Me.LN1.Text = "X"
        '
        'LS
        '
        Me.LS.AutoSize = True
        Me.LS.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LS.Location = New System.Drawing.Point(12, 269)
        Me.LS.Name = "LS"
        Me.LS.Size = New System.Drawing.Size(76, 22)
        Me.LS.TabIndex = 13
        Me.LS.Text = "乱数種"
        '
        'TBS
        '
        Me.TBS.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.TBS.Location = New System.Drawing.Point(94, 267)
        Me.TBS.Name = "TBS"
        Me.TBS.Size = New System.Drawing.Size(286, 29)
        Me.TBS.TabIndex = 14
        '
        'PB
        '
        Me.PB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PB.Location = New System.Drawing.Point(386, 12)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(402, 402)
        Me.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB.TabIndex = 15
        Me.PB.TabStop = False
        '
        'BG
        '
        Me.BG.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.BG.Location = New System.Drawing.Point(16, 310)
        Me.BG.Name = "BG"
        Me.BG.Size = New System.Drawing.Size(364, 40)
        Me.BG.TabIndex = 16
        Me.BG.Text = "Generate"
        Me.BG.UseVisualStyleBackColor = True
        '
        'LRP
        '
        Me.LRP.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LRP.Location = New System.Drawing.Point(180, 14)
        Me.LRP.Margin = New System.Windows.Forms.Padding(3)
        Me.LRP.Name = "LRP"
        Me.LRP.Size = New System.Drawing.Size(200, 22)
        Me.LRP.TabIndex = 17
        Me.LRP.Text = "(X, Y)"
        Me.LRP.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LRC
        '
        Me.LRC.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LRC.Location = New System.Drawing.Point(180, 65)
        Me.LRC.Margin = New System.Windows.Forms.Padding(3)
        Me.LRC.Name = "LRC"
        Me.LRC.Size = New System.Drawing.Size(200, 22)
        Me.LRC.TabIndex = 18
        Me.LRC.Text = "0 / 0"
        Me.LRC.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LP2
        '
        Me.LP2.AutoSize = True
        Me.LP2.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LP2.Location = New System.Drawing.Point(12, 167)
        Me.LP2.Name = "LP2"
        Me.LP2.Size = New System.Drawing.Size(76, 22)
        Me.LP2.TabIndex = 7
        Me.LP2.Text = "直角率"
        '
        'S2
        '
        Me.S2.Location = New System.Drawing.Point(94, 165)
        Me.S2.Maximum = 100
        Me.S2.Name = "S2"
        Me.S2.Size = New System.Drawing.Size(200, 45)
        Me.S2.TabIndex = 8
        Me.S2.Value = 10
        '
        'LN2
        '
        Me.LN2.AutoSize = True
        Me.LN2.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LN2.Location = New System.Drawing.Point(300, 167)
        Me.LN2.Name = "LN2"
        Me.LN2.Size = New System.Drawing.Size(23, 22)
        Me.LN2.TabIndex = 9
        Me.LN2.Text = "X"
        '
        'LP3
        '
        Me.LP3.AutoSize = True
        Me.LP3.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LP3.Location = New System.Drawing.Point(12, 218)
        Me.LP3.Name = "LP3"
        Me.LP3.Size = New System.Drawing.Size(76, 22)
        Me.LP3.TabIndex = 10
        Me.LP3.Text = "分岐率"
        '
        'S3
        '
        Me.S3.Location = New System.Drawing.Point(94, 216)
        Me.S3.Maximum = 100
        Me.S3.Name = "S3"
        Me.S3.Size = New System.Drawing.Size(200, 45)
        Me.S3.TabIndex = 11
        Me.S3.Value = 20
        '
        'LN3
        '
        Me.LN3.AutoSize = True
        Me.LN3.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.LN3.Location = New System.Drawing.Point(300, 218)
        Me.LN3.Name = "LN3"
        Me.LN3.Size = New System.Drawing.Size(23, 22)
        Me.LN3.TabIndex = 12
        Me.LN3.Text = "X"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 426)
        Me.Controls.Add(Me.LRC)
        Me.Controls.Add(Me.LRP)
        Me.Controls.Add(Me.BG)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.TBS)
        Me.Controls.Add(Me.LS)
        Me.Controls.Add(Me.LN3)
        Me.Controls.Add(Me.S3)
        Me.Controls.Add(Me.LP3)
        Me.Controls.Add(Me.LN2)
        Me.Controls.Add(Me.S2)
        Me.Controls.Add(Me.LP2)
        Me.Controls.Add(Me.LN1)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.LP1)
        Me.Controls.Add(Me.UDY)
        Me.Controls.Add(Me.LY)
        Me.Controls.Add(Me.UDX)
        Me.Controls.Add(Me.LX)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.UDX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UDY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LX As Label
    Friend WithEvents UDX As NumericUpDown
    Friend WithEvents LY As Label
    Friend WithEvents UDY As NumericUpDown
    Friend WithEvents LP1 As Label
    Friend WithEvents S1 As TrackBar
    Friend WithEvents LN1 As Label
    Friend WithEvents LS As Label
    Friend WithEvents TBS As TextBox
    Friend WithEvents PB As PictureBox
    Friend WithEvents BG As Button
    Friend WithEvents LRP As Label
    Friend WithEvents LRC As Label
    Friend WithEvents LP2 As Label
    Friend WithEvents S2 As TrackBar
    Friend WithEvents LN2 As Label
    Friend WithEvents LP3 As Label
    Friend WithEvents S3 As TrackBar
    Friend WithEvents LN3 As Label
End Class
