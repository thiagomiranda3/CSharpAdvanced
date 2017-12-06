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

        [Fact]
        public void TestandoTipagemDoGenericDictionary()
        {
            var intDictionary = new GenericDictionary<string, int>();

            intDictionary.Add("primeiro", 1);
            intDictionary.Add("segundo", 2);

            Assert.True(intDictionary["primeiro"] == 1, "Deve retornar o valor int 1");
            Assert.True(intDictionary["segundo"].GetType() == typeof(int), "O valor é do tipo definido");

            var stringList = new GenericDictionary<int, string>();
            stringList.Add(10, "Oi");
            
            Assert.True(stringList[10] == "Oi", "Deve retornar o valor Oi");
            Assert.True(stringList[10].GetType() == typeof(string), "O valor é do tipo definido");
        }

        [Fact]
        public void TestandoTipagemDaGenericUtilities()
        {
            var util = new GenericUtilities();

            Assert.True(util.Max<int>(1, 2) == 2, "Deve retornar o valor int 2");
            Assert.True(util.Max(1, 2).GetType() == typeof(int), "O valor é do tipo definido");
            Assert.True(util.Max<double>(10.2, 8.43) == 10.2, "Deve retornar o valor int 10.2");
            Assert.True(util.Max(10.2, 8.43).GetType() == typeof(double), "O valor é do tipo definido");
        }
    }
}