using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateProjectInputModel : ControllerBase
    {
        public int IdProject { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int IdFrelancer { get; set; }
        public decimal TotalCost { get; set; }
    }
}

