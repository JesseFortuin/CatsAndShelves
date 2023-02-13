using CatsAndShelves.BL;

namespace CatsAndShelves.Test
{
    public class JumpingCatTest
    {
        [Fact]
        public void JumpsNeededTest()
        {
            //arrange
            JumpingCat jump = new JumpingCat();

            var start = 1;

            var finish = 5;

            var expected = 2;

            //act
            int actual = jump.JumpsNeeded(start, finish);

            //assert
            Assert.Equal(expected, actual);       
        }
    }
}