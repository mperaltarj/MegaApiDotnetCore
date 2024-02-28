using System.Collections.Generic;
using Megaman.Dtos;
using api.Domain.Entities;

namespace api.App.Services
{
    public interface IRobotServices
    {
         IEnumerable<Robot> SearchAll();

        RobotReadDTO SearchById(int id);
         

    }
}