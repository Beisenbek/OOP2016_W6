using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class A
    {
        public static Hero h;
    }

    public class Hero
    {
        private string id;
        private static Hero _hero;
        private Hero()
        {
            id = Guid.NewGuid().ToString();
        }
        public string Id { get { return this.id; } }

        static public Hero Instance()
        {
            if (_hero == null)
            {
                _hero = new Hero();
            }
            return _hero;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Hero mario = Hero.Instance();
            Hero mario2 = Hero.Instance();

            Console.WriteLine(mario.Id);
            Console.WriteLine(mario2.Id);
        }
    }
}
