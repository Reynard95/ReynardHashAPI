using Microsoft.AspNetCore.Mvc;

namespace ReynardHashAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HashController : ControllerBase
    {
        private readonly ILogger<HashController> _logger;

        public HashController(ILogger<HashController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "PostHash")]
        public UInt64 Post(string stringToHash)
        {
            //value to be returned
            UInt64 hashedValue = 0;

            //neded for while loop
            int i = 0;

            //declaering multiplier
            ulong multiplier = 1;

            //run through string to get hash values
            while (i < stringToHash.Length)
            {
                //add hashed value to prev value
                hashedValue += stringToHash[i] * multiplier;

                //multiplier 33 works best acording to http://www.cse.yorku.ca/~oz/hash.html
                multiplier *= 33;

                //add 1 for next char
                i++;
            }

            //return hash value
            return hashedValue;
        }
    }
}