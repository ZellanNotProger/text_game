namespace Text_Game
{
    class Monster
    {
        private int _hpMonster;
        public Monster(int hpMonster)
        {
            _hpMonster = hpMonster;
        }
        public bool WasDamaged()
        {
            var randomNumber = new Random().Next(0, 2);
            return randomNumber == 1;
        }
        public void Damage()
        {
            Console.WriteLine("Monster нанес урон игроку Player");
            _hpMonster--;
            Console.WriteLine("У вас осталось {0} жизней", _hpMonster);
        }
        public bool IsDead()
        {
            return _hpMonster <= 0;
        }
        public void Miss()
        {
            Console.WriteLine("Monster не попал по игроку Player");
        }
    }
}
