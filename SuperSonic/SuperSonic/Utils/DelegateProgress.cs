using System;

namespace SuperSonic.Utils;

internal class DelegateProgress<T>(Action<T> report) : IProgress<T>
{
    public void Report(T value) => report(value);
}
