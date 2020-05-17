using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CMASTConnect.DataAccess
{
    class CMASTConnectContext : DbContext
    {
        public CMASTConnectContext(DbContextOptions<CMASTConnectContext> options) :
            base(options)
        {

        }
    }
}
