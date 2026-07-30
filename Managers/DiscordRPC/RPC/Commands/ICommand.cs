using kMenu.Managers.DiscordRPC.RPC.Payload;

namespace kMenu.Managers.DiscordRPC.RPC.Commands
{
    internal interface ICommand
	{
		IPayload PreparePayload(long nonce);
	}
}
