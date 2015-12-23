using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Text;
using Xunit;

namespace UGenerate.Tests.Spikes
{
    public class CodeDomExamples
    {
        [Fact]
        public void generate_class()
        {
            var ns = new CodeNamespace("TestNamespace");
            ns.Imports.Add(new CodeNamespaceImport("System"));
            var c = new CodeTypeDeclaration("TestClass");
            var p1 = new CodeMemberProperty()
            {
                Name = "Property1",
                Type = new CodeTypeReference(typeof(string)),
            };
            p1.GetStatements.Add(new CodeMethodReturnStatement(new CodePrimitiveExpression("Property1")));
            c.Members.Add(p1);
            ns.Types.Add(c);
            var unit = new CodeCompileUnit();
            unit.Namespaces.Add(ns);

            var provider = CodeDomProvider.CreateProvider("CSharp");
            var options = new CodeGeneratorOptions
            {
                BlankLinesBetweenMembers = true,
                BracingStyle = "C"
            };

            var output = new StringBuilder();
            using (var writer = new StringWriter(output))
            {
                provider.GenerateCodeFromCompileUnit(unit, writer, options);
                Console.WriteLine(output.ToString());
            }
        } 
    }
}