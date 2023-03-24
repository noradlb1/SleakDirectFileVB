Imports Microsoft.CSharp
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Tools

Namespace SleakDirectFile
	Partial Public Class encode
		Inherits Form

		Public Sub New()
			InitializeComponent()
			Me.AllowDrop = True
			AddHandler DragEnter, AddressOf encode_DragEnter
			AddHandler DragDrop, AddressOf encode_DragDrop
		End Sub

		Private Sub button1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)

		End Sub

		Private Sub encode_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles MyBase.DragEnter
			If e.Data.GetDataPresent(DataFormats.FileDrop) Then
				e.Effect = DragDropEffects.Copy
			End If
		End Sub

		Private Sub encode_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles MyBase.DragDrop
			Try
				Dim file() As String = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
				Using saveFileDialog As New SaveFileDialog()
					saveFileDialog.Filter = "TXT File (*.txt)|*.txt"
					saveFileDialog.Title = "Save Converted Base64 ..."

					If saveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
						Dim Key() As Byte = Convert.FromBase64String("TxM4zjDL+WrdkYmUb5TvoQ==")

						Dim IV() As Byte = Convert.FromBase64String("e2iOhnoh6dc=")


						Dim encrypt() As Byte = Algroithum.EncryptTripleDES(System.IO.File.ReadAllBytes(file(0)), Key, IV)

						Dim data As String = Convert.ToBase64String(encrypt)
						System.IO.File.WriteAllText(saveFileDialog.FileName, data)

						MessageBox.Show("Raw File Crypted Successfully!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)

					End If
				End Using

			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try
		End Sub

		Private Sub encode_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Me.Hide()
		End Sub

		Private Sub panel1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles panel1.Paint

		End Sub
		Private mouseLocation As Point
		Private Sub mouse_down(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panel1.MouseDown
			mouseLocation = New Point(-e.X, -e.Y)

		End Sub

		Private Sub mouse_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panel1.MouseMove
			If e.Button = MouseButtons.Left Then
				Dim mousePose As Point = Control.MousePosition
				mousePose.Offset(mouseLocation.X, mouseLocation.Y)
				Location = mousePose
			End If
		End Sub
	End Class
End Namespace
