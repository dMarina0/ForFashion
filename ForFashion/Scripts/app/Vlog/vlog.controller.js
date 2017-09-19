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
var VlogModel = (function () {
    function VlogModel() {
    }
    ;
    return VlogModel;
}());
var VlogController = (function (_super) {
    __extends(VlogController, _super);
    function VlogController() {
        var _this = _super.call(this) || this;
        _this.VlogModel = new VlogModel();
        return _this;
    }
    return VlogController;
}(BaseController));
//# sourceMappingURL=vlog.controller.js.map