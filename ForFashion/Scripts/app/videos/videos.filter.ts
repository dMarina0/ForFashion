'use strict'
module videos.Filters {

    export class trustedResource {

        static $inject: string[] = ['$sce'];

        static filter($sce: ng.ISCEService) {
            return (value) => {
                return $sce.trustAsResourceUrl(value)
            };
        }
    }
}
