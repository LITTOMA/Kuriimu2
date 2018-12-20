﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontract.Interfaces.Archive
{
    public interface IArchiveAdapter
    {
        IEnumerable<ArchiveFileInfo> Files { get; }
    }
}
