var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var VideoDto = (function () {
    function VideoDto() {
    }
    return VideoDto;
}());
var VideosModel = (function () {
    function VideosModel() {
        this.VideosDtos = new Array();
    }
    return VideosModel;
}());
var VideosController = (function (_super) {
    __extends(VideosController, _super);
    function VideosController($http, $routeParams) {
        _super.call(this);
        var id = $routeParams.id;
        this.Model = new VideosModel();
        this.httpService = $http;
        //this.getCollection(id);
        this.getVideos(id);
    }
    ;
    VideosController.prototype.getVideos = function (id) {
        var _this = this;
        this.httpService({
            method: 'GET',
            url: 'api/Videos/' + id
        }).then(function (response) {
            _this.Model.VideosDtos = response.data;
            console.log(_this.Model.VideosDtos[0]);
        }, function (response) {
        });
    };
    return VideosController;
}(BaseController));
//# sourceMappingURL=videos.controller.js.map