using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01691175.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// This method takes in the amount of participants and their scores, then outputs the score needed for the bronze award
        /// and the amount of participants having this score. 
        /// </summary>
        /// <param name="N"> a single integer representing a participant's score</param>
        /// <param name="scoreInput">all the participant's scores, separated by "," </param>
        /// <returns>
        /// A non negative integer S, score required for bronze level
        /// A positive integer P, how many participants achieved this score
        /// </returns>
        /// <example>
        ///http://localhost:12180/api/J3/Bronze/4/70,62,58,73  
        ///--> The score required for bronze level is 62 and 1 number of participant achieved this score.
        ///http://localhost:12180/api/J3/Bronze/4/8,75,70,60,70,70,60,75,70
        ///--> The score required for bronze level is 60 and 2 number of participant achieved this score.
        /// </example>
 
        [HttpGet]
        [Route("api/J3/Bronze/{N}/{scoreInput}")]
        public string Bronze(int N, string scoreInput)
        {
            //Turn the string that the user inputted into a string array
            string[] scoreString = scoreInput.Split(',');

            //Turn the string array called scoreString into an integer array called scoreList
            int[] scoreList = new int[scoreString.Length];
           
            for (int i=0; i<scoreString.Length; i++ )
            {
                scoreList[i] = int.Parse(scoreString[i]);
            }

            //If there is less than 3 participants, there will be no bronze reward holders. 
            string failMessage = "There are not enough participants for the bronze prize. Please add more participants.";

            if (scoreList.Length < 3)
            {
                return failMessage;
            }

            //Sort the array from scores large to small
            Array.Sort(scoreList);
            Array.Reverse(scoreList);

            //Count only the distinct scores.
            List<int> unique = new List<int>();

            foreach (int score in scoreList)
            {
                if (!unique.Contains(score))
                {
                    unique.Add(score);
                }

            }

            //Count how many people achieved the bronze score by creating a list
            List<int> bronzeAchieve = new List<int>();
            foreach (int score in scoreList)
            {
                if (score == unique[2])
                {
                    bronzeAchieve.Add(score);
                }
            }

            // S is the score needed to get the bronze award
            int S = unique[2];

            // P is the amount of people that got the bronze award
            int P = bronzeAchieve.Count; 
            
            //Output final message. 
            string successMessage = "The score required for bronze level is " + S.ToString() + " and " + P.ToString() + " number of participant achieved this score.";
            


           
            return successMessage;

            //ALTERNATIVE METHOD with LINQ
            /*Use LINQ instead of loop to create the list
            List<int> scoresListAscend = scoresString.Select(int.Parse).ToList();

            //Use LINQ to reverse the list so that it orders from largest to smallest
            List<int> scoreListDesc = scoresListAscend.OrderByDescending( score => score ).ToList();

            // The amount of score needed to get bronze. 
            int S = scoreListDesc[2];

            int P = scoreListDescCount  - 3;
                string message = "The score required for bronze level is " + S.ToString() + " and " + P.ToString() + " number of participant achieved this score.";
            return message; */

        }
    }
}
