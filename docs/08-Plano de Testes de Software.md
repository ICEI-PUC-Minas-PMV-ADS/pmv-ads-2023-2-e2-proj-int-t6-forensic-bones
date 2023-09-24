# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

| Caso de Teste | CT-001 Cadastro |
| --- | --- |
| Requisitos Associados | A tela home deve apresentar, a funcionalidade de cadastro de usuário, para que consigam gerenciar seus arquivos. |
| Objetivo do Teste | Testar se o usuário consegue se cadastrar na aplicação. |
| Passo | -Acessar o navegador e inserir, https:// forensicbones.com -Criar conta -Preencher os dados solicitados (nome, e-mail, CPF e senha) -clicar em registar-se. |
| Critério de Êxito | O cadastro vai ser realizado com sucesso e receber mensagem de confirmação de cadastro. |

| Caso de Teste | CT-002 Realizar Login |
| --- | --- |
| Requisitos Associados | A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste | Verificar se o usuário consegue logar. |
| Passo | -Acessar o navegador e inserir, https:// forensicbones.com -Clicar no botão “entrar” - Preencher e-mail e senha. |
| Critério de Êxito | Login realizado com sucesso. |

| Caso de Teste | CT-003 Esqueci minha senha |
| --- | --- |
| Requisitos Associados | A aplicação deve possuir opção de “Esqueci minha senha”. |
| Objetivo do Teste | Verificar se o usuário consegue trocar a sua senha. |
| Passo | -Acessar o navegador e inserir, https:// forensicbones.com -Clicar no hiperlink “Esqueci minha senha” - Preencher e-mail e CPF |
| Critério de Êxito | Login realizado com sucesso. |

| Caso de Teste | CT-004 Novo relatório LAF |
| --- | --- |
| Requisitos Associados | A aplicação deve ter um botão para adicionar novo relatório LAF. |
| Objetivo do Teste | Verificar se o usuário consegue começar novo relatório LAF adicionando data e ID |
| Passo | -Após fazer o login, o usuário clicar no botão novo relatório LAF. Entrar com nome, qualificação e data. |
| Critério de Êxito | A aplicação vai criar um ID com data para o novo relatório LAF. |

| Caso de Teste | CT-005 Inventário ósseo |
| --- | --- |
| Requisitos Associados | A aplicação deve ter um relação do inventário ósseo. |
| Objetivo do Teste | Verificar se o usuário consegue entrar com os dados pertinentes. |
| Passo | - Criar novo relatório LAF. -Entrar com quantidade de ossos e comentário, nas linhas correspondente a casa osso. |
| Critério de Êxito | Após inserir os dados os mesmos vão ser salvos. |

| Caso de Teste | CT-006 Salvar dados no inventário ósseo  |
| --- | --- |
| Requisitos Associados | A aplicação deve ter um botão de “salvar” ao final inventário ósseo. |
| Objetivo do Teste | Verificar se o usuário consegue salvar dados da analise óssea. |
| Passo | - Criar novo relatório LAF. -Entrar com quantidade de ossos e comentário, nas linhas correspondente a cada osso. - Salvar  |
| Critério de Êxito | Verificar se a aplicação salva os dados inseridos no inventário ósseo. |


 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
