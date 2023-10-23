Imports System

Module program
    Sub Main()
        Dim hari As String

        Console.Write("Bagaimana cuaca hari ini ? ")
        hari = Console.ReadLine()
        Select Case hari
            Case Is = "hujan"
                Console.WriteLine("Pake payung jing")
            Case Is = "panas"
                Console.WriteLine("kalungan radiator")
            Case Is = "Mendung"
                Console.WriteLine("pakai jaket brow")
            Case Else
                Console.WriteLine("SERAH LO DEH PENGEN NGAPAIN")
        End Select
        Console.ReadKey()
    End Sub
End Module
