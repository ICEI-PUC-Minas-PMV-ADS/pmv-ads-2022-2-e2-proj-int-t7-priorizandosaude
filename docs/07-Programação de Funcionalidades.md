# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

### Requisitos funcionais e seus artefatos desenvolvidos.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| A aplicação devera possuir uma lading page explicando detalhes sobre o serviço fornecido. | Index.cshtml / HomeController.cs |
|RF-002| A aplicação deve gerenciar médicos. Para um médico se cadastrar é necessário: CNPJ, NOME , E-MAIL, TELEFONE, SENHA, ESPECIALIDADE e ENDEREÇO | Create.cshtml / MedicosController.cs | 
|RF-003| A aplicação deve gerenciar pacientes. Para um paciente se cadastrar é necessário: CPF, NOME , E-MAIL, TELEFONE e SENHA. | Create.cshtml / PacientesController.cs |
|RF-004| A aplicação deve mostrar para o usuário todos as agendas cadastradas. | Index.cshtml | 
|RF-006| A aplicação deverá permitir que o médico gerencie sua agenda.  | Delete.cshtml / Details.cshtml / Edit.cshtml / ConsultasController.cs /  |
|RF-007| A aplicação deverá permitir que o médico tenha informações dos seus pacientes. | Baixa | 
|RF-008| A aplicação deverá permitir que o paciente gerencie suas consultas de acordo com a disponibilidade do médico. | Index.cshtml / Delete.cshtml / Details.cshtml / Edit.cshtml |
|RF-009| A aplicação deverá permitir que o usuario tenha as infomações de contato do médico. | ALTA | 
|RF-010| A aplicação deverá permitir que o usuario faça login. | Login.cshtml / MedicosController.cs / PacientesController.cs |
|RF-011| A aplicação deverá permitir que o usuario pesquise  a agenda cadastrada, pela data, especialidade e/ou nome. | Index.cshtml | 

# Instruções de acesso

1 - Link da aplicação na Azure: https://onmedical.azurewebsites.net/ <br>
2 - Se cadastrar
