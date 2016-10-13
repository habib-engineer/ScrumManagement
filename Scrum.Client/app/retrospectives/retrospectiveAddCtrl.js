(function () {
    "use strict";
    angular.module("scrumManagement").
        controller("RetrospectiveAddCtrl", ["retrospectivesResource", RetrospectiveAddCtrl]);

    function RetrospectiveAddCtrl(retrospectivesResource) {
        var vm = this;
        vm.retrospective = {};
        vm.message = '';
        vm.participant = '';
        retrospectivesResource.query({ name: "0" }, function (data) {
            vm.retrospective = data;
            vm.origionalretrospective = angular.copy(data);
        });

        vm.submit = function () {

        var objecttosave = angular.copy(vm.retrospective);
        retrospectivesResource.save(objecttosave, function (data) {
            vm.message = "... Save Complete";
        });
            //vm.retrospective.$save(
            //    function (data) {
            //        vm.message = "... Save Complete";
            //    });
        };

        vm.cancel = function (editForm) {
            editForm.$setPristine();
            vm.retrospective = angular.copy(vm.origionalretrospective);
            vm.message = '';
        };

        vm.addparticipant = function () {
            if (vm.participant) {
                vm.retrospective.participants.push(vm.participant);
            }
        };

    };
}());