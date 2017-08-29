var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var RegisterModel = (function () {
    function RegisterModel() {
    }
    RegisterModel.prototype.validateEmail = function (Email) {
        var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
        return re.test(Email);
    };
    return RegisterModel;
}());
var RegisterController = (function (_super) {
    __extends(RegisterController, _super);
    function RegisterController($http) {
        _super.call(this, $http);
        this.httpService = $http;
        this.RegisterModel = new RegisterModel();
    }
    RegisterController.prototype.RegisterClick = function () {
        window.location.href = "/index.html#!/userprofile";
        var self = this;
        var req = {
            method: 'POST',
            url: 'api/Account/Register',
            headers: {
                'Content-Type': 'application/json'
            },
            data: this.RegisterModel
        };
        this.httpService(req).then(function (response) {
            return response.statusText;
        }, function (error) {
            self.RegisterModel.ErrorMessage = error.data.Message;
        });
    };
    return RegisterController;
}(LoginController));
//# sourceMappingURL=register.controller.js.map