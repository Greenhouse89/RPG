using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; } //data that is returned from the service
        public bool Success { get; set; } = true; //if the service was successful or not default is true
        public string Message { get; set; } = string.Empty; //message that is returned from the service
    }
}