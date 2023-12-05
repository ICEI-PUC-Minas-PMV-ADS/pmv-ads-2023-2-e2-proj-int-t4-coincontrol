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

| **1 (V2)- VISIBILIDADE DO STATUS DO SISTEMA** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| As telas possuem títulos que descrevem seu conteúdo? |  0 | Existem cabeçalhos com os nomes.  |
| Os ícones selecionados se destacam dos não selecionados? | 0  |  Após ajustes, a funcionalidade foi implementada e os botões a serem selecionados se destacam com um retângulo cinza no seu entorno.. |
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

| **3 (V2)- CONTROLE DO USUÁRIO E LIBERDADE** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| As opções de ações do usuário são facilmente visualizadas? |  0 |  Botões com bom tamanho de visualização. | 
| Existem funcionalidades para o usuário desfazer ações? | 1  |  Após novas edições, foram inseridos botões de "voltar" nas páginas, bem como o ícone que indica a possibilidade de clicar e retornar para a página inicial. Mas não foi possível ainda inserir o botão de editar o cadastro de login, caso ele queira alterar e-mail ou senha. | 
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

| **5 (V2) - PREVENÇÃO DE ERROS** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| O usuário é solicitado a confirmar tarefas que possuem consequências drásticas? | 0  | Nas ações de exclusão surgem caixas de diálogo perguntando se o usuário tem certeza que quer excluir aquele item.  | 
| As opções dos menus são lógicas e distintas entre si?  | 0  |  Claras e objetivas. |  
| O sistema alerta o usuário quando ele vai realizar alguma ação crítica e/ou irreversível? | 0  |  Através das caixas de diálogo que se abrem para confirmação de exclusão. |
| Quando existem padrões de formatação para as entradas, isso é sinalizado ao usuário? |  0 |  São abertas mensagens de erro nos campos de entradas. Após programação de novas funcionalidades, o requisito de formatação da senha foi inserido e a respectiva caixa de diálogo se abre em caso de não atendimento aos requisitos de senha. |

| **6- RECONHECIMENTO EM VEZ DE MEMORIZAÇÃO** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| São observados rótulos dos ambientes onde o usuário se encontra? |  0 |  Os nomes são claros. | 
| Existem botões que levem às ações de visualização de histórico de movimentações? | 2  |  Funcionalidade que pode vir a ser implementada. |  
| A aplicação é nítida na diferenciação do estado logado do não logado?  | 0  |  Quando logado, o nome do usuário é destacado. | 
| Existem diferenças, mesmo que sutis, entre as telas onde o usuário pode navegar, de forma a diferenciá-las e identificá-las visualmente?  | 1  | Melhorias estéticas podem ser implementadas. |

| **6 (V2)- RECONHECIMENTO EM VEZ DE MEMORIZAÇÃO** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| São observados rótulos dos ambientes onde o usuário se encontra? |  0 |  Os nomes são claros. | 
| Existem botões que levem às ações de visualização de histórico de movimentações? | 0  |  As páginas de categorias, transações, metas e carteira, onde não feitas entradas, possuem páginas que mostram histórico de lançamentos. |  
| A aplicação é nítida na diferenciação do estado logado do não logado?  | 0  |  Quando logado, o nome do usuário é destacado. | 
| Existem diferenças, mesmo que sutis, entre as telas onde o usuário pode navegar, de forma a diferenciá-las e identificá-las visualmente?  | 0  | Após realização de melhorias, as telas são facilmente diferenciadas pelo usuário. |

| **7- FLEXIBILIDADE E EFICIÊNCIA DE USO** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| Exitem atalhos para as ações do usuário? | 0  | A aplicação possui botões que já levam o usuário, com um clique, à função desejada.  | 
| O usuário pode realizar as tarefas de diferentes maneiras, incluindo algumas mais simples? | 1  | Ainda não implementado. A funcionalidade é classificada como de baixa prioridade pela equipe.  |  

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

| **10 (V2)- AJUDA E DOCUMENTAÇÃO** | **AVALIAÇÃO (ESCALA)** | **COMENTÁRIOS** | 
|---|---|---|
| A aplicação possui alguma forma de ajuda ao usuário? |  3 |  Ainda não foi implementado, mas é importante. | 
| Os campos de ajuda e documentação são facilmente encontrados pelo usuário? |  3 |  Ainda não foi implementado, mas é importante. |  
| A aplicação possui documentação/informação básica disponível para o usuário (funcionamento, utilidade, limitações, políticas de privacidade, entre outros)? | 3  | Ainda não foi implementado, mas é considerado importante pela equipe.  | 

## Testes de Usabilidade do tipo Dinâmica
<p>Os Testes de Usabilidade, do tipo dinâmica, foram feitos com o auxílio de três usuários, uma adolescente, um adulto e um idoso. Os resultados dos testes estão apresentados nos quadros apresentados a seguir:

**TESTE 1 - CRIAR UM NOVO USUÁRIO**

| **USUÁRIO** | **TAXA DE SUCESSO** | **ERROS OCORRIDOS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO E COMENTÁRIOS/SUGESTÕES** | 
|---|---|---|---|---|
| Adulto  | Novo usuário criado com sucesso. | Não cadastro de senha conforme a regra na primeira tentativa. | 1m17s | Usuáro ficou satisfeito. Porém sugeriu que a regra de senha já esteja visível antes da primeira tentativa errada ter ocorrido, como está atualmente. Usuário sugeriu que o sistema faça a checagem de e-mail. |
| Idoso | Novo usuário criado com sucesso.  | A mensagem de erro não fala que deve ter letra minúscula, porém depois de várias tentativas o usuário verificou que é um requisito. | 7m50s | Usuário ficou satisfeito, mas sugere que a mensagem de requisitos de senha já esteja disponível no ato do login e que esta mensagem seja corrigida.  |
| Adolescente | Novo usuário criado com sucesso.  | Não cadastro de senha conforme a regra na primeira tentativa.  | 1m  |  Usuáro ficou parcialmente satisfeito. Gostaria que a regra da senha já estivesse vísivel antes da primeira tentativa. Realizou sugestão de checagem via envio de código por e-mail ou SSM. |

**TESTE 2 - FAZER LOGIN NA APLICAÇÃO**

| **USUÁRIO** | **TAXA DE SUCESSO** | **ERROS OCORRIDOS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO E COMENTÁRIOS/SUGESTÕES** | 
|---|---|---|---|---|
| Adulto  | Realização do login com sucesso.  | Nenhum.  | 41s  | Usuário satisfeito.  |
| Idoso | Realização do login com sucesso.  | Nenhum.  | 30s  | Usuário satisfeito.  |
| Adolescente |  Realização do login com sucesso. | Nenhum.  | 28s | Usuário satisfeito.  |

**TESTE 3 - CRIAR UMA NOVA CATEGORIA**

| **USUÁRIO** | **TAXA DE SUCESSO** | **ERROS OCORRIDOS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO E COMENTÁRIOS/SUGESTÕES** | 
|---|---|---|---|---|
| Adulto  | Usuário criou nova categoria com sucesso. | Usuário não conseguiu inserir o ícone.  | 47s  | Usuário ficou parcialmente satisfeito e fez as seguintes sugestões: é necessário o local no site que tenha as informações básicas sobre como operar o site, qual é seu objetivo e o que é entendido como carteira, transação, categoria...; que a inserção do ícone seja mais intuitiva; e que ao editar uma categoria, o botão de confirmação seja "salvar" em vez de "adicionar".   |
| Idoso | Usuário criou nova categoria com sucesso. | Nenhum.  | 1m54s | Satisfação parcial. Usuário teve dificuldades para inserir o ícone, solicitou apoio para concluir. |
| Adolescente | Usuário criou nova categoria com sucesso.  | Nenhum.  | 1m36s  | Parcialmente satisfeito. O Usuário conseguiu realizar o teste porém teve dificuldades para entender os caminhos.  |

**TESTE 4 - CADASTRAR UMA META FINANCEIRA A SER ALCANÇADA EM DETERMINADA CATEGORIA**

| **USUÁRIO** | **TAXA DE SUCESSO** | **ERROS OCORRIDOS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO E COMENTÁRIOS/SUGESTÕES** | 
|---|---|---|---|---|
| Adulto  | Não houve sucesso, pois o usuário não conseguiu cadastrar nova meta para uma categoria que ele tinha criado. | O usuário não compreendeu que a criação da meta deve ser feita no cadastro de nova categoria. | Não se aplica. | Usuário sugere que na tela de cadastro de nova meta o campo categoria esteja acima do campo de valor da meta (invertido ao que está atualmente). E que o passo-a-passo para criação de nova meta esteja descrito em algum local da aplicação. |
| Idoso | Cadastro de meta feito com sucesso. | Nenhum. | 7m22s | Usuário precisou fazer algumas pergutas durante o processo para entender os caminhos de criação de nova categoria e posterior visualização das categorias criadas. |
| Adolescente | Cadastro de meta feito com sucesso.   |  Nenhum |  2m |  O usuário conseguiu realizar a criação de uma meta e completar o teste porém teve dificuldades para entender os caminhos. |

**TESTE 5 - REGISTRAR UM GANHO E UMA DESPESA FINANCEIRA NA PÁGINA DE TRANSAÇÕES**

| **USUÁRIO** | **TAXA DE SUCESSO** | **ERROS OCORRIDOS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO E COMENTÁRIOS/SUGESTÕES** | 
|---|---|---|---|---|
| Adulto  | Realizado com sucesso.  | Nenhum. | 1m50s | Usuário satisfeito. Sugeriu que o $ seja trocado por R$ e que sejam ajustadas as formatações de ponto e vírgula, que estão trocadas. |
| Idoso | Realizado com sucesso.  | Nenhum. | 2m33s | Usuário satisfeito, mas sugeriu que o $ seja trocado por R$ e que sejam ajustadas as formatações de ponto e vírgula, que estão trocadas. Ele sugeriu também que os valores apresentados nas tabelas estejam alinhados à direita em vez de esquerda. |
| Adolescente | Realizado com sucesso.  |  Nenhum. | 35s  | Usuário satisfeito.  |

**TESTE 6 - VISUALIZAR O PAINEL DE ACOMPANHAMENTO E CONSEGUIR LOCALIZAR SEU GANHO TOTAL, SEU GASTO TOTAL E O BALANÇO DOS VALORES**

| **USUÁRIO** | **TAXA DE SUCESSO** | **ERROS OCORRIDOS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO E COMENTÁRIOS/SUGESTÕES** | 
|---|---|---|---|---|
| Adulto  | Visualização realizada com sucesso.  | Nenhum.  | 10s  | Usuário satisfeito.  |
| Idoso |  Visualização realizada com sucesso.  | Nenhum.  | 30s  | Usuário satisfeito. 
| Adolescente | Visualização realizada com sucesso.   | Nenhum.  | 8s.  | Usuário satisfeito com as representações visuais.  |

**TESTE 7 - EXPORTAR DADOS FINANCEIROS EM FORMATO .pdf**

| **USUÁRIO** | **TAXA DE SUCESSO** | **ERROS OCORRIDOS** | **TEMPO GASTO** | **TAXA DE SATISFAÇÃO E COMENTÁRIOS/SUGESTÕES** | 
|---|---|---|---|---|
| Adulto  | Visualização realizada com sucesso.  | Nenhum.  | 14s  | Usuário satisfeito.   |
| Idoso | Visualização realizada com sucesso.  | Nenhum.  |  35s | Usuário satisfeito.   |
| Adolescente | Visualização realizada com sucesso.  | Nenhum.  | 8s  |  Usuário satisfeito porém recomendou que fosse possível que os dados fossem exportados para seu e-mail cadastrado. |

Os testes realizados mostram que o sistema já permite seu funcionamento, porém ainda apresenta alguns ajustes a serem realizados pela equipe de desenvolvimento. As telas estão bem configuradas para a navegação do usuário com certa facilidade, porém melhorias ainda podem ser implementadas no sentido de aumentar a satisfação na experiência do usuário, item considerado muito importante pela equipe de desenvolvimento.
