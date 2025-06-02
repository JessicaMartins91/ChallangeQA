# Estratégia de Massa de Dados – k6-data.md

## 1. GET para 100, 500 e 1000 acessos simultâneos

**Estratégia usada:** *Sem necessidade de massa de dados dinâmica.*

Neste cenário, os testes foram realizados simulando múltiplos acessos simultâneos ao endpoint `GET`, sem necessidade de autenticação.

---

## 2. 100 acessos simultâneos com o mesmo login

**Estratégia usada:** *Usuário fixo pré-configurado.*

Foi utilizado um único usuário com credenciais fixas para simular 100 acessos simultâneos. 

**Limitação identificada:**  
Houve tentativa de criar múltiplos usuários dinamicamente por meio de uma API de cadastro, mas a mesma estava indisponível, retornando erro `404`. Por esse motivo, não foi possível validar as credenciais nem garantir uma massa de dados variada para esse teste.

---

## 3. Personalizar pizza com 50 usuários

**Estratégia usada:** *Usuário único com múltiplas requisições.*

Foi utilizado um único login para simular 50 usuários personalizando pizzas em paralelo.

---

## 4. Clicar em "Pizza, por favor" com 50 usuários

**Estratégia usada:** *Usuário único reutilizado em VUs paralelas.*

De forma semelhante ao cenário anterior, foi utilizado um usuário fixo para enviar requisições simultâneas ao endpoint `"Pizza, por favor"`. 

---

## Observações Finais

- **Tentativa de criação de massa dinâmica:**  
Foi realizada uma tentativa de gerar usuários distintos antes dos testes. Contudo, a API responsável por essa operação retornava erro `404`, o que impossibilitou a geração de massa variada.

- **Impacto nas simulações:**  
A limitação de criação de usuários comprometeu a diversidade de dados utilizados nos testes de endpoints que exigem autenticação. Por esse motivo, foram reutilizados usuários fixos para simular concorrência.

- **Alternativa adotada:**  
A estratégia final foi utilizar um número fixo e pequeno de usuários conhecidos para testar a performance das APIs. Apesar das limitações, os testes foram válidos para identificar gargalos de resposta e comportamento da aplicação sob carga.

