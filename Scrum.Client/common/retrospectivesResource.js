(function () {
    "use strict";
    angular.module("common.services")
        .factory("retrospectivesResource", ["$resource", "appSettings", retrospectivesResource]);
    function retrospectivesResource($resource, appSettings) {
        return $resource(appSettings.serverPath + "/api/retrospectives/:name", null,
                {
                    'update': { method: 'PUT' }
                });
    }
}());