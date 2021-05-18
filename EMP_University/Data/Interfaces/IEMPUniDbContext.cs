using Common.Models;

using Data.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IEMPUniDbContext
    {
        DbSet<Course> Courses { get; set; }

        DbSet<Student> Students { get; set; }

        DbSet<StudentCourse> StudentCourse { get; set; }

        int SaveChanges();

        int SaveChanges(bool acceptAllChangesOnSuccess);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        EntityEntry Add([NotNull] object entity);

        EntityEntry<TEntity> Add<TEntity>([NotNull] TEntity entity) where TEntity : class;

        ValueTask<EntityEntry> AddAsync([NotNull] object entity, CancellationToken cancellationToken = default);

        ValueTask<EntityEntry<TEntity>> AddAsync<TEntity>([NotNull] TEntity entity, CancellationToken cancellationToken = default) where TEntity : class;

        EntityEntry Update([NotNull] object entity);

        EntityEntry<TEntity> Update<TEntity>([NotNull] TEntity entity) where TEntity : class;

        EntityEntry Remove([NotNull] object entity);

        EntityEntry<TEntity> Remove<TEntity>([NotNull] TEntity entity) where TEntity : class;
    }
}