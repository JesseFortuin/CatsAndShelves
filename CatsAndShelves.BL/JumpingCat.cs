using System.Reflection.Metadata.Ecma335;

namespace CatsAndShelves.BL
{
    public class JumpingCat
    {
        public int JumpsNeeded(int start, int finish)
        {
            int jumpCounter = 0;

            while (start != finish)
            {
                if (start + 3 <= finish)
                {
                    start += 3;

                    jumpCounter++;
                }

                else
                {
                    start += 1;

                    jumpCounter++;
                }
            }

            return jumpCounter;
        }

        //public int JumpsNeeded(int start, int finish)
        //{
        //    List<int> jumpsRecorder= new List<int>();

        //    JumpsNeededRecorder(start, finish, 0, jumpsRecorder);
        //    return jumpsRecorder.Min();
        //}

        //public void JumpsNeededRecorder(int start, int finish, int numberOfJumps, List<int> jumpsRecorder)
        //{

        //    if (start == finish)
        //    {
        //        //success condition
        //        jumpsRecorder.Add(numberOfJumps);
        //    }

        //    if (start < finish)
        //    {
        //        JumpsNeededRecorder(start + 1, finish, numberOfJumps + 1, jumpsRecorder);

        //        JumpsNeededRecorder(start + 3, finish, numberOfJumps + 1, jumpsRecorder);              
        //    }
        //}
    }
}