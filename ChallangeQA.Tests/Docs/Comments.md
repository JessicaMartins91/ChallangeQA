Atividade 1:

Decisões da arquitetura utilizada:

O projeto foi desenvolvido com foco na escalabilidade e na facilidade de manutenção. Por isso, cada teste está organizado em arquivos separados. A estrutura de pastas foi criada para ser clara e intuitiva, facilitando o entendimento. Essa organização traz mais clareza ao código, que fica bem segmentado e simples de atualizar, tornando a manutenção dos testes muito mais ágil.


Lista de bibliotecas de terceiros utilizadas:

Selenium Chrome Extensão do Selenium para controlar o navegador Chrome especificamente.
Selenium Support UI: Fornece recursos auxiliares ao Selenium, como esperas explícitas (waits), seletores de dropdowns, etc.
SpecFlow: Ferramenta de BDD (Behavior Driven Development) para .NET. Permite escrever cenários de teste em linguagem natural (Gherkin).
FluentAssertions: Para validação dos testes.


O que você melhoraria se tivesse mais tempo:

Dificuldade no mapeamento de elementos para testes automatizados: Grande parte dos elementos da interface não possui identificadores únicos (IDs), e em diversos casos, os IDs mudam dinamicamente a cada interação com a tela, o que compromete a estabilidade dos testes. Frequentemente, foi necessário recorrer ao uso de classes CSS para localizar os elementos, o que não é o método mais confiável em ambientes com alterações constantes no layout.

Estruturação e organização do código: Investiria em uma arquitetura de testes mais robusta, aplicando padrões como Page Object Model para tornar o código mais legível, reutilizável (Massa de dados) e fácil de manter.

Estabilidade e confiabilidade dos testes: Buscaria reduzir a instabilidade dos testes melhorando a sincronização, usando esperas explícitas em vez de esperas fixas, e implementando tratamento de exceções para cenários dinâmicos.

