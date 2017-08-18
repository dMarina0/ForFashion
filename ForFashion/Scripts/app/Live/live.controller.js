var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var LiveModel = (function () {
    function LiveModel() {
    }
    ;
    return LiveModel;
}());
var LiveController = (function (_super) {
    __extends(LiveController, _super);
    function LiveController() {
        _super.call(this);
        this.Model = new LiveModel();
        this.conection();
    }
    ;
    ;
    LiveController.prototype.conection = function () {
        var _this = this;
        //initialize connection
        this.connection = $.connection;
        this.proxy = $.connection.hub.createHubProxy('chatHub');
        this.proxy.on('broadcastMessage', function (name, message) { return _this.broadcastMessage(name, message); });
        this.proxy.on('userConnected', function (number) { return _this.userConnected(number); });
        this.proxy.on('onConnected', function (id, userName, connectedUsersJson) { return _this.onConnected(id, userName, connectedUsersJson); });
        this.connection.hub.start().done(function () { return _this.newMessage(); });
    };
    LiveController.prototype.newMessage = function () {
        this.proxy.invoke("onConnected", this.user.username);
    };
    LiveController.prototype.broadcastMessage = function (name, message) {
        console.log(name + " " + message);
    };
    LiveController.prototype.userConnected = function (number) {
        debugger;
        console.log(number);
    };
    LiveController.prototype.onConnected = function (id, userName, connectedUsersJson) {
        debugger;
        var connecvtedUsers = JSON.parse(connectedUsersJson);
    };
    return LiveController;
}(BaseController));
//# sourceMappingURL=live.controller.js.map