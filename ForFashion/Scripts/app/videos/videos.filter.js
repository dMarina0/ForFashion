'use strict';
var videos;
(function (videos) {
    var Filters;
    (function (Filters) {
        var trustedResource = (function () {
            function trustedResource() {
            }
            trustedResource.filter = function ($sce) {
                return function (value) {
                    return $sce.trustAsResourceUrl(value);
                };
            };
            trustedResource.$inject = ['$sce'];
            return trustedResource;
        }());
        Filters.trustedResource = trustedResource;
    })(Filters = videos.Filters || (videos.Filters = {}));
})(videos || (videos = {}));
//# sourceMappingURL=videos.filter.js.map