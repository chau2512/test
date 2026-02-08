using System; 
using System.Collections.Generic;
public class Monster
{
    public string ten; 
    public int hp; 
    public Monster(string ten, int hp)
    {
        this.ten = ten; 
        this.hp = hp; 
    }
static void Main(string[] args)
    {
       Dictionary<string, Monster> danhsachmonster = new Dictionary<string, Monster>(); 
        danhsachmonster.Add("q01", new Monster("goblin", 100));
        danhsachmonster.Add("q02", new Monster("dragon",500));
        danhsachmonster.Add("q03", new global::Monster("adam", 10000000));
        Console.WriteLine("danh sach monster:"); 
        Console.WriteLine("cac monster hien co : q01 , q02 , q03"); 
        
        Console.WriteLine("id monster :");
        String idmonster = Console.ReadLine();
        if (danhsachmonster.ContainsKey(idmonster))
        {
            Monster monsterselected = danhsachmonster[idmonster];
            Console.WriteLine("Selected !!!");
            Console.WriteLine($"name monster {monsterselected.ten} - hp : {monsterselected.hp}");
        }
    }   
    
    

}
