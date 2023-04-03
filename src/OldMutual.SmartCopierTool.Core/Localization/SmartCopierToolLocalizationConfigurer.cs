using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace OldMutual.SmartCopierTool.Localization
{
    public static class SmartCopierToolLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SmartCopierToolConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SmartCopierToolLocalizationConfigurer).GetAssembly(),
                        "OldMutual.SmartCopierTool.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
