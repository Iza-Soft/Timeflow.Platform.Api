﻿using Timeflow.Platform.Api.Boundary.Request.Abstract;

namespace Timeflow.Platform.Api.Boundary.Request.Class
{
    public class ProjectQuery : RequestViewModel
    {
        public Guid UserId { get; set; }
    }
}
