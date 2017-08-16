

class UserProfileModel {
    public FirstName: string;
    public LastName: string;
    public City: string;
    public Address: string;
    public PhoneNumber: string;
    public Error: string;
   
    constructor() {
       
    };
}


class UserProfileController extends BaseController {
    public UserProfileModel: UserProfileModel;
    public httpService: ng.IHttpService;

    constructor($http: ng.IHttpService) {
        super();
        this.UserProfileModel = new UserProfileModel();
        this.httpService = $http;
        this.getData();
    }


    public getData() {

        this.httpService({
            method: 'GET',
            url: 'api/UserDetails',
            headers: {
                'Authorization': 'Bearer ' + this.user.token
            },
        }).then((response:any) => {
            console.log(response.data);
            this.UserProfileModel.FirstName = response.data.FirstName;
            this.UserProfileModel.LastName = response.data.LastName;
            this.UserProfileModel.City = response.data.City;
            this.UserProfileModel.Address = response.data.Address;
            this.UserProfileModel.PhoneNumber = response.data.PhoneNumber;
        }, (response) => {
        });


    }
   
    public postData() {
        var self = this;
        var req = {
            method: 'POST',
            url: 'api/UserDetails',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + this.user.token

            },
            data: {
                "FirstName":this.UserProfileModel.FirstName,
                "LastName": this.UserProfileModel.LastName,
                "City": this.UserProfileModel.City,
                "Address": this.UserProfileModel.Address,
                "PhoneNumber": this.UserProfileModel.PhoneNumber
            }
        }

            this.httpService(req).then((response) => {
                this.UserProfileModel.Error = "";
                console.log(response.data);

            }, error => {
                console.log('error');
            });
        }
 }