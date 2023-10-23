using Domain.Activity.ValueObject;

namespace Domain.Activity
{
    public sealed class Activity
    {
     public  Guid Id {get; set;} = Guid.NewGuid();   
     public string Title { get; set; } = string.Empty;
     public DateTime Date {get; set;} = DateTime.UtcNow;
     public string Description { get; set; } = string.Empty;
     public string Category {get; set;} = string.Empty;
     public string City {get; set;} = string.Empty;
     public string Venue { get; set; } = string.Empty;
   
    // private Activity()
    // {
    //   //
    // }
    //  private Activity(ActivityId id, string title, DateTime date, string descripcion, string category, string city, string venue)
    //  {
    //     Id = id;
    //     Title = title;
    //     Date = date;
    //     Description = descripcion;
    //     Category = category;
    //     City = city;
    //     Venue = venue;
    //  }
    //  //event
    //  public static Activity Create(string title, string descripcion, string category, string city, string venue)
    //  {
    //    return new Activity(ActivityId.Create(), title, DateTime.UtcNow, descripcion, category, city, venue);  
    //  }
    }
}