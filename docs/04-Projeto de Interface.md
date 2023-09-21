
# Projeto de Interface

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Visão geral da interação do usuário pelas telas do sistema e protótipo interativo das telas com as funcionalidades que fazem parte do sistema (wireframes).

 Apresente as principais interfaces da plataforma. Discuta como ela foi elaborada de forma a atender os requisitos funcionais, não funcionais e histórias de usuário abordados nas <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a>.

## Diagrama de Fluxo

O diagrama apresenta o estudo do fluxo de interação do usuário com o sistema interativo e  muitas vezes sem a necessidade do desenho do design das telas da interface. Isso permite que o design das interações seja bem planejado e gere impacto na qualidade no design do wireframe interativo que será desenvolvido logo em seguida.

O diagrama de fluxo pode ser desenvolvido com “boxes” que possuem internamente a indicação dos principais elementos de interface - tais como menus e acessos - e funcionalidades, tais como editar, pesquisar, filtrar, configurar - e a conexão entre esses boxes a partir do processo de interação. Você pode ver mais explicações e exemplos https://www.lucidchart.com/blog/how-to-make-a-user-flow-diagram.

<img src ="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/Diagrama%20de%20Fluxo.png">

As referências abaixo irão auxiliá-lo na geração do artefato “Diagramas de Fluxo”.

> **Links Úteis**:
> - [Fluxograma online: seis sites para fazer gráfico sem instalar nada | Produtividade | TechTudo](https://www.techtudo.com.br/listas/2019/03/fluxograma-online-seis-sites-para-fazer-grafico-sem-instalar-nada.ghtml)

## Wireframe Interativo

Conforme o diagrama de fluxo do projeto, apresentado no item anterior, as telas do sistema são apresentadas em detalhes nos itens que se seguem. Para visualizar o wireframe interativo, acesse o ambiente <a href="https://marvelapp.com/prototype/f10e001">MarvelApp do projeto</a>.

<img src ="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/_%20Wireframe%20%20(Forensic%20Bones)%20.jpg">

As telas do sistema apresentam uma estrutura comum que é apresentada na Figura 1. Nesta estrutura, existem 3 grandes blocos, descritos a seguir. 
São eles:

●	Cabeçalho - local onde são dispostos elementos fixos de identidade (logo) e navegação principal do site (menu da aplicação);

●	Conteúdo - apresenta o conteúdo da tela em questão;

<img src ="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/_%20Wireframe%20%20(Forensic%20Bones)_%20Figura%201%20-%20Estrutura%20padr%C3%A3o%20do%20site.png">

Figura 1 - Estrutura padrão do site


Tela - Landing Page 1

A interface da Página Landing Page 1 exibe o título da aplicação e apresenta dois botões: "Quero me cadastrar" e "Já sou cadastrado". Esses botões são usados ​​pelo sistema para cadastro de usuários e acesso a página home do aplicativo.


<img src ="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/_%20Wireframe%20%20(Forensic%20Bones)%20_Figura%202%20-%20Landing%20Page%201.png">

Figura 2 - Landing Page 1 


Tela - Cadastro

<img src ="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/_%20Wireframe%20%20(Forensic%20Bones)%20_Figura%203%20-%20Landing%20Page%201.1.png">

Figura 3 - Cadastro


Tela - Entrar

<img src ="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/_%20Wireframe%20%20(Forensic%20Bones)%20_Figura%204%20-%20Landing%20Page%201.2.png">

Figura 4 - Entrar


Tela - Home

Após o usuário realizar o login, ele será direcionado à página inicial, onde encontrará um campo na área do cabeçalho que possibilitará a busca por relatórios concluídos. Na área de conteúdo, estará disponível um campo com os relatórios mais recentes, identificados pelo número do relatório e data de criação. Adicionalmente, um calendário permitirá o acesso aos relatórios com base em datas específicas, e um botão abrirá um novo relatório em branco para preenchimento.

<img src ="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/_%20Wireframe%20%20(Forensic%20Bones)%20_Figura%205%20-%20Home.png">

Figura 5 - Home


Tela - Inventário do esqueleto

Ao acessar o relatório de antropologia forense, o usuário deverá inserir o número de identificação do relatório (LAF) e a data de realização do exame (Data do exame). O primeiro elemento a ser apresentado ao usuário é o inventário do esqueleto, onde todos os ossos que compõem o esqueleto humano estão listados. Para nossa aplicação, neste momento, apenas os ossos que compõem o crânio estarão disponíveis, permitindo que sejam catalogados numericamente e registradas quaisquer observações pertinentes a cada elemento ósseo.


<img src ="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/_%20Wireframe%20%20(Forensic%20Bones)%20_Figura%206%20-%20Invent%C3%A1rio%20do%20esqueleto.png">

Figura 6 - Inventário do esqueleto

Tela - Fotografias dos restos do esqueleto

Depois de completar o registro do inventário do esqueleto, o usuário terá a possibilidade de gerenciar as fotografias dos restos do esqueleto em sua posição anatômica. Isso pode ser feito facilmente usando os botões "Inserir Foto" e "Remover Foto". A mesma funcionalidade se estende à tela de "Fotografias dos Achados Patológicos no Esqueleto", possibilitando a inserção de imagens específicas das alterações encontradas nos ossos que foram catalogados.

<img src ="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/_%20Wireframe%20%20(Forensic%20Bones)%20_Figura%207-%20Fotografias%20dos%20restos%20do%20esqueleto.png">

Figura 7 - Fotografias dos restos do esqueleto


Tela - Fotografias dos achados patológicos no esqueleto

<img src ="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/_%20Wireframe%20%20(Forensic%20Bones)%20_Figura%208-%20Fotografias%20dos%20achados%20patol%C3%B3gicos%20no%20esqueleto.png">

Figura 8 - Fotografias dos achados patológicos no esqueleto


Tela - Estimativa de Sexo pelo crânio

Na tela de estimativa de sexo, o usuário encontra um campo que lista as características ou estruturas a serem avaliadas para essa finalidade. Através dos indicadores (Masculino, inconclusivo ou feminino), o usuário pode determinar se é possível estimar o sexo de um indivíduo com base nas características anatômicas envolvidas no processo.

Ao clicar nas características a serem avaliadas, um campo exibe referências científicas para auxiliar na análise. Além disso, existe um espaço destinado a comentários, no qual o usuário pode inserir observações pertinentes com base em seu conhecimento técnico-científico. 

Ao concluir a análise, o usuário terá acesso a um botão que irá calcular e exibir a estimativa de sexo pelo crânio com base nas informações inseridas.

<img src ="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/_%20Wireframe%20%20(Forensic%20Bones)%20_Figura%209-%20Estimativa%20de%20Sexo%20pelo%20cr%C3%A2nio.png">

Figura 9 - Estimativa de Sexo pelo crânio

> **Links Úteis**:
> - [Protótipos vs Wireframes](https://www.nngroup.com/videos/prototypes-vs-wireframes-ux-projects/)
> - [Ferramentas de Wireframes](https://rockcontent.com/blog/wireframes/)
> - [MarvelApp](https://marvelapp.com/developers/documentation/tutorials/)
> - [Figma](https://www.figma.com/)
> - [Adobe XD](https://www.adobe.com/br/products/xd.html#scroll)
> - [Axure](https://www.axure.com/edu) (Licença Educacional)
> - [InvisionApp](https://www.invisionapp.com/) (Licença Educacional)
