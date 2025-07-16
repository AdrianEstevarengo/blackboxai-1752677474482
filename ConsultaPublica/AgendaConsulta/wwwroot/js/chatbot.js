
document.addEventListener('DOMContentLoaded', () => {
    const toggleBtn = document.getElementById('chatbot-toggle');
    const chatContainer = document.getElementById('chatbot-container');
    const notification = document.getElementById('chat-notification');
    const sendButton = document.getElementById('send-button');
    const chatInput = document.getElementById('chat-input');
    const chatMessages = document.getElementById('chat-messages');

    // Initialize SignalR connection
    const connection = new signalR.HubConnectionBuilder()
        .withUrl("/chatHub")
        .configureLogging(signalR.LogLevel.Information)
        .build();

    connection.start().catch(function (err) {
        console.error("SignalR connection error: ", err.toString());
    });

    // Receive messages from the hub
    connection.on("ReceiveMessage", function (user, message) {
        appendMessage(user, message);
    });

    // Função para mostrar/ocultar chat ao clicar no ícone
    toggleBtn.addEventListener('click', () => {
        console.log('Ícone do dog clicado!');
        if (chatContainer.style.display === 'block') {
            chatContainer.style.display = 'none';
        } else {
            chatContainer.style.display = 'block';
        }
    });

    // Clique no header fecha o chat
    const chatHeader = document.getElementById('chat-header');
    chatHeader.addEventListener('click', function () {
        chatContainer.style.display = 'none';
    });

    // Enviar mensagem ao clicar no botão
    sendButton.addEventListener('click', sendMessage);

    // Enviar mensagem ao apertar Enter no input
    chatInput.addEventListener('keypress', (e) => {
        if (e.key === 'Enter') {
            e.preventDefault();
            sendMessage();
        }
    });

    function sendMessage() {
        const message = chatInput.value.trim();
        if (!message) return;

        appendMessage('Você', message);
        chatInput.value = '';

        // Send message via SignalR
        connection.invoke("SendMessage", "Você", message)
            .catch(err => {
                console.error(err.toString());
                appendMessage('Bot', 'Erro ao enviar a mensagem via SignalR.');
            });
    }

    function appendMessage(sender, message) {
        const msg = document.createElement('div');
        msg.className = sender === 'Você' ? 'chat-message user-message' : 'chat-message bot-message';
        msg.innerHTML = `<div class="message-content"><strong>${sender}:</strong> ${message}</div>`;
        chatMessages.appendChild(msg);
        chatMessages.scrollTop = chatMessages.scrollHeight;
    }

    // Mostrar notificação depois de 3 segundos se o chat estiver fechado
    setTimeout(() => {
        const style = window.getComputedStyle(chatContainer);
        const isChatOpen = style.display === 'block';
        if (!isChatOpen && notification) {
            notification.style.display = 'flex';
        }
    }, 3000);
});
