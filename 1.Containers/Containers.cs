﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1.Containers
{
    public interface IStat
    {
        string Name { get; set; }
        int Value { get; set; }
        string Description { get; set; }
        string ToString();
    }
    public class Stat : IStat
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }

        public Stat(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            string data = Name + ":" + Value + "\n" + Description + "\n";
            return data;
        }
    }
    public class Character
    {
        public int ExperiencePoints { get; set; }
        public string CharacterName { get; set; }
        public int Level { get; set; }
        public void GenCharacter()
        {
            var c = new Character();
        }

        public override string ToString()
        {
            string data = "Name: " + CharacterName + "\n" +
                "Level: " + Level + "\n" +
                "Exp: " + ExperiencePoints + "\n" + "\n";
            return data;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

}
