using Modificabilidade.Domain.Entities.Base;
using Modificabilidade.Domain.Entities.ValuesObjects;

namespace Modificabilidade.Tests;

[TestClass]
public class UserTest
{
    [TestMethod]
    public void Validate_Name_Is_Not_Null()
    {
        
        
        //Arrange
        //var name = new Name(null, null);
        
       var result = Assert.ThrowsException<DomainException>(() => new Name(null, "Doe"));

       // Assert
       Assert.AreEqual("First name is required", result.Message);
        
    }
}