﻿namespace Service.Interfaces
{
    public interface ICheckFile
    {
        bool VerifyFileNameExtension(string fileName);
        bool IsFileExists(string fileName);
    }
}
