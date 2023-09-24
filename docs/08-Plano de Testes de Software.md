# Plano de Testes de Software

Neste plano de teste, buscamos detalhar as funções que necessitam de testes antes do primeiro contato com o usuário final. Cada caso abrange cenários específicos de teste de usabilidade e resposta da aplicação 

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

| Caso de Teste | CT-007 Inserir Fotos |
| --- | --- |
| Requisitos Associados | A aplicação deve ter um botão de “inserir foto” ao final do inventário ósseo. |
| Objetivo do Teste | Verificar se o usuário consegue entrar com arquivos JPGE, IMG, GIF, PNG. |
| Passo | - Criar novo relatório LAF. -Rolar a página até o final e após salvar, os dados ósseos - Inserir Fotos |
| Critério de Êxito | Verificar se a aplicação salva os dados inseridos no inventário ósseo. |

| Caso de Teste | CT-008 Preenchimento da estimativa de sexo pelo crânio |
| --- | --- |
| Requisitos Associados | A aplicação deve ter uma relação dos ossos para estimativa do sexo pelo crânio onde vai ser inserido a estimativa e espaço para comentário. |
| Objetivo do Teste | Verificar se o usuário consegue entrar com estimativa (está sendo somente S ou M) e podendo fazer um comentário ao final. |
| Passo | - Criar novo relatório LAF. -Rolar a página até o final e após salvar, os dados ósseos - Preenchimento de estimativa de sexo pelo crânio |
| Critério de Êxito | Verificar se a aplicação salva os dados inseridos em estimativa de sexo pelo crânio. |

Este plano de teste de software, datado de 24/09/2023, é um reflexo do nosso compromisso com a qualidade e funcionalidade do nosso software. No entanto, este é um documento vivo e novos casos de teste podem ser adicionados para abordar novas funcionalidades e cenários. Continuaremos a manter este plano atualizado para refletir nossos esforços contínuos em garantir a qualidade do software.
