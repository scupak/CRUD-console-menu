using System.Collections.Generic;
using VideoApp.Core.Entity;

namespace VideoApp.infraStructure.Data
{
    public class VideoTable
    {
        public static int Id = 0;
        public static List<Video> Videos = new List<Video>();

        public static Video AddVideo(Video video) {

            Id++;
            video.Id = Id;
            Videos.Add(video);
            return video;
        
        
        
        
        }
    }
}
