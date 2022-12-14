namespace Insmart.Core
{
    public static class Constants
    {
        public const string IsActiveWhere= "IsActive=@IsActive";
        public const string IsDeletedWhere = "IsDeleted=@IsDeleted";
        public const string IsActiveIsDeletedWhere = "IsActive=@IsActive and IsDeleted=@IsDeleted";
        public const string GeneralError = "Oops! Something went wrong!";
        public const int Engilish = 1;
        public const int DefaultPageSize = 50;
    }
}
