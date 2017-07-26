class HomeModel {
    public TestText
}

class HomeController {
    public Model: HomeModel;
    constructor() {
        debugger;
        this.Model = new HomeModel();
        this.Model.TestText = "test";
    }
}