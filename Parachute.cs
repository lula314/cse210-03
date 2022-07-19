using System;
using System.Collections.Generic;

namespace cse210_03
{
    public class Parachute
    {
        public List<string> parachuteList = new List<string>();

        // adds lines of parachute drawing to list
        public Parachute()
        {
            this.parachuteList.Add("   ___   ");
            this.parachuteList.Add("  /___\\  ");
            this.parachuteList.Add("  \\   /  ");
            this.parachuteList.Add("   \\ /   ");
            this.parachuteList.Add("    O    ");
            this.parachuteList.Add("   /|\\   ");
            this.parachuteList.Add("   / \\   ");
            this.parachuteList.Add("         ");
            this.parachuteList.Add("^^^^^^^^^");
        }
    }
}
