using AdvProProject.Data;
using Microsoft.EntityFrameworkCore;
using AdvProProject.Data.Models;
using System.Linq;


namespace AdvProProject.Services
{
    public class VenuesService : IService<Venues>
    {
        private readonly IDbContextFactory<ApplicationDbContext> contextFactory;

        public VenuesService(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public void Add(Venues record)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                context.Venues.Add(record);
                context.SaveChanges();
            }
        }

        public List<Venues> GetAll()
        {
            using (var context = contextFactory.CreateDbContext())
            {
                return context.Venues.ToList();
            }
        }

        public Venues GetByID(int id)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                return context.Venues.Find(id);
            }
        }

        public void Update(Venues updatedRecord)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                context.Venues.Update(updatedRecord);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                var record = context.Venues.Find(id);
                if (record != null)
                {
                    context.Venues.Remove(record);
                    context.SaveChanges();
                }
            }
        }


        public void Delete(Venues id)
        {
            throw new NotImplementedException();
        }

        public List<Venues> GetFilteredList(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}
