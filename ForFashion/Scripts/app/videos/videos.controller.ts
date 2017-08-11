class VideoDto {
    public Id: number;
    public VideoUrl: string;
    public Collection_Id: number;
}

class VideosModel {
    // public Name: string;
    public VideosDtos: Array<VideoDto>;
    constructor() {
        this.VideosDtos = new Array<VideoDto>();
    }
}

class VideosController extends BaseController{
    public Model: VideosModel;
    public httpService: ng.IHttpService;
   
    constructor($http: ng.IHttpService, $routeParams: any) {
        super();
        var id: number = $routeParams.id;        
        this.Model = new VideosModel();
        this.httpService = $http;
        //this.getCollection(id);
        this.getVideos(id);
    };

    public getVideos(id: number) {
        this.httpService({
            method: 'GET',
            url: 'api/Videos/' + id
        }).then((response) => {
            this.Model.VideosDtos = <Array<VideoDto>>response.data;            
            console.log(this.Model.VideosDtos[0]);
        }, (response) => {
        });
    }
    //public getCollection(id:number) {
    //    this.httpService({
    //        method: 'GET',
    //        url: 'api/Collection/' + id
    //    }).then((response) => {
    //        this.Model.VideoDto = <VideoDto>response.data;
    //    }, (response) => {
    //    });
    //}

}
