using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const int minRange = 0;
        private const int maxRange = 100;


        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        private readonly double sum;
       
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            this.sum = this.endurance + this.dribble + this.sprint + this.passing + this.shooting;
        }

       
        public double SkillLevel =>  sum/5;
      



        public int Shooting
        {
            get { return shooting; }
          private  set
            {
                if (value < minRange || value > maxRange)
                {
                    throw new ArgumentException($"Shooting should be between {minRange} and {maxRange}.");
                }
                shooting = value;
            }
        }

        public int Passing
        {
            get { return passing; }
            private set
            {
                if (value < minRange || value > maxRange)
                {
                    throw new ArgumentException($"Passing should be between {minRange} and {maxRange}.");
                }
                passing = value;
            }
        }

        public int Dribble
        {
            get { return dribble; }
            private set
            {
                if (value < minRange || value > maxRange)
                {
                    throw new ArgumentException($"Dribble should be between {minRange} and {maxRange}.");
                }
                dribble = value;
            }
        }

        public int Sprint
        {
            get { return sprint; }
            private set
            {
                if (value < minRange || value > maxRange)
                {
                    throw new ArgumentException($"Sprint should be between {minRange} and {maxRange}.");
                }
                sprint = value;
            }
        }

        public int Endurance
        {
            get { return endurance; }
            private set
            {
                if (value < minRange || value > maxRange)
                {
                    throw new ArgumentException($"Endurance should be between {minRange} and {maxRange}.");
                }
                endurance = value;
            }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value=="")
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }



    }
}
