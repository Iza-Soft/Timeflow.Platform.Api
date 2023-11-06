using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Infrastructure.Specifications.Interface;

namespace Timeflow.Platform.Infrastructure.Specifications.Project
{
    internal class GetProjectByUserId : BaseSpecification<ProjectEntity>
    {
        public GetProjectByUserId(Guid userId) : base(x => x.Id.ToString() == userId.ToString()) { }

        //public GetEmployerByEmailAndReference(string email, string reference)
        //    : base(x => x.CompanyEmailAddress.ToLower() == email.ToLower() && x.CompanyReference.ToLower() == reference.ToLower())
        //{

        //}
    }
}
