var HomeModel = (function () {
    function HomeModel() {
    }
    return HomeModel;
}());
var HomeController = (function () {
    function HomeController() {
        debugger;
        this.Model = new HomeModel();
        this.Model.TestText = "test";
    }
    return HomeController;
}());
//# sourceMappingURL=home.controller.js.map