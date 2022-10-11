using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumberjacks
{
    internal class Lumberjack
    {
        public string Name { get; private set; }
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();
        public Lumberjack(string name)
        {
            Name = name;
        }

        public void TakeFlapJack(Flapjack flapjack)
        {
            flapjackStack.Push(flapjack);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{Name} is eating flapjacks");
            while (flapjackStack.Count != 0)
            {
            Flapjack lastFlapJack = flapjackStack.Pop();
            Console.WriteLine($"{Name} ate a {lastFlapJack} flapjack");
            }
        }
    }
}
