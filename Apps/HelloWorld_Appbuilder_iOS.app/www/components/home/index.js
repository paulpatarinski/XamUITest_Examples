'use strict';

app.home = kendo.observable({
    onShow: function() {},
    afterShow: function() {
           var loginButton =  document.getElementById("loginButton");
            loginButton.addEventListener("click", app.login);
    }
});

app.login = function(){
    alert("Logged In");
};

// START_CUSTOM_CODE_home
// Add custom code here. For more information about custom code, see http://docs.telerik.com/platform/screenbuilder/troubleshooting/how-to-keep-custom-code-changes

// END_CUSTOM_CODE_home