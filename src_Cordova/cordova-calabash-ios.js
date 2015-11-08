var xcode = require('xcode'),
    _ = require('underscore'),
    fs = require('fs-extra'),
    path = require('path'),
    projectPath = 'platforms/ios/Your ProjectName.xcodeproj/project.pbxproj',
    myProj = xcode.project(projectPath);
fullpath = (__dirname + '/platforms/ios/' );

console.log('adding frameworks');
myProj.parse(function (err) {
    myProj.addFramework('CFNetwork.framework');
    console.log(fullpath + 'calabash.framework');
    myProj.addFramework(fullpath + 'calabash.framework', {customFramework: true});
    fs.writeFileSync(projectPath, myProj.writeSync());
    console.log('new project written');
});


console.log('adding build flags');
myProj.parse(function (err) {

    var obj = myProj.pbxXCBuildConfigurationSection();
    for (var key in obj) {
        if (!_.isEmpty(obj[key]['buildSettings'])) {
            if (!_.isEmpty(obj[key]['buildSettings']['OTHER_LDFLAGS']) && !_.isEmpty(obj[key]['buildSettings']['INFOPLIST_FILE'])) {

                console.log('*****************');
                var flags = obj[key]['buildSettings']['OTHER_LDFLAGS'];
                console.log(flags.indexOf('"\\"$(SRCROOT)/calabash.framework/calabash\\""'));
                console.log(flags);
                if (flags.indexOf('"\\"$(SRCROOT)/calabash.framework/calabash\\""') == -1) {
                    flags.push('"-force_load"');
                    flags.push('"\\"$(SRCROOT)/calabash.framework/calabash\\""');
                    flags.push('"-lstdc++"');
                    fs.writeFileSync(projectPath, myProj.writeSync());
                }
            }
        }
    }

    fs.writeFileSync(projectPath, myProj.writeSync());

});