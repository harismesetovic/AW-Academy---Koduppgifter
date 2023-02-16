using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien_Attack
{
    public class GameManager
    {

    }
    
    public void StartGame()
    {

    }

    private void CreateAlien()
    {
        int randomNumber = new Random().Next(0, 100);

        if (randomNumber < 50)
        {
            Console.WriteLine("Alien has spawned!");
            Alien alien = new();
        }
        else if (randomNumber < 80)
        {
            Console.WriteLine("Super Alien has spawned!");
            SuperAlien superAlien = new();
        }
        else
        {
            Console.WriteLine("Super Duper Alien has spawned!");
            SuperDuperAlien superDuperAlien = new();
        }
    }
}
