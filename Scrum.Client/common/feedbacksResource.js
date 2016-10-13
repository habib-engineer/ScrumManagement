(function () {
    "use strict";
    angular.module("common.services")
        .factory("feedbacksResource", ["$resource", "appSettings", feedbacksResource]);
    function feedbacksResource($resource, appSettings) {
        return $resource(appSettings.serverPath + "/api/feedbacks/:retrospective", null,
                {
                    'update': { method: 'PUT' }
                });
    }
}());