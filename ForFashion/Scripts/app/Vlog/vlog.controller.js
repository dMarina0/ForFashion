var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var VlogModel = (function () {
    function VlogModel() {
    }
    ;
    return VlogModel;
}());
var VlogController = (function (_super) {
    __extends(VlogController, _super);
    function VlogController() {
        _super.call(this);
        this.VlogModel = new VlogModel();
    }
    return VlogController;
}(BaseController));
//# sourceMappingURL=vlog.controller.js.map