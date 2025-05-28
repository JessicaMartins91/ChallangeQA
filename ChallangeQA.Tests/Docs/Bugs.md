Relatório de Bugs:

Bug 1: Página inicial pré-seleciona nível graduação e não exibe botão avançar
Descrição: Ao acessar a página inicial, o sistema retorna com o nível "Graduação" pré-selecionado, porém o botão "Avançar" não é exibido.
Comportamento esperado: A página inicial deve carregar sem nenhuma opção pré-selecionada, e o botão "Avançar" deve estar visível apenas quando uma opção válida for selecionada.
Passos para reproduzir: Acessar a página inicial 'Escolha o seu nível de ensino e embarque nessa aventura!'.
Gravidade: Média

Bug 2: Seleção "Graduação" exibe cursos de outros níveis
Descrição: Ao selecionar a opção "Graduação", o sistema exibe cursos que pertencem a outros níveis, como Mestrado,Doutorado e Especialização, que não deveriam aparecer nesta categoria.
Comportamento esperado: Somente cursos de graduação devem ser exibidos quando esta opção for selecionada.
Passos para reproduzir: Selecionar "Graduação" >> Verificar a listagem dos cursos exibidos.
Gravidade: Alta

Bug 3: Após voltar de um curso, o botão "Avançar" não aparece, embora "Graduação" permaneça selecionado
Descrição: Após selecionar um curso de graduação e clicar em "Voltar", a opção "Graduação" permanece pré-selecionada, porém o botão "Avançar" não é exibido. É necessário escolher outro curso de graduação para que o botão volte a aparecer.
Comportamento esperado: O botão "Avançar" deve estar visível sempre que o nível de ensino for informado independente da navegação.
Passos para reproduzir: Selecionar um curso de graduação >> Clicar no botão "Voltar" >> Observar que o botão "Avançar" não aparece.
Gravidade: Média

Bug 4: Campo ‘Selecione seu curso de graduação’ considera espaços digitados na validação
Descrição: O sistema considera os espaços inseridos no campo "Selecione seu curso de graduação" para definir se o curso existe, causando erros de validação quando há espaços extras.
Comportamento esperado: Espaços em branco no início ou fim devem ser ignorados na validação do curso.
Passos para reproduzir: Digitar um nome de curso com espaços extras >> Verificar se o sistema valida incorretamente.
Gravidade: Baixa

Bug 5: Campo "CPF" permite caracteres não numéricos
Descrição: O campo "CPF" aceita a inserção de letras e símbolos, o que não deveria ocorrer.
Comportamento esperado: O campo deve aceitar apenas números.
Passos para reproduzir: Digitar letras ou símbolos no campo "CPF"
Gravidade: Média

Bug 6: Campo "CPF" não possui máscara para limitar caracteres
Descrição: O campo "CPF" não possui máscara ou limite para a quantidade de caracteres, permitindo inserir mais do que o permitido.
Comportamento esperado: Deve haver uma máscara para aceitar apenas 11 dígitos numéricos.
Passos para reproduzir: Inserir mais de 11 caracteres no campo "CPF".
Gravidade: Média

Bug 7: Campo "Nome" aceita caracteres inválidos (símbolos e números)
Descrição: O campo "Nome" permite a inserção de caracteres inválidos, como números e símbolos, que não deveriam ser aceitos.
Comportamento esperado: O campo deve aceitar apenas letras e caracteres válidos para nomes.
Passos para reproduzir: Digitar números ou símbolos no campo "Nome".
Gravidade: Baixa

Bug 8: Campo "Data de Nascimento" permite seleção de datas futuras
Descrição: É possível selecionar datas no futuro no campo "Data de Nascimento", o que é incorreto.
Comportamento esperado: O campo deve limitar a seleção para datas no passado.
Passos para reproduzir: Selecionar uma data futura no campo "Data de Nascimento".
Gravidade: Média

Bug 9: Campo "Celular" permite inserção de caracteres não numéricos
Descrição: O campo "Celular" aceita letras e símbolos, quando deveria aceitar apenas números.
Comportamento esperado: O campo deve aceitar apenas números e formatar o telefone corretamente.
Passos para reproduzir: Digitar letras ou símbolos no campo "Celular".
Gravidade: Média

Bug 10: Campo "Telefone" permite inserção de caracteres não numéricos
Descrição: O campo "Telefone" aceita caracteres que não sejam números, o que é incorreto.
Comportamento esperado: Aceitar somente números e caracteres válidos para telefone (ex: parênteses, traço).
Passos para reproduzir: Inserir letras ou símbolos no campo "Telefone".
Gravidade: Média

Bug 11: Campo "Telefone" considera válido apenas caracteres especiais
Descrição: O campo "Telefone" valida como correto somente a entrada de caracteres especiais.
Comportamento esperado: O campo deve validar números e caracteres especiais, como parênteses e traços, corretamente.
Passos para reproduzir: Inserir apenas caracteres especiais no campo "Telefone".
Gravidade: Alta

Bug 12: Campo "Endereço" não possui espaço específico para número do imóvel
Descrição: No campo "Endereço", não há um campo separado para inserir o número do imóvel, causando confusão no preenchimento.
Comportamento esperado: Deve existir um campo específico para o número do imóvel, separado do endereço.
Passos para reproduzir: Acessar o formulário campo endereço.
Gravidade: Baixa


Bug 13: Campo "CEP" considera válido apenas caracteres especiais
Descrição: O campo "CEP" aceita como válido somente caracteres especiais.
Comportamento esperado: O campo deve aceitar somente números no formato correto do CEP.
Passos para reproduzir: Digitar caracteres especiais no campo "CEP".
Gravidade: Alta

Bug 14: Página carrega com nível de ensino "Graduação" pré-selecionado
Descrição: Ao acessar a página, o nível de ensino "Graduação" está pré-selecionado automaticamente, sem ação do usuário.
Comportamento esperado: Nenhuma opção deve estar pré-selecionada na carga inicial da página.
Passos para reproduzir: Acessar a página inicial.
Gravidade: Média

Bug 15: Sistema indica qual dado de login está incorreto (usuario ou senha)
Descrição: Ao informar login incorreto, o sistema sinaliza especificamente se o usuário ou a senha está errado, o que compromete a segurança.
Comportamento esperado: O sistema deve exibir uma mensagem genérica, por exemplo, "Usuário ou senha inválidos", sem especificar o campo errado.
Passos para reproduzir: Inserir usuário ou senha incorretos.
Gravidade: Alta

Bug 16: Sistema não permite visualizar senha e obriga a digitar tudo novamente após erro no login
Descrição: O sistema não oferece a opção de visualizar a senha e, caso haja erro no login, o usuário precisa preencher novamente todos os dados.
Comportamento esperado: Deve haver opção de mostrar a senha digitada e manter os dados preenchidos após erro para facilitar correção.
Passos para reproduzir: Informar dados de login incorretos.
Gravidade: Média