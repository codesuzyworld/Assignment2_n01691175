using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01691175.Controllers
{

    public class J2Controller : ApiController
    {
        /// <summary>

        /// </summary>
        /// <param name="D"> Dusa size</param> 
        /// <param name="Yobi"> Yobi input </param>
        /// <returns>
        /// The final size of Dusa before it runs away due to the Yobi larger than it
        /// </returns>
        /// <example>
        /// http://localhost:12180/api/J2/Dusa/5/2,3,5,6 ---> 10
        /// http://localhost:12180/api/J2/Dusa/5/10,3,5,6 ---> 5
        /// http://localhost:12180/api/J2/Dusa/5/-10,1,5,6 --> -5
        /// http://localhost:12180/api/J2/Dusa/5/3,2,9,20,22,14 --> 19 
        /// http://localhost:12180/api/J2/Dusa/10/10,3,5,13 --> 10
        /// </example> 

        [HttpGet]
        [Route("api/J2/Dusa/{D}/{Yobi}")]
        public int Dusa(int D, string Yobi)
        {
            //Allow the string to be split into an array
            string[] yobis = Yobi.Split(',');

            // set i as the starting index of the array yobis
            int i = 0;

            // If Dusa is bigger than the Yobi, then add them together
            // Then increase the index by one
            // Loop will stop if the Yobi is bigger than the Dosa 
            while (D > int.Parse(yobis[i])){
                D = D + int.Parse(yobis[i]);
                i++;
            }

            // return the number of Dusa
            return D;


        }
    }
}
