class FashionHouseDto {
    public Name: string;
}

class HomeModel {
    public FashionHouseDtos: Array<FashionHouseDto>
    constructor() {
        this.FashionHouseDtos = new Array<FashionHouseDto>();
    }
}

class HomeController extends BaseController {
    public Model: HomeModel;
    public httpService: ng.IHttpService;
    public _array: Array<any>;
    constructor($http: ng.IHttpService) {
        super();
        var self = this;
        this.httpService = $http;
        this.Model = new HomeModel();
        this.onLoad();
        this.get();
    }

    protected onLoad(): void {
        this.loadScript("Content/Theme/js/front.js");
    }

    public get() {
        this.httpService({
            method: 'GET',
            url: 'api/FashionHouse'
        }).then((response) => {
            this.Model.FashionHouseDtos = <Array<FashionHouseDto>>response.data;
        }, (response) => {
        });
    }
}
