using System.Collections.Generic;
using FluentAssertions;
using UGenerate.Core;
using UGenerate.Tests.Core.TestSupport;
using Umbraco.Core.Models;
using Xunit;

namespace UGenerate.Tests.Core
{
    public class ContentTypeClassGeneratorTests
    {
        [Fact]
        public void should_generate_class()
        {
            var module = new Module("", "MyNamespace", "Models\\Generated");
            var dataType = new DataTypeDefinition("datatype1") {};
            var propertyType = new PropertyType(dataType)
            {
                Id = 1,
                Alias = "Property1",
                DataTypeDefinitionId = 1
            };
            var contentType = new TestContentType(new List<PropertyType> {propertyType}) { Alias = "ContentType1" };
            var unit = new ContentTypeClassGenerator().GenerateClass(contentType, module);
            unit.Should().NotBeNull();
            unit.Namespaces.Should().HaveCount(1);
            unit.Namespaces[0].Types.Should().HaveCount(1);
            var @class = unit.Namespaces[0].Types[0];
            @class.Name.Should().Be(contentType.Alias);
        }
    }
}
