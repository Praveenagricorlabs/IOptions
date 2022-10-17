using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Controllers
{
    
    public class CommunicationEndPoints
    {
        public string GetTaskDetails { get; set; }
        public string UpdateTaskDetails { get; set; }       
    }

    public class Communication
    {
        [Required]
        public string CommunicationBaseURL { get; set; }

        [Range(10,100)]
        public int Count { get; set; }
        public CommunicationEndPoints CommunicationEndPoints { get; set; }
    }
}
