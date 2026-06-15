#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace LTX.CLI.Commands;

internal static partial class CreateTextToVideoCommandApiCommand
{
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

    private static Option<int> Duration { get; } = new(
        name: @"--duration")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Resolution { get; } = new(
        name: @"--resolution")
    {
        Description = @"",
        Required = true,
    };

    private static Option<int?> Fps { get; } = new(
        name: @"--fps")
    {
        Description = @"",
    };

    private static Option<bool?> GenerateAudio { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--generate-audio",
        description: @"");

    private static Option<long?> Seed { get; } = new(
        name: @"--seed")
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
        var command = new Command(@"create-text-to-video", @"Generate a video from a text prompt.");
                        command.Options.Add(Prompt);
                        command.Options.Add(Model);
                        command.Options.Add(Duration);
                        command.Options.Add(Resolution);
                        command.Options.Add(Fps);
                        command.Options.Add(GenerateAudio);
                        command.Options.Add(Seed);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::LTX.TextToVideoRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::LTX.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var model = parseResult.GetRequiredValue(Model);
                        var duration = parseResult.GetRequiredValue(Duration);
                        var resolution = parseResult.GetRequiredValue(Resolution);
                        var fps = CliRuntime.WasSpecified(parseResult, Fps) ? parseResult.GetValue(Fps) : (__requestBase is { } __FpsBaseValue ? __FpsBaseValue.Fps : default);
                        var generateAudio = CliRuntime.WasSpecified(parseResult, GenerateAudio) ? parseResult.GetValue(GenerateAudio) : (__requestBase is { } __GenerateAudioBaseValue ? __GenerateAudioBaseValue.GenerateAudio : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateTextToVideoAsync(
                                    prompt: prompt,
                                    model: model,
                                    duration: duration,
                                    resolution: resolution,
                                    fps: fps,
                                    generateAudio: generateAudio,
                                    seed: seed,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}