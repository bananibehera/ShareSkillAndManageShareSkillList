using MarsFramework.Config;
using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using System;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {


            [Test]
            public void AddShareSkill()
            {

                test = extent.StartTest("Add Share Skills Details");
                //Populating excel data
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPathAddShareSkill, "ShareSkill");
                
                //Calling Add share skill method
                ShareSkill shareSkill = new ShareSkill();
                shareSkill.AddShareSkill();
              
            }

            [Test]
            public void EditShareSkill()
            {

                test = extent.StartTest("Edit Share skills Details");
                //Populating excel data
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPathAddShareSkill, "ShareSkill");
                
                //Calling Edit share skill method
                ManageListings manageListings = new ManageListings();
                manageListings.EditShareSkill(GlobalDefinitions.ExcelLib.ReadData(2, "Category"),GlobalDefinitions.ExcelLib.ReadData(2,"Title"),GlobalDefinitions.ExcelLib.ReadData(2,"Description"));
                
               
            }
            [Test]
            public void TestDeleteShareSkill()
            {

                test = extent.StartTest("Delete Share skills Details");
                //Populating excel data
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPathManageShareSkill, "ManageListings");
                
                //Calling Delete share skill method
                ManageListings manageListings = new ManageListings();
                manageListings.DeleteShareSkill(GlobalDefinitions.ExcelLib.ReadData(2,"Category"), GlobalDefinitions.ExcelLib.ReadData(2,"Title"),GlobalDefinitions.ExcelLib.ReadData(2,"Description"));
                
            }





        }
    }
}