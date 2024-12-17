using AdvProProject.Data;
using Microsoft.EntityFrameworkCore;
using AdvProProject.Data.Models;
using System.Linq;

namespace AdvProProject.Services
{
    public class ParticipantsService : IService<Participants>
    {
        private readonly IDbContextFactory<ApplicationDbContext> contextFactory;

        public ParticipantsService(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public void Add(Participants record)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                context.Participants.Add(record);
                context.SaveChanges();
            }
        }

        public List<Participants> GetAll()
        {
            using (var context = contextFactory.CreateDbContext())
            {
                return context.Participants.ToList();
            }
        }

        public Participants GetByID(int id)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                return context.Participants.Find(id);
            }
        }

        public void Update(Participants updatedRecord)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                context.Participants.Update(updatedRecord);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                var record = context.Participants.Find(id);
                if (record != null)
                {
                    context.Participants.Remove(record);
                    context.SaveChanges();
                }
            }
        }


        public void Delete(Participants id)
        {
            throw new NotImplementedException();
        }

        public List<Participants> GetFilteredList(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}

