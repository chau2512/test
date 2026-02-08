using System;
using System.Collections.Generic;

public class Arsenal
{
    static void Main(string[] args)
    {
        List<Vukhi> arenal = new List<Vukhi>();
        arenal.Add(new Vukhi("excalibur", 30));
        arenal.Add(new Vukhi("gun", 50));
        arenal.Add(new Vukhi("tree", 100000));

        foreach (Vukhi vukhi in arenal)
        {
            vukhi.TanCong();
        }
        int tongsatthuong = 0;
        foreach (Vukhi vukhi in arenal)
        {
            tongsatthuong += vukhi.SatThuong;
        }
        Console.WriteLine($"tong sat thuong: {tongsatthuong}");
    }

}
public class Vukhi
{
    string ten;
    public int SatThuong { get; set; }
    public Vukhi(string ten, int satThuong)
    {
        this.ten = ten;
        this.SatThuong = satThuong;
    }
    public void TanCong()
    {
        Console.WriteLine($"ten: {ten} gay ra sat thuong: {SatThuong}");
    }

}