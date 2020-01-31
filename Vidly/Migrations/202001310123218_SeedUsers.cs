namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6388f97f-6039-4637-af27-e61f56538c9f', N'admin@vidly.com', 0, N'AMfvpsfjvcix1G/JW6Hv1nuJJUYFvsiiVhByyjgSReESDpieovSKc9j8oEUO3uYILA==', N'6448e24e-1d0b-4334-804f-b9698b7fd425', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd0761df7-621e-4d62-ab6c-c2811beeaf0e', N'guest@vidly.com', 0, N'AKweFO7YQdt6a+6M8tM6YTK5ZOTeZ6qO+7Z7FSnLp0kSkfMVvmv5B0cR2HkmoQDatg==', N'a586ce51-d328-4c67-b7d0-c778de17d41e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd41eb852-f568-40ce-a6b9-eabffbeadefc', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6388f97f-6039-4637-af27-e61f56538c9f', N'd41eb852-f568-40ce-a6b9-eabffbeadefc')
               ");
        }
        
        public override void Down()
        {
        }
    }
}