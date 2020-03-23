using System;
using System.Collections.Generic;
using System.Text;
using Google.Protobuf;

namespace Tron.Protocol.Common
{
    class ClientStreams
    {
        public CodedInputStream InputStream { get; set; }

        public CodedOutputStream OutputStream { get; set; }
    }
}
