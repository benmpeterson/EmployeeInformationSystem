appEIS.factory('employeeMgmtService', function ($http) {
    empMgmtObj = {};

    empMgmtObj.getAll = function () {
        var Emps;

        Emps = $http({ method: 'Get', url: 'http://localhost:53019/api/Employee' }).
            then(function (response) {
                return response.data;
            });
        return Emps;
    };


    empMgmtObj.createEmployee = function (emp) {
        var Emp;

        Emp = $http({ method: 'Post', url: 'http://localhost:53019/api/Employee', data: emp }).
            then(function (response) {

                return response.data;

            }, function (error) {
                return error.data
            });

        return Emp;

    };


    return empMgmtObj;
});




appEIS.controller('employeeMgmtController', function ($scope, employeeMgmtService) {
    $scope.msg = "Welcome To Mgmt"

    employeeMgmtService.getAll().then(function (result) {
        $scope.Emps = result;
    });

    $scope.CreateEmployee = function (Emp) {
        employeeMgmtService.createEmployee(Emp).then(function (result) {
            $scope.Msg = "You have successfully created " + result.EmployeeId;
        })
    }

    $scope.Sort = function (col) {
        $scope.key = col;
        $scope.AscOrDesc = !$scope.AscOrDesc;
    }
})

