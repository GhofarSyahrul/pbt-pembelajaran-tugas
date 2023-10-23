Imports System

Module Program
    Sub Main()
        Dim nilai As Integer

        Dim angka As Integer
        Const nomor As Integer = 10

        Dim tambah_a As Integer
        Dim tambah_b As Integer
        Dim hasil As Integer


        nilai = 6
        Console.Write("Nilainya nih bre : ")
        Console.WriteLine(nilai)

        angka = 4
        console.write("Yang ditampilin nih bre : ")
        console.writeLine(angka)
        console.write("Nilai const nya nih bre : ")
        console.writeLine(nomor)
        console.writeLine("=====================)
        console.writeLine("COBA ISI KALKULATOR SEDERHANA BANGET")

        console.write("Bilangan 1 : ")
        tambah_a = console.readLine()
        console.write("Bilangan 2 : ")
        tambah_b = console.readLine()

        hasil = tambah_a + tambah_b
        console.write("Hasil tambah nih bre segini : ")
        console.write(hasil)
    End Sub
End Module
