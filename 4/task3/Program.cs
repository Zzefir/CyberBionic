using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the name of the song: ");
            string name = Console.ReadLine();
            Console.Write("Choose record or play: ");
            string mode = Console.ReadLine();

            if (mode == "record")
            {
                IRecodable song = new Player(name);
                song.Record();
                song.Pause();
                song.Stop();
            }
            else if (mode == "play")
            {
                IPlayable song = new Player(name);
                song.Play();
                song.Pause();
                song.Stop();
            }
            else
            {
                Console.WriteLine("No such mode!");
            }

            Console.ReadKey();
        }
    }
}
