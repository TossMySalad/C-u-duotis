using System;
using System.Collections.Generic;
using System.Text;

namespace sqlmapautoLIB
{
    public interface ISqlmapSession : IDisposable
    {
        string ExecuteGet(string url);

        string ExecutePost(string url, string data);
    }
}
