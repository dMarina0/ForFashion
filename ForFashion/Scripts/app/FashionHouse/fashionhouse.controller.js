var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var CollectionFashionHouseDto = (function () {
    function CollectionFashionHouseDto() {
    }
    return CollectionFashionHouseDto;
}());
var FashionHouseModel = (function () {
    function FashionHouseModel() {
        this.CollectionFashionHouseDtos = new Array();
    }
    return FashionHouseModel;
}());
var FashionHouseController = (function (_super) {
    __extends(FashionHouseController, _super);
    //  public x: any;
    function FashionHouseController($http, $routeParams) {
        _super.call(this);
        var id = $routeParams.id;
        var fashionId = $routeParams.fashionId;
        this.httpService = $http;
        this.Model = new FashionHouseModel();
        this.getCollection();
        this.getFashionHouse(id);
        this.getCollectionByFashionHouse(fashionId);
        //   this.x = $location.search;
    }
    ;
    FashionHouseController.prototype.getCollection = function () {
        var _this = this;
        this.httpService({
            method: 'GET',
            url: 'api/Collection'
        }).then(function (response) {
            _this.Model.CollectionFashionHouseDtos = response.data;
        }, function (response) {
        });
    };
    FashionHouseController.prototype.getFashionHouse = function (id) {
        var _this = this;
        this.httpService({
            method: 'GET',
            url: 'api/FashionHouse/' + id
        }).then(function (response) {
            _this.Model.FashionHouseDto = response.data;
        }, function (response) {
        });
    };
    FashionHouseController.prototype.getCollectionByFashionHouse = function (fashionId) {
        var _this = this;
        this.httpService({
            method: 'GET',
            url: 'api/Collection?fashionId1=' + fashionId
        }).then(function (response) {
            _this.Model.CollectionFashionHouseDtos = response.data;
            debugger;
        }, function (response) {
        });
    };
    return FashionHouseController;
}(BaseController));
//# sourceMappingURL=fashionhouse.controller.js.map