using System;
using System.IO;

namespace SuperSonic.Utils;

internal static class PathEx
{
    public static string SanitizeFileName(String fileName, Char replacement = '_')
    {
        foreach (Char invalidChar in Path.GetInvalidFileNameChars())
            fileName = fileName.Replace(invalidChar, replacement);

        return fileName;
    }
}
