using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Zaku
{
    class Game
    {
        Player player;

        public Game()
        {
            Title = "Easy Make App 1.0";
            player = new Player();
            while (true)
            {
                Menu();
            }
        }
        public void Menu()
        { 
            WriteLine("Choose:");
            WriteLine("1) Show Inventory \n2) Make");
            string choose = ReadLine();
            if (choose == "1")
            {
                ShowInventory();
            }
            else if (choose == "2")
            {
                Make();
            }
        }

        public void ShowInventory()
        {
        }
        //private bool SearchInventory(string name)
        //{
        //}
        //private bool RemoveItem(string name)
        //{
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
                MakeOrangeDye();
            }
            else if (choose == "2")
            {
                MakeGreenDye();
            }
            else if (choose == "3")
            {
                MakeTortilla();
            }
            else if (choose == "4")
            {
                MakePaperMache();
            }
            else if (choose == "5")
            {
                MakePlayDough();
            }
            else if (choose == "6")
            {
                MakeColoredPlayDough();
            }
        }
        private void Confirmation(string name)
        {
        }
        private void MakeOrangeDye()
        {
        }
        private void MakeGreenDye()
        {
        }

        private void MakeTortilla()
        {
        }
        private void MakePaperMache()
        {
        }

        private void MakePlayDough()
        {
        }

        private void MakeColoredPlayDough()
        {
        }

    }
}
