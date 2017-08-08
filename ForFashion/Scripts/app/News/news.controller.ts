class NewsModel {
    constructor() { };
}

class NewsController extends BaseController {
    public Model: NewsModel;
    constructor() {
        super();
        this.Model = new NewsModel();
    };
}