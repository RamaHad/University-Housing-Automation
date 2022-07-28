using DataBase.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class ApplicationDbContext:DbContext

    {
        public DbSet<RoleEntity> role { get; set; }
        public DbSet<UserEntity> users { get; set; }
        public DbSet<AccessoryEntity> accessories { get; set; }
        public DbSet<CityEntity> cities { get; set; }
        public DbSet<DateTypeEntity> dateTypes { get; set; }
        public DbSet<RoomEntity> rooms { get; set; }
        public DbSet<StoreDetailEntity> storeDetails { get; set; }
        public DbSet<StudentEntity> students { get; set; }
        public DbSet<StudentAccessoriesEntity> studentAccessories { get; set; }
        public DbSet<StudentDateEntity> studentDates { get; set; }
        public DbSet<StudyBranchEntity> studyBranches { get; set; }
        public DbSet<TimeSloteEntity> timeSlotes { get; set; }
        public DbSet<UnitRoomEntity> unitRooms { get; set; }
        public DbSet<UnitEntity> units { get; set; }
        public DbSet<UnitStoreEntity> unitStores { get; set; }


        protected  override void OnConfiguring(DbContextOptionsBuilder Builder)
        {
            base.OnConfiguring(Builder);
            Builder.UseSqlServer(@"Data Source=DESKTOP-79PJ7V9\SQLEXPRESS;Initial Catalog=OurProject4;Integrated Security=True");

        }

        
        protected  override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);
            Builder.Entity<UserEntity>()
                .HasIndex(u => u.UserName).IsUnique();
            //  //one-to-many
            //  Builder.Entity<User>()
            //  .HasOne<Role>()
            //  .WithMany()
            //  .HasForeignKey(b => b.RoleFk);

            //  Builder.Entity<Unit>()
            // .HasOne<StudyBranch>()
            // .WithMany()
            // .HasForeignKey(b => b.StudeyBranchFk);

            //  Builder.Entity<StoreDetails>()
            // .HasOne<Accessories>()
            // .WithMany()
            // .HasForeignKey(b => b.AccessoriesFk);


            //  Builder.Entity<StoreDetails>()
            // .HasOne<UnitStore>()
            // .WithMany()
            // .HasForeignKey(b => b.UnitStoreFk);

            // Builder.Entity<StudentAccessories>()
            // .HasOne<StoreDetails>()
            // .WithMany()
            // .HasForeignKey(b => b.StoreDetailsFk);

            //  Builder.Entity<UnitRoom>()
            // .HasOne<Room>()
            // .WithMany()
            // .HasForeignKey(b => b.UnitFk);

            //  Builder.Entity<UnitRoom>()
            // .HasOne<Unit>()
            // .WithMany()
            // .HasForeignKey(b => b.UnitFk);


            //  Builder.Entity<StudentDate>()
            // .HasOne<DateType>()
            // .WithMany()
            // .HasForeignKey(b => b.DateTypeFk);

            Builder.Entity<StudentEntity>()
           .HasOne<UnitRoomEntity>()
           .WithMany()
           .HasForeignKey(b => b.UnitRoomFk)
           .OnDelete(DeleteBehavior.NoAction);

            // // Builder.Entity<Student>()
            // //.HasOne<StudyBranch>()                  
            // //.WithMany()                             
            // //.HasForeignKey(b => b.StudentBranchFk);

            //  Builder.Entity<Student>()
            // .HasOne<City>()
            // .WithMany()
            // .HasForeignKey(b => b.CityFk);

            //  Builder.Entity<StudentAccessories>()
            // .HasOne<Student>()
            // .WithMany()
            // .HasForeignKey(b => b.StudentFk);

            Builder.Entity<CityEntity>()
           .HasOne<CityEntity>()
           .WithMany()
           .HasForeignKey(b => b.MainCity)
           .OnDelete(DeleteBehavior.NoAction);

            //  Builder.Entity<StudentDate>()
            //.HasOne<TimeSlote>()
            //.WithMany()
            //.HasForeignKey(b => b.TimeSloteFk);

            //one-to-one
            Builder.Entity<UnitEntity>()
            .HasOne<UserEntity>()
            .WithOne()
            .HasForeignKey<UnitEntity>(b=> b.UserFk )
            .OnDelete(DeleteBehavior.NoAction);

            Builder.Entity<UnitStoreEntity>()
           .HasOne<UserEntity>()
           .WithOne()
           .HasForeignKey<UnitStoreEntity>(b => b.UserFk);

            Builder.Entity<UnitEntity>()
           .HasOne<UnitStoreEntity>()
           .WithOne()
           .HasForeignKey<UnitEntity>(b => b.UnitStoreFk);

        }

    }
}
