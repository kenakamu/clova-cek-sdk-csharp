using Newtonsoft.Json;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// クライアントデバイスに認証されたのデフォルトユーザーの情報を持っているオブジェクト
    /// </summary>
    public class User
    {
        /// <summary>
        /// デバイスのデフォルトユーザーのClova ID
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }
        /// <summary>
        /// 特定のサービスのユーザーアカウントのアクセストークン。デバイスのデフォルトユーザーと連携されたユーザーアカウントのアクセストークンが渡されます。CEKは、外部サービスの認可サーバーから取得したユーザーアカウントのアクセストークンを渡します。詳細については、ユーザーアカウントを連携する https://clova-developers.line.me/guide/#/CEK/Guides/Link_User_Account.md を参照してください。
        /// </summary>
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
    }
}
