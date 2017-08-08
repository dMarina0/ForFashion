var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var LiveModel = (function () {
    function LiveModel() {
    }
    ;
    return LiveModel;
}());
var LiveController = (function (_super) {
    __extends(LiveController, _super);
    function LiveController() {
        _super.call(this);
        this.Model = new LiveModel();
    }
    ;
    return LiveController;
}(BaseController));
//# sourceMappingURL=live.controller.js.map