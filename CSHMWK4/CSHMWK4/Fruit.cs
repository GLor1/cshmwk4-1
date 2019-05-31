using System;
using System.Collections.Generic;
using System.Text;

namespace CSHMWK4
{
   public class Fruit
    {
        public string _seeds { set; get; }
        public string _flavor { set; get; }
        public int _childrenProduced { set; get; }

        public Fruit(string seeds, string flavor, int childrenProduced)
        {
            _seeds = seeds;
            _flavor = flavor;
            _childrenProduced = childrenProduced;
            Console.WriteLine("Seeds: {0}, flavor: {0}, childrenProduced {0}", _seeds, _flavor, _childrenProduced);
        }
        public void childP(int babiesMadefromconsumingfruit)
        {
            for(int i = 0; i < babiesMadefromconsumingfruit; i++)
            {
                Console.Write("Count this line to see how many children you'll have. {0}", _childrenProduced);
            }
        }
        public void flavor(string flavor)
        {
            Console.WriteLine("Sweet!");
        }                                        
    }


    public class Mango: Fruit
    {
    public string _taste { set; get; }
    public Mango(string seeds, string flavor, int childrenProduced, string taste) : base (seeds, flavor, childrenProduced)
    {
        _taste = taste;
        Console.WriteLine("This mango tastes great {0}.", _taste);
    }
    public void action(string action)
    {
        Console.WriteLine("The mango goes man!", action);
    }
    }
        
     

    
}
