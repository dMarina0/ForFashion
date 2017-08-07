class NewsModel {
    constructor() { };
}

class NewsController {
    public Model: NewsModel;
    constructor() {
        this.Model = new NewsModel();
    };
}