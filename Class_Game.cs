namespace Text_Game
{
    class Game
    {

        public void Chapter1()
        {
            Console.WriteLine("После того, как вы нарушили закон, вас решают отвести в тюремные катакомбы.");
            Console.WriteLine("Вас заключили в кандалы.");
            Console.WriteLine("Попробуете сбежать не дав закрыть замок?");
            Console.WriteLine("1. Сбежать");
            Console.WriteLine("2. Поддаться и пойти с охранником");
            int select = int.Parse(Console.ReadLine("Ваш выбор?"));
            if (select == 2) Console.WriteLine("Вы спокойно идете с охранником до катакомб");
            else Console.WriteLine("Попытка не увенчалась успехом...");
            Console.WriteLine();
            Console.WriteLine("Путь предстоял по лестнице вниз, до первых ворот катакомб.");
            Console.WriteLine("Во время не долгого спуска по лестнице были не редко слышны крики девушки.");
            Console.WriteLine("Вас начинают распутывать, чтобы отпустить скитаться по катакомбам.");
            Console.WriteLine("Попробуете оглушить охранника, чтобы убежать?");
            Console.WriteLine("1. Оглушить");
            Console.WriteLine("2. Не трогать охранника и пойти в катакомбы");
            int select2 = int.Parse(Console.ReadLine("Ваш выбор?"));
            if (select2 == 1)
            {
                Console.WriteLine("У вас не получилось побороть охранника, он ударил вас в затылок и вы потеряли сознание.");
                Console.WriteLine("Через несколько часов после не удачной попытки, вы пришли в сознание, после сильного удара охранника.");
            }
            else Console.WriteLine("Вы не стали пытаться оглушить охранника и мирно зашли в катакомбы");
            Console.WriteLine();
            Console.WriteLine("Вы решили прогуляться по катакомбам с целью изучить их получше.");
            Console.WriteLine("В катакомбах было ужасное освещение.");
            Console.WriteLine("Вы исследовали катакомбы около часа и узнали:");
            Console.WriteLine("1. Потолки были висьма не высокими (приблизительно 1,8м)");
            Console.WriteLine("2. Все корридоры и проходы были широкими (около 3х шагов)");
            Console.WriteLine("3. Часто встречались деревянные двери, словно ведущие в дополнительные комнаты.");
            Console.WriteLine("4. Стены из песчаника этих катакомб, всьма не редко стены были в трещеннах");
            Console.WriteLine();
            Console.WriteLine("И вот вы проходите мимо очередного угла и вдруг...");
            Console.WriteLine("На вас нападает монстр!");
            Console.WriteLine("Шансы на побег не велки.");
            Console.WriteLine("Попробуете сбежать?");
            Console.WriteLine("1. Попробовать уйти");
            Console.WriteLine("2. Сразиться с монстром");
            int select3 = int.Parse(Console.ReadLine("Ваш выбор?"));
            if (select == 1)
            {
                Console.WriteLine("Сбежать не удалось");
                Console.WriteLine("Монстр увидел вас, и напал на вас");
            }
            else
                Console.WriteLine("Вы сделали смелый ход и напали на монстра");
            Console.WriteLine();
            Console.WriteLine("Вы сражаетесь с монстром...");
        }
        public void Chapter2()
        {
            Console.WriteLine("По итогам схватки, вы оказались победителем.");
            Console.WriteLine("После драки с монстром, вы решили передохнуть, и сели под факелом.");
            Console.WriteLine("Сидя под факелом, вы задумались, как бы можно сбежать отсюда.");
            Console.WriteLine();
            Console.WriteLine("После не длительного отдыха, вы решаетесь уйти");
            Console.WriteLine("Но перед уходом, у вас встаёт вопрос:");
            Console.WriteLine("забрать с собой факел или оставить его на прежнем месте?");
            Console.WriteLine("1. Забрать факел с собой.");
            Console.WriteLine("2. Оставить факел на прежнем месте.");
            int select4 = int.Parse(Console.ReadLine("Ваш выбор?"));
            if (select4 == 1)
            {
                Console.WriteLine("Вы продолжаете свой путь вместе с факелом.");
                Console.WriteLine("После отдыха, вы прожолжаете свой путь по катакомбам.");
                Console.WriteLine("Имея факел вы чательно остматревались, надеясь найти выход из этих катакомб для побега.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Вы оставили факел на месте в надежде, что он послужит ориентиром.");
                Console.WriteLine("Вы продолжаете путь без факела.");
                Console.WriteLine();
            }
            Console.WriteLine("Вы идете мимо очередного прохода и видете дверь");
            Console.WriteLine("Вы подошли поближе, но вдруг она оказывается заперта");
            Console.WriteLine("Попробуете открыть?");
            Console.WriteLine("1. Попробовать открыть");
            Console.WriteLine("2. Уйти и найти другой проход");
            int select5 = int.Parse(Console.ReadLine("Ваш выбор?"));
            if (select5 == 1)
            {
                Console.WriteLine("Вы попробовали открыть дверь");
                Console.WriteLine("Дверь отперлась от ваших толчков");
                Console.WriteLine("За этой дверью стоял темный силуэт");
                Console.WriteLine();
                if (select4 == 1)
                {
                    Console.WriteLine("У вас был с собой факел");
                    Console.WriteLine("Вы подошли поближе и узнали, что это был человек женского пола");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Так как что вы оставили факел, вы не смогли понять кто это.");
                    Console.WriteLine("Вы решили задать несколько вопросов на не большом расстоянии:");
                    Console.WriteLine("Кто ты? Что ты здесь делаешь? И подобные, для того чтобы понять, кто это");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Вы собрались уходить, но вдруг дверь распохнулась...");
                Console.WriteLine("Что сделаете?");
                Console.WriteLine("1. Уйдете");
                Console.WriteLine("2. Посмотрите, что за этой дверью");
                int select6 = int.Parse(Console.ReadLine("Что выберите?"));
                if (select6 == 1)
                {
                    Console.WriteLine("Вы собирались уйти, но вдруг...");
                    Console.WriteLine("Из этой двери выходит темный силуэт");
                    Console.WriteLine("Но так, как у вас был с собой факел");
                    Console.WriteLine("Вы смогли подойти поближе и узнать, что это был человек женского пола");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Так как что вы оставили факел, вы не смогли понять кто это.");
                    Console.WriteLine("Вы решили задать несколько вопросов на не большом расстоянии:");
                    Console.WriteLine("Кто ты? Что ты здесь делаешь? И подобные, для того чтобы понять, кто это");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("После не долгого знакомства вы решили изучать катакомбы вместе");
            Console.WriteLine("");
        }
        public void Over()
        {
            Console.WriteLine("Press F");
            string mem = Console.ReadLine("???");
            if (mem == "F")
            {
                Console.WriteLine("Молодец!");
                Console.WriteLine("Game Over!");
            }
            else
            {
                Console.WriteLine("Ты позер!");
                Console.WriteLine("Game Over!");
            }
        }
    }

}
