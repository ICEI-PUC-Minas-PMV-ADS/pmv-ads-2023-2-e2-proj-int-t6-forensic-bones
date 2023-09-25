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


## Histórias de Usuários

A partir da compreensão das personas identificadas para o projeto "Estimativa de Sexo por Meio de Estudos Antropológicos do Crânio", foram registradas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Lucas Silva         | Desejo uma ferrmanenta que me permita catalogar e registrar informações escritas, bem como imagens sobre achados ósseos. | Para facilitar o processo de identificação humana e armazenar os dados que possam ser utilizados no futuro. |
|Lucas Silva  |Desejo um sistema que identifica e contabiliza os cinco marcadores biológicos  clássicos do crânio para estimativa o sexo : Crista nucal, processo mastoide, área da glabela, margem supra orbital, e eminência mentoniana, incluídas nas normas para a coleta de dados a partir do sistema de classificação de restos de esqueletos humanos (Buikstra e Ubelaker, 1994) e selecionada com base nos estudos pessoais do autor (Walker, 2008:40). | Para agilizar e melhorar a precisão do processo de identificação, economizando tempo e recursos. |
|Ana Luiza Braga  | Gostaria de uma plataforma que possibilite o armazenamento e a classificação das informações obtidas através da análise do dimorfismo sexual, por meio da avaliação dos marcadores classificáveis presentes no crânio. | Para enriquecer meu conhecimento e aprimorar minhas habilidades na área de antropologia forense. |
|Ana Luiza Braga  | Desejo uma ferramenta que me permita realizar consulta ao material didático sobre métodos de estimativa de sexo a partir do crânio. | Para ter praticidade e agilidade no acesso ao conteúdo científico específico. |

## Requisitos

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| Gerenciar cadastro antropológico. | ALTA | 
|RF-02| Gerenciar inventário ósseo.  | ALTA |
|RF-03| Registrar a contagem óssea.  | BAIXA |
média|RF-05| Armazenar fotografias dos achados patológicos.  | MÉDIA |
|RF-06| Consulta de imagem óssea para classificação de formato| MÉDIA |
|RF-07| Disponibilizar guia de referência didático visual para consulta.   | ALTA |
|RF-08| Classificar os marcadores ósseos para estimativa de sexo.  | ALTA |
|RF-09| Calcular sexo a partir das características anatômicas dos ossos do crânio.   | ALTA |
|RF-10| Gerenciar login.   | ALTA |
|RF-11| Gerenciar relatórios.   | BAIXA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01| Garantir responsividade em dispositivos móveis | ALTA | 
|RNF-02| Assegurar bom nível de contraste na interface |  ALTA | 
|RNF-03| Compatibilidade com navegadores principais |  ALTA | 
|RNF-04| Calcular sexo em menos de 5 segundos |  MÉDIA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Utilizando apenas tecnologias básicas da Web no Front-end e Back-end |
|03| Número pequeno de desenvolvedores responsáveis pelo desenvolvimento da aplicação |
|04| Custo elevado da literatura para o embasamento técnico-científico |

## Diagrama de Casos de Uso

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/2a1235e7c27d3aad72af8fa19531220bea321696/docs/img/User's%20case%20diagram.png">
Figura 1 - Diagrama de casos de uso
