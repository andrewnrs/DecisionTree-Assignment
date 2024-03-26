using DecisionTree.CMS.Samples;
using Xunit;

namespace DecisionTree.CMS.EntityFrameworkCore.Domains;

[Collection(CMSTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CMSEntityFrameworkCoreTestModule>
{

}
