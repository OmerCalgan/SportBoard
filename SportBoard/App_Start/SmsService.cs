using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

public class SmsService : IIdentityMessageService
{
    public Task SendAsync(IdentityMessage message)
    {
        // SMS göndermek için kodunuzu buraya ekleyin.
        return Task.FromResult(0);
    }
}
