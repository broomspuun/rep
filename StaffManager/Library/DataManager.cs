using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Library
{
    public static class DataManager
    {
        //получить всех пользователей
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            List<string> userData = new List<string>();
            try
            {
                List<string> lines = File.ReadAllLines("Users.txt").ToList();
                foreach (string line in lines)
                {
                    userData = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    users.Add(new User(userData[0], userData[1], int.Parse(userData[2]), userData[3]));
                    userData.Clear();
                }
            }
            catch
            {
                _ = File.Create("Users.txt");
            }
            return users;
        }


        //получить все позиции
        public static List<Position> GetAllPositions()
        {
            List<Position> positions = new List<Position>();
            try
            {
                List<string> lines = File.ReadAllLines("Positions.txt").ToList();
                foreach (string line in lines)
                    positions.Add(new Position(line.Trim(), new List<User> { }));
                foreach (User user in GetAllUsers())
                { 
                    if (lines.Contains(user.NameOfPosition)==false)
                    {
                        using (StreamWriter writer = new StreamWriter("Positions.txt", true))
                            writer.WriteLine(user.NameOfPosition);
                        lines.Add(user.NameOfPosition);
                        positions.Add(new Position(user.NameOfPosition, new List<User> { }));
                    }
                    else
                    {
                        foreach (Position position in positions)
                        {
                            if (user.NameOfPosition == position.Name)
                                position.Add(user);
                        }
                    }
                }

            }
            catch
            {
                _ = File.Create("Positions.txt");
            }
            return positions;
        }

        //создать сотрудника
        public static void CreateUser(string name, string surName, int salary, string position)
        {
            using (StreamWriter writer = new StreamWriter("Users.txt", true))
            {
                if (name.Trim().Length == 0)
                    name = "Default";
                if (surName.Trim().Length == 0)
                    surName = "Default";
                if (position.Trim().Length == 0)
                    position = "Default";

                writer.WriteLine(name.Trim() + " " + surName.Trim() + " " + salary + " " + position.Trim());
            }
        }
    }
}
