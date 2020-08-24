using System.Collections.Generic;
using VideoApp.core.DomainServices;
using VideoApp.Core.Entity;


namespace VideoApp.infraStructure.Data
{
    public class VideoTable : IVideoRepository
    {
        public static int Id = 0;
        public static List<Video> Videos = new List<Video>();

        public Video AddVideo(Video video) {

            Id++;
            video.Id = Id;
            Videos.Add(video);
            return video;
        
        
        
        
        }

        public List<Video> GetVideos()
        {
            return Videos;
        }
    }
    }
