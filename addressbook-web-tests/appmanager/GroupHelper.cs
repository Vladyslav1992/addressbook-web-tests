﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAdressbookTests
{
    public class GroupHelper : HelperBase
    {
        private IWebDriver driver;

        public GroupHelper(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public GroupHelper InitNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Footer);
            return this;
        }

        public GroupHelper SubmitGroupCretion()
        {
            driver.FindElement(By.Name("group_footer")).SendKeys("TestGroup");
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }
    }
}
