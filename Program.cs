using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
 public   class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            List<Team> teamList = new List<Team>();
            while (word!="END")
            {
                try
                {
                    var command = word.Split(";").ToArray();
                    var teamName = command[1];
                    if (command[0]=="Team")
                    {
                        var checkTeam = teamList.Where(x => x.Name == teamName).FirstOrDefault();
                        if (checkTeam==null)
                        {
                            var team = new Team(teamName);
                            teamList.Add(team);
                        }
                    
                    }
                    else if (command[0]=="Add")
                    {
                        var currTeam = teamList.Where(x => x.Name == teamName).FirstOrDefault();
                        if (currTeam!=null)
                        {
                            var playerName = command[2];
                            var endurance = int.Parse(command[3]);
                            var sprint = int.Parse(command[4]);
                            var dribble = int.Parse(command[5]);
                            var passing = int.Parse(command[6]);
                            var shooting = int.Parse(command[7]);
                            Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                            currTeam.AddPlayer(player);

                        }
                        else
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                    }
                    else if (command[0]=="Remove")
                    {
                        var playerName = command[2];
                        var currTeam = teamList.Where(x => x.Name == teamName).FirstOrDefault();
                        var currPlayer = teamList.Select(x => x.Players.Where(x => x.Name ==playerName).FirstOrDefault()).FirstOrDefault();
                        if (currPlayer!=null && currTeam!=null)
                        {
                            currTeam.RemovePlayer(currPlayer);
                        }
                        else
                        {
                            throw new ArgumentException($"Player {playerName} is not in {teamName} team.");
                        }
                    }
                    else if (command[0]=="Rating")
                    {
                        var currTeam = teamList.Where(x => x.Name == teamName).FirstOrDefault();
                        if (currTeam != null)
                        {
                            Console.WriteLine($"{teamName} - {currTeam.Rating}");

                        }
                        else
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }

                    }



                }
                catch (ArgumentException e)
                {

                    Console.WriteLine(e.Message);
                 
                }
                word = Console.ReadLine();
            }
           
         
       
        }
    }
}
