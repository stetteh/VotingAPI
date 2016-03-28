using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingAPI.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public virtual Candidate candiate { get; set; }
        public virtual Voter voter { get; set; }

    }
}