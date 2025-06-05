using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using FluentAssertions;

// Validar preenchimento do nome social opcional
namespace ChallangeQA.Steps
{
    [Binding]
    public class CT023Steps
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public CT023Steps()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

    [Given(@"que o usuário informe os dados necessários antes de preencher o formulario")]
    public void GivenQueOUsuarioInformeOsDadosNecessariosAntesDePreencherOFormulario()
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

        [When(@"preencher o campo Nome social com Mariana")]
        public void WhenPreencherOCampoNomeSocialComMariana()
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

            var nomeSocialInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='social-name-input']")));
                nomeSocialInput.SendKeys("Mariana");

            var emailInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='email-input']")));
                emailInput.SendKeys("jessica@teste.com.br");

            var celularInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='cellphone-input']")));
                celularInput.SendKeys("31975000000"); 

            var telefoneInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='phone-input']")));
                 telefoneInput.SendKeys("3132320032");

            var cepInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='cep-input']")));
                cepInput.SendKeys("30330000");

            var enderecoInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='address-input']")));
                enderecoInput.SendKeys("Rua A");

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

        [Then(@"o valor Mariana deve ser mantido e aceito como nome social")]
        public void ThenOValorMarianaDeveSerMantidoEAceitoComoNomeSocial()
        {   

             var nomeSocialInput = wait.Until(d =>
                 d.FindElement(By.CssSelector("[data-testid='social-name-input']")));
    
            var valorDigitado = nomeSocialInput.GetAttribute("value");
                valorDigitado.Should().Be("Mariana");
          
            var botaoAvancar = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='next-button']")));
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
