cordova.define("com.simpleProdInc.calabashiOS.calabashiOS", function(require, exports, module) { /*global cordova, module*/

module.exports = {
	 start: function (successCallback, errorCallback) {
        cordova.exec(successCallback, errorCallback, "CalabashiOSServer", "start", []);
    }
};

});
