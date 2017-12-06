using Features.Generics;
using Xunit;

namespace Features.Tests
{
    public class GenericsTest
    {
        [Fact]
        public void TestandoTipagemDaGenericList()
        {
            var intList = new GenericList<int>();

            intList.Add(1);
            intList.Add(2);

            Assert.True(intList[0] == 1, "Deve retornar o valor int 1");
            Assert.True(intList[1].GetType() == typeof(int), "O valor é do tipo definido");

            var stringList = new GenericList<string>();
            stringList.Add("Oi");
            
            Assert.True(stringList[0] == "Oi", "Deve retornar o valor Oi");
            Assert.True(stringList[0].GetType() == typeof(string), "O valor é do tipo definido");
        }
    }
}