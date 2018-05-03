using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://int.corpadmin.directscaledev.com");
			IWebElement element1 = driver.FindElement(By.Name("username"));
			element1.SendKeys("saruman");
			IWebElement element2 = driver.FindElement(By.Name("password"));
			element1.SendKeys("youshallnotpass");
			IWebElement element = driver.FindElement(By.XPath("//*[@id="login"]/input[3]")).Click();
			driver.Close()
			
		}
	}
}
