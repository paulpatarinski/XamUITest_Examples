cordova.define("com.telerik.LiveSync.livesync", function(require, exports, module) { var exec = require('cordova/exec');

 module.exports = {
    sync: function(successCallback, errorCallback) {
        exec(successCallback, errorCallback, "LiveSync", "sync", []);
    },
    
    enable: function() {
        exec(null, null, "LiveSync", "enable", []);
    },

    disable: function() {
        exec(null, null, "LiveSync", "disable", []);
    }
};

});
