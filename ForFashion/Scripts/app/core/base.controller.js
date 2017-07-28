var BaseController = (function () {
    function BaseController() {
    }
    BaseController.prototype.loadScript = function (url, callback) {
        //let script: any = (<HTMLScriptElement[]><any>document.createElement("script"));
        //script.type = "text/javascript";
        if (callback === void 0) { callback = null; }
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
    };
    return BaseController;
}());
//# sourceMappingURL=base.controller.js.map