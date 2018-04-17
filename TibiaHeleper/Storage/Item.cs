﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibiaHeleper.Storage
{
    [Serializable]
    public class Item
    {
        public int ID { get; set; }
        public string name { get; set; }

        public Item(string name, int id)
        {
            ID = id;
            this.name = name;
        }

        public static List<int> ToIdList(List<Item> items)
        {
            List<int> IDs = new List<int>();
            foreach (Item item  in items)
            {
                IDs.Add(item.ID);
            }
            return IDs;
        }
    }
}
