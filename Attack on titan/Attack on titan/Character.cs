using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attack_on_titan
{
    public  class Character:Aot
    {
        private string name;
        private string rank;
        private int killcount;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Rank
        {
            get { return this.rank; }
            set { this.rank = value; }
        }
        public int KillCount
        {
            get { return this.killcount; }
            set { this.killcount = value; }

        }
        public Character() :base()
        {

        }
        public Character(string name,string rank,int killcount)
        {
            this.name = name;
            this.rank = rank;
            this.killcount = killcount;
        }
        public  override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine();
            Console.WriteLine(" the name of the hero is " + this.name);
            Console.WriteLine(" the rank of the hero is " + this.rank);
            Console.WriteLine(" the killcount is " + this.killcount);
        }
    }
}
