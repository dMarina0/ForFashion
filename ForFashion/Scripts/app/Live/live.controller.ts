class LiveModel {
    UserName: string;
    Message: string;
    constructor() { };
}




class LiveController extends BaseController {
    private connection: SignalR;
    private proxy: SignalR.Hub.Proxy;
    public messages: Array<string>;
    public message: string;;

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
        this.proxy.on('userConnected', (number) => this.userConnected(number));
        this.proxy.on('onConnected', (id, userName, connectedUsersJson) => this.onConnected(id, userName, connectedUsersJson));
        this.connection.hub.start().done(() => this.newMessage())
    }

    protected newMessage() {
        this.proxy.invoke("onConnected", this.user.username);
    }
 


    protected broadcastMessage(name, message) {
        console.log(name + " " + message);
    }
    protected userConnected(number) {
        debugger
        console.log(number);
    }
    protected onConnected(id, userName, connectedUsersJson) {
        debugger
        var connecvtedUsers = JSON.parse(connectedUsersJson);
    }
}