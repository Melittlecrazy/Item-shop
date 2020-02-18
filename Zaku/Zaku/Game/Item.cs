using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaku
{
    class Item
    {
        private string name;
        private float amount;
        private string amounttype;
        public string Name { get => name; set => name = value; }
        public float Amount { get => amount; set => amount = value; }
        public string Amounttype { get => amounttype; set => amounttype = value; }
        public float Value;

        public Item(string _name, float _amount, string _amounttype)
        {
            Name = _name;
            Amount = _amount;
            Amounttype = _amounttype;
        }
        public string Description()
        {
            return $"{Amount} {Amounttype} {Name}.";
        }


    }
}
