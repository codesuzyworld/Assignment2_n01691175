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

        // order the array -> INDEX: 0- gold 1- silver 2- bronze 
        // S = scores[2] P = scores.Count
        //http://localhost:12180/api/J3/Bronze/4/70,62,58,73 - 73 70 62 58

        [HttpGet]
        [Route("api/J3/Bronze/{N}/{score}")]
        public string Bronze(int N, string scoreInput)
        {
            string[] scoreString = scoreInput.Split(',');
            List<int> scoreList = new List<int>();

            foreach (string score in scoreString)
            {
            
                string message = "The score required for bronze level is " + S.ToString() + " and " + P.ToString() + " number of participant achieved this score.";

            }


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
