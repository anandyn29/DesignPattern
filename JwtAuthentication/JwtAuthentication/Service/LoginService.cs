﻿using JwtAuthentication.Models.AppModels;
using JwtAuthentication.Service.Interface;

namespace JwtAuthentication.Service
{
    public class LoginService : ILoginService
    {
        public bool IsValidUser(Login loginUser)
        {
            //using var dbContext = new TrackerContext();
            //return dbContext.Users.Any(u => u.UserName == loginUser.UserName && u.Password == loginUser.Password && u.IsActive);
            return true;
        }

        public bool HasAlreadyLogin(Login loginUser)
        {
            //using var dbContext = new TrackerContext();
            //return dbContext.Users.Any(u => u.UserName == loginUser.UserName && u.IsLoggedIn);
            return false;
        }

        public string GetStoredRefreshToken(string userName)
        {
            //using var dbContext = new TrackerContext();
            //return dbContext.Users.First(u => u.UserName == userName)?.SessionToken ?? string.Empty;
            return string.Empty;
        }

        public void SaveRefreshToken(TokenResponse tokenResponse)
        {
            //Save to Db
            //using var dbContext = new TrackerContext();
            //var user = dbContext.Users.First(u => u.UserName == tokenResponse.UserName);
            //if (user != null)
            //{
            //    user.SessionToken = tokenResponse.Token;
            //    dbContext.SaveChanges();
            //}
        }

        public string GetUserRole(string userName)
        {
            //using var dbContext = new TrackerContext();
            //var user = dbContext.Users.First(u => u.UserName == userName);
            //if (user != null)
            //{
            //    return dbContext.Roles.First(r => r.Id == user.RoleId)?.RoleType ?? string.Empty;
            //}
            return string.Empty;
        }
    }
}
