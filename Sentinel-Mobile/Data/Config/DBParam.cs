using System;

using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace Sentinel_Mobile.Data.Config
{
    class DBParam
    {
        public static String DB_NAME;

        public static void initDBString()
        {
            string StartupPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            string datalogicFilePath = Path.Combine(StartupPath, "Data\\Cache\\cache.sdf");
            DB_NAME = string.Format("DataSource={0}", datalogicFilePath);
        }
    }
}
