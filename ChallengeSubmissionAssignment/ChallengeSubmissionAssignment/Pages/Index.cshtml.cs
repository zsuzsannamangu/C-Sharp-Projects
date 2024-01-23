using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChallengeSubmissionAssignment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //public DateTime timeInUTC { get; set; }

        public void OnGet() //the onGet() method is fired and thus the UTC time is displayed when the page opens, because the HTTP GET verb was used for the request
        {
            //DateTime currentTime = DateTime.Now; // gives you current Time in current timezone
            //timeInUTC = currentTime.ToUniversalTime(); // convert it to UTC using timezone setting of server computer
            
        }
    }
}