using AT.Share.Model;

namespace AT.Client.Services.Interface
{
    public interface IManagerUserService
    {
        Task<List<Staff>> GetAllUserAsync();
        Task<List<GroupUser>> GetAllGroupUserAsync();
        Task<List<StaffInfo>> GetAllUserInfoAsync();
    }
}
