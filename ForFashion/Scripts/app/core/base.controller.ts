
abstract class BaseController  {
    public user: UserModel;
    public newUser: UserModel = null;


    constructor() {
        this.user = new UserModel();
        this.newUser = new UserModel();
        this.GetLoginData();
       
    } 


    protected loadScript(url: string, callback: Function = null): void {

    

        var script = document.createElement('script');
        script.src = url;

        if (callback != null) {
            script.onload = function () {
                callback();
            };
        }

        document.body.appendChild(script);
    }
    protected GetLoginData(): any {
        this.user = JSON.parse(localStorage.getItem('loginData'));
     
      
      
    }

    protected LogOut(): void  {
        localStorage.removeItem('loginData');
        debugger
    }

}