/*global cordova, module*/

module.exports = {
	 start: function (successCallback, errorCallback) {
        cordova.exec(successCallback, errorCallback, "CalabashiOSServer", "start", []);
    }
};
