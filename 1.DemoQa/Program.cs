using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace _1.DemoQa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com");
            Driver.Manage().Window.Maximize();
            Actions act = new Actions(Driver);
            Thread.Sleep(1000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(200);



            #region Elemenet
            Driver.FindElement(By.XPath("//h5[text()='Elements']")).Click();
            Thread.Sleep(200);

            #region Text Box
            //Console.Write("Test Case Started: ");
            //string name = "Zubair Ahmed";
            //string email = "abc@gmail.com";
            //string Cadd = "Kolkata";
            //string Padd = "Kolkata";

            //IWebDriver Driver = new ChromeDriver();
            //IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            //Driver.Manage().Window.Maximize();

            //Thread.Sleep(200);

            //Driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            //Thread.Sleep(2000);
            //Driver.FindElement(By.Id("userName")).SendKeys(name);
            //Thread.Sleep(2000);
            //Driver.FindElement(By.Id("userEmail")).SendKeys(email);
            //Thread.Sleep(2000);
            //Driver.FindElement(By.Id("currentAddress")).SendKeys(Cadd);
            //Thread.Sleep(2000);
            //Driver.FindElement(By.Id("permanentAddress")).SendKeys(Padd);
            //Thread.Sleep(2000);
            //js.ExecuteScript("window.scrollBy(0,500)");


            //Thread.Sleep(2000);

            //IWebElement ButtonElement = Driver.FindElement(By.Id("submit"));
            //Thread.Sleep(2000);
            //ButtonElement.Click();
            //Task.Delay(3000).Wait();

            //Console.WriteLine("Testing Close");
            //Driver.Close();
            //Driver.Quit();
            #endregion

            #region Check Box

            //IWebDriver Driver = new ChromeDriver();
            //Driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
            //Thread.Sleep(200);

            //IWebElement ButtonHome = Driver.FindElement(By.ClassName("rct-icon-expand-close"));
            //Thread.Sleep(200);
            //ButtonHome.Click();

            ////IWebElement ButtonDesktop = Driver.FindElement(By.ClassName("rct-icon rct-icon-parent-close"));
            //IWebElement ButtonDesktop = Driver.FindElement(By.XPath("//label[@for='tree-node-desktop']"));
            //Thread.Sleep(2000);
            //ButtonDesktop.Click();
            ////Thread.Sleep(2000);

            //IWebElement ButtonDocuments = Driver.FindElement(By.XPath("//label[@for='tree-node-documents']"));
            //Thread.Sleep(2000);
            //ButtonDocuments.Click();

            //IWebElement ButtonDownload = Driver.FindElement(By.XPath("//label[@for='tree-node-downloads']"));
            //Thread.Sleep(2000);
            //ButtonDownload.Click();

            //Thread.Sleep(2000);
            //Driver.Close();
            //Driver.Quit();
            #endregion

            #region Radio Button
            //use label

            //IWebDriver Driver = new ChromeDriver();
            //Driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
            //Driver.Manage().Window.Maximize();
            //Thread.Sleep(1000);

            //IWebElement Yes = Driver.FindElement(By.XPath("//label[@for='yesRadio']"));
            //Thread.Sleep(1000);
            //Yes.Click();
            //Task.Delay(2000).Wait();

            //IWebElement impress = Driver.FindElement(By.XPath("//label[@for='impressiveRadio']"));
            //Thread.Sleep(1000);
            //impress.Click();


            //Thread.Sleep(2000);
            //Driver.Close();
            //Driver.Quit();

            #endregion

            #region Web Tables

            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Web Tables']")).Click();
            //Thread.Sleep(200);

            //Driver.FindElement(By.XPath("//button[@id='addNewRecordButton']")).Click();
            //Thread.Sleep(200);

            //IWebElement FirstName = Driver.FindElement(By.XPath("//input[@id='firstName']"));
            //FirstName.SendKeys("Zubair");
            //Thread.Sleep(200);

            //IWebElement LastName = Driver.FindElement(By.XPath("//input[@id='lastName']"));
            //LastName.SendKeys("Ahmed");
            //Thread.Sleep(200);

            //IWebElement Email = Driver.FindElement(By.XPath("//input[@id='userEmail']"));
            //Email.SendKeys("Z123@gmail.com");
            //Thread.Sleep(200);


            //IWebElement Age = Driver.FindElement(By.XPath("//input[@id='age']"));
            //Age.SendKeys("25");
            //Thread.Sleep(200);

            //IWebElement Salary = Driver.FindElement(By.XPath("//input[@id='salary']"));
            //Salary.SendKeys("10000");
            //Thread.Sleep(200);

            //IWebElement Department = Driver.FindElement(By.XPath("//input[@id='department']"));
            //Department.SendKeys("CSE");
            //Thread.Sleep(200);

            //Driver.FindElement(By.XPath("//button[@id='submit']")).Click();
            //Thread.Sleep(2000);

            //Driver.FindElement(By.XPath("//span[@id='edit-record-2']")).Click();
            //Thread.Sleep(200);

            //IWebElement Clear = Driver.FindElement(By.XPath("//input[@id='userEmail']"));
            //Thread.Sleep(200);
            //Clear.Clear();
            //Thread.Sleep(2000);


            //IWebElement EdEmail = Driver.FindElement(By.XPath("//input[@id='userEmail']"));
            //EdEmail.SendKeys("text@12example.com");
            //Thread.Sleep(200);

            //Driver.FindElement(By.XPath("//button[@id='submit']")).Click();
            //Thread.Sleep(2000);


            ////Driver.FindElement(By.XPath("//input[@id='searchBox']")).SendKeys(Keys.BACK_SPACE);
            ////Thread.Sleep(2000);

            //Driver.FindElement(By.XPath("//span[@id='delete-record-3']")).Click();
            //Thread.Sleep(200);

            //Driver.FindElement(By.XPath("//input[@id='searchBox']")).SendKeys("Zu");
            //Thread.Sleep(2000);

            #endregion

            #region Buttons
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Buttons']")).Click();
            //Thread.Sleep(200);
            //IWebElement doubleClick = Driver.FindElement(By.Id("doubleClickBtn"));
            //Thread.Sleep(2000);
            //act.DoubleClick(doubleClick).Perform();

            //IWebElement rightClick = Driver.FindElement(By.Id("rightClickBtn"));
            //Thread.Sleep(2000);
            //act.ContextClick(rightClick).Perform();


            //Thread.Sleep(2000);
            //js.ExecuteScript("window.scrollBy(0,200)");
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//button[text()='Click Me']")).Click();
            //Thread.Sleep(2000);


            #endregion

            #region Link

            //js.ExecuteScript("window.scrollBy(0,300)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Links']")).Click();

            //Driver.FindElement(By.Id("simpleLink")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);

            //Driver.FindElement(By.Id("dynamicLink")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);

            //Driver.FindElement(By.Id("created")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);

            //Driver.FindElement(By.Id("no-content")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);

            //Driver.FindElement(By.Id("moved")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);

            //Driver.FindElement(By.Id("bad-request")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);

            //Driver.FindElement(By.Id("unauthorized")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);

            //Driver.FindElement(By.Id("bad-request")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);

            //Driver.FindElement(By.Id("forbidden")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);

            //Driver.FindElement(By.Id("invalid-url")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);

            #endregion

            #region Broken Links
            //js.ExecuteScript("window.scrollBy(0,500)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Links']")).Click();

            //Driver.FindElement(By.XPath("//p[text()='Valid Link']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);

            //Driver.FindElement(By.XPath("//p[text()='Broken Link']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);


            #endregion

            #region Upload and Download

            //js.ExecuteScript("window.scrollBy(0,300)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Links']")).Click();
            //Thread.Sleep(200);

            //Driver.FindElement(By.Id("downloadButton")).Click();
            //Thread.Sleep(200);

            //Driver.FindElement(By.Id("uploadFile")).Click();
            //Thread.Sleep(200);

            #endregion

            #region Dynamic Properties

            //js.ExecuteScript("window.scrollBy(0,300)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Upload and Download']")).Click();
            //Thread.Sleep(200);

            //Driver.FindElement(By.Id("downloadButton")).Click();
            //Thread.Sleep(2000);

            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(200);

            //Driver.FindElement(By.Id("uploadFile")).Click();
            //Thread.Sleep(200);
            //Driver.SwitchTo().Alert().Dismiss();

            #endregion

            #endregion

            #region Form
            //Driver.FindElement(By.XPath("//div[text()='Forms']")).Click();
            //Thread.Sleep(200);

            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Practice Form']")).Click();
            //Thread.Sleep(200);

            //IWebElement FirstName = Driver.FindElement(By.XPath("//input[@id='firstName']"));
            //FirstName.SendKeys("Zubair");
            //Thread.Sleep(200);

            //IWebElement LastName = Driver.FindElement(By.XPath("//input[@id='lastName']"));
            //LastName.SendKeys("Ahmed");
            //Thread.Sleep(200);

            //IWebElement Email = Driver.FindElement(By.XPath("//input[@id='userEmail']"));
            //Email.SendKeys("Z123@gmail.com");
            //Thread.Sleep(200);

            //IWebElement Mobile = Driver.FindElement(By.XPath("//input[@id='userNumber']"));
            //Mobile.SendKeys("1234567890");
            //Thread.Sleep(200);

            //IWebElement Sub = Driver.FindElement(By.XPath("//input[@id='subjectsContainer']"));
            //Sub.SendKeys("Z123@gmail.com");
            //Thread.Sleep(200);



            #endregion

            #region Alerts, Frame & Windows
            //Driver.FindElement(By.XPath("//div[text()='Alerts, Frame & Windows']")).Click();
            //Thread.Sleep(200);
            #region Browser Window

            //js.ExecuteScript("window.scrollBy(0,400)");
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//span[text()='Browser Windows']")).Click();

            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//button[@id='tabButton']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            //Thread.Sleep(2000);
            //Driver.Close();

            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//button[text()='New Window']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            //Thread.Sleep(2000);
            //Driver.Close();

            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//button[text()='New Window Message']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            //Thread.Sleep(2000);
            //Driver.Close();

            #endregion

            #region Alert
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//h5[text()='Alerts, Frame & Windows']")).Click();
            //Thread.Sleep(200);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(200);
            //js.ExecuteScript("window.scrollBy(0,200)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Alerts']")).Click();
            //Thread.Sleep(200);

            //Driver.FindElement(By.XPath("//button[@id='alertButton']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Alert().Accept();

            #region TimerAlert
            //try
            //{
            //    Driver.FindElement(By.Id("timerAlertButton")).Click();
            //    WebDriverWait wait = new WebDriverWait(Driver, t);
            //    wait.Until(ExpectedConditions.alertIsPresent());
            //    Alert simpleAlert = Driver.SwitchTo().Alert();
            //    simpleAlert.accept();
            //    System.out.println("Unexpected alert accepted");
            //}
            //catch (Exception e)
            //{
            //    System.out.println("unexpected alert not present");
            //}

            //Driver.FindElement(By.XPath("//button[@id='timerAlertButton']")).Click();
            //Thread.Sleep(10000);
            //Driver.SwitchTo().Alert().Accept();
            #endregion

            //Driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Alert().Accept();

            //Driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Alert().Dismiss();

            //Driver.FindElement(By.XPath("//button[@id='promtButton']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Alert().GetType();
            //Driver.SwitchTo().Alert().SendKeys("Zubair Ahmed");
            //Driver.SwitchTo().Alert().Accept();
            //Thread.Sleep(2000);

            #endregion

            #region Frame

            #endregion

            #region Modals

            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//h5[text()='Alerts, Frame & Windows']")).Click();
            //Thread.Sleep(200);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(200);
            //js.ExecuteScript("window.scrollBy(0,500)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Modal Dialogs']")).Click();
            //Thread.Sleep(200);

            //Thread.Sleep(200);
            //Driver.FindElement(By.Id("showSmallModal")).Click();
            //Thread.Sleep(200);

            //string sm1 = Driver.FindElement(By.ClassName("modal-header")).Text;
            //Console.WriteLine("Modal Header"+sm1);
            //Thread.Sleep(200);

            //string sm2 = Driver.FindElement(By.ClassName("modal-body")).Text;
            //Console.WriteLine("Modal Body"+sm2);
            //Thread.Sleep(200);

            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//button[@id='closeSmallModal']")).Click();
            //Thread.Sleep(200);

            //Thread.Sleep(200);
            //Driver.FindElement(By.Id("showLargeModal")).Click();
            //Thread.Sleep(200);

            //string bm1 = Driver.FindElement(By.ClassName("modal-header")).Text;
            //Console.WriteLine("Modal Header"+bm1);
            //Thread.Sleep(200);

            //string bm2 = Driver.FindElement(By.ClassName("modal-body")).Text;
            //Console.WriteLine("Modal Body"+bm2);
            //Thread.Sleep(200);

            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//button[@id='closeLargeModal']")).Click();
            //Thread.Sleep(200);


            #endregion

            #endregion

            #region Widgets
            js.ExecuteScript("window.scrollBy(0,600)");
            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//div[text()='Widgets']")).Click();
            Thread.Sleep(200);
            #region Accordian
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//h5[text()='Widgets']")).Click();
            //Thread.Sleep(200);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(200);
            //js.ExecuteScript("window.scrollBy(0,500)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Accordian']")).Click();
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//div[text()='What is Lorem Ipsum?']")).Click();
            //Thread.Sleep(2000);
            //js.ExecuteScript("window.scrollBy(0,200)");
            //Driver.FindElement(By.XPath("//div[text()='Where does it come from?']")).Click();
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//div[text()='Where does it come from?']")).Click();
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//div[text()='Why do we use it?']")).Click();
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//div[text()='Why do we use it?']")).Click();
            //Thread.Sleep(2000);


            #endregion

            #region Auto Complete

            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//h5[text()='Widgets']")).Click();
            //Thread.Sleep(200);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(200);
            //js.ExecuteScript("window.scrollBy(0,500)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Auto Complete']")).Click();
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//div[@id='autoCompleteMultipleContainer']")).Click();
            //Driver.FindElement(By.XPath("//div[@id='autoCompleteMultipleInput']")).SendKeys("a");
            //Thread.Sleep(200);
            #endregion

            #region Date Picker

            Thread.Sleep(200);
            Driver.FindElement(By.XPath("//span[text()='Date Picker']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("datePickerMonthYearInput")).Clear();

            //IWebElement element = new WebDriverWait(Driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementToBeClickable(By.Id("datePickerMonthYearInput"));
            //element.Click();
            //element.Clear();

            //Thread.Sleep(2000);
            Driver.FindElement(By.Id("datePickerMonthYearInput")).SendKeys("18/12/1998");
            Thread.Sleep(200);

            //Driver.FindElement(By.XPath("//*[@class='react-datepicker__year-select']/option[@value='2020']")).Click();
            //Thread.Sleep(2000);

            //js.ExecuteScript("Driver.FindElement("By.Id("datePickerMonthYear")"));


            #endregion

            #region Slider

            //Driver.FindElement(By.XPath("//*[@id ='demo-tab-grid']")).Click();
            //Thread.Sleep(200);
            ////Driver.FindElement(By.XPath("//h5[text()='Widgets']")).Click();
            //Thread.Sleep(200);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(200);
            //js.ExecuteScript("window.scrollBy(0,500)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Slider']")).Click();

            //Actions builder = new Actions(Driver);
            //Driver.FindElement(By.ClassName("range-slider__tooltip__label"));
            //Thread.Sleep(2000);
            //builder.MoveToElement(Driver.FindElement(By.Id("sliderContainer")));
            //Thread.Sleep(2000);


            #endregion


            #endregion

            #region Interactions

            #endregion

            #region Book Store Application
            #endregion

            Thread.Sleep(2000);
            Driver.Close();
            Thread.Sleep(200);
            Driver.Quit();
        }
    }
}
