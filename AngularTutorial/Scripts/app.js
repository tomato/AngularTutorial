app = angular.module('projectApp', []);

app.controller('projectCtrl', ['$http', function ($http) {
    var self = this;
    var handleError = function (err) {
        alert(err.data.Message);
    };

    var loadData = function () {
        $http.get('api/project')
        .then(function (data) {
            self.project = data.data;
        })
        .catch(handleError);
    };

    self.addRow = function () {
        self.newSprint = {};
    };

    self.addSprint = function () {
        $http.post('api/sprint', self.newSprint)
        .then(function () {
            self.newSprint = null;
            loadData();
        })
        .catch(handleError);
    }

    loadData();
}]);