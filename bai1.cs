using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2033210434_LDAD_Bai1
{
    class Bai1
    {
        int x,y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        char tenTD;

        public char TenTD
        {
          get { return tenTD; }
          set { tenTD = value; }
        }
                public Bai1()
                {}
                public Bai1(char tenTD, int x, int y)
                {
                    TenTD = this.tenTD;
                    X = this.x;
                    Y = this.y;
                }
                public void nhap(){
                    Console.WriteLine("Nhap ten toa do: ");
                    TenTD = char.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap x, y: ");
                    X = int.Parse(Console.ReadLine());
                    Y = int .Parse(Console.ReadLine());
                    Console.WriteLine("Toa do: {0}({0},{0}) ",TenTD,X,Y);
                }
    }
}
