var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Conversation = (function () {
    function Conversation() {
    }
    ;
    return Conversation;
}());
var Message = (function () {
    function Message() {
    }
    ;
    return Message;
}());
var LiveModel = (function () {
    function LiveModel() {
        this.Messages = new Array();
        this.Conversations = new Array();
    }
    ;
    return LiveModel;
}());
var LiveController = (function (_super) {
    __extends(LiveController, _super);
    function LiveController($rootScope) {
        var _this = _super.call(this) || this;
        _this.RootScope = $rootScope;
        _this.LiveModel = new LiveModel();
        _this.conection();
        _this.LiveModel.Name = _this.user.username;
        return _this;
    }
    ;
    LiveController.prototype.conection = function () {
        var _this = this;
        this.connection = $.connection;
        this.proxy = $.connection.hub.createHubProxy('chatHub');
        this.proxy.on('broadcastMessage', function (name, message) { return _this.broadcastMessage(name, message); });
        this.proxy.on('onConnected', function (connectedUsersJson) { return _this.onConnected(connectedUsersJson); });
        this.connection.hub.start().done(function () { return _this.NewMessage(); });
    };
    LiveController.prototype.NewMessage = function () {
        this.proxy.invoke("Connected");
    };
    LiveController.prototype.broadcastMessage = function (name, message) {
        this.LiveModel.mesaj = message;
        var a = new Conversation();
        a.Messages = message;
        a.UserName = name;
        this.LiveModel.Conversations.unshift(a);
        debugger;
        this.LiveModel.mesaj = '';
        this.RootScope.$apply();
    };
    LiveController.prototype.SendMessage = function () {
        this.proxy.invoke("send", this.LiveModel.Name, this.LiveModel.mesaj);
        $("#message-text").focus();
    };
    LiveController.prototype.onConnected = function (connectedUsersJson) {
        this.LiveModel.Conversations = JSON.parse(connectedUsersJson);
        this.RootScope.$apply();
    };
    return LiveController;
}(BaseController));
//# sourceMappingURL=live.controller.js.map