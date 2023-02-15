using CatsAndShelves.BL;

namespace CatsAndShelves.Test
{
    public class JumpingCatTest
    {
        [Fact]
        public void JumpsNeededTest_1()
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

        [Fact]
        public void JumpsNeededTest_2()
        {
            //arrange
            JumpingCat jump = new JumpingCat();

            var start = 2;

            var finish = 5;

            var expected = 1;

            //act
            int actual = jump.JumpsNeeded(start, finish);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}