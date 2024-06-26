﻿#nullable enable

namespace OpenMails.Models
{
    /// <summary>
    /// 发件人或收件人
    /// </summary>
    public class Recipient
    {
        private static string GetDisplayNameFromEmailAddress(string address)
        {
            int end = address.IndexOf('@');

            if (end < 0)
                return address;

            return address.Substring(0, end);
        }

        public Recipient(
            string emailAddress,
            string? displayName)
        {
            EmailAddress = emailAddress;
            DisplayName = displayName ?? GetDisplayNameFromEmailAddress(emailAddress);
        }

        public string EmailAddress { get; }
        public string DisplayName { get; }
    }
}
