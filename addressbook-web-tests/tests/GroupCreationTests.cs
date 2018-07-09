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
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.InitNewGroupCreation();
            GroupData group = new GroupData("Name");
            group.Header = "Header";
            group.Footer = "Footer";
            app.Groups.FillGroupForm(group);
            app.Groups.SubmitGroupCretion();
            app.Groups.ReturnToGroupsPage();
        }
    }
}
