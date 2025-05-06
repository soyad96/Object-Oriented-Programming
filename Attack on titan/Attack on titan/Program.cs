using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attack_on_titan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to the aot.I hope you will enjoy the show and find infomation about it  ");
            var at = new Aot();
            at.EpName = "To you in 2000 years";
            at.EpNo = 1;
            at.ShowInfo();
            Titan t = new Titan();
            t.EpName = " Beast titan ";
            t.EpNo = 12;
            t.TianName = " Zuke ";
            t.TitanType = " Beast titan ";
            t.Power = " Throwing rocks at inasne speed ";
            t.ShowInfo();
            var t2 = new Titan(" the fall of singhana ", 15, " yemir ", " Founding Titan", "she is founder ");
            t2.ShowInfo();
            var c = new Character();
            c.Name = " levi Ackerman ";
            c.Rank = " Captian ";
            c.KillCount = 89;
            c.ShowInfo();
            var c3 = new Character("Hansi ", " setor commander ", 50);
            c3.ShowInfo();
            var c2 = new Character();
            c2.Name = " Mikasa Ackerman ";
            c2.Rank = " scount";
            c2.KillCount = 25;
            c2.ShowInfo();
            var c4 = new Character();
            c4.Name = " Lisan Ackerman ";
            c4.Rank = " sector Commander ";
            c4.KillCount = 30;
            c4.ShowInfo();
            Console.ReadKey();
            
        }
    }
}
