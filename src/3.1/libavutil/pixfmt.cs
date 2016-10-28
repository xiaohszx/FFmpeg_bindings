//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
// ReSharper disable RedundantUsingDirective
// ReSharper disable CheckNamespace
#pragma warning disable 1584,1711,1572,1581,1580,1573
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FFmpeg
{
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "UnusedMember.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "InconsistentNaming")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "RedundantUnsafeContext")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "MemberCanBePrivate.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "MemberCanBePrivate.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "FieldCanBeMadeReadOnly.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "PartialTypeWithSinglePart")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "RedundantNameQualifier")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "ArrangeModifiersOrder")]
    public unsafe static partial class libavutil
    {
        public const short AVPALETTE_SIZE = 1024;

        public const short AVPALETTE_COUNT = 256;

        /// <summary>
        /// Pixel format.
        /// </summary>
        /// <remark>
        /// AV_PIX_FMT_RGB32 is handled in an endian-specific manner. An RGBA
        /// color is put together as:
        /// (A &lt;&lt; 24) | (R &lt;&lt; 16) | (G &lt;&lt; 8) | B
        /// This is stored as BGRA on little-endian CPU architectures and ARGB on
        /// big-endian CPUs.
        /// 
        /// @par
        /// When the pixel format is palettized RGB32 (AV_PIX_FMT_PAL8), the
        /// palettized
        /// image data is stored in AVFrame.data[0]. The palette is transported in
        /// AVFrame.data[1], is 1024 bytes long (256 4-byte entries) and is
        /// formatted the same as in AV_PIX_FMT_RGB32 described above (i.e., it is
        /// also endian-specific). Note also that the individual RGB32 palette
        /// components stored in AVFrame.data[1] should be in the range 0..255.
        /// This is important as many custom PAL8 video codecs that were designed
        /// to run on the IBM VGA graphics adapter use 6-bit palette components.
        /// 
        /// @par
        /// For all the 8 bits per pixel formats, an RGB32 palette is in data[1]
        /// like
        /// for pal8. This palette is filled in automatically by the function
        /// allocating the picture.
        /// </remark>
        public enum AVPixelFormat
        {
            AV_PIX_FMT_NONE = -1,
            /// <summary>planar YUV 4:2:0, 12bpp, (1 Cr & Cb sample per 2x2 Y samples)</summary>
            AV_PIX_FMT_YUV420P = 0,
            /// <summary>packed YUV 4:2:2, 16bpp, Y0 Cb Y1 Cr</summary>
            AV_PIX_FMT_YUYV422 = 1,
            /// <summary>packed RGB 8:8:8, 24bpp, RGBRGB...</summary>
            AV_PIX_FMT_RGB24 = 2,
            /// <summary>packed RGB 8:8:8, 24bpp, BGRBGR...</summary>
            AV_PIX_FMT_BGR24 = 3,
            /// <summary>planar YUV 4:2:2, 16bpp, (1 Cr & Cb sample per 2x1 Y samples)</summary>
            AV_PIX_FMT_YUV422P = 4,
            /// <summary>planar YUV 4:4:4, 24bpp, (1 Cr & Cb sample per 1x1 Y samples)</summary>
            AV_PIX_FMT_YUV444P = 5,
            /// <summary>planar YUV 4:1:0, 9bpp, (1 Cr & Cb sample per 4x4 Y samples)</summary>
            AV_PIX_FMT_YUV410P = 6,
            /// <summary>planar YUV 4:1:1, 12bpp, (1 Cr & Cb sample per 4x1 Y samples)</summary>
            AV_PIX_FMT_YUV411P = 7,
            /// <summary>Y , 8bpp</summary>
            AV_PIX_FMT_GRAY8 = 8,
            /// <summary>Y , 1bpp, 0 is white, 1 is black, in each byte pixels are ordered from the msb to the lsb</summary>
            AV_PIX_FMT_MONOWHITE = 9,
            /// <summary>Y , 1bpp, 0 is black, 1 is white, in each byte pixels are ordered from the msb to the lsb</summary>
            AV_PIX_FMT_MONOBLACK = 10,
            /// <summary>8 bits with AV_PIX_FMT_RGB32 palette</summary>
            AV_PIX_FMT_PAL8 = 11,
            /// <summary>planar YUV 4:2:0, 12bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV420P and setting color_range</summary>
            AV_PIX_FMT_YUVJ420P = 12,
            /// <summary>planar YUV 4:2:2, 16bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV422P and setting color_range</summary>
            AV_PIX_FMT_YUVJ422P = 13,
            /// <summary>planar YUV 4:4:4, 24bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV444P and setting color_range</summary>
            AV_PIX_FMT_YUVJ444P = 14,
            /// <summary>XVideo Motion Acceleration via common packet passing</summary>
            AV_PIX_FMT_XVMC_MPEG2_MC = 15,
            AV_PIX_FMT_XVMC_MPEG2_IDCT = 16,
            /// <summary>packed YUV 4:2:2, 16bpp, Cb Y0 Cr Y1</summary>
            AV_PIX_FMT_UYVY422 = 17,
            /// <summary>packed YUV 4:1:1, 12bpp, Cb Y0 Y1 Cr Y2 Y3</summary>
            AV_PIX_FMT_UYYVYY411 = 18,
            /// <summary>packed RGB 3:3:2, 8bpp, (msb)2B 3G 3R(lsb)</summary>
            AV_PIX_FMT_BGR8 = 19,
            /// <summary>packed RGB 1:2:1 bitstream, 4bpp, (msb)1B 2G 1R(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits</summary>
            AV_PIX_FMT_BGR4 = 20,
            /// <summary>packed RGB 1:2:1, 8bpp, (msb)1B 2G 1R(lsb)</summary>
            AV_PIX_FMT_BGR4_BYTE = 21,
            /// <summary>packed RGB 3:3:2, 8bpp, (msb)2R 3G 3B(lsb)</summary>
            AV_PIX_FMT_RGB8 = 22,
            /// <summary>packed RGB 1:2:1 bitstream, 4bpp, (msb)1R 2G 1B(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits</summary>
            AV_PIX_FMT_RGB4 = 23,
            /// <summary>packed RGB 1:2:1, 8bpp, (msb)1R 2G 1B(lsb)</summary>
            AV_PIX_FMT_RGB4_BYTE = 24,
            /// <summary>planar YUV 4:2:0, 12bpp, 1 plane for Y and 1 plane for the UV components, which are interleaved (first byte U and the following byte V)</summary>
            AV_PIX_FMT_NV12 = 25,
            /// <summary>as above, but U and V bytes are swapped</summary>
            AV_PIX_FMT_NV21 = 26,
            /// <summary>packed ARGB 8:8:8:8, 32bpp, ARGBARGB...</summary>
            AV_PIX_FMT_ARGB = 27,
            /// <summary>packed RGBA 8:8:8:8, 32bpp, RGBARGBA...</summary>
            AV_PIX_FMT_RGBA = 28,
            /// <summary>packed ABGR 8:8:8:8, 32bpp, ABGRABGR...</summary>
            AV_PIX_FMT_ABGR = 29,
            /// <summary>packed BGRA 8:8:8:8, 32bpp, BGRABGRA...</summary>
            AV_PIX_FMT_BGRA = 30,
            /// <summary>Y , 16bpp, big-endian</summary>
            AV_PIX_FMT_GRAY16BE = 31,
            /// <summary>Y , 16bpp, little-endian</summary>
            AV_PIX_FMT_GRAY16LE = 32,
            /// <summary>planar YUV 4:4:0 (1 Cr & Cb sample per 1x2 Y samples)</summary>
            AV_PIX_FMT_YUV440P = 33,
            /// <summary>planar YUV 4:4:0 full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV440P and setting color_range</summary>
            AV_PIX_FMT_YUVJ440P = 34,
            /// <summary>planar YUV 4:2:0, 20bpp, (1 Cr & Cb sample per 2x2 Y & A samples)</summary>
            AV_PIX_FMT_YUVA420P = 35,
            /// <summary>H.264 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers</summary>
            AV_PIX_FMT_VDPAU_H264 = 36,
            /// <summary>MPEG-1 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers</summary>
            AV_PIX_FMT_VDPAU_MPEG1 = 37,
            /// <summary>MPEG-2 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers</summary>
            AV_PIX_FMT_VDPAU_MPEG2 = 38,
            /// <summary>WMV3 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers</summary>
            AV_PIX_FMT_VDPAU_WMV3 = 39,
            /// <summary>VC-1 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers</summary>
            AV_PIX_FMT_VDPAU_VC1 = 40,
            /// <summary>packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as big-endian</summary>
            AV_PIX_FMT_RGB48BE = 41,
            /// <summary>packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as little-endian</summary>
            AV_PIX_FMT_RGB48LE = 42,
            /// <summary>packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), big-endian</summary>
            AV_PIX_FMT_RGB565BE = 43,
            /// <summary>packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), little-endian</summary>
            AV_PIX_FMT_RGB565LE = 44,
            /// <summary>packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), big-endian , X=unused/undefined</summary>
            AV_PIX_FMT_RGB555BE = 45,
            /// <summary>packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), little-endian, X=unused/undefined</summary>
            AV_PIX_FMT_RGB555LE = 46,
            /// <summary>packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), big-endian</summary>
            AV_PIX_FMT_BGR565BE = 47,
            /// <summary>packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), little-endian</summary>
            AV_PIX_FMT_BGR565LE = 48,
            /// <summary>packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), big-endian , X=unused/undefined</summary>
            AV_PIX_FMT_BGR555BE = 49,
            /// <summary>packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), little-endian, X=unused/undefined</summary>
            AV_PIX_FMT_BGR555LE = 50,
            /// <summary>HW acceleration through VA API at motion compensation entry-point, Picture.data[3] contains a vaapi_render_state struct which contains macroblocks as well as various fields extracted from headers</summary>
            AV_PIX_FMT_VAAPI_MOCO = 51,
            /// <summary>HW acceleration through VA API at IDCT entry-point, Picture.data[3] contains a vaapi_render_state struct which contains fields extracted from headers</summary>
            AV_PIX_FMT_VAAPI_IDCT = 52,
            /// <summary>HW decoding through VA API, Picture.data[3] contains a VASurfaceID</summary>
            AV_PIX_FMT_VAAPI_VLD = 53,
            /// <summary>@}</summary>
            AV_PIX_FMT_VAAPI = 53,
            /// <summary>planar YUV 4:2:0, 24bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV420P16LE = 54,
            /// <summary>planar YUV 4:2:0, 24bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV420P16BE = 55,
            /// <summary>planar YUV 4:2:2, 32bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV422P16LE = 56,
            /// <summary>planar YUV 4:2:2, 32bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV422P16BE = 57,
            /// <summary>planar YUV 4:4:4, 48bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV444P16LE = 58,
            /// <summary>planar YUV 4:4:4, 48bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV444P16BE = 59,
            /// <summary>MPEG-4 HW decoding with VDPAU, data[0] contains a vdpau_render_state struct which contains the bitstream of the slices as well as various fields extracted from headers</summary>
            AV_PIX_FMT_VDPAU_MPEG4 = 60,
            /// <summary>HW decoding through DXVA2, Picture.data[3] contains a LPDIRECT3DSURFACE9 pointer</summary>
            AV_PIX_FMT_DXVA2_VLD = 61,
            /// <summary>packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), little-endian, X=unused/undefined</summary>
            AV_PIX_FMT_RGB444LE = 62,
            /// <summary>packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), big-endian, X=unused/undefined</summary>
            AV_PIX_FMT_RGB444BE = 63,
            /// <summary>packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), little-endian, X=unused/undefined</summary>
            AV_PIX_FMT_BGR444LE = 64,
            /// <summary>packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), big-endian, X=unused/undefined</summary>
            AV_PIX_FMT_BGR444BE = 65,
            /// <summary>8 bits gray, 8 bits alpha</summary>
            AV_PIX_FMT_YA8 = 66,
            /// <summary>alias for AV_PIX_FMT_YA8</summary>
            AV_PIX_FMT_Y400A = 66,
            /// <summary>alias for AV_PIX_FMT_YA8</summary>
            AV_PIX_FMT_GRAY8A = 66,
            /// <summary>packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as big-endian</summary>
            AV_PIX_FMT_BGR48BE = 67,
            /// <summary>packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as little-endian</summary>
            AV_PIX_FMT_BGR48LE = 68,
            /// <summary>planar YUV 4:2:0, 13.5bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV420P9BE = 69,
            /// <summary>planar YUV 4:2:0, 13.5bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV420P9LE = 70,
            /// <summary>planar YUV 4:2:0, 15bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV420P10BE = 71,
            /// <summary>planar YUV 4:2:0, 15bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV420P10LE = 72,
            /// <summary>planar YUV 4:2:2, 20bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV422P10BE = 73,
            /// <summary>planar YUV 4:2:2, 20bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV422P10LE = 74,
            /// <summary>planar YUV 4:4:4, 27bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV444P9BE = 75,
            /// <summary>planar YUV 4:4:4, 27bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV444P9LE = 76,
            /// <summary>planar YUV 4:4:4, 30bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV444P10BE = 77,
            /// <summary>planar YUV 4:4:4, 30bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV444P10LE = 78,
            /// <summary>planar YUV 4:2:2, 18bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV422P9BE = 79,
            /// <summary>planar YUV 4:2:2, 18bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV422P9LE = 80,
            /// <summary>hardware decoding through VDA</summary>
            AV_PIX_FMT_VDA_VLD = 81,
            /// <summary>planar GBR 4:4:4 24bpp</summary>
            AV_PIX_FMT_GBRP = 82,
            /// <summary>planar GBR 4:4:4 27bpp, big-endian</summary>
            AV_PIX_FMT_GBRP9BE = 83,
            /// <summary>planar GBR 4:4:4 27bpp, little-endian</summary>
            AV_PIX_FMT_GBRP9LE = 84,
            /// <summary>planar GBR 4:4:4 30bpp, big-endian</summary>
            AV_PIX_FMT_GBRP10BE = 85,
            /// <summary>planar GBR 4:4:4 30bpp, little-endian</summary>
            AV_PIX_FMT_GBRP10LE = 86,
            /// <summary>planar GBR 4:4:4 48bpp, big-endian</summary>
            AV_PIX_FMT_GBRP16BE = 87,
            /// <summary>planar GBR 4:4:4 48bpp, little-endian</summary>
            AV_PIX_FMT_GBRP16LE = 88,
            /// <summary>planar YUV 4:2:2 24bpp, (1 Cr & Cb sample per 2x1 Y & A samples)</summary>
            AV_PIX_FMT_YUVA422P = 89,
            /// <summary>planar YUV 4:4:4 32bpp, (1 Cr & Cb sample per 1x1 Y & A samples)</summary>
            AV_PIX_FMT_YUVA444P = 90,
            /// <summary>planar YUV 4:2:0 22.5bpp, (1 Cr & Cb sample per 2x2 Y & A samples), big-endian</summary>
            AV_PIX_FMT_YUVA420P9BE = 91,
            /// <summary>planar YUV 4:2:0 22.5bpp, (1 Cr & Cb sample per 2x2 Y & A samples), little-endian</summary>
            AV_PIX_FMT_YUVA420P9LE = 92,
            /// <summary>planar YUV 4:2:2 27bpp, (1 Cr & Cb sample per 2x1 Y & A samples), big-endian</summary>
            AV_PIX_FMT_YUVA422P9BE = 93,
            /// <summary>planar YUV 4:2:2 27bpp, (1 Cr & Cb sample per 2x1 Y & A samples), little-endian</summary>
            AV_PIX_FMT_YUVA422P9LE = 94,
            /// <summary>planar YUV 4:4:4 36bpp, (1 Cr & Cb sample per 1x1 Y & A samples), big-endian</summary>
            AV_PIX_FMT_YUVA444P9BE = 95,
            /// <summary>planar YUV 4:4:4 36bpp, (1 Cr & Cb sample per 1x1 Y & A samples), little-endian</summary>
            AV_PIX_FMT_YUVA444P9LE = 96,
            /// <summary>planar YUV 4:2:0 25bpp, (1 Cr & Cb sample per 2x2 Y & A samples, big-endian)</summary>
            AV_PIX_FMT_YUVA420P10BE = 97,
            /// <summary>planar YUV 4:2:0 25bpp, (1 Cr & Cb sample per 2x2 Y & A samples, little-endian)</summary>
            AV_PIX_FMT_YUVA420P10LE = 98,
            /// <summary>planar YUV 4:2:2 30bpp, (1 Cr & Cb sample per 2x1 Y & A samples, big-endian)</summary>
            AV_PIX_FMT_YUVA422P10BE = 99,
            /// <summary>planar YUV 4:2:2 30bpp, (1 Cr & Cb sample per 2x1 Y & A samples, little-endian)</summary>
            AV_PIX_FMT_YUVA422P10LE = 100,
            /// <summary>planar YUV 4:4:4 40bpp, (1 Cr & Cb sample per 1x1 Y & A samples, big-endian)</summary>
            AV_PIX_FMT_YUVA444P10BE = 101,
            /// <summary>planar YUV 4:4:4 40bpp, (1 Cr & Cb sample per 1x1 Y & A samples, little-endian)</summary>
            AV_PIX_FMT_YUVA444P10LE = 102,
            /// <summary>planar YUV 4:2:0 40bpp, (1 Cr & Cb sample per 2x2 Y & A samples, big-endian)</summary>
            AV_PIX_FMT_YUVA420P16BE = 103,
            /// <summary>planar YUV 4:2:0 40bpp, (1 Cr & Cb sample per 2x2 Y & A samples, little-endian)</summary>
            AV_PIX_FMT_YUVA420P16LE = 104,
            /// <summary>planar YUV 4:2:2 48bpp, (1 Cr & Cb sample per 2x1 Y & A samples, big-endian)</summary>
            AV_PIX_FMT_YUVA422P16BE = 105,
            /// <summary>planar YUV 4:2:2 48bpp, (1 Cr & Cb sample per 2x1 Y & A samples, little-endian)</summary>
            AV_PIX_FMT_YUVA422P16LE = 106,
            /// <summary>planar YUV 4:4:4 64bpp, (1 Cr & Cb sample per 1x1 Y & A samples, big-endian)</summary>
            AV_PIX_FMT_YUVA444P16BE = 107,
            /// <summary>planar YUV 4:4:4 64bpp, (1 Cr & Cb sample per 1x1 Y & A samples, little-endian)</summary>
            AV_PIX_FMT_YUVA444P16LE = 108,
            /// <summary>HW acceleration through VDPAU, Picture.data[3] contains a VdpVideoSurface</summary>
            AV_PIX_FMT_VDPAU = 109,
            /// <summary>packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as little-endian, the 4 lower bits are set to 0</summary>
            AV_PIX_FMT_XYZ12LE = 110,
            /// <summary>packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as big-endian, the 4 lower bits are set to 0</summary>
            AV_PIX_FMT_XYZ12BE = 111,
            /// <summary>interleaved chroma YUV 4:2:2, 16bpp, (1 Cr & Cb sample per 2x1 Y samples)</summary>
            AV_PIX_FMT_NV16 = 112,
            /// <summary>interleaved chroma YUV 4:2:2, 20bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian</summary>
            AV_PIX_FMT_NV20LE = 113,
            /// <summary>interleaved chroma YUV 4:2:2, 20bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian</summary>
            AV_PIX_FMT_NV20BE = 114,
            /// <summary>packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian</summary>
            AV_PIX_FMT_RGBA64BE = 115,
            /// <summary>packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian</summary>
            AV_PIX_FMT_RGBA64LE = 116,
            /// <summary>packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian</summary>
            AV_PIX_FMT_BGRA64BE = 117,
            /// <summary>packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian</summary>
            AV_PIX_FMT_BGRA64LE = 118,
            /// <summary>packed YUV 4:2:2, 16bpp, Y0 Cr Y1 Cb</summary>
            AV_PIX_FMT_YVYU422 = 119,
            /// <summary>HW acceleration through VDA, data[3] contains a CVPixelBufferRef</summary>
            AV_PIX_FMT_VDA = 120,
            /// <summary>16 bits gray, 16 bits alpha (big-endian)</summary>
            AV_PIX_FMT_YA16BE = 121,
            /// <summary>16 bits gray, 16 bits alpha (little-endian)</summary>
            AV_PIX_FMT_YA16LE = 122,
            /// <summary>planar GBRA 4:4:4:4 32bpp</summary>
            AV_PIX_FMT_GBRAP = 123,
            /// <summary>planar GBRA 4:4:4:4 64bpp, big-endian</summary>
            AV_PIX_FMT_GBRAP16BE = 124,
            /// <summary>planar GBRA 4:4:4:4 64bpp, little-endian</summary>
            AV_PIX_FMT_GBRAP16LE = 125,
            /// <summary>HW acceleration through QSV, data[3] contains a pointer to the mfxFrameSurface1 structure.</summary>
            AV_PIX_FMT_QSV = 126,
            /// <summary>HW acceleration though MMAL, data[3] contains a pointer to the MMAL_BUFFER_HEADER_T structure.</summary>
            AV_PIX_FMT_MMAL = 127,
            /// <summary>HW decoding through Direct3D11, Picture.data[3] contains a ID3D11VideoDecoderOutputView pointer</summary>
            AV_PIX_FMT_D3D11VA_VLD = 128,
            /// <summary>HW acceleration through CUDA. data[i] contain CUdeviceptr pointers exactly as for system memory frames.</summary>
            AV_PIX_FMT_CUDA = 129,
            /// <summary>packed RGB 8:8:8, 32bpp, XRGBXRGB... X=unused/undefined</summary>
            AV_PIX_FMT_0RGB = 295,
            /// <summary>packed RGB 8:8:8, 32bpp, RGBXRGBX... X=unused/undefined</summary>
            AV_PIX_FMT_RGB0 = 296,
            /// <summary>packed BGR 8:8:8, 32bpp, XBGRXBGR... X=unused/undefined</summary>
            AV_PIX_FMT_0BGR = 297,
            /// <summary>packed BGR 8:8:8, 32bpp, BGRXBGRX... X=unused/undefined</summary>
            AV_PIX_FMT_BGR0 = 298,
            /// <summary>planar YUV 4:2:0,18bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV420P12BE = 299,
            /// <summary>planar YUV 4:2:0,18bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV420P12LE = 300,
            /// <summary>planar YUV 4:2:0,21bpp, (1 Cr & Cb sample per 2x2 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV420P14BE = 301,
            /// <summary>planar YUV 4:2:0,21bpp, (1 Cr & Cb sample per 2x2 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV420P14LE = 302,
            /// <summary>planar YUV 4:2:2,24bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV422P12BE = 303,
            /// <summary>planar YUV 4:2:2,24bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV422P12LE = 304,
            /// <summary>planar YUV 4:2:2,28bpp, (1 Cr & Cb sample per 2x1 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV422P14BE = 305,
            /// <summary>planar YUV 4:2:2,28bpp, (1 Cr & Cb sample per 2x1 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV422P14LE = 306,
            /// <summary>planar YUV 4:4:4,36bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV444P12BE = 307,
            /// <summary>planar YUV 4:4:4,36bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV444P12LE = 308,
            /// <summary>planar YUV 4:4:4,42bpp, (1 Cr & Cb sample per 1x1 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV444P14BE = 309,
            /// <summary>planar YUV 4:4:4,42bpp, (1 Cr & Cb sample per 1x1 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV444P14LE = 310,
            /// <summary>planar GBR 4:4:4 36bpp, big-endian</summary>
            AV_PIX_FMT_GBRP12BE = 311,
            /// <summary>planar GBR 4:4:4 36bpp, little-endian</summary>
            AV_PIX_FMT_GBRP12LE = 312,
            /// <summary>planar GBR 4:4:4 42bpp, big-endian</summary>
            AV_PIX_FMT_GBRP14BE = 313,
            /// <summary>planar GBR 4:4:4 42bpp, little-endian</summary>
            AV_PIX_FMT_GBRP14LE = 314,
            /// <summary>planar YUV 4:1:1, 12bpp, (1 Cr & Cb sample per 4x1 Y samples) full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV411P and setting color_range</summary>
            AV_PIX_FMT_YUVJ411P = 315,
            /// <summary>bayer, BGBG..(odd line), GRGR..(even line), 8-bit samples */</summary>
            AV_PIX_FMT_BAYER_BGGR8 = 316,
            /// <summary>bayer, RGRG..(odd line), GBGB..(even line), 8-bit samples */</summary>
            AV_PIX_FMT_BAYER_RGGB8 = 317,
            /// <summary>bayer, GBGB..(odd line), RGRG..(even line), 8-bit samples */</summary>
            AV_PIX_FMT_BAYER_GBRG8 = 318,
            /// <summary>bayer, GRGR..(odd line), BGBG..(even line), 8-bit samples */</summary>
            AV_PIX_FMT_BAYER_GRBG8 = 319,
            /// <summary>bayer, BGBG..(odd line), GRGR..(even line), 16-bit samples, little-endian */</summary>
            AV_PIX_FMT_BAYER_BGGR16LE = 320,
            /// <summary>bayer, BGBG..(odd line), GRGR..(even line), 16-bit samples, big-endian */</summary>
            AV_PIX_FMT_BAYER_BGGR16BE = 321,
            /// <summary>bayer, RGRG..(odd line), GBGB..(even line), 16-bit samples, little-endian */</summary>
            AV_PIX_FMT_BAYER_RGGB16LE = 322,
            /// <summary>bayer, RGRG..(odd line), GBGB..(even line), 16-bit samples, big-endian */</summary>
            AV_PIX_FMT_BAYER_RGGB16BE = 323,
            /// <summary>bayer, GBGB..(odd line), RGRG..(even line), 16-bit samples, little-endian */</summary>
            AV_PIX_FMT_BAYER_GBRG16LE = 324,
            /// <summary>bayer, GBGB..(odd line), RGRG..(even line), 16-bit samples, big-endian */</summary>
            AV_PIX_FMT_BAYER_GBRG16BE = 325,
            /// <summary>bayer, GRGR..(odd line), BGBG..(even line), 16-bit samples, little-endian */</summary>
            AV_PIX_FMT_BAYER_GRBG16LE = 326,
            /// <summary>bayer, GRGR..(odd line), BGBG..(even line), 16-bit samples, big-endian */</summary>
            AV_PIX_FMT_BAYER_GRBG16BE = 327,
            /// <summary>planar YUV 4:4:0,20bpp, (1 Cr & Cb sample per 1x2 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV440P10LE = 328,
            /// <summary>planar YUV 4:4:0,20bpp, (1 Cr & Cb sample per 1x2 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV440P10BE = 329,
            /// <summary>planar YUV 4:4:0,24bpp, (1 Cr & Cb sample per 1x2 Y samples), little-endian</summary>
            AV_PIX_FMT_YUV440P12LE = 330,
            /// <summary>planar YUV 4:4:0,24bpp, (1 Cr & Cb sample per 1x2 Y samples), big-endian</summary>
            AV_PIX_FMT_YUV440P12BE = 331,
            /// <summary>packed AYUV 4:4:4,64bpp (1 Cr & Cb sample per 1x1 Y & A samples), little-endian</summary>
            AV_PIX_FMT_AYUV64LE = 332,
            /// <summary>packed AYUV 4:4:4,64bpp (1 Cr & Cb sample per 1x1 Y & A samples), big-endian</summary>
            AV_PIX_FMT_AYUV64BE = 333,
            /// <summary>hardware decoding through Videotoolbox</summary>
            AV_PIX_FMT_VIDEOTOOLBOX = 334,
            /// <summary>like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, little-endian</summary>
            AV_PIX_FMT_P010LE = 335,
            /// <summary>like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, big-endian</summary>
            AV_PIX_FMT_P010BE = 336,
            /// <summary>planar GBR 4:4:4:4 48bpp, big-endian</summary>
            AV_PIX_FMT_GBRAP12BE = 337,
            /// <summary>planar GBR 4:4:4:4 48bpp, little-endian</summary>
            AV_PIX_FMT_GBRAP12LE = 338,
            /// <summary>planar GBR 4:4:4:4 40bpp, big-endian</summary>
            AV_PIX_FMT_GBRAP10BE = 339,
            /// <summary>planar GBR 4:4:4:4 40bpp, little-endian</summary>
            AV_PIX_FMT_GBRAP10LE = 340,
            /// <summary>number of pixel formats, DO NOT USE THIS if you want to link with shared libav* because the number of formats might differ between versions</summary>
            AV_PIX_FMT_NB = 341
        }

        /// <summary>
        /// Chromaticity coordinates of the source primaries.
        /// </summary>
        public enum AVColorPrimaries
        {
            AVCOL_PRI_RESERVED0 = 0,
            /// <summary>also ITU-R BT1361 / IEC 61966-2-4 / SMPTE RP177 Annex B</summary>
            AVCOL_PRI_BT709 = 1,
            AVCOL_PRI_UNSPECIFIED = 2,
            AVCOL_PRI_RESERVED = 3,
            /// <summary>also FCC Title 47 Code of Federal Regulations 73.682 (a)(20)</summary>
            AVCOL_PRI_BT470M = 4,
            /// <summary>also ITU-R BT601-6 625 / ITU-R BT1358 625 / ITU-R BT1700 625 PAL & SECAM</summary>
            AVCOL_PRI_BT470BG = 5,
            /// <summary>also ITU-R BT601-6 525 / ITU-R BT1358 525 / ITU-R BT1700 NTSC</summary>
            AVCOL_PRI_SMPTE170M = 6,
            /// <summary>functionally identical to above</summary>
            AVCOL_PRI_SMPTE240M = 7,
            /// <summary>colour filters using Illuminant C</summary>
            AVCOL_PRI_FILM = 8,
            /// <summary>ITU-R BT2020</summary>
            AVCOL_PRI_BT2020 = 9,
            /// <summary>SMPTE ST 428-1 (CIE 1931 XYZ)</summary>
            AVCOL_PRI_SMPTEST428_1 = 10,
            /// <summary>Not part of ABI</summary>
            AVCOL_PRI_NB = 11
        }

        /// <summary>
        /// Color Transfer Characteristic.
        /// </summary>
        public enum AVColorTransferCharacteristic
        {
            AVCOL_TRC_RESERVED0 = 0,
            /// <summary>also ITU-R BT1361</summary>
            AVCOL_TRC_BT709 = 1,
            AVCOL_TRC_UNSPECIFIED = 2,
            AVCOL_TRC_RESERVED = 3,
            /// <summary>also ITU-R BT470M / ITU-R BT1700 625 PAL & SECAM</summary>
            AVCOL_TRC_GAMMA22 = 4,
            /// <summary>also ITU-R BT470BG</summary>
            AVCOL_TRC_GAMMA28 = 5,
            /// <summary>also ITU-R BT601-6 525 or 625 / ITU-R BT1358 525 or 625 / ITU-R BT1700 NTSC</summary>
            AVCOL_TRC_SMPTE170M = 6,
            AVCOL_TRC_SMPTE240M = 7,
            /// <summary>"Linear transfer characteristics"</summary>
            AVCOL_TRC_LINEAR = 8,
            /// <summary>"Logarithmic transfer characteristic (100:1 range)"</summary>
            AVCOL_TRC_LOG = 9,
            /// <summary>"Logarithmic transfer characteristic (100 * Sqrt(10) : 1 range)"</summary>
            AVCOL_TRC_LOG_SQRT = 10,
            /// <summary>IEC 61966-2-4</summary>
            AVCOL_TRC_IEC61966_2_4 = 11,
            /// <summary>ITU-R BT1361 Extended Colour Gamut</summary>
            AVCOL_TRC_BT1361_ECG = 12,
            /// <summary>IEC 61966-2-1 (sRGB or sYCC)</summary>
            AVCOL_TRC_IEC61966_2_1 = 13,
            /// <summary>ITU-R BT2020 for 10-bit system</summary>
            AVCOL_TRC_BT2020_10 = 14,
            /// <summary>ITU-R BT2020 for 12-bit system</summary>
            AVCOL_TRC_BT2020_12 = 15,
            /// <summary>SMPTE ST 2084 for 10-, 12-, 14- and 16-bit systems</summary>
            AVCOL_TRC_SMPTEST2084 = 16,
            /// <summary>SMPTE ST 428-1</summary>
            AVCOL_TRC_SMPTEST428_1 = 17,
            /// <summary>ARIB STD-B67, known as "Hybrid log-gamma"</summary>
            AVCOL_TRC_ARIB_STD_B67 = 18,
            /// <summary>Not part of ABI</summary>
            AVCOL_TRC_NB = 19
        }

        /// <summary>
        /// YUV colorspace type.
        /// </summary>
        public enum AVColorSpace
        {
            /// <summary>order of coefficients is actually GBR, also IEC 61966-2-1 (sRGB)</summary>
            AVCOL_SPC_RGB = 0,
            /// <summary>also ITU-R BT1361 / IEC 61966-2-4 xvYCC709 / SMPTE RP177 Annex B</summary>
            AVCOL_SPC_BT709 = 1,
            AVCOL_SPC_UNSPECIFIED = 2,
            AVCOL_SPC_RESERVED = 3,
            /// <summary>FCC Title 47 Code of Federal Regulations 73.682 (a)(20)</summary>
            AVCOL_SPC_FCC = 4,
            /// <summary>also ITU-R BT601-6 625 / ITU-R BT1358 625 / ITU-R BT1700 625 PAL & SECAM / IEC 61966-2-4 xvYCC601</summary>
            AVCOL_SPC_BT470BG = 5,
            /// <summary>also ITU-R BT601-6 525 / ITU-R BT1358 525 / ITU-R BT1700 NTSC</summary>
            AVCOL_SPC_SMPTE170M = 6,
            /// <summary>functionally identical to above</summary>
            AVCOL_SPC_SMPTE240M = 7,
            /// <summary>Used by Dirac / VC-2 and H.264 FRext, see ITU-T SG16</summary>
            AVCOL_SPC_YCOCG = 8,
            /// <summary>ITU-R BT2020 non-constant luminance system</summary>
            AVCOL_SPC_BT2020_NCL = 9,
            /// <summary>ITU-R BT2020 constant luminance system</summary>
            AVCOL_SPC_BT2020_CL = 10,
            /// <summary>Not part of ABI</summary>
            AVCOL_SPC_NB = 11
        }

        /// <summary>
        /// MPEG vs JPEG YUV range.
        /// </summary>
        public enum AVColorRange
        {
            AVCOL_RANGE_UNSPECIFIED = 0,
            /// <summary>the normal 219*2^(n-8) "MPEG" YUV ranges</summary>
            AVCOL_RANGE_MPEG = 1,
            /// <summary>the normal 2^n-1 "JPEG" YUV ranges</summary>
            AVCOL_RANGE_JPEG = 2,
            /// <summary>Not part of ABI</summary>
            AVCOL_RANGE_NB = 3
        }

        /// <summary>
        /// Location of chroma samples.
        /// 
        /// Illustration showing the location of the first (top left) chroma sample
        /// of the
        /// image, the left shows only luma, the right
        /// shows the location of the chroma sample, the 2 could be imagined to
        /// overlay
        /// each other but are drawn separately due to limitations of ASCII
        /// 
        /// 1st 2nd       1st 2nd horizontal luma sample positions
        /// v   v         v   v
        /// ______        ______
        /// 1st luma line &gt; |X   X ...    |3 4 X ...     X are luma samples,
        /// |             |1 2           1-6 are possible chroma positions
        /// 2nd luma line &gt; |X   X ...    |5 6 X ...     0 is undefined/unknown
        /// position
        /// </summary>
        public enum AVChromaLocation
        {
            AVCHROMA_LOC_UNSPECIFIED = 0,
            /// <summary>MPEG-2/4 4:2:0, H.264 default for 4:2:0</summary>
            AVCHROMA_LOC_LEFT = 1,
            /// <summary>MPEG-1 4:2:0, JPEG 4:2:0, H.263 4:2:0</summary>
            AVCHROMA_LOC_CENTER = 2,
            /// <summary>ITU-R 601, SMPTE 274M 296M S314M(DV 4:1:1), mpeg2 4:2:2</summary>
            AVCHROMA_LOC_TOPLEFT = 3,
            AVCHROMA_LOC_TOP = 4,
            AVCHROMA_LOC_BOTTOMLEFT = 5,
            AVCHROMA_LOC_BOTTOM = 6,
            /// <summary>Not part of ABI</summary>
            AVCHROMA_LOC_NB = 7
        }
    }
}