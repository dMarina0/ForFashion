class VlogModel {
    constructor() { };
}

class VlogController extends BaseController{
    public VlogModel: VlogModel;
    constructor() {
        super();
        this.VlogModel = new VlogModel();
    }
}