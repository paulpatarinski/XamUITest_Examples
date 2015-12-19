#import "CalabashiOSServer.h"
#import <calabash/CalabashServer.h>

@implementation CalabashiOSServer

- (void)start:(CDVInvokedUrlCommand*)command
{
 	CDVPluginResult* pluginResult = nil;

	@try {
	    [CalabashServer start];
        pluginResult = [CDVPluginResult resultWithStatus:CDVCommandStatus_OK];
	 }
	 @catch (NSException * e) {
	    NSLog(@"Exception: %@", e);
        pluginResult = [CDVPluginResult resultWithStatus:CDVCommandStatus_ERROR messageAsString: e.reason];
	 }
   
    [self.commandDelegate sendPluginResult:pluginResult callbackId:command.callbackId];
}

@end