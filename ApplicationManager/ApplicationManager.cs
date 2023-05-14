using AutoItX3Lib;

namespace addressbook_tests_autoit
{
    public class ApplicationManager
    {
        private readonly AutoItX3 auto;
        private readonly GroupHelper groupHelper;
        public static string WIN_TITLE = "Free Address Book";
        public ApplicationManager() 
        {
            groupHelper = new GroupHelper(this);
            auto = new AutoItX3();
            auto.Run(@"c:\FreeAddressBookPortable\AddressBook.exe");
            auto.WinWait(WIN_TITLE);
            auto.WinActivate(WIN_TITLE);
            auto.WinWaitActive(WIN_TITLE);
        }
        public AutoItX3 Auto
        {
            get { return auto; }
        }
        public void Stop() 
        {
            auto.ControlClick(WIN_TITLE, "", "WindowsForms10.BUTTON.app.0.1114f8110");
        }
        public GroupHelper Groups
        { get { return groupHelper; } }
    }
}
