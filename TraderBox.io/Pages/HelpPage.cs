using OpenQA.Selenium;
using System.Collections.Generic;
using TraderBox.io.Util;

namespace TraderBox.io.Pages
{
    class HelpPage : Page
    {
        private By firstQuestionLocator = By.Id("click1");
        private By answerOnFirstQuestionLocator = By.Id("subcart1");
        private By menuItemsLocator = By.XPath("//ul[@id = 'nav']/li");

        public HelpPage(IWebDriver driver) : base(driver)
        {
        }

        public HelpPage ChooseFirstQuestion()
        {
            IWebElement firstQuestion = FindElementWithWaitElementToBeClickable(firstQuestionLocator, 600);
            firstQuestion.Click();

            Log.Info("First question is opened");

            return this;
        }

        public IWebElement GetAnswerOnFirstQuetion()
        {
            return FindElementWithWaitElementExists(answerOnFirstQuestionLocator, 600);
        }

        public InstructionPage GoToInstructionPage()
        {
            List<IWebElement> menuItems = GetElements(menuItemsLocator);
            menuItems[5].Click();

            Log.Info("Instruction is opened");

            return new InstructionPage(driver);
        }

        public TariffPage GoToTariffPage()
        {
            List<IWebElement> menuItems = GetElements(menuItemsLocator);
            menuItems[2].Click();

            Log.Info("Tariffs are opened");

            return new TariffPage(driver);
        }

        public QuizPage GoToQuizPage()
        {
            List<IWebElement> menuItems = GetElements(menuItemsLocator);
            menuItems[3].Click();

            Log.Info("Quiz is opened");

            return new QuizPage(driver);
        }
    }
}