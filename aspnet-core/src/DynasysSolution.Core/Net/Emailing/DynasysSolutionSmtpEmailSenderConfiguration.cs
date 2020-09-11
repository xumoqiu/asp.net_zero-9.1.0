﻿using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace DynasysSolution.Net.Emailing
{
    public class DynasysSolutionSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public DynasysSolutionSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}