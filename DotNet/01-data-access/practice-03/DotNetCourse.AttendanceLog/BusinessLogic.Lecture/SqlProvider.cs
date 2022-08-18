using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.BusinessLogic.Lecture
{
    public class SqlProvider : IDataProvider, IInvocableProvider<Models.Lecture>
    {
        private DataAccess.LectureEngine.IDataProvider Provider { get; set; }

        public SqlProvider(DataAccess.LectureEngine.IDataProvider provider)
        {
            Provider = provider;
        }

        public int Add(string course, string topic, DateTime date)
        {
            return Provider.Add(course, topic, date);
        }

        public Models.Lecture? Get(int id)
        {
            return Provider.Get(id);
        }

        public Models.Lecture? Get(string course, string topic, DateTime date)
        {
            return Provider.Get(course, topic, date);
        }

        public int Update(int id, string course, string topic, DateTime date)
        {
            return Provider.Update(id, course, topic, date);
        }

        public int Delete(int id)
        {
            return Provider.Delete(id);
        }

        public int Delete(string course, string topic, DateTime date)
        {
            return Provider.Delete(course, topic, date);
        }

        public IEnumerable<Models.Lecture> GetAll()
        {
            return Provider.GetAll();
        }

        public void OnAdd(object? sender, ModelEventArgs<Models.Lecture> e)
        {
            if (e == null || e.Model == null)
                return;

            int rowsAffected = Add(e.Model.Course, e.Model.Topic, e.Model.Date);

            if (rowsAffected == 0)
                Console.WriteLine("An error occurred while adding.");
            else
                Console.WriteLine("New Object was added successfully.");
        }

        public void OnGet(object? sender, ModelEventArgs<Models.Lecture> e)
        {
            if (e == null)
                return;

            Models.Lecture? model = null;

            if (e.Id != null && e.Model == null)
            {
                model = Get(((Identifier<int>)e.Id).Value);
            }
            else if (e.Id == null && e.Model != null)
            {
                model = Get(e.Model.Course, e.Model.Topic, e.Model.Date);
            }

            if (model == null)
                Console.WriteLine("Model read failed.");
            else
                Console.WriteLine(model);
        }

        public void OnUpdate(object? sender, ModelEventArgs<Models.Lecture> e)
        {
            if (e == null || e.Model == null)
                return;

            int rowsAffected = Update(e.Model.Id, e.Model.Course, e.Model.Topic, e.Model.Date);

            if (rowsAffected == 0)
                Console.WriteLine("An error occurred while updating.");
            else
                Console.WriteLine("Object was updated successfully.");
        }

        public void OnDelete(object? sender, ModelEventArgs<Models.Lecture> e)
        {
            if (e == null)
                return;

            int rowsAffected = 0;

            if (e.Id != null && e.Model == null)
            {
                rowsAffected = Delete(((Identifier<int>)e.Id).Value);
            }
            else if (e.Id == null && e.Model != null)
            {
                rowsAffected = Delete(e.Model.Course, e.Model.Topic, e.Model.Date);
            }

            if (rowsAffected == 0)
                Console.WriteLine("An error occurred while deleting.");
            else
                Console.WriteLine("Object was deleted successfully.");
        }

        public void OnGetAll(object? sender, ModelEventArgs<Models.Lecture> e)
        {
            var models = GetAll();

            foreach (var model in models)
                Console.WriteLine(model);
        }
    }
}