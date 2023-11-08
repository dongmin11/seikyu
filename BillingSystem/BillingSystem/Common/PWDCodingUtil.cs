using System;
using System.Security.Cryptography;
using System.Text;

namespace BillingSystem
{
    public class PWDCodingUtil
    {
        private static string pwdKey = System.Configuration.ConfigurationManager.AppSettings["PwdKey"];

        private static AesManaged aes;

        # region Const
        private const string AesIV = @"!QAZ2WSX#EDC4RFV";
        private const string AesKey = "IwSa1N@8aSEFu!Is";
        # endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        static PWDCodingUtil()
        {
            aes = new AesManaged();
            aes.BlockSize = 128;
            aes.KeySize = 128;
            aes.IV = Encoding.UTF8.GetBytes(AesIV);

            var bytesPassword = Encoding.UTF8.GetBytes(AesKey);
            // 有効なKeyサイズに調整する
            var bytesKey = new byte[16];
            bytesPassword.CopyTo(bytesKey, 0);

            aes.Key = bytesKey;
        }

        /// <summary>
        /// 文字列をAESで暗号化
        /// </summary>
        public static string Encrypt(string str)
        {
            // 文字列をバイト型配列に変換
            byte[] src = Encoding.Unicode.GetBytes(str + pwdKey);

            // 暗号化する
            using (ICryptoTransform encrypt = aes.CreateEncryptor())
            {
                var dest = encrypt.TransformFinalBlock(src, 0, src.Length);

                // バイト型配列からBase64形式の文字列に変換
                return Convert.ToBase64String(dest);
            }
        }

        /// <summary>
        /// 文字列をAESで復号化
        /// </summary>
        public static string Decrypt(string str)
        {
            // Base64形式の文字列からバイト型配列に変換
            var src = System.Convert.FromBase64String(str);

            // 複号化する
            using (ICryptoTransform decrypt = aes.CreateDecryptor())
            {
                var dest = decrypt.TransformFinalBlock(src, 0, src.Length);
                var value = Encoding.Unicode.GetString(dest, 0, dest.Length);

                return value.Substring(0, value.Length - pwdKey.Length);
            }
        }
    }
}
