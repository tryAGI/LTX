#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace LTX.CLI.Commands;

internal static partial class RetakeVideoSectionCommandApiCommand
{
    private static Option<string> VideoUri { get; } = new(
        name: @"--video-uri")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::LTX.LtxModel> Model { get; } = new(
        name: @"--model")
    {
        Description = @"",
        Required = true,
    };

    private static Option<float> StartTime { get; } = new(
        name: @"--start-time")
    {
        Description = @"",
        Required = true,
    };

    private static Option<float> EndTime { get; } = new(
        name: @"--end-time")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::LTX.RetakeRequestMode?> Mode { get; } = new(
        name: @"--mode")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

    public static Command Create()
    {
        var command = new Command(@"retake-video-section", @"Regenerate a selected section of an existing video.");
                        command.Options.Add(VideoUri);
                        command.Options.Add(Prompt);
                        command.Options.Add(Model);
                        command.Options.Add(StartTime);
                        command.Options.Add(EndTime);
                        command.Options.Add(Mode);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::LTX.RetakeRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::LTX.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var videoUri = parseResult.GetRequiredValue(VideoUri);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var model = parseResult.GetRequiredValue(Model);
                        var startTime = parseResult.GetRequiredValue(StartTime);
                        var endTime = parseResult.GetRequiredValue(EndTime);
                        var mode = CliRuntime.WasSpecified(parseResult, Mode) ? parseResult.GetValue(Mode) : __requestBase is not null ? __requestBase.Mode : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.RetakeVideoSectionAsync(
                                    videoUri: videoUri,
                                    prompt: prompt,
                                    model: model,
                                    startTime: startTime,
                                    endTime: endTime,
                                    mode: mode,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}