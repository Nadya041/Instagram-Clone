using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raupjc_projekt.Models
{
    public interface IMySqlRepository
    {
        Task<List<Album>> GetMyAlbumsAsync(string userId);
        Task AddMyAlbumAsync(string ownerId, string name);
        Task<bool> RemoveMyAlbumAsync(string ownerId, Guid id);
        Task<bool> UpdateMyAlbumAsync(string ownerId, Guid id);

        Task<List<Photo>> GetPhotosAsync(Guid albumId);
        Task AddPhotoToAlbumAsync(Guid albumId, string ownerId, string url);
        Task<bool> RemovePhotoFromAlbumAsync(Guid albumId, Guid photoId, string ownerId);

        Task GetAllAlbumsAsync();
        Task FavoritePhotoAsync(string userId, Guid photoId);
        Task LikePhotoAsync(string guidPhotoId);//provjeri za bazu ako je ok

        Task<List<Photo>> GetFavoritePhotosAsync(string userId);

        Task<List<User>> GetSubscribedUsersAsync(string userId);
        Task SubscribeToUserAsync(string subscriberId, string ownerId);

        Task GetCommentsAsync(Guid photoId);
        Task PostCommentAsync(Guid photoId, string commentatorId, string text);

        Task<List<Photo>> GetFeaturedPhotosAsync();
        Task<List<Photo>> GetPhotosFromSubscribedUsersAsync(string userId);

        Task FeaturePhotoAsync(Guid photoId);


    }
}
