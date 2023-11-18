# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Por exemplo: a tabela a seguir deverá ser preenchida considerando os artefatos desenvolvidos.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| A aplicação web deve permitir ao usuário inserir detalhes de suas transações financeiras (descrição, data, categoria e valor). | TransactionController.cs / Transaction.cs / AddOrEdit.cshtml / Index.cshtml | 
|RF_002| A aplicação deve permitir ao usuário inserir seus gastos recorrentes que serão lançados automaticamente de forma mensal. | CategoryController.cs / Category.cs / AddOrEdit.cshtml / Index.cshtml | 
|RF_003| A aplicação web deve ser capaz de mostrar ao usuário um resumo do saldo atual de suas contas, bem como uma visão geral das despesas e receitas. | DashboardController.cs / Index.cshtml | 
|RF-007| O aplicativo deve permitir que os usuários estabeleçam um orçamento mensal para diferentes categorias de despesas. | MetaController.cs / Meta.cs / Index.cshtml / Create.cshtml / Delete.cshtml / Details.cshtml / Edit.cshtml  | 
|RF-008| A aplicação deve oferecer sistema de credenciais do usuário com login e senha. | UsuariosController.cs / Usuario.cs / Login.cshtml | 
|RNF_001| O site deverá ser responsivo permitindo a visualização em um dispositivo móvel. | [Código Fonte de toda aplicação desenvolvida](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/tree/main/src/coincontrol) | 
|RNF_002| A aplicação deve ser publicada em ambiente acessível na internet (Azure). | [Publicação](https://coincontrolpuc.azurewebsites.net/) | 
|RNF_003| A aplicação deve ser fácil de usar e navegar, com interfaces claras e intuitivas. | [Código Fonte de toda aplicação desenvolvida](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/tree/main/src/coincontrol) | 
|RNF_004| O site deve ser compatível com os principais navegadores do mercado - Firefox, Chrome e Edge | [Código Fonte de toda aplicação desenvolvida](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/tree/main/src/coincontrol) | 
|RNF_005| A senha do usuário deverá ter, no mínimo, oito caracteres com símbolo, número e letra maiúscula.	 |  Usuario.cs | 
|RNF_006| A aplicação deverá ser hospedada no servidor Microsoft Azure. | [Publicação](https://coincontrolpuc.azurewebsites.net/)  | 
|RNF_007	| O aplicativo deve ser elaborado com as tecnologias C#, sqlserver, Microsoft Azure.  | [Código Fonte de toda aplicação desenvolvida](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/tree/main/src/coincontrol) |

# Instruções de acesso

A aplicação poderá ser acessada no seguinte link:  https://coincontrolpuc.azurewebsites.net/

# Usuário teste

E-mail: testee@teste.com
Senha: Abcd123!
