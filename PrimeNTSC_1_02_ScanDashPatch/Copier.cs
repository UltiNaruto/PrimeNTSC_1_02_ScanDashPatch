using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeNTSC_1_02_ScanDashPatch
{
    static class Copier
    {
        static readonly int BUFFER_SIZE = 4096;
        public static void CopyOneFile(String src, String dst, Action<int> progressCallback)
        {
            byte[] buf = new byte[BUFFER_SIZE];
            int i;
            using (var outStream = new FileStream(dst, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var inStream = new FileStream(src, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    while (outStream.Position < inStream.Length)
                    {
                        for (i = 0; i < BUFFER_SIZE; i++) buf[i] = 0;
                        inStream.Read(buf, 0, BUFFER_SIZE);
                        outStream.Write(buf, 0, BUFFER_SIZE);
                        progressCallback((int)((outStream.Position * 100) / inStream.Length));
                    }
                }
            }
        }

        public static async Task CopyFiles(Dictionary<string, string> files, Action<int> progressCallback)
        {
            for (var x = 0; x < files.Count; x++)
            {
                var item = files.ElementAt(x);
                var from = item.Key;
                var to = item.Value;

                using (var outStream = new FileStream(to, FileMode.Create, FileAccess.Write, FileShare.Read))
                {
                    using (var inStream = new FileStream(from, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        await inStream.CopyToAsync(outStream);
                    }
                }

                progressCallback((int)((x + 1) / files.Count) * 100);
            }
        }
    }
}
