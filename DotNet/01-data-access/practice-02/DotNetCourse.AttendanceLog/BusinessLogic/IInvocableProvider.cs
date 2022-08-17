using DotNetCourse.AttendanceLog.Models;

namespace DotNetCourse.AttendanceLog.BusinessLogic
{
    public interface IInvocableProvider<T> where T : class, IIndexableModel<Models.Index>
    {
        void OnAdd(object? sender, ModelEventArgs<T> e);

        void OnUpdate(object? sender, ModelEventArgs<T> e);

        void OnGet(object? sender, ModelEventArgs<T> e);

        void OnDelete(object? sender, ModelEventArgs<T> e);

        void OnGetAll(object? sender, ModelEventArgs<T> e);
    }
}