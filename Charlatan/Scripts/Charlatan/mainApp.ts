module Charlatan {

    export var mainApp = angular.module('mainApp', ['firebase'])
        .constant('FirebaseUrl', 'https://charlataner.firebaseio.com/')
        .service('sokService', sokService)
        .controller('mainController', mainController)
        .directive('sokEnter', Common.sokEnter)
        .directive('sokFocus', Common.sokFocus);

} 