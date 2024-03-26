using DecisionTree.CMS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DecisionTree.CMS.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CMSController : AbpControllerBase
{
    protected CMSController()
    {
        LocalizationResource = typeof(CMSResource);
    }
}
