
using System.Runtime.CompilerServices;
using Application.Activities;
using Domain.Activity;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{   
    public class ActivityController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            //api/activitiesp
            return await Mediator.Send(new List.Query());
        } 

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivities(Guid id)
        {
            //api/activitiesbyid/

            return await Mediator.Send(new Details.Query
            {
                Id = id
            });
        }
        [HttpPost]
        public async Task<IActionResult> CreateActivities(Activity activity)
        {
            await Mediator.Send(new Create.Command{Activity = activity});
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> EditActivities(Activity activity, Guid id)
        {
            activity.Id = id;

            await Mediator.Send(new Edit.Command{Activity = activity});

            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivities(Guid id)
        {
            await Mediator.Send(new Delete.Command
            {
                Id = id
            });
            
            return Ok();
        }
    }
}