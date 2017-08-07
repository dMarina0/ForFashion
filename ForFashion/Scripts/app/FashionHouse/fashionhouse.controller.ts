
class CollectionFashionHouseDto {
    public Name: string;
}
class FashionHouseModel {
    public CollectionFashionHouseDtos: Array<CollectionFashionHouseDto>;
    constructor() {
        this.CollectionFashionHouseDtos = new Array<CollectionFashionHouseDto>();
    }

}
class FashionHouseController extends BaseController {
    public Model: FashionHouseModel;
    public httpService: ng.IHttpService;
    constructor($http: ng.IHttpService) {
        super();
        this.httpService = $http;
        this.Model = new FashionHouseModel();
        this.getCollection();
        
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
    
}