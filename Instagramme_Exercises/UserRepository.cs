using Instagramme_Exercises.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagramme_Exercises
{
    public class UserRepository
    {
        private InstagrammeContext context;

        public UserRepository()
        {
            context = new InstagrammeContext();
        }

        public User FindUserWithPosts(int id)
        {
            /*
             * SELECT * FROM Users
             * JOIN Posts ON Posts.UserId = Users.UserId
             * WHERE Users.UserId = 1
            */

            return context.Users
                .Include(x => x.Posts)
                .FirstOrDefault(x => x.UserId == id);
        }
    }
}
