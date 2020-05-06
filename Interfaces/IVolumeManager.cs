using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Enkonos.Interfaces
{
    public interface IVolumeManager
    {
        bool ChangeVolume(long value);
    }
}
