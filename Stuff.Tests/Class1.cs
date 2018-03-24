using NUnit.Framework;
using StuffApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuff.Tests
{
    [TestFixture]
    public class NameRegistrationTests
    {
        [Test]
        public void Entering_one_name_results_in_the_first_name_being_filled_out()
        {
            //Arrange - take the context from scenerio and put it into code
            var name = "Cher";
            var nameParser = new NameParser();

            //Act
            var result = nameParser.Parse(name);


            //Assert
            Assert.AreEqual("Cher", result.FirstName);
            Assert.IsNull(result.MiddleName);
            Assert.IsNull(result.LastName);


        }
    

    [Test]
    public void Entering_two_name_results_in_the_first_nameand_lat_name_being_filled_out()
    {
        //Arrange - take the context from scenerio and put it into code
        var name = "John Doe";
        var nameParser = new NameParser();

        //Act
        var result = nameParser.Parse(name);


        //Assert
        Assert.AreEqual("John", result.FirstName);
        Assert.IsNull(result.MiddleName);
        Assert.AreEqual("Doe", result.LastName);


    }

        [Test]
        public void Entering_three_name_results_in_the_first_nameand_middlename_and_last_name_being_filled_out()
        {
            //Arrange - take the context from scenerio and put it into code
            var name = "John Richard Doe";
            var nameParser = new NameParser();

            //Act
            var result = nameParser.Parse(name);


            //Assert
            Assert.AreEqual("John", result.FirstName);
            Assert.AreEqual("Richard", result.MiddleName);
            Assert.AreEqual("Doe", result.LastName);


        }
    }
}
