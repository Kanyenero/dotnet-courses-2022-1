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

        public int Add(int lectureId, int studentId, int? mark)
        {
            return Provider.Add(lectureId, studentId, mark);
        }

        public Models.Attendance? Get(int lectureId, int studentId)
        {
            return Provider.Get(lectureId, studentId);
        }

        public int Delete(int lectureId, int studentId)
        {
            return Provider.Delete(lectureId, studentId);
        }

        public IEnumerable<Models.Attendance> GetAll()
        {
            return Provider.GetAll();
        }

        public void OnAdd(object? sender, ModelEventArgs<Models.Attendance> e)
        {
            if (e == null)
                return;

            int rowsAffected = 0;

            if (e.Id != null && e.Model == null)
            {
                rowsAffected = Add(((Identifier<int, int>)e.Id).Value1, ((Identifier<int, int>)e.Id).Value2, null);
            }
            else if (e.Id == null && e.Model != null)
            {
                rowsAffected = Add(e.Model.LectureId, e.Model.StudentId, e.Model.Mark);
            }

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

            var model = Get(((Identifier<int, int>)e.Id).Value1, ((Identifier<int, int>)e.Id).Value2);

            if (model == null)
                Console.WriteLine("Model read failed.");
            else
                Console.WriteLine(model);
        }

        public void OnDelete(object? sender, ModelEventArgs<Models.Attendance> e)
        {
            if (e == null || e.Id == null)
                return;

            int rowsAffected = Delete(((Identifier<int, int>)e.Id).Value1, ((Identifier<int, int>)e.Id).Value2);

            if (rowsAffected == 0)
                Console.WriteLine("An error occurred while deleting.");
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