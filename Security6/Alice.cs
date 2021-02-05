using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Security6
{
    public class Alice
    {
        public int p { get; set; } = 23;
        public int a { get; set; } = 7;
        public int x { get; set; }
        public int X { get; set; }
        public int k { get; set; }
        public int fromBob { get; set; }
        public void genX()
        {
            var rnd = new Random();
            this.x = rnd.Next(100, 1000);
        }
        public void calcX()
        {
            BigInteger b_a = new BigInteger(a);
            BigInteger b_p = new BigInteger(p);
            X = int.Parse((BigInteger.Pow(b_a, x) % b_p).ToString());
             
        }
        public void sendX(Bob bob)
        {
            bob.fromAlice = X;
        }
        public void send_a_p(Bob bob)
        {
            bob.a = a;
            bob.p = p;
        }
        public List<int> calcA()
        {
            return GFG.findPrimitive(p);
        }
        public void CalcK()
        {

            BigInteger bob = new BigInteger(fromBob);
            BigInteger b_p = new BigInteger(p);

            this.k = int.Parse((BigInteger.Pow(bob, x) % b_p).ToString());
        }

    }
}
