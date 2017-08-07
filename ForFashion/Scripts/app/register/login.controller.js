var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
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
        _super.call(this);
        this.LoginModel = new LoginModel();
        this.httpService = $http;
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
                // Code for localStorage/sessionStorage.
                user.username = myData.username;
                user.password = myData.password;
                user.token = myData.access_token;
                user.token_type = myData.token_type;
                var LoginData = JSON.stringify(user);
                localStorage.setItem("loginData", LoginData);
                window.location.href = "index.html#!/home";
                //localStorage.setItem("token_type", myData.token_type);
                //localStorage.setItem("token", myData.access_token);
                return response.statusText;
            }
            else {
                console.log('error');
            }
            localStorage.clear();
        }, function (error) {
            debugger;
            _this.LoginModel.ErrorMessage = error.data.Message;
            //console.log(error.data.Message);
        });
    };
    return LoginController;
}(BaseController));
//# sourceMappingURL=login.controller.js.map