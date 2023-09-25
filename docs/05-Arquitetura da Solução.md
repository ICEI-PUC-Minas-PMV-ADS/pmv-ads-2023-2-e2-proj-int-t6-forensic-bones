# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/Diagrama%20de%20Classes%20Atualizado.PNG">
Figura 14 - Diagrama de Classes


## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-forensic-bones/blob/main/docs/img/DER.png">
Figura 15 - Modelo Entidade-Relacionamento

## Projeto da Base de Dados

### Inventário Esqueleto 
|ID    | QuantidadeOssos  | Data |
|------|:---:|------------|
|LAF - 01| 23 | xx/xx/xxxx | 
|LAF - 02| 17 | xx/xx/xxxx |
|LAF - 03| 19 | xx/xx/xxxx |

### Fotografias Esqueleto
|IdEsqueleto | URL | 
|------|------------|
|LAF - 01 | http://example1.com.br |
|LAF - 02 | http://example2.com.br |
|LAF - 03 | http://example3.com.br |

### Inventário Crânio
|IdEsqueleto| IdCrânio | Descrição | Frontal | ... | Mandíbula |
|------|----------|---|:---:|---|:---:|
|LAF - 01| LAF01-1 | example1 | 1 | ... | 1 |
|LAF - 02| LAF01-2 | example2 | 3 | ... | 1 |
|LAF - 03| LAF01-2 | example3 | 1 | ... | 1 |

### Marcadores Crânio
|IdCranio| CristaNucal | ProcessoMastoide | EminenciaMentoniana | SupraOrbital | AreaGlabela | Observacoes |
|------|:---:|:---:|:---:|:---:|:---:|:-----:|
|LAF01-1| F | F | I | M | F | example1 |
|LAF01-2| M | I | M | M | F | example2 |
|LAF01-2| M | M | M | M | M | example3 |


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
