using System.Collections.Generic;
using Models;

namespace Data_Layer
{
    public interface IRepository
    {
        /// <summary>
        /// This method will search the database and return a list of all users stored.
        /// </summary>
        /// <returns>Returns a list of Users.</returns>
        List<User> GetAllUsers();

        /// <summary>
        /// Returns a single User from the DB with a UserId matching p_userId.
        /// </summary>
        /// <param name="p_id">The ID of the user to find.</param>
        /// <returns>The User found by UserId.</returns>
        User GetUserById(int p_userId);

        /// <summary>
        /// Adds a User to the DB.
        /// </summary>
        /// <param name="p_userToAdd">The User that will be added to the DB</param>
        /// <returns>The User that got added.</returns>
        User AddUser(User p_userToAdd);

        /// <summary>
        /// Removes a User from the DB as well as the data from the other tables that references it.
        /// </summary>
        /// <param name="p_userIdToDelete">The UserId that will be deleted</param>
        /// <returns>The User that will be deleted</returns>
        User DeleteUserById(int p_userIdToDelete);

        /// <summary>
        /// Searches the DB for a user by email and returns a user it finds.
        /// </summary>
        /// <param name="p_email">The email to match with the user.</param>
        /// <returns>Returns the User that was found.</returns>
        User LoginUser(string p_email);

        /// <summary>
        /// Will return the UserId of the user with the email == p_email.
        /// </summary>
        /// <param name="p_email">the email of the user to find.</param>
        /// <returns>the UserId of the user found.</returns>
        User GetUserByEmail(string p_email);

        /// <summary>
        /// Will return a list of all FavoriteLists
        /// </summary>
        /// <returns>The List of FavoriteLists</returns>
        List<FavoriteList> GetAllFavoriteList();

        /// <summary>
        /// Returns a List of FavoriteLists from the DB with a UserId matching p_userId.
        /// </summary>
        /// <param name="p_userId">The ID for the User the FavoriteList references.</param>
        /// <returns>List of FavoriteLists found by UserId.</returns>
        List<FavoriteList> GetFavoriteListByUserId(int p_userId);

        /// <summary>
        /// Returns a single FavoriteList from the DB with FavoriteListId matching p_FavoriteListId.
        /// </summary>
        /// <param name="p_FavoriteListId">The ID for the FavoriteList to find.</param>
        /// <returns>The FavoriteList found by FavoriteListId.</returns>
        FavoriteList GetFavoriteListById(int p_favoriteListId);

        /// <summary>
        /// Will Search for a User from p_FavoriteListToAdd.UserId and add p_FavoriteListToAdd to the list of FavoriteList.
        /// </summary>
        /// <param name="p_FavoriteListToAdd">The Favorite List to add, also contains the UserId to look for.</param>
        /// <returns>The FavoriteList that got added.</returns>
        FavoriteList AddFavoriteList(FavoriteList p_FavoriteListToAdd);

        /// <summary>
        /// Deletes a favoriteList from DB that is found by its FavoriteListId.
        /// </summary>
        /// <param name="p_favoriteListIdToRemove">The Id for the FavoriteList to remove</param>
        /// <returns>The FavoriteList that was removed.</returns>
        FavoriteList DeleteFavoriteListById(int p_favoriteListIdToRemove);

        /// <summary>
        /// Returns a List of PreviousSearch from the DB with a UserId matching p_userId.
        /// </summary>
        /// <param name="p_userId">The ID for the User the PreviousSearch references.</param>
        /// <returns>List of PreviousSearch found by UserId.</returns>
        List<PreviousSearch> GetPreviousSearchByUserId(int p_userId);

        /// <summary>
        /// Returns a single PreviousSearch from the DB with PreviousSearchId matching p_previousSearchId.
        /// </summary>
        /// <param name="p_previousSearchId">The ID for the PreviousSearch to find.</param>
        /// <returns>The PreviousSearch found by PreviousSearchId.</returns>
        PreviousSearch GetPreviousSearchById(int p_previousSearchId);

        /// <summary>
        /// Will Search for a User from p_previousSearchToAdd.UserId and add p_previousSearchToAdd to the list of PreviousSearches.
        /// </summary>
        /// <param name="p_previousSearchToAdd">The PreviousSearch to add, also contains the UserId to look for.</param>
        /// <returns>The PreviousSearch that got added.</returns>
        PreviousSearch AddPreviousSearch(PreviousSearch p_previousSearchToAdd);

        /// <summary>
        /// Deletes a PreviousSearch from DB that is found by its PreviousSearchId.
        /// </summary>
        /// <param name="p_previousSearchId">The Id for the PreviousSearch to remove</param>
        /// <returns>The PreviousSearch that was removed.</returns>
        PreviousSearch DeletePreviousSearchById(int p_previousSearchId);

        /// <summary>
        /// Returns a List of Recommendation from the DB with a UserId matching p_userId.
        /// </summary>
        /// <param name="p_userId">The ID for the User the Recommendation references.</param>
        /// <returns>List of Recommendation found by UserId.</returns>
        List<Recommendation> GetRecommendationByUserId(int p_userId);

        /// <summary>
        /// Returns a single Recommendation from the DB with RecommendationId matching p_recommendationId.
        /// </summary>
        /// <param name="p_recommendationId">The ID for the Recommendation to find.</param>
        /// <returns>The Recommendation found by RecommendationId.</returns>
        Recommendation GetRecommendationById(int p_recommendationId);

        /// <summary>
        /// Will Search for a User from p_recommendationToAdd.UserId and add p_recommendationToAdd to the list of Recommendations.
        /// </summary>
        /// <param name="p_recommendationToAdd">The Recommendation to add, also contains the UserId to look for.</param>
        /// <returns>The Recommendation that got added.</returns>
        Recommendation AddRecommendation(Recommendation p_recommendationToAdd);

        /// <summary>
        /// Deletes a Recommendation from DB that is found by its RecommendationId.
        /// </summary>
        /// <param name="p_recommendationId">The Id for the Recommendation to remove</param>
        /// <returns>The Recommendation that was removed.</returns>
        Recommendation DeleteRecommendationById(int p_recommendationId);

        /// <summary>
        /// Returns a List of Review from the DB with a UserId matching p_userId.
        /// </summary>
        /// <param name="p_userId">The ID for the User the Review references.</param>
        /// <returns>List of Review found by UserId.</returns>
        List<Review> GetReviewByUserId(int p_userId);

        /// <summary>
        /// Returns a single Review from the DB with ReviewId matching p_reviewId.
        /// </summary>
        /// <param name="p_reviewId">The ID for the Review to find.</param>
        /// <returns>The Review found by ReviewId.</returns>
        Review GetReviewById(int p_reviewId);

        /// <summary>
        /// Will find all reviews associated with the inputted imdbId.
        /// </summary>
        /// <param name="p_imdbId">the movie id that will be searched for</param>
        /// <returns>List of reviews matching movie</returns>
        List<Review> GetAllReviewByImdbId(string p_imdbId);

        /// <summary>
        /// Will Search for a User from p_reviewToAdd.UserId and add p_reviewToAdd to the list of Reviews.
        /// </summary>
        /// <param name="p_reviewToAdd">The Review to add, also contains the UserId to look for.</param>
        /// <returns>The Review that got added.</returns>
        Review AddReview(Review p_reviewToAdd);

        /// <summary>
        /// Deletes a Review from DB that is found by its ReviewId.
        /// </summary>
        /// <param name="p_reviewId">The Id for the Review to remove</param>
        /// <returns>The Review that was removed.</returns>
        Review DeleteReviewById(int p_reviewId);

        ///<summary>
        ///Updates the information of a User in the database.
        ///</summary>
        ///<param name = "user" > The "user" is the variable used to access the properties in the DB</param>
        /// <returns>True if the user got updated and false otherwise.</returns>
        bool UpdateUser(User user);

        ///<summary>
        ///Updates the information of a User in the database.
        ///</summary>
        ///<param name = "name", "user"> The "name" is the variable used to access the user in the DB</param>
        /// <returns>user object.</returns>
        User UpdateUserByUsername(string name, User user);


        ///<summary>
        ///Updates the information of a User in the database.
        ///</summary>
        ///<param name = "email", "user"> The "email" is the variable used to access the user in the DB</param>
        /// <returns>user object.</returns>
        User UpdateUserByEmail(string email, User user);


        
        ///<summary>
        ///Updates the information of a User in the database.
        ///</summary>
        ///<param name = "userId", "user"> The "userId" is the variable used to access the user in the DB</param>
        /// <returns>user object.</returns>
        User UpdateUserById(int userId, User user);

        ///<summary>
        ///Updates the information of the FavoriteList of a user in the database.
        ///</summary>
        ///<param name = "fList"> The "fList" is the variable used to access the properties in the DB</param>
        /// <returns>True if the FavoriteList got updated and false otherwise.</returns>
        bool UpdateFavoriteList(FavoriteList favoriteList);

        ///<summary>
        ///Updates the information of the FavoriteList of a user in the database.
        ///</summary>
        ///<param name = "fList" and "FavoriteListId"> The "FavoriteListId" is the variable used to access the FavoriteList in the DB</param>
        /// <returns>FavoriteList object.</returns>
        FavoriteList UpdateFavoriteListById(int FavoriteListId, FavoriteList fList);

        ///<summary>
        ///Updates the information of the PreviousSearch of a user in the database.
        ///</summary>
        ///<param name = "prevSearch"> The "prevSearch" is the variable used to access the properties in the DB</param>
        /// <returns>True if the prevSearch got updated and false otherwise.</returns>
        bool UpdatePreviousSearch(PreviousSearch prevSearch);

        ///<summary>
        ///Updates the information of the PreviousSearch of a user in the database.
        ///</summary>
        ///<param name = "prevSearch" and "PreviousSearchId"> The "prevSearchId" is the variable used to access the PreviousSearchId in the DB</param>
        /// <returns>Recommendation object.</returns>
        PreviousSearch UpdatePreviousSearchById(int PreviousSearchId, PreviousSearch prevSearch);

        ///<summary>
        ///Updates the information of the Recommendation by a user in the database.
        ///</summary>
        ///<param name = "rec"> The "rec" is the variable used to access the properties in the DB</param>
        /// <returns>True if the Recommendation got updated and false otherwise.</returns>
        bool UpdateRecommendation(Recommendation rec);

        ///<summary>
        ///Updates the information of the Recommendation by RecommendationId of a user in the database.
        ///</summary>
        ///<param name = "RecommendationId" and "rec"> The "RecommendationId" is the variable used to access the Recommendation in the DB</param>
        /// <returns>Returns Recommendation object.</returns>
        Recommendation UpdateRecommendationById(int RecommendationId, Recommendation rec);

        ///<summary>
        ///Updates the information of the Review of a user in the database.
        ///</summary>
        ///<param name = "rev"> The "rev" is the variable used to access the properties in the DB</param>
        /// <returns>True if the Review got updated and false otherwise.</returns>
        bool UpdateReview(Review rev);

        ///<summary>
        ///Updates the information of the Review of a user in the database.
        ///</summary>
        ///<param name = "ReviewId" and "rev"> The "ReviewId" is the variable used to access the propertiies in the DB</param>
        ////// <returns>Review object.</returns>
        Review UpdateReviewById(int ReviewId, Review rev);
    }
}