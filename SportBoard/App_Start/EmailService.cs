using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

public class EmailService : IIdentityMessageService
{
    public Task SendAsync(IdentityMessage message)
    {
        // Email göndermek için kodunuzu buraya ekleyin.
        return Task.FromResult(0);
    }
}
