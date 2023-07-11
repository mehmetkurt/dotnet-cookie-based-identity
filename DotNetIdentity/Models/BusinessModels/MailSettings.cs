using DotNetIdentity.Services.SettingsService;

namespace DotNetIdentity.Models.BusinessModels {
    /// <summary>
    /// class to define a ail settings object
    /// </summary>
    public class MailSettings : AppSettingsBase{
        /// <summary>
        /// property Username - string is already nullable
        /// </summary>
        /// <value>string</value>
        public string Username { get; set; }
        /// <summary>
        /// property Password -string is already nullable
        /// </summary>
        /// <value>string</value>
        public string Password { get; set; }
        /// <summary>
        /// property SmtpServer -string is already nullable
        /// </summary>
        /// <value>string</value>
        public string SmtpServer { get; set; }
        /// <summary>
        /// property SmtpPort -string is already nullable
        /// </summary>
        /// <value>string</value>
        public string SmtpPort { get; set; }
        /// <summary>
        /// property SmtpFromAddress -string is already nullable
        /// </summary>
        /// <value>string</value>
        public string SmtpFromAddress {get; set;}
        /// <summary>
        /// property SmtpUseTls
        /// </summary>
        /// <value>bool</value>
        public bool SmtpUseTls { get; set; }
    }
}
