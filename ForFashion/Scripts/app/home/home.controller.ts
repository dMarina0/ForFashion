class FashionHouseDto {
    public Name: string;
    public Id: string;
     
}
class CollectionDto {
    public Name: string;
    public Id: number;
    public FashionHouse: string;
    public Year: number;
    public fashionId: number; 
} 

class HomeModel {
    public FashionHouseDtos: Array<FashionHouseDto>
    public CollectionDtos: Array<CollectionDto>
    public FashionHouseDto: FashionHouseDto;
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
        this.getFashionHouse();
        this.getCollection();
        
    }

    protected onLoad(): void {
        this.loadScript("Content/Theme/js/front.js");
    }

    public getFashionHouse() {
        
        this.httpService({
            method: 'GET',
            url: 'api/FashionHouse' 
        }).then((response) => {
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
