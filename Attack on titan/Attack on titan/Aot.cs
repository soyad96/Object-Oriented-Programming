using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attack_on_titan
{
    public  class Aot
    {
        protected string epName;
        protected int epNo;
        public string EpName
        {
            get { return this.epName; }
            set { this.epName = value; }
        }
        public int EpNo
        {
            get { return this.epNo; }
            set { this.epNo = value; }
        }
        public Aot()
        {

        }
        public Aot(string epName,int epNo)
        {
            this.epNo = epNo;
            this.epName = epName;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine(" the details you want to know about the aot ");
            Console.WriteLine(" the episode number is " + this.epNo);
            Console.WriteLine(" the epsiode name is" + this.epName);
        }
    }
}
