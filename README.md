TelerikUI for Xamarin.iOS
---

**Please note that Telerik's UI for iOS is still in beta, their EULA restricts to use it only for testing purpose and it is not allowed use in production.**


Screenshots: http://imgur.com/a/karaC

###Setup Instructions


- Download Telerik UI for iOS from [http://www.telerik.com/ios-ui](http://www.telerik.com/ios-ui)
- Copy TelerikUI from TelerikUI.framework to Desktop/any convenient location 

![Framework Image](http://i.imgur.com/y6PayHg.png)

- Rename TelerikUI to TelerikUI.a
- Add TelerikUI.a to TelerikUI project and set Build action as `ObjcBindingNativeLibrary`
- Finally, Build the project.

_PS: I have not tested all chart types, so you may encounter few exceptions using these bindings. Please create an issue if you get any errors_
