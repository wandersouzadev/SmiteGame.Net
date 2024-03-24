using System;
using System.Security.Cryptography;
using System.Text;
using SmiteGame.Net.Configuration;

namespace SmiteGame.Net.Helpers
{
    public static class HirezSignatureHelper
    {
        /// <summary>
        /// Creates a timestamp with the format yyyyMMddHHmmss
        /// </summary>
        /// <returns></returns>
        private static string GetTimestamp()
        {
            return DateTime.UtcNow.ToString("yyyyMMddHHmmss");
        }

        /// <summary>
        /// Creates an MD5 hash from a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string CreateMD5Hash(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            bytes = MD5.Create().ComputeHash(bytes);
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        /// <summary>
        /// A distinct signature is required for each API method called.
        /// The signature is created by concatenating several fields and then hashing the result with an MD5 algorithm.
        /// The components of this hash are (in order):
        /// Your devId
        /// The method name being called (eg, “createsession”)
        /// This will not include the ResponseType, just the name of the method.
        /// Your authKey
        /// Current utc timestamp (formatted yyyyMMddHHmmss)
        /// </summary>
        /// <param name="hirezCredentials"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        public static Signature CreateSignature(
            HirezCredentials hirezCredentials,
            string methodName
        )
        {
            string timestamp = GetTimestamp();
            string md5Hash = CreateMD5Hash(
                hirezCredentials.ApiKey + methodName + hirezCredentials.DevId + timestamp
            );
            return new Signature(md5Hash, timestamp);
        }
    }
}
