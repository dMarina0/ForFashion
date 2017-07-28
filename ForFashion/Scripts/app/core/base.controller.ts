
abstract class BaseController  {
   
    constructor() {
    } 

    protected loadScript(url: string, callback: Function = null): void {

        //let script: any = (<HTMLScriptElement[]><any>document.createElement("script"));
        //script.type = "text/javascript";

        //if (script.ReadyState) {  //IE
        //    script.onreadystatechange = function () {
        //        if (script.readyState == "loaded" ||
        //            script.readyState == "complete") {
        //            script.onreadystatechange = null;
        //            callback();
        //        }
        //    };
        //} else {  //Others
        //    script.onload = function () {
        //        callback();
        //    };
        //}

        var script = document.createElement('script');
        script.src = url;

        if (callback != null) {
            script.onload = function () {
                callback();
            };
        }

        document.body.appendChild(script);
    }
}