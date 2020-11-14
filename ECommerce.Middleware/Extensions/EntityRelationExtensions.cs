using ECommerce.Middleware.Entities.Core;
using ECommerce.Middleware.Entities.Identity;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Middleware.Extensions
{
    public static class EntityRelationExtensions
    {
        public static void ToIdentityTables(this ModelBuilder builder)
        {
            builder.Entity<User>().ToTable(nameof(User)).HasKey(e => e.Id);
            builder.Entity<Role>().ToTable(nameof(Role)).HasKey(e => e.Id);
            builder.Entity<UserRole>().ToTable(nameof(UserRole)).HasKey(e => e.Id);
        }

        public static void ToCoreTables(this ModelBuilder builder)
        {
            builder.Entity<Action>().ToTable(nameof(Action)).HasKey(e => e.Id);
            builder.Entity<Area>().ToTable(nameof(Area)).HasKey(e => e.Id);
            builder.Entity<Controller>().ToTable(nameof(Controller)).HasKey(e => e.Id);
            builder.Entity<ControllerAction>().ToTable(nameof(ControllerAction)).HasKey(e => e.Id);
            builder.Entity<ControllerActionRole>().ToTable(nameof(ControllerActionRole)).HasKey(e => e.Id);
        }

        public static void AddIdentityRelations(this ModelBuilder builder)
        {
            builder.Entity<User>(user =>
            {

                user.HasMany(u => u.UserRoles)
                    .WithOne(u => u.User)
                    .HasForeignKey(u => u.UserId)
                    .IsRequired();

                user.HasIndex(u => u.Email).IsUnique();
            });

            builder.Entity<Role>(role =>
            {
                role.HasMany(r => r.UserRoles)
                    .WithOne(r => r.Role)
                    .HasForeignKey(r => r.RoleId)
                    .IsRequired();

                role.HasMany(r => r.ControllerActionRoles)
                    .WithOne(r => r.Role)
                    .HasForeignKey(r => r.RoleId)
                    .IsRequired();

                role.HasIndex(r => r.Name).IsUnique();
            });
        }

        public static void AddCoreRelations(this ModelBuilder builder)
        {
            builder.Entity<Action>(action =>
            {
                action.HasMany(a => a.ControllerActions)
                      .WithOne(a => a.Action)
                      .HasForeignKey(a => a.ActionId)
                      .IsRequired();

                action.HasIndex(a => a.Name).IsUnique();
            });

            builder.Entity<Controller>(controller =>
            {
                controller.HasMany(c => c.ControllerActions)
                          .WithOne(c => c.Controller)
                          .HasForeignKey(c => c.ControllerId)
                          .IsRequired();

                controller.HasIndex(c => c.Name).IsUnique();
            });

            builder.Entity<Area>(area =>
            {
                area.HasMany(a => a.Controllers)
                    .WithOne(c => c.Area)
                    .HasForeignKey(c => c.AreaId)
                    .IsRequired();

                area.HasIndex(a => a.Name).IsUnique();
            });

            builder.Entity<ControllerAction>(controllerAction =>
            {
                controllerAction.HasMany(ca => ca.ControllerActionRoles)
                                .WithOne(ca => ca.ControllerAction)
                                .HasForeignKey(ca => ca.ControllerActionId)
                                .IsRequired();
            });
        }

        public static void AddUpdatedUserRelations(this ModelBuilder builder)
        {
            builder.Entity<User>(user =>
            {
                user.HasMany(u => u.UpdatedActions)
                    .WithOne(a => a.UpdatedUser)
                    .HasForeignKey(a => a.UpdatedUserId)
                    .IsRequired();

                user.HasMany(u => u.UpdatedAreas)
                    .WithOne(a => a.UpdatedUser)
                    .HasForeignKey(a => a.UpdatedUserId)
                    .IsRequired();

                user.HasMany(u => u.UpdatedControllers)
                    .WithOne(c => c.UpdatedUser)
                    .HasForeignKey(c => c.UpdatedUserId)
                    .IsRequired();

                user.HasMany(u => u.UpdatedControllerActions)
                    .WithOne(ca => ca.UpdatedUser)
                    .HasForeignKey(ca => ca.UpdatedUserId)
                    .IsRequired();

                user.HasMany(u => u.UpdatedControllerActionRoles)
                    .WithOne(car => car.UpdatedUser)
                    .HasForeignKey(car => car.UpdatedUserId)
                    .IsRequired();

                user.HasMany(u => u.UpdatedRoles)
                    .WithOne(r => r.UpdatedUser)
                    .HasForeignKey(r => r.UpdatedUserId)
                    .IsRequired();

                user.HasMany(u => u.UpdatedUsers)
                    .WithOne(u => u.UpdatedUser)
                    .HasForeignKey(u => u.UpdatedUserId)
                    .IsRequired();

                user.HasMany(u => u.UpdatedUserRoles)
                    .WithOne(ur => ur.UpdatedUser)
                    .HasForeignKey(ur => ur.UpdatedUserId)
                    .IsRequired();
            });
        }
    }
}