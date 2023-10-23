Imports System

Module Program
    Sub Main()
        Dim hari As String

        Console.Write("Bagaimana cuaca hari ini ? ")
        hari = Console.ReadLine()
        If hari = "hujan" Then
            Console.Write("BAWA PAYUNG MAKANYA KONTOL kalo hujan")
        Else
            Console.Write("SERAH LO DEH MAU APA")
            Console.ReadKey()
            If hari = "Badai" Then
                conso
            End If
        End If
    End Sub
End Module
