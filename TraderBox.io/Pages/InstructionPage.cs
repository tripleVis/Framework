using OpenQA.Selenium;
using TraderBox.io.Util;

namespace TraderBox.io.Pages
{
    class InstructionPage : Page
    {
        private By secondInstructionalQuestionLocator = By.Id("click2");
        private By answerOnSecondInstructionalQuestionLocator = By.Id("subcart2");

        public InstructionPage(IWebDriver driver) : base(driver) { }

        public InstructionPage ChooseSecondInstructionalQuestion()
        {
            IWebElement firstQuestion = FindElementWithWaitElementToBeClickable(secondInstructionalQuestionLocator, 600);
            firstQuestion.Click();

            Log.Info("Second instructional question is opened");

            return this;
        }

        public IWebElement GetAnswerOnSecondInstructionalQuetion()
        {
            return FindElementWithWaitElementExists(answerOnSecondInstructionalQuestionLocator, 600);
        }
    }
}
