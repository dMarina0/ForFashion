class FashionHouseDto {
    public Name: string;
    public Id: string;
}
class CollectionDto {
    public Name: string;
    public Id: number;
} 

class HomeModel {
    public FashionHouseDtos: Array<FashionHouseDto>
    public CollectionDtos: Array<CollectionDto>
    constructor() {
        this.FashionHouseDtos = new Array<FashionHouseDto>();
        this.CollectionDtos = new Array<CollectionDto>();
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
        this.getFashionHouses();
        this.getCollection();
    }

    protected onLoad(): void {
        this.loadScript("Content/Theme/js/front.js");
    }

    public getFashionHouses() {
        this.httpService({
            method: 'GET',
            url: 'api/FashionHouse'
        }).then((response) => {
            debugger
            this.Model.FashionHouseDtos = <Array<FashionHouseDto>>response.data;
        }, (response) => {
        });
    }
    public getCollection() {
        this.httpService({
            method: 'GET',
            url: 'api/Collection'
        }).then((response) => {
            this.Model.CollectionDtos = <Array<CollectionDto>>response.data;
        }, (response) => {
        });
    }

}
