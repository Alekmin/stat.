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
            var user = new User("Alek","Alek1234","21");
            user.Addscore(10);
            user.Addscore(5);
            user.Addscore(-10);
            user.Addscore(-4);
            // act
            var result = user.Resoult;

            //assert
            Assert.AreEqual(1, result);

        }
       
       
    }
}