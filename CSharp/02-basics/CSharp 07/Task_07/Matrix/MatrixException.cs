using System.Runtime.Serialization;

namespace MatrixLib
{
    [Serializable]
    public class MatrixException : Exception, ISerializable
    {
        #region [Props]
        public int Rows { get; }
        public int Cols { get; }
        #endregion

        #region [Constructors]
        // base
        public MatrixException() { }
        public MatrixException(string message) : base(message) { }
        public MatrixException(string message, Exception inner) : base(message, inner) { }

        // parametrized
        public MatrixException(string message, int rows, int cols)
            : base(string.Format("{0}\nMatrix dimensions: [{1}, {2}]", message, rows, cols))
        {
            Rows = rows;
            Cols = cols;
        }
        public MatrixException(string message, Exception inner, int rows, int cols)
            : base(string.Format("{0}\nMatrix dimensions: [{1}, {2}]", message, rows, cols), inner)
        {
            Rows = rows;
            Cols = cols;
        }
        public MatrixException(string message, Matrix mx1, Matrix mx2)
            : base(string.Format("{0}\n" +
                "Matrix 1 dimensions: [{1}, {2}]\n" +
                "Matrix 2 dimensions: [{3}, {4}]", message, mx1.Rows, mx1.Cols, mx2.Rows, mx2.Cols))
        {
        }
        #endregion

        #region [Serialization/Deserialization]
        /// <summary>
        /// This method is called on serialization.
        /// </summary>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));

            info.AddValue("Rows", Rows, typeof(int));
            info.AddValue("Cols", Cols, typeof(int));

            // MUST call through to the base class to let it save its own state
            base.GetObjectData(info, context);
        }
        /// <summary>
        /// The special constructor is used to deserialize values.
        /// </summary>
        protected MatrixException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Rows = (int)info.GetValue("Rows", typeof(int));
            Cols = (int)info.GetValue("Cols", typeof(int));
        }
        #endregion
    }
}
