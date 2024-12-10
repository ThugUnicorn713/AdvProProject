using AdvProProject.Data;
using Microsoft.EntityFrameworkCore;
using AdvProProject.Data.Models;
using System.Linq;

namespace AdvProProject.Services
{
    public class EventsService : IService<Events>
    {
        private readonly IDbContextFactory<ApplicationDbContext> contextFactory;

        public EventsService(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public void Add(Events record)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                context.Events.Add(record);
                context.SaveChanges();
            }
        }

        public List<Events> GetAll()
        {
            using(var context = contextFactory.CreateDbContext())
            {
                return context.Events.ToList();
            }
        }

        public Events GetByID(int id)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                return context.Events.Find(id);
            }
        }

        public void Update(Events updatedRecord)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                context.Events.Update(updatedRecord);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                var record = context.Events.Find(id);
                if (record != null)
                {
                    context.Events.Remove(record);
                    context.SaveChanges();
                }
            }
        }

        public void Delete(Events id)
        {
            throw new NotImplementedException();
        }
    }
}
