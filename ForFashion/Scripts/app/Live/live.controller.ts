class Message {
    UserMessage: string;
    constructor() {
    };
}
class LiveModel {
    UserName: string;
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
        name = this.user.username;
        this.LiveModel.UserName = name;
        this.LiveModel.mesaj = message;
        var a = new Message();
        a.UserMessage = message;
        this.LiveModel.Messages.push(a);
        this.RootScope.$apply();
    }
    protected SendMessage() {
        this.proxy.invoke("send", this.LiveModel.UserName, this.LiveModel.mesaj);
    }

    protected userConnected(number) {
        console.log(number);
    }
    protected onConnected(id, userName, connectedUsersJson) {
        var connecvtedUsers = JSON.parse(connectedUsersJson);
    }
}