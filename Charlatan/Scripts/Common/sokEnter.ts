module Charlatan.Common {

    export interface ISokEnter extends ng.IScope {
        moaShortcuts;
    }

    export function sokEnter($parse): ng.IDirective {
        var link = (scope: ISokEnter, element, attrs) => {
            element.bind("keydown keypress", function (event) {
                if (event.which === 13) {
                    scope.$eval(attrs.sokEnter);
                    event.preventDefault();
                }
            });
        }
        return {
            link: link
        }
    }
    sokEnter.$inject = ["$parse"];

}  