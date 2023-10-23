Imports System

Module Program
    Sub Main()
        Dim listSewa As String
        Dim hargaSewa As Integer
        Dim inputHarga As Integer
        Dim hasil As Integer
        Dim totalInap As Integer
        Dim kembalian As Integer

        console.writeLine("==========MOTEL ERPEEL===========")
        console.write("Harga Sewa : ")
        hargaSewa = console.ReadLine()
        console.write("Lama hari : ")
        totalInap = console.ReadLine()

        hasil = hargaSewa * totalInap
        console.write("total harga sewa : ")
        console.writeLine(hasil)

        console.write("Masukan jumlah uang : ")
        inputHarga = console.ReadLine()

        kembalian = hasil - inputHarga
        console.write("Total Kembalian : ")
        console.writeLine(kembalian)
        console.write("Total Jumlah uang : ")
        console.writeLine(hasil)
        console.ReadKey()
    End Sub
End Module
