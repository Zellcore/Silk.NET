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

#pragma warning disable 1591

namespace Silk.NET.DirectComposition;

public unsafe static class DCompositionLinearTransferEffectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInput(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetInput(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, uint index, ref Silk.NET.Core.Native.IUnknown input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* inputPtr = &input)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, inputPtr, flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRedYIntercept(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, float redYIntercept)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[4])(@this, redYIntercept);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRedSlope(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, float redSlope)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[5])(@this, redSlope);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRedDisable(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, Silk.NET.Core.Bool32 redDisable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, redDisable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGreenYIntercept(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, float greenYIntercept)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[7])(@this, greenYIntercept);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGreenSlope(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, float greenSlope)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[8])(@this, greenSlope);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGreenDisable(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, Silk.NET.Core.Bool32 greenDisable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[9])(@this, greenDisable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBlueYIntercept(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, float blueYIntercept)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[10])(@this, blueYIntercept);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBlueSlope(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, float blueSlope)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[11])(@this, blueSlope);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBlueDisable(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, Silk.NET.Core.Bool32 blueDisable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[12])(@this, blueDisable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAlphaYIntercept(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, float alphaYIntercept)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[13])(@this, alphaYIntercept);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAlphaSlope(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, float alphaSlope)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)@this->LpVtbl[14])(@this, alphaSlope);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAlphaDisable(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, Silk.NET.Core.Bool32 alphaDisable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[15])(@this, alphaDisable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetClampOutput(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, Silk.NET.Core.Bool32 clampOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[16])(@this, clampOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetInput<TI0>(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, uint index, ComPtr<TI0> input, uint flags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetInput(index, (Silk.NET.Core.Native.IUnknown*) input.Handle, flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetInput(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl, uint index, Span<Silk.NET.Core.Native.IUnknown> input, uint flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetInput(index, ref input.GetPinnableReference(), flags);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDCompositionLinearTransferEffect> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
