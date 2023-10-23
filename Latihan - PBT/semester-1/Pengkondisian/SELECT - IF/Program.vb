Imports System

Module Program
    Sub Main()
        Dim nilai As Integer
        Dim grade As String

        Do
            Console.WriteLine("================PROGRAM CEK NILAI================")
            Console.WriteLine("Untuk keluar ketik 'keluar'")
            Console.Write("Masukkan nilai: ")
            Dim input As String = Console.ReadLine()

            If String.Equals(input, "keluar", StringComparison.OrdinalIgnoreCase) Then
                Exit Do ' Keluar dari loop jika pengguna memasukkan "keluar" (baik huruf besar maupun huruf kecil)
            End If

            If Integer.TryParse(input, nilai) Then
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
            Else
                Console.WriteLine("Ga valid nih. Masukin angka / 'keluar' bre.")
            End If
        Loop While True

        Console.WriteLine("Terima kasih. Cek nilai selesai.")
        Console.ReadKey()
    End Sub
End Module
