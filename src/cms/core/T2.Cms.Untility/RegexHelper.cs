﻿//
// Copyright 2011 @ TO2.NET,All rights reseved.
// Name: RegexHelper.cs
// publisher_id: newmin
//

using System;
using System.Text.RegularExpressions;

namespace T2.Cms.Utility
{
    public class RegexHelper
    {
        public static string FilterHtml(string html)
        {
            return Regex.Replace(html, "(<[^>]+>)|(&(\\w)+;)|(\\s)", String.Empty, RegexOptions.IgnoreCase);
        }
    }
}
