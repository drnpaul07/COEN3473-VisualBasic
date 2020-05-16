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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addressTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ageTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.jsonBtn = New System.Windows.Forms.Button()
        Me.xmlBtn = New System.Windows.Forms.Button()
        Me.txtBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.addressTB)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ageTB)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.nameTB)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(17, 16)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 190)
        Me.Panel1.TabIndex = 0
        '
        'addressTB
        '
        Me.addressTB.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTB.Location = New System.Drawing.Point(100, 121)
        Me.addressTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.addressTB.Name = "addressTB"
        Me.addressTB.Size = New System.Drawing.Size(225, 26)
        Me.addressTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tempus Sans ITC", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address:"
        '
        'ageTB
        '
        Me.ageTB.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageTB.Location = New System.Drawing.Point(100, 68)
        Me.ageTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ageTB.MaxLength = 3
        Me.ageTB.Name = "ageTB"
        Me.ageTB.Size = New System.Drawing.Size(225, 26)
        Me.ageTB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Age:"
        '
        'nameTB
        '
        Me.nameTB.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTB.Location = New System.Drawing.Point(100, 17)
        Me.nameTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nameTB.Name = "nameTB"
        Me.nameTB.Size = New System.Drawing.Size(225, 26)
        Me.nameTB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.jsonBtn)
        Me.Panel2.Controls.Add(Me.xmlBtn)
        Me.Panel2.Controls.Add(Me.txtBtn)
        Me.Panel2.Location = New System.Drawing.Point(17, 226)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(345, 123)
        Me.Panel2.TabIndex = 1
        '
        'jsonBtn
        '
        Me.jsonBtn.BackColor = System.Drawing.Color.Aquamarine
        Me.jsonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.jsonBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.jsonBtn.FlatAppearance.BorderSize = 2
        Me.jsonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.jsonBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jsonBtn.ForeColor = System.Drawing.Color.RoyalBlue
        Me.jsonBtn.Location = New System.Drawing.Point(243, 36)
        Me.jsonBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.jsonBtn.Name = "jsonBtn"
        Me.jsonBtn.Size = New System.Drawing.Size(84, 43)
        Me.jsonBtn.TabIndex = 2
        Me.jsonBtn.Text = "JSON"
        Me.jsonBtn.UseVisualStyleBackColor = False
        '
        'xmlBtn
        '
        Me.xmlBtn.BackColor = System.Drawing.Color.Aquamarine
        Me.xmlBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.xmlBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.xmlBtn.FlatAppearance.BorderSize = 2
        Me.xmlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.xmlBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xmlBtn.ForeColor = System.Drawing.Color.RoyalBlue
        Me.xmlBtn.Location = New System.Drawing.Point(129, 36)
        Me.xmlBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xmlBtn.Name = "xmlBtn"
        Me.xmlBtn.Size = New System.Drawing.Size(84, 43)
        Me.xmlBtn.TabIndex = 1
        Me.xmlBtn.Text = "XML"
        Me.xmlBtn.UseVisualStyleBackColor = False
        '
        'txtBtn
        '
        Me.txtBtn.BackColor = System.Drawing.Color.Aquamarine
        Me.txtBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.txtBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtBtn.FlatAppearance.BorderSize = 2
        Me.txtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBtn.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtBtn.Location = New System.Drawing.Point(20, 36)
        Me.txtBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBtn.Name = "txtBtn"
        Me.txtBtn.Size = New System.Drawing.Size(84, 43)
        Me.txtBtn.TabIndex = 0
        Me.txtBtn.Text = "TXT"
        Me.txtBtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(379, 383)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents addressTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ageTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nameTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents jsonBtn As Button
    Friend WithEvents xmlBtn As Button
    Friend WithEvents txtBtn As Button
End Class
