Imports System

Module Program
    Sub Main()
        Dim hari As String

        console.write("Bagaimana cuaca hari ini ? ")
        hari = console.ReadLine()
        If hari = "hujan" Then
            console.write("BAWA PAYUNG MAKANYA KONTOL kalo hujan")
        Else
            console.write("SERAH LO DEH MAU APA")
            console.ReadKey()
        End If
    End Sub
End Module
