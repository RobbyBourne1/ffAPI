using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// NFL.COM Fantasy API Stats http://api.fantasy.nfl.com/v1/players/stats?statType=seasonStats&season=2017&week=4&format=json

namespace ffAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var url = "https://sc.api.fantasy.nfl.com/v1/auth/login?appKey=sample&username=allthelavarocks&password=Wubz3993&timestamp=1268089312&signature=c21bdddc4d4b33f1764c38b9200248d8";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var rawResponse = String.Empty;

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                rawResponse = reader.ReadToEnd();
            }

            var OAuthLogin = JsonConvert.DeserializeObject<OAuthLogin>(rawResponse);

            var urlUser = "http://api.fantasy.nfl.com/v1/user/leagues?authToken=MTIzNCYxJjEyNjgwODg4NTY=";
            var requestUser = WebRequest.Create(urlUser);
            var responseUser = requestUser.GetResponse();
            var rawResponseUser = String.Empty;

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                rawResponse = reader.ReadToEnd();
            }

            var UserLogin = JsonConvert.DeserializeObject<UserLogin>(rawResponse);

            var urlTeams = "http://api.fantasy.nfl.com/v1/league/team/roster?leagueId=1&teamId=1&week=4&authToken=MTIzNCYxJjEyNjgwODg4NTY=";
            var requestTeams = WebRequest.Create(urlTeams);
            var responseTeams = requestTeams.GetResponse();
            var rawResponseTeams = String.Empty;

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                rawResponse = reader.ReadToEnd();
            }

            var TeamsAuth = JsonConvert.DeserializeObject<TeamLogin>(rawResponse);

            Console.WriteLine($"AppKey: {OAuthLogin.appKey}");
            return null;


        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
