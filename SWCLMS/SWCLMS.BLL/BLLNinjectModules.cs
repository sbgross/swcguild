using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using SWCLMS.Data.Mocks;
using SWCLMS.Data.SQL;
using SWCLMS.Models.Interfaces;
using SWCLMS.Data;

namespace SWCLMS.BLL
{
    public class MockNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILmsUserRepository>().To<MockLmsUserRepository>();
        }
    }

    public class SqlNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILmsUserRepository>().To<SqlLmsUserRepository>();
        }
    }

    public class DependencyLoader
    {
        public static NinjectModule LoadModule()
        {
            if(Settings.GetMode() == "SQL")
                return new SqlNinjectModule();

            return new SqlNinjectModule();
        }
    }

}
