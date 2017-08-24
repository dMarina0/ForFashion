class Conversation {
    UserName: string;
    Messages: string;
    constructor() {
    };
}


class Message {
    UserName: string;
    UserMessage: string;
    constructor() {
    };
}
class LiveModel {
    Conversations: Array<Conversation>;
    Name: string;
    mesaj: string;
    Messages: Array<Message>;
    constructor() {
        this.Messages = new Array<Message>();
        this.Conversations = new Array<Conversation>();
    };

}

class LiveController extends BaseController {
    private connection: SignalR;
    private proxy: SignalR.Hub.Proxy;
    public LiveModel: LiveModel;
    //public ConversationModel: Conversation;
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
        var a = new Conversation();
        a.Messages = message;
        a.UserName = name;
        this.LiveModel.Conversations.unshift(a);
        debugger
        this.LiveModel.mesaj = '';
        this.RootScope.$apply();
    }
    protected SendMessage() {
        this.proxy.invoke("send", this.LiveModel.Name, this.LiveModel.mesaj);
        $("#message-text").focus();
    }

    protected userConnected(number) {
        console.log(number);
    }
    protected onConnected(connectedUsersJson) {
        this.LiveModel.Conversations = <Array<Conversation>>JSON.parse(connectedUsersJson);

        this.RootScope.$apply();
        //this.LiveModel.Conversations.push(deserialize);
       
    }
}