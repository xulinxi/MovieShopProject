﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Helpers;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IUserService
    {
        Task<UserLoginResponseModel> ValidateUser(string email, string password);
        Task<UserRegisterResponseModel> CreateUser(UserRegisterRequestModel requestModel);
        Task<UserRegisterResponseModel> GetUserDetails(int id);
        Task<User> GetUser(string email);
        Task<PagedResultSet<User>> GetAllUsersByPagination(int pageSize = 20, int page = 0, string lastName = "");
        Task<Uri> UploadUserProfilePicture(UserProfileRequestModel userProfileRequestModel);

        Task AddFavorite(FavoriteRequestModel favoriteRequest);
        Task RemoveFavorite(FavoriteRequestModel favoriteRequest);
        Task<bool> FavoriteExists(int id, int movieId);
        Task<FavoriteResponseModel> GetAllFavoritesForUser(int id);

        Task PurchaseMovie(PurchaseRequestModel purchaseRequest);
        Task<bool> IsMoviePurchased(PurchaseRequestModel purchaseRequest);
        Task<PurchaseResponseModel> GetAllPurchasesForUser(int id);


        Task AddMovieReview(ReviewRequestModel reviewRequest);
        Task UpdateMovieReview(ReviewRequestModel reviewRequest);
        Task DeleteMovieReview(int userId, int movieId);
        Task<ReviewResponseModel> GetAllReviewsByUser(int id);
    }
}