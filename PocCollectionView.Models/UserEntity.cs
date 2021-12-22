using System;
using System.Collections.Generic;
using System.Text;

namespace PocCollectionView.Models
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Picture { get; set; }
        public string Email { get; set;}
        public string Phone { get; set;}
        public DateTime BornDate { get; set; }

        public UserEntity(int id, string firstname, string picture, string email, string phone, DateTime bornDate)
        {
            Id = id;
            Firstname = firstname;
            Picture = picture;
            Email = email;
            Phone = phone;
            BornDate = bornDate;
        }
    }
}
