# Registro de Testes de Software

De acordo com os requisitos estabelecidos pela equipe para o desenvolvimento da aplicação CoinControl, foram feitos testes de software, conforme os casos de teste e a escala apresentados a seguir.

**ESCALA UTILIZADA NOS TESTES DE SOFTWARE:**

| **NÍVEL DA ESCALA**| **CONCLUSÃO** | 
|---|---|
| Nível 0	| Está adequado com relação à usabilidade. |
| Nível 1	| Problema estético que não tem necessidade que ser corrigido, a menos que haja tempo e recurso disponível. |
| Nível 2	| Problema pequeno, com baixa prioridade na correção. |
| Nível 3	| Problema grande, com alta prioridade de correção. |
| Nível 4	| Catástrofe de usabilidade. O produto só será liberado se a correção for realizada. |


**REGISTROS DE TESTES DE SOFTWARE:**
 
| **Caso de Teste** | **CT-01 - Cadastrar perfil** |
|---|---|
|	Requisito Associado 	| RF_008 - A aplicação deve oferecer sistema de credenciais do usuário com login e senha. |
| Objetivo do Teste 	| Verificar se o usuário consegue criar seu cadastro na aplicação. |
|Resultado esperado | O cadastro é realizado com sucesso. |
|Resultado obtido | Observa-se o botão de login na página principal, que direciona para a página de criação do usuário. É possível concluir o login e visualizá-lo no banco de dados. A estética do botão de "Login" na página principal pode ser melhorada. Verifica-se que os usuários criados já podem ser vistos no banco de dados criado. |
|Avaliação | Nível 1 |
|Evidência |<img src="https://github-production-user-asset-6210df.s3.amazonaws.com/127675409/277198616-06ad58bb-9177-4c2c-afbe-8f6a51d48a06.png" width="300"/> <img src="https://github-production-user-asset-6210df.s3.amazonaws.com/127675409/277198884-11bb85c4-e518-4c61-959b-da9caa02dea1.png" width="300"/> <img src="https://github-production-user-asset-6210df.s3.amazonaws.com/127675409/277198942-33c3222d-7965-4e9f-a8a8-86071cdfbc5c.png" width="300"/> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/blob/69c4b364f54e5cf78fba155dc0ec2e1496b65aaf/docs/img/TesteUsuarioNoBD.png" width="300"/> |

| **Caso de Teste** | **CT-02 - Efetuar login** |
|---|---|
|Requisito Associado | RF_008	- A aplicação deve possuir opção de fazer login caso o usuário já tenha cadastro. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
|Resultado esperado | O login é realizado com sucesso. |
|Resultado obtido | Observa-se que melhoras estéticas deverão ser incrementadas após o login, a confirmação do usuário estar logado é cortada da barra de navegação. |
|Avaliação | Nível 3 |
|Evidência |<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/7fa0f0de-354d-4cc3-8c3c-ed72f286fda0" width="300"/> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/4204c3bf-1557-4f26-8e88-45f0acc839d4" width="300"/> |

| **Caso de Teste V2** | **CT-02 - Efetuar login** |
|---|---|
|Requisito Associado | RF_008	- A aplicação deve possuir opção de fazer login caso o usuário já tenha cadastro. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
|Resultado esperado | O login é realizado com sucesso. |
|Resultado obtido | Com realização de edições no código, o problema retratado na primeira versão desse teste foi solucionado. |
|Avaliação | Nível 0 |
|Evidência |<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/908bc824-a271-45e6-aa6e-e9d282fa25cc" width="300"/> |

| **Caso de Teste** 	| **CT-03 – Critérios para a senha**	|
|---|---|
|Requisito Associado | RNF_005	- A senha do usuário deverá ter, no mínimo, oito caracteres com símbolo, número e letra maiúscula. |
| Objetivo do Teste 	| Verificar se o site exige que a senha do usuário tenha, no mínimo, oito caracteres com símbolo, número e letra maiúscula. |
|Resultado esperado | O site exige que a senha do usuário tenha, no mínimo, oito caracteres com símbolo, número e letra maiúscula.|
|Resultado obtido | O site não exigiu que a senha obedeça às regras estabelecidas. Problemas estéticos que devem ser ajustados também ocorrem. |
|Avaliação | Nível 3 |
|Evidência | <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/7fa0f0de-354d-4cc3-8c3c-ed72f286fda0" width="300"/> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/4204c3bf-1557-4f26-8e88-45f0acc839d4" width="300"/> |

| **Caso de Teste V2** | **CT-03 - Critérios para a senha** |
|---|---|
|Requisito Associado | RNF_005	- A senha do usuário deverá ter, no mínimo, oito caracteres com símbolo, número e letra maiúscula. |
| Objetivo do Teste 	| Verificar se o site exige que a senha do usuário tenha, no mínimo, oito caracteres com símbolo, número e letra maiúscula. |
|Resultado esperado | O site exige que a senha do usuário tenha, no mínimo, oito caracteres com símbolo, número e letra maiúscula. |
|Resultado obtido | Com realização de edições no código, o problema retratado na primeira versão desse teste foi solucionado. |
|Avaliação | Nível 0 |
|Evidência |<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/a0f1d8ec-4576-447a-90ad-45cfb11e0ad8" width="300"/> |


| **Caso de Teste** 	| **CT-04 – Inserir transações**	|
|---|---|
|Requisito Associado | RF_001	- A aplicação web deve permitir ao usuário inserir detalhes de suas transações financeiras (descrição, data, categoria, valor e método de pagamento). |
| Objetivo do Teste 	| Verificar se o usuário consegue inserir uma transação financeira completa. |
| Resultado esperado | Consegue-se realizar a inserção da transação com todos os detalhamentos. |
|Resultado obtido | A aplicação permite que o usuário registre suas transações. |
|Avaliação | Nível 0 |
|Evidência | <img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/3ea33929-7fe5-4aa3-8c4c-2041abf4e315" width="300"/>|

| **Caso de Teste** 	| **CT-05 – Inserir gastos recorrentes**	|
|---|---|
|Requisito Associado | RF_002	- A aplicação deve permitir ao usuário inserir seus gastos recorrentes que serão lançados automaticamente de forma mensal. |
| Objetivo do Teste 	| Verificar se o usuário consegue inserir gastos recorrentes. |
|Resultado esperado | Usuário consegue inserir gastos recorrentes. |
|Resultado obtido | Foi possível, através do uso de categorias, criar os gastos recorrentes dos usuários. |
|Avaliação | Nível O |
|Evidência | <img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/fc44cc71-bd99-4bec-8e85-5e5ddadc25dd" width="300"/> |

| **Caso de Teste** 	| **CT-06 – Visualizar saldo atual detalhado**	|
|---|---|
|Requisito Associado | RF_003	- A aplicação web deve ser capaz de mostrar ao usuário um resumo do saldo atual de suas contas, bem como uma visão geral das despesas e receitas. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar um resumo do seu saldo atual. |
|Resultado esperado | Usuário consegue visualizar seu saldo, com despesas e receitas. |
|Resultado obtido | A aplicação garante ao usuário visualizar o resumo geral de seu saldo |
|Avaliação | Nível 0 |
|Evidência | <img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/613458a8-8d6b-48c4-b6ad-f2cd72caaed0" width="300"/> |

| **Caso de Teste** 	| **CT-07 – Configurar alertas e notificações**	|
|---|---|
|Requisito Associado | RF_004	- O aplicativo web deve oferecer ao usuário um modo de configurar alertas e notificações para ser lembrado de datas de vencimento de contas, metas atingidas ou saldo negativo. |
| Objetivo do Teste 	| Verificar se a aplicação emite alertas em datas de vencimento de contas, metas atingidas ou saldo negativo. |
|Resultado esperado | A aplicação emite os alertas e notificações cadastrados. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-08 – Exportar dados em arquivo**	|
|---|---|
|Requisito Associado | RF_005	- O aplicativo web deve ter capacidade de exportar dados financeiros em formatos de planilhas ou PDF's, para uso externo. |
| Objetivo do Teste 	| Verificar se a aplicação exporta os dados em planilha ou arquivo PDF. |
|Resultado esperado | A aplicação exporta dados em arquivos. |
|Resultado obtido | É possível realizar a exportação dos dados em PDF. |
|Avaliação | Nível 0 |
|Evidência | <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/59593ddf-7c1a-4b86-af41-7c0cda4bf517" width="300"/> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/ac42ceb3-2463-4f7b-a1ee-2156bb51321c" width="300"/> |

| **Caso de Teste** 	| **CT-09 – Relatar problemas ou sugestões**	|
|---|---|
|Requisito Associado | RF_006	- O aplicativo deve oferecer suporte ao cliente para auxiliar os usuários em caso de problemas técnicos ou dúvidas sobre o uso deste. |
| Objetivo do Teste 	| Verificar se o sistema permite que o usuário obtenha suporte em caso de problemas técnicos ou dúvidas. |
|Resultado esperado | A aplicação fornece local de suporte em caso de problemas técnicos ou dúvidas. |
|Resultado obtido | Na sessão de Q/A da aplicação é fornecido um endereço de e-mail para que os usuários entrem em contato. |
|Avaliação | Nível 0 |
|Evidência | <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/8bd3463b-2061-4e59-b85c-53cf7265cd22" width="300"/> |

| **Caso de Teste** 	| **CT-10 – Orçamento por categorias de despesas**	|
|---|---|
|Requisito Associado | RF_007	- O aplicativo deve permitir que os usuários estabeleçam um orçamento mensal para diferentes categorias de despesas. |
| Objetivo do Teste 	| Checar se a aplicação permite ao usuário estabelecer um orçamento mensal para diferentes categorias de despesas. |
|Resultado esperado | A aplicação permite o estabelecimento de orçamento mensal para categorias de despesas. |
|Resultado obtido |Utilizando a funcionalidade de metas, o usuário pode buscar definir orçamentos mensais para categorias.|
|Avaliação | Nível 0 |
|Evidência | <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/57138380-ec7d-4cf0-be34-b05071c4a02f" width="300"/> |

| **Caso de Teste** 	| **CT-11 – Conversão de moeda**	|
|---|---|
|Requisito Associado | RF_009	- A aplicação deve oferecer a conversão para dólar e euro. |
| Objetivo do Teste 	| Verificar se a aplicação converte os valores do usuário para dólar e euro. |
|Resultado esperado | A aplicação converte valores para dólar e euro. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-12 – Recomendações de educação financeira**	|
|---|---|
|Requisito Associado | RF_010	- A aplicação deve oferecer recomendações semanais de educação financeira. |
| Objetivo do Teste 	| Verificar se a aplicação oferece recomendações semanais de educação financeira. |
|Resultado esperado | A aplicação apresenta as recomendações semanais. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-13 – Tutorial explicativo**	|
|---|---|
|Requisito Associado | RF_011	- A aplicação deve oferecer, no primeiro acesso do usuário, um tutorial explicativo de seu uso. |
| Objetivo do Teste 	| Checar se a aplicação oferece, no primeiro acesso, um tutorial explicativo sobre seu uso. |
|Resultado esperado | A aplicação oferece o tutorial explicativo no primeiro acesso do usuário. |
|Resultado obtido | A aplicação fornece, em todos os momentos, uma sessão de Q/A para que o usuário maneje o aplicativo. |
|Avaliação | Nível zero |
|Evidência | <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/70d652cc-17fb-4bc3-b043-48956c558a75" width="300"/> |

| **Caso de Teste** 	| **CT-14 – Responsividade**	|
|---|---|
|Requisito Associado | RNF_001	- O site deverá ser responsivo permitindo a visualização em um dispositivo móvel. |
| Objetivo do Teste 	| Testar se o site está responsivo para acesso em computador e dispositivo móvel. |
|Resultado esperado | A aplicação possui responsividade adequada para acesso em computador e dispositivo móvel.|
|Resultado obtido |Observa-se que não a barra de rolagem horizontal para visualizar a tabela completa |
|Avaliação | 3 |
|Evidência | <img src="https://github-production-user-asset-6210df.s3.amazonaws.com/127675409/277199072-2ae0c075-7955-4a2b-a45a-d6311548fdaf.png" width="300"/>

| **Caso de Teste V2** | **CT-14 - Responsividade** |
|---|---|
|Requisito Associado | RNF_001	- O site deverá ser responsivo permitindo a visualização em um dispositivo móvel. |
| Objetivo do Teste 	| Testar se o site está responsivo para acesso em computador e dispositivo móvel. |
|Resultado esperado | A aplicação possui responsividade adequada para acesso em computador e dispositivo móvel. |
|Resultado obtido | Com realização de edições no código, o problema retratado na primeira versão desse teste foi solucionado. |
|Avaliação | Nível 0 |
|Evidência |<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/29abbc7c-0cf7-48e5-8e98-18a76b467e76" width="300"/> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/62ab07d0-7f62-4d7d-9a60-513dcabd3177" width="300"/> |

| **Caso de Teste** 	| **CT-15 – Publicação do site**	|
|---|---|
|Requisito Associado | RNF_002	- A aplicação deve ser publicada em ambiente acessível na internet. |
| Objetivo do Teste 	| Checar o local de publicação do site. |
|Resultado esperado | O site está publicado em ambiente acessível na internet.|
|Resultado obtido | O objetivo foi concluído. A aplicação está hospedada na internet pelo sistema de nuvem da Microsoft. |
|Avaliação | Nível 0 |
|Evidência | <img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/3af3fa1e-42a6-4a86-b4e0-f465aa4e5843" width="300"/> |

| **Caso de Teste** 	| **CT-16 – Usabilidade do site**	|
|---|---|
|Requisito Associado | RNF_003	- A aplicação deve ser fácil de usar e navegar, com interfaces claras e intuitivas. |
| Objetivo do Teste 	| Testar se a aplicação está fácil de usar, com interfaces claras e intuitivas. |
|Resultado esperado | O site se mostra com boa usabilidade.|
|Resultado obtido | Nos testes realizados, a aplicação se mostra com boa usabilidades. Suas interfaces são claras e intuitivas para os usuários. |
|Avaliação | Nível 0 |
|Evidência | <img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/9765e88b-07a3-4297-9f2e-617094354966" width="300"/> |

| **Caso de Teste** 	| **CT-17 – Compatibilidade do site com navegadores**	|
|---|---|
|Requisito Associado | RNF_004	- O site deve ser compatível com os principais navegadores do mercado (Firefox, Chrome e Edge). |
| Objetivo do Teste 	| Verificar se o site está compatível para ser acessado pelos principais navegadores do mercado (Firefox, Chrome e Edge). |
|Resultado esperado | O site se apresenta compatível com os principais navegadores do mercado (Firefox, Chrome e Edge).|
|Resultado obtido | A aplicação é compatível nos navegadores listados |
|Avaliação | Nível 0 |
|Evidência | <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/9fd987e7-22c6-4f5a-b17d-84d258e04393" width="300"/> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/fee0d05c-079f-45e9-94ec-006ead8481a2" width="300"/>  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/0f105158-ce00-4897-b3c9-0de86bb1e2c7" width="300"/> |


| **Caso de Teste** 	| **CT-18 – Hospedagem do site**	|
|---|---|
|Requisito Associado | RNF_006	- A aplicação deverá ser hospedada no servidor Microsoft Azure. |
| Objetivo do Teste 	| Conferir se o site foi hospedado no servidor Microsoft Azure. |
|Resultado esperado | O site está hospedado no servidor Microsoft Azure.|
|Resultado obtido | Site hospedado no Azure |
|Avaliação | Nível 0 |
|Evidência | <img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/3af3fa1e-42a6-4a86-b4e0-f465aa4e5843" width="300"/> |

| **Caso de Teste** 	| **CT-19 – Tecnologias na construção do site**	|
|---|---|
|Requisito Associado | RNF_007	- O aplicativo deve ser elaborado com as tecnologias C#, sqlserver, Microsoft Azure. |
| Objetivo do Teste 	| Verificar se o aplicativo foi elaborado com as tecnologias C#, sqlserver, Microsoft Azure. |
|Resultado esperado | O site possui tecnologias C#, sqlserver, Microsoft Azure.|
|Resultado obtido | A aplicação foi construída com as tecnologias planejadas. |
|Avaliação | Nível 0. |
|Evidência | [Código Fonte de toda aplicação desenvolvida](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/tree/main/src/coincontrol) |

| **Caso de Teste** 	| **CT-20 – Limite para lançamento de despesas**	|
|---|---|
|Regra associada | Regra 02	- Não haverá limite de quantidade para o lançamento de despesas. |
| Objetivo do Teste 	| Verificar se o aplicativo não está limitando a quantidade de lançamento de despesas. |
|Resultado esperado | O site não limita o lançamento das despesas. |
|Resultado obtido | O usuário pode lançar quantas despesas ele quiser. |
|Avaliação | Nível 0 |
|Evidência | <img src= "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/assets/100796561/3ea33929-7fe5-4aa3-8c4c-2041abf4e315" width="300"/> |

| **Caso de Teste** 	| **CT-21 – Quantidade de metas**	|
|---|---|
|Regra associada | Regra 04	- A aplicação permitirá o cadastro de até três metas por usuário. |
| Objetivo do Teste 	| Verificar se o site limita a quantidade de metas em até três por usuário. |
|Resultado esperado | O site limita a quantidade de metas em até três por usuário. | 
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |



## Avaliação

Observa-se que as funcionalidades do sistema que foram definidas com alta prioridade pela equipe de desenvolvimento já foram estabelecidas e encontram-se em funcionamento, os demais casos de testes não realizados estão ligados a requisitos de baixa prioridade e serão implementados na próxima fase.


