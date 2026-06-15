#nullable enable

using System.CommandLine;

namespace LTX.CLI.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(CreateAudioToVideoCommandApiCommand.Create());
                         command.Subcommands.Add(CreateImageToVideoCommandApiCommand.Create());
                         command.Subcommands.Add(CreateTextToVideoCommandApiCommand.Create());
                         command.Subcommands.Add(ExtendVideoCommandApiCommand.Create());
                         command.Subcommands.Add(RetakeVideoSectionCommandApiCommand.Create());
                         command.Subcommands.Add(UploadMediaCommandApiCommand.Create());
        return command;
    }
}