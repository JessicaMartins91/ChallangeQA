Feature: Validação da aplicação MaisA

@ignore
Scenario: CT001: Exibir opções ao selecionar graduação
Given que o usuário esteja na tela de seleção de nível de graduação
When selecionar a opção Graduação e clicar
Then deve ser exibida a modal Selecione seu curso de graduação

@ignore
Scenario: CT002: Confirmar seleção do curso de graduação
Given que o usuário clique para selecionar curso
When pesquisar o curso Engenharia de Software
Then o curso Engenharia de Software deve ser exibido como selecionado

@ignore
Scenario: CT003: Avançar após preencher todos os campos obrigatórios do cadastro
Given que o usuário preencha o nível e o curso de graduação
When tenha preenchido todos os campos obrigatórios do formulário de cadastro
Then ao clicar em 'Avançar' deve ser direcionado para a tela que informa seu usuário e senha.

@ignore
Scenario: CT004: Avançar sem preencher todos os campos obrigatórios do cadastro
Given que o usuário tenha preenchido o nível e o curso de graduação
When tenha preenchido os campos obrigatórios do formulário de cadastro exceto CPF
Then ao clicar em avançar uma mensagem de alerta deve ser exibida informando que o campo é obrigatório.

@ignore
Scenario: CT005: Avançar sem preencher apenas o campo nome
Given que o usuário tenha avançado as duas etapas iniciais
When tenha preenchido os campos obrigatórios do formulário de cadastro exceto Nome
Then ao clicar em avançar um alerta deve ser exibido informando que o campo é obrigatório.

@ignore
Scenario: CT006: Avançar sem preencher apenas o campo sobrenome
Given que o usuário tenha informado seu nivel de ensino e seu curso 
When tenha preenchido os campos obrigatórios do formulário de cadastro exceto Sobrenome
Then ao tentar avançar um alerta deve ser exibido informando que o campo é obrigatório.

@ignore
Scenario: CT007: Avançar sem preencher apenas o campo email
Given que o usuário tenha informado os dados das etapas anteriores 
When tenha preenchido os campos obrigatórios do formulário de cadastro exceto email
Then ao avançar sem informar o campo email um alerta deve ser exibido campo é obrigatório.

@ignore
Scenario: CT008: Avançar sem preencher apenas o campo celular
Given que o usuário tenha informado as etapas anteriores 
When tenha preenchido os campos obrigatórios do formulário de cadastro exceto celular
Then ao avançar sem informar o campo celular um alerta deve ser exibido campo é obrigatório.

Scenario: CT009: Avançar sem preencher apenas o campo cep
Given que o usuário que os dados das etapas anteriores tenham sido informadas
When tenha preenchido os campos obrigatórios do formulário de cadastro exceto cep
Then ao avançar sem informar o campo cep um alerta deve ser exibido campo é obrigatório.