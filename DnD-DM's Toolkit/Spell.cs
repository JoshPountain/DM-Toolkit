using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_DM_s_Toolkit
{

    public class spell
    {
        public static int[] dieMax = { 4, 8, 10, 12, 20, 100 };
        public spell (Level level, string name, string description)
        {
            
        }
        public enum Level
        {
            cantrip,
            one,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine
        }

        public void Cast(ref int noDice, ref int[] rolls)
        {

        }
        
        

        public Level lev { get; set; }

        protected string description { get; set; }

    }

    public class healing : spell
    {
        public Level m = Level.one;
        
        public healing(Level level, string name, string description) : base(level, name, description)
        {
            
        }
        
    }
    public class damage : spell
    {
        public Level m = Level.one;

        public damage(Level lev, string name, string description) : base(lev, name, description)
        {

        }
    }
    public class savingDamage : damage
    {
        public savingDamage(Level lev, string name, string description  ) : base(lev, name, description)
        {

        }
    }
    public class attack : damage
    {

    }
    public class effect : spell
    {
        public Level m = Level.one;
        public effect() : base(Level.one, "yo?", "mom?")
        {

        }
    }
    public class savingEffect : effect
    {

    }
}
