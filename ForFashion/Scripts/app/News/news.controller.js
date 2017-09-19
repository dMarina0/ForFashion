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
var NewsModel = (function () {
    function NewsModel() {
    }
    ;
    return NewsModel;
}());
var NewsController = (function (_super) {
    __extends(NewsController, _super);
    function NewsController() {
        var _this = _super.call(this) || this;
        _this.Model = new NewsModel();
        return _this;
    }
    ;
    return NewsController;
}(BaseController));
//# sourceMappingURL=news.controller.js.map