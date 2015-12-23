using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models;

namespace UGenerate.Tests.Core.TestSupport
{
    public class TestContentType : IContentType
    {
        public TestContentType(IEnumerable<PropertyType> propertyTypes)
        {
            PropertyTypes = propertyTypes.ToList();
        }

        public object DeepClone()
        {
            throw new NotImplementedException();
        }

        public int Id { get; set; }
        public Guid Key { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool HasIdentity { get; private set; }
        public bool IsDirty()
        {
            throw new NotImplementedException();
        }

        public bool IsPropertyDirty(string propName)
        {
            throw new NotImplementedException();
        }

        public void ResetDirtyProperties()
        {
            throw new NotImplementedException();
        }

        public bool WasDirty()
        {
            throw new NotImplementedException();
        }

        public bool WasPropertyDirty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public void ForgetPreviouslyDirtyProperties()
        {
            throw new NotImplementedException();
        }

        public void ResetDirtyProperties(bool rememberPreviouslyChangedProperties)
        {
            throw new NotImplementedException();
        }

        public int CreatorId { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public string Path { get; set; }
        public int SortOrder { get; set; }
        public bool Trashed { get; private set; }
        public IDictionary<string, object> AdditionalData { get; private set; }
        public void RemovePropertyType(string propertyTypeAlias)
        {
            throw new NotImplementedException();
        }

        public void RemovePropertyGroup(string propertyGroupName)
        {
            throw new NotImplementedException();
        }

        public void SetLazyParentId(Lazy<int> id)
        {
            throw new NotImplementedException();
        }

        public bool PropertyTypeExists(string propertyTypeAlias)
        {
            throw new NotImplementedException();
        }

        public bool AddPropertyType(PropertyType propertyType, string propertyGroupName)
        {
            throw new NotImplementedException();
        }

        public bool AddPropertyType(PropertyType propertyType)
        {
            throw new NotImplementedException();
        }

        public bool AddPropertyGroup(string groupName)
        {
            throw new NotImplementedException();
        }

        public bool MovePropertyType(string propertyTypeAlias, string propertyGroupName)
        {
            throw new NotImplementedException();
        }

        public string Alias { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Thumbnail { get; set; }
        public bool AllowedAsRoot { get; set; }
        public bool IsContainer { get; set; }
        public IEnumerable<ContentTypeSort> AllowedContentTypes { get; set; }
        public PropertyGroupCollection PropertyGroups { get; set; }
        public IEnumerable<PropertyType> PropertyTypes { get; private set; }
        public bool AddContentType(IContentTypeComposition contentType)
        {
            throw new NotImplementedException();
        }

        public bool RemoveContentType(string alias)
        {
            throw new NotImplementedException();
        }

        public bool ContentTypeCompositionExists(string alias)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> CompositionAliases()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> CompositionIds()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IContentTypeComposition> ContentTypeComposition { get; private set; }
        public IEnumerable<PropertyGroup> CompositionPropertyGroups { get; private set; }
        public IEnumerable<PropertyType> CompositionPropertyTypes { get; private set; }
        public void SetDefaultTemplate(ITemplate template)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTemplate(ITemplate template)
        {
            throw new NotImplementedException();
        }

        public IContentType DeepCloneWithResetIdentities(string newAlias)
        {
            throw new NotImplementedException();
        }

        public ITemplate DefaultTemplate { get; private set; }
        public IEnumerable<ITemplate> AllowedTemplates { get; set; }
    }
}