using Xunit;

namespace DecisionTree.CMS.EntityFrameworkCore;

[CollectionDefinition(CMSTestConsts.CollectionDefinitionName)]
public class CMSEntityFrameworkCoreCollection : ICollectionFixture<CMSEntityFrameworkCoreFixture>
{

}
