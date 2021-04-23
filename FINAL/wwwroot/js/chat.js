
var connection = new signalR.HubConnectionBuilder().withUrl("/chathub").build();
connection.start();

connection.on("setSessionID", function (sessionID) {
    document.cookie = "SessionID=" + sessionID;
});