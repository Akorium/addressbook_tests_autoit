using NUnit.Framework;

namespace addressbook_tests_autoit
{
    public class TestBase
    {
        public ApplicationManager application;

        [OneTimeSetUp]

        public void InitApplication()
        {
            application = new ApplicationManager();
        }
        [OneTimeTearDown]
        public void TearDownApplication()
        {
            application.Stop();
        }
    }
}
