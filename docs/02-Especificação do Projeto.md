# Especificações do Projeto

Este projeto foi elaborado pela equipe após a detecção da necessidade de alguns possíveis usuários. O grupo realizou pesquisas e observação de pessoas, suas rotinas diárias e suas necessidades para sugestão de como melhor atendê-los. Com isso, foram estabelecidas as personas, as histórias e os requisitos do projeto, conforme detalhado a seguir. 

## Personas

Personas são personagens que representam os usuários típicos de um produto ou serviço. Eles geralmente são criados com base em dados coletados em pesquisas ou entrevistas com os potenciais usuários reais do produto ou serviço. As informações utilizadas incluem dados demográficos (idade, sexo, educação e renda) e psicográficos (traços de personalidade, valores, interesses e padrões de comportamento). 

O objetivo é entender as necessidades e preferências de cada tipo de usuário e assim, criar soluções personalizadas que atendam às suas demandas.  No contexto de streaming, as personas são uma ferramenta importante para identificar padrões de consumo e desenvolver estratégias de comunicação mais eficazes para atender as expectativas dos consumidores. Para este trabalho, foram criadas personas ficcionais, ou seja, criadas com base na experiência dos membros do grupo, sem que houvesse coleta de dados. 



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

|ID |Descrição do Requisito |Prioridade |
|:---:|---|---|
|RF_001| A aplicação web deve permitir ao usuário inserir detalhes de suas transações financeiras (descrição, data, categoria, valor e método de pagamento).| ALTA |
|RF_002| A aplicação deve permitir ao usuário inserir seus gastos recorrentes que serão lançados automaticamente de forma mensal.  | ALTA |
|RF_003| A aplicação web deve ser capaz de mostrar ao usuário um resumo do saldo atual de suas contas, bem como uma visão geral das despesas e receitas.| ALTA |
|RF_004| O aplicativo web deve oferecer ao usuário um modo de configurar alertas e notificações para serem lembrados de datas de vencimento de contas, metas atingidas ou gastos excessivos.| ALTA |
|RF_005| O aplicativo web deve ter capacidade de exportar dados financeiros em formatos de planilhas ou PDF's, para uso externo.| MÉDIA |
|RF_006| O aplicativo deve disponibilizar suporte ao cliente para auxiliar os usuários em caso de problemas técnicos ou dúvidas sobre o uso do aplicativo.| MÉDIA |
|RF_007| O aplicativo deve permitir que os usuários estabeleçam um orçamento mensal para diferentes categorias de despesas.| MÉDIA |
|RF_008| A aplicação deve oferecer sistema de credenciais do usuário com login e senha.| ALTA |
|RF_009| A aplicação deve oferecer a conversão do dólar e euro.| BAIXA |
|RF_010| A aplicação deve oferecer recomendações semanais de educação financeira.| BAIXA |
|RF_011| A aplicação deve oferecer, no primeiro acesso do usuário, um tutorial explicativo de seu uso.| BAIXA |

### Requisitos não Funcionais

|ID |Descrição do Requisito |Prioridade |
|:---:|---|---|
|RNF_001| O site deverá ser responsivo permitindo a visualização em um dispositivo móvel.   | ALTA | 
|RNF_002| A aplicação deve ser publicada em ambiente acessível na internet (Github). |  ALTA |
|RNF_003| A aplicação deve ser fácil de usar e navegar, com interfaces claras e intuitivas. | ALTA | 
|RNF_004|O site deve ser compatível com os principais navegadores do mercado - Firefox, Chrome e Edge | ALTA | 
|RNF_005| A senha do usuário deverá ter, no mínimo, oito caracteres com símbolo, número e letra maiúscula. |  ALTA | 
|RNF_006| A aplicação deverá ser hospedada no servidor Microsoft Azure. |  ALTA | 
|RNF_007| O aplicativo deve ser elaborado com as tecnologias C#, sqlserver, Microsoft Azure |  ALTA | 

## Regras de Negócio

São as regras do negócio.

|ID| Regras                                             |
|---|---|
|01|Quando as saídas mensais cadastradas pelo usuário se aproximarem ou excederem do limite por ele definido, a aplicação apresentará uma notificação de alerta na tela..
|02| Não haverá limite de quantidade para o lançamento de despesas.       |
|03| A aplicação não se responsabiliza pela origem e/ou veracidade das informações cadastradas pelo usuário. |
|04| A aplicação permitirá o cadastro de até três metas por usuário. |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|---|---|
|01|O projeto deve ser entregue no final do semestre no dia 06 de dezembro de 2023.
|02| O projeto deve ser elaborado apenas pelos membros do grupo       |
|03| A aplicação deve ser fácil de manter e atualizar, com código limpo e documentado para que os desenvolvedores possam entender e modificar facilmente o sistema. |
|04| Toda comunicação inerente à aplicação será realizada com o uso de metodologia ágil. |



## Diagrama de Casos de Uso

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/5957a648-f36a-45d0-a5e5-1373e022c7ed)

