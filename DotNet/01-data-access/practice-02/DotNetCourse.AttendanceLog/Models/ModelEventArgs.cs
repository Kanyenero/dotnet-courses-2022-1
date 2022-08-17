namespace DotNetCourse.AttendanceLog.Models
{
    public delegate void ModelEventHandler<Model>(object sender, ModelEventArgs<Model> e) 
        where Model : class, IIndexableModel<Index>;

    public class ModelEventArgs<T> : EventArgs 
        where T : class, IIndexableModel<Index>
    {
        public Index Id { get; protected set; } = default!;

        private T? model;

        public T? Model 
        {
            get 
            { 
                return model; 
            }
            protected set
            {
                model = value;

                if (model != null && model.Id != null)
                    Id = model.Id;
            }
        }

        public ModelEventArgs()
        {
        }

        public ModelEventArgs(Index id)
        {
            Id = id;
        }

        public ModelEventArgs(T model)
        {
            Model = model;
        }

        public static implicit operator ModelEventArgs<T>(T model) => new(model);
    }
}
