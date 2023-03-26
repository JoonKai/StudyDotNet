﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncBasicThread.Utils
{
    public delegate void FileProgressDelegate(string currentUnits, string totalUnits, int percentage);
    public class FileUtils
    {
        public static void Copy(string sourceFile, string destFIle, FileProgressDelegate fileProgress = null)
        {
            using(FileStream sourceStream = new(sourceFile, FileMode.Open))
            using(FileStream destStream = new(destFIle, FileMode.Create))
            {
                long fileSize = sourceStream.Length;
                int bufferSize = 1024 * 1024;
                byte[] buffer = new byte[bufferSize];

                int read;
                decimal totalRead = 0;

                while ((read = sourceStream.Read(buffer,0,bufferSize)) > 0)
                {
                    destStream.Write(buffer, 0, read);
                    totalRead += read;
                    if(fileProgress != null)
                    {
                        var currentUnits = ConvertUtils.AutoConvertBytes(totalRead);
                        var totalUnits = ConvertUtils.AutoConvertBytes(fileSize);
                        int percentage = (int)((totalRead / fileSize) * 100);
                        fileProgress.Invoke(currentUnits, totalUnits, percentage);
                    }
                }
            }
        }
    }
}
