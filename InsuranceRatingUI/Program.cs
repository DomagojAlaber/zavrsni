using InsuranceRating;

namespace InsuranceRatingUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var logger = new FileLogger();

            var engine = new RatingEngine(logger,
                new FilePolicySource(),
                new JsonPolicySerializer(),
                new RaterFactory(logger));
            Application.Run(new MainForm(engine));
        }
    }
}