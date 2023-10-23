Imports System
Module Program
    Sub Main()
        Dim nilai As Integer
        Dim grade As String

        Do
            Console.WriteLine("Untuk keluar ketik [-1]")
            Console.Write("Masukkan nilai: ")
            nilai = Console.ReadLine()


            If nilai <= -1 Then
                Exit Do ' Keluar dari loop jika pengguna memasukkan -1
            End If

            If nilai >= 90 And nilai <= 100 Then
                grade = "Sangat memuaskan"
            ElseIf nilai >= 80 And nilai <= 89 Then
                grade = "Baik"
            ElseIf nilai >= 65 And nilai <= 79 Then
                grade = "Cukup baik"
            ElseIf nilai >= 50 And nilai <= 64 Then
                grade = "Kurang baik"
            ElseIf nilai >= 100 Then
                grade = "GG NILAI LO BRE!"
            ElseIf nilai >= 0 And nilai <= 49 Then
                grade = "Kerja bagus"
            End If

            Console.WriteLine("Hasil grade mu adalah: " & grade)
        Loop While True

        Console.WriteLine("Terima kasih. cek nilai selesai.")
        Console.ReadKey()
    End Sub
End Module
