namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dcc7eedc-b450-4c3e-81d6-2a57c74574fe', N'guest@kalli.no', 0, N'AGZWDuMWjwTRvw/U+hkf8+KSEU1NjM2eE1jcnxyl+JmZjo0avZf3O94uQBfXZGsbSw==', N'7b82a558-7138-4baa-bc55-5702c883eaca', NULL, 0, 0, NULL, 1, 0, N'guest@kalli.no')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e64ee39e-393e-4db9-8615-9276c8899c5d', N'admin@kalli.no', 0, N'APbkji1ojKWn14BvFh+fxE4tHys7SqlyafcVmIxlHJ5FFI1+MLmxbdYD3NLsfP9fPQ==', N'e72111b3-0f09-45d8-813f-c27c5445e2aa', NULL, 0, 0, NULL, 1, 0, N'admin@kalli.no')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4ef112e8-a4ed-47d2-8c6b-0f0dff60140e', N'CanManageMovies')
                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e64ee39e-393e-4db9-8615-9276c8899c5d', N'4ef112e8-a4ed-47d2-8c6b-0f0dff60140e')
            ");
        }

        public override void Down()
        {
        }
    }
}
