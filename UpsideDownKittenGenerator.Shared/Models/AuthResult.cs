﻿using System.Collections.Generic;

namespace UpsideDownKittenGenerator.Shared
{
    public class AuthResult
    {
        public string Token { get; set; }
        public bool Result { get; set; }
        public List<string> Errors { get; set; }
    }

}
