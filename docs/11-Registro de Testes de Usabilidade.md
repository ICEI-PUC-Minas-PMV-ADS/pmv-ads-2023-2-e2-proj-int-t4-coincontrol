# Registro de Testes de Usabilidade

<p>Conforme previsto no plano de testes, foram realizados testes estáticos e dinâmicos, apresentados a seguir.

## Testes de Usabilidade do tipo Estática
<p>Os Testes de Usabilidade, do tipo estática, foram feitos pela equipe de planejamento e desenvolvimento e foi elaborado o relatório apresentado abaixo, baseado nas 10 heurísticas de Nielsen para verificação de usabilidade de sistemas.
<p>A coluna avaliação foi preenchida conforme escala a seguir:

**ESCALA UTILIZADA NA AVALIAÇÃO DE USABILIDADE:**

| **NÍVEL DA ESCALA**| **CONCLUSÃO** | 
|---|---|
| Nível 0	| Está adequado com relação à usabilidade. |
| Nível 1	| Problema estético que não tem necessidade que ser corrigido, a menos que haja tempo e recurso disponível. |
| Nível 2	| Problema pequeno, com baixa prioridade na correção. |
| Nível 3	| Problema grande, com alta prioridade de correção. |
| Nível 4	| Catástrofe de usabilidade. O produto só será liberado se a correção for realizada. |

**REGISTROS DE TESTES DE USABILIDADE:**


| **1- VISIBILIDADE DO STATUS DO SISTEMA** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| As telas possuem títulos que descrevem seu conteúdo? |  0 | Existem cabeçalhos com os nomes.  |
| Os ícones selecionados se destacam dos não selecionados? | 1  |  Funcionalidade ainda não implementada. |
| O sistema apresenta em que tela o usuário se encontra e possibilidades de ação? |  0 |  Há títulos que indicam em qual localidade da aplicação o usuário se encontra. |

| **2- CORRESPONDÊNCIA ENTRE SISTEMA E MUNDO REAL** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| Os ícones são familiares e de fácil interpretação?  |  0 | Claros e objetivos.  |
| As cores correspondem aos códigos de cores comuns?  | 0  |  Claros e objetivos. |
| Os números possuem casas decimais separadas por vírgulas e uso de cifrão no caso de moeda? |  0 | As páginas criadas até o momento não apresentam números.  |

| **3- CONTROLE DO USUÁRIO E LIBERDADE** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| As opções de ações do usuário são facilmente visualizadas? |  0 |  Botões com bom tamanho de visualização. | 
| Existem funcionalidades para o usuário desfazer ações? | 2  |  Pode-se buscar a inclusão de funcionalidade "voltar" nas páginas até então criadas. Também pode-se inserir o botão de editar o cadastro de login, caso ele queira alterar e-mail ou senha. | 
| O usuário pode editar, copiar e colar durante a entrada de dados? | 0  | Ele tem essa liberdade.  |

| **4- CONSISTÊNCIA E PADRÕES** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| Os textos e ícones seguem padrões de formatação quanto ao alinhamento? | 0  | Padronizado.  | 
| As cores de fundo, textos e botões são padronizadas nas diferentes telas? | 0  |  Padronizado.  |  
| Os objetos são nomeados de forma padronizada em todo o sistema? | 0  | Padronizado.   | 
| Os campos obrigatórios são corretamente sinalizados?  | 0  | Caso o usuário não forneça algum dado obrigatório, há o fornecimento de mensagem de erro.  |

| **5- PREVENÇÃO DE ERROS** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| O usuário é solicitado a confirmar tarefas que possuem consequências drásticas? | 2  | Será implementado.  | 
| As opções dos menus são lógicas e distintas entre si?  | 0  |  Claras e objetivas. |  
| O sistema alerta o usuário quando ele vai realizar alguma ação crítica e/ou irreversível? | 3  |  Será implementado. |
| Quando existem padrões de formatação para as entradas, isso é sinalizado ao usuário? |  2 |  É informado em mensagem de erro na maioria dos casos. Mas é necessário ainda cadastrar o requisito de formatação da senha, bem como seu aviso de erro em caso de não atendimento à regra. |

| **6- RECONHECIMENTO EM VEZ DE MEMORIZAÇÃO** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| São observados rótulos dos ambientes onde o usuário se encontra? |  0 |  Os nomes são claros. | 
| Existem botões que levem às ações de visualização de histórico de movimentações? | 2  |  Funcionalidade que pode vir a ser implementada. |  
| A aplicação é nítida na diferenciação do estado logado do não logado?  | 0  |  Quando logado, o nome do usuário é destacado. | 
| Existem diferenças, mesmo que sutis, entre as telas onde o usuário pode navegar, de forma a diferenciá-las e identificá-las visualmente?  | 1  | Melhorias estéticas podem ser implementadas. |

| **7- FLEXIBILIDADE E EFICIÊNCIA DE USO** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| Exitem atalhos para as ações do usuário? | 0  | A aplicação possui botões que já levam o usuário, com um clique, à função desejada.  | 
| O usuário pode realizar as tarefas de diferentes maneiras, incluindo algumas mais simples? | 1  | Ainda não implementado. Baixa prioridade.  |  

| **8- ESTÉTICA E DESIGN MINIMALISTA** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| Somente informações necessárias são visíveis, evitando confusão? | 0  |  Feitas de forma clara e objetiva. | 
| Os ícones e botões possuem contraste em relação ao fundo? | 0  | Cores que se destacam.  |  
| Os rótulos e menus são breves e descritivos das ações que representam?  |  0 | Claras e objetivas.  | 

| **9- AJUDA AOS USUÁRIOS PARA RECONHECIMENTO, DIAGNÓSTICO E RECUPERAÇÃO DE ERROS** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| As mensagens de erro são próximas do campo onde o erro ocorreu? |  0 |  São no próprio campo. | 
| As mensagens de erro são acompanhadas de sinal sonoro? |  1 |  Não entendemos como prioridade disponibilizar esse recurso sonoro. |  
| As frases e questionamentos são diretos e sem ambiguidade? | 0  | São comandos direitos.  | 
| As mensagens de erro identificam a causa do erro e auxiliam o usuário a consertá-lo? |  0 |São claros e auto-explicativos.  |

| **10- AJUDA E DOCUMENTAÇÃO** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| A aplicação possui alguma forma de ajuda ao usuário? |  4 |  Problema que será resolvido com prioridade. | 
| Os campos de ajuda e documentação são facilmente encontrados pelo usuário? |  4 |  Problema que será resolvido com prioridade. |  
| A aplicação possui documentação/informação básica disponível para o usuário (funcionamento, utilidade, limitações, políticas de privacidade, entre outros)? | 1  | Pode ser implementado em etapas subsequentes.  | 

## Testes de Usabilidade do tipo Dinâmica
<p>Os Testes de Usabilidade, do tipo dinâmica, foram feitos com o auxílio de três usuários, uma adolescente, um adulto e um idoso. Os resultados dos testes estão apresentados nos quadros apresentados a seguir:

**TESTE 1 - CRIAR UM NOVO USUÁRIO**

| **USUÁRIO** | **TAXA DE SUCESSO** | **TAXA DE ERROS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO** | 
|---|---|---|
| Adolescente  |   |   |   |   |
| Adulto |   |   |   |   |
| Idoso  |   |   |   |   |

**TESTE 2 - FAZER LOGIN NA APLICAÇÃO**

| **USUÁRIO** | **TAXA DE SUCESSO** | **TAXA DE ERROS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO** | 
|---|---|---|
| Adolescente  |   |   |   |   |
| Adulto |   |   |   |   |
| Idoso  |   |   |   |   |

**TESTE 3 - CRIAR UMA NOVA CATEGORIA**

| **USUÁRIO** | **TAXA DE SUCESSO** | **TAXA DE ERROS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO** | 
|---|---|---|
| Adolescente  |   |   |   |   |
| Adulto |   |   |   |   |
| Idoso  |   |   |   |   |

**TESTE 4 - CADASTRAR UMA META FINANCEIRA A SER ALCANÇADA EM DETERMINADA CATEGORIA**

| **USUÁRIO** | **TAXA DE SUCESSO** | **TAXA DE ERROS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO** | 
|---|---|---|
| Adolescente  |   |   |   |   |
| Adulto |   |   |   |   |
| Idoso  |   |   |   |   |

**TESTE 5 - REGISTRAR UM GANHO E UMA DESPESA FINANCEIRA NA PÁGINA DE TRANSAÇÕES**

| **USUÁRIO** | **TAXA DE SUCESSO** | **TAXA DE ERROS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO** | 
|---|---|---|
| Adolescente  |   |   |   |   |
| Adulto |   |   |   |   |
| Idoso  |   |   |   |   |

**TESTE 6 - EXPORTAR DADOS FINANCEIROS EM FORMATO .pdf**

| **USUÁRIO** | **TAXA DE SUCESSO** | **TAXA DE ERROS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO** | 
|---|---|---|
| Adolescente  |   |   |   |   |
| Adulto |   |   |   |   |
| Idoso  |   |   |   |   |

**TESTE 7 - VISUALIZAR O PAINEL DE ACOMPANHAMENTO E CONSEGUIR LOCALIZAR SEU GANHO TOTAL, SEU GASTO TOTAL E O BALANÇO DOS VALORES**

| **USUÁRIO** | **TAXA DE SUCESSO** | **TAXA DE ERROS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO** | 
|---|---|---|
| Adolescente  |   |   |   |   |
| Adulto |   |   |   |   |
| Idoso  |   |   |   |   |


Após realizar os testes de usabilidade, obtém-se um relatório a partir das análises realizadas. O Registro de Testes de Usabilidade é um relatório que contém as evidências dos testes e relatos dos usuários participantes, baseado no Plano de Testes de Usabilidade desenvolvido para os casos de uso desta etapa.

As referências abaixo irão auxiliá-lo na geração do artefato “Registro de Testes de Usabilidade”.

> **Links Úteis**:
> - [Ferramentas de Testes de Usabilidade](https://www.usability.gov/how-to-and-tools/resources/templates.html)
