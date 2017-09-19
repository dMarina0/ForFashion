var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
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
    function HomeController($http) {
        var _this = _super.call(this) || this;
        var self = _this;
        _this.httpService = $http;
        _this.Model = new HomeModel();
        _this.onLoad();
        _this.getFashionHouse();
        _this.getCollection();
        return _this;
    }
    HomeController.prototype.onLoad = function () {
        this.loadScript("Content/Theme/js/front.js");
    };
    HomeController.prototype.getFashionHouse = function () {
        var _this = this;
        this.httpService({
            method: 'GET',
            url: 'api/FashionHouse'
        }).then(function (response) {
            _this.Model.FashionHouseDtos = response.data;
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