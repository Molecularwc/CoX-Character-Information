using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CoX_Character_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void characterTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //This saves your character information to the database when clicked
            this.Validate();
            this.characterTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.characterDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'characterDataSet.characterTable' table. You can move, or remove it, as needed.
            this.characterTableTableAdapter.Fill(this.characterDataSet.characterTable);
            //This loads the splash screen up prior to showing the main program form
            LoadSplash ls = new LoadSplash();
            ls.Show();
            Thread.Sleep(2000);
            this.Show();
            ls.Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //this opens up the report form
            Report report = new Report();
            report.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //this opens up the about box
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //this opens up the help form
            Help help = new Help();
            help.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //the following code is done when the add new item button is clicked on the navigator
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox1.Items.AddRange(new object[] {
            "Magic",
            "Mutant",
            "Natural",
            "Science",
            "Technology"});
            comboBox2.Items.AddRange(new object[] {
            "Champion",
            "Freedom",
            "Guardian",
            "Infinity",
            "Justice",
            "Liberty",
            "Pinnacle",
            "Protector",
            "Triumph",
            "Victory",
            "Virtue"});
            comboBox4.Items.AddRange(new object[] {
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25",
            "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37","38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50"});
            
        }

        private void comboBox3_SelectionChangeCommitted(Object sender, EventArgs e)
        {
            //the following code is what happens when the selections change in the Archtype Combobox of Form1
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();

            if (comboBox3.SelectedItem.Equals("Blaster"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] {
            "Archery",
            "Assault Rifle",
            "Electrical Blast",
            "Energy Blast",
            "Fire Blast",
            "Ice Blast",
            "Psychic Blast",
            "Radiation Blast",
            "Sonic Attack"});
                comboBox6.Items.AddRange(new object[] {
            "Electricity Manipulation",
            "Energy Manipulation",
            "Fire Manipulation",
            "Devices",
            "Ice Manipulation",
            "Mental Manipulation"});
                comboBox1.Items.AddRange(new object[] {
                    "Magic",
                    "Mutant",
                    "Natural",
                    "Science",
                    "Technology"});
            }
            else if (comboBox3.SelectedItem.Equals("Arachnos Soldier"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] {
                    "Arachnos Soldier", 
                    "Crab Spider Soldier", 
                    "Bane Spider Soldier" });
                comboBox6.Items.AddRange(new object[] {
                    "Training and Gadgets", 
                    "Crab Spider Training", 
                    "Bane Spider Training" });
                comboBox1.Items.AddRange(new object[] { "Natural" });
            }
            else if (comboBox3.SelectedItem.Equals("Arachnos Widow"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] {
                    "Widow Training", 
                    "Fortunata Training", 
                    "Night Widow Training" });
                comboBox6.Items.AddRange(new object[] {
                    "Teamwork", 
                    "Fortunata Teamwork", 
                    "Widow Teamwork"});
                comboBox1.Items.AddRange(new object[] { "Natural" });
            }
            else if (comboBox3.SelectedItem.Equals("Brute"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] {
                    "Battle Axe",
                    "Claws",
                    "Dark Melee", 
                    "Dual Blades", 
                    "Electrical Melee", 
                    "Energy Melee", 
                    "Fiery Melee", 
                    "Stone Melee", 
                    "Super Strength",
                    "War Mace"});
                comboBox6.Items.AddRange(new object[] {
                    "Dark Armor",
                    "Electric Armor",
                    "Energy Armor",
                    "Fiery Armor",
                    "Invulnerability",
                    "Shield Defense",
                    "Stone Armor",
                    "Super Reflexes",
                    "Willpower"});
                comboBox1.Items.AddRange(new object[] {
                    "Magic",
                    "Mutant",
                    "Natural",
                    "Science",
                    "Technology"});
            }
            else if (comboBox3.SelectedItem.Equals("Controller"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] {
                    "Earth Control",
                    "Fire Control",
                    "Gravity Control",
                    "Ice Control",
                    "Illusion Control",
                    "Mind Control",
                    "Plant Control"});
                comboBox6.Items.AddRange(new object[] {
                    "Cold Domination",
                    "Empathy",
                    "Force Field",
                    "Kinetics",
                    "Radiation Emission",
                    "Sonic Resonance",
                    "Storm Summoning",
                    "Thermal Radiation",
                    "Trick Arrow"});
                comboBox1.Items.AddRange(new object[] {
                    "Magic",
                    "Mutant",
                    "Natural",
                    "Science",
                    "Technology"});
            }
            else if (comboBox3.SelectedItem.Equals("Corruptor"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] {
                    "Archery",
                    "Assault Rifle",
                    "Dark Blast",
                    "Electrical Blast",
                    "Energy Blast",
                    "Fire Blast",
                    "Ice Blast",
                    "Radiation Blast",
                    "Sonic Attacks"});
                comboBox6.Items.AddRange(new object[] {
                    "Cold Domination",
                    "Dark Miasma",
                    "Kinetics",
                    "Pain Domination",
                    "Radiation Emission",
                    "Sonic Resonance",
                    "Storm Summoning",
                    "Thermal Radiation",
                    "Traps",
                    "Trick Arrow" });
                comboBox1.Items.AddRange(new object[] {
                    "Magic",
                    "Mutant",
                    "Natural",
                    "Science",
                    "Technology"});
            }
            else if (comboBox3.SelectedItem.Equals("Defender"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] {
                    "Cold Domination",
                    "Dark Miasma",
                    "Empathy",
                    "Force Field",
                    "Kinetics",
                    "Radiation Emission",
                    "Sonic Resonance",
                    "Storm Summoning",
                    "Traps",
                    "Trick Arrow"});
                comboBox6.Items.AddRange(new object[] {
                    "Archery",
                    "Assault Rifle",
                    "Dark Blast",
                    "Electrical Blast",
                    "Energy Blast",
                    "Ice Blast",
                    "Psychic Blast",
                    "Radiation Blast",
                    "Sonic Attack"});
                comboBox1.Items.AddRange(new object[] {
                    "Magic",
                    "Mutant",
                    "Natural",
                    "Science",
                    "Technology"});
            }
            else if (comboBox3.SelectedItem.Equals("Dominator"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] {
                    "Earth Control",
                    "Fire Control",
                    "Gravity Control",
                    "Ice Control",
                    "Mind Control",
                    "Plant Control"});
                comboBox6.Items.AddRange(new object[] {
                    "Earth Assault",
                    "Electricity Assault",
                    "Energy Assault",
                    "Fiery Assault",
                    "Icy Assault",
                    "Psionic Assault",
                    "Thorny"});
                comboBox1.Items.AddRange(new object[] {
                    "Magic",
                    "Mutant",
                    "Natural",
                    "Science",
                    "Technology"});
            }
            else if (comboBox3.SelectedItem.Equals("Mastermind"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] {
                    "Mernecaries",
                    "Necromancy",
                    "Ninjas",
                    "Robotics",
                    "Thugs"});
                comboBox6.Items.AddRange(new object[] {
                    "Dark Miasma",
                    "Force Field",
                    "Pain Domination",
                    "Poison",
                    "Storm Summoning",
                    "Thermal Radiation",
                    "Traps",
                    "Trick Arrow"});
                comboBox1.Items.AddRange(new object[] {
                    "Magic",
                    "Mutant",
                    "Natural",
                    "Science",
                    "Technology"});
            }
            else if (comboBox3.SelectedItem.Equals("Peacebringer"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] { "Luminous Blast" });
                comboBox6.Items.AddRange(new object[] { "Luminous Aura" });
                comboBox1.Items.AddRange(new object[] { "Natural" });
            }
            else if (comboBox3.SelectedItem.Equals("Scrapper"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] {
                    "Broad Sword",
                    "Claws",
                    "Dark Melee",
                    "Dual Blades",
                    "Electric Melee",
                    "Fiery Melee",
                    "Katana",
                    "Martial Arts",
                    "Spines"});
                comboBox6.Items.AddRange(new object[] {
                    "Dark Armor",
                    "Electric Armor",
                    "Fiery Armor",
                    "Invulnerability",
                    "Regeneration",
                    "Shield Defense",
                    "Super Reflexes",
                    "Willpower"});
                comboBox1.Items.AddRange(new object[] {
                    "Magic",
                    "Mutant",
                    "Natural",
                    "Science",
                    "Technology"});
            }
            else if (comboBox3.SelectedItem.Equals("Stalker"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] {
                    "Broad Sword",
                    "Claws",
                    "Dark Melee",
                    "Dual Blades",
                    "Electric Melee",
                    "Energy Melee",
                    "Martial Arts",
                    "Ninja Blade",
                    "Spines"});
                comboBox6.Items.AddRange(new object[] {
                    "Dark Armor",
                    "Electric Armor",
                    "Energy Armor",
                    "Ninjitsu",
                    "Regeneration",
                    "Super Reflexes",
                    "Willpower"});
                comboBox1.Items.AddRange(new object[] {
                    "Magic",
                    "Mutant",
                    "Natural",
                    "Science",
                    "Technology"});
            }
            else if (comboBox3.SelectedItem.Equals("Tanker"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] {
                    "Dark Armor",
                    "Electric Armor",
                    "Fiery Armor",
                    "Ice Armor",
                    "Invulnerability",
                    "Shield Defense",
                    "Stone Armor",
                    "Willpower"});
                comboBox6.Items.AddRange(new object[] {
                    "Battle Axe", 
                    "Dark Melee", 
                    "Dual Blades",
                    "Electric Melee",
                    "Energy Melee",                    
                    "Fiery Melee",
                    "Ice Melee",
                    "Stone Melee", 
                    "Super Strength",
                    "War Mace"});
                comboBox1.Items.AddRange(new object[] {
                    "Magic",
                    "Mutant",
                    "Natural",
                    "Science",
                    "Technology"});
            }
            else if (comboBox3.SelectedItem.Equals("Warshade"))
            {
                comboBox1.Items.Clear();
                comboBox5.Items.AddRange(new object[] { "Umbral Blast" });
                comboBox6.Items.AddRange(new object[] { "Umbral Aura" });
                comboBox1.Items.AddRange(new object[] { "Science" });
            }
        }

        private void comboBox7_SelectionChangedCommited(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            if (comboBox7.SelectedItem.Equals("Hero"))
            {
                comboBox3.Items.AddRange(new object[] {
                    "Blaster", 
                    "Controller", 
                    "Defender", 
                    "Peacebringer", 
                    "Scrapper", 
                    "Tanker", 
                    "Warshade"});
            }
            else if (comboBox7.SelectedItem.Equals("Villain"))
            {
                comboBox3.Items.AddRange(new object[] {
                    "Arachnos Soldier",
                    "Arachnos Widow",
                    "Brute",
                    "Corruptor",
                    "Dominator",
                    "Mastermind",
                    "Stalker"});
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //this is what is done when the Close button is clicked on Form1
            if (MessageBox.Show("Do you want to save your information before exiting?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Be sure to click the Save button before exiting.");
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
