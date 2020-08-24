using System.Collections.Generic;
using VideoApp.Core.Entity;
using VideoApp.infraStructure.Data;


namespace VideoApp.core
{
  public class VideoService
    {
        public static List<Video> GetVideos()
        {
            return VideoTable.Videos;
        }

        public static Video CreateVideo(Video video)
        {
           return VideoTable.AddVideo(video);


        }


    }
}
