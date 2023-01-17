﻿using FinalTask18.Services;

namespace FinalTask18.Commands
{
    internal class DownloadVideoCommand : ICommand
    {
        public IVideoService videoService { get; private set; }

        public DownloadVideoCommand(IVideoService videoService) 
        { 
            this.videoService = videoService;
        }

        public async Task ExecuteAsync()
        {
            Console.WriteLine("Загрузка видео начата");
            await videoService.DownLoadVideoAsync();
        }
    }
}
