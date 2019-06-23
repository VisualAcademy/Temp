using System.Threading.Tasks;
using Arithmetic;
using Grpc.Core;

namespace RpcService.Server
{
    public class ArithmeticServer : ArithmeticService.ArithmeticServiceBase
    {
        public override Task<ResponseMessage> Add(RequestMessage request, ServerCallContext context)
        {
            ResponseMessage r = new ResponseMessage();

            r.Result = request.First + request.Second;

            return Task.FromResult(r);
        }

        public override Task<ResponseMessage> Subtract(RequestMessage request, ServerCallContext context)
        {
            ResponseMessage r = new ResponseMessage();

            r.Result = request.First - request.Second;

            return Task.FromResult(r);
        }
    }
}
