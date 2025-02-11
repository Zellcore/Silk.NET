// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.WGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.NV
{
    [Extension("NV_present_video")]
    public unsafe partial class NVPresentVideo : NativeExtension<WGL>
    {
        public const string ExtensionName = "NV_present_video";
        [NativeApi(EntryPoint = "wglBindVideoDeviceNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 BindVideoDevice([Flow(FlowDirection.In)] nint hDc, [Flow(FlowDirection.In)] uint uVideoSlot, [Flow(FlowDirection.In)] nint hVideoDevice, [Flow(FlowDirection.In)] int* piAttribList);

        [NativeApi(EntryPoint = "wglBindVideoDeviceNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 BindVideoDevice([Flow(FlowDirection.In)] nint hDc, [Flow(FlowDirection.In)] uint uVideoSlot, [Flow(FlowDirection.In)] nint hVideoDevice, [Flow(FlowDirection.In)] in int piAttribList);

        [NativeApi(EntryPoint = "wglEnumerateVideoDevicesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnumerateVideoDevices([Flow(FlowDirection.In)] nint hDc, [Flow(FlowDirection.Out)] nint* phDeviceList);

        [NativeApi(EntryPoint = "wglEnumerateVideoDevicesNV", Convention = CallingConvention.Winapi)]
        public partial int EnumerateVideoDevices([Flow(FlowDirection.In)] nint hDc, [Flow(FlowDirection.Out)] out nint phDeviceList);

        [NativeApi(EntryPoint = "wglQueryCurrentContextNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryCurrentContext([Flow(FlowDirection.In)] int iAttribute, [Flow(FlowDirection.Out)] int* piValue);

        [NativeApi(EntryPoint = "wglQueryCurrentContextNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 QueryCurrentContext([Flow(FlowDirection.In)] int iAttribute, [Flow(FlowDirection.Out)] out int piValue);

        public NVPresentVideo(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

