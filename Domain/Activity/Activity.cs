using Domain.Activity.ValueObject;

namespace Domain.Activity
{
    public sealed class Activity
    {
     public  Guid Id {get; private set;}   
     public string Title { get; private set; } = string.Empty;
     public DateTime Date {get; private set;} = DateTime.UtcNow;
     public string Description { get; private set; } = string.Empty;
     public string Category {get; private set;} = string.Empty;
     public string City {get; private set;} = string.Empty;
     public string Venue { get; private set; } = string.Empty;
   
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