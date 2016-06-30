angular.module('project')
    .service('projectService', ['$http', function ($http) {

        this.GetProject = function () {
            return $http.get('api/project')
        };

        this.AddSprint = function (sprint) {
            return $http.post('api/sprint', sprint);
        }

    }]);