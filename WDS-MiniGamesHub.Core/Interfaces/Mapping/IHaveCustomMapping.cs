﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace WDS_MiniGamesHub.Core.Interfaces.Mapping
{
    public interface IHaveCustomMapping
    {
        void CreateMappings(Profile configuration);
    }
}
