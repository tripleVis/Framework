using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using TraderBox.io.Model;

namespace TraderBox.io.Util
{
    internal class TestDataReader
    {
        public static TestsSettings GetTestsSettings()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName)
                .AddJsonFile("TraderBox.io/Resources/data.json").Build();

            var section = config.GetSection(nameof(TestsSettings));

            var testsSettings = section.Get<TestsSettings>();

            return testsSettings;
        }
    }
}
