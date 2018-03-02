﻿using HashCode.Core.Domain;

namespace HashCode.Core.Interfaces
{
    public interface IFileService
    {
        FileContents ReadFile(string fileName);
        void WriteFile(Result result);
    }
}
