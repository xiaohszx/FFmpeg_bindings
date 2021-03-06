//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FFmpeg
{
    public unsafe static partial class libavutil
    {
        /// <summary>
        /// @defgroup lavu_xtea XTEA
        /// @ingroup lavu_crypto
        /// @{
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVXTEA
        {
            public fixed uint key[16];
        }

        /// <summary>
        /// Initialize an AVXTEA context.
        /// 
        /// @param ctx an AVXTEA context
        /// @param key a key of 16 bytes used for encryption/decryption
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_xtea_init")]
        public static extern void av_xtea_init(libavutil.AVXTEA* ctx, byte* key);

        /// <summary>
        /// Encrypt or decrypt a buffer using a previously initialized context.
        /// 
        /// @param ctx an AVXTEA context
        /// @param dst destination array, can be equal to src
        /// @param src source array, can be equal to dst
        /// @param count number of 8 byte blocks
        /// @param iv initialization vector for CBC mode, if NULL then ECB will be
        /// used
        /// @param decrypt 0 for encryption, 1 for decryption
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_xtea_crypt")]
        public static extern void av_xtea_crypt(libavutil.AVXTEA* ctx, byte* dst, byte* src, int count, byte* iv, int decrypt);
    }
}
