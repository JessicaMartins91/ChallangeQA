using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using FluentAssertions;

//Preencher o campo telefone com mais caracteres na tela de cadastro
namespace ChallangeQA.Steps
{
    [Binding]
    public class CT021Steps
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public CT021Steps()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Given(@"que o usuário está na tela de cadastro preenchendo as informações pessoais")]
        public void GivenQueOUsuárioEstáNaTelaDeCadastroPreenchendoAsInformacoesPessoais()
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

            var botaoAvancar = wait.Until(d =>
                d.FindElement(By.CssSelector("button.inline-flex.items-center.justify-center.bg-primary"))
            );
            botaoAvancar.Click();
        }

        [When(@"o usuário preenche o campo Telefone com mais de 15 caracteres")]
        public void WhenUsuarioPreencheTelefoneComMaisDe15Caracteres()
        {
            var cpfInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='cpf-input']")));
            cpfInput.SendKeys("11495607623");

            var nomeInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='name-input']")));
            nomeInput.SendKeys("Jéssica");

            var sobrenomeInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='surname-input']")));
            sobrenomeInput.SendKeys("Martins");

            var emailInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='email-input']")));
            emailInput.SendKeys("teste.com.br");

            var celularInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='cellphone-input']")));
            celularInput.SendKeys("31975030000"); 

            var telefoneInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='phone-input']")));
            telefoneInput.SendKeys("31323232323232323");

            var cepInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='cep-input']")));
            cepInput.SendKeys("30330000");

            var enderecoInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='address-input']")));
            enderecoInput.SendKeys("Rua A");

            var complementoInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='complement-input']")));
            complementoInput.SendKeys("");

            var bairroInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='neighborhood-input']")));
            bairroInput.SendKeys("São Pedro");

            var cidadeInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='city-input']")));
            cidadeInput.SendKeys("Belo Horizonte");

            var estadoInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='state-input']")));
            estadoInput.SendKeys("Minas Gerais");

            var paisInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='country-input']")));
            paisInput.SendKeys("Brasil");
        }

    [Then(@"deve ser exibida a mensagem no campo telefone Devem ser informados no máximo 15 caracteres")]
    public void ThenMensagemMaxCaracteresTelefone()
        {
            var botaoAvancar = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='next-button']")));
            botaoAvancar.Click();

            var alertaTelefone = wait.Until(d =>
                d.FindElement(By.XPath("//p[@role='alert' and contains(text(), 'Devem ser informados no máximo 15 caracteres')]"))
            );
            alertaTelefone.Text.Should().Contain("Devem ser informados no máximo 15 caracteres");
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
