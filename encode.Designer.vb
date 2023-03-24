Namespace SleakDirectFile
	Partial Public Class encode
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.label2 = New System.Windows.Forms.Label()
			Me.button2 = New System.Windows.Forms.Button()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(319, 196)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(158, 30)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Drag and Drop"
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(35)))), (CInt((CByte(35)))))
			Me.panel1.Controls.Add(Me.button2)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(800, 30)
			Me.panel1.TabIndex = 1
'			Me.panel1.Paint += New System.Windows.Forms.PaintEventHandler(Me.panel1_Paint)
'			Me.panel1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.mouse_down)
'			Me.panel1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.mouse_Move)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.Color.White
			Me.label2.Location = New System.Drawing.Point(12, 9)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(77, 13)
			Me.label2.TabIndex = 3
			Me.label2.Text = "SleakDropper"
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button2.Font = New System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button2.ForeColor = System.Drawing.Color.White
			Me.button2.Location = New System.Drawing.Point(761, 1)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(39, 29)
			Me.button2.TabIndex = 4
			Me.button2.Text = "X"
			Me.button2.UseVisualStyleBackColor = False
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' encode
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.ClientSize = New System.Drawing.Size(800, 450)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.label1)
			Me.ForeColor = System.Drawing.Color.White
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "encode"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "encode"
'			Me.Load += New System.EventHandler(Me.encode_Load)
'			Me.DragDrop += New System.Windows.Forms.DragEventHandler(Me.encode_DragDrop)
'			Me.DragEnter += New System.Windows.Forms.DragEventHandler(Me.encode_DragEnter)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private WithEvents panel1 As System.Windows.Forms.Panel
		Private label2 As System.Windows.Forms.Label
		Private WithEvents button2 As System.Windows.Forms.Button
	End Class
End Namespace