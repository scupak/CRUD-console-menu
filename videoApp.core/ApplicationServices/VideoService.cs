using System.Collections.Generic;
using VideoApp.core.DomainServices;
using VideoApp.Core.Entity;


namespace VideoApp.core.ApplicationServices
{
  public class VideoService : IVideoService
  {
        private IVideoRepository _VideoTable;
        public VideoService(IVideoRepository VideoTable)
        {
            _VideoTable = VideoTable;


        }

        public List<Video> GetVideos()
        {
            return _VideoTable.GetVideos();
        }

        public Video CreateVideo(Video video)
        {
           return _VideoTable.AddVideo(video);


        }


    }
}
