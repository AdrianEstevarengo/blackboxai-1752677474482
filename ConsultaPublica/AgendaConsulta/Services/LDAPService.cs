using System.DirectoryServices;
using System.Globalization;
using System.Runtime.Versioning;

namespace AgendaConsulta.Services
{
    [SupportedOSPlatform("windows")]
    public class LDAPService
    {
        private readonly string _ldapPath = "LDAP://172.16.0.43";

        public (bool isAuthenticated, string givenName, string surname, string orgao) Authenticate(
            string username,
            string senha
        )
        {
            try
            {
                var dominio = new DirectoryEntry(this._ldapPath, username, senha);
                using (
                    DirectorySearcher searcher =
                        new(
                            dominio,
                            string.Format(
                                CultureInfo.InvariantCulture,
                                "(sAMAccountName={0})",
                                username
                            )
                        )
                )
                {
                    var sr = searcher.FindOne();
                    if (sr == null)
                    {
                        return (false, string.Empty, string.Empty, string.Empty);
                    }

                    var de = sr.GetDirectoryEntry();
                    string givenName =
                        de.Properties["givenName"]?.Value?.ToString() ?? string.Empty;
                    string surname = de.Properties["sn"]?.Value?.ToString() ?? string.Empty;
                    var orgao = string.Empty;
                    var distinguishedName = de.Properties["distinguishedName"]?.Value?.ToString();
                    var partes = distinguishedName.Split(',');
                    var ous = partes
                        .Where(p => p.StartsWith("OU="))
                        .Select(p => p.Replace("OU=", ""))
                        .ToList();

                    // Encontrar o índice de "Executivo"
                    var index = ous.IndexOf("EXECUTIVO");
                    string orgaoAnterior = string.Empty;
                    if (index > 0)
                    {
                        orgaoAnterior = ous[index - 1]; // pega o que vem antes de Executivo
                    }

                    return (true, givenName, surname, orgaoAnterior);
                }
            }
            catch
            {
                return (false, string.Empty, string.Empty, string.Empty);
            }
        }
    }
}
