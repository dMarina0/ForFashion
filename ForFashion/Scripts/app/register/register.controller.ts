
class RegisterModel {
    public Email: string;
    public Password: string;
    public ConfirmPassword: string;
    public ErrorMessage: string;

    constructor() {
    }

    protected validateEmail(Email) {
    var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(Email)
    }
}

class RegisterController extends LoginController {
    public RegisterModel: RegisterModel;
    

    
    constructor($http: ng.IHttpService) {
        super($http);
        this.httpService = $http;
        this.RegisterModel = new RegisterModel();
        
    }

    public RegisterClick() {
       
        window.location.href = "/index.html#!/userprofile";
        var self = this;
        var req = {
            method: 'POST',
            url: 'api/Account/Register',
            headers: {
                'Content-Type': 'application/json'
            },
            data: this.RegisterModel
        }

        this.httpService(req).then(response => {
           
            return response.statusText;
            
        }, (error) => {
            self.RegisterModel.ErrorMessage = error.data.Message;
          
            });
       
    }

}
