(function () {
    "use strict"
    var app = angular.module("scrumManagement", ["common.services","ui.router"]);

    app.config(["$stateProvider", "$urlRouterProvider", function ($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise("/retrospectivesList");
        $stateProvider
            .state("retrospectivesList", {
                url: "/retrospectivesList",
                templateUrl: "app/retrospectives/retrospectivesListView.html",
                controller: "RetrospectivesListCtrl as vm"
            })
            .state("retrospectiveAdd", {
                url: "/retrospectiveAdd",
                templateUrl: "app/retrospectives/retrospectiveAddView.html",
                controller: "RetrospectiveAddCtrl as vm"
            })
            .state("feedbacksList", {
                url: "/feedbacksList",
                templateUrl: "app/feedbacks/feedbacksListView.html",
                controller: "FeedbacksListCtrl as vm"
            })
            .state("feedbackAdd", {
                url: "/feedbackAdd",
                templateUrl: "app/feedbacks/feedbackAddView.html",
                controller: "FeedbackAddCtrl as vm"
            })
    }]);
}());