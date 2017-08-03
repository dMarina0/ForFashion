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
    function FashionHouseController($http) {
        _super.call(this);
        this.httpService = $http;
        this.Model = new FashionHouseModel();
        this.getCollection();
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
    return FashionHouseController;
}(BaseController));
//# sourceMappingURL=fashionhouse.controller.js.map