using DecisionTree.CMS.Samples;
using Xunit;

namespace DecisionTree.CMS.EntityFrameworkCore.Applications;

[Collection(CMSTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CMSEntityFrameworkCoreTestModule>
{

}
