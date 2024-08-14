// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.SDL2
{
	public unsafe partial class SDL
	{

		/// <summary>
		/// Unload the Vulkan library previously loaded by SDL_Vulkan_LoadLibrary()<br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_UnloadLibrary")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void SDLVulkanUnloadLibrary()
		{
			SDLVulkanUnloadLibraryNative();
		}

		/// <summary>
		/// Get the names of the Vulkan instance extensions needed to create a surface<br/>
		/// with SDL_Vulkan_CreateSurface.<br/>
		/// If `pNames` is NULL, then the number of required Vulkan instance extensions<br/>
		/// is returned in `pCount`. Otherwise, `pCount` must point to a variable set<br/>
		/// to the number of elements in the `pNames` array, and on return the variable<br/>
		/// is overwritten with the number of names actually written to `pNames`. If<br/>
		/// `pCount` is less than the number of required extensions, at most `pCount`<br/>
		/// structures will be written. If `pCount` is smaller than the number of<br/>
		/// required extensions, SDL_FALSE will be returned instead of SDL_TRUE, to<br/>
		/// indicate that not all the required extensions were returned.<br/>
		/// The `window` parameter is currently needed to be valid as of SDL 2.0.8,<br/>
		/// however, this parameter will likely be removed in future releases<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetInstanceExtensions")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		internal static SDLBool SDLVulkanGetInstanceExtensionsNative([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] SDLWindow* window, [NativeName(NativeNameType.Param, "pCount")] [NativeName(NativeNameType.Type, "unsigned int*")] uint* pCount, [NativeName(NativeNameType.Param, "pNames")] [NativeName(NativeNameType.Type, "const char**")] byte** pNames)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, uint*, byte**, SDLBool>)vt[1420])(window, pCount, pNames);
			#else
			return (SDLBool)((delegate* unmanaged[Cdecl]<nint, nint, nint, SDLBool>)vt[1420])((nint)window, (nint)pCount, (nint)pNames);
			#endif
		}

		/// <summary>
		/// Get the names of the Vulkan instance extensions needed to create a surface<br/>
		/// with SDL_Vulkan_CreateSurface.<br/>
		/// If `pNames` is NULL, then the number of required Vulkan instance extensions<br/>
		/// is returned in `pCount`. Otherwise, `pCount` must point to a variable set<br/>
		/// to the number of elements in the `pNames` array, and on return the variable<br/>
		/// is overwritten with the number of names actually written to `pNames`. If<br/>
		/// `pCount` is less than the number of required extensions, at most `pCount`<br/>
		/// structures will be written. If `pCount` is smaller than the number of<br/>
		/// required extensions, SDL_FALSE will be returned instead of SDL_TRUE, to<br/>
		/// indicate that not all the required extensions were returned.<br/>
		/// The `window` parameter is currently needed to be valid as of SDL 2.0.8,<br/>
		/// however, this parameter will likely be removed in future releases<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetInstanceExtensions")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		public static SDLBool SDLVulkanGetInstanceExtensions([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] SDLWindow* window, [NativeName(NativeNameType.Param, "pCount")] [NativeName(NativeNameType.Type, "unsigned int*")] uint* pCount, [NativeName(NativeNameType.Param, "pNames")] [NativeName(NativeNameType.Type, "const char**")] byte** pNames)
		{
			SDLBool ret = SDLVulkanGetInstanceExtensionsNative(window, pCount, pNames);
			return ret;
		}

		/// <summary>
		/// Get the names of the Vulkan instance extensions needed to create a surface<br/>
		/// with SDL_Vulkan_CreateSurface.<br/>
		/// If `pNames` is NULL, then the number of required Vulkan instance extensions<br/>
		/// is returned in `pCount`. Otherwise, `pCount` must point to a variable set<br/>
		/// to the number of elements in the `pNames` array, and on return the variable<br/>
		/// is overwritten with the number of names actually written to `pNames`. If<br/>
		/// `pCount` is less than the number of required extensions, at most `pCount`<br/>
		/// structures will be written. If `pCount` is smaller than the number of<br/>
		/// required extensions, SDL_FALSE will be returned instead of SDL_TRUE, to<br/>
		/// indicate that not all the required extensions were returned.<br/>
		/// The `window` parameter is currently needed to be valid as of SDL 2.0.8,<br/>
		/// however, this parameter will likely be removed in future releases<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetInstanceExtensions")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		public static SDLBool SDLVulkanGetInstanceExtensions([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] ref SDLWindow window, [NativeName(NativeNameType.Param, "pCount")] [NativeName(NativeNameType.Type, "unsigned int*")] uint* pCount, [NativeName(NativeNameType.Param, "pNames")] [NativeName(NativeNameType.Type, "const char**")] byte** pNames)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				SDLBool ret = SDLVulkanGetInstanceExtensionsNative((SDLWindow*)pwindow, pCount, pNames);
				return ret;
			}
		}

		/// <summary>
		/// Get the names of the Vulkan instance extensions needed to create a surface<br/>
		/// with SDL_Vulkan_CreateSurface.<br/>
		/// If `pNames` is NULL, then the number of required Vulkan instance extensions<br/>
		/// is returned in `pCount`. Otherwise, `pCount` must point to a variable set<br/>
		/// to the number of elements in the `pNames` array, and on return the variable<br/>
		/// is overwritten with the number of names actually written to `pNames`. If<br/>
		/// `pCount` is less than the number of required extensions, at most `pCount`<br/>
		/// structures will be written. If `pCount` is smaller than the number of<br/>
		/// required extensions, SDL_FALSE will be returned instead of SDL_TRUE, to<br/>
		/// indicate that not all the required extensions were returned.<br/>
		/// The `window` parameter is currently needed to be valid as of SDL 2.0.8,<br/>
		/// however, this parameter will likely be removed in future releases<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetInstanceExtensions")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		public static SDLBool SDLVulkanGetInstanceExtensions([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] SDLWindow* window, [NativeName(NativeNameType.Param, "pCount")] [NativeName(NativeNameType.Type, "unsigned int*")] ref uint pCount, [NativeName(NativeNameType.Param, "pNames")] [NativeName(NativeNameType.Type, "const char**")] byte** pNames)
		{
			fixed (uint* ppCount = &pCount)
			{
				SDLBool ret = SDLVulkanGetInstanceExtensionsNative(window, (uint*)ppCount, pNames);
				return ret;
			}
		}

		/// <summary>
		/// Get the names of the Vulkan instance extensions needed to create a surface<br/>
		/// with SDL_Vulkan_CreateSurface.<br/>
		/// If `pNames` is NULL, then the number of required Vulkan instance extensions<br/>
		/// is returned in `pCount`. Otherwise, `pCount` must point to a variable set<br/>
		/// to the number of elements in the `pNames` array, and on return the variable<br/>
		/// is overwritten with the number of names actually written to `pNames`. If<br/>
		/// `pCount` is less than the number of required extensions, at most `pCount`<br/>
		/// structures will be written. If `pCount` is smaller than the number of<br/>
		/// required extensions, SDL_FALSE will be returned instead of SDL_TRUE, to<br/>
		/// indicate that not all the required extensions were returned.<br/>
		/// The `window` parameter is currently needed to be valid as of SDL 2.0.8,<br/>
		/// however, this parameter will likely be removed in future releases<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetInstanceExtensions")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		public static SDLBool SDLVulkanGetInstanceExtensions([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] ref SDLWindow window, [NativeName(NativeNameType.Param, "pCount")] [NativeName(NativeNameType.Type, "unsigned int*")] ref uint pCount, [NativeName(NativeNameType.Param, "pNames")] [NativeName(NativeNameType.Type, "const char**")] byte** pNames)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				fixed (uint* ppCount = &pCount)
				{
					SDLBool ret = SDLVulkanGetInstanceExtensionsNative((SDLWindow*)pwindow, (uint*)ppCount, pNames);
					return ret;
				}
			}
		}

		/// <summary>
		/// Get the names of the Vulkan instance extensions needed to create a surface<br/>
		/// with SDL_Vulkan_CreateSurface.<br/>
		/// If `pNames` is NULL, then the number of required Vulkan instance extensions<br/>
		/// is returned in `pCount`. Otherwise, `pCount` must point to a variable set<br/>
		/// to the number of elements in the `pNames` array, and on return the variable<br/>
		/// is overwritten with the number of names actually written to `pNames`. If<br/>
		/// `pCount` is less than the number of required extensions, at most `pCount`<br/>
		/// structures will be written. If `pCount` is smaller than the number of<br/>
		/// required extensions, SDL_FALSE will be returned instead of SDL_TRUE, to<br/>
		/// indicate that not all the required extensions were returned.<br/>
		/// The `window` parameter is currently needed to be valid as of SDL 2.0.8,<br/>
		/// however, this parameter will likely be removed in future releases<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetInstanceExtensions")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		public static SDLBool SDLVulkanGetInstanceExtensions([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] SDLWindow* window, [NativeName(NativeNameType.Param, "pCount")] [NativeName(NativeNameType.Type, "unsigned int*")] uint* pCount, [NativeName(NativeNameType.Param, "pNames")] [NativeName(NativeNameType.Type, "const char**")] ref byte* pNames)
		{
			fixed (byte** ppNames = &pNames)
			{
				SDLBool ret = SDLVulkanGetInstanceExtensionsNative(window, pCount, (byte**)ppNames);
				return ret;
			}
		}

		/// <summary>
		/// Get the names of the Vulkan instance extensions needed to create a surface<br/>
		/// with SDL_Vulkan_CreateSurface.<br/>
		/// If `pNames` is NULL, then the number of required Vulkan instance extensions<br/>
		/// is returned in `pCount`. Otherwise, `pCount` must point to a variable set<br/>
		/// to the number of elements in the `pNames` array, and on return the variable<br/>
		/// is overwritten with the number of names actually written to `pNames`. If<br/>
		/// `pCount` is less than the number of required extensions, at most `pCount`<br/>
		/// structures will be written. If `pCount` is smaller than the number of<br/>
		/// required extensions, SDL_FALSE will be returned instead of SDL_TRUE, to<br/>
		/// indicate that not all the required extensions were returned.<br/>
		/// The `window` parameter is currently needed to be valid as of SDL 2.0.8,<br/>
		/// however, this parameter will likely be removed in future releases<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetInstanceExtensions")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		public static SDLBool SDLVulkanGetInstanceExtensions([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] ref SDLWindow window, [NativeName(NativeNameType.Param, "pCount")] [NativeName(NativeNameType.Type, "unsigned int*")] uint* pCount, [NativeName(NativeNameType.Param, "pNames")] [NativeName(NativeNameType.Type, "const char**")] ref byte* pNames)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				fixed (byte** ppNames = &pNames)
				{
					SDLBool ret = SDLVulkanGetInstanceExtensionsNative((SDLWindow*)pwindow, pCount, (byte**)ppNames);
					return ret;
				}
			}
		}

		/// <summary>
		/// Get the names of the Vulkan instance extensions needed to create a surface<br/>
		/// with SDL_Vulkan_CreateSurface.<br/>
		/// If `pNames` is NULL, then the number of required Vulkan instance extensions<br/>
		/// is returned in `pCount`. Otherwise, `pCount` must point to a variable set<br/>
		/// to the number of elements in the `pNames` array, and on return the variable<br/>
		/// is overwritten with the number of names actually written to `pNames`. If<br/>
		/// `pCount` is less than the number of required extensions, at most `pCount`<br/>
		/// structures will be written. If `pCount` is smaller than the number of<br/>
		/// required extensions, SDL_FALSE will be returned instead of SDL_TRUE, to<br/>
		/// indicate that not all the required extensions were returned.<br/>
		/// The `window` parameter is currently needed to be valid as of SDL 2.0.8,<br/>
		/// however, this parameter will likely be removed in future releases<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetInstanceExtensions")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		public static SDLBool SDLVulkanGetInstanceExtensions([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] SDLWindow* window, [NativeName(NativeNameType.Param, "pCount")] [NativeName(NativeNameType.Type, "unsigned int*")] ref uint pCount, [NativeName(NativeNameType.Param, "pNames")] [NativeName(NativeNameType.Type, "const char**")] ref byte* pNames)
		{
			fixed (uint* ppCount = &pCount)
			{
				fixed (byte** ppNames = &pNames)
				{
					SDLBool ret = SDLVulkanGetInstanceExtensionsNative(window, (uint*)ppCount, (byte**)ppNames);
					return ret;
				}
			}
		}

		/// <summary>
		/// Get the names of the Vulkan instance extensions needed to create a surface<br/>
		/// with SDL_Vulkan_CreateSurface.<br/>
		/// If `pNames` is NULL, then the number of required Vulkan instance extensions<br/>
		/// is returned in `pCount`. Otherwise, `pCount` must point to a variable set<br/>
		/// to the number of elements in the `pNames` array, and on return the variable<br/>
		/// is overwritten with the number of names actually written to `pNames`. If<br/>
		/// `pCount` is less than the number of required extensions, at most `pCount`<br/>
		/// structures will be written. If `pCount` is smaller than the number of<br/>
		/// required extensions, SDL_FALSE will be returned instead of SDL_TRUE, to<br/>
		/// indicate that not all the required extensions were returned.<br/>
		/// The `window` parameter is currently needed to be valid as of SDL 2.0.8,<br/>
		/// however, this parameter will likely be removed in future releases<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetInstanceExtensions")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		public static SDLBool SDLVulkanGetInstanceExtensions([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] ref SDLWindow window, [NativeName(NativeNameType.Param, "pCount")] [NativeName(NativeNameType.Type, "unsigned int*")] ref uint pCount, [NativeName(NativeNameType.Param, "pNames")] [NativeName(NativeNameType.Type, "const char**")] ref byte* pNames)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				fixed (uint* ppCount = &pCount)
				{
					fixed (byte** ppNames = &pNames)
					{
						SDLBool ret = SDLVulkanGetInstanceExtensionsNative((SDLWindow*)pwindow, (uint*)ppCount, (byte**)ppNames);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// Create a Vulkan rendering surface for a window.<br/>
		/// The `window` must have been created with the `SDL_WINDOW_VULKAN` flag and<br/>
		/// `instance` must have been created with extensions returned by<br/>
		/// SDL_Vulkan_GetInstanceExtensions() enabled.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_CreateSurface")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		internal static SDLBool SDLVulkanCreateSurfaceNative([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] SDLWindow* window, [NativeName(NativeNameType.Param, "instance")] [NativeName(NativeNameType.Type, "VkInstance")] VkInstance instance, [NativeName(NativeNameType.Param, "surface")] [NativeName(NativeNameType.Type, "VkSurfaceKHR*")] VkSurfaceKHR* surface)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, VkInstance, VkSurfaceKHR*, SDLBool>)vt[1421])(window, instance, surface);
			#else
			return (SDLBool)((delegate* unmanaged[Cdecl]<nint, VkInstance, nint, SDLBool>)vt[1421])((nint)window, instance, (nint)surface);
			#endif
		}

		/// <summary>
		/// Create a Vulkan rendering surface for a window.<br/>
		/// The `window` must have been created with the `SDL_WINDOW_VULKAN` flag and<br/>
		/// `instance` must have been created with extensions returned by<br/>
		/// SDL_Vulkan_GetInstanceExtensions() enabled.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_CreateSurface")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		public static SDLBool SDLVulkanCreateSurface([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] SDLWindow* window, [NativeName(NativeNameType.Param, "instance")] [NativeName(NativeNameType.Type, "VkInstance")] VkInstance instance, [NativeName(NativeNameType.Param, "surface")] [NativeName(NativeNameType.Type, "VkSurfaceKHR*")] VkSurfaceKHR* surface)
		{
			SDLBool ret = SDLVulkanCreateSurfaceNative(window, instance, surface);
			return ret;
		}

		/// <summary>
		/// Create a Vulkan rendering surface for a window.<br/>
		/// The `window` must have been created with the `SDL_WINDOW_VULKAN` flag and<br/>
		/// `instance` must have been created with extensions returned by<br/>
		/// SDL_Vulkan_GetInstanceExtensions() enabled.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_CreateSurface")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		public static SDLBool SDLVulkanCreateSurface([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] ref SDLWindow window, [NativeName(NativeNameType.Param, "instance")] [NativeName(NativeNameType.Type, "VkInstance")] VkInstance instance, [NativeName(NativeNameType.Param, "surface")] [NativeName(NativeNameType.Type, "VkSurfaceKHR*")] VkSurfaceKHR* surface)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				SDLBool ret = SDLVulkanCreateSurfaceNative((SDLWindow*)pwindow, instance, surface);
				return ret;
			}
		}

		/// <summary>
		/// Create a Vulkan rendering surface for a window.<br/>
		/// The `window` must have been created with the `SDL_WINDOW_VULKAN` flag and<br/>
		/// `instance` must have been created with extensions returned by<br/>
		/// SDL_Vulkan_GetInstanceExtensions() enabled.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_CreateSurface")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		public static SDLBool SDLVulkanCreateSurface([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] SDLWindow* window, [NativeName(NativeNameType.Param, "instance")] [NativeName(NativeNameType.Type, "VkInstance")] VkInstance instance, [NativeName(NativeNameType.Param, "surface")] [NativeName(NativeNameType.Type, "VkSurfaceKHR*")] ref VkSurfaceKHR surface)
		{
			fixed (VkSurfaceKHR* psurface = &surface)
			{
				SDLBool ret = SDLVulkanCreateSurfaceNative(window, instance, (VkSurfaceKHR*)psurface);
				return ret;
			}
		}

		/// <summary>
		/// Create a Vulkan rendering surface for a window.<br/>
		/// The `window` must have been created with the `SDL_WINDOW_VULKAN` flag and<br/>
		/// `instance` must have been created with extensions returned by<br/>
		/// SDL_Vulkan_GetInstanceExtensions() enabled.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_CreateSurface")]
		[return: NativeName(NativeNameType.Type, "SDL_bool")]
		public static SDLBool SDLVulkanCreateSurface([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] ref SDLWindow window, [NativeName(NativeNameType.Param, "instance")] [NativeName(NativeNameType.Type, "VkInstance")] VkInstance instance, [NativeName(NativeNameType.Param, "surface")] [NativeName(NativeNameType.Type, "VkSurfaceKHR*")] ref VkSurfaceKHR surface)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				fixed (VkSurfaceKHR* psurface = &surface)
				{
					SDLBool ret = SDLVulkanCreateSurfaceNative((SDLWindow*)pwindow, instance, (VkSurfaceKHR*)psurface);
					return ret;
				}
			}
		}

		/// <summary>
		/// Get the size of the window's underlying drawable dimensions in pixels.<br/>
		/// This may differ from SDL_GetWindowSize() if we're rendering to a high-DPI<br/>
		/// drawable, i.e. the window was created with `SDL_WINDOW_ALLOW_HIGHDPI` on a<br/>
		/// platform with high-DPI support (Apple calls this "Retina"), and not<br/>
		/// disabled by the `SDL_HINT_VIDEO_HIGHDPI_DISABLED` hint.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetDrawableSize")]
		[return: NativeName(NativeNameType.Type, "void")]
		internal static void SDLVulkanGetDrawableSizeNative([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] SDLWindow* window, [NativeName(NativeNameType.Param, "w")] [NativeName(NativeNameType.Type, "int*")] int* w, [NativeName(NativeNameType.Param, "h")] [NativeName(NativeNameType.Type, "int*")] int* h)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<SDLWindow*, int*, int*, void>)vt[1422])(window, w, h);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, nint, void>)vt[1422])((nint)window, (nint)w, (nint)h);
			#endif
		}

		/// <summary>
		/// Get the size of the window's underlying drawable dimensions in pixels.<br/>
		/// This may differ from SDL_GetWindowSize() if we're rendering to a high-DPI<br/>
		/// drawable, i.e. the window was created with `SDL_WINDOW_ALLOW_HIGHDPI` on a<br/>
		/// platform with high-DPI support (Apple calls this "Retina"), and not<br/>
		/// disabled by the `SDL_HINT_VIDEO_HIGHDPI_DISABLED` hint.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetDrawableSize")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void SDLVulkanGetDrawableSize([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] SDLWindow* window, [NativeName(NativeNameType.Param, "w")] [NativeName(NativeNameType.Type, "int*")] int* w, [NativeName(NativeNameType.Param, "h")] [NativeName(NativeNameType.Type, "int*")] int* h)
		{
			SDLVulkanGetDrawableSizeNative(window, w, h);
		}

		/// <summary>
		/// Get the size of the window's underlying drawable dimensions in pixels.<br/>
		/// This may differ from SDL_GetWindowSize() if we're rendering to a high-DPI<br/>
		/// drawable, i.e. the window was created with `SDL_WINDOW_ALLOW_HIGHDPI` on a<br/>
		/// platform with high-DPI support (Apple calls this "Retina"), and not<br/>
		/// disabled by the `SDL_HINT_VIDEO_HIGHDPI_DISABLED` hint.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetDrawableSize")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void SDLVulkanGetDrawableSize([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] ref SDLWindow window, [NativeName(NativeNameType.Param, "w")] [NativeName(NativeNameType.Type, "int*")] int* w, [NativeName(NativeNameType.Param, "h")] [NativeName(NativeNameType.Type, "int*")] int* h)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				SDLVulkanGetDrawableSizeNative((SDLWindow*)pwindow, w, h);
			}
		}

		/// <summary>
		/// Get the size of the window's underlying drawable dimensions in pixels.<br/>
		/// This may differ from SDL_GetWindowSize() if we're rendering to a high-DPI<br/>
		/// drawable, i.e. the window was created with `SDL_WINDOW_ALLOW_HIGHDPI` on a<br/>
		/// platform with high-DPI support (Apple calls this "Retina"), and not<br/>
		/// disabled by the `SDL_HINT_VIDEO_HIGHDPI_DISABLED` hint.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetDrawableSize")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void SDLVulkanGetDrawableSize([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] SDLWindow* window, [NativeName(NativeNameType.Param, "w")] [NativeName(NativeNameType.Type, "int*")] ref int w, [NativeName(NativeNameType.Param, "h")] [NativeName(NativeNameType.Type, "int*")] int* h)
		{
			fixed (int* pw = &w)
			{
				SDLVulkanGetDrawableSizeNative(window, (int*)pw, h);
			}
		}

		/// <summary>
		/// Get the size of the window's underlying drawable dimensions in pixels.<br/>
		/// This may differ from SDL_GetWindowSize() if we're rendering to a high-DPI<br/>
		/// drawable, i.e. the window was created with `SDL_WINDOW_ALLOW_HIGHDPI` on a<br/>
		/// platform with high-DPI support (Apple calls this "Retina"), and not<br/>
		/// disabled by the `SDL_HINT_VIDEO_HIGHDPI_DISABLED` hint.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetDrawableSize")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void SDLVulkanGetDrawableSize([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] ref SDLWindow window, [NativeName(NativeNameType.Param, "w")] [NativeName(NativeNameType.Type, "int*")] ref int w, [NativeName(NativeNameType.Param, "h")] [NativeName(NativeNameType.Type, "int*")] int* h)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				fixed (int* pw = &w)
				{
					SDLVulkanGetDrawableSizeNative((SDLWindow*)pwindow, (int*)pw, h);
				}
			}
		}

		/// <summary>
		/// Get the size of the window's underlying drawable dimensions in pixels.<br/>
		/// This may differ from SDL_GetWindowSize() if we're rendering to a high-DPI<br/>
		/// drawable, i.e. the window was created with `SDL_WINDOW_ALLOW_HIGHDPI` on a<br/>
		/// platform with high-DPI support (Apple calls this "Retina"), and not<br/>
		/// disabled by the `SDL_HINT_VIDEO_HIGHDPI_DISABLED` hint.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetDrawableSize")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void SDLVulkanGetDrawableSize([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] SDLWindow* window, [NativeName(NativeNameType.Param, "w")] [NativeName(NativeNameType.Type, "int*")] int* w, [NativeName(NativeNameType.Param, "h")] [NativeName(NativeNameType.Type, "int*")] ref int h)
		{
			fixed (int* ph = &h)
			{
				SDLVulkanGetDrawableSizeNative(window, w, (int*)ph);
			}
		}

		/// <summary>
		/// Get the size of the window's underlying drawable dimensions in pixels.<br/>
		/// This may differ from SDL_GetWindowSize() if we're rendering to a high-DPI<br/>
		/// drawable, i.e. the window was created with `SDL_WINDOW_ALLOW_HIGHDPI` on a<br/>
		/// platform with high-DPI support (Apple calls this "Retina"), and not<br/>
		/// disabled by the `SDL_HINT_VIDEO_HIGHDPI_DISABLED` hint.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetDrawableSize")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void SDLVulkanGetDrawableSize([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] ref SDLWindow window, [NativeName(NativeNameType.Param, "w")] [NativeName(NativeNameType.Type, "int*")] int* w, [NativeName(NativeNameType.Param, "h")] [NativeName(NativeNameType.Type, "int*")] ref int h)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				fixed (int* ph = &h)
				{
					SDLVulkanGetDrawableSizeNative((SDLWindow*)pwindow, w, (int*)ph);
				}
			}
		}

		/// <summary>
		/// Get the size of the window's underlying drawable dimensions in pixels.<br/>
		/// This may differ from SDL_GetWindowSize() if we're rendering to a high-DPI<br/>
		/// drawable, i.e. the window was created with `SDL_WINDOW_ALLOW_HIGHDPI` on a<br/>
		/// platform with high-DPI support (Apple calls this "Retina"), and not<br/>
		/// disabled by the `SDL_HINT_VIDEO_HIGHDPI_DISABLED` hint.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetDrawableSize")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void SDLVulkanGetDrawableSize([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] SDLWindow* window, [NativeName(NativeNameType.Param, "w")] [NativeName(NativeNameType.Type, "int*")] ref int w, [NativeName(NativeNameType.Param, "h")] [NativeName(NativeNameType.Type, "int*")] ref int h)
		{
			fixed (int* pw = &w)
			{
				fixed (int* ph = &h)
				{
					SDLVulkanGetDrawableSizeNative(window, (int*)pw, (int*)ph);
				}
			}
		}

		/// <summary>
		/// Get the size of the window's underlying drawable dimensions in pixels.<br/>
		/// This may differ from SDL_GetWindowSize() if we're rendering to a high-DPI<br/>
		/// drawable, i.e. the window was created with `SDL_WINDOW_ALLOW_HIGHDPI` on a<br/>
		/// platform with high-DPI support (Apple calls this "Retina"), and not<br/>
		/// disabled by the `SDL_HINT_VIDEO_HIGHDPI_DISABLED` hint.<br/>
		/// <br/>
		/// <br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "SDL_Vulkan_GetDrawableSize")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void SDLVulkanGetDrawableSize([NativeName(NativeNameType.Param, "window")] [NativeName(NativeNameType.Type, "SDL_Window*")] ref SDLWindow window, [NativeName(NativeNameType.Param, "w")] [NativeName(NativeNameType.Type, "int*")] ref int w, [NativeName(NativeNameType.Param, "h")] [NativeName(NativeNameType.Type, "int*")] ref int h)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				fixed (int* pw = &w)
				{
					fixed (int* ph = &h)
					{
						SDLVulkanGetDrawableSizeNative((SDLWindow*)pwindow, (int*)pw, (int*)ph);
					}
				}
			}
		}

	}
}
