var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var HomeModel = (function () {
    function HomeModel() {
    }
    return HomeModel;
}());
var HomeController = (function (_super) {
    __extends(HomeController, _super);
    function HomeController() {
        _super.call(this);
        this.Model = new HomeModel();
        this.Model.TestText = "test";
        this.onLoad();
    }
    HomeController.prototype.onLoad = function () {
        this.loadScript("Content/Theme/js/front.js");
    };
    return HomeController;
}(BaseController));
//# sourceMappingURL=home.controller.js.map