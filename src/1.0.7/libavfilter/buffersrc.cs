//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using FFmpeg;

namespace FFmpeg
{
    public unsafe static partial class libavfilter
    {
        [Flags]
        public enum AV_BUFFERSRC_FLAG
        {
            /// <summary>Do not check for format changes.</summary>
            AV_BUFFERSRC_FLAG_NO_CHECK_FORMAT = 1,
            /// <summary>Do not copy buffer data.</summary>
            AV_BUFFERSRC_FLAG_NO_COPY = 2,
            /// <summary>Immediately push the frame to the output.</summary>
            AV_BUFFERSRC_FLAG_PUSH = 4
        }

        /// <summary>
        /// Add buffer data in picref to buffer_src.
        /// 
        /// @param buffer_src  pointer to a buffer source context
        /// @param picref      a buffer reference, or NULL to mark EOF
        /// @param flags       a combination of AV_BUFFERSRC_FLAG_
        /// @return            >= 0 in case of success, a negative AVERROR code
        /// in case of failure
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersrc_add_ref")]
        public static extern int av_buffersrc_add_ref(libavfilter.AVFilterContext* buffer_src, libavfilter.AVFilterBufferRef* picref, int flags);

        /// <summary>
        /// Get the number of failed requests.
        /// 
        /// A failed request is when the request_frame method is called while no
        /// frame is present in the buffer.
        /// The number is reset when a frame is added.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersrc_get_nb_failed_requests")]
        public static extern uint av_buffersrc_get_nb_failed_requests(libavfilter.AVFilterContext* buffer_src);

        /// <summary>
        /// Add a buffer to the filtergraph s.
        /// 
        /// @param buf buffer containing frame data to be passed down the
        /// filtergraph.
        /// This function will take ownership of buf, the user must not free it.
        /// A NULL buf signals EOF -- i.e. no more frames will be sent to this
        /// filter.
        /// @deprecated Use av_buffersrc_add_ref(s, picref,
        /// AV_BUFFERSRC_FLAG_NO_COPY) instead.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersrc_buffer")]
        public static extern int av_buffersrc_buffer(libavfilter.AVFilterContext* s, libavfilter.AVFilterBufferRef* buf);

        /// <summary>
        /// Add a frame to the buffer source.
        /// 
        /// @param s an instance of the buffersrc filter.
        /// @param frame frame to be added.
        /// 
        /// @warning frame data will be memcpy()ed, which may be a big performance
        /// hit. Use av_buffersrc_buffer() to avoid copying the data.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersrc_write_frame")]
        public static extern int av_buffersrc_write_frame(libavfilter.AVFilterContext* s, libavcodec.AVFrame* frame);
    }
}