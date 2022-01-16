﻿using Cthulhu.CoreLib.Services;
using System;
using System.Threading;

namespace Cthulhu.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(5000);
            DataHub.Client client = new DataHub.Client("http://localhost:5000/datahub");
            client.StartText();
        }
    }
}
