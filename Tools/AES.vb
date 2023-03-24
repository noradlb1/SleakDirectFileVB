Imports System.IO
Imports System.Security.Cryptography


Namespace Tools
	Friend Class Algroithum
		Public Shared Function EncryptTripleDES(ByVal CShellcode() As Byte, ByVal key() As Byte, ByVal iv() As Byte) As Byte()
			Using des = TripleDES.Create()
				des.KeySize = 128
				des.BlockSize = 64
				des.Padding = PaddingMode.PKCS7
				des.Mode = CipherMode.CBC

				des.Key = key
				des.IV = iv

				Using encryptor = des.CreateEncryptor(des.Key, des.IV)
					Using msEncShellCode = New MemoryStream()
					Using cryptoStream = New CryptoStream(msEncShellCode, encryptor, CryptoStreamMode.Write)
						cryptoStream.Write(CShellcode, 0, CShellcode.Length)
						cryptoStream.FlushFinalBlock()

						Return msEncShellCode.ToArray()
					End Using
					End Using
				End Using
			End Using
		End Function
		Public Shared Function EncryptAES(ByVal CShellcode() As Byte, ByVal key() As Byte, ByVal iv() As Byte) As Byte()
			Using aes = System.Security.Cryptography.Aes.Create()
				aes.KeySize = 128
				aes.BlockSize = 64
				aes.Padding = PaddingMode.PKCS7
				aes.Mode = CipherMode.CBC

				aes.Key = key
				aes.IV = iv

				Using encryptor = aes.CreateEncryptor(aes.Key, aes.IV)
					Using msEncShellCode = New MemoryStream()
					Using cryptoStream = New CryptoStream(msEncShellCode, encryptor, CryptoStreamMode.Write)
						cryptoStream.Write(CShellcode, 0, CShellcode.Length)
						cryptoStream.FlushFinalBlock()

						Return msEncShellCode.ToArray()
					End Using
					End Using
				End Using
			End Using
		End Function
	End Class
End Namespace
