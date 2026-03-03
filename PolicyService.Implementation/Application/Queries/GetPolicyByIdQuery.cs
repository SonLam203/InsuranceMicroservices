using MediatR;
using PolicyService.Implementation.Application.DTOs;

public class GetPolicyByIdQuery : IRequest<PolicyDto>
{
    public Guid PolicyId { get; }

    public GetPolicyByIdQuery(Guid policyId)
    {
        PolicyId = policyId;
    }
}