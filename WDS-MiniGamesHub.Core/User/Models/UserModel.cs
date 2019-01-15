using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace WDS_MiniGamesHub.Core.User.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public static Expression<Func<UserModel, UserModel>> Projection
        {
            get
            {
                return user => user;
            }
        }

        public static UserModel Create(UserModel user)
        {
            return Projection.Compile().Invoke(user);
        }
    }
}
