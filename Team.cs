using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> listPlayer;


        public Team(string name)
        {
            this.Name = name;
            this.listPlayer = new List<Player>();
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
        //private double rating = 0;
        public int Rating {
            get
            {
                if (listPlayer.Count > 0)
                {
                    var result = (int)Math.Ceiling(listPlayer.Average(x => x.SkillLevel));
                    return result;
                }
                return 0;
            }
} 
        public IReadOnlyCollection<Player> Players
        {
            get { return listPlayer.AsReadOnly(); }
        }

        public void AddPlayer(Player player)
        {
            listPlayer.Add(player);

        }
        public void RemovePlayer(Player player)
        {
            listPlayer.Remove(player);

        }


    }
}
