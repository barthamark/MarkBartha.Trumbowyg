using System;

namespace MarkBartha.Trumbowyg.Helpers
{
    public static class FieldIdGenerator
    {
        public static string GetRandomFieldId(string prefix = "")
        {
            prefix = string.IsNullOrEmpty(prefix) ? "" : prefix + "-";

            return prefix + Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("=", "").Replace("+", "");
        }
    }
}