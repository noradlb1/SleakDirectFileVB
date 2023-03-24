Imports KeikoObfuscator
Imports Mono.Cecil
Imports System
Imports System.IO

Namespace SleakDirectFile.Tools
	Friend Class Obfuscate
		Public Shared Function Rename(ByVal path As String) As Boolean
			Try

				Using inputStream = File.OpenRead(path)
					' Read assembly.
					Dim assembly = AssemblyDefinition.ReadAssembly(inputStream)
					Dim logOutput = New ConsoleLogOutput()

					' Obfuscate assembly.
					Obfuscator.Obfuscate(assembly, logOutput)

					' Write obfuscated assembly to disk.
					Dim outputDirectory = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(path), "Obfuscated")
					If Not Directory.Exists(outputDirectory) Then
						Directory.CreateDirectory(outputDirectory)
					End If

					Using outputStream = File.Create(System.IO.Path.Combine(outputDirectory, System.IO.Path.GetFileName(path)))
						assembly.Write(outputStream)
					End Using

					Console.WriteLine("Obfuscated.")
					Return True
				End Using

			Catch er As Exception
				Return False
			End Try
		End Function
	End Class
	Friend Class ConsoleLogOutput
		''''''''Implements ILogOutput

		Public Sub ReportError(ByVal exception As Exception)
			Console.WriteLine(exception.ToString())
		End Sub

		Public Sub WriteMessage(ByVal message As String)
			Console.WriteLine(message)
		End Sub
	End Class
End Namespace
