using Discord.Commands;
using System.Threading.Tasks;

public class ModerationModule : ModuleBase<SocketCommandContext>
{
    [Command("kick")]
    [RequireUserPermission(GuildPermission.KickMembers)]
    public async Task KickUser(SocketGuildUser user, [Remainder] string reason = "No reason provided.")
    {
        await user.KickAsync(reason);
        await ReplyAsync($"{user.Username} has been kicked. Reason: {reason}");
    }

    [Command("ban")]
    [RequireUserPermission(GuildPermission.BanMembers)]
    public async Task BanUser(SocketGuildUser user, [Remainder] string reason = "No reason provided.")
    {
        await user.BanAsync(reason);
        await ReplyAsync($"{user.Username} has been banned. Reason: {reason}");
    }
}
