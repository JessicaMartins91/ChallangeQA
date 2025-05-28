Estratégia para uso da massa de dados de teste (PostgreSQL)

Com a aplicação passando a salvar informações em um banco de dados PostgreSQL, é importante organizar bem os dados usados nos testes para que tudo funcione de forma segura e confiável.
A ideia é usar um banco exclusivo só para testes, separado do banco de produção, para evitar qualquer risco de interferência nos dados reais.
Também é possível criar uma cópia do banco original e substituir os dados reais por versões falsas, o que ajuda a deixar os testes mais próximos do uso real da aplicação, sem comprometer nenhuma informação sensível.