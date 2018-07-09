using System; 
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAdressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            navigationHelper.OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GoToGroupsPage();
            groupHelper.InitNewGroupCreation();
            GroupData group = new GroupData("Name");
            group.Header = "Header";
            group.Footer = "Footer";
            groupHelper.FillGroupForm(group);
            groupHelper.SubmitGroupCretion();
            groupHelper.ReturnToGroupsPage();
        }
    }
}
