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
        /// @defgroup lavu_hmac HMAC
        /// @ingroup lavu_crypto
        /// @{
        /// </summary>
        public enum AVHMACType
        {
            AV_HMAC_MD5 = 0,
            AV_HMAC_SHA1 = 1,
            AV_HMAC_SHA224 = 2,
            AV_HMAC_SHA256 = 3,
            AV_HMAC_SHA224_DEPRECATED = 10,
            AV_HMAC_SHA256_DEPRECATED = 11,
            AV_HMAC_SHA384 = 12,
            AV_HMAC_SHA512 = 13
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVHMAC
        {
        }

        /// <summary>
        /// Allocate an AVHMAC context.
        /// </summary>
        /// <param name="type">
        /// The hash function used for the HMAC.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_hmac_alloc")]
        public static extern libavutil.AVHMAC* av_hmac_alloc(libavutil.AVHMACType type);

        /// <summary>
        /// Free an AVHMAC context.
        /// </summary>
        /// <param name="ctx">
        /// The context to free, may be NULL
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_hmac_free")]
        public static extern void av_hmac_free(libavutil.AVHMAC* ctx);

        /// <summary>
        /// Initialize an AVHMAC context with an authentication key.
        /// </summary>
        /// <param name="ctx">
        /// The HMAC context
        /// </param>
        /// <param name="key">
        /// The authentication key
        /// </param>
        /// <param name="keylen">
        /// The length of the key, in bytes
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_hmac_init")]
        public static extern void av_hmac_init(libavutil.AVHMAC* ctx, byte* key, uint keylen);

        /// <summary>
        /// Hash data with the HMAC.
        /// </summary>
        /// <param name="ctx">
        /// The HMAC context
        /// </param>
        /// <param name="data">
        /// The data to hash
        /// </param>
        /// <param name="len">
        /// The length of the data, in bytes
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_hmac_update")]
        public static extern void av_hmac_update(libavutil.AVHMAC* ctx, byte* data, uint len);

        /// <summary>
        /// Finish hashing and output the HMAC digest.
        /// </summary>
        /// <param name="ctx">
        /// The HMAC context
        /// </param>
        /// <param name="out">
        /// The output buffer to write the digest into
        /// </param>
        /// <param name="outlen">
        /// The length of the out buffer, in bytes
        /// </param>
        /// <returns>
        /// The number of bytes written to out, or a negative error code.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_hmac_final")]
        public static extern int av_hmac_final(libavutil.AVHMAC* ctx, byte* _out, uint outlen);

        /// <summary>
        /// Hash an array of data with a key.
        /// </summary>
        /// <param name="ctx">
        /// The HMAC context
        /// </param>
        /// <param name="data">
        /// The data to hash
        /// </param>
        /// <param name="len">
        /// The length of the data, in bytes
        /// </param>
        /// <param name="key">
        /// The authentication key
        /// </param>
        /// <param name="keylen">
        /// The length of the key, in bytes
        /// </param>
        /// <param name="out">
        /// The output buffer to write the digest into
        /// </param>
        /// <param name="outlen">
        /// The length of the out buffer, in bytes
        /// </param>
        /// <returns>
        /// The number of bytes written to out, or a negative error code.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_hmac_calc")]
        public static extern int av_hmac_calc(libavutil.AVHMAC* ctx, byte* data, uint len, byte* key, uint keylen, byte* _out, uint outlen);
    }
}