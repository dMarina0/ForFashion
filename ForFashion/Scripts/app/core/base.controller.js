var BaseController = (function () {
    function BaseController() {
        this.user = new UserModel();
        this.GetLoginData();
    }
    BaseController.prototype.loadScript = function (url, callback) {
        if (callback === void 0) { callback = null; }
        var script = document.createElement('script');
        script.src = url;
        if (callback != null) {
            script.onload = function () {
                callback();
            };
        }
        document.body.appendChild(script);
    };
    BaseController.prototype.GetLoginData = function () {
        this.user = JSON.parse(localStorage.getItem('loginData'));
    };
    BaseController.prototype.LogOut = function () {
        localStorage.removeItem('loginData');
        debugger;
    };
    return BaseController;
}());
//# sourceMappingURL=base.controller.js.map