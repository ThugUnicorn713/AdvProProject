namespace AdvProProject.Services
{
    public interface IService<T>
    {
        public T GetByID(int id);

        public List<T> GetAll();

        public List<T> GetFilteredList(string searchText);

        public void Add(T record);

        public void Update(T updatedRecord);

        public void Delete(T id);
    }
}