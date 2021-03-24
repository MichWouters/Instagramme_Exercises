using NUnit.Framework;

namespace Instagramme_Exercises.Tests
{
    public class Tests
    {
        private UserRepository _repo;

        [SetUp]
        public void Setup()
        {
            _repo = new UserRepository();
        }

        [Test]
        public void Exercise1_FindUserWithAllPosts()
        {
            /*
             * SELECT * FROM Users
             * JOIN Posts ON Posts.UserId = Users.UserId
             * WHERE Users.UserId = 1
            */

            // ARRANGE
            int userId = 1;

            // ACT
            var user = _repo.FindUserWithPosts(userId);

            //ASSERT
            Assert.IsNotNull(user);
        }
    }
}