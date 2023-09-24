# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/Diagrama%20de%20Classes%20Atualizado.PNG">
Figura x - Diagrama de Classes


## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/Modelo%20ER.png">
Figura x - Modelo Entidade-Relacionamento

## Projeto da Base de Dados

Projeto Conceitual:

Nesta fase, definimos a estrutura de informações de alto nível sem se preocupar com a implementação técnica. Para o "Forensic Bones," podemos definir as seguintes entidades conceituais e seus atributos:

Pessoa:

Atributos: ID (Chave Primária), Nome, Sexo, Data de Nascimento, Nacionalidade, Endereço, Etnia, etc.
Crânio:

Atributos: ID (Chave Primária), Comprimento, Largura, Altura, Data de Descoberta, Local de Descoberta, Estado de Conservação, etc.
Material de Referência:

Atributos: ID (Chave Primária), Tipo (por exemplo, Fotografia, Anotação), Descrição, Data de Coleta, Local de Coleta, Coletor, etc.
Estimativa de Sexo:

Atributos: ID (Chave Primária), Resultado (Masculino, Feminino, Indeterminado), Método de Estimativa, Data da Estimativa, Perito Responsável, etc.
Usuário:

Atributos: ID (Chave Primária), Nome de Usuário, Senha (criptografada), Função (Administrador, Analista, etc.), Email, Data de Registro, etc.
Nesta fase, também definimos os relacionamentos entre as entidades, como "Uma Pessoa pode ter Vários Crânios," "Um Crânio pode ter Vários Materiais de Referência" e "Uma Estimativa de Sexo pertence a Uma Pessoa."

Projeto Lógico:

No projeto lógico, traduzimos o modelo conceitual em um modelo adequado para um determinado Sistema de Gerenciamento de Banco de Dados Relacional (SGBD). Aqui estão as tabelas correspondentes às entidades e seus atributos:

Tabela Pessoa:

Colunas: ID (Chave Primária), Nome, Sexo, Data de Nascimento, Nacionalidade, Endereço, Etnia, etc.
Tabela Crânio:

Colunas: ID (Chave Primária), Comprimento, Largura, Altura, Data de Descoberta, Local de Descoberta, Estado de Conservação, etc.
Chave Estrangeira: ID da Pessoa (para vincular um crânio a uma pessoa).
Tabela Material de Referência:

Colunas: ID (Chave Primária), Tipo, Descrição, Data de Coleta, Local de Coleta, Coletor, etc.
Chave Estrangeira: ID da Pessoa (para vincular um material de referência a uma pessoa).
Tabela Estimativa de Sexo:

Colunas: ID (Chave Primária), Resultado (Masculino, Feminino, Indeterminado), Método de Estimativa, Data da Estimativa, Perito Responsável, etc.
Chave Estrangeira: ID da Pessoa (para vincular uma estimativa de sexo a uma pessoa).
Tabela Usuário:

Colunas: ID (Chave Primária), Nome de Usuário, Senha (criptografada), Função (Administrador, Analista, etc.), Email, Data de Registro, etc.
Projeto Físico:

Nesta fase, definimos como os dados serão armazenados fisicamente no SGBD escolhido. Aqui estão alguns detalhes técnicos a serem considerados:

Criar índices na tabela Pessoa para acelerar consultas por Nome, Data de Nascimento, ou outros campos frequentemente pesquisados.

Definir partições na tabela Crânio para melhorar o desempenho da consulta, por exemplo, por Local de Descoberta ou Data de Descoberta.

Estabelecer um plano de backup e recuperação para garantir a integridade dos dados, com agendamentos regulares de backup e testes de restauração.

Configurar restrições de acesso de usuário, garantindo que apenas usuários autorizados acessem informações confidenciais. Isso inclui definir permissões de acesso, autenticação e auditoria de segurança.

Implementar políticas de manutenção, como compactação de tabelas e atualização de estatísticas, para otimizar o desempenho do banco de dados ao longo do tempo.

## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
