/**
 * Created by JetBrains WebStorm.
 * User: khan
 * Date: 10/12/16
 * Time: 6:32 PM
 * To change this template use File | Settings | File Templates.
 */
angular.module('starter.services',['ngResource'])
    .factory('Session', function ($resource) {
        return $resource('http://localhost:55604/API/Brands/GetBrands');
    });