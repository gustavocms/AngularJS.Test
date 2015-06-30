var rolesApp = angular.module('RolesApp', ['RolesServices', 'RolesControllers', 'ui.tree']);

var rolesServices = angular.module('RolesServices', ['ngResource']);

rolesServices.factory('Roles', ['$resource',
  function ($resource) {
      return $resource('/api/roles', {}, {
          query: { method: 'GET', params: {}, isArray: true }
      });
  }]);

var rolesControllers = angular.module('RolesControllers', []);

rolesControllers.controller('TreeViewCtrl', ['$scope', 'Roles', function ($scope, Roles) {
    $scope.roles = Roles.query();
}]);

