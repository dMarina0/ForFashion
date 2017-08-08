class VideosModel {
    constructor() { };
}

class VideosController {
    public Model: VideosModel;
    constructor() {
        this.Model = new VideosModel();
    };
}