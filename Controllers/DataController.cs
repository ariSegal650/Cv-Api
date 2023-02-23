

using Api.Data;
using Api.Dto;
using Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller 
    {
         public DataContext _Context { get; }
        //private readonly ILogger<DataController> _logger;
       // readonly IGeneratePdf _generatePdf;
        public DataController(DataContext context)
        {
            this._Context = context;
            
        }


        // [HttpPost("GetData")]
        // public async Task<IActionResult> GetDataAsync([FromBody] CvDataDto data)
        // {

        //     return  await _generatePdf.GetPdf("/Views/CvPdf/CreatePdf.cshtml", data);
        
        // }

        
       [HttpPost("Statistics")]
        public async Task<IActionResult> StatisticsAsync([FromBody] StatisticsDto st)
        {  
                StatisticsInfoClass a =new StatisticsInfoClass
                {
                    city=st.city,
                    clicks=st.clicks,
                    download=st.download
                };
                _Context.Users.Add(a);
                await _Context.SaveChangesAsync();
                   var users=  _Context.Users.ToList();
                return new OkObjectResult(users);
        }
    


    }
}