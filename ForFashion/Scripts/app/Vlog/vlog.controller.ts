class VlogModel {
    constructor() { };
}

class VlogController {
    public VlogModel: VlogModel;
    constructor() {
        this.VlogModel = new VlogModel();
    }
}