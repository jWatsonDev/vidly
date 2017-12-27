namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2ee5d60a-da4b-4da8-b11f-97fad0b6bba7', N'guest@vidly.com', 0, N'ALAgXUUqeuRf6Ul3Hp/AUxACkWzJrk/wUeRbKNCT9mkb6h7RIMi2g46sPOCAzWZ62g==', N'bdd604ab-d85d-42a8-a0ad-7aeeeabf9942', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4b80d77f-c58d-4ae0-98c4-8038bac8bbec', N'admin@vidly.com', 0, N'AK2xFa7NYY21EwRVp8yCA4dUfZeywUZyIrg1Q1RFbWnde9ZpwLmlpe5xsnVwWS/Jgg==', N'f20e83be-b71e-4a9d-a821-484ff8eca2dd', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5ccd4faf-6aa5-4238-90f9-653cb9dbf1f4', N'jaywatson2.0@outlook.com', 0, N'AEsuF23MSI88YnCJhcBMQgYC8fWJSNBdjJtG9S+d2u5E9t2fAb9kwiKskd9lgbbvjg==', N'b8cf897e-a992-4a15-aa3d-151a1ac33f0d', NULL, 0, 0, NULL, 1, 0, N'jaywatson2.0@outlook.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'71f7f9f3-dfdf-43aa-bdcf-6a0e72fd354c', N'adm@vidly.com', 0, N'AIL1L2l6fVd6TH7+xgOHY2fDr6L6hy1/6eWRMPl5tsTtjmYPo6A17rYS+zUq9HMNdg==', N'afa2a10a-3fbb-48bc-9b56-34464efb18cf', NULL, 0, 0, NULL, 1, 0, N'adm@vidly.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5673a508-cc36-4f84-914e-45ace883583a', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'71f7f9f3-dfdf-43aa-bdcf-6a0e72fd354c', N'5673a508-cc36-4f84-914e-45ace883583a')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
