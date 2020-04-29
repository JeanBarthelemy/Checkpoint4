﻿using System;
using Nancy.Hosting.Self;
using Checkpoint4WPF;


namespace Checkpoint4
{
    class Program
    {
        static void Main(string[] args)
        {
            var hostConfigs = new HostConfiguration
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            };

            Uri uri = new Uri("http://localhost:1234");
            using (var host = new NancyHost(hostConfigs, uri))
            {
                host.Start();
                Console.WriteLine("Running on http://localhost:1234");
                Console.ReadLine();
                host.Stop();
            }
        }


    }
}