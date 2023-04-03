using OldMutual.SmartCopierTool.Debugging;

namespace OldMutual.SmartCopierTool
{
    public class SmartCopierToolConsts
    {
        public const string LocalizationSourceName = "SmartCopierTool";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "fd5d8ee3afe043dbbf0bd475d9df8f46";
    }
}
