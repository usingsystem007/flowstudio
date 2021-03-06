﻿// Copyright (C) 2013 João Pedro Correia - All Rights Reserved
// Code under the terms of the GPLv2 license
// URL: https://github.com/JoaoPe/flowstudio

namespace FlowStudio.Presentation.ViewModel.Data
{
    using System;

    public class OutlineFlowNodeItem : OutlineItem
    {
        public Type FlowNodeType { get; private set; }

        public OutlineFlowNodeItem(Type flowNodeType)
        {
            FlowNodeType = flowNodeType;
        }
    }
}
