﻿using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaku
{
    public class Player
    {
       List<Item> Inventory = new List<Item>();
      // List<Item> Food = new List<Item>();

        
        public Player()
        {
            Inventory.Add(new Item("White Flour", 4, "cup(s)"));
            Inventory.Add(new Item("Water", 4, "cup(s)"));
            Inventory.Add(new Item("Salt", 1, "cup(s)"));
            Inventory.Add(new Item("Newspaper Strips", 1, "set(s)"));
            Inventory.Add(new Item("Blue Food Dye", 1, "bottle(s)"));
            Inventory.Add(new Item("Red Food Dye", 1, "bottle(s)"));
            Inventory.Add(new Item("Yellow Food Dye", 1, "bottle(s)"));

            //Food.Add(new Item(,,));
            //Food.Add(new Item(,,));
            //Food.Add(new Item(,,));
            //Food.Add(new Item(,,));
            //Food.Add(new Item(,,));
            
        }
        public void ListInventoryItems()
        {
            for (int i = 0; i < 7; i++)
            {
                WriteLine($"{i} {Inventory[i].Name}");
            }

        }

        
        
    }
}