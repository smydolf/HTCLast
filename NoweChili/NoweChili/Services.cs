
using ChiliService;
using ClassLibrary1;

namespace NoweChili
{
    public static class Services
    {
        private static HtcAplicationContext htcAplicationContext = new HtcAplicationContext();
        public static ProductService productService = new ProductService(htcAplicationContext);
        public static UserService userService = new UserService(htcAplicationContext);
        public static TransportService transportService = new TransportService(htcAplicationContext);

    }
}
