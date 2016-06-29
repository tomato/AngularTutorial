app = angular.module('projectApp', []);

app.controller('projectCtrl', ['$http', function ($http) {
    var self = this;

    $http.get('api/project')
    .then(function (data) {
        self.project = data.data;
    })
    .catch(function (err) {
        alert(err.data.Message);
    });
}]);