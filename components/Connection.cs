using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBFP.components
{
    class Connection
    {
        public string conString = String.Format("datasource={0};port={1};username={2};password={3}",
            Values.server_address, Values.server_port, Values.server_username, Values.server_password);
    }
}
