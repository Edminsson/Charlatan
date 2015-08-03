module Charlatan {
    export class mainController {
        static $inject = ["$scope", "sokService", 'appGlobals'];
        personer;
        detailsPath: string;
        sokningHarGjorts: boolean = false;

        constructor($scope, private sokService: sokService, appGlobals) {
            $scope.modell = this;
            this.detailsPath = appGlobals.detailsPath;
        }

        sok(name: string) {

            this.sokService.searchByName(name).success((result) => {
                this.personer = result;
                this.sokningHarGjorts = true;
            }).error(() => {
                this.personer = [];
                this.sokningHarGjorts = true;
            });
        }

        tomLista(): boolean {
            return this.personer !== undefined && this.personer.length == 0 && this.sokningHarGjorts;
        }

    }

} 