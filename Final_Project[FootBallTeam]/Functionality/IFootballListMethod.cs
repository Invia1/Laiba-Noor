using Day_9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9.Functionality
{
    public interface IFootballListMethod
    {
        int CreatePlayer(Player player);

        List<Player> GetPlayers();
        void UpdatePlayer(int id);
        void SearchPlayer(int id);
        void RemovePlayer(int id);
    }
}
