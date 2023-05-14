using System;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    public class GroupHelper : HelperBase
    {
        public static string GROUP_WIN_TITLE = "Group editor";
        public GroupHelper (ApplicationManager manager) : base(manager) { }

        public void Add(GroupData newGroup)
        {
            auto.ControlClick(WIN_TITLE, "", "WindowsForms10.BUTTON.app.0.2c908d512");
            auto.WinWait(GROUP_WIN_TITLE);
            auto.ControlClick(GROUP_WIN_TITLE, "", "WindowsForms10.BUTTON.app.0.2c908d53");
            auto.Send(newGroup.Name);
            auto.Send("{ENTER}");
            auto.ControlClick(GROUP_WIN_TITLE, "", "WindowsForms10.BUTTON.app.0.2c908d54");
        }

        public List<GroupData> GetGroupList()
        {
            return new List<GroupData>();
        }
    }
}