var module = angular.module('mycustomersApp', []);

module.controller('customersCtrl', function ($scope, $http) {

    // Get customer list
    $http.get("/api/customerapi")
    .success(function (response) {
        $scope.Customer = response
    });
    // Initial 
    $scope.edit = true;
    $scope.error = false;
    $scope.incomplete = false;
    // Edit
    $scope.editCustomer = function (id) {
        if (id == 'new') {
            $scope.edit = true;
            $scope.incomplete = true;
            $scope.ID = 0;
            $scope.Name = '';
            $scope.Phone = '';
            $scope.Address = '';
            $scope.Email = '';
        } else {

            $scope.edit = false;
            $scope.ID = $scope.Customer[id].ID;
            $scope.Name = $scope.Customer[id].Name.trim();
            $scope.Phone = $scope.Customer[id].Phone.trim();
            $scope.Address = $scope.Customer[id].Address.trim();
            $scope.Email = $scope.Customer[id].Email.trim();

            $("#idEmail").val($scope.Email.trim());


            $scope.incomplete = false;
        }
    };
    // Update or add new one  
    $scope.PostCustomer = function () {
        $.post("api/customerapi",
                     $("#cusForm").serialize(),
                     function (value) {

                         // Refresh list
                         $http.get("/api/customerapi")
                         .success(function (response) {
                             $scope.Customer = response
                         });

                         alert("Saved successfully.");
                     },
                     "json"
               );
    }
    // Delete one customer based on id.
    $scope.delCustomer = function (id) {
        if (confirm("Are you sure you want to delete this customer?")) {
            // todo code for deletion
            $http.delete("api/customerapi/" + id).success(function () {
                alert("Deleted successfully.");
                // Refresh list
                $http.get("/api/customerapi")
                .success(function (response) {
                    $scope.Customer = response
                });

            }).error(function () {
                alert("Error.");
            });
        }
    };
});
