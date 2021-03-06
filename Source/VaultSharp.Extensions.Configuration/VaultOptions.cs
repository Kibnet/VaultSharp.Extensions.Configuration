namespace VaultSharp.Extensions.Configuration
{
    /// <summary>
    /// Vault options class.
    /// </summary>
    public class VaultOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultOptions"/> class.
        /// </summary>
        /// <param name="vaultAddress">Vault address.</param>
        /// <param name="vaultToken">Vault token.</param>
        /// <param name="vaultSecret">Vault secret.</param>
        /// <param name="vaultRoleId">Vault Role ID.</param>
        public VaultOptions(string vaultAddress, string? vaultToken, string? vaultSecret = null, string? vaultRoleId = null)
        {
            this.VaultAddress = vaultAddress;
            this.VaultToken = vaultToken;
            this.VaultSecret = vaultSecret;
            this.VaultRoleId = vaultRoleId;
        }

        /// <summary>
        /// Gets Vault URL address.
        /// </summary>
        public string VaultAddress { get; }

        /// <summary>
        /// Gets Vault access token. Used for token-based authentication.
        /// </summary>
        public string? VaultToken { get; }

        /// <summary>
        /// Gets Vault secret. Used for role-based authentication.
        /// </summary>
        public string? VaultSecret { get; }

        /// <summary>
        /// Gets Vault role identifier. Used for role-based authentication.
        /// </summary>
        public string? VaultRoleId { get; }
    }
}
