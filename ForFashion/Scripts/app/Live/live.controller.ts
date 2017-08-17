class LiveModel {
    constructor() { };
}




class LiveController extends BaseController {
    private connection: SignalR;
    private proxy: SignalR.Hub.Proxy;


    public Model: LiveModel;
    constructor() {
        super();
        this.Model = new LiveModel();
        this.conection();
    };


    public conection(): void {
        //initialize connection
        this.connection = $.connection;
        this.proxy = $.connection.hub.createHubProxy('chatHub');
        this.proxy.on('broadcastMessage', (name, message) => this.broadcastMessage(name, message));
        this.connection.hub.start().done(() => this.executeHubInitActions());

            //// Declare a proxy to reference the hub.

            //var connection:any = $.connection;
            //var chat = connection.chatHub;
            //// Create a function that the hub can call to broadcast messages.
            //chat.client.broadcastMessage = function (name, message) {
            //    console.log(name + " " + message);
            //};

            //// Start the connection.
            //$.connection.hub.start().done(function () {
            //    chat.server.send("me", "you");


            //});
    }

    protected executeHubInitActions() {
        this.proxy.invoke("send", "me", "you");
    }

    protected broadcastMessage(name, message) {
        console.log(name + " " + message);
    }
}