namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'24eefbf9-8261-4357-bca1-18845fa873e9', N'admin@Vidly.com', 0, N'AKZh8navZLU1VjwkX2/46ptYFeAAc/rkmiSlCH7+UMDkjnF7Zoh/FSAAluJ41w2Q1g==', N'e8931178-6b13-4cf6-b740-8d47a9045ca4', NULL, 0, 0, NULL, 1, 0, N'admin@Vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4669c654-31c0-49ce-b9f8-5de418c3258d', N'guest@Vidly.com', 0, N'AIl8z+eAFdHd2LSnX5Gc/MH1A1KDlsHi+sOsaj8WvKvoP+FNYtPvoWX+Lhkrjz9aXw==', N'e60f5554-d797-4a1c-baf1-f0430e4b259b', NULL, 0, 0, NULL, 1, 0, N'guest@Vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ca3a6b9e-112d-4673-9c0d-f0d07c414585', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'24eefbf9-8261-4357-bca1-18845fa873e9', N'ca3a6b9e-112d-4673-9c0d-f0d07c414585')

");
        }
        
        public override void Down()
        {
        }
    }
}
