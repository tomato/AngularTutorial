angular.module('project')
    .controller('projectCtrl', ['projectService', function (projectService) {
    var self = this;
    var handleError = function (err) {
        alert(err.data.Message);
    };

    var loadData = function () {
        projectService.GetProject()
        .then(function (data) {
            self.project = data.data;
        })
        .catch(handleError);
    };

    self.addRow = function () {
        self.newSprint = {};
    };

    self.addSprint = function (sprintForm) {
        if (sprintForm.$valid) {
            projectService.AddSprint(self.newSprint)
            .then(function () {
                self.newSprint = null;
                loadData();
            })
            .catch(handleError);
        }
    }

    loadData();
}]);