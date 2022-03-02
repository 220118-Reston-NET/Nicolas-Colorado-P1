using Xunit;
using ShopModel;

namespace ShopTest
{
    public class ManagerModeltest
    {
        /// <summary>
        ///  Checks the validation for username property for valid data.
        /// </summary>
        [Fact]
        public void ManagerUserShouldSetValidData()
        {
            //Arrange
            Manager manager = new Manager();
            string validuser = "unitester300";
    
            //Act
            manager.username = validuser;
    
            //Assert
            Assert.NotNull(manager.username); 
            Assert.Equal(validuser, manager.username); 
        }

        /// <summary>
        ///  Checks the validation for password property for valid data.
        /// </summary>
        [Fact]
        public void ManagerPassShouldSetValidData()
        {
            //Arrange
            Manager manager = new Manager();
            string validpass = "ni515234";
    
            //Act
            manager.password = validpass;
    
            //Assert
            Assert.NotNull(manager.password); 
            Assert.Equal(validpass, manager.password); 
        }
    }
}