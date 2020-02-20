using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zaku.Utility.Interface;
using static Zaku.Utility.DataLoader;
using static System.Console;
using Zaku.Game;

namespace Zaku
{
    class Games
    {
        Player player;
        Trader trader;

        int activeMenu = 0;

        // game function 
        public void Game()
        {
            Title = "Item Shop";
            player = new Player();
            while (true)
            {
                Menu();
            }
        }
        private void TitleScreen()
        {
            string instructionFile = "Data/Instructions.txt";
            WriteLine(Utility.DataLoader.Loader(instructionFile));

            Pause();
        }
        public void Menu()
        { 
            WriteLine("Choose:");
            WriteLine("1) Show Inventory \n2) Make \n3) Trader");
            string choose = ReadLine();
            if (choose == "1")
            {
                ShowInventory();
                activeMenu = 1;
            }
            else if (choose == "2")
            {
                Make();
                activeMenu = 2; 
            }
            else if (choose == "3")
            {
                WriteLine("Choose:");
                WriteLine("1) Buy \n2) Sell \n3) Back");
                string choose2 = ReadLine();
                activeMenu = 3;
            }
        }

        public void ShowInventory()
        {
            player.ListInventoryItems();
        }
        //private bool searchinventory(string name)
        //{
        //    foreach (Item i in player.Inventory)
        //    {
        //        if (i.Name = name)
        //        {
        //            //Player.Inventory.Remove(i);
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        
        //public bool RemoveItem(string name)
        //{
        //    foreach(Item i in player.Inventory)
        //        {
        //            if (i.Name = name)
        //            {
        //                player.Inventory.Remove(i);
        //                return true;
        //            }
        //        }
        //     return false;
        //}

        //private float GetInventoryAmount(string name)
        //{
        //}
        //private bool ChangeInventoryAmount(string name, float amount)
        //{
        //}

        public void Make()
        {
            
            WriteLine("Make:");
            WriteLine("1) Make Orange Dye  \n2) Make Green Dye  \n3) Make Tortilla  \n4) Make Paper Mache \n5) Make PlayDough \n6) Make Colored PlayDough");
            string choose = ReadLine();
            if (choose == "1")
            {
                //MakeOrangeDye();
            }
            else if (choose == "2")
            {
                //MakeGreenDye();
            }
            else if (choose == "3")
            {
                //MakeTortilla();
            }
            else if (choose == "4")
            {
                //MakePaperMache();
            }
            else if (choose == "5")
            {
                //MakePlayDough();
            }
            else if (choose == "6")
            {
                //MakeColoredPlayDough();
            }
        }
        private void Confirmation(string name)
        {
        }
        //private void MakeOrangeDye()
        //{
        //    if (!Inventory.Contains("1 Red Food Dye" + "1 yellow food dye"))
        //    {
        //        Inventory.Add(new Item("Orange Food Dye", 1, "bottle(s)"));
        //    }
        //    //have inventory be a text doc
        //}
        //private void MakeGreenDye()
        //{
        //    //1 blue food dye 1 yellow food dye
        //}

        //private void MakeTortilla()
        //{
        //    //2 cups white flour 3 / 4 cup warm water
        //}
        //private void MakePaperMache()
        //{
        //    //1 cup flour 2 cups water Newspaper strips
        //}

        //private void MakePlayDough()
        //{
        //    //1 cup of flour ¼ cup of salt ½ cup of warm water
        //}

        //private void MakeColoredPlayDough()
        //{
        //    //(plain play-dough && Food coloring)
        //}

        public void Run()
        {
            TitleScreen();
            Menu();
        }
    }
}
