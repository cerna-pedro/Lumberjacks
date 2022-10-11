namespace Lumberjacks
{
    internal class Program
    {
        static Random random = new Random();
        static Queue<Lumberjack> lumberjackQueue = new Queue<Lumberjack>();

        static void Main(string[] args)
        {
            while (true)
            {

                string consoleWrite = lumberjackQueue.Count == 0 ? "First lumberjack's name: " : "Next lumberjacks's name (blank to end): ";
                Console.Write(consoleWrite);
                string lumberjackName = Console.ReadLine();
                if (lumberjackName != "")
                {
                    Lumberjack lumberjack = new Lumberjack(lumberjackName);
                    Console.Write("Number of flapjacks: ");
                    if (int.TryParse(Console.ReadLine(), out int numberOfFlapjacks))
                    {
                        for (int i = 0; i < numberOfFlapjacks; i++)
                        {
                            lumberjack.TakeFlapJack((Flapjack)random.Next(0, 4));
                        }

                    }
                    lumberjackQueue.Enqueue(lumberjack);

                }
                else
                {
                    while (lumberjackQueue.Count != 0)
                    {

                        lumberjackQueue.Dequeue().EatFlapjacks();
                    }
                    return;
                }

            }


        }
    }
}