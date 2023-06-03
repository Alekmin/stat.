using System.Reflection.Metadata;
using stat_;

namespace stat.Test
{
    public class Tests
    {
        [Test]
        public void WhenUserGetTwoSetOfPoint_ShouldReturnSumCorrectResult()
        {
            // arrange 
            var employee = new Employee ("Alek","Kowal","Alek1234","21");
            employee.Addscore(10);
            employee.Addscore(5);
            employee.Addscore(-10);
            employee.Addscore(-4);
            // act
            var result = employee.Resoult;

            //assert
            Assert.AreEqual(1, result);

        }
       
       
    }
}