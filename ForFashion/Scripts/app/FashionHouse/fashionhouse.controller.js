var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var FashionHouseModel = (function () {
    function FashionHouseModel() {
    }
    return FashionHouseModel;
}());
var FashionHouseController = (function (_super) {
    __extends(FashionHouseController, _super);
    function FashionHouseController() {
        _super.call(this);
        this.Model = new FashionHouseModel();
        this.onLoad();
    }
    ;
    FashionHouseController.prototype.onLoad = function () {
        this.loadScript("Content/Theme/js/front.js");
    };
    return FashionHouseController;
}(BaseController));
//# sourceMappingURL=fashionhouse.controller.js.map