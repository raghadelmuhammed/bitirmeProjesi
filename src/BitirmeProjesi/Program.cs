﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace BitirmeProjesi
{
    public class Program
    {
        public static void Main(string[] args)
        {
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.Build()
				.Run();
        }
    }
}
