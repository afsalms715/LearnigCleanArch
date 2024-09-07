using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application
{
    public class MemberServices:IMemberServices
    {
        private readonly IMemberRepository _memberRepository;
        public MemberServices(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public List<Domain.Member> GetAllMembers()
        {
            return _memberRepository.GetAllMembers();
        }
    }
}
