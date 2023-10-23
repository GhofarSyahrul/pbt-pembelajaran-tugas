Imports System

Module Program
    Sub Main()
        Dim tambah_a As Integer
        Dim tambah_b As Integer
        Dim hasil As Integer

        console.writeLine("===============")
        console.write("Bilangan 1 : ")
        tambah_a = console.ReadLine()
        console.write("Bilangan 2 : ")
        tambah_b = console.ReadLine()

        hasil = tambah_a + tambah_b
        console.write("Hasil tambah nih bre segini : ")
        console.write(hasil)
        console.writeLine()

        hasil = tambah_a - tambah_b
        console.write("Hasil kurang nih bre segini : ")
        console.writeLine(hasil)

        hasil = tambah_a * tambah_b
        console.write("Hasil kali nih bre segini : ")
        console.writeLine(hasil)

        hasil = tambah_a / tambah_b
        console.write("Hasil bagi '/' nih bre segini : ")
        console.writeLine(hasil)

        hasil = tambah_a \ tambah_b
        console.write("Hasil bagi 'div' nih bre segini : ")
        console.writeLine(hasil)

        hasil = tambah_a Mod tambah_b
        console.write("Hasil bagi modulus nih bre segini : ")
        console.writeLine(hasil)
        console.ReadKey()
    End Sub
End Module
