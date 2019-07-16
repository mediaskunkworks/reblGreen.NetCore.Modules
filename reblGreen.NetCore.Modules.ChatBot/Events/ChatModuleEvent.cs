﻿/*
    The MIT License (MIT)

    Copyright (c) 2019 reblGreen Software Ltd. (https://reblgreen.com/)
    Repository Url: https://bitbucket.org/reblgreen/reblgreen.netcore.modules/

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.
 */

using System;
using System.Collections.Generic;
using reblGreen.NetCore.Modules.Interfaces;

namespace reblGreen.NetCore.Modules.ChatBot
{
    [Serializable]
    public class ChatModuleEvent : IEvent<ChatModuleEventInput, ChatModuleEventOutput>
    {
        /// <summary>
        /// Each IEvent must specify a name
        /// </summary>
        public EventName Name { get; } = "reblGreen.NetCore.Modules.ChatBot.ChatModuleEvent";

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, object> Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Handled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ChatModuleEventInput Input { get; } = new ChatModuleEventInput();

        /// <summary>
        /// 
        /// </summary>
        public ChatModuleEventOutput Output { get; set; }
    }
}