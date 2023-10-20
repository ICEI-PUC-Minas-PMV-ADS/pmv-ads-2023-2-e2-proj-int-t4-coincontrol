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
|Resultado obtido | Observa-se o botão de login na página principal, que direciona para a página de criação do usuário. É possível concluir o login e visualizá-lo no banco de dados. A estética do botão de "Login" na página principal pode ser melhorada. |
|Avaliação | Nível 1 |
|Evidência | <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/blob/69c4b364f54e5cf78fba155dc0ec2e1496b65aaf/docs/img/TesteBemvindo.png" width="278"/> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/blob/69c4b364f54e5cf78fba155dc0ec2e1496b65aaf/docs/img/TesteCriacaoPerfil.png" width="278"/> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/blob/69c4b364f54e5cf78fba155dc0ec2e1496b65aaf/docs/img/TesteMensObrigatCriarUsu.png" width="278"/> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-coincontrol/blob/69c4b364f54e5cf78fba155dc0ec2e1496b65aaf/docs/img/TesteUsuarioNoBD.png" width="278"/> |

| **Caso de Teste** | **CT-02 - Efetuar login** |
|---|---|
|Requisito Associado | RF_008	- A aplicação deve possuir opção de fazer login caso o usuário já tenha cadastro. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
|Resultado esperado | O login é realizado com sucesso. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-03 – Inserir transações**	|
|---|---|
|Requisito Associado | RF_001	- A aplicação web deve permitir ao usuário inserir detalhes de suas transações financeiras (descrição, data, categoria, valor e método de pagamento). |
| Objetivo do Teste 	| Verificar se o usuário consegue inserir uma transação financeira completa. |
| Resultado esperado | Consegue-se realizar a inserção da transação com todos os detalhamentos. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-04 – Inserir gastos recorrentes**	|
|---|---|
|Requisito Associado | RF_002	- A aplicação deve permitir ao usuário inserir seus gastos recorrentes que serão lançados automaticamente de forma mensal. |
| Objetivo do Teste 	| Verificar se o usuário consegue inserir gastos recorrentes. |
|Resultado esperado | Usuário consegue inserir gastos recorrentes. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-05 – Visualizar saldo atual detalhado**	|
|---|---|
|Requisito Associado | RF_003	- A aplicação web deve ser capaz de mostrar ao usuário um resumo do saldo atual de suas contas, bem como uma visão geral das despesas e receitas. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar um resumo do seu saldo atual. |
|Resultado esperado | Usuário consegue visualizar seu saldo, com despesas e receitas. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-06 – Configurar alertas e notificações**	|
|---|---|
|Requisito Associado | RF_004	- O aplicativo web deve oferecer ao usuário um modo de configurar alertas e notificações para ser lembrado de datas de vencimento de contas, metas atingidas ou saldo negativo. |
| Objetivo do Teste 	| Verificar se a aplicação emite alertas em datas de vencimento de contas, metas atingidas ou saldo negativo. |
|Resultado esperado | A aplicação emite os alertas e notificações cadastrados. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-07 – Exportar dados em arquivo**	|
|---|---|
|Requisito Associado | RF_005	- O aplicativo web deve ter capacidade de exportar dados financeiros em formatos de planilhas ou PDF's, para uso externo. |
| Objetivo do Teste 	| Verificar se a aplicação exporta os dados em planilha ou arquivo PDF. |
|Resultado esperado | A aplicação exporta dados em arquivos. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-08 – Relatar problemas ou sugestões**	|
|---|---|
|Requisito Associado | RF_006	- O aplicativo deve oferecer suporte ao cliente para auxiliar os usuários em caso de problemas técnicos ou dúvidas sobre o uso deste. |
| Objetivo do Teste 	| Verificar se o sistema permite que o usuário obtenha suporte em caso de problemas técnicos ou dúvidas. |
|Resultado esperado | A aplicação fornece local de suporte em caso de problemas técnicos ou dúvidas. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-09 – Orçamento por categorias de despesas**	|
|---|---|
|Requisito Associado | RF_007	- O aplicativo deve permitir que os usuários estabeleçam um orçamento mensal para diferentes categorias de despesas. |
| Objetivo do Teste 	| Checar se a aplicação permite ao usuário estabelecer um orçamento mensal para diferentes categorias de despesas. |
|Resultado esperado | A aplicação permite o estabelecimento de orçamento mensal para categorias de despesas. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-10 – Conversão de moeda**	|
|---|---|
|Requisito Associado | RF_009	- A aplicação deve oferecer a conversão para dólar e euro. |
| Objetivo do Teste 	| Verificar se a aplicação converte os valores do usuário para dólar e euro. |
|Resultado esperado | A aplicação converte valores para dólar e euro. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-11 – Recomendações de educação financeira**	|
|---|---|
|Requisito Associado | RF_010	- A aplicação deve oferecer recomendações semanais de educação financeira. |
| Objetivo do Teste 	| Verificar se a aplicação oferece recomendações semanais de educação financeira. |
|Resultado esperado | A aplicação apresenta as recomendações semanais. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-12 – Tutorial explicativo**	|
|---|---|
|Requisito Associado | RF_011	- A aplicação deve oferecer, no primeiro acesso do usuário, um tutorial explicativo de seu uso. |
| Objetivo do Teste 	| Checar se a aplicação oferece, no primeiro acesso, um tutorial explicativo sobre seu uso. |
|Resultado esperado | A aplicação oferece o tutorial explicativo no primeiro acesso do usuário. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-13 – Responsividade**	|
|---|---|
|Requisito Associado | RNF_001	- O site deverá ser responsivo permitindo a visualização em um dispositivo móvel. |
| Objetivo do Teste 	| Testar se o site está responsivo para acesso em computador e dispositivo móvel. |
|Resultado esperado | A aplicação possui responsividade adequada para acesso em computador e dispositivo móvel.|
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-14 – Publicação do site**	|
|---|---|
|Requisito Associado | RNF_002	- A aplicação deve ser publicada em ambiente acessível na internet (Github). |
| Objetivo do Teste 	| Checar o local de publicação do site. |
|Resultado esperado | O site está publicado em ambiente acessível na internet (Github).|
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-15 – Usabilidade do site**	|
|---|---|
|Requisito Associado | RNF_003	- A aplicação deve ser fácil de usar e navegar, com interfaces claras e intuitivas. |
| Objetivo do Teste 	| Testar se a aplicação está fácil de usar, com interfaces claras e intuitivas. |
|Resultado esperado | O site se mostra com boa usabilidade.|
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-16 – Compatibilidade do site com navegadores**	|
|---|---|
|Requisito Associado | RNF_004	- O site deve ser compatível com os principais navegadores do mercado (Firefox, Chrome e Edge). |
| Objetivo do Teste 	| Verificar se o site está compatível para ser acessado pelos principais navegadores do mercado (Firefox, Chrome e Edge). |
|Resultado esperado | O site se apresenta compatível com os principais navegadores do mercado (Firefox, Chrome e Edge).|
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-17 – Critérios para a senha**	|
|---|---|
|Requisito Associado | RNF_005	- A senha do usuário deverá ter, no mínimo, oito caracteres com símbolo, número e letra maiúscula. |
| Objetivo do Teste 	| Verificar se o site exige que a senha do usuário tenha, no mínimo, oito caracteres com símbolo, número e letra maiúscula. |
|Resultado esperado | O site exige que a senha do usuário tenha, no mínimo, oito caracteres com símbolo, número e letra maiúscula.|
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-18 – Hospedagem do site**	|
|---|---|
|Requisito Associado | RNF_006	- A aplicação deverá ser hospedada no servidor Microsoft Azure. |
| Objetivo do Teste 	| Conferir se o site foi hospedado no servidor Microsoft Azure. |
|Resultado esperado | O site está hospedado no servidor Microsoft Azure.|
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-19 – Tecnologias na construção do site**	|
|---|---|
|Requisito Associado | RNF_007	- O aplicativo deve ser elaborado com as tecnologias C#, sqlserver, Microsoft Azure. |
| Objetivo do Teste 	| Verificar se o aplicativo foi elaborado com as tecnologias C#, sqlserver, Microsoft Azure. |
|Resultado esperado | O site possui tecnologias C#, sqlserver, Microsoft Azure.|
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-20 – Limite para lançamento de despesas**	|
|---|---|
|Regra associada | Regra 02	- Não haverá limite de quantidade para o lançamento de despesas. |
| Objetivo do Teste 	| Verificar se o aplicativo não está limitando a quantidade de lançamento de despesas. |
|Resultado esperado | O site não limita o lançamento das despesas. |
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |

| **Caso de Teste** 	| **CT-21 – Quantidade de metas**	|
|---|---|
|Regra associada | Regra 04	- A aplicação permitirá o cadastro de até três metas por usuário. |
| Objetivo do Teste 	| Verificar se o site limita a quantidade de metas em até três por usuário. |
|Resultado esperado | O site limita a quantidade de metas em até três por usuário. | 
|Resultado obtido | ********* |
|Avaliação | ********* |
|Evidência | ********* |



<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

## Avaliação

Discorra sobre os resultados do teste. Ressaltando pontos fortes e fracos identificados na solução. Comente como o grupo pretende atacar esses pontos nas próximas iterações. Apresente as falhas detectadas e as melhorias geradas a partir dos resultados obtidos nos testes.

> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
