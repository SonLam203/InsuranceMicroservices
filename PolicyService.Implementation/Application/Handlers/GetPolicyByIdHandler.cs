using MediatR;
using PolicyService.Implementation.Application.DTOs;

public class GetPolicyByIdHandler : IRequestHandler<GetPolicyByIdQuery, PolicyDto>
{
    public Task<PolicyDto> Handle(GetPolicyByIdQuery request, CancellationToken cancellationToken)
    {
        // Giả lập dữ liệu
        return Task.FromResult(new PolicyDto
        {
            Id = request.PolicyId,
            CustomerName = "Nguyen Van A",
            Price = 2500000
        });
    }
}