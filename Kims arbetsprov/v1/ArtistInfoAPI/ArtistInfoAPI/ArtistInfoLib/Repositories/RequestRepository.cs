using System.Collections.Generic;
using System.Linq;
using ArtistInfoLib.Models;

namespace ArtistInfoLib.Repositories
{
    public class RequestRepository : IRequestRepository
    {
        private readonly IRequestFactory _requestFactory;
        private readonly IResponseFactory _responseFactory;
        private readonly IRequestHandler _requestHandler;

        public RequestRepository(IRequestFactory requestFactory, IResponseFactory responseFactory, IRequestHandler requestHandler)
        {
            _requestFactory = requestFactory;
            _responseFactory = responseFactory;
            _requestHandler = requestHandler;
        }

        public IResponse GetArtistInfoModel(string mbid)
        {
            //var musicBrainzRequest = _requestFactory.GetRequestStrings("musicBrainz", mbid);
            //var musicBrainzResponse = _requestHandler.SendRequest(musicBrainzRequest);
            //var musicBrainzModel = _responseFactory.ConvertJsonToMusicBrainzModel(musicBrainzResponse);
            var musicBrainzModel = GetMusicBrainzModel(mbid);
            var wikiId = musicBrainzModel.GetWikipediaId();
            //var wikipediaRequest = _requestFactory.GetRequestStrings("wikipedia", wikiId);
            //var wikipediaResponse = _requestHandler.SendRequest(wikipediaRequest);
            //var wikipediaModel = _responseFactory.ConvertJsonToWikipediaModel(wikipediaResponse);
            var wikipediaModel = GetWikipediaModel(wikiId);
            var albums = new List<Album>();
            foreach (var releaseGroup in musicBrainzModel.releasegroups.Where(x => x.primarytype == "Album"))
            {

                //var coverArtArchiveRequest =
                //    _requestFactory.GetRequestStrings("coverArtArchive", releaseGroup.id);
                //var coverArtArchiveResponse = _requestHandler.SendRequest(coverArtArchiveRequest);
                //var covertArtModel =
                //    _responseFactory.ConvertJsonToCoverArtArchiveModel(coverArtArchiveResponse);
                var covertArtModel = GetCoverArtArchiveModel(releaseGroup.id);
                albums.Add(new Album
                {
                    Id = releaseGroup.id,
                    Title = releaseGroup.title,
                    ImageUrl = covertArtModel.images.FirstOrDefault().image
                });
            }
            var artistInfoModel = MergeModels(musicBrainzModel, wikipediaModel, albums);
            return artistInfoModel;
        }

        private MusicBrainzModel GetMusicBrainzModel(string mbid)
        {
            var musicBrainzRequest = _requestFactory.GetRequestStrings("musicBrainz", mbid);
            var musicBrainzResponse = _requestHandler.SendRequest(musicBrainzRequest);
            return _responseFactory.ConvertJsonToMusicBrainzModel(musicBrainzResponse);
        }

        private WikipediaModel GetWikipediaModel(string id)
        {
            var wikipediaRequest = _requestFactory.GetRequestStrings("wikipedia", id);
            var wikipediaResponse = _requestHandler.SendRequest(wikipediaRequest);
            return _responseFactory.ConvertJsonToWikipediaModel(wikipediaResponse);
        }

        private CoverArtArchiveModel GetCoverArtArchiveModel(string id)
        {
            var coverArtArchiveRequest =
                _requestFactory.GetRequestStrings("coverArtArchive", id);
            var coverArtArchiveResponse = _requestHandler.SendRequest(coverArtArchiveRequest);
            return _responseFactory.ConvertJsonToCoverArtArchiveModel(coverArtArchiveResponse);
        }

        private ArtistInfoModel MergeModels(MusicBrainzModel musicBrainzModel, WikipediaModel wikipediaModel,
            List<Album> albums)
        {
            return new ArtistInfoModel
            {
                Albums = albums,
                Artist = musicBrainzModel.name,
                Description = wikipediaModel.Description,
                Mbid = musicBrainzModel.id
            };
        }
    }
}