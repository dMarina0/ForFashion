class FashionHouseModel {
}
class FashionHouseController extends BaseController {
    public Model: FashionHouseModel;
    constructor() {
        super();
        this.Model = new FashionHouseModel();
        this.onLoad();
        
    };
    protected onLoad(): void {
        this.loadScript("Content/Theme/js/front.js");
    
    }
    
    
}