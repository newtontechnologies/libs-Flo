using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Flo
{
    public interface IHandler<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TIn, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TOut>
    {
        Task<TOut> HandleAsync(TIn input, Func<TIn, Task<TOut>> next);
    }

    public interface IHandler<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T> : IHandler<T, T>
    {
    }
}
