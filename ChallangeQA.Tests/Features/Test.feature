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

@ignore
Scenario: CT009: Avançar sem preencher apenas o campo cep
Given que o usuário que os dados das etapas anteriores tenham sido informadas
When tenha preenchido os campos obrigatórios do formulário de cadastro exceto cep
Then ao avançar sem informar o campo cep um alerta deve ser exibido campo é obrigatório.

@ignore
Scenario: CT010: Avançar sem preencher apenas o campo endereço
Given que os dados das etapas anteriores tenham sido informados
When tenha preenchido os campos obrigatórios do formulário de cadastro exceto endereço
Then ao avançar sem informar o campo endereço um alerta deve ser exibido campo é obrigatório.

@ignore
Scenario: CT011: Avançar sem preencher apenas o campo bairro
Given que os dados das etapas anteriores tenham sido preenchidos corretamente
When tenha preenchido os campos obrigatórios do formulário de cadastro exceto bairro
Then ao avançar sem informar o bairro um alerta deve ser exibido campo é obrigatório.

@ignore
Scenario: CT012: Avançar sem preencher apenas o campo cidade
Given que os dados das etapas anteriores tenham sido corretamente inseridas
When tenha preenchido os campos obrigatórios do formulário de cadastro exceto cidade
Then ao avançar sem informar o cidade um alerta deve ser exibido campo é obrigatório.

@ignore
Scenario: CT013: Avançar sem preencher apenas o campo estado
Given que os usuario informou os dados necessários antes de preencher o formulário
When tenha preenchido os campos obrigatórios do formulário de cadastro exceto estado
Then ao avançar sem informar o estado um alerta deve ser exibido campo é obrigatório.

@ignore
Scenario: CT014: Avançar sem preencher apenas o campo pais
Given que os usuario informou todos os dados anteriores
When tenha preenchido os campos obrigatórios do formulário de cadastro exceto pais
Then ao avançar sem informar o pais um alerta deve ser exibido campo é obrigatório.

@ignore
Scenario: CT015: Permitir avanço sem preenchimento do campo Complemento
Given que o usuário tenha preenchido as informações anteriores ao formulário de inscrição
When clicar no botão "Avançar" sem preencher o campo Complemento
Then o sistema deve permitir que o usuário avance para a tela de login

@ignore
Scenario: CT016: Exibir alerta ao preencher o CPF com formato inválido
Given que o usuário esteja na página de formulário de inscrição
When preencher o campo CPF com o valor invalido
Then ao clicar em avançar uma mensagem de alerta deve ser exibida informando que o CPF é inválido

@ignore
Scenario: CT017: Validar formato do email inválido
Given que o usuário informe os dados cadastrais
When preencher o campo email com o valor invalido
Then uma mensagem de alerta deve ser exibida informando Email inválido

@ignore
Scenario: CT018: Preencher o campo Celular com menos caracteres
Given que o usuário foi direcionado a tela de cadastro
When o usuário preenche o campo Celular com menos de 10 caracteres
Then uma mensagem de alerta deve ser exibida informando sobre a quantidade de caracteres

@ignore
Scenario: CT019: Preencher o campo Celular com mais caracteres
 Given que o usuário foi direcionado a tela de cadastro e os dados foram informados
 When o usuário preenche o campo Celular com mais de 15 caracteres
 Then uma mensagem de alerta deve ser exibida informando sobre a quantidade maxima permitida

@ignore
 Scenario: CT020: Preencher o campo telefone com menos caracteres na tela de cadastro
 Given que o usuário está na tela de cadastro informando os dados necessários
 When o usuário preenche o campo Telefone com menos de 10 caracteres
 Then deve ser exibida a mensagem no campo telefone Devem ser informados no mínimo 10 caracteres

@ignore
 Scenario: CT021: Preencher o campo telefone com mais caracteres na tela de cadastro
 Given que o usuário está na tela de cadastro preenchendo as informações pessoais
 When o usuário preenche o campo Telefone com mais de 15 caracteres
 Then deve ser exibida a mensagem no campo telefone Devem ser informados no máximo 15 caracteres

@ignore
 Scenario: CT022: Validar a exibição da flag Possui deficiência
 Given que tenha preenchido as informações do formulario corretamente
 When o usuário marcar a opção Possui alguma deficiência?
 Then um campo para preenchimento relacionado à deficiência deve ser exibido

@ignore
Scenario: CT023: Validar preenchimento do nome social opcional
Given que o usuário informe os dados necessários antes de preencher o formulario
When preencher o campo Nome social com Mariana
Then o valor Mariana deve ser mantido e aceito como nome social


Scenario: CT024: Retornar para tela selecione seu nível de ensino
Given que o usuário esteja na tela selecione seu curso de Graduação
When clicar no botão voltar
Then o sistema deve retornar para a tela de Selecione seu nível de ensino














