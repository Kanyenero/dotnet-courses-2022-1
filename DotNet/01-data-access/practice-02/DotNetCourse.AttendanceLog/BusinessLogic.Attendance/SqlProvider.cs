using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.BusinessLogic.Attendance
{
    public class SqlProvider : IDataProvider, IInvocableProvider<Models.Attendance>
    {
        private DataAccess.AttendanceEngine.IDataProvider Provider { get; set; }

        public SqlProvider(DataAccess.AttendanceEngine.IDataProvider provider)
        {
            Provider = provider;
        }

        public int Add(Index<int, int> id, int? mark)
        {
            return Provider.Add(id, mark);
        }

        public Models.Attendance Get(Index<int, int> id)
        {
            return Provider.Get(id);
        }

        public int Delete(Index<int, int> id)
        {
            return Provider.Delete(id);
        }

        public IEnumerable<Models.Attendance> GetAll()
        {
            return Provider.GetAll();
        }

        public void OnAdd(object? sender, ModelEventArgs<Models.Attendance> e)
        {
            if (e == null || e.Model == null)
                return;

            int rowsAffected = Add(e.Model.Id, e.Model.Mark);

            if (rowsAffected == 0)
                Console.WriteLine("An error occurred while adding.");
            else
                Console.WriteLine("New Object was added successfully.");
        }

        public void OnUpdate(object? sender, ModelEventArgs<Models.Attendance> e)
        {
            throw new NotImplementedException();
        }

        public void OnGet(object? sender, ModelEventArgs<Models.Attendance> e)
        {
            if (e == null || e.Id == null)
                return;

            var model = Get((Index<int, int>)e.Id);

            if (model == null)
                return;

            Console.WriteLine(model);
        }

        public void OnDelete(object? sender, ModelEventArgs<Models.Attendance> e)
        {
            if (e == null || e.Id == null)
                return;

            int rowsAffected = Delete((Index<int, int>)e.Id);

            if (rowsAffected == 0)
                Console.WriteLine($"An error occurred while deleting.");
            else
                Console.WriteLine("Object was deleted successfully.");
        }

        public void OnGetAll(object? sender, ModelEventArgs<Models.Attendance> e)
        {
            var models = GetAll();

            foreach (var model in models)
                Console.WriteLine(model);
        }
    }
}