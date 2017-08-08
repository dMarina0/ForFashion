class LoginModel {
    public username: string;
    public password: string;
    public ErrorMessage: string;
    public grant_type: string;
    constructor() {
        this.grant_type = 'password';
    }
}

class UserModel {
    public username: string;
    public password: string;
    public token_type: string;
    public token: string;
    constructor() { }
}


class LoginController extends BaseController {
    public httpService: ng.IHttpService;
    public LoginModel: LoginModel;
    constructor($http: ng.IHttpService) {
        super();
        this.LoginModel = new LoginModel();
        this.httpService = $http;

    }

    public LoginClick() {
       
        var req = {
            method: 'POST',
            url: '/token',
            headers: {
                'Content-Type': 'application/x-www-form-urlencoded'
            },
            data: 'grant_type=password' + '&' + 'username=' + this.LoginModel.username + '&' + 'password=' + this.LoginModel.password
        }

        this.httpService(req).then(response => {
            
            var myData: any = response.data;
            var user: UserModel = new UserModel();
            if (typeof (Storage) !== "undefined") {
                // Code for localStorage/sessionStorage.
                user.username = myData.userName;
                user.password = myData.password;
                user.token = myData.access_token;
                user.token_type = myData.token_type;
                var LoginData = JSON.stringify(user);
                localStorage.setItem("loginData", LoginData);
                window.location.href = "index.html#!/home";
               //localStorage.setItem("token_type", myData.token_type);
               //localStorage.setItem("token", myData.access_token);
               return response.statusText;
            } else {
                console.log('error');
            }
            localStorage.clear();
            

        }, error => {
            debugger
            this.LoginModel.ErrorMessage = error.data.Message;
           
            //console.log(error.data.Message);
        });
    }
}
