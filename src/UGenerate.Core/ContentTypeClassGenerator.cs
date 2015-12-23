using System.CodeDom;
using System.CodeDom.Compiler;
using System.Text;
using Umbraco.Core.Models;
using Umbraco.Core.Persistence.Migrations.Upgrades.TargetVersionSeven;
using Umbraco.Core.Services;

namespace UGenerate.Core
{
    public class ContentTypeClassGenerator
    {
        private readonly IContentTypeService contentTypeService;

        public ContentTypeClassGenerator(IContentTypeService contentTypeService)
        {
            contentTypeService = contentTypeService;
        }

        public CodeCompileUnit GenerateClass(IContentType contentType, Module module)
        {
            var unit = new CodeCompileUnit();

            var ns = new CodeNamespace(module.Namespace);
            ns.Imports.Add(new CodeNamespaceImport("System"));
            
            unit.Namespaces.Add(ns);
            string className = contentType.Alias;
            var c = new CodeTypeDeclaration(className);

            // inherit
            var parent = contentType.ParentId != 0 ? contentTypeService.GetContentType(contentType.ParentId) : null;
            if (parent != null)
            {
                c.BaseTypes.Add(new CodeTypeReference(parent.Alias));
            }

            // compositions

            foreach (var propertyType in contentType.PropertyTypes)
            {
                AddProperty(c, propertyType);
            }
            ns.Types.Add(c);
            
            return unit;
        }

        private void AddProperty(CodeTypeDeclaration @class, PropertyType propertyType)
        {
            var property = new CodeMemberProperty()
            {
                Name = propertyType.Alias,
                Type = new CodeTypeReference(typeof(string)),
            };
            property.GetStatements.Add(new CodeMethodReturnStatement(new CodePrimitiveExpression("Property1")));
            @class.Members.Add(property);
        }
    }
}