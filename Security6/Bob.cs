using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Security6
{
    public class Bob
    {
        public int p { get; set; }
        public int a { get; set; }
        public int y { get; set; }
        public int Y { get; set; }
        public int k { get; set; }
        public int fromAlice { get; set; }

        public void genY()
        {
            var rnd = new Random();
            this.y = rnd.Next(100, 1000);
        }
        public void calcY()
        {
            BigInteger b_a = new BigInteger(a);
            BigInteger b_p = new BigInteger(p);
            Y = int.Parse((BigInteger.Pow(b_a, y) % b_p).ToString());
        }
        public void sendY(Alice alice)
        {
            alice.fromBob = Y;
        }
        public void CalcK()
        {
            BigInteger alice = new BigInteger(fromAlice);
            BigInteger b_p = new BigInteger(p);

            this.k = int.Parse((BigInteger.Pow(alice, y) % b_p).ToString());
        }

    }
}
