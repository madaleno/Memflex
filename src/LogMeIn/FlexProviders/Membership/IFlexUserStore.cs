using System.Collections.Generic;
using Microsoft.Web.WebPages.OAuth;

namespace FlexProviders.Membership
{
    public interface IFlexUserStore
    {        
        IFlexMembershipUser GetUserByUsername(string username);
        IFlexMembershipUser Add(IFlexMembershipUser user);
        IFlexMembershipUser Save(IFlexMembershipUser user);
        bool DeleteOAuthAccount(string provider, string providerUserId);
        IFlexMembershipUser GetUserByOAuthProvider(string provider, string providerUserId);
        IFlexMembershipUser CreateOAuthAccount(string provider, string providerUserId, string username);
        IEnumerable<OAuthAccount> GetOAuthAccountsForUser(string username);
    }    
}