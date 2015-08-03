module Charlatan {
    export class sokService {
        static $inject = ['$http', 'appGlobals'];
        constructor(private $http: ng.IHttpService, private appGlobals) {
        }

        searchByName(name: string) {

            var req = {
                method: 'GET',
                url: this.appGlobals.searchPath,
                params: { name: name }
            }

            return this.$http(req);
        }

    }

} 