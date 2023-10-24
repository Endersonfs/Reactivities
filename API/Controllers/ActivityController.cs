
using Domain.Activity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{   
    public class ActivityController : BaseApiController
    {
        private readonly DataContext _dataContextt;
        public ActivityController(DataContext dataContext)
        {
            _dataContextt = dataContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            //api/activities
            return await _dataContextt.Activities.ToListAsync();
        } 

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivities(Guid id)
        {
            //api/activitiesbyid/

            return await _dataContextt.Activities.FindAsync(id);
        } 
    }
}