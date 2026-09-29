#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace LTX.CLI.Commands;

internal static partial class CreateAudioToVideoCommandApiCommand
{
    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"",
    };

    private static Option<global::LTX.LtxModel> Model { get; } = new(
        name: @"--model")
    {
        Description = @"",
    };

    private static Option<int> Duration { get; } = new(
        name: @"--duration")
    {
        Description = @"",
    };

    private static Option<string> Resolution { get; } = new(
        name: @"--resolution")
    {
        Description = @"",
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

    private static Option<string> AudioUri { get; } = new(
        name: @"--audio-uri")
    {
        Description = @"HTTPS, data URI, or LTX storage URI for the audio track.",
    };

    private static Option<string?> ImageUri { get; } = new(
        name: @"--image-uri")
    {
        Description = @"Optional reference image URI.",
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

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-audio-to-video", @"Generate a video synchronized to an audio track.");
                        command.Options.Add(Prompt);
                        command.Options.Add(Model);
                        command.Options.Add(Duration);
                        command.Options.Add(Resolution);
                        command.Options.Add(Fps);
                        command.Options.Add(GenerateAudio);
                        command.Options.Add(Seed);
                        command.Options.Add(AudioUri);
                        command.Options.Add(ImageUri);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::LTX.AudioToVideoRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::LTX.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var prompt = (CliRuntime.WasSpecified(parseResult, Prompt)
                            ? parseResult.GetValue(Prompt)
                            : __requestBase.Value1?.Prompt)
                            ?? throw new CliException(@"Specify prompt or include it in the base request body.");
                        var model = (CliRuntime.WasSpecified(parseResult, Model)
                            ? parseResult.GetValue(Model)
                            : __requestBase.Value1?.Model)
                            ?? throw new CliException(@"Specify model or include it in the base request body.");
                        var duration = (CliRuntime.WasSpecified(parseResult, Duration)
                            ? parseResult.GetValue(Duration)
                            : __requestBase.Value1?.Duration)
                            ?? throw new CliException(@"Specify duration or include it in the base request body.");
                        var resolution = (CliRuntime.WasSpecified(parseResult, Resolution)
                            ? parseResult.GetValue(Resolution)
                            : __requestBase.Value1?.Resolution)
                            ?? throw new CliException(@"Specify resolution or include it in the base request body.");
                        var fps = CliRuntime.WasSpecified(parseResult, Fps) ? parseResult.GetValue(Fps) : (__requestBase is { } __FpsBaseValue ? __FpsBaseValue.Value1?.Fps : default);
                        var generateAudio = CliRuntime.WasSpecified(parseResult, GenerateAudio) ? parseResult.GetValue(GenerateAudio) : (__requestBase is { } __GenerateAudioBaseValue ? __GenerateAudioBaseValue.Value1?.GenerateAudio : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Value1?.Seed : default);
                        var audioUri = (CliRuntime.WasSpecified(parseResult, AudioUri)
                            ? parseResult.GetValue(AudioUri)
                            : __requestBase.Value2?.AudioUri)
                            ?? throw new CliException(@"Specify audio_uri or include it in the base request body.");
                        var imageUri = CliRuntime.WasSpecified(parseResult, ImageUri) ? parseResult.GetValue(ImageUri) : (__requestBase is { } __ImageUriBaseValue ? __ImageUriBaseValue.Value2?.ImageUri : default);
                        var __component1 = __requestBase.Value1 ?? new global::LTX.TextToVideoRequest { Prompt = prompt!, Model = model!, Duration = duration!, Resolution = resolution! };
                        __component1.Prompt = prompt;
                        __component1.Model = model;
                        __component1.Duration = duration;
                        __component1.Resolution = resolution;
                        __component1.Fps = fps;
                        __component1.GenerateAudio = generateAudio;
                        __component1.Seed = seed;

                        var __component2 = __requestBase.Value2 ?? new global::LTX.AudioToVideoRequestVariant2 { AudioUri = audioUri! };
                        __component2.AudioUri = audioUri;
                        __component2.ImageUri = imageUri;

                        if (CliRuntime.WasSpecified(parseResult, AudioUri))
                        {
                            __component1.AdditionalProperties?.Remove(@"audio_uri");
                        }
                        if (CliRuntime.WasSpecified(parseResult, ImageUri))
                        {
                            __component1.AdditionalProperties?.Remove(@"image_uri");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Prompt))
                        {
                            __component2.AdditionalProperties?.Remove(@"prompt");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Model))
                        {
                            __component2.AdditionalProperties?.Remove(@"model");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Duration))
                        {
                            __component2.AdditionalProperties?.Remove(@"duration");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Resolution))
                        {
                            __component2.AdditionalProperties?.Remove(@"resolution");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Fps))
                        {
                            __component2.AdditionalProperties?.Remove(@"fps");
                        }
                        if (CliRuntime.WasSpecified(parseResult, GenerateAudio))
                        {
                            __component2.AdditionalProperties?.Remove(@"generate_audio");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Seed))
                        {
                            __component2.AdditionalProperties?.Remove(@"seed");
                        }
                        var request = new global::LTX.AudioToVideoRequest(
                            __component1, __component2);

                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateAudioToVideoAsync(

                                    request: request,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}