namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //robotsFight();
            //gameCaractersFight();
            coffeMachine();
        }


        public static void robotsFight()
        {
            Robot robot = new Robot();

            robot.name = "Şıpıdık";
            robot.model = 1998;
            robot.batteryLevel = 70;

            robot.greeting();
            robot.move(robot.batteryLevel - 10);
            robot.move(20);
            robot.chargeBattery();
            robot.move(20);
        }

        public static void gameCaractersFight()
        {
            GameCaracter player1 = new GameCaracter();
            GameCaracter player2 = new GameCaracter();

            player1.name = "Player1";
            player1.level = 1;
            player1.health = 100;
            player1.mana = 100;
            player1.damage = 10;

            player2.name = "Player2";
            player2.level = 1;
            player2.health = 100;
            player2.mana = 100;
            player2.damage = 10;

            player1.greeting();
            player2.greeting();

            player1.attack(player2);
            player2.attack(player1);

            player1.heal(player1, 10);
            player2.heal(player2, 10);

            Console.WriteLine("Player 1 hp = "+player1.health);
            Console.WriteLine("Player 2 hp = "+player2.health);


            
        }

        public static void coffeMachine()
        {
            CofeeMachine cofeeMachine = new CofeeMachine();

            cofeeMachine.Model = "Bosch";
            cofeeMachine.WaterLevel = 1000;
            cofeeMachine.CofeeBeans = 100;

            string model = cofeeMachine.Model;
            Console.WriteLine(model);
            cofeeMachine.makeCofee();
            cofeeMachine.makeCofee();
            cofeeMachine.makeCofee();
            cofeeMachine.makeCofee();
            cofeeMachine.makeCofee();
            cofeeMachine.makeCofee();
            cofeeMachine.makeCofee();
            cofeeMachine.makeCofee();
            cofeeMachine.addWater(300);
            cofeeMachine.makeCofee();
            cofeeMachine.makeCofee();
            cofeeMachine.makeCofee();
        }
    }
}
