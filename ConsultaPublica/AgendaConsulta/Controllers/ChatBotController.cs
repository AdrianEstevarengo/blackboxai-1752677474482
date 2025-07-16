using AgendaConsulta.Factories;
using Domain.Entities;
using Infra.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace AgendaConsulta.Controllers
{
    public class ChatBotController : Controller
    {
        private readonly IAtividadeRepository _atividadeRepository;

        // Variável estática para lembrar a última intenção do usuário
        private static string _ultimaIntencao = "";

        public ChatBotController(IAtividadeRepository atividadeRepository)
        {
            _atividadeRepository = atividadeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetResponse(string message, string ug)
        {
            var response = await GenerateResponse(message, ug);
            return Content(response);
        }

        private async Task<string> GenerateResponse(string message, string ug)
        {
            if (string.IsNullOrWhiteSpace(message))
                return BotMessage("Diga algo para mim!🐾");

            message = message.ToLower();

            // Saudações
            if (message.Contains("olá") || message.Contains("oi") || message.Contains("bom dia") || message.Contains("boa tarde") || message.Contains("boa noite"))
            {
                var messageHtml = BotMessage("Olá! Eu sou o Supel Dog, assistente virtual da Superintendência de Compras e Licitações de Rondônia. Em que posso ajudar?");
                var buttonsHtml = @"
                    <div class='chat-options'>
                        <button onclick='sendBotMessage(""detalhe de processo"")'>Detalhe de Processo</button>
                        <button onclick='sendBotMessage(""andamento de processo"")'>Andamento de Processo</button>
                        <button onclick='sendBotMessage(""outra"")'>Outra</button>
                    </div>";
                
                return messageHtml + buttonsHtml;
            }

            // Intenção: detalhe
            if (message.Contains("detalhe de processo"))
            {
                _ultimaIntencao = "detalhe";
                return BotMessage("Claro! Me informe o número do processo para exibir os detalhes.");
            }

            // Intenção: andamento
            if (message.Contains("andamento de processo"))
            {
                _ultimaIntencao = "andamento";
                return BotMessage("Claro! Me informe o número do processo para exibir o andamento.");
            }

            if (message == "sim")
            {
                return GetMenuInicial();
            }
            if (message == "não" || message == "nao"|| message == "n")
            {
                return BotMessage("Tudo bem! Obrigado por conversar comigo. Estarei por aqui se precisar de mais alguma coisa.");
            }

            // Diversas respostas prontas
            if (message.Contains("horário") || message.Contains("atendimento") || message.Contains("quando atendem") || message.Contains("horas"))
                return BotMessage("Nosso horário de atendimento é de segunda a sexta-feira, das 8h às 18h.");

            if (message.Contains("documento") || message.Contains("quais documentos") || message.Contains("o que levar"))
                return BotMessage("Para abrir um processo, você precisa dos documentos: CPF, CNPJ e comprovante de endereço.");

            if (message.Contains("telefone") || message.Contains("contato") || message.Contains("email") || message.Contains("falar com"))
                return BotMessage("Você pode entrar em contato conosco pelo telefone (69) 1234-5678 ou pelo email supel@ro.gov.br.");

            if (message.Contains("endereço") || message.Contains("onde fica") || message.Contains("localização"))
                return BotMessage("Estamos localizados na Av. Sete de Setembro, 1234, Porto Velho - RO.");

            if (message.Contains("licitação") || message.Contains("como participar") || message.Contains("participar licitação"))
                return BotMessage("Para participar das licitações, é preciso estar cadastrado no sistema e atender aos requisitos do edital.");

            if (message.Contains("consulta"))
                return BotMessage("Você quer marcar ou visualizar uma consulta?");

            if (message.Contains("prazo") || message.Contains("tempo") || message.Contains("quanto tempo"))
                return BotMessage("Os prazos variam conforme o tipo do processo. Posso ajudar com um processo específico?");

            if (message.Contains("enviar documentos") || message.Contains("como enviar") || message.Contains("entregar documentos"))
                return BotMessage("Os documentos podem ser entregues presencialmente na Superintendência ou enviados pelo sistema online.");

            if (message.Contains("quem é você") || message.Contains("o que é supel dog") || message.Contains("quem é supel dog"))
                return BotMessage("Eu sou o Supel Dog, seu assistente virtual para ajudar com dúvidas e acompanhar processos da Superintendência de Compras e Licitações de Rondônia.");

            if (message.Contains("adeus") || message.Contains("tchau") || message.Contains("até logo") || message.Contains("falou"))
                return BotMessage("Até logo! Volte sempre que precisar! 🐾");

            if (message.Contains("ajuda") || message.Contains("como funciona") || message.Contains("o que faz") || message.Contains("informações"))
                return BotMessage("Posso ajudar você a acompanhar processos, tirar dúvidas sobre licitações, horários, documentos e muito mais.");



            // Se a mensagem for um número de processo
            if (Regex.IsMatch(message, @"^\d{4}\.\d{6}/\d{4}-\d{2}$"))
            {
                var atividades = await _atividadeRepository.GetByNumeroProcessoAsync(message, ug);
                var atividadeViewModel = AtividadeFactory.AtividadeToProcessoAgendaViewModel(atividades);

                if (atividades != null)
                {
                    if (_ultimaIntencao == "andamento")
                    {
                        _ultimaIntencao = "";
                        var andamentoHtml = $@"
                        <div class='balaodedetalhes'>
                        Informações do andamento do processo solicitado! <br/> 
                        O processo está atualmente no evento 
                        <strong>{atividadeViewModel.UltimoEvento?.TipoEvento.Titulo}</strong>, 
                        que começou em <strong>{atividadeViewModel.UltimoEvento?.DataInicial:dd/MM/yyyy}</strong> 
                        e foi concluído em <strong>{atividadeViewModel.UltimoEvento?.DataFinal:dd/MM/yyyy}</strong>.
                        </div>";

                        
                        return BotMessage(andamentoHtml) + BotMessage("Deseja saber algo mais? Responda com <strong>sim</strong> para continuar.");
                    }
                    else // padrão ou intenção "detalhe"
                    {
                        _ultimaIntencao = "";
                        var detalhesHtml = $@"
                            <div class='balaodedetalhes'>
                                Encontrei o processo solicitado! 🎯<br/>
                                <strong>Número do Processo:</strong> {atividadeViewModel.NumeroProcesso}<br/>
                                <strong>Número do Certame:</strong> {atividadeViewModel.NumeroCertame}<br/>
                                <strong>Situação:</strong> {atividadeViewModel.Situacao}<br/>
                                <strong>Objeto:</strong> {atividadeViewModel.Objeto}<br/>
                                <strong>Data de Entrada:</strong> {atividadeViewModel.DataEntrada:dd/MM/yyyy}<br/>
                                <strong>Mesa:</strong> {atividadeViewModel.Mesa}<br/>
                            </div>";

                        return BotMessage(detalhesHtml) + BotMessage("Deseja saber algo mais? Responda com <strong>sim</strong> para continuar.");
                    }
                }
                else
                {
                    return BotMessage("Não encontrei nenhum processo com esse número. ❌");
                }
            }

            // Retorno padrão
            return BotMessage("Desculpe, não entendi sua mensagem. Poderia reformular?");
        }
        private string BotMessage(string text)
        {
            return $@"
        <div class='chat-message bot-message'>
            <strong>
                <img src='/images/Dog.png'
                     style='width:30px; height:30px; padding-bottom:5px; border-radius:4px; object-fit:contain;' />
            </strong>
            <p>{text}</p>
        </div>";
        }

        private string GetMenuInicial()
        {
            var messageHtml = BotMessage("Olá! Eu sou o Supel Dog, assistente virtual da Superintendência de Compras e Licitações de Rondônia. Em que posso ajudar?");
            var buttonsHtml = @"
        <div class='chat-options'>
            <button onclick='sendBotMessage(""detalhe de processo"")'>Detalhe de Processo</button>
            <button onclick='sendBotMessage(""andamento de processo"")'>Andamento de Processo</button>
            <button onclick='sendBotMessage(""outra"")'>Outra</button>
        </div>";
            return messageHtml + buttonsHtml;
        }

    }
}

