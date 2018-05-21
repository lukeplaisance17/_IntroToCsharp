﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.Containers;

namespace CharacterCreator
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public List<Race> RaceList = new List<Race>();
        public List<Job> JobList = new List<Job>();
        public Form1()
        {
            Random r = new Random();
            InitializeComponent();
            RaceList = new List<Race>()
            {
                new Human() {SavingThrows = new SavingThrows() { Charisma = new Stat("Cha: ", r.Next(1, 11)),
                    Constitution = new Stat("Const: ", r.Next(1, 11)), Intelligence = new Stat("Int: ", r.Next(1, 11)),
                    Strength = new Stat("Str: ", r.Next(1,11)), Dexterity = new Stat("Dex: ", r.Next(1, 11)),
                    Wisdom = new Stat("Wis: ", r.Next(1, 11))}, CharacterName = "Human" , Level = 0, ExperiencePoints = 0},

                new Elf() {SavingThrows = new SavingThrows() { Charisma = new Stat("Cha: ", r.Next(1, 11)),
                    Constitution = new Stat("Const: ", r.Next(1, 11)), Intelligence = new Stat("Int: ", r.Next(1, 11)),
                    Strength = new Stat("Str: ", r.Next(1,11)), Dexterity = new Stat("Dex: ", r.Next(1, 11)),
                    Wisdom = new Stat("Wis: ", r.Next(1, 11))}, CharacterName = "Elf" , Level = 0, ExperiencePoints = 0},

                new Ogre() {SavingThrows = new SavingThrows() { Charisma = new Stat("Cha: ", r.Next(1, 11)),
                    Constitution = new Stat("Const: ", r.Next(1, 11)), Intelligence = new Stat("Int: ", r.Next(1, 11)),
                    Strength = new Stat("Str: ", r.Next(1,11)), Dexterity = new Stat("Dex: ", r.Next(1, 11)),
                    Wisdom = new Stat("Wis: ", r.Next(1, 11))}, CharacterName = "Ogre" , Level = 0, ExperiencePoints = 0},

                new Dwarf() {SavingThrows = new SavingThrows() { Charisma = new Stat("Cha: ", r.Next(1, 11)),
                    Constitution = new Stat("Const: ", r.Next(1, 11)), Intelligence = new Stat("Int: ", r.Next(1, 11)),
                    Strength = new Stat("Str: ", r.Next(1,11)), Dexterity = new Stat("Dex: ", r.Next(1, 11)),
                    Wisdom = new Stat("Wis: ", r.Next(1, 11))}, CharacterName = "Dwarf" , Level = 0, ExperiencePoints = 0}
            };
            JobList = new List<Job>()
            {
                new Assassin() {Name = "Assassin"},
                new Knight() {Name = "Knight" },
                new Mage() {Name = "Mage" },
                new Healer() {Name = "Healer" },
                new SharpShooter() {Name = "Sharpshooter" }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RaceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var item in RaceList)
            {
                if(item.CharacterName == RaceBox.Text)
                {
                    richTextBox1.Text = item.ToString();
                }
            }
        }

        private void JobBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in JobList)
            {
                if (item.Name == JobBox.Text)
                {
                    richTextBox1.Text = item.ToString();
                }
            }
        }

        private void GenCharacter_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (var item in RaceList)
            {
                RaceBox.Items.Add(item.CharacterName);
                item.GenCharacter();
                label5.Text = textBox1.Text;
            }
            foreach (var item in JobList)
            {
                JobBox.Items.Add(item.Name);
            }

        }
    }
}
