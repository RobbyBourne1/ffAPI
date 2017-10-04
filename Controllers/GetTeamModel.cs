using System;
using System.Collections.Generic;
using System.IO;

namespace ffAPI
{
   public class OAuthLogin
   {
       public int appKey { get; set; }
       public string username { get; set; }
       public string password { get; set; }
       public DateTime timestamp { get; set; }
       public string signature { get; set; }
       public string format { get; set; }
       public string callback { get; set; }
       public string returnHTML { get; set; }
   } 

   public class UserLogin 
   {
       public string authToken { get; set; }
       public string format { get; set; }
       public string callback { get; set; }
       public string returnHTML { get; set; }
   }

   public class TeamLogin 
   {
       public string authToken { get; set; }
       public int leagueId { get; set; }
       public int teamId { get; set; }
       public int week { get; set; }
       public int statSeason { get; set; }
       public int statWeek { get; set; }
       public string format { get; set; }
       public string callback { get; set; }
       public string returnHTML { get; set; }

   }
}