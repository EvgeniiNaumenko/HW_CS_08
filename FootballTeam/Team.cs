using HW_08_12_06_2024.Oceanarium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_12_06_2024.FootballTeam
{
    internal class Team:IEnumerable
    {
        public string Name { get; set; }
        public List<Player> _team;
        public Team(string name, List<Player> team)
        {
            Name = name;
            _team = team;
        }
        public Team (string name)
        {
            Name = name;
            _team = new List<Player>();
        }
        public override string ToString()
        {
            Console.WriteLine(Name);
            foreach (var item in _team)
            {
                Console.WriteLine(item);
            }
            return "";
        }
        public void AddPlayer(Player player)
        {
            if (player != null)
            {
                _team.Add(player);
            }
        }
        public void RemovePlayer(string name) 
        {
            foreach(var item in _team)
            {
                if(item.Name == name)
                { 
                    _team.Remove(item);
                }
            }
        }
        public static Team operator+ (Team team, Player player)
        {
            if (player != null)
            {
                team.AddPlayer(player);
            }
            return team;

        }
        public static Team operator- (Team team,string name)
        {
            team._team.RemoveAll(pl => pl.Name == name);
            return team;
        }
        public static Team operator- (Team team,Player player)
        {
            team._team.RemoveAll(pl => pl.Name == player.Name);
            return team;
        }
        public IEnumerator<Player> GetEnumerator()
        {
            foreach (var player in _team)
            {
                yield return player;
            }
        }
        public Player this[int index]
        {
            get
            {
                if (index >= 0 && index < _team.Count)
                {
                    return _team[index];
                }
                else
                {
                    throw new Exception ($"Некорректный индекс!  {index}");
                }
            }
            set
            {
                if (index >= 0 && index < _team.Count)
                {
                    _team[index] = value;
                }
                else
                {
                    throw new Exception($"Некорректный индекс!  {index}");
                }
            }
        }
    }
}
