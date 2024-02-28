using System.Collections.Generic;
using api.Domain.Entities;

namespace Megaman.Database
{
    public interface IRobotRepository
    {
        bool SaveChanges();

        IEnumerable<Robot> GetAllRobots();
        
        Robot GetRobotById(int id);

        void AddRobot(Robot robot);
        
    }
}