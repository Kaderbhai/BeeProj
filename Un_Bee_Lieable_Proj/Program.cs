using System;
using Un_Bee_Lieable_Proj;
using Un_Bee_Lieable_Proj.Bees;

namespace Un_Bee_Lievable
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Beedy's and gentlebees, welcome to the Bee-Drome");
            Console.WriteLine("Two bee enter, one bee leaves!");

            Console.WriteLine("Your contenders tonight are:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) The White Queen");
            Console.WriteLine("2) Doug the Drone");
            Console.WriteLine("3) Worky McWorkFace");
            
            var player1 = new Player();
            
            // Console.WriteLine("Beekeeper what's your name:");            
            // player1.PlayerName = Console.ReadLine();

            Console.WriteLine("Beekeeper 1 choose your Bee!, from 1,2,3");

            var beeFactory = new TheBeeFactory();
            
            beeFactory.BeeFactory();

            string beetag = Console.ReadLine();

            // player1.ChoosenBee = Int32.Parse(beetag);


        }

         public abstract class BeeFactory  
        {  
            public abstract IBee GetBee();  
        }  

        public class QueenFactory: BeeFactory
        {
            private float _health;
            private bool _isDead;

            public QueenFactory(float health, bool isDead)      
            {      
                _health = health;      
                _isDead = isDead;      
            }      
        public override IBee GetBee()      
            {      
                return new Queen(_health, _isDead);      
            }      
        }

        public class DroneFactory: BeeFactory
        {
            private float _health;
            private bool _isDead;

            public DroneFactory(float health, bool isDead)      
            {      
                _health = health;      
                _isDead = isDead;      
            }      
      
        public override IBee GetBee()      
            {      
                return new Drone(_health, _isDead);      
            }      
        }

        public class WorkerFactory: BeeFactory
        {
            private float _health;
            private bool _isDead;

            public WorkerFactory(float health, bool isDead)      
            {      
                _health = health;      
                _isDead = isDead;      
            }      
      
        public override IBee GetBee()      
            {      
                return new Worker(_health, _isDead);      
            }      
        }

        public class TheBeeFactory
        {            
            public void BeeFactory()
            {
            BeeFactory beeFactory = null;

                Console.WriteLine("Choose your bee from 1,2 or 3: ");  
                string bee = Console.ReadLine();  
    
                switch (bee)  
                {  
                    case "1":  
                        beeFactory = new QueenFactory(150, false);  
                        break;  
                    case "2":  
                        beeFactory = new DroneFactory(100, false);
                        break;  
                    case "3":  
                        beeFactory = new WorkerFactory(80, false);  
                        break;  
                    default:  
                        break;  
                }  
    
                IBee bee1 = beeFactory.GetBee();   
            }
            
        }
    }
}
