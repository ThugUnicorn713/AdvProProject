using AdvProProject.Data.Models;
using AdvProProject.Data;
using Microsoft.EntityFrameworkCore;

namespace AdvProProject.Services
{
    public class RegistrationService : IService<Registration>
    {
        private readonly IDbContextFactory<ApplicationDbContext> contextFactory;

        public RegistrationService(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public void Add(Registration record)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                context.Registration.Add(record);
                context.SaveChanges();
            }
        }

        public List<Registration> GetAll()
        {
            using (var context = contextFactory.CreateDbContext())
            {
                return context.Registration.ToList();
            }
        }

        public Registration GetByID(int id)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                return context.Registration.Find(id);
            }
        }

        public void Update(Registration updatedRecord)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                context.Registration.Update(updatedRecord);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                var record = context.Registration.Find(id);
                if (record != null)
                {
                    context.Registration.Remove(record);
                    context.SaveChanges();
                }
            }
        }


        public void Delete(Registration id)
        {
            throw new NotImplementedException();
        }

        public List<Registration> GetFilteredList(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}

