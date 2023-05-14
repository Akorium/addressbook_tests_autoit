using AutoItX3Lib;
namespace addressbook_tests_autoit
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        public static string WIN_TITLE = "Free Address Book";
        protected AutoItX3 auto;
        public HelperBase(ApplicationManager manager) 
        {
            this.manager = manager;
            auto = manager.Auto;
            WIN_TITLE = ApplicationManager.WIN_TITLE;
        }
    }
}