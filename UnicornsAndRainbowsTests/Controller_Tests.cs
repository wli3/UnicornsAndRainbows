using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    [TestClass]
    public class Controller_Tests
    {
        [TestMethod]
        public void when_I_click_on_a_button__the_proper_page_is_launched_in_the_browser()
        {
            UserInterfaceSimulator userInterface = new UserInterfaceSimulator();

            Configuration configuration = new Configuration();
            configuration.SearchRoot = "http://www.example.com/search/term=";

            BrowserNavigatorAdapterSimulator browserNavigatorAdapter = new BrowserNavigatorAdapterSimulator();

            UnicornsAndRainbowsController unicornsAndRainbowsController = new UnicornsAndRainbowsController(userInterface,new BrowserNavigator(configuration.SearchRoot, browserNavigatorAdapter), new MouseCount());

            userInterface.SimulateButtonClick("Puppies");
            Assert.AreEqual(configuration.SearchRoot + "Puppies", browserNavigatorAdapter.Uri.OriginalString);
            Assert.AreEqual(1, userInterface.Count);
        }
    }
}
