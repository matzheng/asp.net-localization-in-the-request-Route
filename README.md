# asp.net localization in the Route
## 4 key things to change
1. LocalizationResources.Resources.resx /  LocalizationResources.Resources.*.resx
2. Register the culture in the Route
```csharp
 routes.MapRoute(
                name: "InternationalDefault",
                url: "{culture}/{controller}/{action}/{id}",
                defaults: new { culture = Helpers.CultureHelper.GetDefaultCulture(), controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
```
3. Generate a basecontroller which checks culture in RouteData before Excution
```csharp
public class BaseController : Controller
    {
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            string cultureName = (string)RouteData.Values["culture"] ?? "en-US";

            cultureName = Helpers.CultureHelper.GetNeutralCulture(cultureName);

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(cultureName);
            return base.BeginExecuteCore(callback, state);
        }
    } 
```
4. Userattrubutes lik 'ErrorMessageResourceType' in your Model.
```csharp
public class LoginUser
    {
        [Required(ErrorMessageResourceType = typeof(LocalizationResources.Resources), ErrorMessageResourceName = "user_name_required")]
        [Display(ResourceType = typeof(LocalizationResources.Resources), Name = "user_name")]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required(ErrorMessageResourceType = typeof(LocalizationResources.Resources), ErrorMessageResourceName = "password_required")]
        [Display(ResourceType = typeof(LocalizationResources.Resources), Name = "password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessageResourceType = typeof(LocalizationResources.Resources), ErrorMessageResourceName = "email_required")]
        [Display(ResourceType = typeof(LocalizationResources.Resources), Name = "email")]
        [MaxLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
```

## reference:
http://afana.me/archive/2011/01/14/aspnet-mvc-internationalization.aspx/
https://stackoverflow.com/questions/36353265/asp-net-mvc-localization-of-validation-messages
