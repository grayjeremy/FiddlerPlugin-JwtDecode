# FiddlerJwtDecode

This project was heavily influenced by [Andrew Connell's SPOAuthFiddlerExt](https://github.com/andrewconnell/SPOAuthFiddlerExt).  By heavily influenced, I mean portions of it are the same....exactly the same.  I strongly suggest you check out his work and read [his article around this plugin](http://blogs.msdn.com/b/kaevans/archive/2013/08/25/creating-a-fiddler-extension-for-sharepoint-2013-app-tokens.aspx).  The plugin that he created goes hand in hand with what I've done. 

I got tired of not being able to read jwt responses within fiddler so I created this response inspector to decode jwt's within a fiddler response.

## Installation Instructions
Copy the following dll's into the 'Inspectors' folder of your fiddler installation

 * FiddlerJwtDecode.dll
 * Newtonsoft.Json.dll
 
 You should see a new tab that says "JWT Decode" in the response pane of the inspectors tab.  Also, don't forget to check out "SPOAuth" which is also circled in red. 

 ![Image of JWT Decode](https://raw.githubusercontent.com/grayjeremy/FiddlerJwtDecode/master/screenshot.png)

