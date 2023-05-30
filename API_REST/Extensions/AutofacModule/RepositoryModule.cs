using Autofac;
using _u = UnitOfWork;

namespace API_REST.Extensions.AutofacModule
{
    public class RepositoryModule: Module
    {
        private readonly IConfiguration _configuration;
        public RepositoryModule(IConfiguration configuration) => _configuration = configuration;
        
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new _u.UnitOfWork(_configuration)).As<_u.IUnitOfWork>();
        }
    }
}
