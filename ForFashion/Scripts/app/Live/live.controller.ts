class LiveModel {
    constructor() { };
}




class LiveController extends BaseController {
    public Model: LiveModel;
    constructor() {
        super();
        this.Model = new LiveModel();
    };
}