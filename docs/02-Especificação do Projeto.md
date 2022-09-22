# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da coleta de dados dos usuários em seu local natural. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

|    `Nome`: Juliana Silveira Brancis  | `Profissão`: Médica Cardiologista        |     `Idade`: 38 Anos    |
|--------------------|------------------------------------|----------------------------------------|
| <img width="250" alt="image" src="https://user-images.githubusercontent.com/55036173/188963711-7db4ab2c-ea9d-4674-83e6-b1c8f8f4fb90.png">| `Motivações`: <br>  Organização no agendamento de pacientes <br> <br>  Facilidade para consultar agendamentos do dia  <br> <br> Facilidade na marcação de pacientes   |  `Frustrações`: <br>  Desorganização de agenda  <br> <br> Falta de facilidade na confirmação dos agendamentos <br><br>                    
|  `Hobbies`: |   `História`:  | `Personalidade`:  |
| <br> Adora assistir filmes <br><br> Gosta de passear ao Ar livre<br><br> Conhecer lugares novos <br> <br>     | Juliana é  médica cardiologista,   que preza pela boa <br> organizaçãoela é uma especialista que visa economizar tempo em suas marcações de pacientes  <br>            | Organizada <br><br> Extrovertida <br><br> Esfoçada<br>   |


|    `Nome`: Mario José Dantas  | `Profissão`: Desenvolvedor         |     `Idade`: 32 Anos    |
|--------------------|------------------------------------|----------------------------------------|
| <img width="250" alt="image" src="https://user-images.githubusercontent.com/55036173/188989388-76071b6b-c8b8-41e2-9f92-fa8ddb89d5c3.png">| `Motivações`: <br>  Otimizar tempo <br> <br> Ter um site para conferir marcações  <br> <br> Facilidade na marcação de consultas |  `Frustrações`: <br>   Perder tempo telefonando para clinicas <br> <br> Dificuldade na confirmação do agendamento <br><br> Esquecimento da data de marcação            
|  `Hobbies`: |   `História`:  | `Personalidade`:  |
| <br> Jogar Games  <br><br> Ouvir música livre<br><br> Conhecer tecnologias novas <br> <br>        | Mario José é um desenvolvedor focado<br> durante sue horario de trabalho, Mario se preocupa com a saúde <br>mas acaba indo pouco ao médico por falta de organização    <br>        | Desorganizado <br><br> Introvertido <br><br> Metodico  <br>    |


|    `Nome`: Marcelo Belchior  | `Profissão`: Aposentado         |     `Idade`: 70 Anos    |
|--------------------|------------------------------------|----------------------------------------|
| <img width="250" alt="image" src="https://user-images.githubusercontent.com/100283917/189008834-552789bd-d695-44eb-80f3-22b56fe5610e.jpg">| `Motivações`: <br>  Se cuidar mais <br> <br> Atendimento ágil  <br> <br> Facilidade de comunicação com hospital |  `Frustrações`: <br>   Ter de ir a hospitais muitas vezes <br> <br> Dificuldade na locomoção <br><br> Longa espera para o atendimento            
|  `Hobbies`: |   `História`:  | `Personalidade`:  |
| <br> Ler  <br><br> Jogos de mesa<br><br> Conversar com as pessoas <br> <br>        | Marcelo é aposentado e sofre com osteoporose<br> Devido a doença têm mobilidade reduzida e precisa de <br>cuidados no dia a dia, tornando difícel ir a hospitais   <br>        | Esforçado <br><br> Sério <br><br> Sábio  <br>    |



## Histórias de Usuários


Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Juliana Brancis    | Eficiencia e agilidade na marcação| Facilitar e agilizar a marcacão dos pacientes  |
|Juliana Brancis    | Visualizar as marcações | organizar melhor a agenda |
|Juliana Brancis    | Gerenciar os dados dos  pacientes | Facilidade na organização dos dados dos pacientes |
|Mario Dantas        | Realizar a marcação de consultas/exames | Marcar consultas com rapidez |
|Mario Dantas        | Realizar alteração de consultas/exames | Facilidade em gerenciar datas da marcação |
|Mario Dantas        | Visualizar a marcação de consultas e exames | Evitar esquecimento de datas |
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |

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
|RF-001| A aplicação devera possuir uma lading page explicando detralhes sobre o serviço fornecido. | ALTA |
|RF-002| A aplicação deve gerenciar médicos. Para um médico se cadastrar é necessário: CNPJ, NOME , E-MAIL, TELEFONE, SENHA, ESPECIALIDADE e ENDEREÇO | ALTA | 
|RF-003| A aplicação deve gerenciar pacientes. Para um paciente se cadastrar é necessário: CPF, NOME , E-MAIL, TELEFONE e SENHA. | ALTA |
|RF-004| A aplicação deve mostrar para o usuário todos os médicos cadastrados. | Baixa | 
|RF-005| A aplicação deverá mostrar uma agenda por médico.| ALTA | 
|RF-006| A aplicação deverá permitir que o médico gerencie sua agenda.  | MÉDIA |
|RF-007| A aplicação deverá permitir que o médico tenha informações dos seus pacientes. | Baixa | 
|RF-008| A aplicação deverá permitir que o paciente gerencie suas consultas de acordo com a disponibilidade do médico. | Alta |
|RF-009| A aplicação deverá permitir que o usuario tenha as infomações de contato do médico. | ALTA | 

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | Alta | 
|RNF-002| O sistema deverá usar o SEO do google para aparecer nas pesquisas do buscador|  Media |
|RNF-002| O back-end devera ser densevolvido em C#|  Alta |
|RNF-002| O sistema deverá seguir as normas da LGPD|  Alta |
|RNF-002| O sistema deve ser publicado em um ambiente acessível publicamente na internet (GitHub Pages, Hostinguer);|  Alta |

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do segundo semestre de 2022 |
|02| O projeto não possue orçamento |
|03| O projeto deve possuir apenas 6 integrantes |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

![image](https://user-images.githubusercontent.com/58198111/189532227-2bed6100-8032-4392-b682-3c445644153d.png)


As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
