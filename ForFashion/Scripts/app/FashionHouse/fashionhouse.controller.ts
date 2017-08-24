
class CollectionFashionHouseDto {
    public Name: string;
    public Year: number;
 
}
class FashionHouseModel {
    public CollectionFashionHouseDtos: Array<CollectionFashionHouseDto>;
    public FashionHouseDto: FashionHouseDto;
    constructor() {
        this.CollectionFashionHouseDtos = new Array<CollectionFashionHouseDto>();
    }

}


class FashionHouseController extends BaseController {
    public Model: FashionHouseModel;
    public httpService: ng.IHttpService;
  //  public x: any;
   
    constructor($http: ng.IHttpService, $routeParams: any) {
        super();
        var id: number = $routeParams.id;
        this.httpService = $http;
        this.Model = new FashionHouseModel();
        this.getCollection();
        this.getFashionHouse(id);
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