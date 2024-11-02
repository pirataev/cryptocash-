using Microsoft.EntityFrameworkCore;

namespace CryptoAnalyzer.Infrastructure;

public class CryptoAnalyzerDbContext : DbContext
{
    public CryptoAnalyzerDbContext(DbContextOptions<CryptoAnalyzerDbContext> options)
        : base(options) { }
}
