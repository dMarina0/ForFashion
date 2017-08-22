var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var FashionHouseDto = (function () {
    function FashionHouseDto() {
    }
    return FashionHouseDto;
}());
var CollectionDto = (function () {
    function CollectionDto() {
    }
    return CollectionDto;
}());
var HomeModel = (function () {
    function HomeModel() {
        this.FashionHouseDtos = new Array();
        this.CollectionDtos = new Array();
    }
    return HomeModel;
}());
var HomeController = (function (_super) {
    __extends(HomeController, _super);
    function HomeController($http, $routeParams) {
        _super.call(this);
        var self = this;
        var id = $routeParams.id;
        this.httpService = $http;
        this.Model = new HomeModel();
        this.onLoad();
        this.getFashionHouse(id);
        this.getCollection();
    }
    HomeController.prototype.onLoad = function () {
        this.loadScript("Content/Theme/js/front.js");
    };
    HomeController.prototype.getFashionHouse = function (id) {
        var _this = this;
        this.httpService({
            method: 'GET',
            url: 'api/FashionHouse/' + id
        }).then(function (response) {
            _this.Model.FashionHouseDto = response.data;
        }, function (response) {
        });
    };
    HomeController.prototype.getCollection = function () {
        var _this = this;
        this.httpService({
            method: 'GET',
            url: 'api/Collection'
        }).then(function (response) {
            _this.Model.CollectionDtos = response.data;
        }, function (response) {
        });
    };
    return HomeController;
}(BaseController));
//# sourceMappingURL=home.controller.js.map