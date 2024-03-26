using System;
using System.Collections.Generic;
using System.Text;
using DecisionTree.CMS.Localization;
using Volo.Abp.Application.Services;

namespace DecisionTree.CMS;

/* Inherit your application services from this class.
 */
public abstract class CMSAppService : ApplicationService
{
    protected CMSAppService()
    {
        LocalizationResource = typeof(CMSResource);
    }
}
