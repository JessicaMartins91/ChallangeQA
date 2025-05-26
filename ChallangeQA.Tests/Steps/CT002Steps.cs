using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public StepDefinitions()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        
        [Given(@"que o usuário clique para selecionar curso")]
        public void GivenQueOUsuarioCliqueParaSelecionarCurso()
        {
            driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/");

            var comboBox = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='education-level-select']"))
            );
            comboBox.Click();

            var opcaoGraduacao = wait.Until(d =>
                d.FindElement(By.XPath("//div[@data-radix-vue-collection-item][contains(., 'Graduação')]"))
            );
            opcaoGraduacao.Click();
        }

        [When(@"pesquisar o curso Engenharia de Software")]
        public void WhenPesquisarOCursoEngenhariaDeSoftware()
        {
            var comboCurso = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='graduation-combo']"))
            );
            comboCurso.Click();

            var cursoInput = wait.Until(d =>
             d.FindElement(By.CssSelector("input.h-9"))         
            );
                cursoInput.Click();
                cursoInput.SendKeys("Engenharia de Software");
                cursoInput.SendKeys(Keys.Enter);
        }
      
        [Then(@"o curso Engenharia de Software deve ser exibido como selecionado")]
        public void ThenOCursoEngenhariaDeSoftwareDeveSerExibidoComoSelecionado()
        {
            var campoSelecionado = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='graduation-combo']"))
            );
            campoSelecionado.Text.Should().Contain("Engenharia de Software");
            
            var botaoAvancar = wait.Until(d =>
               d.FindElement(By.CssSelector("button.inline-flex.items-center.justify-center.bg-primary"))
    );
    botaoAvancar.Click();

        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
