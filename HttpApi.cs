using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using FinalPrepSqlite.Models;
using System.Linq;

namespace FinalPrepSqlite
{
    public class HttpApi
    {

        private readonly ApplicationDbContext _context;
 
        public HttpApi(ApplicationDbContext context) {
            _context = context;
        }
        [FunctionName("HttpApi")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            string responseMessage = string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. This HTTP triggered function executed successfully.";

            return new OkObjectResult(responseMessage);
        }

        [FunctionName("students")]
        public IActionResult GetStudents(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "students")] HttpRequest req,
                ILogger log) {
        
            log.LogInformation("C# HTTP GET trigger function processed api/students request.");

            var studentsArray = _context.Students.ToArray();

            return new OkObjectResult(studentsArray);
        }

    }
}
