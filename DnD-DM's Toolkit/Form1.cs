using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_DM_s_Toolkit
{

    
    enum dice
    {
        d4,
        d8,
        d10,
        d12,
        d20,
        d100
    }
    enum Size
    {
        tiny,
        small,
        medium,
        large,
        huge,
        gargantuan
    }

    enum Stat
    {
        strength,
        dexterity,
        constitution,
        intelligence,
        wisdom,
        charisma
    }

    enum Saves
    {
        strength,
        dexterity,
        constitution,
        intelligence,
        wisdom,
        charisma
    }

    enum Skill
    {
        acrobatics,
        animalHandling,
        arcana,
        athletics,
        deception,
        history,
        insight,
        intinidation,
        investigation,
        medicine,
        nature,
        performance,
        persuasion,
        religion,
        sleightOfHand,
        stealth,
        survival
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            healing h = new healing(spell.Level.one, "thunder", "you telling this story or am I?");
            
        }
    }
}
