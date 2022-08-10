using System.Collections.Generic;

namespace Library
{
    public class DataStore
    {
        public List<User> AllUsers { get; set; } = DataManager.GetAllUsers();
        public List<Position> AllPositions { get; set; } = DataManager.GetAllPositions();
    }
}
