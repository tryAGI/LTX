# Text-to-video

Generate an MP4 video from a text prompt using LTX.

This example assumes `using LTX;` is in scope and `apiKey` contains your LTX API key.

```csharp
using var client = new LtxClient(apiKey);

var video = await client.CreateTextToVideoAsync(new TextToVideoRequest
{
    Prompt = "A majestic eagle soaring through clouds at sunset.",
    Model = LtxModel.Ltx23Pro,
    Duration = 8,
    Resolution = "1920x1080",
    GenerateAudio = true,
});
```