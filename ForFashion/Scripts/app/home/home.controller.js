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
var HomeModel = (function () {
    function HomeModel() {
        this.FashionHouseDtos = new Array();
    }
    return HomeModel;
}());
var HomeController = (function (_super) {
    __extends(HomeController, _super);
    function HomeController($http) {
        _super.call(this);
        var self = this;
        this.httpService = $http;
        this.Model = new HomeModel();
        this.onLoad();
        this.get();
    }
    HomeController.prototype.onLoad = function () {
        this.loadScript("Content/Theme/js/front.js");
    };
    HomeController.prototype.get = function () {
        var _this = this;
        this.httpService({
            method: 'GET',
            url: 'api/FashionHouse'
        }).then(function (response) {
            _this.Model.FashionHouseDtos = response.data;
        }, function (response) {
        });
    };
    return HomeController;
}(BaseController));
//# sourceMappingURL=home.controller.js.map