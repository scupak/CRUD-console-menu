using System;
using System.Collections.Generic;
using System.Text;
using VideoApp.Core.Entity;

namespace VideoApp.core.ApplicationServices
{
    public interface IVideoService
    {
        public List<Video> GetVideos();

        public Video CreateVideo(Video video);

    }
}
