class LiveModel {
    constructor() { };
}




class LiveController {
    public Model: LiveModel;
    constructor() {
        this.Model = new LiveModel();
    };
}