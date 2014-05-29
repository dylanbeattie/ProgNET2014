using System.Globalization;

namespace Ex8
{
    /// <summary>
    /// Such thread safety.
    /// </summary>
    public static class ViewInstanceCount
    {
        private static int _instanceCount;

        public static string InstanceCount
        {
            get { return _instanceCount.ToString(CultureInfo.InvariantCulture); }
        }

        public static void Increment()
        {
            _instanceCount++;
        }
    }
}