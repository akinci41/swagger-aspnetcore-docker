using System;
using System.Collections.Generic;

namespace swagger_training.Model{
    public class HeroGenerator{
        public static string GetHeroName(string firstName, string lastName){
            var f = firstName.Substring(0, 1);
            var l = lastName.Substring(0, 1);

            return string.Concat(GetHeroFirst(f), " ", GetHeroLast(l));
        }

        private static string GetHeroLast(string l)
        {
            return new HeroLast()[l.ToUpper()];
        }

        private static string GetHeroFirst(string f)
        {
            return new HeroFirst()[f.ToUpper()];
        }
    }

    internal class HeroFirst : Dictionary<string, string>
    {
        public HeroFirst()
        {
            AddValue("A", "Captain");
            AddValue("B", "Night");
            AddValue("C", "The");
            AddValue("D", "Ancient");
            AddValue("E", "Spider");
            AddValue("F", "Invisible");
            AddValue("G", "Master");
            AddValue("H", "Mr");
            AddValue("I", "Silver");
            AddValue("J", "Dark");
            AddValue("K", "Professor");
            AddValue("L", "Radioactive");
            AddValue("M", "Incredible");
            AddValue("N", "Impossible");
            AddValue("O", "Iron");
            AddValue("P", "Rocket");
            AddValue("Q", "Human");
            AddValue("R", "Power");
            AddValue("S", "Green");
            AddValue("T", "Super");
            AddValue("U", "Wonder");
            AddValue("V", "Metal");
            AddValue("W", "Doctor");
            AddValue("X", "Masked");
            AddValue("Y", "Crimson");
            AddValue("Z", "Omega");
        }

        private void AddValue(string letter, string value){
            Add(letter, value);
        }
    }

    internal class HeroLast : Dictionary<string, string>
    {
        public HeroLast()
        {
            AddValue("A", "Lightning");
            AddValue("B", "Knight");
            AddValue("C", "Hulk");
            AddValue("D", "Centurion");
            AddValue("E", "Surfer");
            AddValue("F", "Girl");
            AddValue("G", "Warrior");
            AddValue("H", "Man");
            AddValue("I", "Ghost");
            AddValue("J", "Master");
            AddValue("K", "Hornet");
            AddValue("L", "Phantom");
            AddValue("M", "Crusader");
            AddValue("N", "Daredevil");
            AddValue("O", "Machine");
            AddValue("P", "America");
            AddValue("Q", "X");
            AddValue("R", "Doom");
            AddValue("S", "First");
            AddValue("T", "Shadow");
            AddValue("U", "Patriot");
            AddValue("V", "Claw");
            AddValue("W", "Panther");
            AddValue("X", "Hawk");
            AddValue("Y", "Storm");
            AddValue("Z", "Thunder");
        }

        private void AddValue(string letter, string value){
            Add(letter, value);
        }
    }
}