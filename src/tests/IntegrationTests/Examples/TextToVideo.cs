/*
order: 10
title: Text-to-video
slug: text-to-video

Generate an MP4 video from a text prompt using LTX.
*/

namespace LTX.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TextToVideo()
    {
        using var client = GetAuthenticatedClient();

        var video = await client.CreateTextToVideoAsync(new TextToVideoRequest
        {
            Prompt = "A majestic eagle soaring through clouds at sunset.",
            Model = LtxModel.Ltx23Pro,
            Duration = 8,
            Resolution = "1920x1080",
            GenerateAudio = true,
        });

        video.Should().NotBeEmpty();
    }
}
