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
        Me.cappuccinoQuantity = New System.Windows.Forms.NumericUpDown()
        Me.latteQuantity = New System.Windows.Forms.NumericUpDown()
        Me.espressoQuantity = New System.Windows.Forms.NumericUpDown()
        Me.icedQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cappuccinoTotal = New System.Windows.Forms.Label()
        Me.espressoTotal = New System.Windows.Forms.Label()
        Me.latteTotal = New System.Windows.Forms.Label()
        Me.icedTotal = New System.Windows.Forms.Label()
        Me.TaxMultiplier = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.costBeforeTax = New System.Windows.Forms.Label()
        Me.TaxTotal = New System.Windows.Forms.Label()
        Me.grandTotal = New System.Windows.Forms.Label()
        Me.TotalQuantities = New System.Windows.Forms.Button()
        Me.CalculateCosts = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.takeawayCheckbox = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ResetOrder = New System.Windows.Forms.Button()
        Me.resetDailyTotalsButton = New System.Windows.Forms.Button()
        CType(Me.cappuccinoQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.latteQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.espressoQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icedQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cappuccinoQuantity
        '
        Me.cappuccinoQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cappuccinoQuantity.Location = New System.Drawing.Point(145, 97)
        Me.cappuccinoQuantity.Name = "cappuccinoQuantity"
        Me.cappuccinoQuantity.Size = New System.Drawing.Size(120, 31)
        Me.cappuccinoQuantity.TabIndex = 0
        '
        'latteQuantity
        '
        Me.latteQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.latteQuantity.Location = New System.Drawing.Point(145, 168)
        Me.latteQuantity.Name = "latteQuantity"
        Me.latteQuantity.Size = New System.Drawing.Size(120, 31)
        Me.latteQuantity.TabIndex = 1
        '
        'espressoQuantity
        '
        Me.espressoQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.espressoQuantity.Location = New System.Drawing.Point(145, 132)
        Me.espressoQuantity.Name = "espressoQuantity"
        Me.espressoQuantity.Size = New System.Drawing.Size(120, 31)
        Me.espressoQuantity.TabIndex = 2
        '
        'icedQuantity
        '
        Me.icedQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icedQuantity.Location = New System.Drawing.Point(145, 205)
        Me.icedQuantity.Name = "icedQuantity"
        Me.icedQuantity.Size = New System.Drawing.Size(120, 31)
        Me.icedQuantity.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cappuccino"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-2, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Espresso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-2, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Latte"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-2, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Iced"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-2, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 30)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Takeaway?"
        '
        'cappuccinoTotal
        '
        Me.cappuccinoTotal.AutoSize = True
        Me.cappuccinoTotal.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cappuccinoTotal.Location = New System.Drawing.Point(460, 97)
        Me.cappuccinoTotal.Name = "cappuccinoTotal"
        Me.cappuccinoTotal.Size = New System.Drawing.Size(27, 23)
        Me.cappuccinoTotal.TabIndex = 10
        Me.cappuccinoTotal.Text = "$0"
        '
        'espressoTotal
        '
        Me.espressoTotal.AutoSize = True
        Me.espressoTotal.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.espressoTotal.Location = New System.Drawing.Point(460, 135)
        Me.espressoTotal.Name = "espressoTotal"
        Me.espressoTotal.Size = New System.Drawing.Size(27, 23)
        Me.espressoTotal.TabIndex = 11
        Me.espressoTotal.Text = "$0"
        '
        'latteTotal
        '
        Me.latteTotal.AutoSize = True
        Me.latteTotal.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.latteTotal.Location = New System.Drawing.Point(460, 171)
        Me.latteTotal.Name = "latteTotal"
        Me.latteTotal.Size = New System.Drawing.Size(27, 23)
        Me.latteTotal.TabIndex = 12
        Me.latteTotal.Text = "$0"
        '
        'icedTotal
        '
        Me.icedTotal.AutoSize = True
        Me.icedTotal.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icedTotal.Location = New System.Drawing.Point(460, 208)
        Me.icedTotal.Name = "icedTotal"
        Me.icedTotal.Size = New System.Drawing.Size(27, 23)
        Me.icedTotal.TabIndex = 13
        Me.icedTotal.Text = "$0"
        '
        'TaxMultiplier
        '
        Me.TaxMultiplier.AutoSize = True
        Me.TaxMultiplier.Font = New System.Drawing.Font("Gill Sans MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxMultiplier.Location = New System.Drawing.Point(277, 258)
        Me.TaxMultiplier.Name = "TaxMultiplier"
        Me.TaxMultiplier.Size = New System.Drawing.Size(33, 27)
        Me.TaxMultiplier.TabIndex = 14
        Me.TaxMultiplier.Text = "5%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gill Sans MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(278, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "$3.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gill Sans MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(278, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "$2.25"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gill Sans MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(278, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "$2.50"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gill Sans MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(278, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "$2.50"
        '
        'costBeforeTax
        '
        Me.costBeforeTax.AutoSize = True
        Me.costBeforeTax.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costBeforeTax.Location = New System.Drawing.Point(460, 261)
        Me.costBeforeTax.Name = "costBeforeTax"
        Me.costBeforeTax.Size = New System.Drawing.Size(27, 23)
        Me.costBeforeTax.TabIndex = 19
        Me.costBeforeTax.Text = "$0"
        '
        'TaxTotal
        '
        Me.TaxTotal.AutoSize = True
        Me.TaxTotal.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxTotal.Location = New System.Drawing.Point(460, 284)
        Me.TaxTotal.Name = "TaxTotal"
        Me.TaxTotal.Size = New System.Drawing.Size(27, 23)
        Me.TaxTotal.TabIndex = 20
        Me.TaxTotal.Text = "$0"
        '
        'grandTotal
        '
        Me.grandTotal.AutoSize = True
        Me.grandTotal.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grandTotal.Location = New System.Drawing.Point(460, 307)
        Me.grandTotal.Name = "grandTotal"
        Me.grandTotal.Size = New System.Drawing.Size(27, 23)
        Me.grandTotal.TabIndex = 21
        Me.grandTotal.Text = "$0"
        '
        'TotalQuantities
        '
        Me.TotalQuantities.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalQuantities.Location = New System.Drawing.Point(301, 348)
        Me.TotalQuantities.Name = "TotalQuantities"
        Me.TotalQuantities.Size = New System.Drawing.Size(126, 39)
        Me.TotalQuantities.TabIndex = 22
        Me.TotalQuantities.Text = "Check Daily Totals"
        Me.TotalQuantities.UseVisualStyleBackColor = True
        '
        'CalculateCosts
        '
        Me.CalculateCosts.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateCosts.Location = New System.Drawing.Point(3, 348)
        Me.CalculateCosts.Name = "CalculateCosts"
        Me.CalculateCosts.Size = New System.Drawing.Size(88, 39)
        Me.CalculateCosts.TabIndex = 23
        Me.CalculateCosts.Text = "Purchase"
        Me.CalculateCosts.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(340, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 23)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Price before tax"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(369, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 23)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Grand total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(419, 284)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 23)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Tax"
        '
        'takeawayCheckbox
        '
        Me.takeawayCheckbox.AutoSize = True
        Me.takeawayCheckbox.Location = New System.Drawing.Point(145, 267)
        Me.takeawayCheckbox.Name = "takeawayCheckbox"
        Me.takeawayCheckbox.Size = New System.Drawing.Size(15, 14)
        Me.takeawayCheckbox.TabIndex = 27
        Me.takeawayCheckbox.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(-1, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(153, 21)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Coffee Types"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(278, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 21)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Cost"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(415, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 21)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Total"
        '
        'ResetOrder
        '
        Me.ResetOrder.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetOrder.Location = New System.Drawing.Point(97, 348)
        Me.ResetOrder.Name = "ResetOrder"
        Me.ResetOrder.Size = New System.Drawing.Size(88, 39)
        Me.ResetOrder.TabIndex = 31
        Me.ResetOrder.Text = "Reset Order"
        Me.ResetOrder.UseVisualStyleBackColor = True
        '
        'resetDailyTotalsButton
        '
        Me.resetDailyTotalsButton.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetDailyTotalsButton.Location = New System.Drawing.Point(433, 348)
        Me.resetDailyTotalsButton.Name = "resetDailyTotalsButton"
        Me.resetDailyTotalsButton.Size = New System.Drawing.Size(88, 39)
        Me.resetDailyTotalsButton.TabIndex = 32
        Me.resetDailyTotalsButton.Text = "Reset Totals"
        Me.resetDailyTotalsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 399)
        Me.Controls.Add(Me.resetDailyTotalsButton)
        Me.Controls.Add(Me.ResetOrder)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.takeawayCheckbox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CalculateCosts)
        Me.Controls.Add(Me.TotalQuantities)
        Me.Controls.Add(Me.grandTotal)
        Me.Controls.Add(Me.TaxTotal)
        Me.Controls.Add(Me.costBeforeTax)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TaxMultiplier)
        Me.Controls.Add(Me.icedTotal)
        Me.Controls.Add(Me.latteTotal)
        Me.Controls.Add(Me.espressoTotal)
        Me.Controls.Add(Me.cappuccinoTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.icedQuantity)
        Me.Controls.Add(Me.espressoQuantity)
        Me.Controls.Add(Me.latteQuantity)
        Me.Controls.Add(Me.cappuccinoQuantity)
        Me.Name = "Form1"
        Me.Text = "Café au Bean "
        CType(Me.cappuccinoQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.latteQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.espressoQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icedQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cappuccinoQuantity As NumericUpDown
    Friend WithEvents latteQuantity As NumericUpDown
    Friend WithEvents espressoQuantity As NumericUpDown
    Friend WithEvents icedQuantity As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cappuccinoTotal As Label
    Friend WithEvents espressoTotal As Label
    Friend WithEvents latteTotal As Label
    Friend WithEvents icedTotal As Label
    Friend WithEvents TaxMultiplier As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents costBeforeTax As Label
    Friend WithEvents TaxTotal As Label
    Friend WithEvents grandTotal As Label
    Friend WithEvents TotalQuantities As Button
    Friend WithEvents CalculateCosts As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents takeawayCheckbox As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ResetOrder As Button
    Friend WithEvents resetDailyTotalsButton As Button
End Class
