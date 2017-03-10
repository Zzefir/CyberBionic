using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Player: IPlayable, IRecodable
    {
        private string name;

        public Player(string name)
        {
            this.name = name;
        }

        public void Play()
        {
            Console.WriteLine("{0} is playing", name);
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("{0} playing stops", name);
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("{0} playing is paused", name);
        }

        public void Record()
        {
            Console.WriteLine("{0} is recorded", name);
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("{0} recording is paused", name);
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("{0} recording stops", name);
        }
    }
}
