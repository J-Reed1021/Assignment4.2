namespace Assignment4._2
{
    internal static class Program
    {

       public static List<Student> studentList = new List<Student>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        internal static List<Student> studentList = newStudentList
    }
}