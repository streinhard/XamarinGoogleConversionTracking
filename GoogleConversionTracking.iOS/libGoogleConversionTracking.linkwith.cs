using ObjCRuntime;

[assembly: LinkWith("libGoogleConversionTracking.a", Frameworks = "AdSupport", SmartLink = true, ForceLoad = true)]
