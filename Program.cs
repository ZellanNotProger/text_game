namespace Text_Game
{
    public static class Program
    {
        public static void Main()
        {
            var lifePoints = int.Parse(Console.ReadLine("Введите колличество жизней: "));
            var player = new Player(lifePoints / 3);
            var monster = new Monster(lifePoints / 2);
            var game = new Game();
            string startGame = Console.ReadLine("Хотите начать игру?");
            if (startGame == "Yes")
            {
                Console.WriteLine("Игра началась");
                game.Chapter1();
            }
            else if (startGame == "1")
            {
                Console.WriteLine("Игра началась");
                game.Chapter1();
            }
            else
            {
                Console.WriteLine("Мне без разницы.");
                Console.WriteLine("Игра началась");
                game.Chapter1();
            }
            while (true)
            {
                Console.WriteLine();
                var WasDamagde = player.WasDamega();
                var WasDamage = monster.WasDamaged();
                if (player.WasDamega())
                {
                    player.Damega();
                }
                else
                {
                    player.Sims();
                }
                if (monster.WasDamaged())
                {
                    monster.Damage();
                }
                else
                {
                    monster.Miss();

                }
                if (monster.IsDead())
                    break;
                if (player.IsDead())
                    break;
            }
            Console.WriteLine();
            if (player.IsDead())
            {
                game.Chapter2();
            }
            else
            {
                game.Over();
            }
        }
    }
}