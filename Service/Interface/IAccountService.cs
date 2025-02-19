﻿using DataAccess.Models;
using Service.DTO;
using Service.Helper;

namespace Service.Interface
{
    public interface IAccountService
    {
        Task<bool> LoginAsync(string email, string password);
        Task<SystemAccount?> GetCurrentUserAsync();
        Task LogoutAsync();

        Task<IEnumerable<AccountViewModel>> GetAllAccountsAsync();
        Task<AccountViewModel?> GetAccountByIdAsync(int id);
        Task<IEnumerable<AccountViewModel>> SearchAccountsAsync(string searchTerm, int? roleFilter);
        Task<ServiceResult> CreateAccountAsync(AccountViewModel model);
        Task<ServiceResult> UpdateAccountAsync(AccountViewModel model);
        Task<ServiceResult> DeleteAccountAsync(int id);


        Task<ProfileViewModel?> GetUserProfileAsync(int accountId);
        Task<ServiceResult> UpdateProfileAsync(ProfileViewModel model);
        Task<ServiceResult> ChangePasswordAsync(int accountId, string currentPassword, string newPassword);
    }
}
