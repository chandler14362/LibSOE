﻿namespace SOE.Database
{
    public interface IDatabaseBackend
    {
        void Connect(string host, int port);
    }
}
