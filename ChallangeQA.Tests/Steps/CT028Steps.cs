using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using FluentAssertions;
using Xunit;


//Tentativa de login informando apenas o campo senha inválido
namespace ChallangeQA.Steps
{
    [Binding]
    public class CT028Steps
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public CT028Steps()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }
    
        [Given(@"que depois de preencher os dados para cadastro")]
        public void GivenQueDepoisDePreencherOsDadosParaCadastro()
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
                d.FindElement(By.CssSelector("[data-testid='next-button']")));
            botaoAvancar.Click();

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
            emailInput.SendKeys("jessica@teste.com.br");

            var celularInput = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='cellphone-input']")));
            celularInput.SendKeys("31975030000"); 

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

            var botaoAvancarParaLogin = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='next-button']")));
            botaoAvancarParaLogin.Click();

            var acessarAreaCandidato = wait.Until(d => 
                d.FindElement(By.CssSelector("[data-testid='next-button']")));
                acessarAreaCandidato.Click();
        }
    
        [When(@"preencher apenas o campo usuário com o valor inválido")]
        public void WhenPreencherApenasOCampoUsuarioComOValorInvalido()
        {
            var informarLogin = wait.Until(d => 
                d.FindElement(By.CssSelector("[data-testid='username-input']")));
                informarLogin.SendKeys("candidat@");

            var informarSenha = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='password-input']")));
                informarSenha.SendKeys("subscription");
        }
    
        [Then(@"o sistema deve alertar que o usuário é invalido não permitindo login")]
        public void ThenOSistemaDeveAlertarQueOUsuarioEInvalidoNaoPermitindoLogin()
        {
            var botaoLogin = wait.Until(d =>
                d.FindElement(By.CssSelector("[data-testid='login-button']")));
                botaoLogin.Click();

            var alertaUsuarioInvalido = wait.Until(d =>
                d.FindElement(By.XPath("//p[@role='alert' and contains(text(), 'Usuário inválido')]"))
            );
                alertaUsuarioInvalido.Text.Should().Contain("Usuário inválido");
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}