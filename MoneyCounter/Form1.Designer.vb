<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Dime = New System.Windows.Forms.PictureBox()
        Me.Penny = New System.Windows.Forms.PictureBox()
        Me.Nickel = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TotalValue = New System.Windows.Forms.Label()
        Me.DollarCount = New System.Windows.Forms.Label()
        Me.HalfDollarCount = New System.Windows.Forms.Label()
        Me.QuarterCount = New System.Windows.Forms.Label()
        Me.DimeCount = New System.Windows.Forms.Label()
        Me.NickelCount = New System.Windows.Forms.Label()
        Me.PennyCount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Quarter = New System.Windows.Forms.PictureBox()
        Me.HalfDollar = New System.Windows.Forms.PictureBox()
        Me.Dollar = New System.Windows.Forms.PictureBox()
        CType(Me.Dime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Penny, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nickel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Quarter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HalfDollar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dollar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dime
        '
        Me.Dime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dime.Image = CType(resources.GetObject("Dime.Image"), System.Drawing.Image)
        Me.Dime.Location = New System.Drawing.Point(124, 12)
        Me.Dime.Name = "Dime"
        Me.Dime.Size = New System.Drawing.Size(50, 50)
        Me.Dime.TabIndex = 0
        Me.Dime.TabStop = False
        '
        'Penny
        '
        Me.Penny.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Penny.Image = CType(resources.GetObject("Penny.Image"), System.Drawing.Image)
        Me.Penny.Location = New System.Drawing.Point(12, 12)
        Me.Penny.Name = "Penny"
        Me.Penny.Size = New System.Drawing.Size(50, 50)
        Me.Penny.TabIndex = 1
        Me.Penny.TabStop = False
        '
        'Nickel
        '
        Me.Nickel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Nickel.Image = CType(resources.GetObject("Nickel.Image"), System.Drawing.Image)
        Me.Nickel.Location = New System.Drawing.Point(68, 12)
        Me.Nickel.Name = "Nickel"
        Me.Nickel.Size = New System.Drawing.Size(50, 50)
        Me.Nickel.TabIndex = 2
        Me.Nickel.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TotalValue)
        Me.GroupBox1.Controls.Add(Me.DollarCount)
        Me.GroupBox1.Controls.Add(Me.HalfDollarCount)
        Me.GroupBox1.Controls.Add(Me.QuarterCount)
        Me.GroupBox1.Controls.Add(Me.DimeCount)
        Me.GroupBox1.Controls.Add(Me.NickelCount)
        Me.GroupBox1.Controls.Add(Me.PennyCount)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 145)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totals"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(118, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "$"
        '
        'TotalValue
        '
        Me.TotalValue.AutoSize = True
        Me.TotalValue.Location = New System.Drawing.Point(129, 126)
        Me.TotalValue.Name = "TotalValue"
        Me.TotalValue.Size = New System.Drawing.Size(28, 13)
        Me.TotalValue.TabIndex = 13
        Me.TotalValue.Text = "0.00"
        '
        'DollarCount
        '
        Me.DollarCount.AutoSize = True
        Me.DollarCount.Location = New System.Drawing.Point(118, 105)
        Me.DollarCount.Name = "DollarCount"
        Me.DollarCount.Size = New System.Drawing.Size(13, 13)
        Me.DollarCount.TabIndex = 12
        Me.DollarCount.Text = "0"
        '
        'HalfDollarCount
        '
        Me.HalfDollarCount.AutoSize = True
        Me.HalfDollarCount.Location = New System.Drawing.Point(118, 88)
        Me.HalfDollarCount.Name = "HalfDollarCount"
        Me.HalfDollarCount.Size = New System.Drawing.Size(13, 13)
        Me.HalfDollarCount.TabIndex = 11
        Me.HalfDollarCount.Text = "0"
        '
        'QuarterCount
        '
        Me.QuarterCount.AutoSize = True
        Me.QuarterCount.Location = New System.Drawing.Point(118, 71)
        Me.QuarterCount.Name = "QuarterCount"
        Me.QuarterCount.Size = New System.Drawing.Size(13, 13)
        Me.QuarterCount.TabIndex = 10
        Me.QuarterCount.Text = "0"
        '
        'DimeCount
        '
        Me.DimeCount.AutoSize = True
        Me.DimeCount.Location = New System.Drawing.Point(118, 54)
        Me.DimeCount.Name = "DimeCount"
        Me.DimeCount.Size = New System.Drawing.Size(13, 13)
        Me.DimeCount.TabIndex = 9
        Me.DimeCount.Text = "0"
        '
        'NickelCount
        '
        Me.NickelCount.AutoSize = True
        Me.NickelCount.Location = New System.Drawing.Point(118, 37)
        Me.NickelCount.Name = "NickelCount"
        Me.NickelCount.Size = New System.Drawing.Size(13, 13)
        Me.NickelCount.TabIndex = 8
        Me.NickelCount.Text = "0"
        '
        'PennyCount
        '
        Me.PennyCount.AutoSize = True
        Me.PennyCount.Location = New System.Drawing.Point(118, 20)
        Me.PennyCount.Name = "PennyCount"
        Me.PennyCount.Size = New System.Drawing.Size(13, 13)
        Me.PennyCount.TabIndex = 7
        Me.PennyCount.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Cash Value: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dollars: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Half Dollars: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quarters: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dimes: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nickels: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pennies: "
        '
        'Quarter
        '
        Me.Quarter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Quarter.Image = CType(resources.GetObject("Quarter.Image"), System.Drawing.Image)
        Me.Quarter.Location = New System.Drawing.Point(180, 12)
        Me.Quarter.Name = "Quarter"
        Me.Quarter.Size = New System.Drawing.Size(50, 50)
        Me.Quarter.TabIndex = 4
        Me.Quarter.TabStop = False
        '
        'HalfDollar
        '
        Me.HalfDollar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HalfDollar.Image = CType(resources.GetObject("HalfDollar.Image"), System.Drawing.Image)
        Me.HalfDollar.Location = New System.Drawing.Point(236, 12)
        Me.HalfDollar.Name = "HalfDollar"
        Me.HalfDollar.Size = New System.Drawing.Size(50, 50)
        Me.HalfDollar.TabIndex = 5
        Me.HalfDollar.TabStop = False
        '
        'Dollar
        '
        Me.Dollar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dollar.Image = CType(resources.GetObject("Dollar.Image"), System.Drawing.Image)
        Me.Dollar.Location = New System.Drawing.Point(292, 12)
        Me.Dollar.Name = "Dollar"
        Me.Dollar.Size = New System.Drawing.Size(50, 50)
        Me.Dollar.TabIndex = 6
        Me.Dollar.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 226)
        Me.Controls.Add(Me.Dollar)
        Me.Controls.Add(Me.HalfDollar)
        Me.Controls.Add(Me.Quarter)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Nickel)
        Me.Controls.Add(Me.Penny)
        Me.Controls.Add(Me.Dime)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Money Counter"
        CType(Me.Dime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Penny, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nickel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Quarter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HalfDollar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dollar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dime As System.Windows.Forms.PictureBox
    Friend WithEvents Penny As System.Windows.Forms.PictureBox
    Friend WithEvents Nickel As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Quarter As System.Windows.Forms.PictureBox
    Friend WithEvents HalfDollar As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TotalValue As System.Windows.Forms.Label
    Friend WithEvents DollarCount As System.Windows.Forms.Label
    Friend WithEvents HalfDollarCount As System.Windows.Forms.Label
    Friend WithEvents QuarterCount As System.Windows.Forms.Label
    Friend WithEvents DimeCount As System.Windows.Forms.Label
    Friend WithEvents NickelCount As System.Windows.Forms.Label
    Friend WithEvents PennyCount As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dollar As System.Windows.Forms.PictureBox

End Class
