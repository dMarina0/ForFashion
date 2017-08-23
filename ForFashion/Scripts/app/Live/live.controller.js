var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var Message = (function () {
    function Message() {
    }
    ;
    return Message;
}());
var LiveModel = (function () {
    function LiveModel() {
        this.Messages = new Array();
    }
    ;
    return LiveModel;
}());
var LiveController = (function (_super) {
    __extends(LiveController, _super);
    function LiveController($rootScope) {
        _super.call(this);
        this.RootScope = $rootScope;
        this.LiveModel = new LiveModel();
        this.conection();
        this.LiveModel.Name = this.user.username;
    }
    ;
    LiveController.prototype.conection = function () {
        var _this = this;
        this.connection = $.connection;
        this.proxy = $.connection.hub.createHubProxy('chatHub');
        this.proxy.on('broadcastMessage', function (name, message) { return _this.broadcastMessage(name, message); });
        this.proxy.on('userConnected', function (number) { return _this.userConnected(number); });
        this.proxy.on('onConnected', function (connectedUsersJson) { return _this.onConnected(connectedUsersJson); });
        this.connection.hub.start().done(function () { return _this.NewMessage(); });
    };
    LiveController.prototype.NewMessage = function () {
        this.proxy.invoke("Connected");
    };
    LiveController.prototype.broadcastMessage = function (name, message) {
        this.LiveModel.mesaj = message;
        var a = new Message();
        a.UserMessage = message;
        a.UserName = name;
        this.LiveModel.Messages.push(a);
        this.RootScope.$apply();
    };
    LiveController.prototype.SendMessage = function () {
        this.proxy.invoke("send", this.LiveModel.Name, this.LiveModel.mesaj);
    };
    LiveController.prototype.userConnected = function (number) {
        console.log(number);
    };
    LiveController.prototype.onConnected = function (connectedUsersJson) {
        var connectedUsers = JSON.parse(connectedUsersJson);
    };
    return LiveController;
}(BaseController));
//# sourceMappingURL=live.controller.js.map