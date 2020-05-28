﻿//  Project 
using NickScotney.SeratoNowPlaying.Logic.Helpers;

namespace NickScotney.SeratoNowPlaying.Logic.Controllers
{
    public class FileController
    {
        public static void ClearFiles(string currentTrack, string previousTrack)
        {
            FileHelper.ClearFile(currentTrack);

            if (!string.IsNullOrEmpty(previousTrack))
                FileHelper.ClearFile(previousTrack);
        }

        public static void ReadHtml(string currentTrackLabel, string previousTrackLabel, string currentTrackPrefix, string currentTrackSuffix)
            => FileHelper.GetTrackNames(currentTrackLabel, previousTrackLabel, currentTrackPrefix, currentTrackSuffix);

        public static void SetFolderPath(string folderPath)
            => FileHelper.FolderLocation = folderPath;

        public static void SetParseAddress(string parseAddress)
            => FileHelper.ParseAddress = parseAddress;
    }
}