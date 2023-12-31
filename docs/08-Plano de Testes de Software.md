# Plano de Testes de Software

De acordo com os requisitos estabelecidos pela equipe para o desenvolvimento da aplicação CoinControl, está prevista a realização dos testes, conforme os casos de teste apresentados a seguir.
 
| **Caso de Teste** | **CT-01 - Cadastrar perfil** |
|---|---|
|	Requisito Associado 	| RF_008 - A aplicação deve oferecer sistema de credenciais do usuário com login e senha. |
| Objetivo do Teste 	| Verificar se o usuário consegue criar seu cadastro na aplicação. |
| Passos 	| Acessar o site da aplicação / Clicar em "Crie sua conta!" / Digitar o Nome, o Email e a Senha / Clicar em "Crie seu perfil"  |
|Critério de Êxito | O cadastro é realizado com sucesso. |

| **Caso de Teste** | **CT-02 - Efetuar login** |
|---|---|
|Requisito Associado | RF_008	- A aplicação deve possuir opção de fazer login caso o usuário já tenha cadastro. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| Acessar o site da aplicação / Clicar em "Login" / Digitar o Email e a Senha / Clicar em "Acessar" |
|Critério de Êxito | O login é realizado com sucesso. |

| **Caso de Teste** 	| **CT-03 – Critérios para a senha**	|
|---|---|
|Requisito Associado | RNF_005	- A senha do usuário deverá ter, no mínimo, oito caracteres com símbolo, número e letra maiúscula. |
| Objetivo do Teste 	| Verificar se o site exige que a senha do usuário tenha, no mínimo, oito caracteres com símbolo, número e letra maiúscula. |
| Passos 	| Acessar o site da aplicação / Clicar em "Crie sua conta!" / Digitar o Nome, o Email e a Senha - que não atenda os requisitos propostos / Clicar em "Crie seu perfil" / Observar a mensagem de erro por não atendimento aos requisitos de formato de senha / Realizar nova tentativa atendendo ao formato proposto para a senha |
|Critério de Êxito | O site exige que a senha do usuário tenha, no mínimo, oito caracteres com símbolo, número e letra maiúscula.|

| **Caso de Teste** 	| **CT-04 – Inserir transações**	|
|---|---|
|Requisito Associado | RF_001	- A aplicação web deve permitir ao usuário inserir detalhes de suas transações financeiras (descrição, data, categoria, valor e método de pagamento). |
| Objetivo do Teste 	| Verificar se o usuário consegue inserir uma transação financeira completa. |
| Passos 	| Acessar o site da aplicação / Clicar em "Transações" / Clicar em "+Nova Transação" / Inserir as informações solicitadas / Clicar em "Adicionar" |
|Critério de Êxito | Consegue-se realizar a inserção da transação com todos os detalhamentos. |

| **Caso de Teste** 	| **CT-05 – Inserir gastos recorrentes**	|
|---|---|
|Requisito Associado | RF_002	- A aplicação deve permitir ao usuário inserir seus gastos recorrentes que serão lançados automaticamente de forma mensal. |
| Objetivo do Teste 	| Verificar se o usuário consegue inserir gastos recorrentes. |
| Passos 	| Acessar o site da aplicação / Clicar em "Categorias" / Clicar em "+Nova Categoria" / Inserir as informações /  Realizar os lançamentos  |
|Critério de Êxito | Usuário consegue inserir gastos recorrentes. |

| **Caso de Teste** 	| **CT-06 – Visualizar saldo atual detalhado**	|
|---|---|
|Requisito Associado | RF_003	- A aplicação web deve ser capaz de mostrar ao usuário um resumo do saldo atual de suas contas, bem como uma visão geral das despesas e receitas. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar um resumo do seu saldo atual. |
| Passos 	| Acessar o site da aplicação / Visualizar o Dashboard |
|Critério de Êxito | Usuário consegue visualizar seu saldo, com despesas e receitas. |

| **Caso de Teste** 	| **CT-07 – Configurar alertas e notificações**	|
|---|---|
|Requisito Associado | RF_004	- O aplicativo web deve oferecer ao usuário um modo de configurar alertas e notificações para ser lembrado de datas de vencimento de contas, metas atingidas ou saldo negativo. |
| Objetivo do Teste 	| Verificar se a aplicação emite alertas em datas de vencimento de contas, metas atingidas ou saldo negativo. |
| Passos 	| Acessar o site da aplicação / Clicar em "Alertas" / Verificar se há o fornecimento de notificações para datas e eventos importantes definidos pelo usuário. |
|Critério de Êxito | A aplicação emite os alertas e notificações cadastrados. |

| **Caso de Teste** 	| **CT-08 – Exportar dados em arquivo**	|
|---|---|
|Requisito Associado | RF_005	- O aplicativo web deve ter capacidade de exportar dados financeiros em formatos de planilhas ou PDF's, para uso externo. |
| Objetivo do Teste 	| Verificar se a aplicação exporta os dados em planilha ou arquivo PDF. |
| Passos 	| Acessar o site da aplicação / Clicar em "Transações" / Clicar em "Imprimir" |
|Critério de Êxito | A aplicação exporta dados em arquivos. |

| **Caso de Teste** 	| **CT-09 – Relatar problemas ou sugestões**	|
|---|---|
|Requisito Associado | RF_006	- O aplicativo deve oferecer suporte ao cliente para auxiliar os usuários em caso de problemas técnicos ou dúvidas sobre o uso deste. |
| Objetivo do Teste 	| Verificar se o sistema permite que o usuário obtenha suporte em caso de problemas técnicos ou dúvidas. |
| Passos 	| Acessar o site da aplicação / Clicar em "Q&A" / Verificar o e-mail de suporte e entrar em contato|
|Critério de Êxito | A aplicação fornece local de suporte em caso de problemas técnicos ou dúvidas. |

| **Caso de Teste** 	| **CT-10 – Orçamento por categorias de despesas**	|
|---|---|
|Requisito Associado | RF_007	- O aplicativo deve permitir que os usuários estabeleçam um orçamento mensal para diferentes categorias de despesas. |
| Objetivo do Teste 	| Checar se a aplicação permite ao usuário estabelecer um orçamento mensal para diferentes categorias de despesas. |
| Passos 	| Acessar o site da aplicação / Clicar em "Categorias" / Clicar em "+Nova Transação" / Inserir as informações solicitadas / Clicar em "Adicionar" | |
|Critério de Êxito | A aplicação permite o estabelecimento de orçamento mensal para categorias de despesas. |

| **Caso de Teste** 	| **CT-11 – Conversão de moeda**	|
|---|---|
|Requisito Associado | RF_009	- A aplicação deve oferecer a conversão para dólar e euro. |
| Objetivo do Teste 	| Verificar se a aplicação converte os valores do usuário para dólar e euro. |
| Passos 	| Acessar o site da aplicação / Clicar em "Conversor de moeda" / Verificar se há a aplicação realiza conversão de valores para dólar e euro. |
|Critério de Êxito | A aplicação converte valores para dólar e euro. |

| **Caso de Teste** 	| **CT-12 – Recomendações de educação financeira**	|
|---|---|
|Requisito Associado | RF_010	- A aplicação deve oferecer recomendações semanais de educação financeira. |
| Objetivo do Teste 	| Verificar se a aplicação oferece recomendações semanais de educação financeira. |
| Passos 	| Acessar o site da aplicação / Clicar em "Recomendações Financeiras" / Verificar se há o fornecimento de dicas de finanças. |
|Critério de Êxito | A aplicação apresenta as recomendações semanais. |

| **Caso de Teste** 	| **CT-13 – Tutorial explicativo**	|
|---|---|
|Requisito Associado | RF_011	- A aplicação deve oferecer, no primeiro acesso do usuário, um tutorial explicativo de seu uso. |
| Objetivo do Teste 	| Checar se a aplicação oferece, no primeiro acesso, um tutorial explicativo sobre seu uso. |
| Passos 	| Acessar o site da aplicação / Clicar em "Q&A" / Verificar o tutorial da aplicação |
|Critério de Êxito | A aplicação oferece o tutorial explicativo no primeiro acesso do usuário. |

| **Caso de Teste** 	| **CT-14 – Responsividade**	|
|---|---|
|Requisito Associado | RNF_001	- O site deverá ser responsivo permitindo a visualização em um dispositivo móvel. |
| Objetivo do Teste 	| Testar se o site está responsivo para acesso em computador e dispositivo móvel. |
| Passos 	|Inserir a URL do site em verificadores de responsividade / Verificar se a aplicação está responsiva em dispositivo móvel. |
|Critério de Êxito | A aplicação possui responsividade adequada para acesso em computador e dispositivo móvel.|

| **Caso de Teste** 	| **CT-15 – Publicação do site**	|
|---|---|
|Requisito Associado | RNF_002	- A aplicação deve ser publicada em ambiente acessível na internet. |
| Objetivo do Teste 	| Checar o local de publicação do site. |
| Passos 	| Acessar o site / Verificar se a aplicação está publicada.  |
|Critério de Êxito | O site está publicado em ambiente acessível na internet.|

| **Caso de Teste** 	| **CT-16 – Usabilidade do site**	|
|---|---|
|Requisito Associado | RNF_003	- A aplicação deve ser fácil de usar e navegar, com interfaces claras e intuitivas. |
| Objetivo do Teste 	| Testar se a aplicação está fácil de usar, com interfaces claras e intuitivas. |
| Passos 	| Acessar o site / Verificar se a aplicação fornece interfaces claras e intuitivas.  |
|Critério de Êxito | O site se mostra com boa usabilidade.|

| **Caso de Teste** 	| **CT-17 – Compatibilidade do site com navegadores**	|
|---|---|
|Requisito Associado | RNF_004	- O site deve ser compatível com os principais navegadores do mercado (Firefox, Chrome e Edge). |
| Objetivo do Teste 	| Verificar se o site está compatível para ser acessado pelos principais navegadores do mercado (Firefox, Chrome e Edge). |
| Passos 	| Acessar o site nos principais navegadores do mercado / Verificar se a aplicação funciona neles. |
|Critério de Êxito | O site se apresenta compatível com os principais navegadores do mercado (Firefox, Chrome e Edge).|

| **Caso de Teste** 	| **CT-18 – Hospedagem do site**	|
|---|---|
|Requisito Associado | RNF_006	- A aplicação deverá ser hospedada no servidor Microsoft Azure. |
| Objetivo do Teste 	| Conferir se o site foi hospedado no servidor Microsoft Azure. |
| Passos 	| Acessar o site / Verificar se a hospedagem está dentro do Microsoft Azure. |
|Critério de Êxito | O site está hospedado no servidor Microsoft Azure.|

| **Caso de Teste** 	| **CT-19 – Tecnologias na construção do site**	|
|---|---|
|Requisito Associado | RNF_007	- O aplicativo deve ser elaborado com as tecnologias C#, sqlserver, Microsoft Azure. |
| Objetivo do Teste 	| Verificar se o aplicativo foi elaborado com as tecnologias C#, sqlserver, Microsoft Azure. |
| Passos 	| Acessar o código da aplicação no Github / Verificar se as tecnologias empregadas foram utilizadas na construção da aplicação |
|Critério de Êxito | O site possui tecnologias C#, sqlserver, Microsoft Azure.|

| **Caso de Teste** 	| **CT-20 – Limite para lançamento de despesas**	|
|---|---|
|Regra associada | Regra 02	- Não haverá limite de quantidade para o lançamento de despesas. |
| Objetivo do Teste 	| Verificar se o aplicativo não está limitando a quantidade de lançamento de despesas. |
| Passos 	| Acessar o site da aplicação / Clicar em "Transações" / Verificar se a aplicação limita o lançamento de transações. |
|Critério de Êxito | O site não limita o lançamento das despesas. |

| **Caso de Teste** 	| **CT-21 – Quantidade de metas**	|
|---|---|
|Regra associada | Regra 04	- A aplicação permitirá o cadastro de até três metas por usuário. |
| Objetivo do Teste 	| Verificar se o site limita a quantidade de metas em até três por usuário. |
| Passos 	| Acessar o site da aplicação / Clicar em "Metas" / Tentar cadastrar mais de três metas. |
|Critério de Êxito | O site limita a quantidade de metas em até três por usuário. |

