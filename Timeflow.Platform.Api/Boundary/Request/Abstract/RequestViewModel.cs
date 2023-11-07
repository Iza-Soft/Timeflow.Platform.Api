namespace Timeflow.Platform.Api.Boundary.Request.Abstract
{
    public abstract class RequestViewModel
    {
        public virtual string RequestId => new HttpContextAccessor().HttpContext!.TraceIdentifier;
    }
}
