using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attack_on_titan
{
    public  class Wall:Aot
    {
        private string wallName;
        private int radious;
        public string WallName
        {
            get { return this.wallName; }
            set { this.wallName = value; }
        }
        public int Radious
        {
            get { return this.radious; }
            set { this.radious = value; }
        }
        public Wall() : base()
        {

        }
        public Wall(string epName,int epNo,string wallName,int radious) : base(epName, epNo)
        {
            this.wallName = wallName;
            this.radious = radious;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(" the name of wall is  " + this.wallName);
            Console.WriteLine(" the radious of the wall is " + this.radious);
        }
    }
}
