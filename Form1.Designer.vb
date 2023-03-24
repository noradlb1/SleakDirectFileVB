Namespace SleakDirectFile
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.url = New System.Windows.Forms.Label()
			Me.button2 = New System.Windows.Forms.Button()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.button3 = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.terms = New System.Windows.Forms.CheckBox()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(128, 52)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(182, 20)
			Me.textBox1.TabIndex = 0
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button1.Font = New System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.White
			Me.button1.Location = New System.Drawing.Point(328, 50)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Build"
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' url
			' 
			Me.url.AutoSize = True
			Me.url.Font = New System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.url.ForeColor = System.Drawing.Color.White
			Me.url.Location = New System.Drawing.Point(27, 55)
			Me.url.Name = "url"
			Me.url.Size = New System.Drawing.Size(95, 13)
			Me.url.TabIndex = 2
			Me.url.Text = "Direct File Link  : "
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button2.Font = New System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button2.ForeColor = System.Drawing.Color.White
			Me.button2.Location = New System.Drawing.Point(178, 90)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(75, 23)
			Me.button2.TabIndex = 3
			Me.button2.Text = "ENCODE"
			Me.button2.UseVisualStyleBackColor = False
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.panel1.Controls.Add(Me.button3)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(457, 25)
			Me.panel1.TabIndex = 4
'			Me.panel1.Paint += New System.Windows.Forms.PaintEventHandler(Me.panel1_Paint)
'			Me.panel1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.mousedown)
'			Me.panel1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.mouse_Move)
			' 
			' button3
			' 
			Me.button3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button3.Font = New System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button3.ForeColor = System.Drawing.Color.White
			Me.button3.Location = New System.Drawing.Point(418, 0)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(39, 25)
			Me.button3.TabIndex = 5
			Me.button3.Text = "X"
			Me.button3.UseVisualStyleBackColor = False
'			Me.button3.Click += New System.EventHandler(Me.button3_Click)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.White
			Me.label1.Location = New System.Drawing.Point(3, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(77, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "SleakDropper"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.Color.White
			Me.label2.Location = New System.Drawing.Point(12, 103)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(111, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Upload Base64 Data"
'			Me.label2.Click += New System.EventHandler(Me.label2_Click)
			' 
			' terms
			' 
			Me.terms.AutoSize = True
			Me.terms.ForeColor = System.Drawing.Color.White
			Me.terms.Location = New System.Drawing.Point(270, 94)
			Me.terms.Name = "terms"
			Me.terms.Size = New System.Drawing.Size(183, 17)
			Me.terms.TabIndex = 5
			Me.terms.Text = "I accept the rules and regulations"
			Me.terms.UseVisualStyleBackColor = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(35)))), (CInt((CByte(35)))))
			Me.ClientSize = New System.Drawing.Size(457, 125)
			Me.Controls.Add(Me.terms)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.url)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.textBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Builder"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private textBox1 As System.Windows.Forms.TextBox
		Private WithEvents button1 As System.Windows.Forms.Button
		Private url As System.Windows.Forms.Label
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents panel1 As System.Windows.Forms.Panel
		Private label1 As System.Windows.Forms.Label
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents label2 As System.Windows.Forms.Label
		Private terms As System.Windows.Forms.CheckBox
	End Class
End Namespace

