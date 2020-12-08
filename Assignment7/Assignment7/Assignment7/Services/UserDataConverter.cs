using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using Assignment7.Models;
using Newtonsoft.Json;
using Assignment7;

namespace Assignment7.Services
{
   public class UserDataConverter
    {
		public List<User> users;

		public UserDataConverter()
        {
			var assembly = IntrospectionExtensions.GetTypeInfo(typeof(UserDataConverter)).Assembly;
			Stream stream = assembly.GetManifestResourceStream("Assignment7.UserData.json");

			
			using (var reader = new StreamReader(stream))
			{
				var json = reader.ReadToEnd();
				var rootobject = JsonConvert.DeserializeObject<Rootobject>(json);
				users = rootobject.users;
				
			}

		}

		public List<User> GetData()
        {
			return users;
        }

    }
}
