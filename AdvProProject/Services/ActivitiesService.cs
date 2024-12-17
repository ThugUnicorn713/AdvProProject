using AdvProProject.Data;
using Microsoft.EntityFrameworkCore;
using AdvProProject.Data.Models;
using System.Linq;

namespace AdvProProject.Services
{
    public class ActivitiesService : IService<Activities>
    {

        private readonly IDbContextFactory<ApplicationDbContext> contextFactory;

        public ActivitiesService(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public void Add(Activities record)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                context.Activities.Add(record);
                context.SaveChanges();
            }
        }

        public List<Activities> GetAll()
        {
            using (var context = contextFactory.CreateDbContext())
            {
                return context.Activities.ToList();
            }
        }

        public List<Activities> GetFilteredList(string searchText)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                var records = context.Activities.Where(r => r.Game.ToLower().Contains(searchText.ToLower()) || r.Talk.ToLower().Contains(searchText.ToLower()) || r.Workshop.ToLower().Contains(searchText.ToLower())).ToList();
                return records;
            }
        }

        public Activities GetByID(int id)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                return context.Activities.Find(id);
            }
        }

        public void Update(Activities updatedRecord)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                context.Activities.Update(updatedRecord);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                var record = context.Activities.Find(id);
                if (record != null)
                {
                    context.Activities.Remove(record);
                    context.SaveChanges();
                }
            }
        }


        public void Delete(Activities id)
        {
            throw new NotImplementedException();
        }

        public List<Activities> GetFilteredList()
        {
            throw new NotImplementedException();
        }
    }
}
