(function () {
    "use strict";
    angular.module("scrumManagement").
        controller("FeedbacksListCtrl", ["$state", "feedbacksResource", FeedbacksListCtrl]);

    function FeedbacksListCtrl($state, feedbacksResource) {
        var vm = this;

        vm.feedbacks = [ { retrospectiveName : "Retrospective 1", personName: "Gareth", body:"Sprint objective met", type:"Positive"}
        , { retrospectiveName: "Retrospective 1", personName: "Viktor", body: "Too many items piled up in the awaiting QA", type: "Negative" }
        , { retrospectiveName: "Retrospective 1", personName: "Mike", body: "We should be looking to start using VS2015", type: "Idea" }];

        //feedbacksResource.query({retrospective: "Retrospective1" }, function (data) {
        //    vm.feedbacks = data;
        //});

        vm.addFeedback = function () {
            $state.go('feedbackAdd');
        };
    };
}());