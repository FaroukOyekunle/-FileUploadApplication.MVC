using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FileUploadApplication.MVC.Models;

namespace FileUploadApplication.MVC.Data
{
    public class FileUploadApplicationDbContext
    {
        public FileUploadApplicationDbContext(DbContextOptions<FileUploadApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<FileOnDatabaseModel> FilesOnDatabase { get; set; }
        public DbSet<FileOnFileSystemModel> FilesOnFileSystem { get; set; }
    }
}