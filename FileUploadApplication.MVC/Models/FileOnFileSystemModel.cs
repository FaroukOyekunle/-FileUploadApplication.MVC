using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploadApplication.MVC.Models;

public class FileOnFileSystemModel : FileModel
{
    public string FilePath { get; set; }
}
