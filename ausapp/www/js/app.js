// Ionic Starter App

// angular.module is a global place for creating, registering and retrieving Angular modules
// 'starter' is the name of this angular module example (also set in a <body> attribute in index.html)
// the 2nd parameter is an array of 'requires'
// 'starter.controllers' is found in controllers.js
angular.module('starter', ['ionic', 'starter.controllers'])

.run(function($ionicPlatform) {
  $ionicPlatform.ready(function() {
    // Hide the accessory bar by default (remove this to show the accessory bar above the keyboard
    // for form inputs)
    if (window.cordova && window.cordova.plugins.Keyboard) {
      cordova.plugins.Keyboard.hideKeyboardAccessoryBar(true);
      cordova.plugins.Keyboard.disableScroll(true);

    }
    if (window.StatusBar) {
      // org.apache.cordova.statusbar required
      StatusBar.styleDefault();
    }
  });
})

.config(function($stateProvider, $urlRouterProvider) {
  $stateProvider



    .state('login', {
    url: '/login',
    templateUrl: 'templates/login.html',
    controller: 'LoginCtrl'
  })


    .state('signup', {
    url: '/signup',
    templateUrl: 'templates/signup.html',
  })



    .state('app', {
    url: '/app',
    abstract: true,
    templateUrl: 'templates/menu.html',
    controller: 'AppCtrl'
  })


    .state('app.fooditems', {
    url: '/fooditems',
    views: {
      'menuContent': {
        templateUrl: 'templates/fooditems.html'
      }
    }
  })
      .state('app.babycare', {
          url: '/babycare',
          views: {
              'menuContent': {
                  templateUrl: 'templates/babycare.html'
              }
          }
      })
      .state('app.pharmacy', {
          url: '/pharmacy',
          views: {
              'menuContent': {
                  templateUrl: 'templates/pharmacy.html'
              }
          }
      })
      .state('app.frozenfoods', {
          url: '/frozenfoods',
          views: {
              'menuContent': {
                  templateUrl: 'templates/frozenfoods.html'
              }
          }
      })

      .state('app.household', {
          url: '/household',
          views: {
              'menuContent': {
                  templateUrl: 'templates/household.html'
              }
          }
      })
      .state('app.beverages', {
          url: '/beverages',
          views: {
              'menuContent': {
                  templateUrl: 'templates/beverages.html'
              }
          }
      })

      .state('app.fashion', {
          url: '/fashion',
          views: {
              'menuContent': {
                  templateUrl: 'templates/fashion.html'
              }
          }
      })  .state('app.stores', {
    url: '/stores',
    views: {
      'menuContent': {
        templateUrl: 'templates/stores.html'
      }
    }
  })
  
    .state('app.categories', {
      url: '/categories',
      views: {
        'menuContent': {
          templateUrl: 'templates/categories.html'
        }
      }
    })



  .state('app.location', {
      url: '/location',
      views: {
        'menuContent': {
          templateUrl: 'templates/location.html'
        }
      }
    })

    .state('app.dashboard', {
      url: '/dashboard',
      views: {
        'menuContent': {
          templateUrl: 'templates/dashboard.html',
          controller: 'PlaylistCtrl'
        }
      }
    })



  .state('app.single', {
    url: '/playlists/:playlistId',
    views: {
      'menuContent': {
        templateUrl: 'templates/playlist.html',
        controller: 'PlaylistCtrl'
      }
    }
  });
  // if none of the above states are matched, use this as the fallback
  $urlRouterProvider.otherwise('/login');
});

