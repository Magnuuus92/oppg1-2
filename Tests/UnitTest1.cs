using Xunit;

namespace Tests;


public class UnitTest1

{
    [Fact]
    public void Add_ShouldStoreValuesCorrectly()
    {
        //arrange
        var list = new List<string>
        {
            //act
            "10",
            "15",
            "30"
        };
        list.RemoveAt(1);
        // denne skal fjerne 15 på plass 2 så 30 som egentlig er på plass 3 tar plass 2. 

        //assert
        list.Equals(list[1] == "30");
        list.Equals(list[0] == "10");




    }
}
