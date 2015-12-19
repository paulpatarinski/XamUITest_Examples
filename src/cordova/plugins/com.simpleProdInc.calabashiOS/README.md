[Calabash iOS](https://github.com/calabash/calabash-ios) in your Cordova apps.

#Usage
Add to your project

```
cordova plugin add https://github.com/paulpatarinski/Cordova-Calabash-iOS-Plugin
```

Edit `www/js/index.js` and add the following code inside `onDeviceReady`

```js
if(window.calabash){
    var success = function() {
        console.log("Calabash Server started");
    }

    var failure = function() {
        console.log("Error starting Calabash Server");
    }

    calabash.start(success, failure);
}
```

