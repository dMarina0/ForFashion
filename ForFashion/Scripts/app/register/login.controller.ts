class LoginModel {
    public username: string;
    public password: string;
    public ErrorMessage: string;
    public grant_type: string;
    constructor() {
        this.grant_type = 'password';
    }
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
        debugger
        var req = {
            method: 'POST',
            url: '/token',
            headers: {
                'Content-Type': 'application/x-www-form-urlencoded'
            },
            data: 'grant_type=password' + '&' + 'username=' + this.LoginModel.username + '&' + 'password=' + this.LoginModel.password
        }

        this.httpService(req).then(response => {
            debugger
            var myData: any = response.data;
            if (typeof (Storage) !== "undefined") {
                // Code for localStorage/sessionStorage.
               localStorage.setItem("token_type", myData.token_type);
               localStorage.setItem("token", myData.access_token);
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
