class Message {
    UserName: string;
    UserMessage: string;
    constructor() {
    };
}
class LiveModel {
    ConnectedUsers: Array<string>;
    Name: string;
    mesaj: string;
    Messages: Array<Message>;
    constructor() {
       this.Messages = new Array<Message>();
    };

}

class LiveController extends BaseController {
    private connection: SignalR;
    private proxy: SignalR.Hub.Proxy;
    public LiveModel: LiveModel;
    protected RootScope: ng.IRootScopeService;

    constructor($rootScope: ng.IRootScopeService) {
        super();
        this.RootScope = $rootScope;
        this.LiveModel = new LiveModel();
        this.conection();
        this.LiveModel.Name = this.user.username;
    };


    public conection(): void {
        this.connection = $.connection;
        this.proxy = $.connection.hub.createHubProxy('chatHub');
        this.proxy.on('broadcastMessage', (name, message) => this.broadcastMessage(name, message));
        this.proxy.on('userConnected', (number) => this.userConnected(number));
        this.proxy.on('onConnected', (connectedUsersJson) => this.onConnected(connectedUsersJson));
        this.connection.hub.start().done(() => this.NewMessage())
    }

    protected NewMessage() {
        this.proxy.invoke("Connected");
       
    }

    protected broadcastMessage(name, message) {
        this.LiveModel.mesaj = message;
        var a = new Message();
        a.UserMessage = message;
        a.UserName = name;
        this.LiveModel.Messages.push(a);
        this.RootScope.$apply();
    }
    protected SendMessage() {
        this.proxy.invoke("send", this.LiveModel.Name, this.LiveModel.mesaj);
    }

    protected userConnected(number) {
        console.log(number);
    }
    protected onConnected(connectedUsersJson) {
        var connectedUsers = JSON.parse(connectedUsersJson);
    }
}