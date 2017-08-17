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
    LiveController.prototype.conection = function () {
        var _this = this;
        //initialize connection
        this.connection = $.connection;
        this.proxy = $.connection.hub.createHubProxy('chatHub');
        this.proxy.on('broadcastMessage', function (name, message) { return _this.broadcastMessage(name, message); });
        this.connection.hub.start().done(function () { return _this.executeHubInitActions(); });
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
    };
    LiveController.prototype.executeHubInitActions = function () {
        this.proxy.invoke("send", "me", "you");
    };
    LiveController.prototype.broadcastMessage = function (name, message) {
        console.log(name + " " + message);
    };
    return LiveController;
}(BaseController));
//# sourceMappingURL=live.controller.js.map