namespace DotNetCourse.AttendanceLog.Models
{
    public class ModelEventArgs<T> : EventArgs
        where T : class
    {
        public static new ModelEventArgs<T> Empty => new();

        public Identifier? Id { get; protected set; }

        public T? Model { get; protected set; }

        public ModelEventArgs()
        {
        }

        public ModelEventArgs(Identifier id)
        {
            Id = id;
        }

        public ModelEventArgs(T model)
        {
            Model = model;
        }

        public ModelEventArgs(Identifier id, T model)
        {
            Id = id;
            Model = model;
        }

        public static implicit operator ModelEventArgs<T>(T model) => new(model);
    }
}
