namespace Common
{
    public class ConstCommon
    {
        #region INIファイルパス    
        /// <summary>
        /// INIファイルパス(システム)
        /// </summary>
        public const string INI_PATH = "/Ini/Training.ini";
        /// <summary>
        /// INIファイルパス(メッセージ)
        /// </summary>
        public const string INI_PATH_MSG = "/Ini/Message.ini";
        #endregion

        #region DB接続関連       
        /// <summary>
        /// コレクション
        /// </summary>
        public const string CONNECTION = "CONNECTION";
        /// <summary>
        /// DB接続文字列
        /// </summary>
        public const string CONNECTIONSTRING = "CONNECTIONSTRING";
        #endregion

        #region メッセージ関連
        /// <summary>
        /// セクションキー
        /// </summary>
        public const string MESSAGE = "MESSAGE";
        /// <summary>
        /// ユーザーIDまたはパスワードが正しくありません。
        /// </summary>
        public const string IMG0001 = "IMG0001";
        /// <summary>
        /// {0}を入力して下さい。
        /// </summary>
        public const string IMG0002 = "IMG0002";
        /// <summary>
        /// 該当データが存在しません。
        /// </summary>
        public const string IMG0003 = "IMG0003";

        /// <summary>
        /// システムエラーが発生しました。システム管理者に連絡してください。
        /// </summary>
        public const string IMG9999 = "IMG9999";
        #endregion

        #region コードリスト
        /// <summary>
        /// テスト
        /// </summary>
        public const string CODELIST_KINDID_0000 = "0000";
        #endregion

        #region その他
        /// <summary>
        /// ハッシュテーブルキー
        /// </summary>
        public const string RESULT = "Result";
        #endregion
    }
}
