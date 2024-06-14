using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01691175.Controllers
{


 
    public class J1Controller : ApiController
    {
        /// <summary>
        /// The link to the J1 question is here:
        /// https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2024/ccc/juniorEF.pdf
        /// There is a new conveyor belt sushi restaurant. Plates of sushi are on the conveyor belt.
        /// Each red plate of sushi = $3, Green plate = $4, Blue plate = $5
        /// Determine the cost of a meal, given the number of plates of each color chosen by customer
        /// </summary>
        /// <param name="R">Number of Red Plates</param> 
        /// <param name="G">Number of Green Plates</param>
        /// <param name="B">Number of Blue Plates</param>
        /// <returns>
        /// integer number of {C}
        /// </returns>
        /// <example>
        /// curl http://localhost:12180/api/J1/Sushi/0/2/4 
        /// -> "This customer chose 0 red plates, 2 green plates, and 4 blue plates.
        ///    Therefore, the cost of the meal in dollars is 0 x 3 + 2 X 4 + 4 X 5 = 28."
        /// </example>
        [HttpGet]
        [Route("api/J1/Sushi/{R}/{G}/{B}")]
        public string Sushi(int R, int G, int B)
        {
            int C = R*3 + G*4 + B*5;
            string explanation= "This customer chose " + R + " red plates, " + G + " green plates, and "
                + B + " blue plates."
                + "Therefore, the cost of the meal in dollars is "
                + R + " x 3 + " + G + " X 4 + " + B + " X 5 = " + C + ".";
            return explanation;
        }
    }
}