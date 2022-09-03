using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace ContentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContentController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        { "Javascript", "Typescript", "Node.js", "Asp .Net", ".Net Core", "C#", "HTML", "CSS", "Git", "Apache" };

        private readonly ILogger<ContentController> _logger;

        public ContentController(ILogger<ContentController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSkills")]
        public IEnumerable<Skill> Get()
        {
            return Enumerable.Range(1, 9).Select(index => new Skill
            {
                Id = index + 1,
                Name = Summaries[index],
                TypeId = index < 8 ? 1 : 2
            }).ToArray();
        }
    }
}