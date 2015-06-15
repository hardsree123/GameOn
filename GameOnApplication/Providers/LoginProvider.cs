using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using GameOnApplication.Models;
using GameOnApplication.Interface;

namespace GameOnApplication.Providers
{
    /// <summary>
    /// public interface definitions
    /// </summary>
    public class LoginProvider : ILogin
    {
        private LoginProvider()
        {
        }
        public static LoginProvider Instance
        {
            [DebuggerStepThrough]
            get
            {
                return Nested.instance;
            }
        }

        /// <summary>
        /// Not to be called while using logic
        /// </summary>
        internal class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }
            internal static readonly LoginProvider instance = new LoginProvider();
        }

        public UserModel UserLogin(LoginModel userLoginCredentials)
        {
            return 
        }
    }
}