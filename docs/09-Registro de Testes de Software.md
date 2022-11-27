# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Relatório com as evidências dos testes de software.

| Testes 	| CT-01 – Cadastrar paciente e CT-03 - Efetuar login Paciente |
|:---:	|:---:	|
|	Vídeo 	| <video src="https://user-images.githubusercontent.com/58198111/198903172-20200ed2-f415-474f-9197-aded270c39e4.mp4"> |
|  	|  	|
| Testes 	| CT-02 – Cadastrar médico e CT-04 – Efetuar login Médico	|
|	Vídeo 	| <video src="https://user-images.githubusercontent.com/58198111/198903239-785d28e0-bdd9-40cc-80cf-a8f18cec34e9.mp4"> |
|  	|  	|
| Testes 	| CT-05 – Mostrar médicos cadastrados	|
|	Vídeo 	| <video src="https://user-images.githubusercontent.com/58198111/204144175-ad5eef5a-d690-4209-99aa-d868adc887cf.mp4"> |
|  	|  	|
| Testes 	| CT-06 – Renderizar agenda do médico	|
|	Vídeo 	| <video src="https://user-images.githubusercontent.com/58198111/204144200-d7a6358f-4187-4c36-aee5-ae134523d069.mp4"> |
|  	|  	|
| Testes 	| CT-07 – Confirmar consultas do paciente	|
|	Vídeo 	| <video src="https://user-images.githubusercontent.com/58198111/204144260-757c914a-d078-43fc-9fc9-6ac33fa0e971.mp4"> |
|  	|  	|
| Testes 	| CT-08 – Cancelar consultas do paciente	|
|	Vídeo 	| <video src="https://user-images.githubusercontent.com/58198111/204149600-6c6a83e8-6f4a-488b-bceb-28bc4da805fa.mp4"> |
|  	|  	|
| Testes 	| CT-10 – Cancelar consultas do médico	|
|	Vídeo 	| <video src="https://user-images.githubusercontent.com/58198111/204149609-58576a78-7a6a-4b77-ad4c-1b04b6dec8fd.mp4"> |
  
  <h2>Relatório de Testes de Software</h2>
  
O objetivo deste relatório é analisar se a aplicação Priorizando a saúde atende aos requisitos previamente propostos e sugerir possíveis pontos de correção.

| 1 	| Cadastrar paciente 	|
|:---:	|:---:	|
|	Requisito	| RF-01 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de pacientes para que esses consigam criar e gerenciar seu perfil. |
| Observação | Na página inicial possui a funcionalidade cadastrar paciente, este que pode ser realizado ao clicar em "Paciente". Após o preenchimento das informações cadastrais (nome, senha, e-mail, telefone e cpf ) o cadastro é realizado com sucesso. Além disso, é possível fazer alterações posteriores a respeito dessas informações (por exemplo, a troca de e-mail e a alteração de número de telefone). Assim, a aplicação Priorizando a saúde atende ao requisito <b> Cadastrar paciente. |
|  	|  	|
| 2 	| Efetuar login do paciente |
|	Requisito	| RF-010 - A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Observação | Na página inicial, a aplicação apresenta a funcionalidade de login. este que pode ser realizado ao clicar em "Paciente". Após o preenchimento dos campos  e-mail e senha, o usuário é redirecionado para a tela principal. Assim, a aplicação Priorizando a saúde atende ao requisito <b> Efetuar login Paciente. |
|  	|  	|
| 3 	| Cadastrar Médico 	|
|	Requisito	| RF-002 - A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Observação | Na página inicial possui a funcionalidade cadastrar médico, este que pode ser realizado ao clicar em "Médico". Após o preenchimento das informações cadastrais (nome, especialidade, crm, endereço, e-mail, telefone e senha) o cadastro é realizado com sucesso. Além disso, é possível fazer alterações posteriores a respeito dessas informações (por exemplo, a troca de e-mail e a alteração de número de telefone). Assim, a aplicação Priorizando a saúde atende ao requisito <b> Cadastrar Médico. |
|  	|  	|
| 4 	| Efetuar login do Médico |
|	Requisito	| RF-010 - A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Observação | Na página inicial, a aplicação apresenta a funcionalidade de login. este que pode ser realizado ao clicar em "Médico". Após o preenchimento dos campos  e-mail e senha, o usuário é redirecionado para a tela principal. Assim, a aplicação Priorizando a saúde atende ao requisito <b> Efetuar login Médico. |
|  	|  	|
| 5 	| Mostrar médicos cadastrados |
|	Requisito	| RF-004 - A aplicação deve mostrar na tela home do paciente os medicos cadastrados quando preenchidos os campos de data e e especialidade. |
| Observação | Após realizar login como paciente, a aplicação apresenta os médicos cadastrados. Assim, a aplicação Priorizando a saúde atende ao requisito <b> Mostrar médicos cadastrados. |
|  	|  	|
| 6 	| Renderizar agenda do médico |
|	Requisito	| RF-005 - A aplicação deve ser capaz de mostrar as proximas consultas do médico. |
| Observação | Após realizar login como médico e clicar em minhas consultas no canto superior direito, é exibido a agenda. Assim, a aplicação Priorizando a saúde atende ao requisito <b> Renderizar agenda do médico. |
|  	|  	|
| 7 	| Confirmar consultas do paciente |
|	Requisito	| RF-008 -A aplicação deverá permitir que o paciente gerencie suas consultas |
| Observação | Após realizar login como paciente e clicar em minhas consultas, tera uma opção escrito delete. Assim, a aplicação Priorizando a saúde atende ao requisito <b> Confirmar consultas do paciente. |
|  	|  	|
| 8 	| Cancelar consultas do paciente |
|	Requisito	| RF-008 -A aplicação deverá permitir que o paciente gerencie suas consultas |
| Observação | Após realizar login como paciente e clicar em minhas consultas, tera uma opção escrito delete para cancelar. Assim, a aplicação Priorizando a saúde atende ao requisito <b> Cancelar consultas do paciente. |
|  	|  	|
| 10 	| Cancelar consultas do médico |
|	Requisito	| RF-006 -A aplicação deverá permitir que o médico gerencie suas consultas |
| Observação | Após realizar login como médico e clicar em minhas consultas, tera uma opção escrito delete para cancelar. Assim, a aplicação Priorizando a saúde atende ao requisito <b> Cancelar consultas do médico. |






