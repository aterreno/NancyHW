﻿namespace NancyApplication1
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters => View["index"];
            Get["/hello"] = parameters => View["hello"];
        }
    }
}