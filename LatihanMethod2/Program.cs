using System.Linq.Expressions;
using System.Text.Json.Serialization;

int jumlahItem;

decimal hargaItem, diskon, totalBayar;

static decimal hitungDiskon(int jml_item)
{
    if (jml_item == 5)
        return 50000;
    else if (jml_item == 10)
        return 75000;
    else
        return 0;
}

static decimal hitungTotal(int jml_item, decimal hrg_item, decimal diskon_item)
{
    return jml_item * hrg_item - diskon_item;
}

Console.Write("Masukkan Jumlah item : ");
jumlahItem = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Masukkan harga per item : ");
hargaItem = decimal.Parse(Console.ReadLine());

diskon = hitungDiskon(jumlahItem);

totalBayar = hitungTotal(jumlahItem, hargaItem, diskon);
Console.WriteLine($"Total yang harus dibayar adalah : {totalBayar}");