
using Domain.Activity;

namespace Persistence.Seed;
public class Seed
{
    public static async Task SeedData(DataContext context)
    {
        if(context.Activities.Any()) return;

        var activityList = new List<Activity>
        {  
            #region Datos a Guardar para Activiy
            
            new Activity
            {
                Title = "Past Activity 1",
                Date = DateTime.UtcNow.AddMonths(-1),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 2",
                Date = DateTime.UtcNow.AddMonths(-1),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 3",
                Date = DateTime.UtcNow.AddMonths(-1),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 4",
                Date = DateTime.UtcNow.AddMonths(-1),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 5",
                Date = DateTime.UtcNow.AddMonths(-14),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 6",
                Date = DateTime.UtcNow.AddMonths(-1),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 7",
                Date = DateTime.UtcNow.AddMonths(-13),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 8",
                Date = DateTime.UtcNow.AddMonths(-19),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 9",
                Date = DateTime.UtcNow.AddMonths(-17),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 10",
                Date = DateTime.UtcNow.AddMonths(-15),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 11",
                Date = DateTime.UtcNow.AddMonths(-14),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 12",
                Date = DateTime.UtcNow.AddMonths(-13),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 13",
                Date = DateTime.UtcNow.AddMonths(-12),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 14",
                Date = DateTime.UtcNow.AddMonths(-12),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 15",
                Date = DateTime.UtcNow.AddMonths(-11),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            },
            new Activity
            {
                Title = "Past Activity 1",
                Date = DateTime.UtcNow.AddMonths(-11),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,",
                Category = "Past1",
                City = "Santo Domingo",
                Venue = "Travesia Medallones"
            }
            #endregion
        };

        await context.Activities.AddRangeAsync(activityList);
        await context.SaveChangesAsync();
    } 
}
