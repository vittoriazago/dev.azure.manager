using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DevAzureManager.Models;
using Microsoft.Extensions.Configuration;

namespace DevAzureManager.Clients
{
    public abstract class BaseClient : IDisposable
    {
        public BaseClient(IConfiguration configuration)
        {
            Configuration = configuration;
            PAT = configuration["APPSETTINGS:TOKEN"];
            Login = configuration["APPSETTINGS:LOGIN"];
            Organization = configuration["APPSETTINGS:ORGANIZATION"];
            Project = configuration["APPSETTINGS:PROJECT"];
            BaseUri = configuration["APPSETTINGS:BASEURI"] + Organization + "/" + Project + "/";

            Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(
                        System.Text.ASCIIEncoding.ASCII.GetBytes(
                            string.Format("{0}:{1}", Login, PAT))));
        }
        public IConfiguration Configuration { get; }
        public HttpClient Client { get; }
        public string PAT { get; }
        public string Login { get; }
        public string Organization { get; }
        public string Project { get; }
        public string BaseUri { get; }

        private bool disposed = false;

        //Implement IDisposable.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free other state (managed objects).
                }
                // Free your own state (unmanaged objects).
                // Set large fields to null.
                disposed = true;
            }
        }

        // Use C# destructor syntax for finalization code.
        ~BaseClient()
        {
            // Simply call Dispose(false).
            Dispose(false);
        }
    }

}
