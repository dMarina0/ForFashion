var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var NewsModel = (function () {
    function NewsModel() {
    }
    ;
    return NewsModel;
}());
var NewsController = (function (_super) {
    __extends(NewsController, _super);
    function NewsController() {
        _super.call(this);
        this.Model = new NewsModel();
    }
    ;
    return NewsController;
}(BaseController));
//# sourceMappingURL=news.controller.js.map