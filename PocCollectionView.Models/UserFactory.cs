using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PocCollectionView.Models
{
    public class UserFactory
    {
        private static List<string> _names = new List<string>() { "Thomas", "Axel", "Sébastien", "Charlie", "Georges", "Théo", "Kilian", "Samuel", "Anthony", "Hugo"};
        public static IEnumerable<UserEntity> GenerateUser(int numberOfUser = 100)
        {
            List<UserEntity> users = new List<UserEntity>();
            var random = new Random();

            for (int i = 0; i < numberOfUser; i++)
            {
                var user = new UserEntity(i, _names[random.Next(0, _names.Count - 1)], "https://picsum.photos/400/300", "a.b@gmail.com", "06 07 29 01 78");
                users.Add(user);
            }


            return users;
        }
    }
}
