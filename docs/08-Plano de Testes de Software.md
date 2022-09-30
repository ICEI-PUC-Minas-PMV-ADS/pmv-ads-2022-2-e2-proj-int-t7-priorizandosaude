# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário Paciente consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://priorizandosaude.github.com <br> - Clicar em "Paciente" no canto direito superior da tela <br> - Clicar em "Não tem cadastro clique aqui" - <br> preencher os campos obrigatórios (e-mail, nome, data de nascimento, genero, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso - Redirecionar para tela home do paciente |
| Caso de Teste 	| CT-02 – Cadastrar Médico	|
|Requisito Associado | RF-002	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário Médico consegue realizar login. |
| Passos 	|  - Informar o endereço do site https://priorizandosaude.github.com <br> - Clicar em "Médico" no canto direito superior da tela <br> - Clicar em "Não tem cadastro clique aqui" - <br> preencher os campos obrigatórios (e-mail, nome, especialidade, endereço, celular, CRM, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso - Redirecionar para tela home do médico |
| Caso de Teste 	| CT-03 – Efetuar login Paciente	|
|Requisito Associado | RF-010	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário Paciente consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://priorizandosaude.github.com <br> - Clicar no botão "Paciente" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
| Caso de Teste 	| CT-04 – Efetuar login Médico	|
|Requisito Associado | RF-010	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário médico consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://priorizandosaude.github.com <br> - Clicar no botão "Medico" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
| Caso de Teste 	| CT-05 – Mostrar médicos cadastrados	|
|Requisito Associado | RF-004	- A aplicação deve mostrar na tela home do paciente os medicos cadastrados quando preenchidos os campos de data e e especialidade  |
| Objetivo do Teste 	| Verificar se o usuário paciente visualiza os medicos cadastrados. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  https://priorizandosaude.github.com<br> - Clicar no botão "Paciente" <br> - Preencher o campo de e-mail  <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - preencher a data escolhida para consulta <br> - preencher a especilidade do médico | 
|Critério de Êxito | - Medicos disponiveis aparecem na tela. |
| Caso de Teste 	| CT-06 – Renderizar agenda do médico.		|
|Requisito Associado | RF-005 e RF-007	- A aplicação deve ser capaz de mostrar as proximas consultas do médico e as informações dos pacientes. |
| Objetivo do Teste 	| Verificar se o usuário médico é capaz de visualizar as proximas consultas agendadas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  https://priorizandosaude.github.com<br> - Clicar no botão "Médico" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em minhas consultas no canto superior direito da tela  |
|Critério de Êxito | - Renderização de consultas com sucesso |
| Caso de Teste 	| CT-07 – Confirmar consultas do paciente.		|
|Requisito Associado | RF-008	-A aplicação deverá permitir que o paciente gerencie suas consultas. |
| Objetivo do Teste 	| Verificar se o usuário médico é capaz de visualizar as proximas consultas agendadas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  https://priorizandosaude.github.com<br> - Clicar no botão "Paciente" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em minhas consultas no canto superior direito da tela <br> Clicar em confirmar |
|Critério de Êxito | - Consulta confirmada com sucesso |
| Caso de Teste 	| CT-08 – Cancelar consultas do paciente.		|
|Requisito Associado | RF-008	-A aplicação deverá permitir que o paciente gerencie suas consultas. |
| Objetivo do Teste 	| Verificar se o usuário médico é capaz de visualizar as proximas consultas agendadas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  https://priorizandosaude.github.com<br> - Clicar no botão "Paciente" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em minhas consultas no canto superior direito da tela <br> Clicar em cancelar |
|Critério de Êxito | - Consulta cancelada com sucesso|
| Caso de Teste 	| CT-09 – Confirmar consultas médico.		|
|Requisito Associado | RF-006	-A aplicação deverá permitir que o médico gerencie suas consultas. |
| Objetivo do Teste 	| Verificar se o usuário médico é capaz de visualizar as proximas consultas agendadas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  https://priorizandosaude.github.com<br> - Clicar no botão "Medico" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em minhas consultas no canto superior direito da tela <br> Clicar em cancelar |
|Critério de Êxito | - Consulta Confimada com sucesso|
| Caso de Teste 	| CT-10 – Cancelar consultas do médico.		|
|Requisito Associado | RF-006	-A aplicação deverá permitir que o médico gerencie suas consultas. |
| Objetivo do Teste 	| Verificar se o usuário médico é capaz de visualizar as proximas consultas agendadas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  https://priorizandosaude.github.com<br> - Clicar no botão "Médico" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em minhas consultas no canto superior direito da tela <br> Clicar em cancelar |
|Critério de Êxito | - Consulta cancelada com sucesso|
| Caso de Teste 	| CT-11 – Renderizar consultas com dados do médico agendado.		|
|Requisito Associado | RF-009	- A aplicação deverá permitir que o usuario tenha as infomações de contato do médico. |
| Objetivo do Teste 	| Verificar se o usuário médico é capaz de visualizar as proximas consultas agendadas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site  https://priorizandosaude.github.com<br> - Clicar no botão "Paciente" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em minhas consultas no canto superior direito da tela |
|Critério de Êxito | - Renderizar consulta com dados do médico agendado |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
