(function () {
    "use strict";
    angular.module("scrumManagement").
        controller("RetrospectivesListCtrl", ["$state", "retrospectivesResource", RetrospectivesListCtrl]);

    function RetrospectivesListCtrl($state, retrospectivesResource) {
        var vm = this;
        vm.searchdate = Date.now();
        retrospectivesResource.query(function (data) {
            vm.retrospectives = data;
        });

        vm.searchbydate = function () {
            retrospectivesResource.query({searchdate: vm.searchdate }, function (data) {
                vm.retrospectives = data;
            });
        };

        vm.viewFeedbacks = function () {
            $state.go('feedbacksList');
        };


    };
}());