using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Animal
    {
        abstract public string MakeSound();
    }
    class Dog : Animal
    {
        public override string MakeSound()
        { 
            return "Bark";
        }
    }
    class Cat : Animal
    {
        public override string MakeSound()
        { 
            return "Meow";
        }
    }
}
