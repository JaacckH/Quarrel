
var connection = new signalR.HubConnectionBuilder().withUrl("/chathub").build();
connection.start();

connection.on("setSessionID", function (sessionID) {
    document.cookie = "SessionID=" + sessionID;
});

function login() {
    var username = document.getElementById('username').value;
    var password = document.getElementById('password').value;

    if (username == "Georgia" && password == "GeorgiaPass") {
        window.location.href = '/';
    }

    else if (username == "Tom" && password == "TomPass") {
        window.location.href = '/Banned';
    }

    else if (username == "Rick" && password == "RickPass") {
        window.location.href = '/Verify';
    }

    else {
        alert("Incorrect Username or Password. Please Try Again!");
    }
}

function createAccount() {
    var username = document.getElementById('username').value;

    if (username == "Rick") {
        alert("Account Created");
        window.location.href = '/Login';
    }
    else {
        alert("Username is Taken. Please Try Again!");
    }
}