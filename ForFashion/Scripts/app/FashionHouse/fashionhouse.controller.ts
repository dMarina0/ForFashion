
class CollectionFashionHouseDto {
    public Name: string;
    public Year: number;
    public fashionId: number;
}
class FashionHouseModel {
    public CollectionFashionHouseDtos: Array<CollectionFashionHouseDto>;
    public FashionHouseDto: FashionHouseDto;
    constructor() {
        this.CollectionFashionHouseDtos = new Array<CollectionFashionHouseDto>();
    }

}
class Pagination {
    public PageNumber: number;
    public ElementsOnPage: number;
}

class FashionHouseController extends BaseController {
    public Model: FashionHouseModel;
    public httpService: ng.IHttpService;
  //  public x: any;
   
    constructor($http: ng.IHttpService, $routeParams: any) {
        super();
        var id: number = $routeParams.id;
        var fashionId: number = id;
        this.httpService = $http;
        this.Model = new FashionHouseModel();
        this.getCollection();
        this.getFashionHouse(id);
        this.getCollectionByFashionHouseId(fashionId);
     //   this.x = $location.search;
    };

    public getCollection() {
        this.httpService({
            method: 'GET',
            url: 'api/Collection'
        }).then((response) => {
            this.Model.CollectionFashionHouseDtos = <Array<CollectionDto>>response.data;
        }, (response) => {
        });
    }

    public getCollectionByFashionHouseId(fashionId: number) {
        this.httpService({
            method: 'GET',
            url: 'api/Collection?fashionId=' + fashionId
        }).then((response) => {
            this.Model.CollectionFashionHouseDtos = <Array<CollectionDto>>response.data;
        }, (response) => {
        });
    }

    public getFashionHouse(id: number) {
        
        this.httpService({
            method: 'GET',
            url: 'api/FashionHouse/' + id
        }).then((response) => {            
            this.Model.FashionHouseDto = <FashionHouseDto>response.data;
        }, (response) => {
        });
    }
}