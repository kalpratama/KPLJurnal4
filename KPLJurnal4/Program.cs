using System;

class kodeBuah
{
    public string getKodeBuah(string namaBuah)
    {
        switch (namaBuah)
        {
            case "Apel":
                return "A00";
            case "Aprikot":
                return "B00";
            case "Alpukat":
                return "C00";
            case "Pisang":
                return "D00";
            case "Paprika":
                return "E00";
            case "Blackberry":
                return "F00";
            case "Cherry":
                return "H00";
            case "Kenapa":
                return "I00";
            case "Jagung":
                return "J00";
            case "Kurma":
                return "K00";
            case "Durian":
                return "L00";
            case "Anggur":
                return "M00";
            case "Melon":
                return "N00";
            case "Semangka":
                return "O00";
            default:
                return "Kode Buah tidak ditemukan.";
        }
    }
}

class posisiKarakter
{
    public enum Trigger
    {
        TombolW, TombolS, TombolX
    }

    public enum statusKarakter
    {
        Tengkurap, Jongkok, Berdiri, Terbang
    }

    private statusKarakter org = statusKarakter.Berdiri;

    public void ubahPosisi(Trigger trigger)
    {
        if (trigger == Trigger.TombolW && org == statusKarakter.Berdiri)
        {
            org = statusKarakter.Terbang;
            Console.WriteLine("Posisi Take Off");
        }
        else if (trigger == Trigger.TombolS && org == statusKarakter.Terbang)
        {
            org = statusKarakter.Berdiri;
            Console.WriteLine("Posisi Standby");
        }
        else if (trigger == Trigger.TombolX && org == statusKarakter.Terbang)
        {
            org = statusKarakter.Jongkok;
            Console.WriteLine("Posisi Jongkok");
        }
        else if (trigger == Trigger.TombolS && org == statusKarakter.Berdiri)
        {
            org = statusKarakter.Jongkok;
            Console.WriteLine("Posisi Jongkok");
        }
        else if (trigger == Trigger.TombolW && org == statusKarakter.Jongkok)
        {
            org = statusKarakter.Berdiri;
            Console.WriteLine("Posisi Standby");
        }
        else if (trigger == Trigger.TombolS && org == statusKarakter.Jongkok)
        {
            org = statusKarakter.Tengkurap;
            Console.WriteLine("Posisi Istirahat");
        }
        else if (trigger == Trigger.TombolW && org == statusKarakter.Tengkurap)
        {
            org = statusKarakter.Jongkok;
            Console.WriteLine("Posisi Jongkok");
        }
    }
}

class Program
{
    static void Main()
    {
        kodeBuah kodeBuahInstance = new kodeBuah();

        string Buah = "Apel";
        string kodeBuah = kodeBuahInstance.getKodeBuah(Buah);

        Console.WriteLine($"Kode Buah {Buah}: {kodeBuah}");
        Console.WriteLine("---------------------");

        posisiKarakter posisiKarakter = new posisiKarakter();

        posisiKarakter.ubahPosisi(posisiKarakter.Trigger.TombolW);
        posisiKarakter.ubahPosisi(posisiKarakter.Trigger.TombolS);
        posisiKarakter.ubahPosisi(posisiKarakter.Trigger.TombolS);
        posisiKarakter.ubahPosisi(posisiKarakter.Trigger.TombolW);
        posisiKarakter.ubahPosisi(posisiKarakter.Trigger.TombolW);
        posisiKarakter.ubahPosisi(posisiKarakter.Trigger.TombolW);
    }
}