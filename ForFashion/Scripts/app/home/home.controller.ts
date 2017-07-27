class HomeModel {
    public TestText
}

class HomeController extends BaseController {
    public Model: HomeModel;
    constructor() {
        super();
        this.Model = new HomeModel();
        this.Model.TestText = "test";

        this.onLoad();
    }

    protected onLoad(): void {
        this.loadScript("Content/Theme/js/front.js");
    }
}
