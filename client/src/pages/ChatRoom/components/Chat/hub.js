import { HubConnectionBuilder } from '@aspnet/signalr';

let chatRoomConnection = null;

function startConnection(connection) {
    if(connection) {
        connection.start().catch(() => {
            setTimeout(() => {
                startConnection(connection);
            }, 2000);
        });
    }
}

const hub = {
    listenChatRoom(callback) {
        const resource = "https://localhost:44361/ChatRoom";
        chatRoomConnection = new HubConnectionBuilder().withUrl(resource).build();
        chatRoomConnection.on('UpdateChat', (missions) => {
            callback(missions);
        });

        chatRoomConnection.onclose( () => {
            startConnection(chatRoomConnection);
        });

        startConnection(chatRoomConnection);
    }
};

export default hub;