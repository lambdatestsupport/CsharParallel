using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium.iOS;
using System.Threading;

namespace csharp_appium

{
    class Program
    {
        static void Main(string[] args)
        {
            Thread device1 = new Thread(obj => runTestCase("rakeshslambdatest", "MHu1nfiZVVPSteHsFVqybmvsxePoFJq0j8htKDk7uHcRwPgLGg", "lt://APP10160631101689497663230717", "Galaxy S21 Ultra 5G", "11", "Android", true, "CSharp Sample Android", "CSharp Sample Android", "CSharp Sample Android1"));
            Thread device2 = new Thread(obj => runTestCase("rakeshslambdatest", "MHu1nfiZVVPSteHsFVqybmvsxePoFJq0j8htKDk7uHcRwPgLGg", "lt://APP10160631101689497663230717", "Oppo A12", "9", "Android", true, "CSharp Sample Android", "CSharp Sample Android", "CSharp Sample Android2"));
            Thread device3 = new Thread(obj => runTestCase("rakeshslambdatest", "MHu1nfiZVVPSteHsFVqybmvsxePoFJq0j8htKDk7uHcRwPgLGg", "lt://APP10160631101689497663230717", "Vivo T1 5G", "12", "Android", true, "CSharp Sample Android", "CSharp Sample Android", "CSharp Sample Android3"));
            Thread device4 = new Thread(obj => runTestCase("rakeshslambdatest", "MHu1nfiZVVPSteHsFVqybmvsxePoFJq0j8htKDk7uHcRwPgLGg", "lt://APP10160631101689497663230717", "Pixel 6 Pro", "12", "Android", true, "CSharp Sample Android", "CSharp Sample Android", "CSharp Sample Android4"));
            Thread device5 = new Thread(obj => runTestCase("rakeshslambdatest", "MHu1nfiZVVPSteHsFVqybmvsxePoFJq0j8htKDk7uHcRwPgLGg", "lt://APP10160631101689497663230717", "Galaxy S21 Ultra 5G", "11", "Android", true, "CSharp Sample Android", "CSharp Sample Android", "CSharp Sample Android5"));

            device1.Start();
            device2.Start();
            device3.Start();
            device4.Start();
            device5.Start();
            device1.Join();
            device2.Join();
            device3.Join();
            device4.Join();
            device5.Join();
            // Initialize the remote Webdriver using LambdaTest remote URL
            // and desired capabilities defined above

        }
        static void runTestCase(string user, string accessKey, string app, string deviceName, string platformVersion, string platformName, bool isRealMobile, string project, string build, string name)
        {
            AppiumOptions caps = new AppiumOptions();


            caps.AddAdditionalCapability("user", user);  //Add the LT Username
            caps.AddAdditionalCapability("accessKey", accessKey);  //Add the LT Access key

            // Set URL of the application under test
            caps.AddAdditionalCapability("app", app); //Add the App ID

            // Specify device and os_version
            caps.AddAdditionalCapability("deviceName", deviceName);  //Add the Device Details
            caps.AddAdditionalCapability("platformVersion", platformVersion);
            caps.AddAdditionalCapability("platformName", platformName);
            caps.AddAdditionalCapability("isRealMobile", isRealMobile);
            caps.AddAdditionalCapability("network", false);

            caps.AddAdditionalCapability("project", project);
            caps.AddAdditionalCapability("build", build);
            caps.AddAdditionalCapability("name", name);
            executeParallel(caps);
        }

        static void executeParallel(AppiumOptions caps)
        {
            IOSDriver<IOSElement> driver = new IOSDriver<IOSElement>(
                 new Uri("https://mobile-hub.lambdatest.com/wd/hub"), caps);

            // Test case for the sample iOS app. 
            // If you have uploaded your app, update the test case here.
            IOSElement color = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("color"))
            );
            color.Click();
            color.Click();

            IOSElement text = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("Text"))
            );
            text.Click();

            IOSElement toast = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("toast"))
            );
            toast.Click();

            IOSElement nf = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("notification"))
            );
            nf.Click();

            IOSElement gl = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("geoLocation"))
            );
            gl.Click();

            Thread.Sleep(5000);

            driver.Navigate().Back();

            IOSElement st = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("speedTest"))
            );
            st.Click();

            Thread.Sleep(5000);

            driver.Navigate().Back();

            IOSElement browser = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.AccessibilityId("Browser"))
            );
            browser.Click();

            IOSElement inputBox = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("url"))
            );
            inputBox.Click();


            driver.Quit();
        }
    }
}


