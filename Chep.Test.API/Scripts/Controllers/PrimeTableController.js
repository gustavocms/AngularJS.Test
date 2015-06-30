var PrimesApp = angular.module('PrimesApp', ['PrimesServices', 'PrimesControllers']);

var PrimesServices = angular.module('PrimesServices', ['ngResource']);

PrimesServices.factory('Primes', ['$resource',
  function ($resource) {
      return $resource('/api/PrimeNumbers/:action', {
          number: '@number',
          start: '@start',
          end: '@end'
          }, {
              IsPrimeNumber: { method: 'GET', params: { action: 'IsPrimeNumber' }, isArray: false },
              ListPrimeNumbers: { method: 'GET', params: { action: 'ListPrimeNumbers' }, isArray: true }
          });
  }]);

var PrimesControllers = angular.module('PrimesControllers', []);

PrimesControllers.controller('PrimeTableCtrl', ['$scope', 'Primes', function ($scope, Primes) {
    $scope.requestModel = {
        columns: "",
        start: "",
        end: ""
    }

    $scope.generateTable = function () {
        Primes.IsPrimeNumber({ number: $scope.requestModel.start }).$promise.then(function (data) {
            if (!data) {
                alert('Invalid start number. Must be a prime number');
            }
            else {
                Primes.IsPrimeNumber({ number: $scope.requestModel.end }).$promise.then(function (data) {
                    if (!data) {
                        alert('Invalid end number. Must be a prime number');
                    }
                    else {
                        Primes.ListPrimeNumbers({ start: $scope.requestModel.start, end: $scope.requestModel.end }).$promise.then(function (data) {
                            var cols = $scope.requestModel.columns
                            var rows = Math.ceil(data.length / cols);
                            var result = [];
                            var i = 0;

                            for (r = 0; r < rows; r++) {
                                var row = [];

                                for (c = 0; c < cols; c++) {
                                    if (i < data.length) {
                                        row.push(data[i]);
                                        i++;
                                    }
                                }

                                result.push(row);
                            }

                            $scope.primes = result;
                        });
                    }
                });
            }
        });
    }
}]);

