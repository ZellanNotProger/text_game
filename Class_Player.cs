namespace Text_Game
{
    class Player
    {
        private int _hpPlayer;
        public Player(int hpPlayer)
        {
            _hpPlayer = hpPlayer;
        }
        public bool WasDamega()
        {
            var randomNumber1 = new Random().Next(0, 2);
            return randomNumber1 == 1;
        }
        public void Damega()
        {
            Console.WriteLine("Player нанес урон игроку Monster");
            _hpPlayer--;
            Console.WriteLine("У него осталось {0} жизней", _hpPlayer);
        }
        public bool IsDead()
        {
            return _hpPlayer <= 0;
        }
        public void Sims()
        {
            Console.WriteLine("Player не попал по игроку Monster");
        }
    }
}