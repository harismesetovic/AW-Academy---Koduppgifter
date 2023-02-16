using DungeonsOfDoom.Core;

namespace DungeonsOfDoom
{

    internal class Program
    {
        Room[,] rooms;
        Player player;

        private static void Main(string[] args)
        {
            //RandomUtils.Percentage();
            //RandomUtils.Dice();
            Program program = new Program();
            program.Play();
        }

        public void Play()
        {
            Console.CursorVisible = false;
            CreatePlayer();
            CreateRooms();

            do
            {
                do
                {
                    Console.Clear();
                    DisplayRoom();
                    DisplayStats();
                    AskForMovement();
                    CheckRoom();
                } while (player.IsAlive && Monster.MonsterCounter != 0);
                CreateRooms();
                //IncreaseDifficulty();
            } while (player.IsAlive);

            GameOver();
        }

        //private void IncreaseDifficulty(CoreStats monster)
        //{
        //    monster.IncreaseDifficulty(monster);
        //}

        void CreatePlayer()
        {
            player = new Player(30, 0, 0);
        }
        void CreateRooms()
        {
            rooms = new Room[20, 5];
            for (int y = 0; y < rooms.GetLength(1); y++)
            {
                for (int x = 0; x < rooms.GetLength(0); x++)
                {
                    rooms[x, y] = new Room();

                    int percentage = Random.Shared.Next(1, 100 + 1);
                    if (percentage < 6)
                        rooms[x, y].MonsterInRoom = new Slime();
                    else if (percentage < 8)
                        rooms[x, y].MonsterInRoom = new Skeleton();
                    else if (percentage < 1)
                        rooms[x, y].MonsterInRoom = new Ogre();
                    else if
                        (percentage < 14)
                        rooms[x, y].ItemInRoom = new Sword();
                    else if
                        (percentage < 16)
                        rooms[x, y].ItemInRoom = new Shield();
                }
            }
        }
        private void DisplayRoom()
        {
            for (int y = 0; y < rooms.GetLength(1); y++)
            {
                for (int x = 0; x < rooms.GetLength(0); x++)
                {
                    Room room = rooms[x, y];
                    if (player.X == x && player.Y == y)
                        Console.Write("P");
                    else if (room.MonsterInRoom != null)
                    {
                        if (room.MonsterInRoom.MonsterType == Monster._MonsterType.Slime)
                            Console.Write("S");
                        else if (room.MonsterInRoom.MonsterType == Monster._MonsterType.Skeleton)
                            Console.Write("B");
                        else
                            Console.Write("O");
                    }
                    else if (room.ItemInRoom != null)
                        Console.Write("I");
                    else
                        Console.Write(".");
                }
                System.Console.WriteLine();
            }
        }

        private void DisplayStats()
        {
            System.Console.WriteLine($"Monsters alive: {Monster.MonsterCounter}");
            System.Console.WriteLine(player.Name);
            System.Console.WriteLine($"Health: {player.Health}");
            System.Console.WriteLine($"Strength: {player.Strength}");
            System.Console.WriteLine($"Armor: {player.Armor}");
            System.Console.WriteLine("Inventory:");
            if (player.Inventory.Count() != 0)
            {
                foreach (var item in player.Inventory)
                {
                    System.Console.WriteLine(item.Name);
                }
            }
        }

        private void AskForMovement()
        {
            int newX = player.X;
            int newY = player.Y;
            bool isValidKey = true;

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow: newX++; break;
                case ConsoleKey.LeftArrow: newX--; break;
                case ConsoleKey.UpArrow: newY--; break;
                case ConsoleKey.DownArrow: newY++; break;
                default: isValidKey = false; break;
            }
            if (isValidKey &&
                newX >= 0 && newX < rooms.GetLength(0) &&
                newY >= 0 && newY < rooms.GetLength(1))
            {
                player.X = newX;
                player.Y = newY;
            }

            // CheckForItem();
        }

        private void CheckRoom()
        {
            Room currentRoom = rooms[player.X, player.Y];
            if (currentRoom.MonsterInRoom != null)
            {
                AttackMonster(currentRoom.MonsterInRoom);
            }
            else if (currentRoom.ItemInRoom != null)
            {
                CheckForItem();
            }
        }


        private void GameOver()
        {
            Console.Clear();
            System.Console.WriteLine("Game over...");
            Console.ReadKey();
            Play();
        }

        private void AttackMonster(CoreStats opponent)
        {
            Room currentRoom = rooms[player.X, player.Y];
            Console.Clear();
            System.Console.WriteLine(player.Name);
            System.Console.WriteLine($"{player.Health} hp, {player.Strength} str, {player.Armor} armor");
            System.Console.WriteLine("Versus");
            System.Console.WriteLine(opponent.Name);
            System.Console.WriteLine($"{opponent.Health} hp, {opponent.Strength} str, {opponent.Armor} armor");
            System.Console.WriteLine();
            Console.WriteLine($"{player.Name} hit {opponent.Name} for {player.Attack(opponent)} hp");

            if (opponent.Health <= 0)
            {
                foreach (var item in opponent.Inventory)
                {
                    player.AddToInventory(item);
                    System.Console.WriteLine($"{opponent.Name} dropped {item.Name}");
                }
                currentRoom.MonsterInRoom = null;
                Monster.MonsterCounter--;

            }
            else
            {
                Console.WriteLine($"{opponent.Name} hit {player.Name} for {opponent.Attack(player)} hp");
            }
            System.Console.ReadLine();
        }

        void CheckForItem()
        {
            Room currentRoom = rooms[player.X, player.Y];

            if (currentRoom.ItemInRoom.Name == "Teleport Potion")
            {
                player.Health += 10;
                player.X = Random.Shared.Next(0, rooms.GetLength(0));
                player.Y = Random.Shared.Next(0, rooms.GetLength(1));
                currentRoom.ItemInRoom = null;
            }
            else if (currentRoom.ItemInRoom != null)
            {
                player.AddToInventory(currentRoom.ItemInRoom);
                currentRoom.ItemInRoom = null;
            }

        }


    }
}
