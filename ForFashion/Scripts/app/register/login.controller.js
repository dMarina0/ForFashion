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
var LoginModel = (function () {
    function LoginModel() {
        this.grant_type = 'password';
    }
    return LoginModel;
}());
var UserModel = (function () {
    function UserModel() {
    }
    return UserModel;
}());
var LoginController = (function (_super) {
    __extends(LoginController, _super);
    function LoginController($http) {
        var _this = _super.call(this) || this;
        _this.LoginModel = new LoginModel();
        _this.httpService = $http;
        return _this;
    }
    LoginController.prototype.LoginClick = function () {
        var _this = this;
        var req = {
            method: 'POST',
            url: '/token',
            headers: {
                'Content-Type': 'application/x-www-form-urlencoded'
            },
            data: 'grant_type=password' + '&' + 'username=' + this.LoginModel.username + '&' + 'password=' + this.LoginModel.password
        };
        this.httpService(req).then(function (response) {
            var myData = response.data;
            var user = new UserModel();
            if (typeof (Storage) !== "undefined") {
                user.username = myData.userName;
                user.password = myData.password;
                user.token = myData.access_token;
                user.token_type = myData.token_type;
                var LoginData = JSON.stringify(user);
                localStorage.setItem("loginData", LoginData);
                window.location.href = "index.html#!/home";
                return response.statusText;
            }
            else {
                console.log('error');
            }
            localStorage.clear();
        }, function (error) {
            debugger;
            _this.LoginModel.ErrorMessage = error.data.Message;
        });
    };
    return LoginController;
}(BaseController));
//# sourceMappingURL=login.controller.js.map