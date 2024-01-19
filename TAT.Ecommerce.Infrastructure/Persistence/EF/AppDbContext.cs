using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TAT.Ecommerce.Domain.Common;
using TAT.Ecommerce.Domain.Entities;
using TAT.Ecommerce.Infrastructure.Persistence.Configuration;

namespace TAT.Ecommerce.Infrastructure.Persistence.EF
{
    public class AppDbContext : IdentityDbContext<User, Role, Guid>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            _ = builder.ApplyConfiguration(new AccountConfiguration());
            _ = builder.ApplyConfiguration(new AddressConfiguration());
            // identity 
            _ = builder.ApplyConfiguration(new AppRoleClaimConfiguration());
            _ = builder.ApplyConfiguration(new AppRoleConfiguration());
            _ = builder.ApplyConfiguration(new AppUserClaimConfiguration());
            _ = builder.ApplyConfiguration(new AppUserConfiguration());
            _ = builder.ApplyConfiguration(new AppUserLoginConfiguration());
            _ = builder.ApplyConfiguration(new AppUserRoleConfiguration());
            _ = builder.ApplyConfiguration(new AppUserTokenConfiguration());
            ///////////////////////////////

            _ = builder.ApplyConfiguration(new BrandConfiguration());
            _ = builder.ApplyConfiguration(new CartConfiguration());
            _ = builder.ApplyConfiguration(new CartItemConfiguration());
            _ = builder.ApplyConfiguration(new CategoryConfiguration());
            _ = builder.ApplyConfiguration(new CustomerConfiguration());
            _ = builder.ApplyConfiguration(new GalleryConfiguration());
            _ = builder.ApplyConfiguration(new MappingCategoryTagConfiguration());
            _ = builder.ApplyConfiguration(new MappingProductTagConfiguration());
            _ = builder.ApplyConfiguration(new OrderConfiguration());
            _ = builder.ApplyConfiguration(new OrderItemConfiguration());
            _ = builder.ApplyConfiguration(new ProductConfiguration());
            _ = builder.ApplyConfiguration(new StoreConfiguration());
            _ = builder.ApplyConfiguration(new StoreOwnerConfiguration());
            _ = builder.ApplyConfiguration(new SubCategoryConfiguration());
            _ = builder.ApplyConfiguration(new TagConfiguration());
            _ = builder.ApplyConfiguration(new TransactionConfiguration());



        }
        public virtual Task<int> SaveChangesAsync(string username = "")
        {
            foreach (Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<BaseEntity> entry in ChangeTracker.Entries<BaseEntity>())
            {

                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = DateTimeOffset.UtcNow;
                    entry.Entity.CreatedBy = username;
                }

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTimeOffset.UtcNow;
                    entry.Entity.CreatedBy = username;
                }
            }
            return base.SaveChangesAsync();
        }

        public DbSet<Account>? Accounts { get; set; }
        public DbSet<Address>? Addresses { get; set; }
        public DbSet<Brand>? Brands { get; set; }
        public DbSet<Cart>? Carts { get; set; }
        public DbSet<CartItem>? CartItems { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Gallery>? Galleries { get; set; }
        public DbSet<MappingCategoryTag>? MappingCategoryTags { get; set; }
        public DbSet<MappingProductTag>? MappingProductTags { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Store>? Stores { get; set; }
        public DbSet<StoreOwner>? StoreOwners { get; set; }
        public DbSet<SubCategory>? SubCategories { get; set; }
        public DbSet<Tag>? Tags { get; set; }
        public DbSet<Transaction>? Transactions { get; set; }

    }



}
