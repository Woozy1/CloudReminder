using web.Models;
using System;
using System.Linq;

namespace web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CloudContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Events.Any())
            {
                return;   // DB has been seeded
            }

            var Events = new Event[]
            {
            new Event{Name="Carson",GroupID=213, DateAdded=DateTime.Parse("2005-09-01"),EventDate=DateTime.Parse("2005-09-01")},
            };
            foreach (Event s in Events)
            {
                context.Events.Add(s);
            }
            context.SaveChanges();

            var Groups = new Group[]
            {
            new Group{Name="Chemistry"},
            };
            foreach (Group c in Groups)
            {
                context.Groups.Add(c);
            }
            context.SaveChanges();
        }
    }
}