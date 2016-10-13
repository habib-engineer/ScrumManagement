(function () {
    "use strict";
    angular.module("scrumManagement").
        controller("FeedbackAddCtrl", ["feedbacksResource", FeedbackAddCtrl]);

    function FeedbackAddCtrl(feedbacksResource) {
        var vm = this;
        vm.message = '';
        vm.feedback = { retrospectiveName: "Retrospective 1", personName: "", body: "", type: "" };

        //feedbacksResource.query({ retrospective: "Retrospective1" }, function (data) {
        //    vm.feedback = data;
        //    vm.origionalfeedback = angular.copy(data);
        //});

        vm.submit = function () {
                vm.message = "... Save Complete";
            };

        vm.cancel = function (editForm) {
            editForm.$setPristine();
            vm.message = '';
        };
    };
}());