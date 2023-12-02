using coincontrol.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class QnAController : Controller
{
    public IActionResult Index()
    {
        var questionsAndAnswers = new List<Question>
        {
            new Question { Id = 1, QuestionText = "Como inicio meu acesso no CoinControl?", AnswerText = "Basta acessar nosso site e na tela inicial clicar em “Novo por aqui? Crie sua conta!”. Nos campos que vão surgir, você insere seu nome, seu email e uma senha, que deve ter no mínimo oito caracteres, incluindo pelo menos uma letra maiúscula, um número e um símbolo." },
            new Question { Id = 2, QuestionText = "Como separo meus ganhos e gastos por áreas?", AnswerText = " Clique no botão “Categorias” no menu esquerdo e em “+ Nova Categoria”. Defina se essa categoria será de ganhos “Entrada”, gastos “Saída” ou Meta a ser atingida. A meta é utilizada para que você se organize financeiramente para atingir a meta que estabeleceu para um fim específico (por exemplo para uma viagem). Você pode criar várias categorias e vincular um ícone para cada clicando com o botão direito sobre o campo “Ícone” e então selecionar “Emojis” para abrir as opções de emojis disponíveis." },
            new Question { Id = 3, QuestionText = "Como faço para lançar os valores que eu receba ou que eu gaste?", AnswerText = "Clique no botão “Transações” no menu esquerdo e em “+ Nova Transação”. Preencha informando a qual categoria aquele lançamento pertence, seu valor e, se desejar, alguma outra informação complementar. Então clique em “Adicionar”. Você pode lançar inúmeras transações."},
            new Question { Id = 4, QuestionText = "Posso fazer com o mesmo login mais de um controle financeiro?", AnswerText = "Claro! Basta você criar diferentes carteiras clicando no botão “Carteira” no menu esquerdo e posteriormente em “Adicionar carteira”. Cada carteira se refere a um controle financeiro independente."},
            new Question { Id = 5, QuestionText = "Eu consigo gerar relatórios para baixar e salvar?", AnswerText = "Sim, você pode clicar em “Relatórios” no menu esquerdo para gerar o relatório que desejar em .pdf e salvar em seu computador, smartphone ou tablet."},
            new Question { Id = 6, QuestionText = "Como visualizo quanto ainda tenho de dinheiro disponível?", AnswerText = "Para visualizar seu controle geral financeiro, basta clicar em “Dashboard” no menu esquerdo. Em “Ganho total” e “Gasto total” você observa o valor total recebido e gasto, respectivamente. E em “Balanço” você visualiza seu saldo. Apresentamos também gráficos que resumem para você os gastos por categoria e a comparação entre ganhos e gastos, bem como as transações recentes."},
            new Question { Id = 7, QuestionText = "Os dados que eu lançar no site são protegidos?", AnswerText = "Sim, seus dados, transações, valores e demais registros só poderão ser visualizados após realizado o login. Não compartilhamos dados pessoais ou financeiros com terceiros. A equipe CoinControl se compromete com o sigilo dos seus dados."},
            new Question { Id = 8, QuestionText = "Se eu permanecer com dúvidas, como posso esclarecê-las:", AnswerText = "Se você ainda permanecer com dúvidas, basta entrar em contato com nossa equipe através do e-mail coincontrol@gmail.com que responderemos com prazer."},
        };
        return View(questionsAndAnswers);
    }
}
