# Especificações do Projeto

A definição precisa do problema e os aspectos mais pertinentes a serem observados neste projeto foram consolidados através de um trabalho de imersão, realizado pela equipe, que envolveu a observação dos usuários em seu ambiente natural, bem como entrevistas com especialistas. Os insights obtidos durante esse processo foram sintetizados na forma de personas e histórias de usuários.

## Personas

As personas desenvolvidas como parte do entendimento do problema são adquiridas a seguir:
Lucas Silva
Idade: 36 anos
Ocupação: Odontolegista, trabalha como perito criminal em um instituto médico-legal, auxiliando na identificação de restos mortais desconhecidos em casos criminais e de desastres em massa.
Motivações: 
- Contribuir para a solução de casos forenses complexos.
- Desenvolver técnicas que auxiliam na identificação humana.
Frustrações:
- Falta de investimentos em recursos tecnológicos nos IML’S.
- Dificuldade em adquirir e preservar o acervo bibliográfico de consulta no IML.
Hobbies, História:
- Lucas é apaixonado por ciências forenses e tecnologia desde sua graduação em odontologia. Ele é ativo em conferências e workshops, buscando sempre se atualizar nas técnicas e metodologias da área.

Ana Luiza Braga
Idade: 27 anos
Ocupação: Estudante, estudante do último ano do curso de medicina e monitora da disciplina de medicina legal.
Motivações: 
- Contribuir para o meio acadêmico por meio de produção de conteúdo científico.
- Aprimorar métodos de estimativa de sexo a partir de estudos antropológicos do crânio.
Frustrações:
- Falta de ferramentas tecnológicas específicas para aplicar no estudo acadêmico da antropologia forense.
Hobbies, História:
- Ana é estagiária do setor de antropologia forense de um IML, presidente da liga acadêmica de antropologia forense de sua região. Após concluir sua graduação pretende prestar concurso para perito criminal da polícia federal.



Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| Gerenciar um inventário ósseo com checklist dos ossos do crânio com campo de comentário associado a cada osso | ALTA | 
|RF-02| Realizar a contagem óssea   | BAIXA |
|RF-03| Gerenciar uma base de imagens a partir de fotografias do inventário ósseo  | MÉDIA |
|RF-04| Armazenar fotografias dos achados patológicos do crânio.   | MÉDIA |
|RF-05| Disponibilizar a imagem de cada osso para realizar a classificação de formato associada a ele.  | MÉDIA |
|RF-06| Disponibilizar guia de referência didático visual para consulta.| ALTA |
|RF-07| Classificar os marcadores ósseos para estimativa de sexo.   | ALTA |
|RF-08| Calcular sexo a partir das características anatômicas dos ossos do crânio.   | ALTA |
|RF-09| Permitir que o usuário realize cadastro na aplicação.   | ALTA |
|RF-10| Permitir que o usuário faça login.   | ALTA |
|RF-11| Permitir que o usuário acesse e imprima um PDF com as informações geradas.   | BAIXA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-02| Publicar o aplicativo em ambiente acessível na Internet |  ALTA | 
|RNF-03| Compatibilidade com navegadores principais |  MÉDIA | 
|RNF-04| Realizar cálculo em menos de 3 segundos |  ALTA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Utilizando apenas tecnologias básicas da Web no Front-end e Back-end |
|03| Número pequeno de desenvolvedores responsáveis pelo desenvolvimento da aplicação |
|04| Custo elevado da literatura para o embasamento técnico-científico |

## Diagrama de Casos de Uso

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/b4586cf483c0e4b2e720408f6a0b23bc54b0f009/docs/img/User's%20case%20diagram.png">

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
