using NUnit.Framework;

namespace addressbook_tests_autoit
{
    public class TestBase
    {
        public ApplicationManager application;

        [TestFixtureSetUp]

        public void InitApplication()
        {
            application = new ApplicationManager();
        }
        [TestFixtureTearDown]
        public void TearDownApplication()
        {
            application.Stop();
        }
    }
}
