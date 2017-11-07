using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArgenSearch;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            var persona = ArgenSearchClient.Search(123456).Result;
            var id = persona.Data[0];
            Assert.IsTrue(persona.Success);

            var datos = ArgenSearchClient.Detail(id).Result;
            Assert.IsTrue(datos.Success);

            var notExists = ArgenSearchClient.Search(1234567812).Result;
            Assert.IsFalse(notExists.Success);
        }
    }
}
