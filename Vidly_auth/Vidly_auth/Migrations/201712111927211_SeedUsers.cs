namespace Vidly_auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'67b628e9-1dfa-4020-bcd0-67dd1bb0af6e', N'admin@vidly.com', 0, N'AF96/6bPBZyXxb1pggPbOzE2uUbNMBtlEWiI5fM2zWh1l5f//RQhSh8wQ8/jYqSe9g==', N'51c22475-979d-4350-8457-976c443c3baa', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7367b21e-ca23-4b4f-a952-a56a8e8b1c6b', N'steve@steve.com', 0, N'AEKpKKaosDkCn6fCpfNGzFLx8FOojF4M3qTD0j6bisfI9cav4D+qPS050jqy1ucswA==', N'f74e2b63-5f4a-44a4-be0c-0e54a255d25b', NULL, 0, 0, NULL, 1, 0, N'steve@steve.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'eff67052-8378-4277-a4a7-231615feea6e', N'guest@vidly.com', 0, N'AEzOyKt6iP3ERQKRP0+SyiMPK3zOo74iV0CVGXo0HjR32vyfT/BHxtlDzKAlYhsKrw==', N'5d3b19fb-b835-4873-b7e0-6778cd3f4a9d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'64dc87cd-a081-469e-b761-ce032006c17c', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'67b628e9-1dfa-4020-bcd0-67dd1bb0af6e', N'64dc87cd-a081-469e-b761-ce032006c17c')
");
        }
        
        public override void Down()
        {
        }
    }
}
