using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.BusinessLogic.Student
{
    public class SqlProvider : IDataProvider, IInvocableProvider<Models.Student>
    {
        private DataAccess.StudentEngine.IDataProvider Provider { get; set; }

        public SqlProvider(DataAccess.StudentEngine.IDataProvider provider)
        {
            Provider = provider;
        }

        public int Add(string firstName, string lastName, string uniqueLogin)
        {
            return Provider.Add(firstName, lastName, uniqueLogin);
        }

        public Models.Student Get(Index<int> id)
        {
            return Provider.Get(id);
        }

        public Models.Student Get(string firstName, string lastName, string uniqueLogin)
        {
            return Provider.Get(firstName, lastName, uniqueLogin);
        }

        public int Update(Index<int> id, string firstName, string lastName, string uniqueLogin)
        {
            return Provider.Update(id, firstName, lastName, uniqueLogin);
        }

        public int Delete(Index<int> id)
        {
            return Provider.Delete(id);
        }

        public int Delete(string firstName, string lastName, string uniqueLogin)
        {
            return Provider.Delete(firstName, lastName, uniqueLogin);
        }

        public IEnumerable<Models.Student> GetAll()
        {
            return Provider.GetAll();
        }

        public void OnAdd(object? sender, ModelEventArgs<Models.Student> e)
        {
            if (e == null || e.Model == null)
                return;

            int rowsAffected = Add(e.Model.FirstName, e.Model.LastName, e.Model.UniqueLogin);

            if (rowsAffected == 0)
                Console.WriteLine("An error occurred while adding.");
            else
                Console.WriteLine("New Object was added successfully.");
        }

        public void OnGet(object? sender, ModelEventArgs<Models.Student> e)
        {
            if (e == null)
                return;

            Models.Student model = null!;

            if (e.Id == null && e.Model != null)
            {
                model = Get(e.Model.FirstName, e.Model.LastName, e.Model.UniqueLogin);
            }

            if (e.Id != null && e.Model == null)
            {
                model = Get((Index<int>)e.Id);
            }

            if (model == null)
                return;

            Console.WriteLine(model);
        }

        public void OnUpdate(object? sender, ModelEventArgs<Models.Student> e)
        {
            if (e == null || e.Model == null)
                return;

            int rowsAffected = Update((Index<int>)e.Id, e.Model.FirstName, e.Model.LastName, e.Model.UniqueLogin);

            if (rowsAffected == 0)
                Console.WriteLine("An error occurred while updating.");
            else
                Console.WriteLine("Object was updated successfully.");
        }

        public void OnDelete(object? sender, ModelEventArgs<Models.Student> e)
        {
            if (e == null)
                return;

            int rowsAffected = 0;

            if (e.Id == null && e.Model != null)
            {
                rowsAffected = Delete(e.Model.FirstName, e.Model.LastName, e.Model.UniqueLogin);
            }

            if (e.Id != null && e.Model == null)
            {
                rowsAffected = Delete((Index<int>)e.Id);
            }

            if (rowsAffected == 0)
                Console.WriteLine("An error occurred while deleting.");
            else
                Console.WriteLine("Object was deleted successfully.");
        }

        public void OnGetAll(object? sender, ModelEventArgs<Models.Student> e)
        {
            var models = GetAll();

            foreach (var model in models)
                Console.WriteLine(model);
        }
    }
}
