//
// WARNING - GENERATED CODE - DO NOT EDIT
//
// UIEvent.cs
//
// Author:
//   Aaron Bockover <abock@xamarin.com>
//
// Copyright 2015-2016 Xamarin Inc. All rights reserved.

using System;
using mshtml;

namespace Xamarin.CrossBrowser
{
    public partial class UIEvent : Event
    {
        internal UIEvent (ScriptContext context, IDOMUIEvent comObject) : base (context, (IDOMEvent)comObject)
        {
        }
    }
}