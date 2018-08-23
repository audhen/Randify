﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Randify.Models.SpotifyModel
{
    internal class playlisttrack
    {
        //public string added_at { get; set; }
        //public user added_by { get; set; }
        public track track { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public PlaylistTrack ToPOCO()
        {
            var playlistTrack = new PlaylistTrack();
            playlistTrack.Track = this.track.ToPOCO();

            /*
            DateTime addedAt;

            if (DateTime.TryParse(this.added_at, out addedAt))
                playlistTrack.AddedAt = addedAt;
            else
                playlistTrack.AddedAt = DateTime.Now;

            if (this.added_by != null)
                playlistTrack.AddedBy = this.added_by.ToPOCO();
            */

            return playlistTrack;
        }
    }
}
